using System;
namespace OpenTK
{
    public partial struct Vector3d
    {
        #region Constructors

        /// <summary></summary>
        public Vector3d(Vector2d v)
        {
            X = v.X;
            Y = v.Y;
            Z = 0.0f;
        }
        
        /// <summary></summary>
        public Vector3d(Vector2d v, float z)
        {
            X = v.X;
            Y = v.Y;
            Z = z;
        }

        #endregion Constructors

        #region Conversions

        /// <summary></summary>
        public static explicit operator Vector3d(Vector3 v)
        {
            return new Vector3d(
                v.X,
                v.Y,
                v.Z
            );
        }

        /// <summary></summary>
        public static explicit operator Vector3d(Vector3i v)
        {
            return new Vector3d(
                v.X,
                v.Y,
                v.Z
            );
        }
        
        /// <summary></summary>
        public static explicit operator Vector3d(Vector3h v)
        {
            return new Vector3d(
                v.X,
                v.Y,
                v.Z
            );
        }

        #endregion
    }


}

