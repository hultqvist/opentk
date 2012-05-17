using System;
namespace OpenTK
{
    public partial struct Vector2h
    {
        #region Conversions
        
        /// <summary></summary>
        public static explicit operator Vector2h(Vector2d v)
        {
            return new Vector2h(
                v.X,
                v.Y
            );
        }
        
        /// <summary></summary>
        public static explicit operator Vector2h(Vector2 v)
        {
            return new Vector2h(
                v.X,
                v.Y
            );
        }
        
        /// <summary></summary>
        public static explicit operator Vector2h(Vector2i v)
        {
            return new Vector2h(
                v.X,
                v.Y
            );
        }

        #endregion
    }


}

