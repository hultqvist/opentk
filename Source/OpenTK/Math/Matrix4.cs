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
    
    /// <summary>
    /// <para>Represents a 4x4 Matrix</para>
    /// <para>Storage is column-major and vectors are assumed to be column vectors.</para>
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct Matrix4 : IEquatable<Matrix4>
    {
        /// <summary></summary>
        public Vector4 Column0;
        /// <summary></summary>
        public Vector4 Column1;
        /// <summary></summary>
        public Vector4 Column2;
        /// <summary></summary>
        public Vector4 Column3;

        #region Rows
        
        /// <summary>
        /// The first column of this matrix
        /// </summary>
        public Vector4 Row0
        {
            get { return new Vector4(Column0.X, Column1.X, Column2.X, Column3.X); }
        }

        /// <summary>
        /// The second column of this matrix
        /// </summary>
        public Vector4 Row1
        {
            get { return new Vector4(Column0.Y, Column1.Y, Column2.Y, Column3.Y); }
        }

        /// <summary>
        /// The third column of this matrix
        /// </summary>
        public Vector4 Row2
        {
            get { return new Vector4(Column0.Z, Column1.Z, Column2.Z, Column3.Z); }
        }

        /// <summary>
        /// The fourth column of this matrix
        /// </summary>
        public Vector4 Row3
        {
            get { return new Vector4(Column0.W, Column1.W, Column2.W, Column3.W); }
        }

        #endregion

        #region Constructors

        /// <summary></summary>
        public Matrix4(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3)
        {
            Column0 = column0;
            Column1 = column1;
            Column2 = column2;
            Column3 = column3;
        }

        /// <summary>
        /// Initializes a matrix, parameters are indexed mRowCol
        /// </summary>
        public Matrix4(
            float m00, float m01, float m02, float m03,
            float m10, float m11, float m12, float m13,
            float m20, float m21, float m22, float m23,
            float m30, float m31, float m32, float m33)
        {
            Column0 = new Vector4(m00, m10, m20, m30);
            Column1 = new Vector4(m01, m11, m21, m31);
            Column2 = new Vector4(m02, m12, m22, m32);
            Column3 = new Vector4(m03, m13, m23, m33);
        }

        #endregion

        #region Instance Operations

        /// <summary>
        /// The determinant of this matrix
        /// </summary>
        public float Determinant()
        {
            //Determinant of a 2x2 matrix with rows 2-3 and columns from their index
            //no 00
            float d01 = Column0.Z * Column1.W - Column1.Z * Column0.W;
            float d02 = Column0.Z * Column2.W - Column2.Z * Column0.W;
            float d03 = Column0.Z * Column3.W - Column3.Z * Column0.W;
            //     d10 = Col1.Z * Col0.W - Col0.Z * Col1.W;
            //no 11
            float d12 = Column1.Z * Column2.W - Column2.Z * Column1.W;
            float d13 = Column1.Z * Column3.W - Column3.Z * Column1.W;
            //     d20 = Col2.Z * Col0.W - Col0.Z * Col2.W;
            //     d21 = Col2.Z * Col1.W - Col1.Z * Col2.W;
            //no22
            float d23 = Column2.Z * Column3.W - Column3.Z * Column2.W;
            //     d30 = Col3.Z * Col0.W - Col0.Z * Col3.W;
            //     d31 = Col3.Z * Col1.W - Col1.Z * Col3.W;
            //     d32 = Col3.Z * Col2.W - Col2.Z * Col3.W;
            //no33
                            
            //Determinant of a 3x3 matrix with rows 1-3 and columns form their index
            float d123 = Column1.Y * d23 - Column2.Y * d13 + Column3.Y * d12;
            float d023 = Column0.Y * d23 - Column2.Y * d03 + Column3.Y * d02;
            float d013 = Column0.Y * d13 - Column1.Y * d03 + Column3.Y * d01;
            float d012 = Column0.Y * d12 - Column1.Y * d02 + Column2.Y * d01;
            
            return Column0.X * d123 - Column1.X * d023 + Column2.X * d013 - Column3.X * d012;
        }

        /// <summary>
        /// Return the inverse of the matrix.
        /// </summary>
        public Matrix4 Invert()
        {
            return Matrix4.Invert(this);
        }

        /// <summary>
        /// Return the transpose of the matrix
        /// </summary>
        public Matrix4 Transpose()
        {
            return Matrix4.Transpose(this);
        }

        #endregion

        #region Static: Matrix generation

        /// <summary>
        /// The identity matrix
        /// </summary>
        public static readonly Matrix4 Identity = new Matrix4(Vector4.UnitX, Vector4.UnitY, Vector4.UnitZ, Vector4.UnitW);

        #region RotationQuaternion
        
        /// <summary>
        /// Build a rotation matrix from the specified quaternion.
        /// </summary>
        /// <param name="q">Quaternion to translate.</param>
        /// <param name="m">Matrix result.</param>
        public static void RotationQuaternion(ref Quaternion q, ref Matrix4 m)
        {
            float scale = 1.0f / q.Length;
            
            float X = q.X * scale;
            float Y = q.Y * scale;
            float Z = q.Z * scale;
            float W = q.W * scale;

            float xx = X * X;
            float xy = X * Y;
            float xz = X * Z;
            float xw = X * W;
            float yy = Y * Y;
            float yz = Y * Z;
            float yw = Y * W;
            float zz = Z * Z;
            float zw = Z * W;

            m.Column0.X = 1 - 2 * (yy + zz);
            m.Column0.Y = 2 * (xy + zw);
            m.Column0.Z = 2 * (xz - yw);
            m.Column0.W = 0;
            
            m.Column1.X = 2 * (xy - zw);
            m.Column1.Y = 1 - 2 * (xx + zz);
            m.Column1.Z = 2 * (yz + xw);
            m.Column1.W = 0;
            
            m.Column2.X = 2 * (xz + yw);
            m.Column2.Y = 2 * (yz - xw);
            m.Column2.Z = 1 - 2 * (xx + yy);
            m.Column2.W = 0;
            
            m.Column3.X = 0;
            m.Column3.Y = 0;
            m.Column3.Z = 0;
            m.Column3.W = 1;
        }

        /// <summary>
        /// Build a rotation matrix from the specified quaternion.
        /// </summary>
        /// <param name="q">Quaternion to translate.</param>
        /// <returns>A matrix instance.</returns>
        public static Matrix4 RotationQuaternion(ref Quaternion q)
        {
            Matrix4 m = new Matrix4();
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
        public static void RotationAxisAngle(Vector3 axis, double angle, out Matrix4 result)
        {
            float cos = (float)System.Math.Cos(-angle);
            float sin = (float)System.Math.Sin(-angle);
            float t = 1.0f - cos;

            axis.Normalize();

            result = new Matrix4(t * axis.X * axis.X + cos, t * axis.X * axis.Y - sin * axis.Z, t * axis.X * axis.Z + sin * axis.Y, 0.0f,
                                 t * axis.X * axis.Y + sin * axis.Z, t * axis.Y * axis.Y + cos, t * axis.Y * axis.Z - sin * axis.X, 0.0f,
                                 t * axis.X * axis.Z - sin * axis.Y, t * axis.Y * axis.Z + sin * axis.X, t * axis.Z * axis.Z + cos, 0.0f,
                                 0, 0, 0, 1);
        }
        
        /// <summary>
        /// Build a rotation matrix from the specified axis/angle rotation.
        /// </summary>
        /// <param name="axis">The axis to rotate about.</param>
        /// <param name="angle">Angle in radians to rotate counter-clockwise (looking in the direction of the given axis).</param>
        /// <returns>A matrix instance.</returns>
        public static Matrix4 RotationAxisAngle(Vector3 axis, double angle)
        {
            Matrix4 result;
            RotationAxisAngle(axis, angle, out result);
            return result;
        }
        
        #endregion

        #region Rotation[XYZ]

        /// <summary>
        /// Builds a rotation matrix for a right-hand rotation around the x-axis.
        /// </summary>
        /// <param name="angle">The right-hand rotation in radians around the x-axis.</param>
        /// <param name="result">The resulting Matrix4 instance.</param>
        public static void RotationX(double angle, out Matrix4 result)
        {
            float cos = (float)System.Math.Cos(angle);
            float sin = (float)System.Math.Sin(angle);

            result.Column0 = Vector4.UnitX;
            result.Column1 = new Vector4(0.0f, cos, sin, 0.0f);
            result.Column2 = new Vector4(0.0f, -sin, cos, 0.0f);
            result.Column3 = Vector4.UnitW;
        }

        /// <summary>
        /// Builds a rotation matrix for a right-hand rotation around the x-axis.
        /// </summary>
        /// <param name="angle">The right-hand rotation in radians around the x-axis.</param>
        /// <returns>The resulting Matrix4 instance.</returns>
        public static Matrix4 RotationX(double angle)
        {
            Matrix4 result;
            RotationX(angle, out result);
            return result;
        }

        /// <summary>
        /// Builds a rotation matrix for a right-hand rotation around the y-axis.
        /// </summary>
        /// <param name="angle">The right-hand rotation in radians around the y-axis.</param>
        /// <param name="result">The resulting Matrix4 instance.</param>
        public static void RotationY(double angle, out Matrix4 result)
        {
            float cos = (float)System.Math.Cos(angle);
            float sin = (float)System.Math.Sin(angle);

            result.Column0 = new Vector4(cos, 0.0f, -sin, 0.0f);
            result.Column1 = Vector4.UnitY;
            result.Column2 = new Vector4(sin, 0.0f, cos, 0.0f);
            result.Column3 = Vector4.UnitW;
        }

        /// <summary>
        /// Builds a rotation matrix for a right-hand rotation around the y-axis.
        /// </summary>
        /// <param name="angle">The right-hand rotation in radians around the y-axis.</param>
        /// <returns>The resulting Matrix4 instance.</returns>
        public static Matrix4 RotationY(double angle)
        {
            Matrix4 result;
            RotationY(angle, out result);
            return result;
        }

        /// <summary>
        /// Builds a rotation matrix for a right-hand rotation around the z-axis.
        /// </summary>
        /// <param name="angle">The right-hand rotation in radians around the z-axis.</param>
        /// <param name="result">The resulting Matrix4 instance.</param>
        public static void RotationZ(double angle, out Matrix4 result)
        {
            float cos = (float)System.Math.Cos(angle);
            float sin = (float)System.Math.Sin(angle);

            result.Column0 = new Vector4(cos, sin, 0.0f, 0.0f);
            result.Column1 = new Vector4(-sin, cos, 0.0f, 0.0f);
            result.Column2 = Vector4.UnitZ;
            result.Column3 = Vector4.UnitW;
        }

        /// <summary>
        /// Builds a rotation matrix for a right-hand rotation around the z-axis.
        /// </summary>
        /// <param name="angle">The right-hand rotation in radians around the z-axis.</param>
        /// <returns>The resulting Matrix4 instance.</returns>
        public static Matrix4 RotationZ(double angle)
        {
            Matrix4 result;
            RotationZ(angle, out result);
            return result;
        }

        #endregion

        #region Translation

        /// <summary>
        /// Creates a translation matrix.
        /// </summary>
        /// <param name="x">X translation.</param>
        /// <param name="y">Y translation.</param>
        /// <param name="z">Z translation.</param>
        /// <param name="result">The resulting Matrix4 instance.</param>
        public static void Translation(float x, float y, float z, out Matrix4 result)
        {
            result = Identity;
            result.Column3 = new Vector4(x, y, z, 1);
        }

        /// <summary>
        /// Creates a translation matrix.
        /// </summary>
        /// <param name="vector">The translation vector.</param>
        /// <param name="result">The resulting Matrix4 instance.</param>
        public static void Translation(ref Vector3 vector, out Matrix4 result)
        {
            result = Identity;
            result.Column3 = new Vector4(vector.X, vector.Y, vector.Z, 1);
        }

        /// <summary>
        /// Creates a translation matrix.
        /// </summary>
        /// <param name="x">X translation.</param>
        /// <param name="y">Y translation.</param>
        /// <param name="z">Z translation.</param>
        /// <returns>The resulting Matrix4 instance.</returns>
        public static Matrix4 Translation(float x, float y, float z)
        {
            Matrix4 result;
            Translation(x, y, z, out result);
            return result;
        }

        /// <summary>
        /// Creates a translation matrix.
        /// </summary>
        /// <param name="vector">The translation vector.</param>
        /// <returns>The resulting Matrix4 instance.</returns>
        public static Matrix4 Translation(Vector3 vector)
        {
            Matrix4 result;
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
        /// <param name="result">The resulting Matrix4 instance.</param>
        public static void Orthographic(float xWidth, float yHeight, float zNear, float zFar, out Matrix4 result)
        {
            OrthographicOffCenter(-xWidth / 2, xWidth / 2, -yHeight / 2, yHeight / 2, zNear, zFar, out result);
        }

        /// <summary>
        /// Creates an orthographic projection matrix.
        /// </summary>
        /// <param name="width">The width of the projection volume.</param>
        /// <param name="height">The height of the projection volume.</param>
        /// <param name="zNear">The near edge of the projection volume.</param>
        /// <param name="zFar">The far edge of the projection volume.</param>
        /// <rereturns>The resulting Matrix4 instance.</rereturns>
        public static Matrix4 Orthographic(float width, float height, float zNear, float zFar)
        {
            Matrix4 result;
            OrthographicOffCenter(-width / 2, width / 2, -height / 2, height / 2, zNear, zFar, out result);
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
        /// <param name="result">The resulting Matrix4 instance.</param>
        public static void OrthographicOffCenter(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4 result)
        {
            result = new Matrix4();

            float invRL = 1 / (right - left);
            float invTB = 1 / (top - bottom);
            float invFN = 1 / (zNear - zFar);

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
        /// <returns>The resulting Matrix4 instance.</returns>
        public static Matrix4 OrthographicOffCenter(float left, float right, float bottom, float top, float zNear, float zFar)
        {
            Matrix4 result;
            OrthographicOffCenter(left, right, bottom, top, zNear, zFar, out result);
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
        public static void PerspectiveFieldOfView(double fovy, float aspect, float zNear, float zFar, out Matrix4 result)
        {
            if (fovy <= 0 || fovy > Math.PI)
                throw new ArgumentOutOfRangeException("fovy");
            if (aspect <= 0)
                throw new ArgumentOutOfRangeException("aspect");

            float yMax = (float)(Math.Abs(zNear) * System.Math.Tan(0.5f * fovy));
            float ymin = -yMax;
            float xMin = ymin * aspect;
            float xMax = yMax * aspect;

            PerspectiveOffCenter(xMin, xMax, ymin, yMax, zNear, zFar, out result);
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
        public static Matrix4 PerspectiveFieldOfView(double fovy, float aspect, float zNear, float zFar)
        {
            Matrix4 result;
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
        public static void PerspectiveOffCenter(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4 result)
        {
            float x, y, a, b, c, d;
            float xSize = right - left;
            float ySize = top - bottom;

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
            } else
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

            result = new Matrix4(x, 0, a, 0,
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
        public static Matrix4 PerspectiveOffCenter(float left, float right, float bottom, float top, float zNear, float zFar)
        {
            Matrix4 result;
            PerspectiveOffCenter(left, right, bottom, top, zNear, zFar, out result);
            return result;
        }
        
        #endregion

        #region Scale Functions

        /// <summary>
        /// Build a scaling matrix
        /// </summary>
        /// <param name="scale">Single scale factor for x,y and z axes</param>
        /// <returns>A scaling matrix</returns>
        public static Matrix4 Scale(float scale)
        {
            return Scale(scale, scale, scale);
        }

        /// <summary>
        /// Build a scaling matrix
        /// </summary>
        /// <param name="scale">Scale factors for x,y and z axes</param>
        /// <returns>A scaling matrix</returns>
        public static Matrix4 Scale(Vector3 scale)
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
        public static Matrix4 Scale(float x, float y, float z)
        {
            Matrix4 result = new Matrix4();
            result.Column0.X = x;
            result.Column1.Y = y;
            result.Column2.Z = z;
            result.Column3.W = 1;
            return result;
        }

        #endregion

        #region Camera LookAt Helper Functions

        /// <summary>
        /// Build a world space to camera space matrix
        /// </summary>
        /// <param name="eye">Eye (camera) position in world space</param>
        /// <param name="target">Target position in world space</param>
        /// <param name="up">Up vector in world space (should not be parallel to the camera direction, that is target - eye)</param>
        /// <returns>A Matrix4 that transforms world space to camera space</returns>
        public static Matrix4 LookAt(Vector3 eye, Vector3 target, Vector3 up)
        {
            Vector3 z = (eye - target).Normalize();
            Vector3 x = Vector3.Cross(up, z).Normalize();
            Vector3 y = Vector3.Cross(z, x).Normalize();

            Matrix4 rot = new Matrix4(x.X,x.Y,x.Z,0,
                                      y.X,y.Y,y.Z,0,
                                      z.X,z.Y,z.Z,0,
                                      0,0,0,1);

            Matrix4 trans = Matrix4.Translation(-eye);

            return rot * trans;
        }

        /// <summary>
        /// Build a world space to camera space matrix
        /// </summary>
        /// <param name="eyeX">Eye (camera) position in world space</param>
        /// <param name="eyeY">Eye (camera) position in world space</param>
        /// <param name="eyeZ">Eye (camera) position in world space</param>
        /// <param name="targetX">Target position in world space</param>
        /// <param name="targetY">Target position in world space</param>
        /// <param name="targetZ">Target position in world space</param>
        /// <param name="upX">Up vector in world space (should not be parallel to the camera direction, that is target - eye)</param>
        /// <param name="upY">Up vector in world space (should not be parallel to the camera direction, that is target - eye)</param>
        /// <param name="upZ">Up vector in world space (should not be parallel to the camera direction, that is target - eye)</param>
        /// <returns>A Matrix4 that transforms world space to camera space</returns>
        public static Matrix4 LookAt(float eyeX, float eyeY, float eyeZ, float targetX, float targetY, float targetZ, float upX, float upY, float upZ)
        {
            return LookAt(new Vector3(eyeX, eyeY, eyeZ), new Vector3(targetX, targetY, targetZ), new Vector3(upX, upY, upZ));
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
        public static bool operator ==(Matrix4 left, Matrix4 right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Compares two instances for inequality.
        /// </summary>
        /// <param name="left">The first instance.</param>
        /// <param name="right">The second instance.</param>
        /// <returns>True, if left does not equal right; false otherwise.</returns>
        public static bool operator !=(Matrix4 left, Matrix4 right)
        {
            return !left.Equals(right);
        }
        
        /// <summary>
        /// Element-wise addition.
        /// </summary>
        public static Matrix4 operator +(float left, Matrix4 right)
        {
            Matrix4 m = new Matrix4();
            m.Column0 = left + right.Column0;
            m.Column1 = left + right.Column1;
            m.Column2 = left + right.Column2;
            m.Column3 = left + right.Column3;
            return m;
        }

        /// <summary>
        /// Element-wise addition.
        /// </summary>
        public static Matrix4 operator +(Matrix4 left, float right)
        {
            Matrix4 m = new Matrix4();
            m.Column0 = left.Column0 + right;
            m.Column1 = left.Column1 + right;
            m.Column2 = left.Column2 + right;
            m.Column3 = left.Column3 + right;
            return m;
        }

        /// <summary>
        /// Element-wise addition.
        /// </summary>
        public static Matrix4 operator +(Matrix4 left, Matrix4 right)
        {
            Matrix4 m = new Matrix4();
            m.Column0 = left.Column0 + right.Column0;
            m.Column1 = left.Column1 + right.Column1;
            m.Column2 = left.Column2 + right.Column2;
            m.Column3 = left.Column3 + right.Column3;
            return m;
        }

        /// <summary>
        /// Element-wise subtraction.
        /// </summary>
        public static Matrix4 operator -(float left, Matrix4 right)
        {
            Matrix4 m = new Matrix4();
            m.Column0 = left - right.Column0;
            m.Column1 = left - right.Column1;
            m.Column2 = left - right.Column2;
            m.Column3 = left - right.Column3;
            return m;
        }

        /// <summary>
        /// Element-wise subtraction.
        /// </summary>
        public static Matrix4 operator -(Matrix4 left, float right)
        {
            Matrix4 m = new Matrix4();
            m.Column0 = left.Column0 - right;
            m.Column1 = left.Column1 - right;
            m.Column2 = left.Column2 - right;
            m.Column3 = left.Column3 - right;
            return m;
        }

        /// <summary>
        /// Element-wise subtraction.
        /// </summary>
        public static Matrix4 operator -(Matrix4 left, Matrix4 right)
        {
            Matrix4 m = new Matrix4();
            m.Column0 = left.Column0 - right.Column0;
            m.Column1 = left.Column1 - right.Column1;
            m.Column2 = left.Column2 - right.Column2;
            m.Column3 = left.Column3 - right.Column3;
            return m;
        }

        /// <summary>
        /// Element-wise negation.
        /// </summary>
        public static Matrix4 operator -(Matrix4 right)
        {
            Matrix4 m = new Matrix4();
            m.Column0 = - right.Column0;
            m.Column1 = - right.Column1;
            m.Column2 = - right.Column2;
            m.Column3 = - right.Column3;
            return m;
        }

        /// <summary>
        /// Element-wise multiplication
        /// </summary>
        /// <returns>A new Matrix4 which holds the result of the multiplication</returns>
        public static Matrix4 operator *(float left, Matrix4 right)
        {
            Matrix4 m = new Matrix4();
            m.Column0 = left * right.Column0;
            m.Column1 = left * right.Column1;
            m.Column2 = left * right.Column2;
            m.Column3 = left * right.Column3;
            return m;
        }

        /// <summary>
        /// Element-wise multiplication
        /// </summary>
        /// <returns>A new Matrix4 which holds the result of the multiplication</returns>
        public static Matrix4 operator *(Matrix4 left, float right)
        {
            Matrix4 m = new Matrix4();
            m.Column0 = left.Column0 * right;
            m.Column1 = left.Column1 * right;
            m.Column2 = left.Column2 * right;
            m.Column3 = left.Column3 * right;
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
        public static Vector4 operator *(Matrix4 left, Vector4 right)
        {
            Vector4 result = new Vector4();
            result.X =
                left.Column0.X * right.X + 
                left.Column1.X * right.Y + 
                left.Column2.X * right.Z + 
                left.Column3.X * right.W;
            result.Y =
                left.Column0.Y * right.X + 
                left.Column1.Y * right.Y + 
                left.Column2.Y * right.Z + 
                left.Column3.Y * right.W;
            result.Z =
                left.Column0.Z * right.X + 
                left.Column1.Z * right.Y + 
                left.Column2.Z * right.Z + 
                left.Column3.Z * right.W;
            result.W =
                left.Column0.W * right.X + 
                left.Column1.W * right.Y + 
                left.Column2.W * right.Z + 
                left.Column3.W * right.W;
            return result;
        }

        /// <summary>
        /// Matrix multiplication
        /// </summary>
        /// <param name="left">left-hand operand</param>
        /// <param name="right">right-hand operand</param>
        /// <returns>A new Matrix4 which holds the result of the multiplication</returns>
        public static Matrix4 operator *(Matrix4 left, Matrix4 right)
        {
            Matrix4 m = new Matrix4();
            Matrix4.Multiply(ref left, ref right, out m);
            return m;
        }

        /// <summary>
        /// Multiplies two instances.
        /// </summary>
        /// <param name="left">The left operand of the multiplication.</param>
        /// <param name="right">The right operand of the multiplication.</param>
        /// <param name="result">A new instance that is the result of the multiplication</param>
        public static void Multiply(ref Matrix4 left, ref Matrix4 right, out Matrix4 result)
        {
            //Believe it or not, referencing the same left.Col0.X four times is faster than storing it in a local variable.
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

        }

        #endregion

        #region Static: Matrix Operations
        
        /// <summary>
        /// Calculate the inverse of the given matrix
        /// </summary>
        /// <param name="mat">The matrix to invert</param>
        /// <returns>The inverse of the given matrix if it has one, or the input if it is singular</returns>
        /// <exception cref="InvalidOperationException">Thrown if the Matrix4 is singular.</exception>
        public static Matrix4 Invert(Matrix4 mat)
        {
            int[] colIdx = { 0, 0, 0, 0 };
            int[] rowIdx = { 0, 0, 0, 0 };
            int[] pivotIdx = { -1, -1, -1, -1 };

            // convert the matrix to an array for easy looping
            float[,] inverse = {{mat.Column0.X, mat.Column1.X, mat.Column2.X, mat.Column3.X}, 
                                {mat.Column0.Y, mat.Column1.Y, mat.Column2.Y, mat.Column3.Y}, 
                                {mat.Column0.Z, mat.Column1.Z, mat.Column2.Z, mat.Column3.Z}, 
                                {mat.Column0.W, mat.Column1.W, mat.Column2.W, mat.Column3.W} };
            int icol = 0;
            int irow = 0;
            for (int i = 0; i < 4; i++)
            {
                // Find the largest pivot value
                float maxPivot = 0.0f;
                for (int j = 0; j < 4; j++)
                {
                    if (pivotIdx[j] != 0)
                    {
                        for (int k = 0; k < 4; ++k)
                        {
                            if (pivotIdx[k] == -1)
                            {
                                float absVal = System.Math.Abs(inverse[j, k]);
                                if (absVal > maxPivot)
                                {
                                    maxPivot = absVal;
                                    irow = j;
                                    icol = k;
                                }
                            }
                            else if (pivotIdx[k] > 0)
                            {
                                return mat;
                            }
                        }
                    }
                }

                ++(pivotIdx[icol]);

                // Swap rows over so pivot is on diagonal
                if (irow != icol)
                {
                    for (int k = 0; k < 4; ++k)
                    {
                        float f = inverse[irow, k];
                        inverse[irow, k] = inverse[icol, k];
                        inverse[icol, k] = f;
                    }
                }

                rowIdx[i] = irow;
                colIdx[i] = icol;

                float pivot = inverse[icol, icol];
                // check for singular matrix
                if (pivot == 0.0f)
                {
                    throw new InvalidOperationException("Matrix is singular and cannot be inverted.");
                    //return mat;
                }

                // Scale row so it has a unit diagonal
                float oneOverPivot = 1.0f / pivot;
                inverse[icol, icol] = 1.0f;
                for (int k = 0; k < 4; ++k)
                    inverse[icol, k] *= oneOverPivot;

                // Do elimination of non-diagonal elements
                for (int j = 0; j < 4; ++j)
                {
                    // check this isn't on the diagonal
                    if (icol != j)
                    {
                        float f = inverse[j, icol];
                        inverse[j, icol] = 0.0f;
                        for (int k = 0; k < 4; ++k)
                            inverse[j, k] -= inverse[icol, k] * f;
                    }
                }
            }

            for (int j = 3; j >= 0; --j)
            {
                int ir = rowIdx[j];
                int ic = colIdx[j];
                for (int k = 0; k < 4; ++k)
                {
                    float f = inverse[k, ir];
                    inverse[k, ir] = inverse[k, ic];
                    inverse[k, ic] = f;
                }
            }

            mat.Column0.X = inverse[0,0];
            mat.Column0.Y = inverse[1,0];
            mat.Column0.Z = inverse[2,0];
            mat.Column0.W = inverse[3,0];
            mat.Column1.X = inverse[0,1];
            mat.Column1.Y = inverse[1,1];
            mat.Column1.Z = inverse[2,1];
            mat.Column1.W = inverse[3,1];
            mat.Column2.X = inverse[0,2];
            mat.Column2.Y = inverse[1,2];
            mat.Column2.Z = inverse[2,2];
            mat.Column2.W = inverse[3,2];
            mat.Column3.X = inverse[0,3];
            mat.Column3.Y = inverse[1,3];
            mat.Column3.Z = inverse[2,3];
            mat.Column3.W = inverse[3,3];
            return mat;
        }

        /// <summary>
        /// Calculate the transpose of the given matrix
        /// </summary>
        /// <param name="mat">The matrix to transpose</param>
        /// <returns>The transpose of the given matrix</returns>
        public static Matrix4 Transpose(Matrix4 mat)
        {
            return new Matrix4(mat.Row0, mat.Row1, mat.Row2, mat.Row3);
        }


        /// <summary>
        /// Calculate the transpose of the given matrix
        /// </summary>
        /// <param name="mat">The matrix to transpose</param>
        /// <param name="result">The result of the calculation</param>
        public static void Transpose(ref Matrix4 mat, out Matrix4 result)
        {
            result.Column0 = mat.Row0;
            result.Column1 = mat.Row1;
            result.Column2 = mat.Row2;
            result.Column3 = mat.Row3;
        }

        #endregion

        #region Overrides

        /// <summary></summary>
        public override string ToString()
        {
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
        }

        /// <summary></summary>
        public override int GetHashCode()
        {
            return Column0.GetHashCode() ^ Column1.GetHashCode() ^ Column2.GetHashCode() ^ Column3.GetHashCode();
        }

        /// <summary></summary>
        public override bool Equals(object obj)
        {
            if (!(obj is Matrix4))
                return false;

            return this.Equals((Matrix4)obj);
        }

        #endregion

        #region IEquatable<Matrix4> Members

        /// <summary>Indicates whether the current matrix is equal to another matrix.</summary>
        /// <param name="other">An matrix to compare with this matrix.</param>
        /// <returns>true if the current matrix is equal to the matrix parameter; otherwise, false.</returns>
        public bool Equals(Matrix4 other)
        {
            return
                Column0 == other.Column0 &&
                Column1 == other.Column1 &&
                Column2 == other.Column2 &&
                Column3 == other.Column3;
        }

        #endregion
    }
}
