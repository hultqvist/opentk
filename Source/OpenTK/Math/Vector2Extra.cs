using System;
namespace OpenTK
{
    public partial struct Vector2
    {
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

