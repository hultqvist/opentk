﻿// Generated by Generator.Template using template Math/VectorTemplate.cs

#define TEMPLATE_DIM_3
#define TEMPLATE_DIM_4
#define TEMPLATE_UNIT_HALF

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
    using unit = Half;
    using vec2 = Vector2h;
    using vec3 = Vector3h;

    /// <summary>Represents a 4D vector using four unit.</summary>
    /// <remarks>
    /// The Vector4h structure is suitable for interoperation with unmanaged code requiring four consecutive units.
    /// </remarks>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct Vector4h : IEquatable<Vector4h>
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
        /// Defines the size of the Vector4h struct in bytes.
        /// </summary>
        public static readonly int SizeInBytes = Marshal.SizeOf(new Vector4h());

        #region Static: Unit-vectors and other help vectors

        /// <summary>
        /// Defines a unit-length Vector4h that points along the X-axis.
        /// </summary>
        public static readonly Vector4h UnitX = new Vector4h((unit)1, (unit)0
                                                           , (unit)0
                                                           , (unit)0
                                                           );

        /// <summary>
        /// Defines a unit-length Vector4h that points along the Y-axis.
        /// </summary>
        public static readonly Vector4h UnitY = new Vector4h((unit)0, (unit)1
                                                           , (unit)0
                                                           , (unit)0
                                                           );

        /// <summary>
        /// Defines a unit-length Vector4h that points along the Z-axis.
        /// </summary>
        public static readonly Vector4h UnitZ = new Vector4h((unit)0, (unit)0, (unit)1
                                                           , (unit)0
                                                           );

        /// <summary>
        /// Defines a unit-length Vector4h that points along the W-axis.
        /// </summary>
        public static readonly Vector4h UnitW = new Vector4h((unit)0, (unit)0, (unit)0, (unit)1);

        /// <summary>
        /// Defines a zero-length Vector4h.
        /// </summary>
        public static readonly Vector4h Zero = new Vector4h((unit)0);

        /// <summary>
        /// Defines an instance with all components set to 1.
        /// </summary>
        public static readonly Vector4h One = new Vector4h((unit)1);
        
        #endregion Static: Unit-vectors and other help vectors

        #region Constructors

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// <param name="value">The value that will initialize all components.</param>
        public Vector4h(unit value)
        {
            X = value;
            Y = value;
            Z = value;
            W = value;
        }

        /// <summary>
        /// Constructs a new Vector4h.
        /// </summary>
        public Vector4h(
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

        #if !TEMPLATE_UNIT_INT32

        /// <summary>
        /// Return a Vector4h scaled to unit length.
        /// </summary>
        public Vector4h Normalize()
        {
            unit scale = (unit)( 1.0 / this.Length);
            return new Vector4h(X * scale, Y * scale
                               , Z * scale
                               , W * scale
                               );
        }

        
        /// <summary>
        /// Return a Vector4h scaled to approximately unit length.
        /// </summary>
        public Vector4h NormalizeFast()
        {
            unit scale = MathHelper.InverseSqrtFast(X * X + Y * Y
                                                      + Z * Z
                                                      + W * W
                                                     );
            return new Vector4h(X * scale, Y * scale
                               , Z * scale
                               , W * scale
                               );
        }

        #endif // !TEMPLATE_UNIT_INT32

        #endregion
     
        #region Multiply

        /// <summary>
        /// Multiplies a vector by a scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <param name="result">Result of the operation.</param>
        public static void Multiply(ref Vector4h vector, unit scale, out Vector4h result)
        {
            result = new Vector4h(
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
        public static Vector4h Multiply(Vector4h vector, Vector4h scale)
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
        public static void Multiply(ref Vector4h vector, ref Vector4h scale, out Vector4h result)
        {
            result = new Vector4h(
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
        public static Vector4h Divide(Vector4h vector, unit scale)
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
        public static void Divide(ref Vector4h vector, unit scale, out Vector4h result)
        {
            Multiply(ref vector, 1 / scale, out result);
        }

        /// <summary>
        /// Divides a vector by the components of a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        public static Vector4h Divide(Vector4h vector, Vector4h scale)
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
        public static void Divide(ref Vector4h vector, ref Vector4h scale, out Vector4h result)
        {
            result = new Vector4h(
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
        public static Vector4h ComponentMin(Vector4h a, Vector4h b)
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
        public static void ComponentMin(ref Vector4h a, ref Vector4h b, out Vector4h result)
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
        public static Vector4h ComponentMax(Vector4h a, Vector4h b)
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
        public static void ComponentMax(ref Vector4h a, ref Vector4h b, out Vector4h result)
        {
            result.X = a.X > b.X ? a.X : b.X;
            result.Y = a.Y > b.Y ? a.Y : b.Y;
            result.Z = a.Z > b.Z ? a.Z : b.Z;
            result.W = a.W > b.W ? a.W : b.W;
        }

        #endregion Component Min/Max

        #region Min/Max

        /// <summary>
        /// Returns the Vector4h with the minimum magnitude
        /// </summary>
        /// <param name="left">Left operand</param>
        /// <param name="right">Right operand</param>
        /// <returns>The minimum Vector4h</returns>
        public static Vector4h Min(Vector4h left, Vector4h right)
        {
            return left.LengthSquared < right.LengthSquared ? left : right;
        }

        /// <summary>
        /// Returns the Vector4h with the minimum magnitude
        /// </summary>
        /// <param name="left">Left operand</param>
        /// <param name="right">Right operand</param>
        /// <returns>The minimum Vector4h</returns>
        public static Vector4h Max(Vector4h left, Vector4h right)
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
        public static Vector4h Clamp(Vector4h vec, Vector4h min, Vector4h max)
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
        public static void Clamp(ref Vector4h vec, ref Vector4h min, ref Vector4h max, out Vector4h result)
        {
            result.X = vec.X < min.X ? min.X : vec.X > max.X ? max.X : vec.X;
            result.Y = vec.Y < min.Y ? min.Y : vec.Y > max.Y ? max.Y : vec.Y;
            result.Z = vec.X < min.Z ? min.Z : vec.Z > max.Z ? max.Z : vec.Z;
            result.W = vec.Y < min.W ? min.W : vec.W > max.W ? max.W : vec.W;
        }

        #endregion

        #region Normalize

        #if !TEMPLATE_UNIT_INT32

        /// <summary>
        /// Scale a vector to unit length(1)
        /// </summary>
        /// <param name="vec">The input vector</param>
        /// <param name="result">The normalized vector</param>
        public static void Normalize(ref Vector4h vec, out Vector4h result)
        {
            unit scale = 1.0f / (unit)vec.Length;
            result.X = vec.X * scale;
            result.Y = vec.Y * scale;
            result.Z = vec.Z * scale;
            result.W = vec.W * scale;
        }

        /// <summary>
        /// Scale a vector to approximately unit length
        /// </summary>
        /// <param name="vec">The input vector</param>
        /// <param name="result">The normalized vector</param>
        public static void NormalizeFast(ref Vector4h vec, out Vector4h result)
        {
            unit scale = MathHelper.InverseSqrtFast(vec.X * vec.X + vec.Y * vec.Y
                                                      + vec.Z * vec.Z
                                                      + vec.W * vec.W
                                                     );
            result.X = vec.X * scale;
            result.Y = vec.Y * scale;
            result.Z = vec.Z * scale;
            result.W = vec.W * scale;
        }

        #endif

        #endregion

        #region Dot

        /// <summary>
        /// Calculate the dot product of two vectors
        /// </summary>
        public static unit Dot(Vector4h left, Vector4h right)
        {
            return left.X * right.X + left.Y * right.Y
                    + left.Z * right.Z
                    + left.W * right.W
                    ;
        }

        /// <summary>
        /// Calculate the dot product of two vectors
        /// </summary>
        public static void Dot(ref Vector4h left, ref Vector4h right, out unit result)
        {
            result = left.X * right.X + left.Y * right.Y
                    + left.Z * right.Z
                    + left.W * right.W
                    ;
        }

        #endregion

        #region Lerp

        /// <summary>
        /// Returns a new Vector that is the linear blend of the 2 given Vectors
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="blend">The blend factor. a when blend=0, b when blend=1.</param>
        /// <returns>a when blend=0, b when blend=1, and a linear combination otherwise</returns>
        public static Vector4h Lerp(Vector4h a, Vector4h b, unit blend)
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
        public static void Lerp(ref Vector4h a, ref Vector4h b, unit blend, out Vector4h result)
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
        public static Vector4h BaryCentric(Vector4h a, Vector4h b, Vector4h c, unit u, unit v)
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
        public static void BaryCentric(ref Vector4h a, ref Vector4h b, ref Vector4h c, unit u, unit v, out Vector4h result)
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
        public static Vector4h operator +(unit left, Vector4h right)
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
        public static Vector4h operator +(Vector4h left, unit right)
        {
            left.X += right;
            left.Y += right;
            left.Z += right;
            left.W += right;
            return left;
        }

        /// <summary></summary>
        public static Vector4h operator +(Vector4h left, Vector4h right)
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
        public static Vector4h operator -(unit left, Vector4h right)
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
        public static Vector4h operator -(Vector4h left, unit right)
        {
            left.X -= right;
            left.Y -= right;
            left.Z -= right;
            left.W -= right;
            return left;
        }
        
        /// <summary></summary>
        public static Vector4h operator -(Vector4h left, Vector4h right)
        {
            left.X -= right.X;
            left.Y -= right.Y;
            left.Z -= right.Z;
            left.W -= right.W;
            return left;
        }

        /// <summary></summary>
        public static Vector4h operator -(Vector4h vec)
        {
            vec.X = -vec.X;
            vec.Y = -vec.Y;
            vec.Z = -vec.Z;
            vec.W = -vec.W;
            return vec;
        }

        /// <summary></summary>
        public static Vector4h operator *(Vector4h vec, unit scale)
        {
            vec.X *= scale;
            vec.Y *= scale;
            vec.Z *= scale;
            vec.W *= scale;
            return vec;
        }

        /// <summary></summary>
        public static Vector4h operator *(unit scale, Vector4h vec)
        {
            vec.X *= scale;
            vec.Y *= scale;
            vec.Z *= scale;
            vec.W *= scale;
            return vec;
        }

        /// <summary></summary>
        public static Vector4h operator / (Vector4h vec, double scale)
        {
            double mult = 1.0 / scale;
            return new Vector4h(
            vec.X * mult,
            vec.Y * mult
            , vec.Z * mult
            , vec.W * mult
                );
        }

        /// <summary></summary>
        public static Vector4h operator /(Vector4h vec, float scale)
        {
            float mult = 1.0f / scale;
            return new Vector4h(
            vec.X * mult,
            vec.Y * mult
            , vec.Z * mult
            , vec.W * mult
                );
        }

        /// <summary></summary>
        public static bool operator ==(Vector4h left, Vector4h right)
        {
            return left.Equals(right);
        }

        /// <summary></summary>
        public static bool operator !=(Vector4h left, Vector4h right)
        {
            return !left.Equals(right);
        }

        #endregion

        #region Overrides

        /// <summary></summary>
        public override string ToString()
        {
            const string format = "0.0";

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
            if (!(obj is Vector4h))
                return false;

            return this.Equals((Vector4h)obj);
        }

        #endregion

        #region IEquatable<Vector4h> Members

        /// <summary>Indicates whether the current vector is equal to another vector.</summary>
        /// <param name="other">A vector to compare with this vector.</param>
        /// <returns>true if the current vector is equal to the vector parameter; otherwise, false.</returns>
        public bool Equals(Vector4h other)
        {
            return X == other.X && Y == other.Y
                && Z == other.Z
                && W == other.W
                    ;
        }

        #endregion
    }
}
