// Template for Vector[234][d_hi].cs
// Run Generator.Template to generate the Vector files
#define TEMPLATE_DIM_3
//#define TEMPLATE_DIM_4
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

namespace OpenTK
{
#if TEMPLATE_UNIT_DOUBLE
    using unit = System.Double;
    using unitQuaternion = Quaterniond;
    using vec3 = Vector3d;
    #if TEMPLATE_DIM_4
    using vec = Vector4d;
    #else
    using vec = Vector3d;
    #endif
#elif TEMPLATE_UNIT_SINGLE
    using unit = System.Single;
    using unitQuaternion = Quaternion;
    using vec3 = Vector3;
    #if TEMPLATE_DIM_4
    using vec = Vector4;
    #else
    using vec = Vector3;
    #endif
#endif    

    /// <summary>
    /// <para>Represents a 4x4 Matrix</para>
    /// <para>Storage is column-major and vectors are assumed to be column vectors.</para>
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public partial struct MatrixTemplate : IEquatable<MatrixTemplate>
    {
        /// <summary></summary>
        public vec Column0;
        /// <summary></summary>
        public vec Column1;
        /// <summary></summary>
        public vec Column2;
#if TEMPLATE_DIM_4
        /// <summary></summary>
        public vec Column3;
#endif

        private const unit one = 1;

        #region Rows
        
        /// <summary>
        /// The first column of this matrix
        /// </summary>
        public vec Row0
        {
            get
            {
                return new vec(
                    Column0.X,
                    Column1.X,
                    Column2.X
#if TEMPLATE_DIM_4
                    , Column3.X
#endif
                );
            }
        }

        /// <summary>
        /// The second column of this matrix
        /// </summary>
        public vec Row1
        {
            get
            {
                return new vec(
                    Column0.Y,
                    Column1.Y,
                    Column2.Y
                #if TEMPLATE_DIM_4
                    ,Column3.Y
                #endif
                );
            }
        }

        /// <summary>
        /// The third column of this matrix
        /// </summary>
        public vec Row2
        {
            get
            {
                return new vec(
                    Column0.Z,
                    Column1.Z,
                    Column2.Z
                #if TEMPLATE_DIM_4
                    ,Column3.Z
                #endif
                );
            }
        }

        #if TEMPLATE_DIM_4

        /// <summary>
        /// The fourth column of this matrix
        /// </summary>
        public vec Row3
        {
            get { return new vec(Column0.W, Column1.W, Column2.W, Column3.W); }
        }
        #endif

        #endregion

        #region Constructors

        /// <summary></summary>
        public MatrixTemplate(vec column0, vec column1, vec column2
#if TEMPLATE_DIM_4
                              , vec column3
#endif
        )
        {
            Column0 = column0;
            Column1 = column1;
            Column2 = column2;
#if TEMPLATE_DIM_4
            Column3 = column3;
#endif
        }

#if TEMPLATE_DIM_4
        /// <summary>
        /// Initializes a matrix, parameters are indexed mRowCol
        /// </summary>
        public MatrixTemplate(
            unit m00, unit m01, unit m02, unit m03,
            unit m10, unit m11, unit m12, unit m13,
            unit m20, unit m21, unit m22, unit m23,
            unit m30, unit m31, unit m32, unit m33)
        {
            Column0 = new vec(m00, m10, m20, m30);
            Column1 = new vec(m01, m11, m21, m31);
            Column2 = new vec(m02, m12, m22, m32);
            Column3 = new vec(m03, m13, m23, m33);
        }
#else
        /// <summary>
        /// Initializes a matrix, parameters are indexed mRowCol
        /// </summary>
        public MatrixTemplate(
            unit m00, unit m01, unit m02,
            unit m10, unit m11, unit m12,
            unit m20, unit m21, unit m22)
        {
            Column0 = new vec(m00, m10, m20);
            Column1 = new vec(m01, m11, m21);
            Column2 = new vec(m02, m12, m22);
        }
#endif

        #endregion

        #region Instance Operations

#if TEMPLATE_DIM_4
        /// <summary>
        /// The determinant of this matrix
        /// </summary>
        public unit Determinant()
        {
            //Determinant of a 2x2 matrix with rows 2-3 and columns from their index
            //no 00
            unit d01 = Column0.Z * Column1.W - Column1.Z * Column0.W;
            unit d02 = Column0.Z * Column2.W - Column2.Z * Column0.W;
            unit d03 = Column0.Z * Column3.W - Column3.Z * Column0.W;
            //     d10 = Col1.Z * Col0.W - Col0.Z * Col1.W;
            //no 11
            unit d12 = Column1.Z * Column2.W - Column2.Z * Column1.W;
            unit d13 = Column1.Z * Column3.W - Column3.Z * Column1.W;
            //     d20 = Col2.Z * Col0.W - Col0.Z * Col2.W;
            //     d21 = Col2.Z * Col1.W - Col1.Z * Col2.W;
            //no22
            unit d23 = Column2.Z * Column3.W - Column3.Z * Column2.W;
            //     d30 = Col3.Z * Col0.W - Col0.Z * Col3.W;
            //     d31 = Col3.Z * Col1.W - Col1.Z * Col3.W;
            //     d32 = Col3.Z * Col2.W - Col2.Z * Col3.W;
            //no33
                            
            //Determinant of a 3x3 matrix with rows 1-3 and columns form their index
            unit d123 = Column1.Y * d23 - Column2.Y * d13 + Column3.Y * d12;
            unit d023 = Column0.Y * d23 - Column2.Y * d03 + Column3.Y * d02;
            unit d013 = Column0.Y * d13 - Column1.Y * d03 + Column3.Y * d01;
            unit d012 = Column0.Y * d12 - Column1.Y * d02 + Column2.Y * d01;
            
            return Column0.X * d123 - Column1.X * d023 + Column2.X * d013 - Column3.X * d012;
        }
#endif

        /// <summary>
        /// Return the inverse of the matrix.
        /// </summary>
        public MatrixTemplate Invert()
        {
            return MatrixTemplate.Invert(this);
        }

        /// <summary>
        /// Return the transpose of the matrix
        /// </summary>
        public MatrixTemplate Transpose()
        {
            return MatrixTemplate.Transpose(this);
        }

        #endregion

        #region Static: Matrix generation

        /// <summary>
        /// The identity matrix
        /// </summary>
        public static readonly MatrixTemplate Identity = new MatrixTemplate(
                vec.UnitX,
                vec.UnitY,
                vec.UnitZ
#if TEMPLATE_DIM_4
                ,vec.UnitW
#endif
            );

        #region RotationQuaternion
        
        /// <summary>
        /// Build a rotation matrix from the specified quaternion.
        /// </summary>
        /// <param name="q">Quaternion to translate.</param>
        /// <param name="m">Matrix result.</param>
        public static void RotationQuaternion(ref unitQuaternion q, ref MatrixTemplate m)
        {
            unit scale = one / q.Length;
            
            unit X = q.X * scale;
            unit Y = q.Y * scale;
            unit Z = q.Z * scale;
            unit W = q.W * scale;

            unit xx = X * X;
            unit xy = X * Y;
            unit xz = X * Z;
            unit xw = X * W;
            unit yy = Y * Y;
            unit yz = Y * Z;
            unit yw = Y * W;
            unit zz = Z * Z;
            unit zw = Z * W;

            m.Column0.X = 1 - 2 * (yy + zz);
            m.Column0.Y = 2 * (xy + zw);
            m.Column0.Z = 2 * (xz - yw);

            m.Column1.X = 2 * (xy - zw);
            m.Column1.Y = 1 - 2 * (xx + zz);
            m.Column1.Z = 2 * (yz + xw);

            m.Column2.X = 2 * (xz + yw);
            m.Column2.Y = 2 * (yz - xw);
            m.Column2.Z = 1 - 2 * (xx + yy);

#if TEMPLATE_DIM_4
            m.Column0.W = 0;
            m.Column1.W = 0;
            m.Column2.W = 0;
            m.Column3.X = 0;
            m.Column3.Y = 0;
            m.Column3.Z = 0;
            m.Column3.W = 1;
#endif
        }

        /// <summary>
        /// Build a rotation matrix from the specified quaternion.
        /// </summary>
        /// <param name="q">Quaternion to translate.</param>
        /// <returns>A matrix instance.</returns>
        public static MatrixTemplate RotationQuaternion(ref unitQuaternion q)
        {
            MatrixTemplate m = new MatrixTemplate();
            RotationQuaternion(ref q, ref m);
            return m;
        }

        #endregion

        #region RotationAxisAngle
        
        /// <summary>
        /// Build a rotation matrix from the specified axis/angle rotation.
        /// </summary>
        /// <param name="axis">The axis to rotate about.</param>
        /// <param name="angle">Angle in radians to rotate counter-clockwise (looking in the direction of the given axis).</param>
        /// <param name="result">A matrix instance.</param>
        public static void RotationAxisAngle(vec3 axis, double angle, out MatrixTemplate result)
        {
            unit cos = (unit)System.Math.Cos(-angle);
            unit sin = (unit)System.Math.Sin(-angle);
            unit t = one - cos;

            axis.Normalize();
#if TEMPLATE_DIM_4
            result = new MatrixTemplate(t * axis.X * axis.X + cos, t * axis.X * axis.Y - sin * axis.Z, t * axis.X * axis.Z + sin * axis.Y, 0,
                                 t * axis.X * axis.Y + sin * axis.Z, t * axis.Y * axis.Y + cos, t * axis.Y * axis.Z - sin * axis.X, 0,
                                 t * axis.X * axis.Z - sin * axis.Y, t * axis.Y * axis.Z + sin * axis.X, t * axis.Z * axis.Z + cos, 0,
                                 0, 0, 0, 1);
#else
            result = new MatrixTemplate(t * axis.X * axis.X + cos, t * axis.X * axis.Y - sin * axis.Z, t * axis.X * axis.Z + sin * axis.Y,
                                 t * axis.X * axis.Y + sin * axis.Z, t * axis.Y * axis.Y + cos, t * axis.Y * axis.Z - sin * axis.X,
                                 t * axis.X * axis.Z - sin * axis.Y, t * axis.Y * axis.Z + sin * axis.X, t * axis.Z * axis.Z + cos);
#endif
        }
        
        /// <summary>
        /// Build a rotation matrix from the specified axis/angle rotation.
        /// </summary>
        /// <param name="axis">The axis to rotate about.</param>
        /// <param name="angle">Angle in radians to rotate counter-clockwise (looking in the direction of the given axis).</param>
        /// <returns>A matrix instance.</returns>
        public static MatrixTemplate RotationAxisAngle(vec3 axis, double angle)
        {
            MatrixTemplate result;
            RotationAxisAngle(axis, angle, out result);
            return result;
        }
        
        #endregion

        #region Rotation[XYZ]

        /// <summary>
        /// Builds a rotation matrix for a right-hand rotation around the x-axis.
        /// </summary>
        /// <param name="angle">The right-hand rotation in radians around the x-axis.</param>
        /// <param name="result">The resulting MatrixTemplate instance.</param>
        public static void RotationX(double angle, out MatrixTemplate result)
        {
            unit cos = (unit)System.Math.Cos(angle);
            unit sin = (unit)System.Math.Sin(angle);

            #if TEMPLATE_DIM_4
            result.Column0 = vec.UnitX;
            result.Column1 = new vec(0, cos, sin, 0);
            result.Column2 = new vec(0, -sin, cos, 0);
            result.Column3 = vec.UnitW;
            #else
            result.Column0 = vec.UnitX;
            result.Column1 = new vec(0, cos, sin);
            result.Column2 = new vec(0, -sin, cos);
            #endif
        }

        /// <summary>
        /// Builds a rotation matrix for a right-hand rotation around the x-axis.
        /// </summary>
        /// <param name="angle">The right-hand rotation in radians around the x-axis.</param>
        /// <returns>The resulting MatrixTemplate instance.</returns>
        public static MatrixTemplate RotationX(double angle)
        {
            MatrixTemplate result;
            RotationX(angle, out result);
            return result;
        }

        /// <summary>
        /// Builds a rotation matrix for a right-hand rotation around the y-axis.
        /// </summary>
        /// <param name="angle">The right-hand rotation in radians around the y-axis.</param>
        /// <param name="result">The resulting MatrixTemplate instance.</param>
        public static void RotationY(double angle, out MatrixTemplate result)
        {
            unit cos = (unit)System.Math.Cos(angle);
            unit sin = (unit)System.Math.Sin(angle);

            #if TEMPLATE_DIM_4
            result.Column0 = new vec(cos, 0, -sin, 0);
            result.Column1 = vec.UnitY;
            result.Column2 = new vec(sin, 0, cos, 0);
            result.Column3 = vec.UnitW;
            #else
            result.Column0 = new vec(cos, 0, -sin);
            result.Column1 = vec.UnitY;
            result.Column2 = new vec(sin, 0, cos);
            #endif
        }

        /// <summary>
        /// Builds a rotation matrix for a right-hand rotation around the y-axis.
        /// </summary>
        /// <param name="angle">The right-hand rotation in radians around the y-axis.</param>
        /// <returns>The resulting MatrixTemplate instance.</returns>
        public static MatrixTemplate RotationY(double angle)
        {
            MatrixTemplate result;
            RotationY(angle, out result);
            return result;
        }

        /// <summary>
        /// Builds a rotation matrix for a right-hand rotation around the z-axis.
        /// </summary>
        /// <param name="angle">The right-hand rotation in radians around the z-axis.</param>
        /// <param name="result">The resulting MatrixTemplate instance.</param>
        public static void RotationZ(double angle, out MatrixTemplate result)
        {
            unit cos = (unit)System.Math.Cos(angle);
            unit sin = (unit)System.Math.Sin(angle);

            #if TEMPLATE_DIM_4
            result.Column0 = new vec(cos, sin, 0, 0);
            result.Column1 = new vec(-sin, cos, 0, 0);
            result.Column2 = vec.UnitZ;
            result.Column3 = vec.UnitW;
            #else
            result.Column0 = new vec(cos, sin, 0);
            result.Column1 = new vec(-sin, cos, 0);
            result.Column2 = vec.UnitZ;
            #endif
        }

        /// <summary>
        /// Builds a rotation matrix for a right-hand rotation around the z-axis.
        /// </summary>
        /// <param name="angle">The right-hand rotation in radians around the z-axis.</param>
        /// <returns>The resulting MatrixTemplate instance.</returns>
        public static MatrixTemplate RotationZ(double angle)
        {
            MatrixTemplate result;
            RotationZ(angle, out result);
            return result;
        }

        #endregion

#if TEMPLATE_DIM_4

        #region Translation
            
        /// <summary>
        /// Creates a translation matrix.
        /// </summary>
        public static void Translation(unit x, unit y, unit z, out MatrixTemplate result)
        {
            result = Identity;
            result.Column3 = new vec(x, y, z, 1);
        }

        /// <summary>
        /// Creates a translation matrix.
        /// </summary>
        public static void Translation(ref vec3 vector, out MatrixTemplate result)
        {
            result = Identity;
            result.Column3 = new vec(vector.X, vector.Y, vector.Z, 1);
        }

        /// <summary>
        /// Creates a translation matrix.
        /// </summary>
        /// <param name="x">X translation.</param>
        /// <param name="y">Y translation.</param>
        /// <param name="z">Z translation.</param>
        /// <returns>The resulting MatrixTemplate instance.</returns>
        public static MatrixTemplate Translation(unit x, unit y, unit z)
        {
            MatrixTemplate result;
            Translation(x, y, z, out result);
            return result;
        }

        /// <summary>
        /// Creates a translation matrix.
        /// </summary>
        /// <param name="vector">The translation vector.</param>
        /// <returns>The resulting MatrixTemplate instance.</returns>
        public static MatrixTemplate Translation(vec3 vector)
        {
            MatrixTemplate result;
            Translation(vector.X, vector.Y, vector.Z, out result);
            return result;
        }

        #endregion

        #region Orthographic

        /// <summary>
        /// Creates an orthographic projection matrix.
        /// </summary>
        /// <param name="xWidth">The width of the projection volume.</param>
        /// <param name="yHeight">The height of the projection volume.</param>
        /// <param name="zNear">The near edge of the projection volume.</param>
        /// <param name="zFar">The far edge of the projection volume.</param>
        /// <param name="result">The resulting MatrixTemplate instance.</param>
        public static void Orthographic(unit xWidth, unit yHeight, unit zNear, unit zFar, out MatrixTemplate result)
        {
            OrthographicOffCenter(
                -xWidth / 2,
                xWidth / 2,
                -yHeight / 2,
                yHeight / 2,
                zNear,
                zFar,
                out result
            );
        }

        /// <summary>
        /// Creates an orthographic projection matrix.
        /// </summary>
        /// <param name="width">The width of the projection volume.</param>
        /// <param name="height">The height of the projection volume.</param>
        /// <param name="zNear">The near edge of the projection volume.</param>
        /// <param name="zFar">The far edge of the projection volume.</param>
        /// <rereturns>The resulting MatrixTemplate instance.</rereturns>
        public static MatrixTemplate Orthographic(unit width, unit height, unit zNear, unit zFar)
        {
            MatrixTemplate result;
            OrthographicOffCenter(
                -width / 2,
                width / 2,
                -height / 2,
                height / 2,
                zNear,
                zFar,
                out result
            );
            return result;
        }

        /// <summary>
        /// Creates an orthographic projection matrix.
        /// Looking into the direction of negative Z.
        /// </summary>
        /// <param name="left">The left edge of the projection volume.</param>
        /// <param name="right">The right edge of the projection volume.</param>
        /// <param name="bottom">The bottom edge of the projection volume.</param>
        /// <param name="top">The top edge of the projection volume.</param>
        /// <param name="zNear">The near edge of the projection volume.</param>
        /// <param name="zFar">The far edge of the projection volume.</param>
        /// <param name="result">The resulting MatrixTemplate instance.</param>
        public static void OrthographicOffCenter(unit left, unit right, unit bottom, unit top, unit zNear, unit zFar, out MatrixTemplate result)
        {
            result = new MatrixTemplate();

            unit invRL = 1 / (right - left);
            unit invTB = 1 / (top - bottom);
            unit invFN = 1 / (zNear - zFar);

            result.Column0.X = 2 * invRL;
            result.Column1.Y = 2 * invTB;
            result.Column2.Z = 2 * invFN;

            result.Column3.X = -(right + left) * invRL;
            result.Column3.Y = -(top + bottom) * invTB;
            result.Column3.Z = -(zFar + zNear) * invFN;
            result.Column3.W = 1;
        }

        /// <summary>
        /// Creates an orthographic projection matrix.
        /// Looking into the direction of negative Z.
        /// </summary>
        /// <param name="left">The left edge of the projection volume.</param>
        /// <param name="right">The right edge of the projection volume.</param>
        /// <param name="bottom">The bottom edge of the projection volume.</param>
        /// <param name="top">The top edge of the projection volume.</param>
        /// <param name="zNear">The near edge of the projection volume.</param>
        /// <param name="zFar">The far edge of the projection volume.</param>
        /// <returns>The resulting MatrixTemplate instance.</returns>
        public static MatrixTemplate OrthographicOffCenter(unit left, unit right, unit bottom, unit top, unit zNear, unit zFar)
        {
            MatrixTemplate result;
            OrthographicOffCenter(
                left,
                right,
                bottom,
                top,
                zNear,
                zFar,
                out result
            );
            return result;
        }

        #endregion
        
        #region PerspectiveFieldOfView
        
        /// <summary>
        /// Creates a perspective projection matrix.
        /// </summary>
        /// <param name="fovy">Angle of the field of view in the y direction (in radians)</param>
        /// <param name="aspect">Aspect ratio of the view (width / height)</param>
        /// <param name="zNear">Distance to the near clip plane</param>
        /// <param name="zFar">Distance to the far clip plane</param>
        /// <param name="result">A projection matrix that transforms camera space to raster space</param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown under the following conditions:
        /// <list type="bullet">
        /// <item>fovy is zero, less than zero or larger than Math.PI</item>
        /// <item>aspect is negative or zero</item>
        /// <item>zNear is negative or zero</item>
        /// <item>zFar is negative or zero</item>
        /// <item>zNear is larger than zFar</item>
        /// </list>
        /// </exception>
        public static void PerspectiveFieldOfView(double fovy, unit aspect, unit zNear, unit zFar, out MatrixTemplate result)
        {
            if (fovy <= 0 || fovy > Math.PI)
                throw new ArgumentOutOfRangeException("fovy");
            if (aspect <= 0)
                throw new ArgumentOutOfRangeException("aspect");

            unit yMax = (unit)(Math.Abs(zNear) * System.Math.Tan(0.5f * fovy));
            unit ymin = -yMax;
            unit xMin = ymin * aspect;
            unit xMax = yMax * aspect;

            PerspectiveOffCenter(
                xMin,
                xMax,
                ymin,
                yMax,
                zNear,
                zFar,
                out result
            );
        }

        /// <summary>
        /// Creates a perspective projection matrix.
        /// </summary>
        /// <param name="fovy">Angle of the field of view in the y direction (in radians)</param>
        /// <param name="aspect">Aspect ratio of the view (width / height)</param>
        /// <param name="zNear">Distance to the near clip plane</param>
        /// <param name="zFar">Distance to the far clip plane</param>
        /// <param name="result">A projection matrix that transforms camera space to raster space</param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown under the following conditions:
        /// <list type="bullet">
        /// <item>fovy is zero, less than zero or larger than Math.PI</item>
        /// <item>aspect is negative or zero</item>
        /// <item>zNear is negative or zero</item>
        /// <item>zFar is negative or zero</item>
        /// <item>zNear is larger than zFar</item>
        /// </list>
        /// </exception>
        public static void PerspectiveHorizontalFieldOfView(double fovy, unit aspect, unit zNear, unit zFar, out MatrixTemplate result)
        {
            if (fovy <= 0 || fovy > Math.PI)
                throw new ArgumentOutOfRangeException("fovy");
            if (aspect <= 0)
                throw new ArgumentOutOfRangeException("aspect");

            unit xMax = (unit)(Math.Abs(zNear) * System.Math.Tan(0.5f * fovy));
            unit xMin = -xMax;
            unit yMin = xMin / aspect;
            unit yMax = xMax / aspect;

            PerspectiveOffCenter(
                xMin,
                xMax,
                yMin,
                yMax,
                zNear,
                zFar,
                out result
            );
        }


        /// <summary>
        /// Creates a perspective projection matrix.
        /// </summary>
        /// <param name="fovy">Angle of the field of view in the y direction (in radians)</param>
        /// <param name="aspect">Aspect ratio of the view (width / height)</param>
        /// <param name="zNear">Distance to the near clip plane</param>
        /// <param name="zFar">Distance to the far clip plane</param>
        /// <returns>A projection matrix that transforms camera space to raster space</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown under the following conditions:
        /// <list type="bullet">
        /// <item>fovy is zero, less than zero or larger than Math.PI</item>
        /// <item>aspect is negative or zero</item>
        /// <item>zNear is negative or zero</item>
        /// <item>zFar is negative or zero</item>
        /// <item>zNear is larger than zFar</item>
        /// </list>
        /// </exception>
        public static MatrixTemplate PerspectiveFieldOfView(double fovy, unit aspect, unit zNear, unit zFar)
        {
            MatrixTemplate result;
            PerspectiveFieldOfView(fovy, aspect, zNear, zFar, out result);
            return result;
        }
        
        /// <summary>
        /// Creates an perspective projection matrix.
        /// </summary>
        /// <param name="left">Left edge of the view frustum</param>
        /// <param name="right">Right edge of the view frustum</param>
        /// <param name="bottom">Bottom edge of the view frustum</param>
        /// <param name="top">Top edge of the view frustum</param>
        /// <param name="zNear">Distance to the near clip plane</param>
        /// <param name="zFar">Distance to the far clip plane</param>
        /// <param name="result">A projection matrix that transforms camera space to raster space</param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown under the following conditions:
        /// <list type="bullet">
        /// <item>zNear is negative or zero</item>
        /// </list>
        /// </exception>
        public static void PerspectiveOffCenter(unit left, unit right, unit bottom, unit top, unit zNear, unit zFar, out MatrixTemplate result)
        {
            unit x, y, a, b, c, d;
            unit xSize = right - left;
            unit ySize = top - bottom;

            if (zNear > 0)
            {
                if (zFar < zNear)
                    throw new ArgumentOutOfRangeException(
                        "zFar",
                        "Required: abs(zFar) > abs(zNear)"
                    );

                //Positive Z
                x = 2.0f * zNear / xSize;
                y = 2.0f * zNear / ySize;
                a = (right + left) / xSize;
                b = (top + bottom) / ySize;
                c = -(zFar + zNear) / (zFar - zNear);
                d = -(2.0f * zFar * zNear) / (zFar - zNear);
            }
            else
            {
                if (zFar > zNear)
                    throw new ArgumentOutOfRangeException(
                        "zFar",
                        "Required: abs(zFar) > abs(zNear)"
                    );

                //Negative Z
                x = -2.0f * zNear / xSize;
                y = -2.0f * zNear / ySize;
                a = (right + left) / xSize;
                b = (top + bottom) / ySize;
                c = (zFar + zNear) / (zFar - zNear);
                d = -2.0f * zFar * zNear / (zFar - zNear);
            }

            result = new MatrixTemplate(x, 0, a, 0,
                                 0, y, b, 0,
                                 0, 0, c, d,
                                 0, 0, -1, 0);
        }
        
        /// <summary>
        /// Creates an perspective projection matrix.
        /// </summary>
        /// <param name="left">Left edge of the view frustum</param>
        /// <param name="right">Right edge of the view frustum</param>
        /// <param name="bottom">Bottom edge of the view frustum</param>
        /// <param name="top">Top edge of the view frustum</param>
        /// <param name="zNear">Distance to the near clip plane</param>
        /// <param name="zFar">Distance to the far clip plane</param>
        /// <returns>A projection matrix that transforms camera space to raster space</returns>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown under the following conditions:
        /// <list type="bullet">
        /// <item>zNear is negative or zero</item>
        /// <item>zFar is negative or zero</item>
        /// <item>zNear is larger than zFar</item>
        /// </list>
        /// </exception>
        public static MatrixTemplate PerspectiveOffCenter(unit left, unit right, unit bottom, unit top, unit zNear, unit zFar)
        {
            MatrixTemplate result;
            PerspectiveOffCenter(
                left,
                right,
                bottom,
                top,
                zNear,
                zFar,
                out result
            );
            return result;
        }
        
        #endregion

#endif

        #region Scale Functions

        /// <summary>
        /// Build a scaling matrix
        /// </summary>
        /// <param name="scale">Single scale factor for x,y and z axes</param>
        /// <returns>A scaling matrix</returns>
        public static MatrixTemplate Scale(unit scale)
        {
            return Scale(scale, scale, scale);
        }

        /// <summary>
        /// Build a scaling matrix
        /// </summary>
        /// <param name="scale">Scale factors for x,y and z axes</param>
        /// <returns>A scaling matrix</returns>
        public static MatrixTemplate Scale(vec3 scale)
        {
            return Scale(scale.X, scale.Y, scale.Z);
        }

        /// <summary>
        /// Build a scaling matrix
        /// </summary>
        /// <param name="x">Scale factor for x-axis</param>
        /// <param name="y">Scale factor for y-axis</param>
        /// <param name="z">Scale factor for z-axis</param>
        /// <returns>A scaling matrix</returns>
        public static MatrixTemplate Scale(unit x, unit y, unit z)
        {
            MatrixTemplate result = new MatrixTemplate();
            result.Column0.X = x;
            result.Column1.Y = y;
            result.Column2.Z = z;
#if TEMPLATE_DIM_4
            result.Column3.W = 1;
#endif
            return result;
        }

        #endregion

        #endregion

        #region Operators

        /// <summary>
        /// Compares two instances for equality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left equals right; false otherwise.</returns>
        public static bool operator ==(MatrixTemplate left, MatrixTemplate right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares two instances for inequality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left does not equal right; false otherwise.</returns>
        public static bool operator !=(MatrixTemplate left, MatrixTemplate right)
        {
            return !left.Equals(right);
        }
        
        /// <summary>
        /// Element-wise addition.
        /// </summary>
        public static MatrixTemplate operator +(unit left, MatrixTemplate right)
        {
            MatrixTemplate m = new MatrixTemplate();
            m.Column0 = left + right.Column0;
            m.Column1 = left + right.Column1;
            m.Column2 = left + right.Column2;
            #if TEMPLATE_DIM_4
            m.Column3 = left + right.Column3;
            #endif
            return m;
        }

        /// <summary>
        /// Element-wise addition.
        /// </summary>
        public static MatrixTemplate operator +(MatrixTemplate left, unit right)
        {
            MatrixTemplate m = new MatrixTemplate();
            m.Column0 = left.Column0 + right;
            m.Column1 = left.Column1 + right;
            m.Column2 = left.Column2 + right;
            #if TEMPLATE_DIM_4
            m.Column3 = left.Column3 + right;
            #endif
            return m;
        }

        /// <summary>
        /// Element-wise addition.
        /// </summary>
        public static MatrixTemplate operator +(MatrixTemplate left, MatrixTemplate right)
        {
            MatrixTemplate m = new MatrixTemplate();
            m.Column0 = left.Column0 + right.Column0;
            m.Column1 = left.Column1 + right.Column1;
            m.Column2 = left.Column2 + right.Column2;
            #if TEMPLATE_DIM_4
            m.Column3 = left.Column3 + right.Column3;
            #endif
            return m;
        }

        /// <summary>
        /// Element-wise subtraction.
        /// </summary>
        public static MatrixTemplate operator -(unit left, MatrixTemplate right)
        {
            MatrixTemplate m = new MatrixTemplate();
            m.Column0 = left - right.Column0;
            m.Column1 = left - right.Column1;
            m.Column2 = left - right.Column2;
            #if TEMPLATE_DIM_4
            m.Column3 = left - right.Column3;
            #endif
            return m;
        }

        /// <summary>
        /// Element-wise subtraction.
        /// </summary>
        public static MatrixTemplate operator -(MatrixTemplate left, unit right)
        {
            MatrixTemplate m = new MatrixTemplate();
            m.Column0 = left.Column0 - right;
            m.Column1 = left.Column1 - right;
            m.Column2 = left.Column2 - right;
            #if TEMPLATE_DIM_4
            m.Column3 = left.Column3 - right;
            #endif
            return m;
        }

        /// <summary>
        /// Element-wise subtraction.
        /// </summary>
        public static MatrixTemplate operator -(MatrixTemplate left, MatrixTemplate right)
        {
            MatrixTemplate m = new MatrixTemplate();
            m.Column0 = left.Column0 - right.Column0;
            m.Column1 = left.Column1 - right.Column1;
            m.Column2 = left.Column2 - right.Column2;
            #if TEMPLATE_DIM_4
            m.Column3 = left.Column3 - right.Column3;
            #endif
            return m;
        }

        /// <summary>
        /// Element-wise negation.
        /// </summary>
        public static MatrixTemplate operator -(MatrixTemplate right)
        {
            MatrixTemplate m = new MatrixTemplate();
            m.Column0 = - right.Column0;
            m.Column1 = - right.Column1;
            m.Column2 = - right.Column2;
            #if TEMPLATE_DIM_4
            m.Column3 = - right.Column3;
            #endif
            return m;
        }

        /// <summary>
        /// Element-wise multiplication
        /// </summary>
        /// <returns>A new MatrixTemplate which holds the result of the multiplication</returns>
        public static MatrixTemplate operator *(unit left, MatrixTemplate right)
        {
            MatrixTemplate m = new MatrixTemplate();
            m.Column0 = left * right.Column0;
            m.Column1 = left * right.Column1;
            m.Column2 = left * right.Column2;
            #if TEMPLATE_DIM_4
            m.Column3 = left * right.Column3;
            #endif
            return m;
        }

        /// <summary>
        /// Element-wise multiplication
        /// </summary>
        /// <returns>A new MatrixTemplate which holds the result of the multiplication</returns>
        public static MatrixTemplate operator *(MatrixTemplate left, unit right)
        {
            MatrixTemplate m = new MatrixTemplate();
            m.Column0 = left.Column0 * right;
            m.Column1 = left.Column1 * right;
            m.Column2 = left.Column2 * right;
            #if TEMPLATE_DIM_4
            m.Column3 = left.Column3 * right;
            #endif
            return m;
        }

        /// <summary>
        /// Matrix multiplication with a column vector
        /// </summary>
        /// <param name='left'>
        /// Transform Matrix
        /// </param>
        /// <param name='right'>
        /// Column vector
        /// </param>
        public static vec operator *(MatrixTemplate left, vec right)
        {
            vec result = new vec();
            result.X =
                left.Column0.X * right.X + 
                left.Column1.X * right.Y + 
                left.Column2.X * right.Z
#if TEMPLATE_DIM_4
                + left.Column3.X * right.W
#endif
                    ;
            result.Y =
                left.Column0.Y * right.X + 
                left.Column1.Y * right.Y + 
                left.Column2.Y * right.Z
#if TEMPLATE_DIM_4
                + left.Column3.Y * right.W;
#endif
                    ;
            result.Z =
                left.Column0.Z * right.X + 
                left.Column1.Z * right.Y + 
                left.Column2.Z * right.Z
#if TEMPLATE_DIM_4
                + left.Column3.Z * right.W;
#endif
                    ;
            #if TEMPLATE_DIM_4
            result.W =
                left.Column0.W * right.X + 
                left.Column1.W * right.Y + 
                left.Column2.W * right.Z + 
                left.Column3.W * right.W;
            #endif
            return result;
        }

        /// <summary>
        /// Matrix multiplication
        /// </summary>
        /// <param name="left">left-hand operand</param>
        /// <param name="right">right-hand operand</param>
        /// <returns>A new MatrixTemplate which holds the result of the multiplication</returns>
        public static MatrixTemplate operator *(MatrixTemplate left, MatrixTemplate right)
        {
            MatrixTemplate m = new MatrixTemplate();
            MatrixTemplate.Multiply(ref left, ref right, out m);
            return m;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication</param>
        public static void Multiply(ref MatrixTemplate left, ref MatrixTemplate right, out MatrixTemplate result)
        {
            //Believe it or not, referencing the same left.Col0.X four times is faster than storing it in a local variable.
#if TEMPLATE_DIM_4
            result.Column0.X =
                left.Column0.X * right.Column0.X + 
                left.Column1.X * right.Column0.Y + 
                left.Column2.X * right.Column0.Z + 
                left.Column3.X * right.Column0.W;
            result.Column0.Y =
                left.Column0.Y * right.Column0.X + 
                left.Column1.Y * right.Column0.Y + 
                left.Column2.Y * right.Column0.Z + 
                left.Column3.Y * right.Column0.W;
            result.Column0.Z =
                left.Column0.Z * right.Column0.X + 
                left.Column1.Z * right.Column0.Y + 
                left.Column2.Z * right.Column0.Z + 
                left.Column3.Z * right.Column0.W;
            result.Column0.W =
                left.Column0.W * right.Column0.X + 
                left.Column1.W * right.Column0.Y + 
                left.Column2.W * right.Column0.Z + 
                left.Column3.W * right.Column0.W;

            result.Column1.X =
                left.Column0.X * right.Column1.X + 
                left.Column1.X * right.Column1.Y + 
                left.Column2.X * right.Column1.Z + 
                left.Column3.X * right.Column1.W;
            result.Column1.Y =
                left.Column0.Y * right.Column1.X + 
                left.Column1.Y * right.Column1.Y + 
                left.Column2.Y * right.Column1.Z + 
                left.Column3.Y * right.Column1.W;
            result.Column1.Z =
                left.Column0.Z * right.Column1.X + 
                left.Column1.Z * right.Column1.Y + 
                left.Column2.Z * right.Column1.Z + 
                left.Column3.Z * right.Column1.W;
            result.Column1.W =
                left.Column0.W * right.Column1.X + 
                left.Column1.W * right.Column1.Y + 
                left.Column2.W * right.Column1.Z + 
                left.Column3.W * right.Column1.W;

            result.Column2.X =
                left.Column0.X * right.Column2.X + 
                left.Column1.X * right.Column2.Y + 
                left.Column2.X * right.Column2.Z + 
                left.Column3.X * right.Column2.W;
            result.Column2.Y =
                left.Column0.Y * right.Column2.X + 
                left.Column1.Y * right.Column2.Y + 
                left.Column2.Y * right.Column2.Z + 
                left.Column3.Y * right.Column2.W;
            result.Column2.Z =
                left.Column0.Z * right.Column2.X + 
                left.Column1.Z * right.Column2.Y + 
                left.Column2.Z * right.Column2.Z + 
                left.Column3.Z * right.Column2.W;
            result.Column2.W =
                left.Column0.W * right.Column2.X + 
                left.Column1.W * right.Column2.Y + 
                left.Column2.W * right.Column2.Z + 
                left.Column3.W * right.Column2.W;

            result.Column3.X =
                left.Column0.X * right.Column3.X + 
                left.Column1.X * right.Column3.Y + 
                left.Column2.X * right.Column3.Z + 
                left.Column3.X * right.Column3.W;
            result.Column3.Y =
                left.Column0.Y * right.Column3.X + 
                left.Column1.Y * right.Column3.Y + 
                left.Column2.Y * right.Column3.Z + 
                left.Column3.Y * right.Column3.W;
            result.Column3.Z =
                left.Column0.Z * right.Column3.X + 
                left.Column1.Z * right.Column3.Y + 
                left.Column2.Z * right.Column3.Z + 
                left.Column3.Z * right.Column3.W;
            result.Column3.W =
                left.Column0.W * right.Column3.X + 
                left.Column1.W * right.Column3.Y + 
                left.Column2.W * right.Column3.Z + 
                left.Column3.W * right.Column3.W;
#else                
            result.Column0.X =
                left.Column0.X * right.Column0.X + 
                left.Column1.X * right.Column0.Y + 
                left.Column2.X * right.Column0.Z;
            result.Column0.Y =
                left.Column0.Y * right.Column0.X + 
                left.Column1.Y * right.Column0.Y + 
                left.Column2.Y * right.Column0.Z;
            result.Column0.Z =
                left.Column0.Z * right.Column0.X + 
                left.Column1.Z * right.Column0.Y + 
                left.Column2.Z * right.Column0.Z;

            result.Column1.X =
                left.Column0.X * right.Column1.X + 
                left.Column1.X * right.Column1.Y + 
                left.Column2.X * right.Column1.Z;
            result.Column1.Y =
                left.Column0.Y * right.Column1.X + 
                left.Column1.Y * right.Column1.Y + 
                left.Column2.Y * right.Column1.Z;
            result.Column1.Z =
                left.Column0.Z * right.Column1.X + 
                left.Column1.Z * right.Column1.Y + 
                left.Column2.Z * right.Column1.Z;

            result.Column2.X =
                left.Column0.X * right.Column2.X + 
                left.Column1.X * right.Column2.Y + 
                left.Column2.X * right.Column2.Z;
            result.Column2.Y =
                left.Column0.Y * right.Column2.X + 
                left.Column1.Y * right.Column2.Y + 
                left.Column2.Y * right.Column2.Z;
            result.Column2.Z =
                left.Column0.Z * right.Column2.X + 
                left.Column1.Z * right.Column2.Y + 
                left.Column2.Z * right.Column2.Z;
#endif
        }

        #endregion

        #region Static: Matrix Operations
        
        /// <summary>
        /// Calculate the inverse of the given matrix
        /// </summary>
        /// <param name="mat">The matrix to invert</param>
        /// <returns>The inverse of the given matrix if it has one, or the input if it is singular</returns>
        /// <exception cref="InvalidOperationException">Thrown if the MatrixTemplate is singular.</exception>
        public static MatrixTemplate Invert(MatrixTemplate mat)
        {
            #if TEMPLATE_DIM_4
            const int dim = 4;
            int[] colIdx = { 0, 0, 0, 0 };
            int[] rowIdx = { 0, 0, 0, 0 };
            int[] pivotIdx = { -1, -1, -1, -1 };

            // convert the matrix to an array for easy looping
            unit[,] inverse = {
                { mat.Column0.X, mat.Column1.X, mat.Column2.X, mat.Column3.X },
                { mat.Column0.Y, mat.Column1.Y, mat.Column2.Y, mat.Column3.Y },
                { mat.Column0.Z, mat.Column1.Z, mat.Column2.Z, mat.Column3.Z },
                { mat.Column0.W, mat.Column1.W, mat.Column2.W, mat.Column3.W } };
            #else
            const int dim = 3;
            int[] colIdx = { 0, 0, 0};
            int[] rowIdx = { 0, 0, 0};
            int[] pivotIdx = { -1, -1, -1 };

            // convert the matrix to an array for easy looping
            unit[,] inverse = {
                { mat.Column0.X, mat.Column1.X, mat.Column2.X },
                { mat.Column0.Y, mat.Column1.Y, mat.Column2.Y },
                { mat.Column0.Z, mat.Column1.Z, mat.Column2.Z } };
            #endif


            int icol = 0;
            int irow = 0;
            for (int i = 0; i < dim; i++)
            {
                // Find the largest pivot value
                unit maxPivot = 0;
                for (int j = 0; j < dim; j++)
                {
                    if (pivotIdx [j] != 0)
                    {
                        for (int k = 0; k < dim; ++k)
                        {
                            if (pivotIdx [k] == -1)
                            {
                                unit absVal = System.Math.Abs(inverse [j, k]);
                                if (absVal > maxPivot)
                                {
                                    maxPivot = absVal;
                                    irow = j;
                                    icol = k;
                                }
                            }
                            else if (pivotIdx [k] > 0)
                            {
                                return mat;
                            }
                        }
                    }
                }

                ++(pivotIdx [icol]);

                // Swap rows over so pivot is on diagonal
                if (irow != icol)
                {
                    for (int k = 0; k < dim; ++k)
                    {
                        unit f = inverse [irow, k];
                        inverse [irow, k] = inverse [icol, k];
                        inverse [icol, k] = f;
                    }
                }

                rowIdx [i] = irow;
                colIdx [i] = icol;

                unit pivot = inverse [icol, icol];
                // check for singular matrix
                if (pivot == 0)
                {
                    throw new InvalidOperationException("Matrix is singular and cannot be inverted.");
                    //return mat;
                }

                // Scale row so it has a unit diagonal
                unit oneOverPivot = one / pivot;
                inverse [icol, icol] = one;
                for (int k = 0; k < dim; ++k)
                    inverse [icol, k] *= oneOverPivot;

                // Do elimination of non-diagonal elements
                for (int j = 0; j < dim; ++j)
                {
                    // check this isn't on the diagonal
                    if (icol != j)
                    {
                        unit f = inverse [j, icol];
                        inverse [j, icol] = 0;
                        for (int k = 0; k < dim; ++k)
                            inverse [j, k] -= inverse [icol, k] * f;
                    }
                }
            }

            for (int j = 3; j >= 0; --j)
            {
                int ir = rowIdx [j];
                int ic = colIdx [j];
                for (int k = 0; k < dim; ++k)
                {
                    unit f = inverse [k, ir];
                    inverse [k, ir] = inverse [k, ic];
                    inverse [k, ic] = f;
                }
            }

            mat.Column0.X = inverse [0, 0];
            mat.Column0.Y = inverse [1, 0];
            mat.Column0.Z = inverse [2, 0];
            mat.Column1.X = inverse [0, 1];
            mat.Column1.Y = inverse [1, 1];
            mat.Column1.Z = inverse [2, 1];
            mat.Column2.X = inverse [0, 2];
            mat.Column2.Y = inverse [1, 2];
            mat.Column2.Z = inverse [2, 2];

            #if TEMPLATE_DIM_4
            mat.Column0.W = inverse [3, 0];
            mat.Column1.W = inverse [3, 1];
            mat.Column2.W = inverse [3, 2];
            mat.Column3.X = inverse [0, 3];
            mat.Column3.Y = inverse [1, 3];
            mat.Column3.Z = inverse [2, 3];
            mat.Column3.W = inverse [3, 3];
            #endif
            return mat;
        }

        /// <summary>
        /// Calculate the transpose of the given matrix
        /// </summary>
        /// <param name="mat">The matrix to transpose</param>
        /// <returns>The transpose of the given matrix</returns>
        public static MatrixTemplate Transpose(MatrixTemplate mat)
        {
            return new MatrixTemplate(mat.Row0, mat.Row1, mat.Row2
#if TEMPLATE_DIM_4
                                    , mat.Row3
#endif
                                      );
        }


        /// <summary>
        /// Calculate the transpose of the given matrix
        /// </summary>
        /// <param name="mat">The matrix to transpose</param>
        /// <param name="result">The result of the calculation</param>
        public static void Transpose(ref MatrixTemplate mat, out MatrixTemplate result)
        {
            result.Column0 = mat.Row0;
            result.Column1 = mat.Row1;
            result.Column2 = mat.Row2;
#if TEMPLATE_DIM_4
            result.Column3 = mat.Row3;
#endif
        }

        #endregion

        #region Overrides

        /// <summary></summary>
        public override string ToString()
        {
            #if TEMPLATE_DIM_4
            return String.Format(
                "[ {0}   {4}   {8}   {12} ]\n" +
                "[ {1}   {5}   {9}   {13} ]\n" +
                "[ {2}   {6}   {10}   {14} ]\n" +
                "[ {3}   {7}   {11}   {15} ]\n",
                Column0.X.ToString("0.0"), Column0.Y.ToString("0.0"), Column0.Z.ToString("0.0"), Column0.W.ToString("0.0"),
                Column1.X.ToString("0.0"), Column1.Y.ToString("0.0"), Column1.Z.ToString("0.0"), Column1.W.ToString("0.0"),
                Column2.X.ToString("0.0"), Column2.Y.ToString("0.0"), Column2.Z.ToString("0.0"), Column2.W.ToString("0.0"),
                Column3.X.ToString("0.0"), Column3.Y.ToString("0.0"), Column3.Z.ToString("0.0"), Column3.W.ToString("0.0")
            );
            #else
            return String.Format(
                "[ {0}   {3}   {6} ]\n" +
                "[ {1}   {4}   {7} ]\n" +
                "[ {2}   {5}   {8} ]\n",
                Column0.X.ToString("0.0"), Column0.Y.ToString("0.0"), Column0.Z.ToString("0.0"),
                Column1.X.ToString("0.0"), Column1.Y.ToString("0.0"), Column1.Z.ToString("0.0"),
                Column2.X.ToString("0.0"), Column2.Y.ToString("0.0"), Column2.Z.ToString("0.0")
            );
            #endif
        }

        /// <summary></summary>
        public override int GetHashCode()
        {
            return Column0.GetHashCode() ^ Column1.GetHashCode() ^ Column2.GetHashCode()
            #if TEMPLATE_DIM_4
                ^ Column3.GetHashCode()
            #endif
                ;
        }

        /// <summary></summary>
        public override bool Equals(object obj)
        {
            if (!(obj is MatrixTemplate))
                return false;

            return this.Equals((MatrixTemplate)obj);
        }

        #endregion

        #region IEquatable<MatrixTemplate> Members

        /// <summary>Indicates whether the current matrix is equal to another matrix.</summary>
        /// <param name="other">An matrix to compare with this matrix.</param>
        /// <returns>true if the current matrix is equal to the matrix parameter; otherwise, false.</returns>
        public bool Equals(MatrixTemplate other)
        {
            return
                Column0 == other.Column0 &&
                Column1 == other.Column1 &&
                Column2 == other.Column2
            #if TEMPLATE_DIM_4
                && Column3 == other.Column3
            #endif
                    ;
        }

        #endregion
    }
}
