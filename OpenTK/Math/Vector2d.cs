using System;
namespace OpenTK
{
    public partial struct Vector2d
    {
        #region Conversions
        
        /// <summary></summary>
        public static explicit operator Vector2d(Vector2 v)
        {
            return new Vector2d(
                v.X,
                v.Y
            );
        }
        
        /// <summary></summary>
        public static explicit operator Vector2d(Vector2i v)
        {
            return new Vector2d(
                v.X,
                v.Y
            );
        }
        
        /// <summary></summary>
        public static explicit operator Vector2d(Vector2h v)
        {
            return new Vector2d(
                v.X,
                v.Y
            );
        }

        #endregion
    }



}

