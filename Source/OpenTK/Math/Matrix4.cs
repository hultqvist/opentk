using System;
namespace OpenTK
{
 public partial struct Matrix4
    {
        /// <summary></summary>
        public static explicit operator Matrix4(Matrix4d m)
        {
            return new Matrix4(
                (Vector4)m.Column0,
                (Vector4)m.Column1,
                (Vector4)m.Column2,
                (Vector4)m.Column3);
        }

        #region Camera LookAt Helper

        /// <summary>
        /// Build a world space to camera space matrix
        /// </summary>
        /// <param name="eye">Eye (camera) position in world space</param>
        /// <param name="target">Target position in world space</param>
        /// <param name="up">Up vector in world space (should not be parallel to the camera direction, that is target - eye)</param>
        /// <returns>A MatrixTemplate that transforms world space to camera space</returns>
        public static Matrix4 LookAt(Vector3 eye, Vector3 target, Vector3 up)
        {
            Vector3 z = (eye - target).Normalize();
            Vector3 x = Vector3.Cross(up, z).Normalize();
            Vector3 y = Vector3.Cross(z, x).Normalize();

            Matrix4 rot = new Matrix4(x.X, x.Y, x.Z, 0,
                                      y.X, y.Y, y.Z, 0,
                                      z.X, z.Y, z.Z, 0,
                                      0, 0, 0, 1);

            Matrix4 trans = Matrix4.Translation(-eye);

            return rot * trans;
        }

        #endregion  
    }
}