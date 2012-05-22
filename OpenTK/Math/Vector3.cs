using System;
namespace OpenTK
{
    public partial struct Vector3
    {
        #region Constructors

        /// <summary></summary>
        public Vector3(Vector2 v)
        {
            X = v.X;
            Y = v.Y;
            Z = 0.0f;
        }

        /// <summary></summary>
        public Vector3(Vector2 v, float z)
        {
            X = v.X;
            Y = v.Y;
            Z = z;
        }

        /// <summary></summary>
        public Vector3(double x, double y, double z)
        {
            X = (float)x;
            Y = (float)y;
            Z = (float)z;
        }

        #endregion Constructors

        #region Conversions

        /// <summary></summary>
        public static explicit operator Vector3(Vector3d v)
        {
            return new Vector3(
                (float)v.X,
                (float)v.Y,
                (float)v.Z
            );
        }

        /// <summary></summary>
        public static explicit operator Vector3(Vector3i v)
        {
            return new Vector3(
                v.X,
                v.Y,
                v.Z
            );
        }

        /// <summary></summary>
        public static explicit operator Vector3(Vector3h v)
        {
            return new Vector3(
                (float)v.X,
                v.Y,
                v.Z
            );
        }

        #endregion
    }

    public partial struct Vector3d
    {
    }
}

