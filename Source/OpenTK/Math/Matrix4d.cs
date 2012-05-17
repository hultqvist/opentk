using System;
namespace OpenTK
{
    public partial struct Matrix4d
    {
        /// <summary></summary>
        public static explicit operator Matrix4d(Matrix4 m)
        {
            return new Matrix4d(
                (Vector4d)m.Column0,
                (Vector4d)m.Column1,
                (Vector4d)m.Column2,
                (Vector4d)m.Column3);
        }

        #region Camera LookAt Helper

        /// <summary>
        /// Build a world space to camera space matrix
        /// </summary>
        /// <param name="eye">Eye (camera) position in world space</param>
        /// <param name="target">Target position in world space</param>
        /// <param name="up">Up vector in world space (should not be parallel to the camera direction, that is target - eye)</param>
        /// <returns>A MatrixTemplate that transforms world space to camera space</returns>
        public static Matrix4d LookAt(Vector3d eye, Vector3d target, Vector3d up)
        {
            Vector3d z = (eye - target).Normalize();
            Vector3d x = Vector3d.Cross(up, z).Normalize();
            Vector3d y = Vector3d.Cross(z, x).Normalize();

            Matrix4d rot = new Matrix4d(x.X, x.Y, x.Z, 0,
                                      y.X, y.Y, y.Z, 0,
                                      z.X, z.Y, z.Z, 0,
                                      0, 0, 0, 1);

            Matrix4d trans = Matrix4d.Translation(-eye);

            return rot * trans;
        }

        #endregion
    }

}