// Template for Vector[234][d_hi].cs
// Run Generator.Template to generate the Vector files
#define TEMPLATE_UNIT_SINGLE
// All up to the first empty line will be removed:

#region --- License ---
/*
Copyright (c) 2006 - 2008 The Open Toolkit library.

Permission is hereby granted, free of charge, to any person obtaining a copy of
this software and associated documentation files (the "Software"), to deal in
the Software without restriction, including without limitation the rights to
use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
of the Software, and to permit persons to whom the Software is furnished to do
so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
 */
#endregion
using System;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Xml.Serialization;

namespace OpenTK
{
#if TEMPLATE_UNIT_DOUBLE
    using unit = System.Double;
    using vec3 = Vector3d;
    using vec4 = Vector4d;
#elif TEMPLATE_UNIT_SINGLE
    using unit = System.Single;
    using vec3 = Vector3;
    using vec4 = Vector4;
#endif   

    /// <summary>
    /// Represents a QuaternionTemplate.
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct QuaternionTemplate : IEquatable<QuaternionTemplate>
    {
        /// <summary>
        /// sin(𝚯/2)µ_x
        /// </summary>
        public unit X;
        /// <summary>
        /// sin(𝚯/2)µ_y
        /// </summary>
        public unit Y;
        /// <summary>
        /// sin(𝚯/2)µ_z
        /// </summary>
        public unit Z;
        /// <summary>
        /// cos(𝚯/2)
        /// </summary>
        public unit W;

        #region Alternate representations

        /// <summary>
        /// Gets or sets the X, Y and Z components of this instance.
        /// </summary>
        public vec3 Xyz
        {
            get { return new vec3(X, Y, Z); }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Construct a new QuaternionTemplate from vector and w components
        /// </summary>
        /// <param name="v">The vector part</param>
        /// <param name="w">The w part</param>
        public QuaternionTemplate(vec3 v, unit w)
        {
            this.X = v.X;
            this.Y = v.Y;
            this.Z = v.Z;
            this.W = w;
        }

        /// <summary>
        /// Construct a new QuaternionTemplate
        /// </summary>
        /// <param name="x">The x component</param>
        /// <param name="y">The y component</param>
        /// <param name="z">The z component</param>
        /// <param name="w">The w component</param>
        public QuaternionTemplate(unit x, unit y, unit z, unit w)
            : this(new vec3(x, y, z), w)
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the length (magnitude) of the quaternion.
        /// </summary>
        /// <seealso cref="LengthSquared"/>
        public unit Length
        {
            get
            {
                return (unit)System.Math.Sqrt(W * W + Xyz.LengthSquared);
            }
        }

        /// <summary>
        /// Gets the square of the quaternion length (magnitude).
        /// </summary>
        public unit LengthSquared
        {
            get
            {
                return W * W + Xyz.LengthSquared;
            }
        }

        #endregion

        #region Instance Operations returning a new struct

        /// <summary>
        /// Convert the current quaternion to axis angle representation
        /// </summary>
        /// <param name="axis">The resultant axis</param>
        /// <param name="angle">The resultant angle</param>
        public void ToAxisAngle(out vec3 axis, out double angle)
        {
            vec4 result = ToAxisAngle();
            axis = result.Xyz;
            angle = result.W;
        }

        /// <summary>
        /// Convert this instance to an axis-angle representation.
        /// </summary>
        /// <returns>A vec4 that is the axis-angle representation of this quaternion.</returns>
        public vec4 ToAxisAngle()
        {
            QuaternionTemplate q = this;
            if (Math.Abs(q.W) > 1.0f)
                q.Normalize();

            vec4 result = new vec4();

            result.W = 2.0f * (unit)System.Math.Acos(q.W); // angle
            unit den = (unit)System.Math.Sqrt(1.0 - q.W * q.W);
            if (den > 0.0001f)
            {
                result.Xyz = q.Xyz / den;
            } else
            {
                // This occurs when the angle is zero. 
                // Not a problem: just set an arbitrary normalized axis.
                result.Xyz = vec3.UnitX;
            }

            return result;
        }

        /// <summary>
        /// Return the conjugate of this quaternion
        /// </summary>
        public QuaternionTemplate Conjugate()
        {
            return new QuaternionTemplate(-X, -Y, -Z, W);
        }

        /// <summary>
        /// Return the inverse of the instance.
        /// </summary>
        public QuaternionTemplate Inverse()
        {
            unit div = 1 / (W * W + X * X + Y * Y + Z * Z);
            return new QuaternionTemplate(-X * div, -Y * div, -Z * div, W * div);
        }

        /// <summary>
        /// Scale the quaternion to unit length
        /// </summary>
        /// <returns>The normalized quaternion</returns>
        public QuaternionTemplate Normalize()
        {
            unit scale = 1 / this.Length;
            return new QuaternionTemplate(X * scale, Y * scale, Z * scale, W * scale);
        }

        #endregion

        #region Static

        /// <summary>
        /// Defines the identity quaternion.
        /// </summary>
        public static QuaternionTemplate Identity = new QuaternionTemplate(0, 0, 0, 1);

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <param name="result">A new instance containing the result of the calculation.</param>
        public static void Multiply(ref QuaternionTemplate left, ref QuaternionTemplate right, out QuaternionTemplate result)
        {
            result = new QuaternionTemplate(
                right.W * left.Xyz + left.W * right.Xyz + vec3.Cross(
                left.Xyz,
                right.Xyz
            ),
                left.W * right.W - vec3.Dot(left.Xyz, right.Xyz));
        }

        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        /// <param name="quaternion">The instance.</param>
        /// <param name="scale">The scalar.</param>
        /// <param name="result">A new instance containing the result of the calculation.</param>
        public static void Multiply(ref QuaternionTemplate quaternion, unit scale, out QuaternionTemplate result)
        {
            result = new QuaternionTemplate(
                quaternion.X * scale,
                quaternion.Y * scale,
                quaternion.Z * scale,
                quaternion.W * scale
            );
        }

        /// <summary>
        /// Get the conjugate of the given quaternion
        /// </summary>
        /// <param name="q">The quaternion</param>
        /// <param name="result">The conjugate of the given quaternion</param>
        public static void Conjugate(ref QuaternionTemplate q, out QuaternionTemplate result)
        {
            result = new QuaternionTemplate(-q.Xyz, q.W);
        }

        /// <summary>
        /// Get the inverse of the given quaternion
        /// </summary>
        /// <param name="q">The quaternion to invert</param>
        /// <param name="result">The inverse of the given quaternion</param>
        public static void Invert(ref QuaternionTemplate q, out QuaternionTemplate result)
        {
            unit lengthSq = q.LengthSquared;
            if (lengthSq != 0.0)
            {
                unit i = 1.0f / lengthSq;
                result = new QuaternionTemplate(q.Xyz * -i, q.W * i);
            } else
            {
                result = q;
            }
        }

        /// <summary>
        /// Scale the given quaternion to unit length
        /// </summary>
        /// <param name="q">The quaternion to normalize</param>
        /// <param name="result">The normalized quaternion</param>
        public static void Normalize(ref QuaternionTemplate q, out QuaternionTemplate result)
        {
            unit scale = 1.0f / q.Length;
            result = new QuaternionTemplate(q.Xyz * scale, q.W * scale);
        }

        #region FromAxisAngle

        /// <summary>
        /// Build a quaternion from the given axis and angle
        /// </summary>
        /// <param name="axis">The axis to rotate about</param>
        /// <param name="angle">The rotation angle in radians</param>
        /// <returns></returns>
        public static QuaternionTemplate FromAxisAngle(vec3 axis, double angle)
        {
            if (axis.LengthSquared == 0.0f)
                return Identity;

            angle *= 0.5f;
            axis.Normalize();
            QuaternionTemplate result = new QuaternionTemplate(
                axis * (unit)System.Math.Sin(angle),
                (unit)System.Math.Cos(angle)
            );

            return result.Normalize();
        }

        #endregion

        #region Slerp

        /// <summary>
        /// Do Spherical linear interpolation between two quaternions 
        /// </summary>
        /// <param name="q1">The first quaternion</param>
        /// <param name="q2">The second quaternion</param>
        /// <param name="blend">The blend factor</param>
        /// <returns>A smooth blend between the given quaternions</returns>
        public static QuaternionTemplate Slerp(QuaternionTemplate q1, QuaternionTemplate q2, unit blend)
        {
            // if either input is zero, return the other.
            if (q1.LengthSquared == 0.0f)
            {
                if (q2.LengthSquared == 0.0f)
                {
                    return Identity;
                }
                return q2;
            } else if (q2.LengthSquared == 0.0f)
            {
                return q1;
            }


            unit cosHalfAngle = q1.W * q2.W + vec3.Dot(q1.Xyz, q2.Xyz);

            if (cosHalfAngle >= 1.0f || cosHalfAngle <= -1.0f)
            {
                // angle = 0.0f, so just return one input.
                return q1;
            } else if (cosHalfAngle < 0.0f)
            {
                q2.X = -q2.X;
                q2.Y = -q2.Y;
                q2.Z = -q2.Z;
                q2.W = -q2.W;
                cosHalfAngle = -cosHalfAngle;
            }

            unit blendA;
            unit blendB;
            if (cosHalfAngle < 0.99f)
            {
                // do proper slerp for big angles
                unit halfAngle = (unit)System.Math.Acos(cosHalfAngle);
                unit sinHalfAngle = (unit)System.Math.Sin(halfAngle);
                unit oneOverSinHalfAngle = 1.0f / sinHalfAngle;
                blendA = (unit)System.Math.Sin(halfAngle * (1.0f - blend)) * oneOverSinHalfAngle;
                blendB = (unit)System.Math.Sin(halfAngle * blend) * oneOverSinHalfAngle;
            } else
            {
                // do lerp if angle is really small.
                blendA = 1.0f - blend;
                blendB = blend;
            }

            QuaternionTemplate result = new QuaternionTemplate(
                blendA * q1.Xyz + blendB * q2.Xyz,
                blendA * q1.W + blendB * q2.W
            );
            if (result.LengthSquared > 0.0f)
                return result.Normalize();
            else
                return Identity;
        }

        #endregion

        #endregion

        #region Operators

        /// <summary>
        /// Adds two instances.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>The result of the calculation.</returns>
        public static QuaternionTemplate operator +(QuaternionTemplate left, QuaternionTemplate right)
        {
            left.X += right.X;
            left.Y += right.Y;
            left.Z += right.Z;
            left.W += right.W;
            return left;
        }

        /// <summary>
        /// Subtracts two instances.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>The result of the calculation.</returns>
        public static QuaternionTemplate operator -(QuaternionTemplate left, QuaternionTemplate right)
        {
            left.X -= right.X;
            left.Y -= right.Y;
            left.Z -= right.Z;
            left.W -= right.W;
            return left;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>The result of the calculation.</returns>
        public static QuaternionTemplate operator *(QuaternionTemplate left, QuaternionTemplate right)
        {
            Multiply(ref left, ref right, out left);
            return left;
        }

        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        /// <param name="quaternion">The instance.</param>
        /// <param name="scale">The scalar.</param>
        /// <returns>A new instance containing the result of the calculation.</returns>
        public static QuaternionTemplate operator *(QuaternionTemplate quaternion, unit scale)
        {
            return new QuaternionTemplate(
                quaternion.X * scale,
                quaternion.Y * scale,
                quaternion.Z * scale,
                quaternion.W * scale
            );
        }
            
        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        /// <param name="quaternion">The instance.</param>
        /// <param name="scale">The scalar.</param>
        /// <returns>A new instance containing the result of the calculation.</returns>
        public static QuaternionTemplate operator *(unit scale, QuaternionTemplate quaternion)
        {
            return new QuaternionTemplate(
                quaternion.X * scale,
                quaternion.Y * scale,
                quaternion.Z * scale,
                quaternion.W * scale
            );
        }

        /// <summary>
        /// Compares two instances for equality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left equals right; false otherwise.</returns>
        public static bool operator ==(QuaternionTemplate left, QuaternionTemplate right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares two instances for inequality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left does not equal right; false otherwise.</returns>
        public static bool operator !=(QuaternionTemplate left, QuaternionTemplate right)
        {
            return !left.Equals(right);
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Returns a System.String that represents the current QuaternionTemplate.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("V: {0}, W: {1}", Xyz, W);
        }

        /// <summary>
        /// Compares this object instance to another object for equality. 
        /// </summary>
        /// <param name="other">The other object to be used in the comparison.</param>
        /// <returns>True if both objects are QuaternionTemplates of equal value. Otherwise it returns false.</returns>
        public override bool Equals(object other)
        {
            if (other is QuaternionTemplate == false)
                return false;
            return this == (QuaternionTemplate)other;
        }

        /// <summary>
        /// Provides the hash code for this object. 
        /// </summary>
        /// <returns>A hash code formed from the bitwise XOR of this objects members.</returns>
        public override int GetHashCode()
        {
            return Xyz.GetHashCode() ^ W.GetHashCode();
        }

        #endregion

        #region IEquatable<QuaternionTemplate> Members

        /// <summary>
        /// Compares this QuaternionTemplate instance to another QuaternionTemplate for equality. 
        /// </summary>
        /// <param name="other">The other QuaternionTemplate to be used in the comparison.</param>
        /// <returns>True if both instances are equal; false otherwise.</returns>
        public bool Equals(QuaternionTemplate other)
        {
            return Xyz == other.Xyz && W == other.W;
        }

        #endregion
    }
}
