using System;
namespace OpenTK
{
    public partial struct Vector4h
    {
        #region Constructors

        /// <summary></summary>
        public Vector4h(Vector3h v)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
            W = 0.0f;
        }

        /// <summary></summary>
        public Vector4h(Vector3h v, Half w)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
            W = w;
        }
        
        /// <summary></summary>
        public Vector4h(Vector2h v)
        {
            X = v.X;
            Y = v.Y;
            Z = 0.0f;
            W = 0.0f;
        }
        
        /// <summary></summary>
        public Vector4h(Vector2h v, Half z, Half w)
        {
            X = v.X;
            Y = v.Y;
            Z = z;
            W = w;
        }

        #endregion Constructors

        #region Conversions
        
        /// <summary></summary>
        public static explicit operator Vector4h(Vector4d v)
        {
            return new Vector4h(
                v.X,
                v.Y,
                v.Z,
                v.W
            );
        }

        /// <summary></summary>
        public static explicit operator Vector4h(Vector4 v)
        {
            return new Vector4h(
                v.X,
                v.Y,
                v.Z,
                v.W
            );
        }
        
        /// <summary></summary>
        public static explicit operator Vector4h(Vector4i v)
        {
            return new Vector4h(
                v.X,
                v.Y,
                v.Z,
                v.W
            );
        }

        #endregion
    }



}

