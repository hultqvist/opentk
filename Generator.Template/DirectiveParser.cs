using System;
using System.Collections.Generic;
using System.IO;

namespace Generator.Template
{
    /// <summary>
    /// Parse file line by line and apply and remove local #if directives
    /// </summary>
    class DirectiveParser
    {
        readonly List<string> locals;
        readonly List<string> include;

        /// <summary>
        /// Whether code on the current level should be included
        /// </summary>
        Stack<bool> stackInclude = new Stack<bool>(); //true if we are to include it in the output
        Stack<bool> stackLocal = new Stack<bool>(); //if a local #if statement == remove from code
        bool currentInclude = true;
        bool currentLocal = false;

        public DirectiveParser(List<string> local, List<string> defined)
        {
            this.locals = local;
            this.include = defined;
        }

        /// <summary>
        /// Return true if the line is to be written to the output file
        /// </summary>
        public bool Parse(string line)
        {
            string d = line.Trim();

            if (d.StartsWith("#if "))
            {
                d = d.Substring(4).Trim();
                bool not = d.StartsWith("!");
                if(not)
                    d = d.Substring(1);

                //Push
                stackInclude.Push(currentInclude);
                stackLocal.Push(currentLocal);

                currentLocal = locals.Contains(d);
                if (currentLocal)
                {
                    if (include.Contains(d) == not)
                        currentInclude = false;
                    return false; //hide local directives
                }
                return currentInclude;
            }
            if (d.StartsWith("#elif "))
            {
                d = d.Substring(6).Trim();
                bool not = d.StartsWith("!");
                if(not)
                    d = d.Substring(1);
                //Stack is untouched

                if (stackInclude.Peek() == false)
                    return false;

                if(currentLocal != locals.Contains(d))
                    throw new NotImplementedException("this parser does not support mixed local and non local variables in #if, #elif");

                if (currentLocal)
                {
                    if(include.Contains(d) && !not)
                        currentInclude = true;
                    else
                        currentInclude = false;
                    return false;
                }
                return currentInclude;
            }
            if (d.StartsWith("#else"))
            {
                //Stack is untouched

                if (stackInclude.Peek() == false)
                    return false;

                if (currentLocal)
                {
                    currentInclude = !currentInclude;
                    return false;
                }
                return currentInclude;
            }
            if (d.StartsWith("#endif"))
            {
                //Pop
                bool includeEndif = currentLocal == false;
                currentInclude = stackInclude.Pop();
                currentLocal = stackLocal.Pop();
                if(currentInclude == false)
                    return false;
                return includeEndif;
            }
            return currentInclude;
        }

        public void Finish()
        {
            if (stackLocal.Count != 0)
                throw new InvalidDataException("Non matching #if #endif directives");
            if (stackInclude.Count != 0)
                throw new InvalidDataException("Non matching #if #endif directives");
        }

    }
}

