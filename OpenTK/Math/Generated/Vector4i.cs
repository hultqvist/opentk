﻿// Generated by Generator.Template using template Math/VectorTemplate.cs

#define TEMPLATE_DIM_3
#define TEMPLATE_DIM_4
#define TEMPLATE_UNIT_INT32

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
    using unit = System.Int32;
    using vec2 = Vector2i;
    using vec3 = Vector3i;

    /// <summary>Represents a 4D vector using four unit.</summary>
    /// <remarks>
    /// The Vector4i structure is suitable for interoperation with unmanaged code requiring four consecutive units.
    /// </remarks>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct Vector4i : IEquatable<Vector4i>
    {
        /// <summary></summary>
        public unit X;
        /// <summary></summary>
        public unit Y;
        /// <summary></summary>
        public unit Z;
        /// <summary></summary>
        public unit W;

        /// <summary>
        /// Defines the size of the Vector4i struct in bytes.
        /// </summary>
        public static readonly int SizeInBytes = Marshal.SizeOf(new Vector4i());

        #region Static: Unit-vectors and other help vectors

        /// <summary>
        /// Defines a unit-length Vector4i that points along the X-axis.
        /// </summary>
        public static readonly Vector4i UnitX = new Vector4i((unit)1, (unit)0
                                                           , (unit)0
                                                           , (unit)0
                                                           );

        /// <summary>
        /// Defines a unit-length Vector4i that points along the Y-axis.
        /// </summary>
        public static readonly Vector4i UnitY = new Vector4i((unit)0, (unit)1
                                                           , (unit)0
                                                           , (unit)0
                                                           );

        /// <summary>
        /// Defines a unit-length Vector4i that points along the Z-axis.
        /// </summary>
        public static readonly Vector4i UnitZ = new Vector4i((unit)0, (unit)0, (unit)1
                                                           , (unit)0
                                                           );

        /// <summary>
        /// Defines a unit-length Vector4i that points along the W-axis.
        /// </summary>
        public static readonly Vector4i UnitW = new Vector4i((unit)0, (unit)0, (unit)0, (unit)1);

        /// <summary>
        /// Defines a zero-length Vector4i.
        /// </summary>
        public static readonly Vector4i Zero = new Vector4i((unit)0);

        /// <summary>
        /// Defines an instance with all components set to 1.
        /// </summary>
        public static readonly Vector4i One = new Vector4i((unit)1);
        
        #endregion Static: Unit-vectors and other help vectors

        #region Constructors

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// <param name="value">The value that will initialize all components.</param>
        public Vector4i(unit value)
        {
            X = value;
            Y = value;
            Z = value;
            W = value;
        }

        /// <summary>
        /// Constructs a new Vector4i.
        /// </summary>
        public Vector4i(
            unit x, unit y
            , unit z
            , unit w
        )
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
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
                    + W * W
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
                    + W * W
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
                    + W * W
                    ;
            }
        }

        #endregion

        #region Normalize


        #endregion
     
        #region Multiply

        /// <summary>
        /// Multiplies a vector by a scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <param name="result">Result of the operation.</param>
        public static void Multiply(ref Vector4i vector, unit scale, out Vector4i result)
        {
            result = new Vector4i(
                vector.X * scale,
                vector.Y * scale
                , vector.Z * scale
                , vector.W * scale
            );
        }

        /// <summary>
        /// Multiplies a vector by the components a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        public static Vector4i Multiply(Vector4i vector, Vector4i scale)
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
        public static void Multiply(ref Vector4i vector, ref Vector4i scale, out Vector4i result)
        {
            result = new Vector4i(
                vector.X * scale.X,
                vector.Y * scale.Y
                , vector.Z * scale.Z
                , vector.W * scale.W
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
        public static Vector4i Divide(Vector4i vector, unit scale)
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
        public static void Divide(ref Vector4i vector, unit scale, out Vector4i result)
        {
            Multiply(ref vector, 1 / scale, out result);
        }

        /// <summary>
        /// Divides a vector by the components of a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        public static Vector4i Divide(Vector4i vector, Vector4i scale)
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
        public static void Divide(ref Vector4i vector, ref Vector4i scale, out Vector4i result)
        {
            result = new Vector4i(
                vector.X / scale.X,
                vector.Y / scale.Y
                , vector.Z / scale.Z
                , vector.W / scale.W
            );
        }

        #endregion

        #region Component Min/Max

        /// <summary>
        /// Calculate the component-wise minimum of two vectors
        /// </summary>
        /// <returns>The component-wise minimum</returns>
        public static Vector4i ComponentMin(Vector4i a, Vector4i b)
        {
            a.X = a.X < b.X ? a.X : b.X;
            a.Y = a.Y < b.Y ? a.Y : b.Y;
            a.Z = a.Z < b.Z ? a.Z : b.Z;
            a.W = a.W < b.W ? a.W : b.W;
            return a;
        }

        /// <summary>
        /// Calculate the component-wise minimum of two vectors
        /// </summary>
        public static void ComponentMin(ref Vector4i a, ref Vector4i b, out Vector4i result)
        {
            result.X = a.X < b.X ? a.X : b.X;
            result.Y = a.Y < b.Y ? a.Y : b.Y;
            result.Z = a.Z < b.Z ? a.Z : b.Z;
            result.W = a.W < b.W ? a.W : b.W;
        }

        /// <summary>
        /// Calculate the component-wise maximum of two vectors
        /// </summary>
        /// <returns>The component-wise maximum</returns>
        public static Vector4i ComponentMax(Vector4i a, Vector4i b)
        {
            a.X = a.X > b.X ? a.X : b.X;
            a.Y = a.Y > b.Y ? a.Y : b.Y;
            a.Z = a.Z > b.Z ? a.Z : b.Z;
            a.W = a.W > b.W ? a.W : b.W;
            return a;
        }

        /// <summary>
        /// Calculate the component-wise maximum of two vectors
        /// </summary>
        public static void ComponentMax(ref Vector4i a, ref Vector4i b, out Vector4i result)
        {
            result.X = a.X > b.X ? a.X : b.X;
            result.Y = a.Y > b.Y ? a.Y : b.Y;
            result.Z = a.Z > b.Z ? a.Z : b.Z;
            result.W = a.W > b.W ? a.W : b.W;
        }

        #endregion Component Min/Max

        #region Min/Max

        /// <summary>
        /// Returns the Vector4i with the minimum magnitude
        /// </summary>
        /// <param name="left">Left operand</param>
        /// <param name="right">Right operand</param>
        /// <returns>The minimum Vector4i</returns>
        public static Vector4i Min(Vector4i left, Vector4i right)
        {
            return left.LengthSquared < right.LengthSquared ? left : right;
        }

        /// <summary>
        /// Returns the Vector4i with the minimum magnitude
        /// </summary>
        /// <param name="left">Left operand</param>
        /// <param name="right">Right operand</param>
        /// <returns>The minimum Vector4i</returns>
        public static Vector4i Max(Vector4i left, Vector4i right)
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
        public static Vector4i Clamp(Vector4i vec, Vector4i min, Vector4i max)
        {
            vec.X = vec.X < min.X ? min.X : vec.X > max.X ? max.X : vec.X;
            vec.Y = vec.Y < min.Y ? min.Y : vec.Y > max.Y ? max.Y : vec.Y;
            vec.Z = vec.X < min.Z ? min.Z : vec.Z > max.Z ? max.Z : vec.Z;
            vec.W = vec.Y < min.W ? min.W : vec.W > max.W ? max.W : vec.W;
            return vec;
        }

        /// <summary>
        /// Clamp a vector to the given minimum and maximum vectors
        /// </summary>
        /// <param name="vec">Input vector</param>
        /// <param name="min">Minimum vector</param>
        /// <param name="max">Maximum vector</param>
        /// <param name="result">The clamped vector</param>
        public static void Clamp(ref Vector4i vec, ref Vector4i min, ref Vector4i max, out Vector4i result)
        {
            result.X = vec.X < min.X ? min.X : vec.X > max.X ? max.X : vec.X;
            result.Y = vec.Y < min.Y ? min.Y : vec.Y > max.Y ? max.Y : vec.Y;
            result.Z = vec.X < min.Z ? min.Z : vec.Z > max.Z ? max.Z : vec.Z;
            result.W = vec.Y < min.W ? min.W : vec.W > max.W ? max.W : vec.W;
        }

        #endregion


        #region Dot

        /// <summary>
        /// Calculate the dot product of two vectors
        /// </summary>
        public static unit Dot(Vector4i left, Vector4i right)
        {
            return left.X * right.X + left.Y * right.Y
                    + left.Z * right.Z
                    + left.W * right.W
                    ;
        }

        /// <summary>
        /// Calculate the dot product of two vectors
        /// </summary>
        public static void Dot(ref Vector4i left, ref Vector4i right, out unit result)
        {
            result = left.X * right.X + left.Y * right.Y
                    + left.Z * right.Z
                    + left.W * right.W
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
        public static Vector4i Cross(Vector4i left, Vector4i right)
        {
            Vector4i result;
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
        public static void Cross(ref Vector4i left, ref Vector4i right, out Vector4i result)
        {
            result = new Vector4i(left.Y * right.Z - left.Z * right.Y,
                left.Z * right.X - left.X * right.Z,
                left.X * right.Y - left.Y * right.X
                , 1
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
        public static double CalculateAngle(Vector4i first, Vector4i second)
        {
            return System.Math.Acos((Vector4i.Dot(first, second)) / (first.Length * second.Length));
        }

        /// <summary>Calculates the angle (in radians) between two vectors.</summary>
        /// <param name="first">The first vector.</param>
        /// <param name="second">The second vector.</param>
        /// <param name="result">Angle (in radians) between the vectors.</param>
        /// <remarks>Note that the returned angle is never bigger than the constant Pi.</remarks>
        public static void CalculateAngle(ref Vector4i first, ref Vector4i second, out double result)
        {
            unit temp;
            Vector4i.Dot(ref first, ref second, out temp);
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
        public static Vector4i Lerp(Vector4i a, Vector4i b, unit blend)
        {
            a.X = blend * (b.X - a.X) + a.X;
            a.Y = blend * (b.Y - a.Y) + a.Y;
            a.Z = blend * (b.Z - a.Z) + a.Z;
            a.W = blend * (b.W - a.W) + a.W;
            return a;
        }

        /// <summary>
        /// Returns a new Vector that is the linear blend of the 2 given Vectors
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="blend">The blend factor. a when blend=0, b when blend=1.</param>
        /// <param name="result">a when blend=0, b when blend=1, and a linear combination otherwise</param>
        public static void Lerp(ref Vector4i a, ref Vector4i b, unit blend, out Vector4i result)
        {
            result.X = blend * (b.X - a.X) + a.X;
            result.Y = blend * (b.Y - a.Y) + a.Y;
            result.Z = blend * (b.Z - a.Z) + a.Z;
            result.W = blend * (b.W - a.W) + a.W;
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
        public static Vector4i BaryCentric(Vector4i a, Vector4i b, Vector4i c, unit u, unit v)
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
        public static void BaryCentric(ref Vector4i a, ref Vector4i b, ref Vector4i c, unit u, unit v, out Vector4i result)
        {
            result.X = a.X + u * (b.X - a.X) + v * (c.X - a.X);
            result.Y = a.Y + u * (b.Y - a.Y) + v * (c.Y - a.Y);
            result.Z = a.Z + u * (b.Z - a.Z) + v * (c.Z - a.Z);
            result.W = a.W + u * (b.W - a.W) + v * (c.W - a.W);

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



        /// <summary></summary>
        [XmlIgnore]
        public vec3 Xyz
        {
            get { return new vec3(X, Y, Z); }
            set
            {
                X = value.X;
                Y = value.Y;
                Z = value.Z;
            }
        }


        #endregion

        #region Operators

        /// <summary>
        /// Element-wise addition.
        /// </summary>
        public static Vector4i operator +(unit left, Vector4i right)
        {
            right.X += left;
            right.Y += left;
            right.Z += left;
            right.W += left;
            return right;
        }

        /// <summary>
        /// Element-wise addition.
        /// </summary>
        public static Vector4i operator +(Vector4i left, unit right)
        {
            left.X += right;
            left.Y += right;
            left.Z += right;
            left.W += right;
            return left;
        }

        /// <summary></summary>
        public static Vector4i operator +(Vector4i left, Vector4i right)
        {
            left.X += right.X;
            left.Y += right.Y;
            left.Z += right.Z;
            left.W += right.W;
            return left;
        }

        /// <summary>
        /// Element-wise subtraction.
        /// </summary>
        public static Vector4i operator -(unit left, Vector4i right)
        {
            right.X = left - right.X;
            right.Y = left - right.Y;
            right.Z = left - right.Z;
            right.W = left - right.W;
            return right;
        }
        
        /// <summary>
        /// Element-wise subtraction.
        /// </summary>
        public static Vector4i operator -(Vector4i left, unit right)
        {
            left.X -= right;
            left.Y -= right;
            left.Z -= right;
            left.W -= right;
            return left;
        }
        
        /// <summary></summary>
        public static Vector4i operator -(Vector4i left, Vector4i right)
        {
            left.X -= right.X;
            left.Y -= right.Y;
            left.Z -= right.Z;
            left.W -= right.W;
            return left;
        }

        /// <summary></summary>
        public static Vector4i operator -(Vector4i vec)
        {
            vec.X = -vec.X;
            vec.Y = -vec.Y;
            vec.Z = -vec.Z;
            vec.W = -vec.W;
            return vec;
        }

        /// <summary></summary>
        public static Vector4i operator *(Vector4i vec, unit scale)
        {
            vec.X *= scale;
            vec.Y *= scale;
            vec.Z *= scale;
            vec.W *= scale;
            return vec;
        }

        /// <summary></summary>
        public static Vector4i operator *(unit scale, Vector4i vec)
        {
            vec.X *= scale;
            vec.Y *= scale;
            vec.Z *= scale;
            vec.W *= scale;
            return vec;
        }

        /// <summary></summary>
        public static Vector4i operator / (Vector4i vec, double scale)
        {
            double mult = 1.0 / scale;
            return new Vector4i(
            vec.X * mult,
            vec.Y * mult
            , vec.Z * mult
            , vec.W * mult
                );
        }

        /// <summary></summary>
        public static Vector4i operator /(Vector4i vec, float scale)
        {
            float mult = 1.0f / scale;
            return new Vector4i(
            vec.X * mult,
            vec.Y * mult
            , vec.Z * mult
            , vec.W * mult
                );
        }

        /// <summary></summary>
        public static bool operator ==(Vector4i left, Vector4i right)
        {
            return left.Equals(right);
        }

        /// <summary></summary>
        public static bool operator !=(Vector4i left, Vector4i right)
        {
            return !left.Equals(right);
        }

        #endregion

        #region Overrides

        /// <summary></summary>
        public override string ToString()
        {
            const string format = "0";

            return String.Format("({0}, {1}, {2}, {3})'", X.ToString(format), Y.ToString(format), Z.ToString(format), W.ToString(format));
        }

        /// <summary></summary>
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode()
                ^ Z.GetHashCode()
                ^ W.GetHashCode()
                    ;
        }

        /// <summary></summary>
        public override bool Equals(object obj)
        {
            if (!(obj is Vector4i))
                return false;

            return this.Equals((Vector4i)obj);
        }

        #endregion

        #region IEquatable<Vector4i> Members

        /// <summary>Indicates whether the current vector is equal to another vector.</summary>
        /// <param name="other">A vector to compare with this vector.</param>
        /// <returns>true if the current vector is equal to the vector parameter; otherwise, false.</returns>
        public bool Equals(Vector4i other)
        {
            return X == other.X && Y == other.Y
                && Z == other.Z
                && W == other.W
                    ;
        }

        #endregion
    }
}
