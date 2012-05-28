﻿// Generated by Generator.Template using template Math/VectorTemplate.cs

#define TEMPLATE_DIM_3
#define TEMPLATE_UNIT_SINGLE

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
using System.Xml.Serialization;

namespace OpenTK
{
    using unit = System.Single;
    using vec2 = Vector2;
    using vec3 = Vector3;

    /// <summary>Represents a 4D vector using four unit.</summary>
    /// <remarks>
    /// The Vector3 structure is suitable for interoperation with unmanaged code requiring four consecutive units.
    /// </remarks>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct Vector3 : IEquatable<Vector3>
    {
        /// <summary></summary>
        public unit X;
        /// <summary></summary>
        public unit Y;
        /// <summary></summary>
        public unit Z;

        /// <summary>
        /// Defines the size of the Vector3 struct in bytes.
        /// </summary>
        public static readonly int SizeInBytes = Marshal.SizeOf(new Vector3());

        #region Static: Unit-vectors and other help vectors

        /// <summary>
        /// Defines a unit-length Vector3 that points along the X-axis.
        /// </summary>
        public static readonly Vector3 UnitX = new Vector3((unit)1, (unit)0
                                                           , (unit)0
                                                           );

        /// <summary>
        /// Defines a unit-length Vector3 that points along the Y-axis.
        /// </summary>
        public static readonly Vector3 UnitY = new Vector3((unit)0, (unit)1
                                                           , (unit)0
                                                           );

        /// <summary>
        /// Defines a unit-length Vector3 that points along the Z-axis.
        /// </summary>
        public static readonly Vector3 UnitZ = new Vector3((unit)0, (unit)0, (unit)1
                                                           );


        /// <summary>
        /// Defines a zero-length Vector3.
        /// </summary>
        public static readonly Vector3 Zero = new Vector3((unit)0);

        /// <summary>
        /// Defines an instance with all components set to 1.
        /// </summary>
        public static readonly Vector3 One = new Vector3((unit)1);
        
        #endregion Static: Unit-vectors and other help vectors

        #region Constructors

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// <param name="value">The value that will initialize all components.</param>
        public Vector3(unit value)
        {
            X = value;
            Y = value;
            Z = value;
        }

        /// <summary>
        /// Constructs a new Vector3.
        /// </summary>
        public Vector3(
            unit x, unit y
            , unit z
        )
        {
            X = x;
            Y = y;
            Z = z;
        }

        #endregion

        #region Length

        /// <summary>
        /// Gets the length (magnitude) of the vector.
        /// </summary>
        /// <see cref="LengthFast"/>
        /// <seealso cref="LengthSquared"/>
        public double Length
        {
            get
            {
                return System.Math.Sqrt(X * X + Y * Y
                    + Z * Z
                );
            }
        }

        /// <summary>
        /// Gets an approximation of the vector length (magnitude).
        /// </summary>
        /// <remarks>
        /// This property uses an approximation of the square root function to calculate vector magnitude, with
        /// an upper error bound of 0.001.
        /// </remarks>
        /// <see cref="Length"/>
        /// <seealso cref="LengthSquared"/>
        public double LengthFast
        {
            get
            {
                return 1.0 / MathHelper.InverseSqrtFast(X * X + Y * Y
                    + Z * Z
                );
            }
        }

        /// <summary>
        /// Gets the square of the vector length (magnitude).
        /// </summary>
        /// <remarks>
        /// This property avoids the costly square root operation required by the Length property. This makes it more suitable
        /// for comparisons.
        /// </remarks>
        /// <see cref="Length"/>
        /// <seealso cref="LengthFast"/>
        public unit LengthSquared
        { 
            get
            {
                return X * X + Y * Y
                    + Z * Z
                    ;
            }
        }

        #endregion

        #region Normalize


        /// <summary>
        /// Return a Vector3 scaled to unit length.
        /// </summary>
        public Vector3 Normalize()
        {
            unit scale = (unit)( 1.0 / this.Length);
            return new Vector3(X * scale, Y * scale
                               , Z * scale
                               );
        }

        
        /// <summary>
        /// Return a Vector3 scaled to approximately unit length.
        /// </summary>
        public Vector3 NormalizeFast()
        {
            unit scale = MathHelper.InverseSqrtFast(X * X + Y * Y
                                                      + Z * Z
                                                     );
            return new Vector3(X * scale, Y * scale
                               , Z * scale
                               );
        }


        #endregion
     
        #region Multiply

        /// <summary>
        /// Multiplies a vector by a scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <param name="result">Result of the operation.</param>
        public static void Multiply(ref Vector3 vector, unit scale, out Vector3 result)
        {
            result = new Vector3(
                vector.X * scale,
                vector.Y * scale
                , vector.Z * scale
            );
        }

        /// <summary>
        /// Multiplies a vector by the components a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        public static Vector3 Multiply(Vector3 vector, Vector3 scale)
        {
            Multiply(ref vector, ref scale, out vector);
            return vector;
        }

        /// <summary>
        /// Multiplies a vector by the components of a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <param name="result">Result of the operation.</param>
        public static void Multiply(ref Vector3 vector, ref Vector3 scale, out Vector3 result)
        {
            result = new Vector3(
                vector.X * scale.X,
                vector.Y * scale.Y
                , vector.Z * scale.Z
            );
        }

        #endregion

        #region Divide

        /// <summary>
        /// Divides a vector by a scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        public static Vector3 Divide(Vector3 vector, unit scale)
        {
            Divide(ref vector, scale, out vector);
            return vector;
        }

        /// <summary>
        /// Divides a vector by a scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <param name="result">Result of the operation.</param>
        public static void Divide(ref Vector3 vector, unit scale, out Vector3 result)
        {
            Multiply(ref vector, 1 / scale, out result);
        }

        /// <summary>
        /// Divides a vector by the components of a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        public static Vector3 Divide(Vector3 vector, Vector3 scale)
        {
            Divide(ref vector, ref scale, out vector);
            return vector;
        }

        /// <summary>
        /// Divide a vector by the components of a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <param name="result">Result of the operation.</param>
        public static void Divide(ref Vector3 vector, ref Vector3 scale, out Vector3 result)
        {
            result = new Vector3(
                vector.X / scale.X,
                vector.Y / scale.Y
                , vector.Z / scale.Z
            );
        }

        #endregion

        #region Component Min/Max

        /// <summary>
        /// Calculate the component-wise minimum of two vectors
        /// </summary>
        /// <returns>The component-wise minimum</returns>
        public static Vector3 ComponentMin(Vector3 a, Vector3 b)
        {
            a.X = a.X < b.X ? a.X : b.X;
            a.Y = a.Y < b.Y ? a.Y : b.Y;
            a.Z = a.Z < b.Z ? a.Z : b.Z;
            return a;
        }

        /// <summary>
        /// Calculate the component-wise minimum of two vectors
        /// </summary>
        public static void ComponentMin(ref Vector3 a, ref Vector3 b, out Vector3 result)
        {
            result.X = a.X < b.X ? a.X : b.X;
            result.Y = a.Y < b.Y ? a.Y : b.Y;
            result.Z = a.Z < b.Z ? a.Z : b.Z;
        }

        /// <summary>
        /// Calculate the component-wise maximum of two vectors
        /// </summary>
        /// <returns>The component-wise maximum</returns>
        public static Vector3 ComponentMax(Vector3 a, Vector3 b)
        {
            a.X = a.X > b.X ? a.X : b.X;
            a.Y = a.Y > b.Y ? a.Y : b.Y;
            a.Z = a.Z > b.Z ? a.Z : b.Z;
            return a;
        }

        /// <summary>
        /// Calculate the component-wise maximum of two vectors
        /// </summary>
        public static void ComponentMax(ref Vector3 a, ref Vector3 b, out Vector3 result)
        {
            result.X = a.X > b.X ? a.X : b.X;
            result.Y = a.Y > b.Y ? a.Y : b.Y;
            result.Z = a.Z > b.Z ? a.Z : b.Z;
        }

        #endregion Component Min/Max

        #region Min/Max

        /// <summary>
        /// Returns the Vector3 with the minimum magnitude
        /// </summary>
        /// <param name="left">Left operand</param>
        /// <param name="right">Right operand</param>
        /// <returns>The minimum Vector3</returns>
        public static Vector3 Min(Vector3 left, Vector3 right)
        {
            return left.LengthSquared < right.LengthSquared ? left : right;
        }

        /// <summary>
        /// Returns the Vector3 with the minimum magnitude
        /// </summary>
        /// <param name="left">Left operand</param>
        /// <param name="right">Right operand</param>
        /// <returns>The minimum Vector3</returns>
        public static Vector3 Max(Vector3 left, Vector3 right)
        {
            return left.LengthSquared >= right.LengthSquared ? left : right;
        }


        #endregion Min/Max

        #region Clamp

        /// <summary>
        /// Clamp a vector to the given minimum and maximum vectors
        /// </summary>
        /// <param name="vec">Input vector</param>
        /// <param name="min">Minimum vector</param>
        /// <param name="max">Maximum vector</param>
        /// <returns>The clamped vector</returns>
        public static Vector3 Clamp(Vector3 vec, Vector3 min, Vector3 max)
        {
            vec.X = vec.X < min.X ? min.X : vec.X > max.X ? max.X : vec.X;
            vec.Y = vec.Y < min.Y ? min.Y : vec.Y > max.Y ? max.Y : vec.Y;
            vec.Z = vec.X < min.Z ? min.Z : vec.Z > max.Z ? max.Z : vec.Z;
            return vec;
        }

        /// <summary>
        /// Clamp a vector to the given minimum and maximum vectors
        /// </summary>
        /// <param name="vec">Input vector</param>
        /// <param name="min">Minimum vector</param>
        /// <param name="max">Maximum vector</param>
        /// <param name="result">The clamped vector</param>
        public static void Clamp(ref Vector3 vec, ref Vector3 min, ref Vector3 max, out Vector3 result)
        {
            result.X = vec.X < min.X ? min.X : vec.X > max.X ? max.X : vec.X;
            result.Y = vec.Y < min.Y ? min.Y : vec.Y > max.Y ? max.Y : vec.Y;
            result.Z = vec.X < min.Z ? min.Z : vec.Z > max.Z ? max.Z : vec.Z;
        }

        #endregion


        #region Normalize

        /// <summary>
        /// Scale a vector to unit length(1)
        /// </summary>
        /// <param name="vec">The input vector</param>
        /// <param name="result">The normalized vector</param>
        public static void Normalize(ref Vector3 vec, out Vector3 result)
        {
            unit scale = 1.0f / (unit)vec.Length;
            result.X = vec.X * scale;
            result.Y = vec.Y * scale;
            result.Z = vec.Z * scale;
        }

        /// <summary>
        /// Scale a vector to approximately unit length
        /// </summary>
        /// <param name="vec">The input vector</param>
        /// <param name="result">The normalized vector</param>
        public static void NormalizeFast(ref Vector3 vec, out Vector3 result)
        {
            unit scale = MathHelper.InverseSqrtFast(vec.X * vec.X + vec.Y * vec.Y
                                                      + vec.Z * vec.Z
                                                     );
            result.X = vec.X * scale;
            result.Y = vec.Y * scale;
            result.Z = vec.Z * scale;
        }

        #endregion


        #region Dot

        /// <summary>
        /// Calculate the dot product of two vectors
        /// </summary>
        public static unit Dot(Vector3 left, Vector3 right)
        {
            return left.X * right.X + left.Y * right.Y
                    + left.Z * right.Z
                    ;
        }

        /// <summary>
        /// Calculate the dot product of two vectors
        /// </summary>
        public static void Dot(ref Vector3 left, ref Vector3 right, out unit result)
        {
            result = left.X * right.X + left.Y * right.Y
                    + left.Z * right.Z
                    ;
        }

        #endregion
                
                
        #region Cross product

        /// <summary>
        /// Caclulate the 3D cross (vector) product of two vectors
        /// </summary>
        /// <param name="left">First operand</param>
        /// <param name="right">Second operand</param>
        /// <returns>The cross product of the two inputs</returns>
        public static Vector3 Cross(Vector3 left, Vector3 right)
        {
            Vector3 result;
            Cross(ref left, ref right, out result);
            return result;
        }

        /// <summary>
        /// Caclulate the 3D cross (vector) product of two vectors
        /// </summary>
        /// <param name="left">First operand</param>
        /// <param name="right">Second operand</param>
        /// <returns>The cross product of the two inputs</returns>
        /// <param name="result">The cross product of the two inputs</param>
        public static void Cross(ref Vector3 left, ref Vector3 right, out Vector3 result)
        {
            result = new Vector3(left.Y * right.Z - left.Z * right.Y,
                left.Z * right.X - left.X * right.Z,
                left.X * right.Y - left.Y * right.X
            );
        }
 
        #endregion Cross product


        #region Calculate Angle

        /// <summary>
        /// Calculates the angle (in radians) between two vectors.
        /// </summary>
        /// <param name="first">The first vector.</param>
        /// <param name="second">The second vector.</param>
        /// <returns>Angle (in radians) between the vectors.</returns>
        /// <remarks>Note that the returned angle is never bigger than the constant Pi.</remarks>
        public static double CalculateAngle(Vector3 first, Vector3 second)
        {
            return System.Math.Acos((Vector3.Dot(first, second)) / (first.Length * second.Length));
        }

        /// <summary>Calculates the angle (in radians) between two vectors.</summary>
        /// <param name="first">The first vector.</param>
        /// <param name="second">The second vector.</param>
        /// <param name="result">Angle (in radians) between the vectors.</param>
        /// <remarks>Note that the returned angle is never bigger than the constant Pi.</remarks>
        public static void CalculateAngle(ref Vector3 first, ref Vector3 second, out double result)
        {
            unit temp;
            Vector3.Dot(ref first, ref second, out temp);
            result = System.Math.Acos(temp / (first.Length * second.Length));
        }
 
        #endregion Calculate Angle

        #region Lerp

        /// <summary>
        /// Returns a new Vector that is the linear blend of the 2 given Vectors
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="blend">The blend factor. a when blend=0, b when blend=1.</param>
        /// <returns>a when blend=0, b when blend=1, and a linear combination otherwise</returns>
        public static Vector3 Lerp(Vector3 a, Vector3 b, unit blend)
        {
            a.X = blend * (b.X - a.X) + a.X;
            a.Y = blend * (b.Y - a.Y) + a.Y;
            a.Z = blend * (b.Z - a.Z) + a.Z;
            return a;
        }

        /// <summary>
        /// Returns a new Vector that is the linear blend of the 2 given Vectors
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="blend">The blend factor. a when blend=0, b when blend=1.</param>
        /// <param name="result">a when blend=0, b when blend=1, and a linear combination otherwise</param>
        public static void Lerp(ref Vector3 a, ref Vector3 b, unit blend, out Vector3 result)
        {
            result.X = blend * (b.X - a.X) + a.X;
            result.Y = blend * (b.Y - a.Y) + a.Y;
            result.Z = blend * (b.Z - a.Z) + a.Z;
        }

        #endregion

        #region Barycentric

        /// <summary>
        /// Interpolate 3 Vectors using Barycentric coordinates
        /// </summary>
        /// <param name="a">First input Vector</param>
        /// <param name="b">Second input Vector</param>
        /// <param name="c">Third input Vector</param>
        /// <param name="u">First Barycentric Coordinate</param>
        /// <param name="v">Second Barycentric Coordinate</param>
        /// <returns>a when u=v=0, b when u=1,v=0, c when u=0,v=1, and a linear combination of a,b,c otherwise</returns>
        public static Vector3 BaryCentric(Vector3 a, Vector3 b, Vector3 c, unit u, unit v)
        {
            return a + u * (b - a) + v * (c - a);
        }

        /// <summary>Interpolate 3 Vectors using Barycentric coordinates</summary>
        /// <param name="a">First input Vector.</param>
        /// <param name="b">Second input Vector.</param>
        /// <param name="c">Third input Vector.</param>
        /// <param name="u">First Barycentric Coordinate.</param>
        /// <param name="v">Second Barycentric Coordinate.</param>
        /// <param name="result">Output Vector. a when u=v=0, b when u=1,v=0, c when u=0,v=1, and a linear combination of a,b,c otherwise</param>
        public static void BaryCentric(ref Vector3 a, ref Vector3 b, ref Vector3 c, unit u, unit v, out Vector3 result)
        {
            result.X = a.X + u * (b.X - a.X) + v * (c.X - a.X);
            result.Y = a.Y + u * (b.Y - a.Y) + v * (c.Y - a.Y);
            result.Z = a.Z + u * (b.Z - a.Z) + v * (c.Z - a.Z);

        }

        #endregion

        #region Swizzle


        /// <summary></summary>
        [XmlIgnore]
        public vec2 Xy
        {
            get { return new vec2(X, Y); }
            set
            { 
                X = value.X;
                Y = value.Y;
            }
        }



        #endregion

        #region Operators

        /// <summary>
        /// Element-wise addition.
        /// </summary>
        public static Vector3 operator +(unit left, Vector3 right)
        {
            right.X += left;
            right.Y += left;
            right.Z += left;
            return right;
        }

        /// <summary>
        /// Element-wise addition.
        /// </summary>
        public static Vector3 operator +(Vector3 left, unit right)
        {
            left.X += right;
            left.Y += right;
            left.Z += right;
            return left;
        }

        /// <summary></summary>
        public static Vector3 operator +(Vector3 left, Vector3 right)
        {
            left.X += right.X;
            left.Y += right.Y;
            left.Z += right.Z;
            return left;
        }

        /// <summary>
        /// Element-wise subtraction.
        /// </summary>
        public static Vector3 operator -(unit left, Vector3 right)
        {
            right.X = left - right.X;
            right.Y = left - right.Y;
            right.Z = left - right.Z;
            return right;
        }
        
        /// <summary>
        /// Element-wise subtraction.
        /// </summary>
        public static Vector3 operator -(Vector3 left, unit right)
        {
            left.X -= right;
            left.Y -= right;
            left.Z -= right;
            return left;
        }
        
        /// <summary></summary>
        public static Vector3 operator -(Vector3 left, Vector3 right)
        {
            left.X -= right.X;
            left.Y -= right.Y;
            left.Z -= right.Z;
            return left;
        }

        /// <summary></summary>
        public static Vector3 operator -(Vector3 vec)
        {
            vec.X = -vec.X;
            vec.Y = -vec.Y;
            vec.Z = -vec.Z;
            return vec;
        }

        /// <summary></summary>
        public static Vector3 operator *(Vector3 vec, unit scale)
        {
            vec.X *= scale;
            vec.Y *= scale;
            vec.Z *= scale;
            return vec;
        }

        /// <summary></summary>
        public static Vector3 operator *(unit scale, Vector3 vec)
        {
            vec.X *= scale;
            vec.Y *= scale;
            vec.Z *= scale;
            return vec;
        }

        /// <summary></summary>
        public static Vector3 operator / (Vector3 vec, double scale)
        {
            double mult = 1.0 / scale;
            return new Vector3(
            vec.X * mult,
            vec.Y * mult
            , vec.Z * mult
                );
        }

        /// <summary></summary>
        public static Vector3 operator /(Vector3 vec, float scale)
        {
            float mult = 1.0f / scale;
            return new Vector3(
            vec.X * mult,
            vec.Y * mult
            , vec.Z * mult
                );
        }

        /// <summary></summary>
        public static bool operator ==(Vector3 left, Vector3 right)
        {
            return left.Equals(right);
        }

        /// <summary></summary>
        public static bool operator !=(Vector3 left, Vector3 right)
        {
            return !left.Equals(right);
        }

        #endregion

        #region Overrides

        /// <summary></summary>
        public override string ToString()
        {
            const string format = "0.0";
            return ToString(format);
        }

        /// <summary></summary>
        public string ToString(string format)
        {
            return String.Format("({0}, {1}, {2})'", X.ToString(format), Y.ToString(format), Z.ToString(format));
        }

        /// <summary></summary>
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode()
                ^ Z.GetHashCode()
                    ;
        }

        /// <summary></summary>
        public override bool Equals(object obj)
        {
            if (!(obj is Vector3))
                return false;

            return this.Equals((Vector3)obj);
        }

        #endregion

        #region IEquatable<Vector3> Members

        /// <summary>Indicates whether the current vector is equal to another vector.</summary>
        /// <param name="other">A vector to compare with this vector.</param>
        /// <returns>true if the current vector is equal to the vector parameter; otherwise, false.</returns>
        public bool Equals(Vector3 other)
        {
            return X == other.X && Y == other.Y
                && Z == other.Z
                    ;
        }

        #endregion
    }
}
