using System;
namespace OpenTK
{
    // Single Location for all Vector to Vector operators
    // See MatrixOperators for Vector - Matrix operations

    // Current design guidelines: subject to change
    // Higher to lower dimensions are done via swizzle Vector2 v2 = v.xy (implemented in respective file);

    // Lower to higher are done via constructor, Vector4 v = new Vector4(v2, z, w);
    // Cast operators(explicit operator X) are implemented in the destination class(in this file)

    #region Vector4x

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

    public partial struct Vector4i
    {
        #region Constructors

        /// <summary></summary>
        public Vector4i(Vector3i v)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
            W = 0;
        }

        /// <summary></summary>
        public Vector4i(Vector3i v, int w)
        {
            X = v.X;
            Y = v.Y;
            Z = v.Z;
            W = w;
        }

        /// <summary></summary>
        public Vector4i(Vector2i v)
        {
            X = v.X;
            Y = v.Y;
            Z = 0;
            W = 0;
        }

        /// <summary></summary>
        public Vector4i(Vector2i v, int z, int w)
        {
            X = v.X;
            Y = v.Y;
            Z = z;
            W = w;
        }

        /// <summary></summary>
        public Vector4i(double x, double y, double z, double w)
        {
            X = (int)x;
            Y = (int)y;
            Z = (int)z;
            W = (int)w;
        }

        #endregion Constructors
    }

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

    #endregion Vector4x

    #region Vector3x

    public partial struct Vector3d
    {
        #region Constructors

        /// <summary></summary>
        public Vector3d(Vector2d v)
        {
            X = v.X;
            Y = v.Y;
            Z = 0.0f;
        }
        
        /// <summary></summary>
        public Vector3d(Vector2d v, float z)
        {
            X = v.X;
            Y = v.Y;
            Z = z;
        }

        #endregion Constructors

        #region Conversions

        /// <summary></summary>
        public static explicit operator Vector3d(Vector3 v)
        {
            return new Vector3d(
                v.X,
                v.Y,
                v.Z
            );
        }

        /// <summary></summary>
        public static explicit operator Vector3d(Vector3i v)
        {
            return new Vector3d(
                v.X,
                v.Y,
                v.Z
            );
        }
        
        /// <summary></summary>
        public static explicit operator Vector3d(Vector3h v)
        {
            return new Vector3d(
                v.X,
                v.Y,
                v.Z
            );
        }

        #endregion
    }

    public partial struct Vector3
    {
        #region Constructors

        /// <summary></summary>
        public Vector3(Vector2 v)
        {
            X = v.X;
            Y = v.Y;
            Z = 0.0f;
        }

        /// <summary></summary>
        public Vector3(Vector2 v, float z)
        {
            X = v.X;
            Y = v.Y;
            Z = z;
        }

        /// <summary></summary>
        public Vector3(double x, double y, double z)
        {
            X = (float)x;
            Y = (float)y;
            Z = (float)z;
        }

        #endregion Constructors

        #region Conversions

        /// <summary></summary>
        public static explicit operator Vector3(Vector3d v)
        {
            return new Vector3(
                (float)v.X,
                (float)v.Y,
                (float)v.Z
            );
        }

        /// <summary></summary>
        public static explicit operator Vector3(Vector3i v)
        {
            return new Vector3(
                v.X,
                v.Y,
                v.Z
            );
        }

        /// <summary></summary>
        public static explicit operator Vector3(Vector3h v)
        {
            return new Vector3(
                (float)v.X,
                v.Y,
                v.Z
            );
        }

        #endregion
    }

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
    }

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

    #endregion Vector3x

    #region Vector2x

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

    public partial struct Vector2
    {
        /// <summary></summary>
        public Vector2 (double x, double y)
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
    }

    public partial struct Vector2i
    {
        /// <summary></summary>
        public Vector2i (double x, double y)
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

    #endregion Vector2x

}

