// Template for Vector[234][d_hi].cs
// Run Generator.Template to generate the Vector files
#define TEMPLATE_DIM_3
#define TEMPLATE_DIM_4
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
using System.Xml.Serialization;

namespace OpenTK
{
#if TEMPLATE_UNIT_DOUBLE
    using unit = System.Double;
    using vec2 = Vector2d;
    using vec3 = Vector3d;
#elif TEMPLATE_UNIT_SINGLE
    using unit = System.Single;
    using vec2 = Vector2;
    using vec3 = Vector3;
#elif TEMPLATE_UNIT_INT32
    using unit = System.Int32;
    using vec2 = Vector2i;
    using vec3 = Vector3i;
#elif TEMPLATE_UNIT_HALF
    using unit = Half;
    using vec2 = Vector2h;
    using vec3 = Vector3h;
#endif

    /// <summary>Represents a 4D vector using four unit.</summary>
    /// <remarks>
    /// The VectorTemplate structure is suitable for interoperation with unmanaged code requiring four consecutive units.
    /// </remarks>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct VectorTemplate : IEquatable<VectorTemplate>
    {
        /// <summary></summary>
        public unit X;
        /// <summary></summary>
        public unit Y;
        #if TEMPLATE_DIM_3
        /// <summary></summary>
        public unit Z;
        #if TEMPLATE_DIM_4
        /// <summary></summary>
        public unit W;
        #endif
        #endif

        /// <summary>
        /// Defines the size of the VectorTemplate struct in bytes.
        /// </summary>
        public static readonly int SizeInBytes = Marshal.SizeOf(new VectorTemplate());

        #region Static: Unit-vectors and other help vectors

        /// <summary>
        /// Defines a unit-length VectorTemplate that points along the X-axis.
        /// </summary>
        public static readonly VectorTemplate UnitX = new VectorTemplate((unit)1, (unit)0
                #if TEMPLATE_DIM_3
                                                           , (unit)0
                #if TEMPLATE_DIM_4
                                                           , (unit)0
                #endif
                #endif
                                                           );

        /// <summary>
        /// Defines a unit-length VectorTemplate that points along the Y-axis.
        /// </summary>
        public static readonly VectorTemplate UnitY = new VectorTemplate((unit)0, (unit)1
                #if TEMPLATE_DIM_3
                                                           , (unit)0
                #if TEMPLATE_DIM_4
                                                           , (unit)0
                #endif
                #endif
                                                           );

        #if TEMPLATE_DIM_3
        /// <summary>
        /// Defines a unit-length VectorTemplate that points along the Z-axis.
        /// </summary>
        public static readonly VectorTemplate UnitZ = new VectorTemplate((unit)0, (unit)0, (unit)1
                #if TEMPLATE_DIM_4
                                                           , (unit)0
                #endif
                                                           );
        #endif

        #if TEMPLATE_DIM_4
        /// <summary>
        /// Defines a unit-length VectorTemplate that points along the W-axis.
        /// </summary>
        public static readonly VectorTemplate UnitW = new VectorTemplate((unit)0, (unit)0, (unit)0, (unit)1);
        #endif

        /// <summary>
        /// Defines a zero-length VectorTemplate.
        /// </summary>
        public static readonly VectorTemplate Zero = new VectorTemplate((unit)0);

        /// <summary>
        /// Defines an instance with all components set to 1.
        /// </summary>
        public static readonly VectorTemplate One = new VectorTemplate((unit)1);
        
        #endregion Static: Unit-vectors and other help vectors

        #region Constructors

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        /// <param name="value">The value that will initialize all components.</param>
        public VectorTemplate(unit value)
        {
            X = value;
            Y = value;
#if TEMPLATE_DIM_3
            Z = value;
#if TEMPLATE_DIM_4
            W = value;
#endif
#endif
        }

        /// <summary>
        /// Constructs a new VectorTemplate.
        /// </summary>
        public VectorTemplate(
            unit x, unit y
            #if TEMPLATE_DIM_3
            , unit z
            #if TEMPLATE_DIM_4
            , unit w
            #endif
            #endif
        )
        {
            X = x;
            Y = y;
            #if TEMPLATE_DIM_3
            Z = z;
            #if TEMPLATE_DIM_4
            W = w;
            #endif
            #endif
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
                #if TEMPLATE_DIM_3
                    + Z * Z
                #if TEMPLATE_DIM_4
                    + W * W
                #endif
                #endif
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
                #if TEMPLATE_DIM_3
                    + Z * Z
                #if TEMPLATE_DIM_4
                    + W * W
                #endif
                #endif
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
                #if TEMPLATE_DIM_3
                    + Z * Z
                #if TEMPLATE_DIM_4
                    + W * W
                #endif
                #endif
                    ;
            }
        }

        #endregion

        #region Normalize

        #if !TEMPLATE_UNIT_INT32

        /// <summary>
        /// Return a VectorTemplate scaled to unit length.
        /// </summary>
        public VectorTemplate Normalize()
        {
            unit scale = (unit)( 1.0 / this.Length);
            return new VectorTemplate(X * scale, Y * scale
                #if TEMPLATE_DIM_3
                               , Z * scale
                #if TEMPLATE_DIM_4
                               , W * scale
                #endif
                #endif
                               );
        }

        
        /// <summary>
        /// Return a VectorTemplate scaled to approximately unit length.
        /// </summary>
        public VectorTemplate NormalizeFast()
        {
            unit scale = MathHelper.InverseSqrtFast(X * X + Y * Y
                #if TEMPLATE_DIM_3
                                                      + Z * Z
                #if TEMPLATE_DIM_4
                                                      + W * W
                #endif
                #endif
                                                     );
            return new VectorTemplate(X * scale, Y * scale
                #if TEMPLATE_DIM_3
                               , Z * scale
                #if TEMPLATE_DIM_4
                               , W * scale
                #endif
                #endif
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
        public static void Multiply(ref VectorTemplate vector, unit scale, out VectorTemplate result)
        {
            result = new VectorTemplate(
                vector.X * scale,
                vector.Y * scale
                #if TEMPLATE_DIM_3
                , vector.Z * scale
                #if TEMPLATE_DIM_4
                , vector.W * scale
                #endif
                #endif
            );
        }

        /// <summary>
        /// Multiplies a vector by the components a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        public static VectorTemplate Multiply(VectorTemplate vector, VectorTemplate scale)
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
        public static void Multiply(ref VectorTemplate vector, ref VectorTemplate scale, out VectorTemplate result)
        {
            result = new VectorTemplate(
                vector.X * scale.X,
                vector.Y * scale.Y
                #if TEMPLATE_DIM_3
                , vector.Z * scale.Z
                #if TEMPLATE_DIM_4
                , vector.W * scale.W
                #endif
                #endif
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
        public static VectorTemplate Divide(VectorTemplate vector, unit scale)
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
        public static void Divide(ref VectorTemplate vector, unit scale, out VectorTemplate result)
        {
            Multiply(ref vector, 1 / scale, out result);
        }

        /// <summary>
        /// Divides a vector by the components of a vector (scale).
        /// </summary>
        /// <param name="vector">Left operand.</param>
        /// <param name="scale">Right operand.</param>
        /// <returns>Result of the operation.</returns>
        public static VectorTemplate Divide(VectorTemplate vector, VectorTemplate scale)
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
        public static void Divide(ref VectorTemplate vector, ref VectorTemplate scale, out VectorTemplate result)
        {
            result = new VectorTemplate(
                vector.X / scale.X,
                vector.Y / scale.Y
                #if TEMPLATE_DIM_3
                , vector.Z / scale.Z
                #if TEMPLATE_DIM_4
                , vector.W / scale.W
                #endif
                #endif
            );
        }

        #endregion

        #region Component Min/Max

        /// <summary>
        /// Calculate the component-wise minimum of two vectors
        /// </summary>
        /// <returns>The component-wise minimum</returns>
        public static VectorTemplate ComponentMin(VectorTemplate a, VectorTemplate b)
        {
            a.X = a.X < b.X ? a.X : b.X;
            a.Y = a.Y < b.Y ? a.Y : b.Y;
                #if TEMPLATE_DIM_3
            a.Z = a.Z < b.Z ? a.Z : b.Z;
                #if TEMPLATE_DIM_4
            a.W = a.W < b.W ? a.W : b.W;
                #endif
                #endif
            return a;
        }

        /// <summary>
        /// Calculate the component-wise minimum of two vectors
        /// </summary>
        public static void ComponentMin(ref VectorTemplate a, ref VectorTemplate b, out VectorTemplate result)
        {
            result.X = a.X < b.X ? a.X : b.X;
            result.Y = a.Y < b.Y ? a.Y : b.Y;
                #if TEMPLATE_DIM_3
            result.Z = a.Z < b.Z ? a.Z : b.Z;
                #if TEMPLATE_DIM_4
            result.W = a.W < b.W ? a.W : b.W;
                #endif
                #endif
        }

        /// <summary>
        /// Calculate the component-wise maximum of two vectors
        /// </summary>
        /// <returns>The component-wise maximum</returns>
        public static VectorTemplate ComponentMax(VectorTemplate a, VectorTemplate b)
        {
            a.X = a.X > b.X ? a.X : b.X;
            a.Y = a.Y > b.Y ? a.Y : b.Y;
                #if TEMPLATE_DIM_3
            a.Z = a.Z > b.Z ? a.Z : b.Z;
                #if TEMPLATE_DIM_4
            a.W = a.W > b.W ? a.W : b.W;
                #endif
                #endif
            return a;
        }

        /// <summary>
        /// Calculate the component-wise maximum of two vectors
        /// </summary>
        public static void ComponentMax(ref VectorTemplate a, ref VectorTemplate b, out VectorTemplate result)
        {
            result.X = a.X > b.X ? a.X : b.X;
            result.Y = a.Y > b.Y ? a.Y : b.Y;
                #if TEMPLATE_DIM_3
            result.Z = a.Z > b.Z ? a.Z : b.Z;
                #if TEMPLATE_DIM_4
            result.W = a.W > b.W ? a.W : b.W;
                #endif
                #endif
        }

        #endregion Component Min/Max

        #region Min/Max

        /// <summary>
        /// Returns the VectorTemplate with the minimum magnitude
        /// </summary>
        /// <param name="left">Left operand</param>
        /// <param name="right">Right operand</param>
        /// <returns>The minimum VectorTemplate</returns>
        public static VectorTemplate Min(VectorTemplate left, VectorTemplate right)
        {
            return left.LengthSquared < right.LengthSquared ? left : right;
        }

        /// <summary>
        /// Returns the VectorTemplate with the minimum magnitude
        /// </summary>
        /// <param name="left">Left operand</param>
        /// <param name="right">Right operand</param>
        /// <returns>The minimum VectorTemplate</returns>
        public static VectorTemplate Max(VectorTemplate left, VectorTemplate right)
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
        public static VectorTemplate Clamp(VectorTemplate vec, VectorTemplate min, VectorTemplate max)
        {
            vec.X = vec.X < min.X ? min.X : vec.X > max.X ? max.X : vec.X;
            vec.Y = vec.Y < min.Y ? min.Y : vec.Y > max.Y ? max.Y : vec.Y;
                #if TEMPLATE_DIM_3
            vec.Z = vec.X < min.Z ? min.Z : vec.Z > max.Z ? max.Z : vec.Z;
                #if TEMPLATE_DIM_4
            vec.W = vec.Y < min.W ? min.W : vec.W > max.W ? max.W : vec.W;
                #endif
                #endif
            return vec;
        }

        /// <summary>
        /// Clamp a vector to the given minimum and maximum vectors
        /// </summary>
        /// <param name="vec">Input vector</param>
        /// <param name="min">Minimum vector</param>
        /// <param name="max">Maximum vector</param>
        /// <param name="result">The clamped vector</param>
        public static void Clamp(ref VectorTemplate vec, ref VectorTemplate min, ref VectorTemplate max, out VectorTemplate result)
        {
            result.X = vec.X < min.X ? min.X : vec.X > max.X ? max.X : vec.X;
            result.Y = vec.Y < min.Y ? min.Y : vec.Y > max.Y ? max.Y : vec.Y;
                #if TEMPLATE_DIM_3
            result.Z = vec.X < min.Z ? min.Z : vec.Z > max.Z ? max.Z : vec.Z;
                #if TEMPLATE_DIM_4
            result.W = vec.Y < min.W ? min.W : vec.W > max.W ? max.W : vec.W;
                #endif
                #endif
        }

        #endregion

        #if !TEMPLATE_UNIT_INT32

        #region Normalize

        /// <summary>
        /// Scale a vector to unit length(1)
        /// </summary>
        /// <param name="vec">The input vector</param>
        /// <param name="result">The normalized vector</param>
        public static void Normalize(ref VectorTemplate vec, out VectorTemplate result)
        {
            unit scale = 1.0f / (unit)vec.Length;
            result.X = vec.X * scale;
            result.Y = vec.Y * scale;
                #if TEMPLATE_DIM_3
            result.Z = vec.Z * scale;
                #if TEMPLATE_DIM_4
            result.W = vec.W * scale;
                #endif
                #endif
        }

        /// <summary>
        /// Scale a vector to approximately unit length
        /// </summary>
        /// <param name="vec">The input vector</param>
        /// <param name="result">The normalized vector</param>
        public static void NormalizeFast(ref VectorTemplate vec, out VectorTemplate result)
        {
            unit scale = MathHelper.InverseSqrtFast(vec.X * vec.X + vec.Y * vec.Y
                #if TEMPLATE_DIM_3
                                                      + vec.Z * vec.Z
                #if TEMPLATE_DIM_4
                                                      + vec.W * vec.W
                #endif
                #endif
                                                     );
            result.X = vec.X * scale;
            result.Y = vec.Y * scale;
                #if TEMPLATE_DIM_3
            result.Z = vec.Z * scale;
                #if TEMPLATE_DIM_4
            result.W = vec.W * scale;
                #endif
                #endif
        }

        #endregion

        #endif

        #region Dot

        /// <summary>
        /// Calculate the dot product of two vectors
        /// </summary>
        public static unit Dot(VectorTemplate left, VectorTemplate right)
        {
            return left.X * right.X + left.Y * right.Y
                #if TEMPLATE_DIM_3
                    + left.Z * right.Z
                #if TEMPLATE_DIM_4
                    + left.W * right.W
                #endif
                #endif
                    ;
        }

        /// <summary>
        /// Calculate the dot product of two vectors
        /// </summary>
        public static void Dot(ref VectorTemplate left, ref VectorTemplate right, out unit result)
        {
            result = left.X * right.X + left.Y * right.Y
                #if TEMPLATE_DIM_3
                    + left.Z * right.Z
                #if TEMPLATE_DIM_4
                    + left.W * right.W
                #endif
                #endif
                    ;
        }

        #endregion
                
        #if TEMPLATE_DIM_3
                
        #region Cross product

        /// <summary>
        /// Caclulate the 3D cross (vector) product of two vectors
        /// </summary>
        /// <param name="left">First operand</param>
        /// <param name="right">Second operand</param>
        /// <returns>The cross product of the two inputs</returns>
        public static VectorTemplate Cross(VectorTemplate left, VectorTemplate right)
        {
            VectorTemplate result;
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
        public static void Cross(ref VectorTemplate left, ref VectorTemplate right, out VectorTemplate result)
        {
            result = new VectorTemplate(left.Y * right.Z - left.Z * right.Y,
                left.Z * right.X - left.X * right.Z,
                left.X * right.Y - left.Y * right.X
            #if TEMPLATE_DIM_4
                , 1
            #endif
            );
        }
 
        #endregion Cross product

        #endif

        #region Calculate Angle

        /// <summary>
        /// Calculates the angle (in radians) between two vectors.
        /// </summary>
        /// <param name="first">The first vector.</param>
        /// <param name="second">The second vector.</param>
        /// <returns>Angle (in radians) between the vectors.</returns>
        /// <remarks>Note that the returned angle is never bigger than the constant Pi.</remarks>
        public static double CalculateAngle(VectorTemplate first, VectorTemplate second)
        {
            return System.Math.Acos((VectorTemplate.Dot(first, second)) / (first.Length * second.Length));
        }

        /// <summary>Calculates the angle (in radians) between two vectors.</summary>
        /// <param name="first">The first vector.</param>
        /// <param name="second">The second vector.</param>
        /// <param name="result">Angle (in radians) between the vectors.</param>
        /// <remarks>Note that the returned angle is never bigger than the constant Pi.</remarks>
        public static void CalculateAngle(ref VectorTemplate first, ref VectorTemplate second, out double result)
        {
            unit temp;
            VectorTemplate.Dot(ref first, ref second, out temp);
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
        public static VectorTemplate Lerp(VectorTemplate a, VectorTemplate b, unit blend)
        {
            a.X = blend * (b.X - a.X) + a.X;
            a.Y = blend * (b.Y - a.Y) + a.Y;
                #if TEMPLATE_DIM_3
            a.Z = blend * (b.Z - a.Z) + a.Z;
                #if TEMPLATE_DIM_4
            a.W = blend * (b.W - a.W) + a.W;
                #endif
                #endif
            return a;
        }

        /// <summary>
        /// Returns a new Vector that is the linear blend of the 2 given Vectors
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="blend">The blend factor. a when blend=0, b when blend=1.</param>
        /// <param name="result">a when blend=0, b when blend=1, and a linear combination otherwise</param>
        public static void Lerp(ref VectorTemplate a, ref VectorTemplate b, unit blend, out VectorTemplate result)
        {
            result.X = blend * (b.X - a.X) + a.X;
            result.Y = blend * (b.Y - a.Y) + a.Y;
                #if TEMPLATE_DIM_3
            result.Z = blend * (b.Z - a.Z) + a.Z;
                #if TEMPLATE_DIM_4
            result.W = blend * (b.W - a.W) + a.W;
                #endif
                #endif
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
        public static VectorTemplate BaryCentric(VectorTemplate a, VectorTemplate b, VectorTemplate c, unit u, unit v)
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
        public static void BaryCentric(ref VectorTemplate a, ref VectorTemplate b, ref VectorTemplate c, unit u, unit v, out VectorTemplate result)
        {
            result.X = a.X + u * (b.X - a.X) + v * (c.X - a.X);
            result.Y = a.Y + u * (b.Y - a.Y) + v * (c.Y - a.Y);
                #if TEMPLATE_DIM_3
            result.Z = a.Z + u * (b.Z - a.Z) + v * (c.Z - a.Z);
                #if TEMPLATE_DIM_4
            result.W = a.W + u * (b.W - a.W) + v * (c.W - a.W);
                #endif
                #endif

        }

        #endregion

        #region Swizzle

        #if TEMPLATE_DIM_3

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

        #endif

        #if TEMPLATE_DIM_4

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

        #endif

        #endregion

        #region Operators

        /// <summary>
        /// Element-wise addition.
        /// </summary>
        public static VectorTemplate operator +(unit left, VectorTemplate right)
        {
            right.X += left;
            right.Y += left;
                #if TEMPLATE_DIM_3
            right.Z += left;
                #if TEMPLATE_DIM_4
            right.W += left;
                #endif
                #endif
            return right;
        }

        /// <summary>
        /// Element-wise addition.
        /// </summary>
        public static VectorTemplate operator +(VectorTemplate left, unit right)
        {
            left.X += right;
            left.Y += right;
                #if TEMPLATE_DIM_3
            left.Z += right;
                #if TEMPLATE_DIM_4
            left.W += right;
                #endif
                #endif
            return left;
        }

        /// <summary></summary>
        public static VectorTemplate operator +(VectorTemplate left, VectorTemplate right)
        {
            left.X += right.X;
            left.Y += right.Y;
                #if TEMPLATE_DIM_3
            left.Z += right.Z;
                #if TEMPLATE_DIM_4
            left.W += right.W;
                #endif
                #endif
            return left;
        }

        /// <summary>
        /// Element-wise subtraction.
        /// </summary>
        public static VectorTemplate operator -(unit left, VectorTemplate right)
        {
            right.X = left - right.X;
            right.Y = left - right.Y;
                #if TEMPLATE_DIM_3
            right.Z = left - right.Z;
                #if TEMPLATE_DIM_4
            right.W = left - right.W;
                #endif
                #endif
            return right;
        }
        
        /// <summary>
        /// Element-wise subtraction.
        /// </summary>
        public static VectorTemplate operator -(VectorTemplate left, unit right)
        {
            left.X -= right;
            left.Y -= right;
                #if TEMPLATE_DIM_3
            left.Z -= right;
                #if TEMPLATE_DIM_4
            left.W -= right;
                #endif
                #endif
            return left;
        }
        
        /// <summary></summary>
        public static VectorTemplate operator -(VectorTemplate left, VectorTemplate right)
        {
            left.X -= right.X;
            left.Y -= right.Y;
                #if TEMPLATE_DIM_3
            left.Z -= right.Z;
                #if TEMPLATE_DIM_4
            left.W -= right.W;
                #endif
                #endif
            return left;
        }

        /// <summary></summary>
        public static VectorTemplate operator -(VectorTemplate vec)
        {
            vec.X = -vec.X;
            vec.Y = -vec.Y;
                #if TEMPLATE_DIM_3
            vec.Z = -vec.Z;
                #if TEMPLATE_DIM_4
            vec.W = -vec.W;
                #endif
                #endif
            return vec;
        }

        /// <summary></summary>
        public static VectorTemplate operator *(VectorTemplate vec, unit scale)
        {
            vec.X *= scale;
            vec.Y *= scale;
                #if TEMPLATE_DIM_3
            vec.Z *= scale;
                #if TEMPLATE_DIM_4
            vec.W *= scale;
                #endif
                #endif
            return vec;
        }

        /// <summary></summary>
        public static VectorTemplate operator *(unit scale, VectorTemplate vec)
        {
            vec.X *= scale;
            vec.Y *= scale;
                #if TEMPLATE_DIM_3
            vec.Z *= scale;
                #if TEMPLATE_DIM_4
            vec.W *= scale;
                #endif
                #endif
            return vec;
        }

        /// <summary></summary>
        public static VectorTemplate operator / (VectorTemplate vec, double scale)
        {
            double mult = 1.0 / scale;
            return new VectorTemplate(
            vec.X * mult,
            vec.Y * mult
                #if TEMPLATE_DIM_3
            , vec.Z * mult
                #if TEMPLATE_DIM_4
            , vec.W * mult
                #endif
                #endif
                );
        }

        /// <summary></summary>
        public static VectorTemplate operator /(VectorTemplate vec, float scale)
        {
            float mult = 1.0f / scale;
            return new VectorTemplate(
            vec.X * mult,
            vec.Y * mult
                #if TEMPLATE_DIM_3
            , vec.Z * mult
                #if TEMPLATE_DIM_4
            , vec.W * mult
                #endif
                #endif
                );
        }

        /// <summary></summary>
        public static bool operator ==(VectorTemplate left, VectorTemplate right)
        {
            return left.Equals(right);
        }

        /// <summary></summary>
        public static bool operator !=(VectorTemplate left, VectorTemplate right)
        {
            return !left.Equals(right);
        }

        #endregion

        #region Overrides

        /// <summary></summary>
        public override string ToString()
        {
            #if TEMPLATE_UNIT_INT32
            const string format = "0";
            #else
            const string format = "0.0";
            #endif
            return ToString(format);
        }

        /// <summary></summary>
        public string ToString(string format)
        {
            #if TEMPLATE_DIM_4
            return String.Format("({0}, {1}, {2}, {3})'", X.ToString(format), Y.ToString(format), Z.ToString(format), W.ToString(format));
            #else
            #if TEMPLATE_DIM_3
            return String.Format("({0}, {1}, {2})'", X.ToString(format), Y.ToString(format), Z.ToString(format));
            #else
            return String.Format("({0}, {1})'", X.ToString(format), Y.ToString(format));
            #endif
            #endif
        }

        /// <summary></summary>
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode()
                #if TEMPLATE_DIM_3
                ^ Z.GetHashCode()
                #if TEMPLATE_DIM_4
                ^ W.GetHashCode()
                #endif
                #endif
                    ;
        }

        /// <summary></summary>
        public override bool Equals(object obj)
        {
            if (!(obj is VectorTemplate))
                return false;

            return this.Equals((VectorTemplate)obj);
        }

        #endregion

        #region IEquatable<VectorTemplate> Members

        /// <summary>Indicates whether the current vector is equal to another vector.</summary>
        /// <param name="other">A vector to compare with this vector.</param>
        /// <returns>true if the current vector is equal to the vector parameter; otherwise, false.</returns>
        public bool Equals(VectorTemplate other)
        {
            return X == other.X && Y == other.Y
                #if TEMPLATE_DIM_3
                && Z == other.Z
                #if TEMPLATE_DIM_4
                && W == other.W
                #endif
                #endif
                    ;
        }

        #endregion
    }
}
