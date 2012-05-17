using System;
namespace OpenTK
{
    public partial struct Vector4
    {
        #region Constructors

        /// <summary>
        /// Initializes w to 0
        /// </summary>
        public Vector4(Vector3 v)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
            W = 0.0f;
        }

        /// <summary></summary>
        public Vector4(Vector3 v, float w)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
            W = w;
        }

        /// <summary></summary>
        public Vector4(Vector2 v)
        {
            X = v.X;
            Y = v.Y;
            Z = 0.0f;
            W = 0.0f;
        }

        /// <summary></summary>
        public Vector4(Vector2 v, float z, float w)
        {
            X = v.X;
            Y = v.Y;
            Z = z;
            W = w;
        }

        /// <summary></summary>
        public Vector4(double x, double y, double z, double w)
        {
            X = (float)x;
            Y = (float)y;
            Z = (float)z;
            W = (float)w;
        }

        #endregion Constructors

        #region Conversions

        /// <summary></summary>
        public static explicit operator Vector4(Vector4d v)
        {
            return new Vector4(
                (float)v.X,
                (float)v.Y,
                (float)v.Z,
                (float)v.W
            );
        }

        /// <summary></summary>
        public static explicit operator Vector4(Vector4i v)
        {
            return new Vector4(
                v.X,
                v.Y,
                v.Z,
                v.W
            );
        }

        /// <summary></summary>
        public static explicit operator Vector4(Vector4h v)
        {
            return new Vector4(
                v.X,
                v.Y,
                v.Z,
                v.W
            );
        }

        #endregion
    }



}

