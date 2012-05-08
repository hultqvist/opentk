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
    /// <summary>Represents a 4D vector using four single-precision doubleing-point numbers.</summary>
    /// <remarks>
    /// The Vector2d structure is suitable for interoperation with unmanaged code requiring four consecutive doubles.
    /// </remarks>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Vector2d : IEquatable<Vector2d>
    {
        /// <summary></summary>
        public double X;
        /// <summary></summary>
        public double Y;

        /// <summary>
        /// Defines the size of the Vector2d struct in bytes.
        /// </summary>
        public static readonly int SizeInBytes = Marshal.SizeOf(new Vector2d());

        #region Static: Unit-vectors and other help vectors

        /// <summary>
        /// Defines a unit-length Vector2d that points towards the X-axis.
        /// </summary>
        public static readonly Vector2d UnitX = new Vector2d(1, 0);

        /// <summary>
        /// Defines a unit-length Vector2d that points towards the Y-axis.
        /// </summary>
        public static readonly Vector2d UnitY = new Vector2d(0, 1);

        /// <summary>
        /// Defines a zero-length Vector2d.
        /// </summary>
        public static readonly Vector2d Zero = new Vector2d(0, 0);

        /// <summary>
        /// Defines an instance with all components set to 1.
        /// </summary>
        public static readonly Vector2d One = new Vector2d(1, 1);
        
        #endregion

        #region Constructors

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// <param name="value">The value that will initialize this instance.</param>
        public Vector2d(double value)
        {
            X = value;
            Y = value;
        }

        /// <summary>
        /// Constructs a new Vector2d.
        /// </summary>
        /// <param name="x">The x component of the Vector2d.</param>
        /// <param name="y">The y component of the Vector2d.</param>
        /// <param name="z">The z component of the Vector2d.</param>
        /// <param name="w">The w component of the Vector2d.</param>
        public Vector2d(double x, double y)
        {
            X = x;
            Y = y;
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
                return (double)System.Math.Sqrt(X * X + Y * Y);
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
                return 1.0f / MathHelper.InverseSqrtFast(X * X + Y * Y);
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
        public double LengthSquared
        {
            get
            {
                return X * X + Y * Y;
            }
        }

        #endregion

        #region Normalize

        /// <summary>
        /// Scales the Vector2d to unit length.
        /// </summary>
        public void Normalize()
        {
            double scale = 1.0f / this.Length;
            X *= scale;
            Y *= scale;
        }

        
        /// <summary>
        /// Scales the Vector2d to approximately unit length.
        /// </summary>
        public void NormalizeFast()
        {
            double scale = MathHelper.InverseSqrtFast(X * X + Y * Y);
            X *= scale;
            Y *= scale;
        }

        #endregion
     
        #region Multiply

        /// <summary>
        /// Multiplies a vector by a scalar.
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <param name="result">Result of the operation.</param>
        public static void Multiply(ref Vector2d vector, double scale, out Vector2d result)
        {
            result = new Vector2d(
                vector.X * scale,
                vector.Y * scale
            );
        }

        /// <summary>
        /// Multiplies a vector by the components a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        public static Vector2d Multiply(Vector2d vector, Vector2d scale)
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
        public static void Multiply(ref Vector2d vector, ref Vector2d scale, out Vector2d result)
        {
            result = new Vector2d(
                vector.X * scale.X,
                vector.Y * scale.Y
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
        public static Vector2d Divide(Vector2d vector, double scale)
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
        public static void Divide(ref Vector2d vector, double scale, out Vector2d result)
        {
            Multiply(ref vector, 1 / scale, out result);
        }

        /// <summary>
        /// Divides a vector by the components of a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        public static Vector2d Divide(Vector2d vector, Vector2d scale)
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
        public static void Divide(ref Vector2d vector, ref Vector2d scale, out Vector2d result)
        {
            result = new Vector2d(
                vector.X / scale.X,
                vector.Y / scale.Y
            );
        }

        #endregion

        #region Min

        /// <summary>
        /// Calculate the component-wise minimum of two vectors
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <returns>The component-wise minimum</returns>
        public static Vector2d Min(Vector2d a, Vector2d b)
        {
            a.X = a.X < b.X ? a.X : b.X;
            a.Y = a.Y < b.Y ? a.Y : b.Y;
            return a;
        }

        /// <summary>
        /// Calculate the component-wise minimum of two vectors
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <param name="result">The component-wise minimum</param>
        public static void Min(ref Vector2d a, ref Vector2d b, out Vector2d result)
        {
            result.X = a.X < b.X ? a.X : b.X;
            result.Y = a.Y < b.Y ? a.Y : b.Y;
        }

        #endregion

        #region Max

        /// <summary>
        /// Calculate the component-wise maximum of two vectors
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <returns>The component-wise maximum</returns>
        public static Vector2d Max(Vector2d a, Vector2d b)
        {
            a.X = a.X > b.X ? a.X : b.X;
            a.Y = a.Y > b.Y ? a.Y : b.Y;
            return a;
        }

        /// <summary>
        /// Calculate the component-wise maximum of two vectors
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <param name="result">The component-wise maximum</param>
        public static void Max(ref Vector2d a, ref Vector2d b, out Vector2d result)
        {
            result.X = a.X > b.X ? a.X : b.X;
            result.Y = a.Y > b.Y ? a.Y : b.Y;
        }

        #endregion

        #region Clamp

        /// <summary>
        /// Clamp a vector to the given minimum and maximum vectors
        /// </summary>
        /// <param name="vec">Input vector</param>
        /// <param name="min">Minimum vector</param>
        /// <param name="max">Maximum vector</param>
        /// <returns>The clamped vector</returns>
        public static Vector2d Clamp(Vector2d vec, Vector2d min, Vector2d max)
        {
            vec.X = vec.X < min.X ? min.X : vec.X > max.X ? max.X : vec.X;
            vec.Y = vec.Y < min.Y ? min.Y : vec.Y > max.Y ? max.Y : vec.Y;
            return vec;
        }

        /// <summary>
        /// Clamp a vector to the given minimum and maximum vectors
        /// </summary>
        /// <param name="vec">Input vector</param>
        /// <param name="min">Minimum vector</param>
        /// <param name="max">Maximum vector</param>
        /// <param name="result">The clamped vector</param>
        public static void Clamp(ref Vector2d vec, ref Vector2d min, ref Vector2d max, out Vector2d result)
        {
            result.X = vec.X < min.X ? min.X : vec.X > max.X ? max.X : vec.X;
            result.Y = vec.Y < min.Y ? min.Y : vec.Y > max.Y ? max.Y : vec.Y;
        }

        #endregion

        #region Normalize

        /// <summary>
        /// Scale a vector to unit length
        /// </summary>
        /// <param name="vec">The input vector</param>
        /// <returns>The normalized vector</returns>
        public static Vector2d Normalize(Vector2d vec)
        {
            double scale = 1.0f / vec.Length;
            vec.X *= scale;
            vec.Y *= scale;
            return vec;
        }

        /// <summary>
        /// Scale a vector to unit length
        /// </summary>
        /// <param name="vec">The input vector</param>
        /// <param name="result">The normalized vector</param>
        public static void Normalize(ref Vector2d vec, out Vector2d result)
        {
            double scale = 1.0f / vec.Length;
            result.X = vec.X * scale;
            result.Y = vec.Y * scale;
        }

        /// <summary>
        /// Scale a vector to approximately unit length
        /// </summary>
        /// <param name="vec">The input vector</param>
        /// <returns>The normalized vector</returns>
        public static Vector2d NormalizeFast(Vector2d vec)
        {
            double scale = MathHelper.InverseSqrtFast(vec.X * vec.X + vec.Y * vec.Y);
            vec.X *= scale;
            vec.Y *= scale;
            return vec;
        }

        /// <summary>
        /// Scale a vector to approximately unit length
        /// </summary>
        /// <param name="vec">The input vector</param>
        /// <param name="result">The normalized vector</param>
        public static void NormalizeFast(ref Vector2d vec, out Vector2d result)
        {
            double scale = MathHelper.InverseSqrtFast(vec.X * vec.X + vec.Y * vec.Y);
            result.X = vec.X * scale;
            result.Y = vec.Y * scale;
        }

        #endregion

        #region Dot

        /// <summary>
        /// Calculate the dot product of two vectors
        /// </summary>
        public static double Dot(Vector2d left, Vector2d right)
        {
            return left.X * right.X + left.Y * right.Y;
        }

        /// <summary>
        /// Calculate the dot product of two vectors
        /// </summary>
        public static void Dot(ref Vector2d left, ref Vector2d right, out double result)
        {
            result = left.X * right.X + left.Y * right.Y;
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
        public static Vector2d Lerp(Vector2d a, Vector2d b, double blend)
        {
            a.X = blend * (b.X - a.X) + a.X;
            a.Y = blend * (b.Y - a.Y) + a.Y;
            return a;
        }

        /// <summary>
        /// Returns a new Vector that is the linear blend of the 2 given Vectors
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="blend">The blend factor. a when blend=0, b when blend=1.</param>
        /// <param name="result">a when blend=0, b when blend=1, and a linear combination otherwise</param>
        public static void Lerp(ref Vector2d a, ref Vector2d b, double blend, out Vector2d result)
        {
            result.X = blend * (b.X - a.X) + a.X;
            result.Y = blend * (b.Y - a.Y) + a.Y;
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
        public static Vector2d BaryCentric(Vector2d a, Vector2d b, Vector2d c, double u, double v)
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
        public static void BaryCentric(ref Vector2d a, ref Vector2d b, ref Vector2d c, double u, double v, out Vector2d result)
        {
            result.X = a.X + u * (b.X - a.X) + v * (c.X - a.X);
            result.Y = a.Y + u * (b.Y - a.Y) + v * (c.Y - a.Y);
        }

        #endregion

        #region Operators

        /// <summary>
        /// Element-wise addition.
        /// </summary>
        public static Vector2d operator +(double left, Vector2d right)
        {
            right.X += left;
            right.Y += left;
            return right;
        }

        /// <summary>
        /// Element-wise addition.
        /// </summary>
        public static Vector2d operator +(Vector2d left, double right)
        {
            left.X += right;
            left.Y += right;
            return left;
        }

        /// <summary>
        /// Adds two instances.
        /// </summary>
        public static Vector2d operator +(Vector2d left, Vector2d right)
        {
            left.X += right.X;
            left.Y += right.Y;
            return left;
        }

        /// <summary>
        /// Element-wise subtraction.
        /// </summary>
        public static Vector2d operator -(double left, Vector2d right)
        {
            right.X = left - right.X;
            right.Y = left - right.Y;
            return right;
        }
        
        /// <summary>
        /// Element-wise subtraction.
        /// </summary>
        public static Vector2d operator -(Vector2d left, double right)
        {
            left.X -= right;
            left.Y -= right;
            return left;
        }
        
        /// <summary>
        /// Subtracts two instances.
        /// </summary>
        public static Vector2d operator -(Vector2d left, Vector2d right)
        {
            left.X -= right.X;
            left.Y -= right.Y;
            return left;
        }

        /// <summary>
        /// Negates an instance.
        /// </summary>
        public static Vector2d operator -(Vector2d vec)
        {
            vec.X = -vec.X;
            vec.Y = -vec.Y;
            return vec;
        }

        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        public static Vector2d operator *(Vector2d vec, double scale)
        {
            vec.X *= scale;
            vec.Y *= scale;
            return vec;
        }

        /// <summary>
        /// Multiplies an instance by a scalar.
        /// </summary>
        public static Vector2d operator *(double scale, Vector2d vec)
        {
            vec.X *= scale;
            vec.Y *= scale;
            return vec;
        }

        /// <summary>
        /// Divides an instance by a scalar.
        /// </summary>
        public static Vector2d operator /(Vector2d vec, double scale)
        {
            double mult = 1.0f / scale;
            vec.X *= mult;
            vec.Y *= mult;
            return vec;
        }

        /// <summary>
        /// Compares two instances for equality.
        /// </summary>
        /// <returns>True, if left equals right; false otherwise.</returns>
        public static bool operator ==(Vector2d left, Vector2d right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares two instances for inequality.
        /// </summary>
        /// <returns>True, if left does not equa lright; false otherwise.</returns>
        public static bool operator !=(Vector2d left, Vector2d right)
        {
            return !left.Equals(right);
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Returns a System.String that represents the current Vector2d.
        /// </summary>
        public override string ToString()
        {
            return String.Format(
                "({0}, {1}, {2}, {3})'",
                X.ToString("0.0"),
                Y.ToString("0.0"));
        }

        /// <summary>
        /// </summary>
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }

        /// <summary>
        /// </summary>
        public override bool Equals(object obj)
        {
            if (!(obj is Vector2d))
                return false;

            return this.Equals((Vector2d)obj);
        }

        #endregion

        #region IEquatable<Vector2d> Members

        /// <summary>Indicates whether the current vector is equal to another vector.</summary>
        /// <param name="other">A vector to compare with this vector.</param>
        /// <returns>true if the current vector is equal to the vector parameter; otherwise, false.</returns>
        public bool Equals(Vector2d other)
        {
            return
                X == other.X &&
                Y == other.Y;
        }

        #endregion
    }
}
