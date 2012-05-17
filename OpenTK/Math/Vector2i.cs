using System;
namespace OpenTK
{
    public partial struct Vector2i
    {
        /// <summary></summary>
        public Vector2i(double x, double y)
        {
            this.X = (int)x;
            this.Y = (int)y;
        }

        #region Conversions
        
        /// <summary></summary>
        public static explicit operator Vector2i(Vector2d v)
        {
            return new Vector2i(
                v.X,
                v.Y
            );
        }
        
        /// <summary></summary>
        public static explicit operator Vector2i(Vector2 v)
        {
            return new Vector2i(
                v.X,
                v.Y
            );
        }
        
        /// <summary></summary>
        public static explicit operator Vector2i(Vector2h v)
        {
            return new Vector2i(
                v.X,
                v.Y
            );
        }

        #endregion
    }



}

