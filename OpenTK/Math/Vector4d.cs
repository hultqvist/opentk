using System;
namespace OpenTK
{
    public partial struct Vector4d
    {
        #region Constructors

        /// <summary></summary>
        public Vector4d(Vector3d v)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
            W = 0.0f;
        }

        /// <summary></summary>
        public Vector4d(Vector3d v, float w)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
            W = w;
        }

        /// <summary></summary>
        public Vector4d(Vector2d v)
        {
            X = v.X;
            Y = v.Y;
            Z = 0.0f;
            W = 0.0f;
        }

        /// <summary></summary>
        public Vector4d(Vector2d v, float z, float w)
        {
            X = v.X;
            Y = v.Y;
            Z = z;
            W = w;
        }

        #endregion Constructors

        #region Conversions

        /// <summary></summary>
        public static explicit operator Vector4d(Vector4 v)
        {
            return new Vector4d(
                v.X,
                v.Y,
                v.Z,
                v.W
            );
        }

        /// <summary></summary>
        public static explicit operator Vector4d(Vector4i v)
        {
            return new Vector4d(
                v.X,
                v.Y,
                v.Z,
                v.W
            );
        }

        /// <summary></summary>
        public static explicit operator Vector4d(Vector4h v)
        {
            return new Vector4d(
                v.X,
                v.Y,
                v.Z,
                v.W
            );
        }

        #endregion
    }


}

