using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Generator.Template
{
    /// <summary>
    /// Generate Vector[234][dih].cs based on VectorTemplate.cs
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// Template local #define
        /// </summary>
        static List<string> local = new List<string>(){
            "TEMPLATE_DIM_3",
            "TEMPLATE_DIM_4",
            "TEMPLATE_UNIT_DOUBLE",
            "TEMPLATE_UNIT_SINGLE",
            "TEMPLATE_UNIT_INT32",
            "TEMPLATE_UNIT_HALF",
        };
        static string basePath = ".." + Path.DirectorySeparatorChar +
                ".." + Path.DirectorySeparatorChar +
                ".." + Path.DirectorySeparatorChar +
                "OpenTK" + Path.DirectorySeparatorChar +
                "Math" + Path.DirectorySeparatorChar;
            
        public static void Main(string[] args)
        {
            Console.WriteLine("Template Generator");
                
            GenerateFromTemplate("Vector", new int[]{2,3,4}, new string[]{"d","","h","i"});
            GenerateFromTemplate("Matrix", new int[]{3,4}, new string[]{"d",""});
            GenerateFromTemplate("Quaternion", new int[]{0}, new string[]{"d",""});
        }

        static void GenerateFromTemplate(string baseName, int[] dimensions, string[] suffixes)
        {
            //Read template
            string[] template = File.ReadAllLines(
                Path.Combine(basePath, baseName + "Template.cs"),
                Encoding.UTF8
            );

            //Generate code
            foreach (int d in dimensions)
            {
                string ds = (d == 0 ? "": d.ToString());

                foreach (string s in suffixes)
                {
                    string filename = baseName + ds + s + ".cs";
                    Console.WriteLine("Generating " + filename);
                    using (TextWriter w = new StreamWriter(Path.Combine(basePath, filename), false, Encoding.UTF8))
                        GenerateFile(template, baseName, d, s, w);
                }
            }
        }

        static void GenerateFile(string[] template, string classBase, int dimension, string suffix, TextWriter w)
        {
            w.WriteLine("// Generated by Generator.Template using template Math/" + classBase + "Template.cs");
            w.WriteLine();

            List<string> include = new List<string>();

            if (dimension >= 3)
                include.Add("TEMPLATE_DIM_3");
            if (dimension >= 4)
                include.Add("TEMPLATE_DIM_4");

            string templateClass = classBase + "Template";
            string targetClass = classBase + (dimension == 0 ? "": dimension.ToString());

            if (suffix == "d")
            {
                include.Add("TEMPLATE_UNIT_DOUBLE");
                targetClass += "d";
            }
            if (suffix == "")
            {
                include.Add("TEMPLATE_UNIT_SINGLE");
            }
            if (suffix == "i")
            {
                include.Add("TEMPLATE_UNIT_INT32");
                targetClass += "i";
            }
            if (suffix == "h")
            {
                include.Add("TEMPLATE_UNIT_HALF");
                targetClass += "h";
            }

            foreach (var i in include)
                w.WriteLine("#define " + i);

            DirectiveParser dp = new DirectiveParser(local, include);

            bool start = true; //to remove leading comments

            foreach (string l in template)
            {
                if (start && l.Trim() != "")
                    continue;
                else
                    start = false;

                if (dp.Parse(l) == false)
                    continue;

                //Replace class name
                string line = l.Replace(templateClass, targetClass);

                w.WriteLine(line);
            }

            dp.Finish();
        }
    }
}
