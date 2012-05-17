using System;
namespace OpenTK
{
    public partial struct Vector3i
    {
        #region Constructors
        
        /// <summary></summary>
        public Vector3i(Vector2i v)
        {
            X = v.X;
            Y = v.Y;
            Z = 0;
        }
        
        /// <summary></summary>
        public Vector3i(Vector2i v, int z)
        {
            X = v.X;
            Y = v.Y;
            Z = z;
        }
        
        /// <summary></summary>
        public Vector3i(double x, double y, double z)
        {
            X = (int)x;
            Y = (int)y;
            Z = (int)z;
        }
        
        /// <summary></summary>
        public static Vector3i Floor(Vector3 v)
        {
            return new Vector3i(
                (int)Math.Floor(v.X),
                (int)Math.Floor(v.Y),
                (int)Math.Floor(v.Z));
        }
        
        /// <summary></summary>
        public static Vector3i Floor(Vector3d v)
        {
            return new Vector3i(
                (int)Math.Floor(v.X),
                (int)Math.Floor(v.Y),
                (int)Math.Floor(v.Z));
        }

        #endregion Constructors

        #region Conversions
        
        /// <summary></summary>
        public static explicit operator Vector3i(Vector3d v)
        {
            return new Vector3i(
                v.X,
                v.Y,
                v.Z
            );
        }
        
        /// <summary></summary>
        public static explicit operator Vector3i(Vector3 v)
        {
            return new Vector3i(
                v.X,
                v.Y,
                v.Z
            );
        }
        
        /// <summary></summary>
        public static explicit operator Vector3i(Vector3h v)
        {
            return new Vector3i(
                v.X,
                v.Y,
                v.Z
            );
        }

        #endregion

        #region Operators

        /// <summary>Component wise but operator</summary>
        public static Vector3i operator &(Vector3i v, int value)
        {
            return new Vector3i(
                v.X & value,
                v.Y & value,
                v.Z & value);
        }

        #endregion Operators
    }



}

