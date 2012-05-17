using System;
namespace OpenTK
{
    public partial struct Matrix3
    {
        /// <summary></summary>
        public static explicit operator Matrix3(Matrix3d m)
        {
            return new Matrix3(
                (Vector3)m.Column0,
                (Vector3)m.Column1,
                (Vector3)m.Column2);
        }
    }

}