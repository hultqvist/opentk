using System;
namespace OpenTK
{
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



}

