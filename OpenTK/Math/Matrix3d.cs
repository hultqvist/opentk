using System;
namespace OpenTK
{
    public partial struct Matrix3d
    {
        /// <summary></summary>
        public static explicit operator Matrix3d(Matrix3 m)
        {
            return new Matrix3d(
                (Vector3d)m.Column0,
                (Vector3d)m.Column1,
                (Vector3d)m.Column2);
        }
    }
}