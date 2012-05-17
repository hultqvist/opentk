using System;
namespace OpenTK
{
    public partial struct Vector2
    {
        /// <summary></summary>
        public Vector2(double x, double y)
        {
            this.X = (float)x;
            this.Y = (float)y;
        }

        #region Conversions
        
        /// <summary></summary>
        public static explicit operator Vector2(Vector2d v)
        {
            return new Vector2(
                (float)v.X,
                (float)v.Y
            );
        }
        
        /// <summary></summary>
        public static explicit operator Vector2(Vector2i v)
        {
            return new Vector2(
                v.X,
                v.Y
            );
        }

        /// <summary></summary>
        public static explicit operator Vector2(Vector2h v)
        {
            return new Vector2(
                v.X,
                v.Y
            );
        }

        #endregion
    

        #region Perpendicular

        /// <summary>
        /// Gets the perpendicular vector on the right side of this vector.
        /// </summary>
        public Vector2 PerpendicularRight
        {
            get { return new Vector2(Y, -X); }
        }
 
        /// <summary>
        /// Gets the perpendicular vector on the left side of this vector.
        /// </summary>
        public Vector2 PerpendicularLeft
        {
            get { return new Vector2(-Y, X); }
        }
 
        #endregion Perpendicular
    }
}

