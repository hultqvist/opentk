#region --- License ---
/* Copyright (c) 2006-2008 the OpenTK team.
 * See license.txt for license info
 * 
 * Contributions by Andy Gill.
 */
#endregion

#region --- Using Directives ---

using System;
using System.Collections.Generic;
#if !MINIMAL
using System.Drawing;
#endif
using System.Text;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Diagnostics;
using System.Reflection.Emit;


#endregion

namespace OpenTK.Graphics.OpenGL
{
    /// <summary>
    /// OpenGL bindings for .NET, implementing the full OpenGL API, including extensions.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This class contains all OpenGL enums and functions defined in the latest OpenGL specification.
    /// The official .spec files can be found at: http://opengl.org/registry/.
    /// </para>
    /// <para> A valid OpenGL context must be created before calling any OpenGL function.</para>
    /// <para>
    /// Use the GL.Load and GL.LoadAll methods to prepare function entry points prior to use. To maintain
    /// cross-platform compatibility, this must be done for both core and extension functions. The GameWindow
    /// and the GLControl class will take care of this automatically.
    /// </para>
    /// <para>
    /// You can use the GL.SupportsExtension method to check whether any given category of extension functions
    /// exists in the current OpenGL context. Keep in mind that different OpenGL contexts may support different
    /// extensions, and under different entry points. Always check if all required extensions are still supported
    /// when changing visuals or pixel formats.
    /// </para>
    /// <para>
    /// You may retrieve the entry point for an OpenGL function using the GL.GetDelegate method.
    /// </para>
    /// </remarks>
    /// <see href="http://opengl.org/registry/"/>
    public sealed partial class GL : GraphicsBindingsBase
    {
        #region --- Fields ---

        internal const string Library = "opengl32.dll";

        //static SortedList<string, bool> AvailableExtensions = new SortedList<string, bool>();
        static readonly object sync_root = new object();

        #endregion

        #region --- Constructor ---

        static GL()
        {
        }

        #endregion

        #region --- Public Members ---

        /// <summary>
        /// Loads all OpenGL entry points (core and extension).
        /// This method is provided for compatibility purposes with older OpenTK versions.
        /// </summary>
        [Obsolete("If you are using a context constructed outside of OpenTK, create a new GraphicsContext and pass your context handle to it. Otherwise, there is no need to call this method.")]
        public static void LoadAll()
        {
            new GL().LoadEntryPoints();
        }

        #endregion

        #region --- Protected Members ---

        /// <summary>
        /// Returns a synchronization token unique for the GL class.
        /// </summary>
        protected override object SyncRoot
        {
            get { return sync_root; }
        }

        #endregion

        #region --- GL Overloads ---

#pragma warning disable 3019
#pragma warning disable 1591
#pragma warning disable 1572
#pragma warning disable 1573

        // Note: Mono 1.9.1 truncates StringBuilder results (for 'out string' parameters).
        // We work around this issue by doubling the StringBuilder capacity.

        #region public static void ClearColor() overloads

        public static void ClearColor(Color color)
        {
            GL.ClearColor(color.R / 255.0f, color.G / 255.0f, color.B / 255.0f, color.A / 255.0f);
        }

        public static void ClearColor(Color4 color)
        {
            GL.ClearColor(color.R, color.G, color.B, color.A);
        }

        #endregion

        #region public static void BlendColor() overloads

        public static void BlendColor(Color color)
        {
            GL.BlendColor(color.R / 255.0f, color.G / 255.0f, color.B / 255.0f, color.A / 255.0f);
        }

        public static void BlendColor(Color4 color)
        {
            GL.BlendColor(color.R, color.G, color.B, color.A);
        }

        #endregion

        #region UniformMatrix

        public static void UniformMatrix4(int location, bool transpose, ref Matrix4 matrix)
        {
            unsafe
            {
                fixed (float* matrix_ptr = &matrix.Column0.X)
                {
                    GL.UniformMatrix4(location, 1, transpose, matrix_ptr);
                }
            }
        }

        #region Uniform

        [CLSCompliant(false)]
        public static void Uniform2(int location, ref Vector2 vector)
        {
            GL.Uniform2(location, vector.X, vector.Y);
        }

        [CLSCompliant(false)]
        public static void Uniform3(int location, ref Vector3 vector)
        {
            GL.Uniform3(location, vector.X, vector.Y, vector.Z);
        }

        [CLSCompliant(false)]
        public static void Uniform4(int location, ref Vector4 vector)
        {
            GL.Uniform4(location, vector.X, vector.Y, vector.Z, vector.W);
        }

        public static void Uniform2(int location, Vector2 vector)
        {
            GL.Uniform2(location, vector.X, vector.Y);
        }

        public static void Uniform3(int location, Vector3 vector)
        {
            GL.Uniform3(location, vector.X, vector.Y, vector.Z);
        }

        public static void Uniform4(int location, Vector4 vector)
        {
            GL.Uniform4(location, vector.X, vector.Y, vector.Z, vector.W);
        }

        public static void Uniform4(int location, Color4 color)
        {
            GL.Uniform4(location, color.R, color.G, color.B, color.A);
        }

        public static void Uniform4(int location, Quaternion quaternion)
        {
            GL.Uniform4(location, quaternion.X, quaternion.Y, quaternion.Z, quaternion.W);
        }

        #endregion

        #endregion

        #region Shaders

        #region GetActiveAttrib

        public static string GetActiveAttrib(uint program, uint index, out int size, out ActiveAttribType type)
        {
            int length;
            GetProgram(program, OpenTK.Graphics.OpenGL.ProgramParameter.ActiveAttributeMaxLength, out length);
            StringBuilder sb = new StringBuilder(length == 0 ? 1 : length * 2);

            GetActiveAttrib(program, index, sb.Capacity, out length, out size, out type, sb);
            return sb.ToString();
        }

        #endregion

        #region GetActiveUniform

        public static string GetActiveUniform(uint program, uint uniformIndex, out int size, out ActiveUniformType type)
        {
            int length;
            GetProgram(program, OpenTK.Graphics.OpenGL.ProgramParameter.ActiveUniformMaxLength, out length);

            StringBuilder sb = new StringBuilder(length == 0 ? 1 : length);
            GetActiveUniform(program, uniformIndex, sb.Capacity, out length, out size, out type, sb);
            return sb.ToString();
        }

        #endregion

        #region GetActiveUniformName

        public static string GetActiveUniformName(uint program, uint uniformIndex)
        {
            int length;
            GetProgram(program, OpenTK.Graphics.OpenGL.ProgramParameter.ActiveUniformMaxLength, out length);
            StringBuilder sb = new StringBuilder(length == 0 ? 1 : length * 2);

            GetActiveUniformName(program, uniformIndex, sb.Capacity, out length, sb);
            return sb.ToString();
        }

        #endregion

        #region GetActiveUniformBlockName

        public static string GetActiveUniformBlockName(uint program, uint uniformIndex)
        {
            int length;
            GetProgram(program, OpenTK.Graphics.OpenGL.ProgramParameter.ActiveUniformBlockMaxNameLength, out length);
            StringBuilder sb = new StringBuilder(length == 0 ? 1 : length * 2);

            GetActiveUniformBlockName(program, uniformIndex, sb.Capacity, out length, sb);
            return sb.ToString();
        }

        #endregion

        #region public static void ShaderSource(uint shader, System.String @string)

        public static void ShaderSource(uint shader, System.String @string)
        {
            unsafe
            {
                int length = @string.Length;
                GL.ShaderSource(shader, 1, new string[] { @string }, &length);
            }
        }

        #endregion

        #region public static string GetShaderInfoLog(uint shader)

        public static string GetShaderInfoLog(uint shader)
        {
            string info;
            GetShaderInfoLog(shader, out info);
            return info;
        }

        #endregion

        #region public static void GetShaderInfoLog(uint shader, out string info)

        public static void GetShaderInfoLog(uint shader, out string info)
        {
            unsafe
            {
                int length;
                GL.GetShader(shader, ShaderParameter.InfoLogLength, out length);
                if (length == 0)
                {
                    info = String.Empty;
                    return;
                }
                StringBuilder sb = new StringBuilder(length * 2);
                GL.GetShaderInfoLog(shader, sb.Capacity, &length, sb);
                info = sb.ToString();
            }
        }

        #endregion

        #region public static string GetProgramInfoLog(uint program)

        public static string GetProgramInfoLog(uint program)
        {
            string info;
            GetProgramInfoLog(program, out info);
            return info;
        }

        #endregion

        #region public static void GetProgramInfoLog(uint program, out string info)

        public static void GetProgramInfoLog(uint program, out string info)
        {
            unsafe
            {
                int length;
                GL.GetProgram(program, OpenTK.Graphics.OpenGL.ProgramParameter.InfoLogLength, out length); if (length == 0)
                {
                    info = String.Empty;
                    return;
                }
                StringBuilder sb = new StringBuilder(length * 2);
                GL.GetProgramInfoLog(program, sb.Capacity, &length, sb);
                info = sb.ToString();
            }
        }

        #endregion

        #endregion

        #region public static void PointParameter(PointSpriteCoordOriginParameter param)

        /// <summary>
        /// Helper function that defines the coordinate origin of the Point Sprite.
        /// </summary>
        /// <param name="param">
        /// A OpenTK.Graphics.OpenGL.GL.PointSpriteCoordOriginParameter token,
        /// denoting the origin of the Point Sprite.
        /// </param>
        public static void PointParameter(PointSpriteCoordOriginParameter param)
        {
            GL.PointParameter(PointParameterName.PointSpriteCoordOrigin, (int)param);
        }

        #endregion

        #region GenBuffer

        /// <summary>[requires: v1.5]
        /// Generates a single buffer object name
        /// </summary>
        /// <returns>The generated buffer object name</returns>
        public static uint GenBuffer()
        {
            uint id;
            GenBuffers(1, out id);
            return id;
        }

        #endregion

        #region DeleteBuffer

        /// <summary>[requires: v1.5]
        /// Deletes a single buffer object
        /// </summary>
        /// <param name="id">The buffer object to be deleted</param>
        [CLSCompliant(false)]
        public static void DeleteBuffer(uint id)
        {
            DeleteBuffers(1, ref id);
        }

        #endregion

        #region GenFramebuffer

        /// <summary>[requires: v3.0 and ARB_framebuffer_object]
        /// Generates a single framebuffer object name
        /// </summary>
        /// <returns>The generated framebuffer object name</returns>
        public static uint GenFramebuffer()
        {
            uint id;
            GenFramebuffers(1, out id);
            return id;
        }

        #endregion

        #region DeleteFramebuffer

        /// <summary>[requires: v3.0 and ARB_framebuffer_object]
        /// Deletes a single framebuffer object
        /// </summary>
        /// <param name="id">The framebuffer object to be deleted</param>
        [CLSCompliant(false)]
        public static void DeleteFramebuffer(uint id)
        {
            DeleteFramebuffers(1, ref id);
        }

        #endregion

        #region GenProgramPipeline

        /// <summary>[requires: v4.1 and ARB_separate_shader_objects]
        /// Generates a single single pipeline object name
        /// </summary>
        /// <returns>The generated single pipeline object name</returns>
        public static uint GenProgramPipeline()
        {
            uint id;
            GenProgramPipelines(1, out id);
            return id;
        }

        #endregion

        #region DeleteProgramPipeline

        /// <summary>[requires: v4.1 and ARB_separate_shader_objects]
        /// Deletes a single program pipeline object
        /// </summary>
        /// <param name="id">The program pipeline object to be deleted</param>
        [CLSCompliant(false)]
        public static void DeleteProgramPipeline(uint id)
        {
            DeleteProgramPipelines(1, ref id);
        }

        #endregion

        #region GenQuery

        /// <summary>[requires: v1.5]
        /// Generates a single query object name
        /// </summary>
        /// <returns>The generated query object name</returns>
        public static uint GenQuery()
        {
            uint id;
            GenQueries(1, out id);
            return id;
        }

        #endregion

        #region DeleteQuery

        /// <summary>
        /// Deletes a single query object
        /// </summary>
        /// <param name="id">The query object to be deleted</param>
        [CLSCompliant(false)]
        public static void DeleteQuery(uint id)
        {
            DeleteQueries(1, ref id);
        }

        #endregion

        #region GenRenderbuffer

        /// <summary>[requires: v3.0 and ARB_framebuffer_object]
        /// Generates a single renderbuffer object name
        /// </summary>
        /// <returns>The generated renderbuffer object name</returns>
        public static uint GenRenderbuffer()
        {
            uint id;
            GenRenderbuffers(1, out id);
            return id;
        }

        #endregion

        #region DeleteRenderbuffer

        /// <summary>[requires: v3.0 and ARB_framebuffer_object]
        /// Deletes a single renderbuffer object
        /// </summary>
        /// <param name="id">The renderbuffer object to be deleted</param>
        [CLSCompliant(false)]
        public static void DeleteRenderbuffer(uint id)
        {
            DeleteRenderbuffers(1, ref id);
        }

        #endregion

        #region GenSampler

        /// <summary>
        /// Generates a single sampler object name
        /// </summary>
        /// <returns>The generated sampler object name</returns>
        public static uint GenSampler()
        {
            uint id;
            GenSamplers(1, out id);
            return id;
        }

        #endregion

        #region DeleteSampler

        /// <summary>
        /// Deletes a single sampler object
        /// </summary>
        /// <param name="id">The sampler object to be deleted</param>
        [CLSCompliant(false)]
        public static void DeleteSampler(uint id)
        {
            DeleteSamplers(1, ref id);
        }

        #endregion

        #region GenTexture

        /// <summary>[requires: v1.1]
        /// Generate a single texture name
        /// </summary>
        /// <returns>The generated texture name</returns>
        public static uint GenTexture()
        {
            uint id;
            GenTextures(1, out id);
            return id;
        }

        #endregion

        #region DeleteTexture

        /// <summary>[requires: v1.1]
        /// Delete a single texture name
        /// </summary>
        /// <param name="id">The texture to be deleted</param>
        [CLSCompliant(false)]
        public static void DeleteTexture(uint id)
        {
            DeleteTextures(1, ref id);
        }

        #endregion

        #region GenTransformFeedback

        /// <summary>[requires: v1.2 and ARB_transform_feedback2]
        /// Generates a single transform feedback object name
        /// </summary>
        /// <returns>The generated transform feedback object name</returns>
        public static uint GenTransformFeedback()
        {
            uint id;
            GenTransformFeedback(1, out id);
            return id;
        }

        #endregion

        #region DeleteTransformFeedback

        /// <summary>[requires: v1.2 and ARB_transform_feedback2]
        /// Deletes a single transform feedback object
        /// </summary>
        /// <param name="id">The transform feedback object to be deleted</param>
        [CLSCompliant(false)]
        public static void DeleteTransformFeedback(uint id)
        {
            DeleteTransformFeedback(1, ref id);
        }

        #endregion

        #region GenVertexArray

        /// <summary>[requires: v3.0 and ARB_vertex_array_object]
        /// Generates a single vertex array object name
        /// </summary>
        /// <returns>The generated vertex array object name</returns>
        public static uint GenVertexArray()
        {
            uint id;
            GenVertexArrays(1, out id);
            return id;
        }

        #endregion

        #region DeleteVertexArray

        /// <summary>[requires: v3.0 and ARB_vertex_array_object]
        /// Deletes a single vertex array object
        /// </summary>
        /// <param name="id">The vertex array object to be deleted</param>
        [CLSCompliant(false)]
        public static void DeleteVertexArray(uint id)
        {
            DeleteVertexArrays(1, ref id);
        }

        #endregion

        #region VertexAttribPointer

        public static void VertexAttribPointer(uint index, int size, VertexAttribPointerType type, bool normalized, int stride, int offset)
        {
            VertexAttribPointer(index, size, type, normalized, stride, (IntPtr)offset);
        }

        #endregion

        #region DrawElements

        public static void DrawElements(BeginMode mode, int count, DrawElementsType type, int offset)
        {
            DrawElements(mode, count, type, new IntPtr(offset));
        }

        #endregion

        #region Get[Float|Double]

        public static void GetFloat(GetPName pname, out Vector2 vector)
        {
            unsafe
            {
                fixed (Vector2* ptr = &vector)
                    GetFloat(pname, (float*)ptr);
            }
        }

        public static void GetFloat(GetPName pname, out Vector3 vector)
        {
            unsafe
            {
                fixed (Vector3* ptr = &vector)
                    GetFloat(pname, (float*)ptr);
            }
        }

        public static void GetFloat(GetPName pname, out Vector4 vector)
        {
            unsafe
            {
                fixed (Vector4* ptr = &vector)
                    GetFloat(pname, (float*)ptr);
            }
        }

        public static void GetFloat(GetPName pname, out Matrix4 matrix)
        {
            unsafe
            {
                fixed (Matrix4* ptr = &matrix)
                    GetFloat(pname, (float*)ptr);
            }
        }

        public static void GetDouble(GetPName pname, out Vector2d vector)
        {
            unsafe
            {
                fixed (Vector2d* ptr = &vector)
                    GetDouble(pname, (double*)ptr);
            }
        }

        public static void GetDouble(GetPName pname, out Vector3d vector)
        {
            unsafe
            {
                fixed (Vector3d* ptr = &vector)
                    GetDouble(pname, (double*)ptr);
            }
        }

        public static void GetDouble(GetPName pname, out Vector4d vector)
        {
            unsafe
            {
                fixed (Vector4d* ptr = &vector)
                    GetDouble(pname, (double*)ptr);
            }
        }

        public static void GetDouble(GetPName pname, out Matrix4d matrix)
        {
            unsafe
            {
                fixed (Matrix4d* ptr = &matrix)
                    GetDouble(pname, (double*)ptr);
            }
        }

        #endregion

        #region Viewport

        public static void Viewport(Size size)
        {
            GL.Viewport(0, 0, size.Width, size.Height);
        }

        public static void Viewport(Point location, Size size)
        {
            GL.Viewport(location.X, location.Y, size.Width, size.Height);
        }

        public static void Viewport(Rectangle rectangle)
        {
            GL.Viewport(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
        }
#if NO_SYSDRAWING
        public static void Viewport(OpenTK.Point location, OpenTK.Size size)
        {
            GL.Viewport(location.X, location.Y, size.Width, size.Height);
        }

        public static void Viewport(OpenTK.Rectangle rectangle)
        {
            GL.Viewport(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
        }
#endif
        #endregion

#pragma warning restore 3019
#pragma warning restore 1591
#pragma warning restore 1572
#pragma warning restore 1573

        #endregion
    }

    /// <summary></summary>
    public delegate void DebugProcAmd(uint id,
        AmdDebugOutput category, AmdDebugOutput severity,
        IntPtr length, string message, IntPtr userParam);

    /// <summary></summary>
    public delegate void DebugProcArb(uint id,
        ArbDebugOutput category, ArbDebugOutput severity,
        IntPtr length, string message, IntPtr userParam);
}
