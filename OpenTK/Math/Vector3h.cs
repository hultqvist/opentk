using System;
namespace OpenTK
{
    public partial struct Vector3h
    {
        #region Constructors
        
        /// <summary></summary>
        public Vector3h(Vector2h v)
        {
            X = v.X;
            Y = v.Y;
            Z = 0.0f;
        }
        
        /// <summary></summary>
        public Vector3h(Vector2h v, Half z)
        {
            X = v.X;
            Y = v.Y;
            Z = z;
        }

        #endregion Constructors

        #region Conversions
        
        /// <summary></summary>
        public static explicit operator Vector3h(Vector3d v)
        {
            return new Vector3h(
                v.X,
                v.Y,
                v.Z
            );
        }
        
        /// <summary></summary>
        public static explicit operator Vector3h(Vector3 v)
        {
            return new Vector3h(
                v.X,
                v.Y,
                v.Z
            );
        }
        
        /// <summary></summary>
        public static explicit operator Vector3h(Vector3i v)
        {
            return new Vector3h(
                v.X,
                v.Y,
                v.Z
            );
        }

        #endregion
    }




}

