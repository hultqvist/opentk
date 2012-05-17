// This file is auto-generated through the Generator.Bind project.
// Do not edit by hand!

//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2012 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//



using System;

namespace OpenTK.Graphics.ES20
{
    /// <summary>
    /// Used in GL.GetActiveAttrib
    /// </summary>
    public enum ActiveAttribType : int
    {
        /// <summary>
        /// Original was GL_Float = 0X1406
        /// </summary>
        Float = ((int)0X1406)        ,
        /// <summary>
        /// Original was GL_FloatVec2 = 0X8b50
        /// </summary>
        FloatVec2 = ((int)0X8b50)        ,
        /// <summary>
        /// Original was GL_FloatVec3 = 0X8b51
        /// </summary>
        FloatVec3 = ((int)0X8b51)        ,
        /// <summary>
        /// Original was GL_FloatVec4 = 0X8b52
        /// </summary>
        FloatVec4 = ((int)0X8b52)        ,
        /// <summary>
        /// Original was GL_FloatMat2 = 0X8b5a
        /// </summary>
        FloatMat2 = ((int)0X8b5a)        ,
        /// <summary>
        /// Original was GL_FloatMat3 = 0X8b5b
        /// </summary>
        FloatMat3 = ((int)0X8b5b)        ,
        /// <summary>
        /// Original was GL_FloatMat4 = 0X8b5c
        /// </summary>
        FloatMat4 = ((int)0X8b5c)        ,
    }

    /// <summary>
    /// Used in GL.GetActiveUniform
    /// </summary>
    public enum ActiveUniformType : int
    {
        /// <summary>
        /// Original was GL_Int = 0X1404
        /// </summary>
        Int = ((int)0X1404)        ,
        /// <summary>
        /// Original was GL_Float = 0X1406
        /// </summary>
        Float = ((int)0X1406)        ,
        /// <summary>
        /// Original was GL_FloatVec2 = 0X8b50
        /// </summary>
        FloatVec2 = ((int)0X8b50)        ,
        /// <summary>
        /// Original was GL_FloatVec3 = 0X8b51
        /// </summary>
        FloatVec3 = ((int)0X8b51)        ,
        /// <summary>
        /// Original was GL_FloatVec4 = 0X8b52
        /// </summary>
        FloatVec4 = ((int)0X8b52)        ,
        /// <summary>
        /// Original was GL_IntVec2 = 0X8b53
        /// </summary>
        IntVec2 = ((int)0X8b53)        ,
        /// <summary>
        /// Original was GL_IntVec3 = 0X8b54
        /// </summary>
        IntVec3 = ((int)0X8b54)        ,
        /// <summary>
        /// Original was GL_IntVec4 = 0X8b55
        /// </summary>
        IntVec4 = ((int)0X8b55)        ,
        /// <summary>
        /// Original was GL_Bool = 0X8b56
        /// </summary>
        Bool = ((int)0X8b56)        ,
        /// <summary>
        /// Original was GL_BoolVec2 = 0X8b57
        /// </summary>
        BoolVec2 = ((int)0X8b57)        ,
        /// <summary>
        /// Original was GL_BoolVec3 = 0X8b58
        /// </summary>
        BoolVec3 = ((int)0X8b58)        ,
        /// <summary>
        /// Original was GL_BoolVec4 = 0X8b59
        /// </summary>
        BoolVec4 = ((int)0X8b59)        ,
        /// <summary>
        /// Original was GL_FloatMat2 = 0X8b5a
        /// </summary>
        FloatMat2 = ((int)0X8b5a)        ,
        /// <summary>
        /// Original was GL_FloatMat3 = 0X8b5b
        /// </summary>
        FloatMat3 = ((int)0X8b5b)        ,
        /// <summary>
        /// Original was GL_FloatMat4 = 0X8b5c
        /// </summary>
        FloatMat4 = ((int)0X8b5c)        ,
        /// <summary>
        /// Original was GL_Sampler2D = 0X8b5e
        /// </summary>
        Sampler2D = ((int)0X8b5e)        ,
        /// <summary>
        /// Original was GL_SamplerCube = 0X8b60
        /// </summary>
        SamplerCube = ((int)0X8b60)        ,
    }

    /// <summary>
    /// Used in GL.Amd.GetPerfMonitorCounterData, GL.Amd.GetPerfMonitorCounterInfo, GL.Angle.BlitFramebuffer, GL.Angle.RenderbufferStorageMultisample, GL.Ext.DiscardFramebuffer, GL.Ext.MultiDrawArrays, GL.Ext.MultiDrawElements, GL.NV.CoverageOperation, GL.NV.GetFence, GL.NV.SetFence, GL.Oes.CompressedTexImage3D, GL.Oes.CompressedTexSubImage3D, GL.Oes.CopyTexSubImage3D, GL.Oes.EGLImageTargetRenderbufferStorage, GL.Oes.EGLImageTargetTexture2D, GL.Oes.FramebufferTexture3D, GL.Oes.GetBufferPointer, GL.Oes.GetProgramBinary, GL.Oes.MapBuffer, GL.Oes.ProgramBinary, GL.Oes.TexImage3D, GL.Oes.TexSubImage3D, GL.Oes.UnmapBuffer, GL.Qcom.ExtGetBufferPointer, GL.Qcom.ExtGetProgramBinarySource, GL.Qcom.ExtGetTexLevelParameter, GL.Qcom.ExtGetTexSubImage, GL.Qcom.ExtTexObjectStateOverride
    /// </summary>
    public enum All : int
    {
        /// <summary>
        /// Original was GL_FALSE = 0
        /// </summary>
        False = ((int)0)        ,
        /// <summary>
        /// Original was GL_NO_ERROR = 0
        /// </summary>
        NoError = ((int)0)        ,
        /// <summary>
        /// Original was GL_NONE = 0
        /// </summary>
        None = ((int)0)        ,
        /// <summary>
        /// Original was GL_ZERO = 0
        /// </summary>
        Zero = ((int)0)        ,
        /// <summary>
        /// Original was GL_POINTS = 0x0000
        /// </summary>
        Points = ((int)0x0000)        ,
        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT0_QCOM = 0x00000001
        /// </summary>
        ColorBufferBit0Qcom = ((int)0x00000001)        ,
        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT1_QCOM = 0x00000002
        /// </summary>
        ColorBufferBit1Qcom = ((int)0x00000002)        ,
        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT2_QCOM = 0x00000004
        /// </summary>
        ColorBufferBit2Qcom = ((int)0x00000004)        ,
        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT3_QCOM = 0x00000008
        /// </summary>
        ColorBufferBit3Qcom = ((int)0x00000008)        ,
        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT4_QCOM = 0x00000010
        /// </summary>
        ColorBufferBit4Qcom = ((int)0x00000010)        ,
        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT5_QCOM = 0x00000020
        /// </summary>
        ColorBufferBit5Qcom = ((int)0x00000020)        ,
        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT6_QCOM = 0x00000040
        /// </summary>
        ColorBufferBit6Qcom = ((int)0x00000040)        ,
        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT7_QCOM = 0x00000080
        /// </summary>
        ColorBufferBit7Qcom = ((int)0x00000080)        ,
        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT = 0x00000100
        /// </summary>
        DepthBufferBit = ((int)0x00000100)        ,
        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT0_QCOM = 0x00000100
        /// </summary>
        DepthBufferBit0Qcom = ((int)0x00000100)        ,
        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT1_QCOM = 0x00000200
        /// </summary>
        DepthBufferBit1Qcom = ((int)0x00000200)        ,
        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT2_QCOM = 0x00000400
        /// </summary>
        DepthBufferBit2Qcom = ((int)0x00000400)        ,
        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT = 0x00000400
        /// </summary>
        StencilBufferBit = ((int)0x00000400)        ,
        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT3_QCOM = 0x00000800
        /// </summary>
        DepthBufferBit3Qcom = ((int)0x00000800)        ,
        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT4_QCOM = 0x00001000
        /// </summary>
        DepthBufferBit4Qcom = ((int)0x00001000)        ,
        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT5_QCOM = 0x00002000
        /// </summary>
        DepthBufferBit5Qcom = ((int)0x00002000)        ,
        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT = 0x00004000
        /// </summary>
        ColorBufferBit = ((int)0x00004000)        ,
        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT6_QCOM = 0x00004000
        /// </summary>
        DepthBufferBit6Qcom = ((int)0x00004000)        ,
        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT7_QCOM = 0x00008000
        /// </summary>
        DepthBufferBit7Qcom = ((int)0x00008000)        ,
        /// <summary>
        /// Original was GL_LINES = 0x0001
        /// </summary>
        Lines = ((int)0x0001)        ,
        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT0_QCOM = 0x00010000
        /// </summary>
        StencilBufferBit0Qcom = ((int)0x00010000)        ,
        /// <summary>
        /// Original was GL_LINE_LOOP = 0x0002
        /// </summary>
        LineLoop = ((int)0x0002)        ,
        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT1_QCOM = 0x00020000
        /// </summary>
        StencilBufferBit1Qcom = ((int)0x00020000)        ,
        /// <summary>
        /// Original was GL_LINE_STRIP = 0x0003
        /// </summary>
        LineStrip = ((int)0x0003)        ,
        /// <summary>
        /// Original was GL_TRIANGLES = 0x0004
        /// </summary>
        Triangles = ((int)0x0004)        ,
        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT2_QCOM = 0x00040000
        /// </summary>
        StencilBufferBit2Qcom = ((int)0x00040000)        ,
        /// <summary>
        /// Original was GL_TRIANGLE_STRIP = 0x0005
        /// </summary>
        TriangleStrip = ((int)0x0005)        ,
        /// <summary>
        /// Original was GL_TRIANGLE_FAN = 0x0006
        /// </summary>
        TriangleFan = ((int)0x0006)        ,
        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT3_QCOM = 0x00080000
        /// </summary>
        StencilBufferBit3Qcom = ((int)0x00080000)        ,
        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT4_QCOM = 0x00100000
        /// </summary>
        StencilBufferBit4Qcom = ((int)0x00100000)        ,
        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT5_QCOM = 0x00200000
        /// </summary>
        StencilBufferBit5Qcom = ((int)0x00200000)        ,
        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT6_QCOM = 0x00400000
        /// </summary>
        StencilBufferBit6Qcom = ((int)0x00400000)        ,
        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT7_QCOM = 0x00800000
        /// </summary>
        StencilBufferBit7Qcom = ((int)0x00800000)        ,
        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT0_QCOM = 0x01000000
        /// </summary>
        MultisampleBufferBit0Qcom = ((int)0x01000000)        ,
        /// <summary>
        /// Original was GL_NEVER = 0x0200
        /// </summary>
        Never = ((int)0x0200)        ,
        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT1_QCOM = 0x02000000
        /// </summary>
        MultisampleBufferBit1Qcom = ((int)0x02000000)        ,
        /// <summary>
        /// Original was GL_LESS = 0x0201
        /// </summary>
        Less = ((int)0x0201)        ,
        /// <summary>
        /// Original was GL_EQUAL = 0x0202
        /// </summary>
        Equal = ((int)0x0202)        ,
        /// <summary>
        /// Original was GL_LEQUAL = 0x0203
        /// </summary>
        Lequal = ((int)0x0203)        ,
        /// <summary>
        /// Original was GL_GREATER = 0x0204
        /// </summary>
        Greater = ((int)0x0204)        ,
        /// <summary>
        /// Original was GL_NOTEQUAL = 0x0205
        /// </summary>
        Notequal = ((int)0x0205)        ,
        /// <summary>
        /// Original was GL_GEQUAL = 0x0206
        /// </summary>
        Gequal = ((int)0x0206)        ,
        /// <summary>
        /// Original was GL_ALWAYS = 0x0207
        /// </summary>
        Always = ((int)0x0207)        ,
        /// <summary>
        /// Original was GL_SRC_COLOR = 0x0300
        /// </summary>
        SrcColor = ((int)0x0300)        ,
        /// <summary>
        /// Original was GL_ONE_MINUS_SRC_COLOR = 0x0301
        /// </summary>
        OneMinusSrcColor = ((int)0x0301)        ,
        /// <summary>
        /// Original was GL_SRC_ALPHA = 0x0302
        /// </summary>
        SrcAlpha = ((int)0x0302)        ,
        /// <summary>
        /// Original was GL_ONE_MINUS_SRC_ALPHA = 0x0303
        /// </summary>
        OneMinusSrcAlpha = ((int)0x0303)        ,
        /// <summary>
        /// Original was GL_DST_ALPHA = 0x0304
        /// </summary>
        DstAlpha = ((int)0x0304)        ,
        /// <summary>
        /// Original was GL_ONE_MINUS_DST_ALPHA = 0x0305
        /// </summary>
        OneMinusDstAlpha = ((int)0x0305)        ,
        /// <summary>
        /// Original was GL_DST_COLOR = 0x0306
        /// </summary>
        DstColor = ((int)0x0306)        ,
        /// <summary>
        /// Original was GL_ONE_MINUS_DST_COLOR = 0x0307
        /// </summary>
        OneMinusDstColor = ((int)0x0307)        ,
        /// <summary>
        /// Original was GL_SRC_ALPHA_SATURATE = 0x0308
        /// </summary>
        SrcAlphaSaturate = ((int)0x0308)        ,
        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT2_QCOM = 0x04000000
        /// </summary>
        MultisampleBufferBit2Qcom = ((int)0x04000000)        ,
        /// <summary>
        /// Original was GL_FRONT = 0x0404
        /// </summary>
        Front = ((int)0x0404)        ,
        /// <summary>
        /// Original was GL_BACK = 0x0405
        /// </summary>
        Back = ((int)0x0405)        ,
        /// <summary>
        /// Original was GL_FRONT_AND_BACK = 0x0408
        /// </summary>
        FrontAndBack = ((int)0x0408)        ,
        /// <summary>
        /// Original was GL_INVALID_ENUM = 0x0500
        /// </summary>
        InvalidEnum = ((int)0x0500)        ,
        /// <summary>
        /// Original was GL_INVALID_VALUE = 0x0501
        /// </summary>
        InvalidValue = ((int)0x0501)        ,
        /// <summary>
        /// Original was GL_INVALID_OPERATION = 0x0502
        /// </summary>
        InvalidOperation = ((int)0x0502)        ,
        /// <summary>
        /// Original was GL_OUT_OF_MEMORY = 0x0505
        /// </summary>
        OutOfMemory = ((int)0x0505)        ,
        /// <summary>
        /// Original was GL_INVALID_FRAMEBUFFER_OPERATION = 0x0506
        /// </summary>
        InvalidFramebufferOperation = ((int)0x0506)        ,
        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT3_QCOM = 0x08000000
        /// </summary>
        MultisampleBufferBit3Qcom = ((int)0x08000000)        ,
        /// <summary>
        /// Original was GL_CW = 0x0900
        /// </summary>
        Cw = ((int)0x0900)        ,
        /// <summary>
        /// Original was GL_CCW = 0x0901
        /// </summary>
        Ccw = ((int)0x0901)        ,
        /// <summary>
        /// Original was GL_LINE_WIDTH = 0x0B21
        /// </summary>
        LineWidth = ((int)0x0B21)        ,
        /// <summary>
        /// Original was GL_CULL_FACE = 0x0B44
        /// </summary>
        CullFace = ((int)0x0B44)        ,
        /// <summary>
        /// Original was GL_CULL_FACE_MODE = 0x0B45
        /// </summary>
        CullFaceMode = ((int)0x0B45)        ,
        /// <summary>
        /// Original was GL_FRONT_FACE = 0x0B46
        /// </summary>
        FrontFace = ((int)0x0B46)        ,
        /// <summary>
        /// Original was GL_DEPTH_RANGE = 0x0B70
        /// </summary>
        DepthRange = ((int)0x0B70)        ,
        /// <summary>
        /// Original was GL_DEPTH_TEST = 0x0B71
        /// </summary>
        DepthTest = ((int)0x0B71)        ,
        /// <summary>
        /// Original was GL_DEPTH_WRITEMASK = 0x0B72
        /// </summary>
        DepthWritemask = ((int)0x0B72)        ,
        /// <summary>
        /// Original was GL_DEPTH_CLEAR_VALUE = 0x0B73
        /// </summary>
        DepthClearValue = ((int)0x0B73)        ,
        /// <summary>
        /// Original was GL_DEPTH_FUNC = 0x0B74
        /// </summary>
        DepthFunc = ((int)0x0B74)        ,
        /// <summary>
        /// Original was GL_STENCIL_TEST = 0x0B90
        /// </summary>
        StencilTest = ((int)0x0B90)        ,
        /// <summary>
        /// Original was GL_STENCIL_CLEAR_VALUE = 0x0B91
        /// </summary>
        StencilClearValue = ((int)0x0B91)        ,
        /// <summary>
        /// Original was GL_STENCIL_FUNC = 0x0B92
        /// </summary>
        StencilFunc = ((int)0x0B92)        ,
        /// <summary>
        /// Original was GL_STENCIL_VALUE_MASK = 0x0B93
        /// </summary>
        StencilValueMask = ((int)0x0B93)        ,
        /// <summary>
        /// Original was GL_STENCIL_FAIL = 0x0B94
        /// </summary>
        StencilFail = ((int)0x0B94)        ,
        /// <summary>
        /// Original was GL_STENCIL_PASS_DEPTH_FAIL = 0x0B95
        /// </summary>
        StencilPassDepthFail = ((int)0x0B95)        ,
        /// <summary>
        /// Original was GL_STENCIL_PASS_DEPTH_PASS = 0x0B96
        /// </summary>
        StencilPassDepthPass = ((int)0x0B96)        ,
        /// <summary>
        /// Original was GL_STENCIL_REF = 0x0B97
        /// </summary>
        StencilRef = ((int)0x0B97)        ,
        /// <summary>
        /// Original was GL_STENCIL_WRITEMASK = 0x0B98
        /// </summary>
        StencilWritemask = ((int)0x0B98)        ,
        /// <summary>
        /// Original was GL_VIEWPORT = 0x0BA2
        /// </summary>
        Viewport = ((int)0x0BA2)        ,
        /// <summary>
        /// Original was GL_DITHER = 0x0BD0
        /// </summary>
        Dither = ((int)0x0BD0)        ,
        /// <summary>
        /// Original was GL_BLEND = 0x0BE2
        /// </summary>
        Blend = ((int)0x0BE2)        ,
        /// <summary>
        /// Original was GL_SCISSOR_BOX = 0x0C10
        /// </summary>
        ScissorBox = ((int)0x0C10)        ,
        /// <summary>
        /// Original was GL_SCISSOR_TEST = 0x0C11
        /// </summary>
        ScissorTest = ((int)0x0C11)        ,
        /// <summary>
        /// Original was GL_COLOR_CLEAR_VALUE = 0x0C22
        /// </summary>
        ColorClearValue = ((int)0x0C22)        ,
        /// <summary>
        /// Original was GL_COLOR_WRITEMASK = 0x0C23
        /// </summary>
        ColorWritemask = ((int)0x0C23)        ,
        /// <summary>
        /// Original was GL_UNPACK_ALIGNMENT = 0x0CF5
        /// </summary>
        UnpackAlignment = ((int)0x0CF5)        ,
        /// <summary>
        /// Original was GL_PACK_ALIGNMENT = 0x0D05
        /// </summary>
        PackAlignment = ((int)0x0D05)        ,
        /// <summary>
        /// Original was GL_MAX_TEXTURE_SIZE = 0x0D33
        /// </summary>
        MaxTextureSize = ((int)0x0D33)        ,
        /// <summary>
        /// Original was GL_MAX_VIEWPORT_DIMS = 0x0D3A
        /// </summary>
        MaxViewportDims = ((int)0x0D3A)        ,
        /// <summary>
        /// Original was GL_SUBPIXEL_BITS = 0x0D50
        /// </summary>
        SubpixelBits = ((int)0x0D50)        ,
        /// <summary>
        /// Original was GL_RED_BITS = 0x0D52
        /// </summary>
        RedBits = ((int)0x0D52)        ,
        /// <summary>
        /// Original was GL_GREEN_BITS = 0x0D53
        /// </summary>
        GreenBits = ((int)0x0D53)        ,
        /// <summary>
        /// Original was GL_BLUE_BITS = 0x0D54
        /// </summary>
        BlueBits = ((int)0x0D54)        ,
        /// <summary>
        /// Original was GL_ALPHA_BITS = 0x0D55
        /// </summary>
        AlphaBits = ((int)0x0D55)        ,
        /// <summary>
        /// Original was GL_DEPTH_BITS = 0x0D56
        /// </summary>
        DepthBits = ((int)0x0D56)        ,
        /// <summary>
        /// Original was GL_STENCIL_BITS = 0x0D57
        /// </summary>
        StencilBits = ((int)0x0D57)        ,
        /// <summary>
        /// Original was GL_TEXTURE_2D = 0x0DE1
        /// </summary>
        Texture2D = ((int)0x0DE1)        ,
        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT4_QCOM = 0x10000000
        /// </summary>
        MultisampleBufferBit4Qcom = ((int)0x10000000)        ,
        /// <summary>
        /// Original was GL_DONT_CARE = 0x1100
        /// </summary>
        DontCare = ((int)0x1100)        ,
        /// <summary>
        /// Original was GL_FASTEST = 0x1101
        /// </summary>
        Fastest = ((int)0x1101)        ,
        /// <summary>
        /// Original was GL_NICEST = 0x1102
        /// </summary>
        Nicest = ((int)0x1102)        ,
        /// <summary>
        /// Original was GL_BYTE = 0x1400
        /// </summary>
        Byte = ((int)0x1400)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_BYTE = 0x1401
        /// </summary>
        UnsignedByte = ((int)0x1401)        ,
        /// <summary>
        /// Original was GL_SHORT = 0x1402
        /// </summary>
        Short = ((int)0x1402)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT = 0x1403
        /// </summary>
        UnsignedShort = ((int)0x1403)        ,
        /// <summary>
        /// Original was GL_INT = 0x1404
        /// </summary>
        Int = ((int)0x1404)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_INT = 0x1405
        /// </summary>
        UnsignedInt = ((int)0x1405)        ,
        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = ((int)0x1406)        ,
        /// <summary>
        /// Original was GL_FIXED = 0x140C
        /// </summary>
        Fixed = ((int)0x140C)        ,
        /// <summary>
        /// Original was GL_INVERT = 0x150A
        /// </summary>
        Invert = ((int)0x150A)        ,
        /// <summary>
        /// Original was GL_TEXTURE = 0x1702
        /// </summary>
        Texture = ((int)0x1702)        ,
        /// <summary>
        /// Original was GL_COLOR_EXT = 0x1800
        /// </summary>
        ColorExt = ((int)0x1800)        ,
        /// <summary>
        /// Original was GL_DEPTH_EXT = 0x1801
        /// </summary>
        DepthExt = ((int)0x1801)        ,
        /// <summary>
        /// Original was GL_STENCIL_EXT = 0x1802
        /// </summary>
        StencilExt = ((int)0x1802)        ,
        /// <summary>
        /// Original was GL_STENCIL_INDEX = 0x1901
        /// </summary>
        StencilIndex = ((int)0x1901)        ,
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT = 0x1902
        /// </summary>
        DepthComponent = ((int)0x1902)        ,
        /// <summary>
        /// Original was GL_ALPHA = 0x1906
        /// </summary>
        Alpha = ((int)0x1906)        ,
        /// <summary>
        /// Original was GL_RGB = 0x1907
        /// </summary>
        Rgb = ((int)0x1907)        ,
        /// <summary>
        /// Original was GL_RGBA = 0x1908
        /// </summary>
        Rgba = ((int)0x1908)        ,
        /// <summary>
        /// Original was GL_LUMINANCE = 0x1909
        /// </summary>
        Luminance = ((int)0x1909)        ,
        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA = 0x190A
        /// </summary>
        LuminanceAlpha = ((int)0x190A)        ,
        /// <summary>
        /// Original was GL_KEEP = 0x1E00
        /// </summary>
        Keep = ((int)0x1E00)        ,
        /// <summary>
        /// Original was GL_REPLACE = 0x1E01
        /// </summary>
        Replace = ((int)0x1E01)        ,
        /// <summary>
        /// Original was GL_INCR = 0x1E02
        /// </summary>
        Incr = ((int)0x1E02)        ,
        /// <summary>
        /// Original was GL_DECR = 0x1E03
        /// </summary>
        Decr = ((int)0x1E03)        ,
        /// <summary>
        /// Original was GL_VENDOR = 0x1F00
        /// </summary>
        Vendor = ((int)0x1F00)        ,
        /// <summary>
        /// Original was GL_RENDERER = 0x1F01
        /// </summary>
        Renderer = ((int)0x1F01)        ,
        /// <summary>
        /// Original was GL_VERSION = 0x1F02
        /// </summary>
        Version = ((int)0x1F02)        ,
        /// <summary>
        /// Original was GL_EXTENSIONS = 0x1F03
        /// </summary>
        Extensions = ((int)0x1F03)        ,
        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT5_QCOM = 0x20000000
        /// </summary>
        MultisampleBufferBit5Qcom = ((int)0x20000000)        ,
        /// <summary>
        /// Original was GL_NEAREST = 0x2600
        /// </summary>
        Nearest = ((int)0x2600)        ,
        /// <summary>
        /// Original was GL_LINEAR = 0x2601
        /// </summary>
        Linear = ((int)0x2601)        ,
        /// <summary>
        /// Original was GL_NEAREST_MIPMAP_NEAREST = 0x2700
        /// </summary>
        NearestMipmapNearest = ((int)0x2700)        ,
        /// <summary>
        /// Original was GL_LINEAR_MIPMAP_NEAREST = 0x2701
        /// </summary>
        LinearMipmapNearest = ((int)0x2701)        ,
        /// <summary>
        /// Original was GL_NEAREST_MIPMAP_LINEAR = 0x2702
        /// </summary>
        NearestMipmapLinear = ((int)0x2702)        ,
        /// <summary>
        /// Original was GL_LINEAR_MIPMAP_LINEAR = 0x2703
        /// </summary>
        LinearMipmapLinear = ((int)0x2703)        ,
        /// <summary>
        /// Original was GL_TEXTURE_MAG_FILTER = 0x2800
        /// </summary>
        TextureMagFilter = ((int)0x2800)        ,
        /// <summary>
        /// Original was GL_TEXTURE_MIN_FILTER = 0x2801
        /// </summary>
        TextureMinFilter = ((int)0x2801)        ,
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_S = 0x2802
        /// </summary>
        TextureWrapS = ((int)0x2802)        ,
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_T = 0x2803
        /// </summary>
        TextureWrapT = ((int)0x2803)        ,
        /// <summary>
        /// Original was GL_REPEAT = 0x2901
        /// </summary>
        Repeat = ((int)0x2901)        ,
        /// <summary>
        /// Original was GL_POLYGON_OFFSET_UNITS = 0x2A00
        /// </summary>
        PolygonOffsetUnits = ((int)0x2A00)        ,
        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT6_QCOM = 0x40000000
        /// </summary>
        MultisampleBufferBit6Qcom = ((int)0x40000000)        ,
        /// <summary>
        /// Original was GL_COVERAGE_BUFFER_BIT_NV = 0x8000
        /// </summary>
        CoverageBufferBitNv = ((int)0x8000)        ,
        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT7_QCOM = 0x80000000
        /// </summary>
        MultisampleBufferBit7Qcom = unchecked((int)0x80000000)        ,
        /// <summary>
        /// Original was GL_CONSTANT_COLOR = 0x8001
        /// </summary>
        ConstantColor = ((int)0x8001)        ,
        /// <summary>
        /// Original was GL_ONE_MINUS_CONSTANT_COLOR = 0x8002
        /// </summary>
        OneMinusConstantColor = ((int)0x8002)        ,
        /// <summary>
        /// Original was GL_CONSTANT_ALPHA = 0x8003
        /// </summary>
        ConstantAlpha = ((int)0x8003)        ,
        /// <summary>
        /// Original was GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004
        /// </summary>
        OneMinusConstantAlpha = ((int)0x8004)        ,
        /// <summary>
        /// Original was GL_BLEND_COLOR = 0x8005
        /// </summary>
        BlendColor = ((int)0x8005)        ,
        /// <summary>
        /// Original was GL_FUNC_ADD = 0x8006
        /// </summary>
        FuncAdd = ((int)0x8006)        ,
        /// <summary>
        /// Original was GL_MIN_EXT = 0x8007
        /// </summary>
        MinExt = ((int)0x8007)        ,
        /// <summary>
        /// Original was GL_MAX_EXT = 0x8008
        /// </summary>
        MaxExt = ((int)0x8008)        ,
        /// <summary>
        /// Original was GL_BLEND_EQUATION = 0x8009
        /// </summary>
        BlendEquation = ((int)0x8009)        ,
        /// <summary>
        /// Original was GL_BlendEquationRgb = 0X8009
        /// </summary>
        BlendEquationRgb = ((int)0X8009)        ,
        /// <summary>
        /// Original was GL_FUNC_SUBTRACT = 0x800A
        /// </summary>
        FuncSubtract = ((int)0x800A)        ,
        /// <summary>
        /// Original was GL_FUNC_REVERSE_SUBTRACT = 0x800B
        /// </summary>
        FuncReverseSubtract = ((int)0x800B)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033
        /// </summary>
        UnsignedShort4444 = ((int)0x8033)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034
        /// </summary>
        UnsignedShort5551 = ((int)0x8034)        ,
        /// <summary>
        /// Original was GL_POLYGON_OFFSET_FILL = 0x8037
        /// </summary>
        PolygonOffsetFill = ((int)0x8037)        ,
        /// <summary>
        /// Original was GL_POLYGON_OFFSET_FACTOR = 0x8038
        /// </summary>
        PolygonOffsetFactor = ((int)0x8038)        ,
        /// <summary>
        /// Original was GL_RGB8_OES = 0x8051
        /// </summary>
        Rgb8Oes = ((int)0x8051)        ,
        /// <summary>
        /// Original was GL_RGBA4 = 0x8056
        /// </summary>
        Rgba4 = ((int)0x8056)        ,
        /// <summary>
        /// Original was GL_RGB5_A1 = 0x8057
        /// </summary>
        Rgb5A1 = ((int)0x8057)        ,
        /// <summary>
        /// Original was GL_RGBA8_OES = 0x8058
        /// </summary>
        Rgba8Oes = ((int)0x8058)        ,
        /// <summary>
        /// Original was GL_TEXTURE_BINDING_2D = 0x8069
        /// </summary>
        TextureBinding2D = ((int)0x8069)        ,
        /// <summary>
        /// Original was GL_TEXTURE_BINDING_3D_OES = 0x806A
        /// </summary>
        TextureBinding3DOes = ((int)0x806A)        ,
        /// <summary>
        /// Original was GL_TEXTURE_3D_OES = 0x806F
        /// </summary>
        Texture3DOes = ((int)0x806F)        ,
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_R_OES = 0x8072
        /// </summary>
        TextureWrapROes = ((int)0x8072)        ,
        /// <summary>
        /// Original was GL_MAX_3D_TEXTURE_SIZE_OES = 0x8073
        /// </summary>
        Max3DTextureSizeOes = ((int)0x8073)        ,
        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E
        /// </summary>
        SampleAlphaToCoverage = ((int)0x809E)        ,
        /// <summary>
        /// Original was GL_SAMPLE_COVERAGE = 0x80A0
        /// </summary>
        SampleCoverage = ((int)0x80A0)        ,
        /// <summary>
        /// Original was GL_SAMPLE_BUFFERS = 0x80A8
        /// </summary>
        SampleBuffers = ((int)0x80A8)        ,
        /// <summary>
        /// Original was GL_SAMPLES = 0x80A9
        /// </summary>
        Samples = ((int)0x80A9)        ,
        /// <summary>
        /// Original was GL_SAMPLE_COVERAGE_VALUE = 0x80AA
        /// </summary>
        SampleCoverageValue = ((int)0x80AA)        ,
        /// <summary>
        /// Original was GL_SAMPLE_COVERAGE_INVERT = 0x80AB
        /// </summary>
        SampleCoverageInvert = ((int)0x80AB)        ,
        /// <summary>
        /// Original was GL_BLEND_DST_RGB = 0x80C8
        /// </summary>
        BlendDstRgb = ((int)0x80C8)        ,
        /// <summary>
        /// Original was GL_BLEND_SRC_RGB = 0x80C9
        /// </summary>
        BlendSrcRgb = ((int)0x80C9)        ,
        /// <summary>
        /// Original was GL_BLEND_DST_ALPHA = 0x80CA
        /// </summary>
        BlendDstAlpha = ((int)0x80CA)        ,
        /// <summary>
        /// Original was GL_BLEND_SRC_ALPHA = 0x80CB
        /// </summary>
        BlendSrcAlpha = ((int)0x80CB)        ,
        /// <summary>
        /// Original was GL_BGRA_EXT = 0x80E1
        /// </summary>
        BgraExt = ((int)0x80E1)        ,
        /// <summary>
        /// Original was GL_BGRA_IMG = 0x80E1
        /// </summary>
        BgraImg = ((int)0x80E1)        ,
        /// <summary>
        /// Original was GL_CLAMP_TO_EDGE = 0x812F
        /// </summary>
        ClampToEdge = ((int)0x812F)        ,
        /// <summary>
        /// Original was GL_TEXTURE_MAX_LEVEL_APPLE = 0x813D
        /// </summary>
        TextureMaxLevelApple = ((int)0x813D)        ,
        /// <summary>
        /// Original was GL_GENERATE_MIPMAP_HINT = 0x8192
        /// </summary>
        GenerateMipmapHint = ((int)0x8192)        ,
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16 = 0x81A5
        /// </summary>
        DepthComponent16 = ((int)0x81A5)        ,
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24_OES = 0x81A6
        /// </summary>
        DepthComponent24Oes = ((int)0x81A6)        ,
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32_OES = 0x81A7
        /// </summary>
        DepthComponent32Oes = ((int)0x81A7)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_5_6_5 = 0x8363
        /// </summary>
        UnsignedShort565 = ((int)0x8363)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_4_4_4_4_REV_EXT = 0x8365
        /// </summary>
        UnsignedShort4444RevExt = ((int)0x8365)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_4_4_4_4_REV_IMG = 0x8365
        /// </summary>
        UnsignedShort4444RevImg = ((int)0x8365)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_1_5_5_5_REV_EXT = 0x8366
        /// </summary>
        UnsignedShort1555RevExt = ((int)0x8366)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_INT_2_10_10_10_REV_EXT = 0x8368
        /// </summary>
        UnsignedInt2101010RevExt = ((int)0x8368)        ,
        /// <summary>
        /// Original was GL_MIRRORED_REPEAT = 0x8370
        /// </summary>
        MirroredRepeat = ((int)0x8370)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_S3TC_DXT1_EXT = 0x83F0
        /// </summary>
        CompressedRgbS3tcDxt1Ext = ((int)0x83F0)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_S3TC_DXT1_EXT = 0x83F1
        /// </summary>
        CompressedRgbaS3tcDxt1Ext = ((int)0x83F1)        ,
        /// <summary>
        /// Original was GL_ALIASED_POINT_SIZE_RANGE = 0x846D
        /// </summary>
        AliasedPointSizeRange = ((int)0x846D)        ,
        /// <summary>
        /// Original was GL_ALIASED_LINE_WIDTH_RANGE = 0x846E
        /// </summary>
        AliasedLineWidthRange = ((int)0x846E)        ,
        /// <summary>
        /// Original was GL_TEXTURE0 = 0x84C0
        /// </summary>
        Texture0 = ((int)0x84C0)        ,
        /// <summary>
        /// Original was GL_TEXTURE1 = 0x84C1
        /// </summary>
        Texture1 = ((int)0x84C1)        ,
        /// <summary>
        /// Original was GL_TEXTURE2 = 0x84C2
        /// </summary>
        Texture2 = ((int)0x84C2)        ,
        /// <summary>
        /// Original was GL_TEXTURE3 = 0x84C3
        /// </summary>
        Texture3 = ((int)0x84C3)        ,
        /// <summary>
        /// Original was GL_TEXTURE4 = 0x84C4
        /// </summary>
        Texture4 = ((int)0x84C4)        ,
        /// <summary>
        /// Original was GL_TEXTURE5 = 0x84C5
        /// </summary>
        Texture5 = ((int)0x84C5)        ,
        /// <summary>
        /// Original was GL_TEXTURE6 = 0x84C6
        /// </summary>
        Texture6 = ((int)0x84C6)        ,
        /// <summary>
        /// Original was GL_TEXTURE7 = 0x84C7
        /// </summary>
        Texture7 = ((int)0x84C7)        ,
        /// <summary>
        /// Original was GL_TEXTURE8 = 0x84C8
        /// </summary>
        Texture8 = ((int)0x84C8)        ,
        /// <summary>
        /// Original was GL_TEXTURE9 = 0x84C9
        /// </summary>
        Texture9 = ((int)0x84C9)        ,
        /// <summary>
        /// Original was GL_TEXTURE10 = 0x84CA
        /// </summary>
        Texture10 = ((int)0x84CA)        ,
        /// <summary>
        /// Original was GL_TEXTURE11 = 0x84CB
        /// </summary>
        Texture11 = ((int)0x84CB)        ,
        /// <summary>
        /// Original was GL_TEXTURE12 = 0x84CC
        /// </summary>
        Texture12 = ((int)0x84CC)        ,
        /// <summary>
        /// Original was GL_TEXTURE13 = 0x84CD
        /// </summary>
        Texture13 = ((int)0x84CD)        ,
        /// <summary>
        /// Original was GL_TEXTURE14 = 0x84CE
        /// </summary>
        Texture14 = ((int)0x84CE)        ,
        /// <summary>
        /// Original was GL_TEXTURE15 = 0x84CF
        /// </summary>
        Texture15 = ((int)0x84CF)        ,
        /// <summary>
        /// Original was GL_TEXTURE16 = 0x84D0
        /// </summary>
        Texture16 = ((int)0x84D0)        ,
        /// <summary>
        /// Original was GL_TEXTURE17 = 0x84D1
        /// </summary>
        Texture17 = ((int)0x84D1)        ,
        /// <summary>
        /// Original was GL_TEXTURE18 = 0x84D2
        /// </summary>
        Texture18 = ((int)0x84D2)        ,
        /// <summary>
        /// Original was GL_TEXTURE19 = 0x84D3
        /// </summary>
        Texture19 = ((int)0x84D3)        ,
        /// <summary>
        /// Original was GL_TEXTURE20 = 0x84D4
        /// </summary>
        Texture20 = ((int)0x84D4)        ,
        /// <summary>
        /// Original was GL_TEXTURE21 = 0x84D5
        /// </summary>
        Texture21 = ((int)0x84D5)        ,
        /// <summary>
        /// Original was GL_TEXTURE22 = 0x84D6
        /// </summary>
        Texture22 = ((int)0x84D6)        ,
        /// <summary>
        /// Original was GL_TEXTURE23 = 0x84D7
        /// </summary>
        Texture23 = ((int)0x84D7)        ,
        /// <summary>
        /// Original was GL_TEXTURE24 = 0x84D8
        /// </summary>
        Texture24 = ((int)0x84D8)        ,
        /// <summary>
        /// Original was GL_TEXTURE25 = 0x84D9
        /// </summary>
        Texture25 = ((int)0x84D9)        ,
        /// <summary>
        /// Original was GL_TEXTURE26 = 0x84DA
        /// </summary>
        Texture26 = ((int)0x84DA)        ,
        /// <summary>
        /// Original was GL_TEXTURE27 = 0x84DB
        /// </summary>
        Texture27 = ((int)0x84DB)        ,
        /// <summary>
        /// Original was GL_TEXTURE28 = 0x84DC
        /// </summary>
        Texture28 = ((int)0x84DC)        ,
        /// <summary>
        /// Original was GL_TEXTURE29 = 0x84DD
        /// </summary>
        Texture29 = ((int)0x84DD)        ,
        /// <summary>
        /// Original was GL_TEXTURE30 = 0x84DE
        /// </summary>
        Texture30 = ((int)0x84DE)        ,
        /// <summary>
        /// Original was GL_TEXTURE31 = 0x84DF
        /// </summary>
        Texture31 = ((int)0x84DF)        ,
        /// <summary>
        /// Original was GL_ACTIVE_TEXTURE = 0x84E0
        /// </summary>
        ActiveTexture = ((int)0x84E0)        ,
        /// <summary>
        /// Original was GL_MAX_RENDERBUFFER_SIZE = 0x84E8
        /// </summary>
        MaxRenderbufferSize = ((int)0x84E8)        ,
        /// <summary>
        /// Original was GL_ALL_COMPLETED_NV = 0x84F2
        /// </summary>
        AllCompletedNv = ((int)0x84F2)        ,
        /// <summary>
        /// Original was GL_FENCE_STATUS_NV = 0x84F3
        /// </summary>
        FenceStatusNv = ((int)0x84F3)        ,
        /// <summary>
        /// Original was GL_FENCE_CONDITION_NV = 0x84F4
        /// </summary>
        FenceConditionNv = ((int)0x84F4)        ,
        /// <summary>
        /// Original was GL_DEPTH_STENCIL_OES = 0x84F9
        /// </summary>
        DepthStencilOes = ((int)0x84F9)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_INT_24_8_OES = 0x84FA
        /// </summary>
        UnsignedInt248Oes = ((int)0x84FA)        ,
        /// <summary>
        /// Original was GL_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FE
        /// </summary>
        TextureMaxAnisotropyExt = ((int)0x84FE)        ,
        /// <summary>
        /// Original was GL_MAX_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FF
        /// </summary>
        MaxTextureMaxAnisotropyExt = ((int)0x84FF)        ,
        /// <summary>
        /// Original was GL_INCR_WRAP = 0x8507
        /// </summary>
        IncrWrap = ((int)0x8507)        ,
        /// <summary>
        /// Original was GL_DECR_WRAP = 0x8508
        /// </summary>
        DecrWrap = ((int)0x8508)        ,
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP = 0x8513
        /// </summary>
        TextureCubeMap = ((int)0x8513)        ,
        /// <summary>
        /// Original was GL_TEXTURE_BINDING_CUBE_MAP = 0x8514
        /// </summary>
        TextureBindingCubeMap = ((int)0x8514)        ,
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515
        /// </summary>
        TextureCubeMapPositiveX = ((int)0x8515)        ,
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516
        /// </summary>
        TextureCubeMapNegativeX = ((int)0x8516)        ,
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517
        /// </summary>
        TextureCubeMapPositiveY = ((int)0x8517)        ,
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518
        /// </summary>
        TextureCubeMapNegativeY = ((int)0x8518)        ,
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519
        /// </summary>
        TextureCubeMapPositiveZ = ((int)0x8519)        ,
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A
        /// </summary>
        TextureCubeMapNegativeZ = ((int)0x851A)        ,
        /// <summary>
        /// Original was GL_MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C
        /// </summary>
        MaxCubeMapTextureSize = ((int)0x851C)        ,
        /// <summary>
        /// Original was GL_VERTEX_ARRAY_BINDING_OES = 0x85B5
        /// </summary>
        VertexArrayBindingOes = ((int)0x85B5)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_8_8_APPLE = 0x85BA
        /// </summary>
        UnsignedShort88Apple = ((int)0x85BA)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_8_8_REV_APPLE = 0x85BB
        /// </summary>
        UnsignedShort88RevApple = ((int)0x85BB)        ,
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622
        /// </summary>
        VertexAttribArrayEnabled = ((int)0x8622)        ,
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_SIZE = 0x8623
        /// </summary>
        VertexAttribArraySize = ((int)0x8623)        ,
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624
        /// </summary>
        VertexAttribArrayStride = ((int)0x8624)        ,
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_TYPE = 0x8625
        /// </summary>
        VertexAttribArrayType = ((int)0x8625)        ,
        /// <summary>
        /// Original was GL_CURRENT_VERTEX_ATTRIB = 0x8626
        /// </summary>
        CurrentVertexAttrib = ((int)0x8626)        ,
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_POINTER = 0x8645
        /// </summary>
        VertexAttribArrayPointer = ((int)0x8645)        ,
        /// <summary>
        /// Original was GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2
        /// </summary>
        NumCompressedTextureFormats = ((int)0x86A2)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3
        /// </summary>
        CompressedTextureFormats = ((int)0x86A3)        ,
        /// <summary>
        /// Original was GL_Z400_BINARY_AMD = 0x8740
        /// </summary>
        Z400BinaryAmd = ((int)0x8740)        ,
        /// <summary>
        /// Original was GL_PROGRAM_BINARY_LENGTH_OES = 0x8741
        /// </summary>
        ProgramBinaryLengthOes = ((int)0x8741)        ,
        /// <summary>
        /// Original was GL_BUFFER_SIZE = 0x8764
        /// </summary>
        BufferSize = ((int)0x8764)        ,
        /// <summary>
        /// Original was GL_BUFFER_USAGE = 0x8765
        /// </summary>
        BufferUsage = ((int)0x8765)        ,
        /// <summary>
        /// Original was GL_ATC_RGBA_INTERPOLATED_ALPHA_AMD = 0x87EE
        /// </summary>
        AtcRgbaInterpolatedAlphaAmd = ((int)0x87EE)        ,
        /// <summary>
        /// Original was GL_3DC_X_AMD = 0x87F9
        /// </summary>
        Gl3DcXAmd = ((int)0x87F9)        ,
        /// <summary>
        /// Original was GL_3DC_XY_AMD = 0x87FA
        /// </summary>
        Gl3DcXyAmd = ((int)0x87FA)        ,
        /// <summary>
        /// Original was GL_NUM_PROGRAM_BINARY_FORMATS_OES = 0x87FE
        /// </summary>
        NumProgramBinaryFormatsOes = ((int)0x87FE)        ,
        /// <summary>
        /// Original was GL_PROGRAM_BINARY_FORMATS_OES = 0x87FF
        /// </summary>
        ProgramBinaryFormatsOes = ((int)0x87FF)        ,
        /// <summary>
        /// Original was GL_STENCIL_BACK_FUNC = 0x8800
        /// </summary>
        StencilBackFunc = ((int)0x8800)        ,
        /// <summary>
        /// Original was GL_STENCIL_BACK_FAIL = 0x8801
        /// </summary>
        StencilBackFail = ((int)0x8801)        ,
        /// <summary>
        /// Original was GL_STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802
        /// </summary>
        StencilBackPassDepthFail = ((int)0x8802)        ,
        /// <summary>
        /// Original was GL_STENCIL_BACK_PASS_DEPTH_PASS = 0x8803
        /// </summary>
        StencilBackPassDepthPass = ((int)0x8803)        ,
        /// <summary>
        /// Original was GL_WRITEONLY_RENDERING_QCOM = 0x8823
        /// </summary>
        WriteonlyRenderingQcom = ((int)0x8823)        ,
        /// <summary>
        /// Original was GL_BLEND_EQUATION_ALPHA = 0x883D
        /// </summary>
        BlendEquationAlpha = ((int)0x883D)        ,
        /// <summary>
        /// Original was GL_MAX_VERTEX_ATTRIBS = 0x8869
        /// </summary>
        MaxVertexAttribs = ((int)0x8869)        ,
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A
        /// </summary>
        VertexAttribArrayNormalized = ((int)0x886A)        ,
        /// <summary>
        /// Original was GL_MAX_TEXTURE_IMAGE_UNITS = 0x8872
        /// </summary>
        MaxTextureImageUnits = ((int)0x8872)        ,
        /// <summary>
        /// Original was GL_ARRAY_BUFFER = 0x8892
        /// </summary>
        ArrayBuffer = ((int)0x8892)        ,
        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BUFFER = 0x8893
        /// </summary>
        ElementArrayBuffer = ((int)0x8893)        ,
        /// <summary>
        /// Original was GL_ARRAY_BUFFER_BINDING = 0x8894
        /// </summary>
        ArrayBufferBinding = ((int)0x8894)        ,
        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BUFFER_BINDING = 0x8895
        /// </summary>
        ElementArrayBufferBinding = ((int)0x8895)        ,
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F
        /// </summary>
        VertexAttribArrayBufferBinding = ((int)0x889F)        ,
        /// <summary>
        /// Original was GL_WRITE_ONLY_OES = 0x88B9
        /// </summary>
        WriteOnlyOes = ((int)0x88B9)        ,
        /// <summary>
        /// Original was GL_BUFFER_ACCESS_OES = 0x88BB
        /// </summary>
        BufferAccessOes = ((int)0x88BB)        ,
        /// <summary>
        /// Original was GL_BUFFER_MAPPED_OES = 0x88BC
        /// </summary>
        BufferMappedOes = ((int)0x88BC)        ,
        /// <summary>
        /// Original was GL_BUFFER_MAP_POINTER_OES = 0x88BD
        /// </summary>
        BufferMapPointerOes = ((int)0x88BD)        ,
        /// <summary>
        /// Original was GL_STREAM_DRAW = 0x88E0
        /// </summary>
        StreamDraw = ((int)0x88E0)        ,
        /// <summary>
        /// Original was GL_STATIC_DRAW = 0x88E4
        /// </summary>
        StaticDraw = ((int)0x88E4)        ,
        /// <summary>
        /// Original was GL_DYNAMIC_DRAW = 0x88E8
        /// </summary>
        DynamicDraw = ((int)0x88E8)        ,
        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8_OES = 0x88F0
        /// </summary>
        Depth24Stencil8Oes = ((int)0x88F0)        ,
        /// <summary>
        /// Original was GL_RGB_422_APPLE = 0x8A1F
        /// </summary>
        Rgb422Apple = ((int)0x8A1F)        ,
        /// <summary>
        /// Original was GL_FRAGMENT_SHADER = 0x8B30
        /// </summary>
        FragmentShader = ((int)0x8B30)        ,
        /// <summary>
        /// Original was GL_VERTEX_SHADER = 0x8B31
        /// </summary>
        VertexShader = ((int)0x8B31)        ,
        /// <summary>
        /// Original was GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C
        /// </summary>
        MaxVertexTextureImageUnits = ((int)0x8B4C)        ,
        /// <summary>
        /// Original was GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D
        /// </summary>
        MaxCombinedTextureImageUnits = ((int)0x8B4D)        ,
        /// <summary>
        /// Original was GL_SHADER_TYPE = 0x8B4F
        /// </summary>
        ShaderType = ((int)0x8B4F)        ,
        /// <summary>
        /// Original was GL_FLOAT_VEC2 = 0x8B50
        /// </summary>
        FloatVec2 = ((int)0x8B50)        ,
        /// <summary>
        /// Original was GL_FLOAT_VEC3 = 0x8B51
        /// </summary>
        FloatVec3 = ((int)0x8B51)        ,
        /// <summary>
        /// Original was GL_FLOAT_VEC4 = 0x8B52
        /// </summary>
        FloatVec4 = ((int)0x8B52)        ,
        /// <summary>
        /// Original was GL_INT_VEC2 = 0x8B53
        /// </summary>
        IntVec2 = ((int)0x8B53)        ,
        /// <summary>
        /// Original was GL_INT_VEC3 = 0x8B54
        /// </summary>
        IntVec3 = ((int)0x8B54)        ,
        /// <summary>
        /// Original was GL_INT_VEC4 = 0x8B55
        /// </summary>
        IntVec4 = ((int)0x8B55)        ,
        /// <summary>
        /// Original was GL_BOOL = 0x8B56
        /// </summary>
        Bool = ((int)0x8B56)        ,
        /// <summary>
        /// Original was GL_BOOL_VEC2 = 0x8B57
        /// </summary>
        BoolVec2 = ((int)0x8B57)        ,
        /// <summary>
        /// Original was GL_BOOL_VEC3 = 0x8B58
        /// </summary>
        BoolVec3 = ((int)0x8B58)        ,
        /// <summary>
        /// Original was GL_BOOL_VEC4 = 0x8B59
        /// </summary>
        BoolVec4 = ((int)0x8B59)        ,
        /// <summary>
        /// Original was GL_FLOAT_MAT2 = 0x8B5A
        /// </summary>
        FloatMat2 = ((int)0x8B5A)        ,
        /// <summary>
        /// Original was GL_FLOAT_MAT3 = 0x8B5B
        /// </summary>
        FloatMat3 = ((int)0x8B5B)        ,
        /// <summary>
        /// Original was GL_FLOAT_MAT4 = 0x8B5C
        /// </summary>
        FloatMat4 = ((int)0x8B5C)        ,
        /// <summary>
        /// Original was GL_SAMPLER_2D = 0x8B5E
        /// </summary>
        Sampler2D = ((int)0x8B5E)        ,
        /// <summary>
        /// Original was GL_SAMPLER_3D_OES = 0x8B5F
        /// </summary>
        Sampler3DOes = ((int)0x8B5F)        ,
        /// <summary>
        /// Original was GL_SAMPLER_CUBE = 0x8B60
        /// </summary>
        SamplerCube = ((int)0x8B60)        ,
        /// <summary>
        /// Original was GL_DELETE_STATUS = 0x8B80
        /// </summary>
        DeleteStatus = ((int)0x8B80)        ,
        /// <summary>
        /// Original was GL_COMPILE_STATUS = 0x8B81
        /// </summary>
        CompileStatus = ((int)0x8B81)        ,
        /// <summary>
        /// Original was GL_LINK_STATUS = 0x8B82
        /// </summary>
        LinkStatus = ((int)0x8B82)        ,
        /// <summary>
        /// Original was GL_VALIDATE_STATUS = 0x8B83
        /// </summary>
        ValidateStatus = ((int)0x8B83)        ,
        /// <summary>
        /// Original was GL_INFO_LOG_LENGTH = 0x8B84
        /// </summary>
        InfoLogLength = ((int)0x8B84)        ,
        /// <summary>
        /// Original was GL_ATTACHED_SHADERS = 0x8B85
        /// </summary>
        AttachedShaders = ((int)0x8B85)        ,
        /// <summary>
        /// Original was GL_ACTIVE_UNIFORMS = 0x8B86
        /// </summary>
        ActiveUniforms = ((int)0x8B86)        ,
        /// <summary>
        /// Original was GL_ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87
        /// </summary>
        ActiveUniformMaxLength = ((int)0x8B87)        ,
        /// <summary>
        /// Original was GL_SHADER_SOURCE_LENGTH = 0x8B88
        /// </summary>
        ShaderSourceLength = ((int)0x8B88)        ,
        /// <summary>
        /// Original was GL_ACTIVE_ATTRIBUTES = 0x8B89
        /// </summary>
        ActiveAttributes = ((int)0x8B89)        ,
        /// <summary>
        /// Original was GL_ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A
        /// </summary>
        ActiveAttributeMaxLength = ((int)0x8B8A)        ,
        /// <summary>
        /// Original was GL_FRAGMENT_SHADER_DERIVATIVE_HINT_OES = 0x8B8B
        /// </summary>
        FragmentShaderDerivativeHintOes = ((int)0x8B8B)        ,
        /// <summary>
        /// Original was GL_SHADING_LANGUAGE_VERSION = 0x8B8C
        /// </summary>
        ShadingLanguageVersion = ((int)0x8B8C)        ,
        /// <summary>
        /// Original was GL_CURRENT_PROGRAM = 0x8B8D
        /// </summary>
        CurrentProgram = ((int)0x8B8D)        ,
        /// <summary>
        /// Original was GL_PALETTE4_RGB8_OES = 0x8B90
        /// </summary>
        Palette4Rgb8Oes = ((int)0x8B90)        ,
        /// <summary>
        /// Original was GL_PALETTE4_RGBA8_OES = 0x8B91
        /// </summary>
        Palette4Rgba8Oes = ((int)0x8B91)        ,
        /// <summary>
        /// Original was GL_PALETTE4_R5_G6_B5_OES = 0x8B92
        /// </summary>
        Palette4R5G6B5Oes = ((int)0x8B92)        ,
        /// <summary>
        /// Original was GL_PALETTE4_RGBA4_OES = 0x8B93
        /// </summary>
        Palette4Rgba4Oes = ((int)0x8B93)        ,
        /// <summary>
        /// Original was GL_PALETTE4_RGB5_A1_OES = 0x8B94
        /// </summary>
        Palette4Rgb5A1Oes = ((int)0x8B94)        ,
        /// <summary>
        /// Original was GL_PALETTE8_RGB8_OES = 0x8B95
        /// </summary>
        Palette8Rgb8Oes = ((int)0x8B95)        ,
        /// <summary>
        /// Original was GL_PALETTE8_RGBA8_OES = 0x8B96
        /// </summary>
        Palette8Rgba8Oes = ((int)0x8B96)        ,
        /// <summary>
        /// Original was GL_PALETTE8_R5_G6_B5_OES = 0x8B97
        /// </summary>
        Palette8R5G6B5Oes = ((int)0x8B97)        ,
        /// <summary>
        /// Original was GL_PALETTE8_RGBA4_OES = 0x8B98
        /// </summary>
        Palette8Rgba4Oes = ((int)0x8B98)        ,
        /// <summary>
        /// Original was GL_PALETTE8_RGB5_A1_OES = 0x8B99
        /// </summary>
        Palette8Rgb5A1Oes = ((int)0x8B99)        ,
        /// <summary>
        /// Original was GL_IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A
        /// </summary>
        ImplementationColorReadType = ((int)0x8B9A)        ,
        /// <summary>
        /// Original was GL_IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B
        /// </summary>
        ImplementationColorReadFormat = ((int)0x8B9B)        ,
        /// <summary>
        /// Original was GL_COUNTER_TYPE_AMD = 0x8BC0
        /// </summary>
        CounterTypeAmd = ((int)0x8BC0)        ,
        /// <summary>
        /// Original was GL_COUNTER_RANGE_AMD = 0x8BC1
        /// </summary>
        CounterRangeAmd = ((int)0x8BC1)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_INT64_AMD = 0x8BC2
        /// </summary>
        UnsignedInt64Amd = ((int)0x8BC2)        ,
        /// <summary>
        /// Original was GL_PERCENTAGE_AMD = 0x8BC3
        /// </summary>
        PercentageAmd = ((int)0x8BC3)        ,
        /// <summary>
        /// Original was GL_PERFMON_RESULT_AVAILABLE_AMD = 0x8BC4
        /// </summary>
        PerfmonResultAvailableAmd = ((int)0x8BC4)        ,
        /// <summary>
        /// Original was GL_PERFMON_RESULT_SIZE_AMD = 0x8BC5
        /// </summary>
        PerfmonResultSizeAmd = ((int)0x8BC5)        ,
        /// <summary>
        /// Original was GL_PERFMON_RESULT_AMD = 0x8BC6
        /// </summary>
        PerfmonResultAmd = ((int)0x8BC6)        ,
        /// <summary>
        /// Original was GL_TEXTURE_WIDTH_QCOM = 0x8BD2
        /// </summary>
        TextureWidthQcom = ((int)0x8BD2)        ,
        /// <summary>
        /// Original was GL_TEXTURE_HEIGHT_QCOM = 0x8BD3
        /// </summary>
        TextureHeightQcom = ((int)0x8BD3)        ,
        /// <summary>
        /// Original was GL_TEXTURE_DEPTH_QCOM = 0x8BD4
        /// </summary>
        TextureDepthQcom = ((int)0x8BD4)        ,
        /// <summary>
        /// Original was GL_TEXTURE_INTERNAL_FORMAT_QCOM = 0x8BD5
        /// </summary>
        TextureInternalFormatQcom = ((int)0x8BD5)        ,
        /// <summary>
        /// Original was GL_TEXTURE_FORMAT_QCOM = 0x8BD6
        /// </summary>
        TextureFormatQcom = ((int)0x8BD6)        ,
        /// <summary>
        /// Original was GL_TEXTURE_TYPE_QCOM = 0x8BD7
        /// </summary>
        TextureTypeQcom = ((int)0x8BD7)        ,
        /// <summary>
        /// Original was GL_TEXTURE_IMAGE_VALID_QCOM = 0x8BD8
        /// </summary>
        TextureImageValidQcom = ((int)0x8BD8)        ,
        /// <summary>
        /// Original was GL_TEXTURE_NUM_LEVELS_QCOM = 0x8BD9
        /// </summary>
        TextureNumLevelsQcom = ((int)0x8BD9)        ,
        /// <summary>
        /// Original was GL_TEXTURE_TARGET_QCOM = 0x8BDA
        /// </summary>
        TextureTargetQcom = ((int)0x8BDA)        ,
        /// <summary>
        /// Original was GL_TEXTURE_OBJECT_VALID_QCOM = 0x8BDB
        /// </summary>
        TextureObjectValidQcom = ((int)0x8BDB)        ,
        /// <summary>
        /// Original was GL_STATE_RESTORE = 0x8BDC
        /// </summary>
        StateRestore = ((int)0x8BDC)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_PVRTC_4BPPV1_IMG = 0x8C00
        /// </summary>
        CompressedRgbPvrtc4Bppv1Img = ((int)0x8C00)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_PVRTC_2BPPV1_IMG = 0x8C01
        /// </summary>
        CompressedRgbPvrtc2Bppv1Img = ((int)0x8C01)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_PVRTC_4BPPV1_IMG = 0x8C02
        /// </summary>
        CompressedRgbaPvrtc4Bppv1Img = ((int)0x8C02)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_PVRTC_2BPPV1_IMG = 0x8C03
        /// </summary>
        CompressedRgbaPvrtc2Bppv1Img = ((int)0x8C03)        ,
        /// <summary>
        /// Original was GL_SGX_BINARY_IMG = 0x8C0A
        /// </summary>
        SgxBinaryImg = ((int)0x8C0A)        ,
        /// <summary>
        /// Original was GL_ATC_RGB_AMD = 0x8C92
        /// </summary>
        AtcRgbAmd = ((int)0x8C92)        ,
        /// <summary>
        /// Original was GL_ATC_RGBA_EXPLICIT_ALPHA_AMD = 0x8C93
        /// </summary>
        AtcRgbaExplicitAlphaAmd = ((int)0x8C93)        ,
        /// <summary>
        /// Original was GL_STENCIL_BACK_REF = 0x8CA3
        /// </summary>
        StencilBackRef = ((int)0x8CA3)        ,
        /// <summary>
        /// Original was GL_STENCIL_BACK_VALUE_MASK = 0x8CA4
        /// </summary>
        StencilBackValueMask = ((int)0x8CA4)        ,
        /// <summary>
        /// Original was GL_STENCIL_BACK_WRITEMASK = 0x8CA5
        /// </summary>
        StencilBackWritemask = ((int)0x8CA5)        ,
        /// <summary>
        /// Original was GL_DRAW_FRAMEBUFFER_BINDING_ANGLE = 0x8CA6
        /// </summary>
        DrawFramebufferBindingAngle = ((int)0x8CA6)        ,
        /// <summary>
        /// Original was GL_DRAW_FRAMEBUFFER_BINDING_APPLE = 0x8CA6
        /// </summary>
        DrawFramebufferBindingApple = ((int)0x8CA6)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_BINDING = 0x8CA6
        /// </summary>
        FramebufferBinding = ((int)0x8CA6)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_BINDING = 0x8CA7
        /// </summary>
        RenderbufferBinding = ((int)0x8CA7)        ,
        /// <summary>
        /// Original was GL_READ_FRAMEBUFFER_ANGLE = 0x8CA8
        /// </summary>
        ReadFramebufferAngle = ((int)0x8CA8)        ,
        /// <summary>
        /// Original was GL_READ_FRAMEBUFFER_APPLE = 0x8CA8
        /// </summary>
        ReadFramebufferApple = ((int)0x8CA8)        ,
        /// <summary>
        /// Original was GL_DRAW_FRAMEBUFFER_ANGLE = 0x8CA9
        /// </summary>
        DrawFramebufferAngle = ((int)0x8CA9)        ,
        /// <summary>
        /// Original was GL_DRAW_FRAMEBUFFER_APPLE = 0x8CA9
        /// </summary>
        DrawFramebufferApple = ((int)0x8CA9)        ,
        /// <summary>
        /// Original was GL_READ_FRAMEBUFFER_BINDING_ANGLE = 0x8CAA
        /// </summary>
        ReadFramebufferBindingAngle = ((int)0x8CAA)        ,
        /// <summary>
        /// Original was GL_READ_FRAMEBUFFER_BINDING_APPLE = 0x8CAA
        /// </summary>
        ReadFramebufferBindingApple = ((int)0x8CAA)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_SAMPLES_ANGLE = 0x8CAB
        /// </summary>
        RenderbufferSamplesAngle = ((int)0x8CAB)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_SAMPLES_APPLE = 0x8CAB
        /// </summary>
        RenderbufferSamplesApple = ((int)0x8CAB)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0
        /// </summary>
        FramebufferAttachmentObjectType = ((int)0x8CD0)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1
        /// </summary>
        FramebufferAttachmentObjectName = ((int)0x8CD1)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2
        /// </summary>
        FramebufferAttachmentTextureLevel = ((int)0x8CD2)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3
        /// </summary>
        FramebufferAttachmentTextureCubeMapFace = ((int)0x8CD3)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_OES = 0x8CD4
        /// </summary>
        FramebufferAttachmentTexture3DZoffsetOes = ((int)0x8CD4)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_COMPLETE = 0x8CD5
        /// </summary>
        FramebufferComplete = ((int)0x8CD5)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6
        /// </summary>
        FramebufferIncompleteAttachment = ((int)0x8CD6)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7
        /// </summary>
        FramebufferIncompleteMissingAttachment = ((int)0x8CD7)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS = 0x8CD9
        /// </summary>
        FramebufferIncompleteDimensions = ((int)0x8CD9)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_UNSUPPORTED = 0x8CDD
        /// </summary>
        FramebufferUnsupported = ((int)0x8CDD)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0 = 0x8CE0
        /// </summary>
        ColorAttachment0 = ((int)0x8CE0)        ,
        /// <summary>
        /// Original was GL_DEPTH_ATTACHMENT = 0x8D00
        /// </summary>
        DepthAttachment = ((int)0x8D00)        ,
        /// <summary>
        /// Original was GL_STENCIL_ATTACHMENT = 0x8D20
        /// </summary>
        StencilAttachment = ((int)0x8D20)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER = 0x8D40
        /// </summary>
        Framebuffer = ((int)0x8D40)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER = 0x8D41
        /// </summary>
        Renderbuffer = ((int)0x8D41)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_WIDTH = 0x8D42
        /// </summary>
        RenderbufferWidth = ((int)0x8D42)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_HEIGHT = 0x8D43
        /// </summary>
        RenderbufferHeight = ((int)0x8D43)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_INTERNAL_FORMAT = 0x8D44
        /// </summary>
        RenderbufferInternalFormat = ((int)0x8D44)        ,
        /// <summary>
        /// Original was GL_STENCIL_INDEX1_OES = 0x8D46
        /// </summary>
        StencilIndex1Oes = ((int)0x8D46)        ,
        /// <summary>
        /// Original was GL_STENCIL_INDEX4_OES = 0x8D47
        /// </summary>
        StencilIndex4Oes = ((int)0x8D47)        ,
        /// <summary>
        /// Original was GL_STENCIL_INDEX8 = 0x8D48
        /// </summary>
        StencilIndex8 = ((int)0x8D48)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_RED_SIZE = 0x8D50
        /// </summary>
        RenderbufferRedSize = ((int)0x8D50)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_GREEN_SIZE = 0x8D51
        /// </summary>
        RenderbufferGreenSize = ((int)0x8D51)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_BLUE_SIZE = 0x8D52
        /// </summary>
        RenderbufferBlueSize = ((int)0x8D52)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_ALPHA_SIZE = 0x8D53
        /// </summary>
        RenderbufferAlphaSize = ((int)0x8D53)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_DEPTH_SIZE = 0x8D54
        /// </summary>
        RenderbufferDepthSize = ((int)0x8D54)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_STENCIL_SIZE = 0x8D55
        /// </summary>
        RenderbufferStencilSize = ((int)0x8D55)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_ANGLE = 0x8D56
        /// </summary>
        FramebufferIncompleteMultisampleAngle = ((int)0x8D56)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_APPLE = 0x8D56
        /// </summary>
        FramebufferIncompleteMultisampleApple = ((int)0x8D56)        ,
        /// <summary>
        /// Original was GL_MAX_SAMPLES_ANGLE = 0x8D57
        /// </summary>
        MaxSamplesAngle = ((int)0x8D57)        ,
        /// <summary>
        /// Original was GL_MAX_SAMPLES_APPLE = 0x8D57
        /// </summary>
        MaxSamplesApple = ((int)0x8D57)        ,
        /// <summary>
        /// Original was GL_HALF_FLOAT_OES = 0x8D61
        /// </summary>
        HalfFloatOes = ((int)0x8D61)        ,
        /// <summary>
        /// Original was GL_RGB565 = 0x8D62
        /// </summary>
        Rgb565 = ((int)0x8D62)        ,
        /// <summary>
        /// Original was GL_ETC1_RGB8_OES = 0x8D64
        /// </summary>
        Etc1Rgb8Oes = ((int)0x8D64)        ,
        /// <summary>
        /// Original was GL_LOW_FLOAT = 0x8DF0
        /// </summary>
        LowFloat = ((int)0x8DF0)        ,
        /// <summary>
        /// Original was GL_MEDIUM_FLOAT = 0x8DF1
        /// </summary>
        MediumFloat = ((int)0x8DF1)        ,
        /// <summary>
        /// Original was GL_HIGH_FLOAT = 0x8DF2
        /// </summary>
        HighFloat = ((int)0x8DF2)        ,
        /// <summary>
        /// Original was GL_LOW_INT = 0x8DF3
        /// </summary>
        LowInt = ((int)0x8DF3)        ,
        /// <summary>
        /// Original was GL_MEDIUM_INT = 0x8DF4
        /// </summary>
        MediumInt = ((int)0x8DF4)        ,
        /// <summary>
        /// Original was GL_HIGH_INT = 0x8DF5
        /// </summary>
        HighInt = ((int)0x8DF5)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_INT_10_10_10_2_OES = 0x8DF6
        /// </summary>
        UnsignedInt1010102Oes = ((int)0x8DF6)        ,
        /// <summary>
        /// Original was GL_INT_10_10_10_2_OES = 0x8DF7
        /// </summary>
        Int1010102Oes = ((int)0x8DF7)        ,
        /// <summary>
        /// Original was GL_SHADER_BINARY_FORMATS = 0x8DF8
        /// </summary>
        ShaderBinaryFormats = ((int)0x8DF8)        ,
        /// <summary>
        /// Original was GL_NUM_SHADER_BINARY_FORMATS = 0x8DF9
        /// </summary>
        NumShaderBinaryFormats = ((int)0x8DF9)        ,
        /// <summary>
        /// Original was GL_SHADER_COMPILER = 0x8DFA
        /// </summary>
        ShaderCompiler = ((int)0x8DFA)        ,
        /// <summary>
        /// Original was GL_MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB
        /// </summary>
        MaxVertexUniformVectors = ((int)0x8DFB)        ,
        /// <summary>
        /// Original was GL_MAX_VARYING_VECTORS = 0x8DFC
        /// </summary>
        MaxVaryingVectors = ((int)0x8DFC)        ,
        /// <summary>
        /// Original was GL_MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD
        /// </summary>
        MaxFragmentUniformVectors = ((int)0x8DFD)        ,
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16_NONLINEAR_NV = 0x8E2C
        /// </summary>
        DepthComponent16NonlinearNv = ((int)0x8E2C)        ,
        /// <summary>
        /// Original was GL_COVERAGE_COMPONENT_NV = 0x8ED0
        /// </summary>
        CoverageComponentNv = ((int)0x8ED0)        ,
        /// <summary>
        /// Original was GL_COVERAGE_COMPONENT4_NV = 0x8ED1
        /// </summary>
        CoverageComponent4Nv = ((int)0x8ED1)        ,
        /// <summary>
        /// Original was GL_COVERAGE_ATTACHMENT_NV = 0x8ED2
        /// </summary>
        CoverageAttachmentNv = ((int)0x8ED2)        ,
        /// <summary>
        /// Original was GL_COVERAGE_BUFFERS_NV = 0x8ED3
        /// </summary>
        CoverageBuffersNv = ((int)0x8ED3)        ,
        /// <summary>
        /// Original was GL_COVERAGE_SAMPLES_NV = 0x8ED4
        /// </summary>
        CoverageSamplesNv = ((int)0x8ED4)        ,
        /// <summary>
        /// Original was GL_COVERAGE_ALL_FRAGMENTS_NV = 0x8ED5
        /// </summary>
        CoverageAllFragmentsNv = ((int)0x8ED5)        ,
        /// <summary>
        /// Original was GL_COVERAGE_EDGE_FRAGMENTS_NV = 0x8ED6
        /// </summary>
        CoverageEdgeFragmentsNv = ((int)0x8ED6)        ,
        /// <summary>
        /// Original was GL_COVERAGE_AUTOMATIC_NV = 0x8ED7
        /// </summary>
        CoverageAutomaticNv = ((int)0x8ED7)        ,
        /// <summary>
        /// Original was GL_MALI_SHADER_BINARY_ARM = 0x8F60
        /// </summary>
        MaliShaderBinaryArm = ((int)0x8F60)        ,
        /// <summary>
        /// Original was GL_PERFMON_GLOBAL_MODE_QCOM = 0x8FA0
        /// </summary>
        PerfmonGlobalModeQcom = ((int)0x8FA0)        ,
        /// <summary>
        /// Original was GL_SHADER_BINARY_VIV = 0x8FC4
        /// </summary>
        ShaderBinaryViv = ((int)0x8FC4)        ,
        /// <summary>
        /// Original was GL_SGX_PROGRAM_BINARY_IMG = 0x9130
        /// </summary>
        SgxProgramBinaryImg = ((int)0x9130)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_SAMPLES_IMG = 0x9133
        /// </summary>
        RenderbufferSamplesImg = ((int)0x9133)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_IMG = 0x9134
        /// </summary>
        FramebufferIncompleteMultisampleImg = ((int)0x9134)        ,
        /// <summary>
        /// Original was GL_MAX_SAMPLES_IMG = 0x9135
        /// </summary>
        MaxSamplesImg = ((int)0x9135)        ,
        /// <summary>
        /// Original was GL_TEXTURE_SAMPLES_IMG = 0x9136
        /// </summary>
        TextureSamplesImg = ((int)0x9136)        ,
        /// <summary>
        /// Original was GL_AMD_compressed_3DC_texture = 1
        /// </summary>
        AmdCompressed3DcTexture = ((int)1)        ,
        /// <summary>
        /// Original was GL_AMD_compressed_ATC_texture = 1
        /// </summary>
        AmdCompressedAtcTexture = ((int)1)        ,
        /// <summary>
        /// Original was GL_AMD_performance_monitor = 1
        /// </summary>
        AmdPerformanceMonitor = ((int)1)        ,
        /// <summary>
        /// Original was GL_AMD_program_binary_Z400 = 1
        /// </summary>
        AmdProgramBinaryZ400 = ((int)1)        ,
        /// <summary>
        /// Original was GL_ANGLE_framebuffer_blit = 1
        /// </summary>
        AngleFramebufferBlit = ((int)1)        ,
        /// <summary>
        /// Original was GL_ANGLE_framebuffer_multisample = 1
        /// </summary>
        AngleFramebufferMultisample = ((int)1)        ,
        /// <summary>
        /// Original was GL_APPLE_framebuffer_multisample = 1
        /// </summary>
        AppleFramebufferMultisample = ((int)1)        ,
        /// <summary>
        /// Original was GL_APPLE_rgb_422 = 1
        /// </summary>
        AppleRgb422 = ((int)1)        ,
        /// <summary>
        /// Original was GL_APPLE_texture_format_BGRA8888 = 1
        /// </summary>
        AppleTextureFormatBgra8888 = ((int)1)        ,
        /// <summary>
        /// Original was GL_APPLE_texture_max_level = 1
        /// </summary>
        AppleTextureMaxLevel = ((int)1)        ,
        /// <summary>
        /// Original was GL_ARM_mali_shader_binary = 1
        /// </summary>
        ArmMaliShaderBinary = ((int)1)        ,
        /// <summary>
        /// Original was GL_ARM_rgba8 = 1
        /// </summary>
        ArmRgba8 = ((int)1)        ,
        /// <summary>
        /// Original was GL_ES_VERSION_2_0 = 1
        /// </summary>
        EsVersion20 = ((int)1)        ,
        /// <summary>
        /// Original was GL_EXT_blend_minmax = 1
        /// </summary>
        ExtBlendMinmax = ((int)1)        ,
        /// <summary>
        /// Original was GL_EXT_discard_framebuffer = 1
        /// </summary>
        ExtDiscardFramebuffer = ((int)1)        ,
        /// <summary>
        /// Original was GL_EXT_multi_draw_arrays = 1
        /// </summary>
        ExtMultiDrawArrays = ((int)1)        ,
        /// <summary>
        /// Original was GL_EXT_read_format_bgra = 1
        /// </summary>
        ExtReadFormatBgra = ((int)1)        ,
        /// <summary>
        /// Original was GL_EXT_shader_texture_lod = 1
        /// </summary>
        ExtShaderTextureLod = ((int)1)        ,
        /// <summary>
        /// Original was GL_EXT_texture_compression_dxt1 = 1
        /// </summary>
        ExtTextureCompressionDxt1 = ((int)1)        ,
        /// <summary>
        /// Original was GL_EXT_texture_filter_anisotropic = 1
        /// </summary>
        ExtTextureFilterAnisotropic = ((int)1)        ,
        /// <summary>
        /// Original was GL_EXT_texture_format_BGRA8888 = 1
        /// </summary>
        ExtTextureFormatBgra8888 = ((int)1)        ,
        /// <summary>
        /// Original was GL_EXT_texture_type_2_10_10_10_REV = 1
        /// </summary>
        ExtTextureType2101010Rev = ((int)1)        ,
        /// <summary>
        /// Original was GL_IMG_multisampled_render_to_texture = 1
        /// </summary>
        ImgMultisampledRenderToTexture = ((int)1)        ,
        /// <summary>
        /// Original was GL_IMG_program_binary = 1
        /// </summary>
        ImgProgramBinary = ((int)1)        ,
        /// <summary>
        /// Original was GL_IMG_read_format = 1
        /// </summary>
        ImgReadFormat = ((int)1)        ,
        /// <summary>
        /// Original was GL_IMG_shader_binary = 1
        /// </summary>
        ImgShaderBinary = ((int)1)        ,
        /// <summary>
        /// Original was GL_IMG_texture_compression_pvrtc = 1
        /// </summary>
        ImgTextureCompressionPvrtc = ((int)1)        ,
        /// <summary>
        /// Original was GL_NV_coverage_sample = 1
        /// </summary>
        NvCoverageSample = ((int)1)        ,
        /// <summary>
        /// Original was GL_NV_depth_nonlinear = 1
        /// </summary>
        NvDepthNonlinear = ((int)1)        ,
        /// <summary>
        /// Original was GL_NV_fence = 1
        /// </summary>
        NvFence = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_compressed_ETC1_RGB8_texture = 1
        /// </summary>
        OesCompressedEtc1Rgb8Texture = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_compressed_paletted_texture = 1
        /// </summary>
        OesCompressedPalettedTexture = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_depth24 = 1
        /// </summary>
        OesDepth24 = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_depth32 = 1
        /// </summary>
        OesDepth32 = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_depth_texture = 1
        /// </summary>
        OesDepthTexture = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_EGL_image = 1
        /// </summary>
        OesEglImage = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_element_index_uint = 1
        /// </summary>
        OesElementIndexUint = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_fbo_render_mipmap = 1
        /// </summary>
        OesFboRenderMipmap = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_fragment_precision_high = 1
        /// </summary>
        OesFragmentPrecisionHigh = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_get_program_binary = 1
        /// </summary>
        OesGetProgramBinary = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_mapbuffer = 1
        /// </summary>
        OesMapbuffer = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_packed_depth_stencil = 1
        /// </summary>
        OesPackedDepthStencil = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_rgb8_rgba8 = 1
        /// </summary>
        OesRgb8Rgba8 = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_standard_derivatives = 1
        /// </summary>
        OesStandardDerivatives = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_stencil1 = 1
        /// </summary>
        OesStencil1 = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_stencil4 = 1
        /// </summary>
        OesStencil4 = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_texture_3D = 1
        /// </summary>
        OesTexture3D = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_texture_float = 1
        /// </summary>
        OesTextureFloat = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_texture_float_linear = 1
        /// </summary>
        OesTextureFloatLinear = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_texture_half_float = 1
        /// </summary>
        OesTextureHalfFloat = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_texture_half_float_linear = 1
        /// </summary>
        OesTextureHalfFloatLinear = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_texture_npot = 1
        /// </summary>
        OesTextureNpot = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_vertex_array_object = 1
        /// </summary>
        OesVertexArrayObject = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_vertex_half_float = 1
        /// </summary>
        OesVertexHalfFloat = ((int)1)        ,
        /// <summary>
        /// Original was GL_OES_vertex_type_10_10_10_2 = 1
        /// </summary>
        OesVertexType1010102 = ((int)1)        ,
        /// <summary>
        /// Original was GL_ONE = 1
        /// </summary>
        One = ((int)1)        ,
        /// <summary>
        /// Original was GL_QCOM_driver_control = 1
        /// </summary>
        QcomDriverControl = ((int)1)        ,
        /// <summary>
        /// Original was GL_QCOM_extended_get = 1
        /// </summary>
        QcomExtendedGet = ((int)1)        ,
        /// <summary>
        /// Original was GL_QCOM_extended_get2 = 1
        /// </summary>
        QcomExtendedGet2 = ((int)1)        ,
        /// <summary>
        /// Original was GL_QCOM_perfmon_global_mode = 1
        /// </summary>
        QcomPerfmonGlobalMode = ((int)1)        ,
        /// <summary>
        /// Original was GL_QCOM_tiled_rendering = 1
        /// </summary>
        QcomTiledRendering = ((int)1)        ,
        /// <summary>
        /// Original was GL_QCOM_writeonly_rendering = 1
        /// </summary>
        QcomWriteonlyRendering = ((int)1)        ,
        /// <summary>
        /// Original was GL_TRUE = 1
        /// </summary>
        True = ((int)1)        ,
        /// <summary>
        /// Original was GL_VIV_shader_binary = 1
        /// </summary>
        VivShaderBinary = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AmdCompressed3Dctexture : int
    {
        /// <summary>
        /// Original was GL_3DC_X_AMD = 0x87F9
        /// </summary>
        Gl3DcXAmd = ((int)0x87F9)        ,
        /// <summary>
        /// Original was GL_3DC_XY_AMD = 0x87FA
        /// </summary>
        Gl3DcXyAmd = ((int)0x87FA)        ,
        /// <summary>
        /// Original was GL_AMD_compressed_3DC_texture = 1
        /// </summary>
        AmdCompressed3DcTexture = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AmdCompressedAtctexture : int
    {
        /// <summary>
        /// Original was GL_ATC_RGBA_INTERPOLATED_ALPHA_AMD = 0x87EE
        /// </summary>
        AtcRgbaInterpolatedAlphaAmd = ((int)0x87EE)        ,
        /// <summary>
        /// Original was GL_ATC_RGB_AMD = 0x8C92
        /// </summary>
        AtcRgbAmd = ((int)0x8C92)        ,
        /// <summary>
        /// Original was GL_ATC_RGBA_EXPLICIT_ALPHA_AMD = 0x8C93
        /// </summary>
        AtcRgbaExplicitAlphaAmd = ((int)0x8C93)        ,
        /// <summary>
        /// Original was GL_AMD_compressed_ATC_texture = 1
        /// </summary>
        AmdCompressedAtcTexture = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AmdPerformanceMonitor : int
    {
        /// <summary>
        /// Original was GL_COUNTER_TYPE_AMD = 0x8BC0
        /// </summary>
        CounterTypeAmd = ((int)0x8BC0)        ,
        /// <summary>
        /// Original was GL_COUNTER_RANGE_AMD = 0x8BC1
        /// </summary>
        CounterRangeAmd = ((int)0x8BC1)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_INT64_AMD = 0x8BC2
        /// </summary>
        UnsignedInt64Amd = ((int)0x8BC2)        ,
        /// <summary>
        /// Original was GL_PERCENTAGE_AMD = 0x8BC3
        /// </summary>
        PercentageAmd = ((int)0x8BC3)        ,
        /// <summary>
        /// Original was GL_PERFMON_RESULT_AVAILABLE_AMD = 0x8BC4
        /// </summary>
        PerfmonResultAvailableAmd = ((int)0x8BC4)        ,
        /// <summary>
        /// Original was GL_PERFMON_RESULT_SIZE_AMD = 0x8BC5
        /// </summary>
        PerfmonResultSizeAmd = ((int)0x8BC5)        ,
        /// <summary>
        /// Original was GL_PERFMON_RESULT_AMD = 0x8BC6
        /// </summary>
        PerfmonResultAmd = ((int)0x8BC6)        ,
        /// <summary>
        /// Original was GL_AMD_performance_monitor = 1
        /// </summary>
        AmdPerformanceMonitor = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AmdProgramBinaryZ400 : int
    {
        /// <summary>
        /// Original was GL_Z400_BINARY_AMD = 0x8740
        /// </summary>
        Z400BinaryAmd = ((int)0x8740)        ,
        /// <summary>
        /// Original was GL_AMD_program_binary_Z400 = 1
        /// </summary>
        AmdProgramBinaryZ400 = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AngleFramebufferBlit : int
    {
        /// <summary>
        /// Original was GL_DRAW_FRAMEBUFFER_BINDING_ANGLE = 0x8CA6
        /// </summary>
        DrawFramebufferBindingAngle = ((int)0x8CA6)        ,
        /// <summary>
        /// Original was GL_READ_FRAMEBUFFER_ANGLE = 0x8CA8
        /// </summary>
        ReadFramebufferAngle = ((int)0x8CA8)        ,
        /// <summary>
        /// Original was GL_DRAW_FRAMEBUFFER_ANGLE = 0x8CA9
        /// </summary>
        DrawFramebufferAngle = ((int)0x8CA9)        ,
        /// <summary>
        /// Original was GL_READ_FRAMEBUFFER_BINDING_ANGLE = 0x8CAA
        /// </summary>
        ReadFramebufferBindingAngle = ((int)0x8CAA)        ,
        /// <summary>
        /// Original was GL_ANGLE_framebuffer_blit = 1
        /// </summary>
        AngleFramebufferBlit = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AngleFramebufferMultisample : int
    {
        /// <summary>
        /// Original was GL_RENDERBUFFER_SAMPLES_ANGLE = 0x8CAB
        /// </summary>
        RenderbufferSamplesAngle = ((int)0x8CAB)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_ANGLE = 0x8D56
        /// </summary>
        FramebufferIncompleteMultisampleAngle = ((int)0x8D56)        ,
        /// <summary>
        /// Original was GL_MAX_SAMPLES_ANGLE = 0x8D57
        /// </summary>
        MaxSamplesAngle = ((int)0x8D57)        ,
        /// <summary>
        /// Original was GL_ANGLE_framebuffer_multisample = 1
        /// </summary>
        AngleFramebufferMultisample = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AppleFramebufferMultisample : int
    {
        /// <summary>
        /// Original was GL_DRAW_FRAMEBUFFER_BINDING_APPLE = 0x8CA6
        /// </summary>
        DrawFramebufferBindingApple = ((int)0x8CA6)        ,
        /// <summary>
        /// Original was GL_READ_FRAMEBUFFER_APPLE = 0x8CA8
        /// </summary>
        ReadFramebufferApple = ((int)0x8CA8)        ,
        /// <summary>
        /// Original was GL_DRAW_FRAMEBUFFER_APPLE = 0x8CA9
        /// </summary>
        DrawFramebufferApple = ((int)0x8CA9)        ,
        /// <summary>
        /// Original was GL_READ_FRAMEBUFFER_BINDING_APPLE = 0x8CAA
        /// </summary>
        ReadFramebufferBindingApple = ((int)0x8CAA)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_SAMPLES_APPLE = 0x8CAB
        /// </summary>
        RenderbufferSamplesApple = ((int)0x8CAB)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_APPLE = 0x8D56
        /// </summary>
        FramebufferIncompleteMultisampleApple = ((int)0x8D56)        ,
        /// <summary>
        /// Original was GL_MAX_SAMPLES_APPLE = 0x8D57
        /// </summary>
        MaxSamplesApple = ((int)0x8D57)        ,
        /// <summary>
        /// Original was GL_APPLE_framebuffer_multisample = 1
        /// </summary>
        AppleFramebufferMultisample = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AppleRgb422 : int
    {
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_8_8_APPLE = 0x85BA
        /// </summary>
        UnsignedShort88Apple = ((int)0x85BA)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_8_8_REV_APPLE = 0x85BB
        /// </summary>
        UnsignedShort88RevApple = ((int)0x85BB)        ,
        /// <summary>
        /// Original was GL_RGB_422_APPLE = 0x8A1F
        /// </summary>
        Rgb422Apple = ((int)0x8A1F)        ,
        /// <summary>
        /// Original was GL_APPLE_rgb_422 = 1
        /// </summary>
        AppleRgb422 = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AppleTextureFormatBgra8888 : int
    {
        /// <summary>
        /// Original was GL_BGRA_EXT = 0x80E1
        /// </summary>
        BgraExt = ((int)0x80E1)        ,
        /// <summary>
        /// Original was GL_APPLE_texture_format_BGRA8888 = 1
        /// </summary>
        AppleTextureFormatBgra8888 = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AppleTextureMaxLevel : int
    {
        /// <summary>
        /// Original was GL_TEXTURE_MAX_LEVEL_APPLE = 0x813D
        /// </summary>
        TextureMaxLevelApple = ((int)0x813D)        ,
        /// <summary>
        /// Original was GL_APPLE_texture_max_level = 1
        /// </summary>
        AppleTextureMaxLevel = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArmMaliShaderBinary : int
    {
        /// <summary>
        /// Original was GL_MALI_SHADER_BINARY_ARM = 0x8F60
        /// </summary>
        MaliShaderBinaryArm = ((int)0x8F60)        ,
        /// <summary>
        /// Original was GL_ARM_mali_shader_binary = 1
        /// </summary>
        ArmMaliShaderBinary = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ArmRgba8 : int
    {
        /// <summary>
        /// Original was GL_ARM_rgba8 = 1
        /// </summary>
        ArmRgba8 = ((int)1)        ,
    }

    /// <summary>
    /// Used in GL.DrawArrays, GL.DrawElements
    /// </summary>
    public enum BeginMode : int
    {
        /// <summary>
        /// Original was GL_POINTS = 0x0000
        /// </summary>
        Points = ((int)0x0000)        ,
        /// <summary>
        /// Original was GL_LINES = 0x0001
        /// </summary>
        Lines = ((int)0x0001)        ,
        /// <summary>
        /// Original was GL_LINE_LOOP = 0x0002
        /// </summary>
        LineLoop = ((int)0x0002)        ,
        /// <summary>
        /// Original was GL_LINE_STRIP = 0x0003
        /// </summary>
        LineStrip = ((int)0x0003)        ,
        /// <summary>
        /// Original was GL_TRIANGLES = 0x0004
        /// </summary>
        Triangles = ((int)0x0004)        ,
        /// <summary>
        /// Original was GL_TRIANGLE_STRIP = 0x0005
        /// </summary>
        TriangleStrip = ((int)0x0005)        ,
        /// <summary>
        /// Original was GL_TRIANGLE_FAN = 0x0006
        /// </summary>
        TriangleFan = ((int)0x0006)        ,
    }

    /// <summary>
    /// Used in GL.BlendEquation, GL.BlendEquationSeparate
    /// </summary>
    public enum BlendEquationMode : int
    {
        /// <summary>
        /// Original was GL_FuncAdd = 0X8006
        /// </summary>
        FuncAdd = ((int)0X8006)        ,
        /// <summary>
        /// Original was GL_FuncSubtract = 0X800a
        /// </summary>
        FuncSubtract = ((int)0X800a)        ,
        /// <summary>
        /// Original was GL_FuncReverseSubtract = 0X800b
        /// </summary>
        FuncReverseSubtract = ((int)0X800b)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum BlendEquationSeparate : int
    {
        /// <summary>
        /// Original was GL_FUNC_ADD = 0x8006
        /// </summary>
        FuncAdd = ((int)0x8006)        ,
        /// <summary>
        /// Original was GL_BLEND_EQUATION = 0x8009
        /// </summary>
        BlendEquation = ((int)0x8009)        ,
        /// <summary>
        /// Original was GL_BLEND_EQUATION_ALPHA = 0x883D
        /// </summary>
        BlendEquationAlpha = ((int)0x883D)        ,
    }

    /// <summary>
    /// Used in GL.BlendFunc, GL.BlendFuncSeparate
    /// </summary>
    public enum BlendingFactorDest : int
    {
        /// <summary>
        /// Original was GL_ZERO = 0
        /// </summary>
        Zero = ((int)0)        ,
        /// <summary>
        /// Original was GL_SRC_COLOR = 0x0300
        /// </summary>
        SrcColor = ((int)0x0300)        ,
        /// <summary>
        /// Original was GL_ONE_MINUS_SRC_COLOR = 0x0301
        /// </summary>
        OneMinusSrcColor = ((int)0x0301)        ,
        /// <summary>
        /// Original was GL_SRC_ALPHA = 0x0302
        /// </summary>
        SrcAlpha = ((int)0x0302)        ,
        /// <summary>
        /// Original was GL_ONE_MINUS_SRC_ALPHA = 0x0303
        /// </summary>
        OneMinusSrcAlpha = ((int)0x0303)        ,
        /// <summary>
        /// Original was GL_DST_ALPHA = 0x0304
        /// </summary>
        DstAlpha = ((int)0x0304)        ,
        /// <summary>
        /// Original was GL_ONE_MINUS_DST_ALPHA = 0x0305
        /// </summary>
        OneMinusDstAlpha = ((int)0x0305)        ,
        /// <summary>
        /// Original was GL_DstColor = 0X0306
        /// </summary>
        DstColor = ((int)0X0306)        ,
        /// <summary>
        /// Original was GL_OneMinusDstColor = 0X0307
        /// </summary>
        OneMinusDstColor = ((int)0X0307)        ,
        /// <summary>
        /// Original was GL_SrcAlphaSaturate = 0X0308
        /// </summary>
        SrcAlphaSaturate = ((int)0X0308)        ,
        /// <summary>
        /// Original was GL_ConstantColor = 0X8001
        /// </summary>
        ConstantColor = ((int)0X8001)        ,
        /// <summary>
        /// Original was GL_OneMinusConstantColor = 0X8002
        /// </summary>
        OneMinusConstantColor = ((int)0X8002)        ,
        /// <summary>
        /// Original was GL_ConstantAlpha = 0X8003
        /// </summary>
        ConstantAlpha = ((int)0X8003)        ,
        /// <summary>
        /// Original was GL_OneMinusConstantAlpha = 0X8004
        /// </summary>
        OneMinusConstantAlpha = ((int)0X8004)        ,
        /// <summary>
        /// Original was GL_ONE = 1
        /// </summary>
        One = ((int)1)        ,
    }

    /// <summary>
    /// Used in GL.BlendFunc, GL.BlendFuncSeparate
    /// </summary>
    public enum BlendingFactorSrc : int
    {
        /// <summary>
        /// Original was GL_Zero = 0
        /// </summary>
        Zero = ((int)0)        ,
        /// <summary>
        /// Original was GL_SrcColor = 0X0300
        /// </summary>
        SrcColor = ((int)0X0300)        ,
        /// <summary>
        /// Original was GL_OneMinusSrcColor = 0X0301
        /// </summary>
        OneMinusSrcColor = ((int)0X0301)        ,
        /// <summary>
        /// Original was GL_SrcAlpha = 0X0302
        /// </summary>
        SrcAlpha = ((int)0X0302)        ,
        /// <summary>
        /// Original was GL_OneMinusSrcAlpha = 0X0303
        /// </summary>
        OneMinusSrcAlpha = ((int)0X0303)        ,
        /// <summary>
        /// Original was GL_DstAlpha = 0X0304
        /// </summary>
        DstAlpha = ((int)0X0304)        ,
        /// <summary>
        /// Original was GL_OneMinusDstAlpha = 0X0305
        /// </summary>
        OneMinusDstAlpha = ((int)0X0305)        ,
        /// <summary>
        /// Original was GL_DST_COLOR = 0x0306
        /// </summary>
        DstColor = ((int)0x0306)        ,
        /// <summary>
        /// Original was GL_ONE_MINUS_DST_COLOR = 0x0307
        /// </summary>
        OneMinusDstColor = ((int)0x0307)        ,
        /// <summary>
        /// Original was GL_SRC_ALPHA_SATURATE = 0x0308
        /// </summary>
        SrcAlphaSaturate = ((int)0x0308)        ,
        /// <summary>
        /// Original was GL_ConstantColor = 0X8001
        /// </summary>
        ConstantColor = ((int)0X8001)        ,
        /// <summary>
        /// Original was GL_OneMinusConstantColor = 0X8002
        /// </summary>
        OneMinusConstantColor = ((int)0X8002)        ,
        /// <summary>
        /// Original was GL_ConstantAlpha = 0X8003
        /// </summary>
        ConstantAlpha = ((int)0X8003)        ,
        /// <summary>
        /// Original was GL_OneMinusConstantAlpha = 0X8004
        /// </summary>
        OneMinusConstantAlpha = ((int)0X8004)        ,
        /// <summary>
        /// Original was GL_One = 1
        /// </summary>
        One = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum BlendSubtract : int
    {
        /// <summary>
        /// Original was GL_FUNC_SUBTRACT = 0x800A
        /// </summary>
        FuncSubtract = ((int)0x800A)        ,
        /// <summary>
        /// Original was GL_FUNC_REVERSE_SUBTRACT = 0x800B
        /// </summary>
        FuncReverseSubtract = ((int)0x800B)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Boolean : int
    {
        /// <summary>
        /// Original was GL_FALSE = 0
        /// </summary>
        False = ((int)0)        ,
        /// <summary>
        /// Original was GL_TRUE = 1
        /// </summary>
        True = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum BufferObjects : int
    {
        /// <summary>
        /// Original was GL_CURRENT_VERTEX_ATTRIB = 0x8626
        /// </summary>
        CurrentVertexAttrib = ((int)0x8626)        ,
        /// <summary>
        /// Original was GL_BUFFER_SIZE = 0x8764
        /// </summary>
        BufferSize = ((int)0x8764)        ,
        /// <summary>
        /// Original was GL_BUFFER_USAGE = 0x8765
        /// </summary>
        BufferUsage = ((int)0x8765)        ,
        /// <summary>
        /// Original was GL_ARRAY_BUFFER = 0x8892
        /// </summary>
        ArrayBuffer = ((int)0x8892)        ,
        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BUFFER = 0x8893
        /// </summary>
        ElementArrayBuffer = ((int)0x8893)        ,
        /// <summary>
        /// Original was GL_ARRAY_BUFFER_BINDING = 0x8894
        /// </summary>
        ArrayBufferBinding = ((int)0x8894)        ,
        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BUFFER_BINDING = 0x8895
        /// </summary>
        ElementArrayBufferBinding = ((int)0x8895)        ,
        /// <summary>
        /// Original was GL_STREAM_DRAW = 0x88E0
        /// </summary>
        StreamDraw = ((int)0x88E0)        ,
        /// <summary>
        /// Original was GL_STATIC_DRAW = 0x88E4
        /// </summary>
        StaticDraw = ((int)0x88E4)        ,
        /// <summary>
        /// Original was GL_DYNAMIC_DRAW = 0x88E8
        /// </summary>
        DynamicDraw = ((int)0x88E8)        ,
    }

    /// <summary>
    /// Used in GL.GetBufferParameter
    /// </summary>
    public enum BufferParameterName : int
    {
        /// <summary>
        /// Original was GL_BufferSize = 0X8764
        /// </summary>
        BufferSize = ((int)0X8764)        ,
        /// <summary>
        /// Original was GL_BufferUsage = 0X8765
        /// </summary>
        BufferUsage = ((int)0X8765)        ,
    }

    /// <summary>
    /// Used in GL.BindBuffer, GL.BufferData, GL.BufferSubData, GL.GetBufferParameter
    /// </summary>
    public enum BufferTarget : int
    {
        /// <summary>
        /// Original was GL_ArrayBuffer = 0X8892
        /// </summary>
        ArrayBuffer = ((int)0X8892)        ,
        /// <summary>
        /// Original was GL_ElementArrayBuffer = 0X8893
        /// </summary>
        ElementArrayBuffer = ((int)0X8893)        ,
    }

    /// <summary>
    /// Used in GL.BufferData
    /// </summary>
    public enum BufferUsage : int
    {
        /// <summary>
        /// Original was GL_StreamDraw = 0X88e0
        /// </summary>
        StreamDraw = ((int)0X88e0)        ,
        /// <summary>
        /// Original was GL_StaticDraw = 0X88e4
        /// </summary>
        StaticDraw = ((int)0X88e4)        ,
        /// <summary>
        /// Original was GL_DynamicDraw = 0X88e8
        /// </summary>
        DynamicDraw = ((int)0X88e8)        ,
    }

    /// <summary>
    /// Used in GL.Clear
    /// </summary>
    [Flags]
    public enum ClearBufferMask : int
    {
        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT = 0x00000100
        /// </summary>
        DepthBufferBit = ((int)0x00000100)        ,
        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT = 0x00000400
        /// </summary>
        StencilBufferBit = ((int)0x00000400)        ,
        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT = 0x00004000
        /// </summary>
        ColorBufferBit = ((int)0x00004000)        ,
    }

    /// <summary>
    /// Used in GL.CullFace, GL.StencilFuncSeparate, GL.StencilMaskSeparate, GL.StencilOpSeparate
    /// </summary>
    public enum CullFaceMode : int
    {
        /// <summary>
        /// Original was GL_FRONT = 0x0404
        /// </summary>
        Front = ((int)0x0404)        ,
        /// <summary>
        /// Original was GL_BACK = 0x0405
        /// </summary>
        Back = ((int)0x0405)        ,
        /// <summary>
        /// Original was GL_FRONT_AND_BACK = 0x0408
        /// </summary>
        FrontAndBack = ((int)0x0408)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum DataType : int
    {
        /// <summary>
        /// Original was GL_BYTE = 0x1400
        /// </summary>
        Byte = ((int)0x1400)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_BYTE = 0x1401
        /// </summary>
        UnsignedByte = ((int)0x1401)        ,
        /// <summary>
        /// Original was GL_SHORT = 0x1402
        /// </summary>
        Short = ((int)0x1402)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT = 0x1403
        /// </summary>
        UnsignedShort = ((int)0x1403)        ,
        /// <summary>
        /// Original was GL_INT = 0x1404
        /// </summary>
        Int = ((int)0x1404)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_INT = 0x1405
        /// </summary>
        UnsignedInt = ((int)0x1405)        ,
        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = ((int)0x1406)        ,
        /// <summary>
        /// Original was GL_FIXED = 0x140C
        /// </summary>
        Fixed = ((int)0x140C)        ,
    }

    /// <summary>
    /// Used in GL.DepthFunc
    /// </summary>
    public enum DepthFunction : int
    {
        /// <summary>
        /// Original was GL_Never = 0X0200
        /// </summary>
        Never = ((int)0X0200)        ,
        /// <summary>
        /// Original was GL_Less = 0X0201
        /// </summary>
        Less = ((int)0X0201)        ,
        /// <summary>
        /// Original was GL_Equal = 0X0202
        /// </summary>
        Equal = ((int)0X0202)        ,
        /// <summary>
        /// Original was GL_Lequal = 0X0203
        /// </summary>
        Lequal = ((int)0X0203)        ,
        /// <summary>
        /// Original was GL_Greater = 0X0204
        /// </summary>
        Greater = ((int)0X0204)        ,
        /// <summary>
        /// Original was GL_Notequal = 0X0205
        /// </summary>
        Notequal = ((int)0X0205)        ,
        /// <summary>
        /// Original was GL_Gequal = 0X0206
        /// </summary>
        Gequal = ((int)0X0206)        ,
        /// <summary>
        /// Original was GL_Always = 0X0207
        /// </summary>
        Always = ((int)0X0207)        ,
    }

    /// <summary>
    /// Used in GL.DrawElements
    /// </summary>
    public enum DrawElementsType : int
    {
        /// <summary>
        /// Original was GL_UnsignedByte = 0X1401
        /// </summary>
        UnsignedByte = ((int)0X1401)        ,
        /// <summary>
        /// Original was GL_UnsignedShort = 0X1403
        /// </summary>
        UnsignedShort = ((int)0X1403)        ,
    }

    /// <summary>
    /// Used in GL.Disable, GL.Enable, GL.IsEnabled
    /// </summary>
    public enum EnableCap : int
    {
        /// <summary>
        /// Original was GL_CULL_FACE = 0x0B44
        /// </summary>
        CullFace = ((int)0x0B44)        ,
        /// <summary>
        /// Original was GL_DEPTH_TEST = 0x0B71
        /// </summary>
        DepthTest = ((int)0x0B71)        ,
        /// <summary>
        /// Original was GL_STENCIL_TEST = 0x0B90
        /// </summary>
        StencilTest = ((int)0x0B90)        ,
        /// <summary>
        /// Original was GL_DITHER = 0x0BD0
        /// </summary>
        Dither = ((int)0x0BD0)        ,
        /// <summary>
        /// Original was GL_BLEND = 0x0BE2
        /// </summary>
        Blend = ((int)0x0BE2)        ,
        /// <summary>
        /// Original was GL_SCISSOR_TEST = 0x0C11
        /// </summary>
        ScissorTest = ((int)0x0C11)        ,
        /// <summary>
        /// Original was GL_TEXTURE_2D = 0x0DE1
        /// </summary>
        Texture2D = ((int)0x0DE1)        ,
        /// <summary>
        /// Original was GL_POLYGON_OFFSET_FILL = 0x8037
        /// </summary>
        PolygonOffsetFill = ((int)0x8037)        ,
        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E
        /// </summary>
        SampleAlphaToCoverage = ((int)0x809E)        ,
        /// <summary>
        /// Original was GL_SAMPLE_COVERAGE = 0x80A0
        /// </summary>
        SampleCoverage = ((int)0x80A0)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ErrorCode : int
    {
        /// <summary>
        /// Original was GL_NO_ERROR = 0
        /// </summary>
        NoError = ((int)0)        ,
        /// <summary>
        /// Original was GL_INVALID_ENUM = 0x0500
        /// </summary>
        InvalidEnum = ((int)0x0500)        ,
        /// <summary>
        /// Original was GL_INVALID_VALUE = 0x0501
        /// </summary>
        InvalidValue = ((int)0x0501)        ,
        /// <summary>
        /// Original was GL_INVALID_OPERATION = 0x0502
        /// </summary>
        InvalidOperation = ((int)0x0502)        ,
        /// <summary>
        /// Original was GL_OUT_OF_MEMORY = 0x0505
        /// </summary>
        OutOfMemory = ((int)0x0505)        ,
        /// <summary>
        /// Original was GL_InvalidFramebufferOperation = 0X0506
        /// </summary>
        InvalidFramebufferOperation = ((int)0X0506)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtBlendMinmax : int
    {
        /// <summary>
        /// Original was GL_MIN_EXT = 0x8007
        /// </summary>
        MinExt = ((int)0x8007)        ,
        /// <summary>
        /// Original was GL_MAX_EXT = 0x8008
        /// </summary>
        MaxExt = ((int)0x8008)        ,
        /// <summary>
        /// Original was GL_EXT_blend_minmax = 1
        /// </summary>
        ExtBlendMinmax = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtDiscardFramebuffer : int
    {
        /// <summary>
        /// Original was GL_COLOR_EXT = 0x1800
        /// </summary>
        ColorExt = ((int)0x1800)        ,
        /// <summary>
        /// Original was GL_DEPTH_EXT = 0x1801
        /// </summary>
        DepthExt = ((int)0x1801)        ,
        /// <summary>
        /// Original was GL_STENCIL_EXT = 0x1802
        /// </summary>
        StencilExt = ((int)0x1802)        ,
        /// <summary>
        /// Original was GL_EXT_discard_framebuffer = 1
        /// </summary>
        ExtDiscardFramebuffer = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtReadFormatBgra : int
    {
        /// <summary>
        /// Original was GL_BGRA_EXT = 0x80E1
        /// </summary>
        BgraExt = ((int)0x80E1)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_4_4_4_4_REV_EXT = 0x8365
        /// </summary>
        UnsignedShort4444RevExt = ((int)0x8365)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_1_5_5_5_REV_EXT = 0x8366
        /// </summary>
        UnsignedShort1555RevExt = ((int)0x8366)        ,
        /// <summary>
        /// Original was GL_EXT_read_format_bgra = 1
        /// </summary>
        ExtReadFormatBgra = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtShaderTextureLod : int
    {
        /// <summary>
        /// Original was GL_EXT_shader_texture_lod = 1
        /// </summary>
        ExtShaderTextureLod = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtTextureCompressionDxt1 : int
    {
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_S3TC_DXT1_EXT = 0x83F0
        /// </summary>
        CompressedRgbS3tcDxt1Ext = ((int)0x83F0)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_S3TC_DXT1_EXT = 0x83F1
        /// </summary>
        CompressedRgbaS3tcDxt1Ext = ((int)0x83F1)        ,
        /// <summary>
        /// Original was GL_EXT_texture_compression_dxt1 = 1
        /// </summary>
        ExtTextureCompressionDxt1 = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtTextureFilterAnisotropic : int
    {
        /// <summary>
        /// Original was GL_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FE
        /// </summary>
        TextureMaxAnisotropyExt = ((int)0x84FE)        ,
        /// <summary>
        /// Original was GL_MAX_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FF
        /// </summary>
        MaxTextureMaxAnisotropyExt = ((int)0x84FF)        ,
        /// <summary>
        /// Original was GL_EXT_texture_filter_anisotropic = 1
        /// </summary>
        ExtTextureFilterAnisotropic = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtTextureFormatBgra8888 : int
    {
        /// <summary>
        /// Original was GL_BGRA_EXT = 0x80E1
        /// </summary>
        BgraExt = ((int)0x80E1)        ,
        /// <summary>
        /// Original was GL_EXT_texture_format_BGRA8888 = 1
        /// </summary>
        ExtTextureFormatBgra8888 = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ExtTextureType2101010Rev : int
    {
        /// <summary>
        /// Original was GL_UNSIGNED_INT_2_10_10_10_REV_EXT = 0x8368
        /// </summary>
        UnsignedInt2101010RevExt = ((int)0x8368)        ,
        /// <summary>
        /// Original was GL_EXT_texture_type_2_10_10_10_REV = 1
        /// </summary>
        ExtTextureType2101010Rev = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FramebufferErrorCode : int
    {
        /// <summary>
        /// Original was GL_FramebufferComplete = 0X8cd5
        /// </summary>
        FramebufferComplete = ((int)0X8cd5)        ,
        /// <summary>
        /// Original was GL_FramebufferIncompleteAttachment = 0X8cd6
        /// </summary>
        FramebufferIncompleteAttachment = ((int)0X8cd6)        ,
        /// <summary>
        /// Original was GL_FramebufferIncompleteMissingAttachment = 0X8cd7
        /// </summary>
        FramebufferIncompleteMissingAttachment = ((int)0X8cd7)        ,
        /// <summary>
        /// Original was GL_FramebufferIncompleteDimensions = 0X8cd9
        /// </summary>
        FramebufferIncompleteDimensions = ((int)0X8cd9)        ,
        /// <summary>
        /// Original was GL_FramebufferUnsupported = 0X8cdd
        /// </summary>
        FramebufferUnsupported = ((int)0X8cdd)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FramebufferObject : int
    {
        /// <summary>
        /// Original was GL_NONE = 0
        /// </summary>
        None = ((int)0)        ,
        /// <summary>
        /// Original was GL_INVALID_FRAMEBUFFER_OPERATION = 0x0506
        /// </summary>
        InvalidFramebufferOperation = ((int)0x0506)        ,
        /// <summary>
        /// Original was GL_STENCIL_INDEX = 0x1901
        /// </summary>
        StencilIndex = ((int)0x1901)        ,
        /// <summary>
        /// Original was GL_RGBA4 = 0x8056
        /// </summary>
        Rgba4 = ((int)0x8056)        ,
        /// <summary>
        /// Original was GL_RGB5_A1 = 0x8057
        /// </summary>
        Rgb5A1 = ((int)0x8057)        ,
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16 = 0x81A5
        /// </summary>
        DepthComponent16 = ((int)0x81A5)        ,
        /// <summary>
        /// Original was GL_MAX_RENDERBUFFER_SIZE = 0x84E8
        /// </summary>
        MaxRenderbufferSize = ((int)0x84E8)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_BINDING = 0x8CA6
        /// </summary>
        FramebufferBinding = ((int)0x8CA6)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_BINDING = 0x8CA7
        /// </summary>
        RenderbufferBinding = ((int)0x8CA7)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0
        /// </summary>
        FramebufferAttachmentObjectType = ((int)0x8CD0)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1
        /// </summary>
        FramebufferAttachmentObjectName = ((int)0x8CD1)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2
        /// </summary>
        FramebufferAttachmentTextureLevel = ((int)0x8CD2)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3
        /// </summary>
        FramebufferAttachmentTextureCubeMapFace = ((int)0x8CD3)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_COMPLETE = 0x8CD5
        /// </summary>
        FramebufferComplete = ((int)0x8CD5)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6
        /// </summary>
        FramebufferIncompleteAttachment = ((int)0x8CD6)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7
        /// </summary>
        FramebufferIncompleteMissingAttachment = ((int)0x8CD7)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS = 0x8CD9
        /// </summary>
        FramebufferIncompleteDimensions = ((int)0x8CD9)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_UNSUPPORTED = 0x8CDD
        /// </summary>
        FramebufferUnsupported = ((int)0x8CDD)        ,
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0 = 0x8CE0
        /// </summary>
        ColorAttachment0 = ((int)0x8CE0)        ,
        /// <summary>
        /// Original was GL_DEPTH_ATTACHMENT = 0x8D00
        /// </summary>
        DepthAttachment = ((int)0x8D00)        ,
        /// <summary>
        /// Original was GL_STENCIL_ATTACHMENT = 0x8D20
        /// </summary>
        StencilAttachment = ((int)0x8D20)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER = 0x8D40
        /// </summary>
        Framebuffer = ((int)0x8D40)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER = 0x8D41
        /// </summary>
        Renderbuffer = ((int)0x8D41)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_WIDTH = 0x8D42
        /// </summary>
        RenderbufferWidth = ((int)0x8D42)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_HEIGHT = 0x8D43
        /// </summary>
        RenderbufferHeight = ((int)0x8D43)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_INTERNAL_FORMAT = 0x8D44
        /// </summary>
        RenderbufferInternalFormat = ((int)0x8D44)        ,
        /// <summary>
        /// Original was GL_STENCIL_INDEX8 = 0x8D48
        /// </summary>
        StencilIndex8 = ((int)0x8D48)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_RED_SIZE = 0x8D50
        /// </summary>
        RenderbufferRedSize = ((int)0x8D50)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_GREEN_SIZE = 0x8D51
        /// </summary>
        RenderbufferGreenSize = ((int)0x8D51)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_BLUE_SIZE = 0x8D52
        /// </summary>
        RenderbufferBlueSize = ((int)0x8D52)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_ALPHA_SIZE = 0x8D53
        /// </summary>
        RenderbufferAlphaSize = ((int)0x8D53)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_DEPTH_SIZE = 0x8D54
        /// </summary>
        RenderbufferDepthSize = ((int)0x8D54)        ,
        /// <summary>
        /// Original was GL_RENDERBUFFER_STENCIL_SIZE = 0x8D55
        /// </summary>
        RenderbufferStencilSize = ((int)0x8D55)        ,
        /// <summary>
        /// Original was GL_RGB565 = 0x8D62
        /// </summary>
        Rgb565 = ((int)0x8D62)        ,
    }

    /// <summary>
    /// Used in GL.GetFramebufferAttachmentParameter
    /// </summary>
    public enum FramebufferParameterName : int
    {
        /// <summary>
        /// Original was GL_FramebufferAttachmentObjectType = 0X8cd0
        /// </summary>
        FramebufferAttachmentObjectType = ((int)0X8cd0)        ,
        /// <summary>
        /// Original was GL_FramebufferAttachmentObjectName = 0X8cd1
        /// </summary>
        FramebufferAttachmentObjectName = ((int)0X8cd1)        ,
        /// <summary>
        /// Original was GL_FramebufferAttachmentTextureLevel = 0X8cd2
        /// </summary>
        FramebufferAttachmentTextureLevel = ((int)0X8cd2)        ,
        /// <summary>
        /// Original was GL_FramebufferAttachmentTextureCubeMapFace = 0X8cd3
        /// </summary>
        FramebufferAttachmentTextureCubeMapFace = ((int)0X8cd3)        ,
    }

    /// <summary>
    /// Used in GL.FramebufferRenderbuffer, GL.FramebufferTexture2D, GL.GetFramebufferAttachmentParameter
    /// </summary>
    public enum FramebufferSlot : int
    {
        /// <summary>
        /// Original was GL_ColorAttachment0 = 0X8ce0
        /// </summary>
        ColorAttachment0 = ((int)0X8ce0)        ,
        /// <summary>
        /// Original was GL_DepthAttachment = 0X8d00
        /// </summary>
        DepthAttachment = ((int)0X8d00)        ,
        /// <summary>
        /// Original was GL_StencilAttachment = 0X8d20
        /// </summary>
        StencilAttachment = ((int)0X8d20)        ,
    }

    /// <summary>
    /// Used in GL.BindFramebuffer, GL.CheckFramebufferStatus, GL.FramebufferRenderbuffer, GL.FramebufferTexture2D, GL.GetFramebufferAttachmentParameter
    /// </summary>
    public enum FramebufferTarget : int
    {
        /// <summary>
        /// Original was GL_Framebuffer = 0X8d40
        /// </summary>
        Framebuffer = ((int)0X8d40)        ,
    }

    /// <summary>
    /// Used in GL.FrontFace
    /// </summary>
    public enum FrontFaceDirection : int
    {
        /// <summary>
        /// Original was GL_CW = 0x0900
        /// </summary>
        Cw = ((int)0x0900)        ,
        /// <summary>
        /// Original was GL_CCW = 0x0901
        /// </summary>
        Ccw = ((int)0x0901)        ,
    }

    /// <summary>
    /// Used in GL.GetBoolean, GL.GetFloat, GL.GetInteger
    /// </summary>
    public enum GetPName : int
    {
        /// <summary>
        /// Original was GL_LINE_WIDTH = 0x0B21
        /// </summary>
        LineWidth = ((int)0x0B21)        ,
        /// <summary>
        /// Original was GL_CullFace = 0X0b44
        /// </summary>
        CullFace = ((int)0X0b44)        ,
        /// <summary>
        /// Original was GL_CULL_FACE_MODE = 0x0B45
        /// </summary>
        CullFaceMode = ((int)0x0B45)        ,
        /// <summary>
        /// Original was GL_FRONT_FACE = 0x0B46
        /// </summary>
        FrontFace = ((int)0x0B46)        ,
        /// <summary>
        /// Original was GL_DEPTH_RANGE = 0x0B70
        /// </summary>
        DepthRange = ((int)0x0B70)        ,
        /// <summary>
        /// Original was GL_DepthTest = 0X0b71
        /// </summary>
        DepthTest = ((int)0X0b71)        ,
        /// <summary>
        /// Original was GL_DEPTH_WRITEMASK = 0x0B72
        /// </summary>
        DepthWritemask = ((int)0x0B72)        ,
        /// <summary>
        /// Original was GL_DEPTH_CLEAR_VALUE = 0x0B73
        /// </summary>
        DepthClearValue = ((int)0x0B73)        ,
        /// <summary>
        /// Original was GL_DEPTH_FUNC = 0x0B74
        /// </summary>
        DepthFunc = ((int)0x0B74)        ,
        /// <summary>
        /// Original was GL_StencilTest = 0X0b90
        /// </summary>
        StencilTest = ((int)0X0b90)        ,
        /// <summary>
        /// Original was GL_STENCIL_CLEAR_VALUE = 0x0B91
        /// </summary>
        StencilClearValue = ((int)0x0B91)        ,
        /// <summary>
        /// Original was GL_STENCIL_FUNC = 0x0B92
        /// </summary>
        StencilFunc = ((int)0x0B92)        ,
        /// <summary>
        /// Original was GL_STENCIL_VALUE_MASK = 0x0B93
        /// </summary>
        StencilValueMask = ((int)0x0B93)        ,
        /// <summary>
        /// Original was GL_STENCIL_FAIL = 0x0B94
        /// </summary>
        StencilFail = ((int)0x0B94)        ,
        /// <summary>
        /// Original was GL_STENCIL_PASS_DEPTH_FAIL = 0x0B95
        /// </summary>
        StencilPassDepthFail = ((int)0x0B95)        ,
        /// <summary>
        /// Original was GL_STENCIL_PASS_DEPTH_PASS = 0x0B96
        /// </summary>
        StencilPassDepthPass = ((int)0x0B96)        ,
        /// <summary>
        /// Original was GL_STENCIL_REF = 0x0B97
        /// </summary>
        StencilRef = ((int)0x0B97)        ,
        /// <summary>
        /// Original was GL_STENCIL_WRITEMASK = 0x0B98
        /// </summary>
        StencilWritemask = ((int)0x0B98)        ,
        /// <summary>
        /// Original was GL_VIEWPORT = 0x0BA2
        /// </summary>
        Viewport = ((int)0x0BA2)        ,
        /// <summary>
        /// Original was GL_Dither = 0X0bd0
        /// </summary>
        Dither = ((int)0X0bd0)        ,
        /// <summary>
        /// Original was GL_Blend = 0X0be2
        /// </summary>
        Blend = ((int)0X0be2)        ,
        /// <summary>
        /// Original was GL_SCISSOR_BOX = 0x0C10
        /// </summary>
        ScissorBox = ((int)0x0C10)        ,
        /// <summary>
        /// Original was GL_ScissorTest = 0X0c11
        /// </summary>
        ScissorTest = ((int)0X0c11)        ,
        /// <summary>
        /// Original was GL_COLOR_CLEAR_VALUE = 0x0C22
        /// </summary>
        ColorClearValue = ((int)0x0C22)        ,
        /// <summary>
        /// Original was GL_COLOR_WRITEMASK = 0x0C23
        /// </summary>
        ColorWritemask = ((int)0x0C23)        ,
        /// <summary>
        /// Original was GL_UNPACK_ALIGNMENT = 0x0CF5
        /// </summary>
        UnpackAlignment = ((int)0x0CF5)        ,
        /// <summary>
        /// Original was GL_PACK_ALIGNMENT = 0x0D05
        /// </summary>
        PackAlignment = ((int)0x0D05)        ,
        /// <summary>
        /// Original was GL_MAX_TEXTURE_SIZE = 0x0D33
        /// </summary>
        MaxTextureSize = ((int)0x0D33)        ,
        /// <summary>
        /// Original was GL_MAX_VIEWPORT_DIMS = 0x0D3A
        /// </summary>
        MaxViewportDims = ((int)0x0D3A)        ,
        /// <summary>
        /// Original was GL_SUBPIXEL_BITS = 0x0D50
        /// </summary>
        SubpixelBits = ((int)0x0D50)        ,
        /// <summary>
        /// Original was GL_RED_BITS = 0x0D52
        /// </summary>
        RedBits = ((int)0x0D52)        ,
        /// <summary>
        /// Original was GL_GREEN_BITS = 0x0D53
        /// </summary>
        GreenBits = ((int)0x0D53)        ,
        /// <summary>
        /// Original was GL_BLUE_BITS = 0x0D54
        /// </summary>
        BlueBits = ((int)0x0D54)        ,
        /// <summary>
        /// Original was GL_ALPHA_BITS = 0x0D55
        /// </summary>
        AlphaBits = ((int)0x0D55)        ,
        /// <summary>
        /// Original was GL_DEPTH_BITS = 0x0D56
        /// </summary>
        DepthBits = ((int)0x0D56)        ,
        /// <summary>
        /// Original was GL_STENCIL_BITS = 0x0D57
        /// </summary>
        StencilBits = ((int)0x0D57)        ,
        /// <summary>
        /// Original was GL_Texture2D = 0X0de1
        /// </summary>
        Texture2D = ((int)0X0de1)        ,
        /// <summary>
        /// Original was GL_POLYGON_OFFSET_UNITS = 0x2A00
        /// </summary>
        PolygonOffsetUnits = ((int)0x2A00)        ,
        /// <summary>
        /// Original was GL_BlendColor = 0X8005
        /// </summary>
        BlendColor = ((int)0X8005)        ,
        /// <summary>
        /// Original was GL_BlendEquation = 0X8009
        /// </summary>
        BlendEquation = ((int)0X8009)        ,
        /// <summary>
        /// Original was GL_BlendEquationRgb = 0X8009
        /// </summary>
        BlendEquationRgb = ((int)0X8009)        ,
        /// <summary>
        /// Original was GL_PolygonOffsetFill = 0X8037
        /// </summary>
        PolygonOffsetFill = ((int)0X8037)        ,
        /// <summary>
        /// Original was GL_POLYGON_OFFSET_FACTOR = 0x8038
        /// </summary>
        PolygonOffsetFactor = ((int)0x8038)        ,
        /// <summary>
        /// Original was GL_TEXTURE_BINDING_2D = 0x8069
        /// </summary>
        TextureBinding2D = ((int)0x8069)        ,
        /// <summary>
        /// Original was GL_SampleAlphaToCoverage = 0X809e
        /// </summary>
        SampleAlphaToCoverage = ((int)0X809e)        ,
        /// <summary>
        /// Original was GL_SampleCoverage = 0X80a0
        /// </summary>
        SampleCoverage = ((int)0X80a0)        ,
        /// <summary>
        /// Original was GL_SAMPLE_BUFFERS = 0x80A8
        /// </summary>
        SampleBuffers = ((int)0x80A8)        ,
        /// <summary>
        /// Original was GL_SAMPLES = 0x80A9
        /// </summary>
        Samples = ((int)0x80A9)        ,
        /// <summary>
        /// Original was GL_SAMPLE_COVERAGE_VALUE = 0x80AA
        /// </summary>
        SampleCoverageValue = ((int)0x80AA)        ,
        /// <summary>
        /// Original was GL_SAMPLE_COVERAGE_INVERT = 0x80AB
        /// </summary>
        SampleCoverageInvert = ((int)0x80AB)        ,
        /// <summary>
        /// Original was GL_BlendDstRgb = 0X80c8
        /// </summary>
        BlendDstRgb = ((int)0X80c8)        ,
        /// <summary>
        /// Original was GL_BlendSrcRgb = 0X80c9
        /// </summary>
        BlendSrcRgb = ((int)0X80c9)        ,
        /// <summary>
        /// Original was GL_BlendDstAlpha = 0X80ca
        /// </summary>
        BlendDstAlpha = ((int)0X80ca)        ,
        /// <summary>
        /// Original was GL_BlendSrcAlpha = 0X80cb
        /// </summary>
        BlendSrcAlpha = ((int)0X80cb)        ,
        /// <summary>
        /// Original was GL_GenerateMipmapHint = 0X8192
        /// </summary>
        GenerateMipmapHint = ((int)0X8192)        ,
        /// <summary>
        /// Original was GL_ALIASED_POINT_SIZE_RANGE = 0x846D
        /// </summary>
        AliasedPointSizeRange = ((int)0x846D)        ,
        /// <summary>
        /// Original was GL_ALIASED_LINE_WIDTH_RANGE = 0x846E
        /// </summary>
        AliasedLineWidthRange = ((int)0x846E)        ,
        /// <summary>
        /// Original was GL_ActiveTexture = 0X84e0
        /// </summary>
        ActiveTexture = ((int)0X84e0)        ,
        /// <summary>
        /// Original was GL_MaxRenderbufferSize = 0X84e8
        /// </summary>
        MaxRenderbufferSize = ((int)0X84e8)        ,
        /// <summary>
        /// Original was GL_TextureBindingCubeMap = 0X8514
        /// </summary>
        TextureBindingCubeMap = ((int)0X8514)        ,
        /// <summary>
        /// Original was GL_MaxCubeMapTextureSize = 0X851c
        /// </summary>
        MaxCubeMapTextureSize = ((int)0X851c)        ,
        /// <summary>
        /// Original was GL_NumCompressedTextureFormats = 0X86a2
        /// </summary>
        NumCompressedTextureFormats = ((int)0X86a2)        ,
        /// <summary>
        /// Original was GL_CompressedTextureFormats = 0X86a3
        /// </summary>
        CompressedTextureFormats = ((int)0X86a3)        ,
        /// <summary>
        /// Original was GL_STENCIL_BACK_FUNC = 0x8800
        /// </summary>
        StencilBackFunc = ((int)0x8800)        ,
        /// <summary>
        /// Original was GL_STENCIL_BACK_FAIL = 0x8801
        /// </summary>
        StencilBackFail = ((int)0x8801)        ,
        /// <summary>
        /// Original was GL_STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802
        /// </summary>
        StencilBackPassDepthFail = ((int)0x8802)        ,
        /// <summary>
        /// Original was GL_STENCIL_BACK_PASS_DEPTH_PASS = 0x8803
        /// </summary>
        StencilBackPassDepthPass = ((int)0x8803)        ,
        /// <summary>
        /// Original was GL_BlendEquationAlpha = 0X883d
        /// </summary>
        BlendEquationAlpha = ((int)0X883d)        ,
        /// <summary>
        /// Original was GL_MaxVertexAttribs = 0X8869
        /// </summary>
        MaxVertexAttribs = ((int)0X8869)        ,
        /// <summary>
        /// Original was GL_MaxTextureImageUnits = 0X8872
        /// </summary>
        MaxTextureImageUnits = ((int)0X8872)        ,
        /// <summary>
        /// Original was GL_ArrayBufferBinding = 0X8894
        /// </summary>
        ArrayBufferBinding = ((int)0X8894)        ,
        /// <summary>
        /// Original was GL_ElementArrayBufferBinding = 0X8895
        /// </summary>
        ElementArrayBufferBinding = ((int)0X8895)        ,
        /// <summary>
        /// Original was GL_MaxVertexTextureImageUnits = 0X8b4c
        /// </summary>
        MaxVertexTextureImageUnits = ((int)0X8b4c)        ,
        /// <summary>
        /// Original was GL_MaxCombinedTextureImageUnits = 0X8b4d
        /// </summary>
        MaxCombinedTextureImageUnits = ((int)0X8b4d)        ,
        /// <summary>
        /// Original was GL_CurrentProgram = 0X8b8d
        /// </summary>
        CurrentProgram = ((int)0X8b8d)        ,
        /// <summary>
        /// Original was GL_ImplementationColorReadType = 0X8b9a
        /// </summary>
        ImplementationColorReadType = ((int)0X8b9a)        ,
        /// <summary>
        /// Original was GL_ImplementationColorReadFormat = 0X8b9b
        /// </summary>
        ImplementationColorReadFormat = ((int)0X8b9b)        ,
        /// <summary>
        /// Original was GL_STENCIL_BACK_REF = 0x8CA3
        /// </summary>
        StencilBackRef = ((int)0x8CA3)        ,
        /// <summary>
        /// Original was GL_STENCIL_BACK_VALUE_MASK = 0x8CA4
        /// </summary>
        StencilBackValueMask = ((int)0x8CA4)        ,
        /// <summary>
        /// Original was GL_STENCIL_BACK_WRITEMASK = 0x8CA5
        /// </summary>
        StencilBackWritemask = ((int)0x8CA5)        ,
        /// <summary>
        /// Original was GL_FramebufferBinding = 0X8ca6
        /// </summary>
        FramebufferBinding = ((int)0X8ca6)        ,
        /// <summary>
        /// Original was GL_RenderbufferBinding = 0X8ca7
        /// </summary>
        RenderbufferBinding = ((int)0X8ca7)        ,
        /// <summary>
        /// Original was GL_ShaderBinaryFormats = 0X8df8
        /// </summary>
        ShaderBinaryFormats = ((int)0X8df8)        ,
        /// <summary>
        /// Original was GL_NumShaderBinaryFormats = 0X8df9
        /// </summary>
        NumShaderBinaryFormats = ((int)0X8df9)        ,
        /// <summary>
        /// Original was GL_ShaderCompiler = 0X8dfa
        /// </summary>
        ShaderCompiler = ((int)0X8dfa)        ,
        /// <summary>
        /// Original was GL_MaxVertexUniformVectors = 0X8dfb
        /// </summary>
        MaxVertexUniformVectors = ((int)0X8dfb)        ,
        /// <summary>
        /// Original was GL_MaxVaryingVectors = 0X8dfc
        /// </summary>
        MaxVaryingVectors = ((int)0X8dfc)        ,
        /// <summary>
        /// Original was GL_MaxFragmentUniformVectors = 0X8dfd
        /// </summary>
        MaxFragmentUniformVectors = ((int)0X8dfd)        ,
    }

    /// <summary>
    /// Used in GL.GetTexParameter
    /// </summary>
    public enum GetTextureParameter : int
    {
        /// <summary>
        /// Original was GL_TextureMagFilter = 0X2800
        /// </summary>
        TextureMagFilter = ((int)0X2800)        ,
        /// <summary>
        /// Original was GL_TextureMinFilter = 0X2801
        /// </summary>
        TextureMinFilter = ((int)0X2801)        ,
        /// <summary>
        /// Original was GL_TextureWrapS = 0X2802
        /// </summary>
        TextureWrapS = ((int)0X2802)        ,
        /// <summary>
        /// Original was GL_TextureWrapT = 0X2803
        /// </summary>
        TextureWrapT = ((int)0X2803)        ,
        /// <summary>
        /// Original was GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2
        /// </summary>
        NumCompressedTextureFormats = ((int)0x86A2)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3
        /// </summary>
        CompressedTextureFormats = ((int)0x86A3)        ,
    }

    /// <summary>
    /// Used in GL.Hint
    /// </summary>
    public enum HintMode : int
    {
        /// <summary>
        /// Original was GL_DONT_CARE = 0x1100
        /// </summary>
        DontCare = ((int)0x1100)        ,
        /// <summary>
        /// Original was GL_FASTEST = 0x1101
        /// </summary>
        Fastest = ((int)0x1101)        ,
        /// <summary>
        /// Original was GL_NICEST = 0x1102
        /// </summary>
        Nicest = ((int)0x1102)        ,
    }

    /// <summary>
    /// Used in GL.Hint
    /// </summary>
    public enum HintTarget : int
    {
        /// <summary>
        /// Original was GL_GENERATE_MIPMAP_HINT = 0x8192
        /// </summary>
        GenerateMipmapHint = ((int)0x8192)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ImgMultisampledRenderToTexture : int
    {
        /// <summary>
        /// Original was GL_RENDERBUFFER_SAMPLES_IMG = 0x9133
        /// </summary>
        RenderbufferSamplesImg = ((int)0x9133)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_IMG = 0x9134
        /// </summary>
        FramebufferIncompleteMultisampleImg = ((int)0x9134)        ,
        /// <summary>
        /// Original was GL_MAX_SAMPLES_IMG = 0x9135
        /// </summary>
        MaxSamplesImg = ((int)0x9135)        ,
        /// <summary>
        /// Original was GL_TEXTURE_SAMPLES_IMG = 0x9136
        /// </summary>
        TextureSamplesImg = ((int)0x9136)        ,
        /// <summary>
        /// Original was GL_IMG_multisampled_render_to_texture = 1
        /// </summary>
        ImgMultisampledRenderToTexture = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ImgProgramBinary : int
    {
        /// <summary>
        /// Original was GL_SGX_PROGRAM_BINARY_IMG = 0x9130
        /// </summary>
        SgxProgramBinaryImg = ((int)0x9130)        ,
        /// <summary>
        /// Original was GL_IMG_program_binary = 1
        /// </summary>
        ImgProgramBinary = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ImgReadFormat : int
    {
        /// <summary>
        /// Original was GL_BGRA_IMG = 0x80E1
        /// </summary>
        BgraImg = ((int)0x80E1)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_4_4_4_4_REV_IMG = 0x8365
        /// </summary>
        UnsignedShort4444RevImg = ((int)0x8365)        ,
        /// <summary>
        /// Original was GL_IMG_read_format = 1
        /// </summary>
        ImgReadFormat = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ImgShaderBinary : int
    {
        /// <summary>
        /// Original was GL_SGX_BINARY_IMG = 0x8C0A
        /// </summary>
        SgxBinaryImg = ((int)0x8C0A)        ,
        /// <summary>
        /// Original was GL_IMG_shader_binary = 1
        /// </summary>
        ImgShaderBinary = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ImgTextureCompressionPvrtc : int
    {
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_PVRTC_4BPPV1_IMG = 0x8C00
        /// </summary>
        CompressedRgbPvrtc4Bppv1Img = ((int)0x8C00)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_PVRTC_2BPPV1_IMG = 0x8C01
        /// </summary>
        CompressedRgbPvrtc2Bppv1Img = ((int)0x8C01)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_PVRTC_4BPPV1_IMG = 0x8C02
        /// </summary>
        CompressedRgbaPvrtc4Bppv1Img = ((int)0x8C02)        ,
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_PVRTC_2BPPV1_IMG = 0x8C03
        /// </summary>
        CompressedRgbaPvrtc2Bppv1Img = ((int)0x8C03)        ,
        /// <summary>
        /// Original was GL_IMG_texture_compression_pvrtc = 1
        /// </summary>
        ImgTextureCompressionPvrtc = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvCoverageSample : int
    {
        /// <summary>
        /// Original was GL_COVERAGE_BUFFER_BIT_NV = 0x8000
        /// </summary>
        CoverageBufferBitNv = ((int)0x8000)        ,
        /// <summary>
        /// Original was GL_COVERAGE_COMPONENT_NV = 0x8ED0
        /// </summary>
        CoverageComponentNv = ((int)0x8ED0)        ,
        /// <summary>
        /// Original was GL_COVERAGE_COMPONENT4_NV = 0x8ED1
        /// </summary>
        CoverageComponent4Nv = ((int)0x8ED1)        ,
        /// <summary>
        /// Original was GL_COVERAGE_ATTACHMENT_NV = 0x8ED2
        /// </summary>
        CoverageAttachmentNv = ((int)0x8ED2)        ,
        /// <summary>
        /// Original was GL_COVERAGE_BUFFERS_NV = 0x8ED3
        /// </summary>
        CoverageBuffersNv = ((int)0x8ED3)        ,
        /// <summary>
        /// Original was GL_COVERAGE_SAMPLES_NV = 0x8ED4
        /// </summary>
        CoverageSamplesNv = ((int)0x8ED4)        ,
        /// <summary>
        /// Original was GL_COVERAGE_ALL_FRAGMENTS_NV = 0x8ED5
        /// </summary>
        CoverageAllFragmentsNv = ((int)0x8ED5)        ,
        /// <summary>
        /// Original was GL_COVERAGE_EDGE_FRAGMENTS_NV = 0x8ED6
        /// </summary>
        CoverageEdgeFragmentsNv = ((int)0x8ED6)        ,
        /// <summary>
        /// Original was GL_COVERAGE_AUTOMATIC_NV = 0x8ED7
        /// </summary>
        CoverageAutomaticNv = ((int)0x8ED7)        ,
        /// <summary>
        /// Original was GL_NV_coverage_sample = 1
        /// </summary>
        NvCoverageSample = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvDepthNonlinear : int
    {
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16_NONLINEAR_NV = 0x8E2C
        /// </summary>
        DepthComponent16NonlinearNv = ((int)0x8E2C)        ,
        /// <summary>
        /// Original was GL_NV_depth_nonlinear = 1
        /// </summary>
        NvDepthNonlinear = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum NvFence : int
    {
        /// <summary>
        /// Original was GL_ALL_COMPLETED_NV = 0x84F2
        /// </summary>
        AllCompletedNv = ((int)0x84F2)        ,
        /// <summary>
        /// Original was GL_FENCE_STATUS_NV = 0x84F3
        /// </summary>
        FenceStatusNv = ((int)0x84F3)        ,
        /// <summary>
        /// Original was GL_FENCE_CONDITION_NV = 0x84F4
        /// </summary>
        FenceConditionNv = ((int)0x84F4)        ,
        /// <summary>
        /// Original was GL_NV_fence = 1
        /// </summary>
        NvFence = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesCompressedEtc1Rgb8Texture : int
    {
        /// <summary>
        /// Original was GL_ETC1_RGB8_OES = 0x8D64
        /// </summary>
        Etc1Rgb8Oes = ((int)0x8D64)        ,
        /// <summary>
        /// Original was GL_OES_compressed_ETC1_RGB8_texture = 1
        /// </summary>
        OesCompressedEtc1Rgb8Texture = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesCompressedPalettedTexture : int
    {
        /// <summary>
        /// Original was GL_PALETTE4_RGB8_OES = 0x8B90
        /// </summary>
        Palette4Rgb8Oes = ((int)0x8B90)        ,
        /// <summary>
        /// Original was GL_PALETTE4_RGBA8_OES = 0x8B91
        /// </summary>
        Palette4Rgba8Oes = ((int)0x8B91)        ,
        /// <summary>
        /// Original was GL_PALETTE4_R5_G6_B5_OES = 0x8B92
        /// </summary>
        Palette4R5G6B5Oes = ((int)0x8B92)        ,
        /// <summary>
        /// Original was GL_PALETTE4_RGBA4_OES = 0x8B93
        /// </summary>
        Palette4Rgba4Oes = ((int)0x8B93)        ,
        /// <summary>
        /// Original was GL_PALETTE4_RGB5_A1_OES = 0x8B94
        /// </summary>
        Palette4Rgb5A1Oes = ((int)0x8B94)        ,
        /// <summary>
        /// Original was GL_PALETTE8_RGB8_OES = 0x8B95
        /// </summary>
        Palette8Rgb8Oes = ((int)0x8B95)        ,
        /// <summary>
        /// Original was GL_PALETTE8_RGBA8_OES = 0x8B96
        /// </summary>
        Palette8Rgba8Oes = ((int)0x8B96)        ,
        /// <summary>
        /// Original was GL_PALETTE8_R5_G6_B5_OES = 0x8B97
        /// </summary>
        Palette8R5G6B5Oes = ((int)0x8B97)        ,
        /// <summary>
        /// Original was GL_PALETTE8_RGBA4_OES = 0x8B98
        /// </summary>
        Palette8Rgba4Oes = ((int)0x8B98)        ,
        /// <summary>
        /// Original was GL_PALETTE8_RGB5_A1_OES = 0x8B99
        /// </summary>
        Palette8Rgb5A1Oes = ((int)0x8B99)        ,
        /// <summary>
        /// Original was GL_OES_compressed_paletted_texture = 1
        /// </summary>
        OesCompressedPalettedTexture = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesDepth24 : int
    {
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24_OES = 0x81A6
        /// </summary>
        DepthComponent24Oes = ((int)0x81A6)        ,
        /// <summary>
        /// Original was GL_OES_depth24 = 1
        /// </summary>
        OesDepth24 = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesDepth32 : int
    {
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32_OES = 0x81A7
        /// </summary>
        DepthComponent32Oes = ((int)0x81A7)        ,
        /// <summary>
        /// Original was GL_OES_depth32 = 1
        /// </summary>
        OesDepth32 = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesDepthTexture : int
    {
        /// <summary>
        /// Original was GL_OES_depth_texture = 1
        /// </summary>
        OesDepthTexture = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesEglImage : int
    {
        /// <summary>
        /// Original was GL_OES_EGL_image = 1
        /// </summary>
        OesEglImage = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesElementIndexUint : int
    {
        /// <summary>
        /// Original was GL_UNSIGNED_INT = 0x1405
        /// </summary>
        UnsignedInt = ((int)0x1405)        ,
        /// <summary>
        /// Original was GL_OES_element_index_uint = 1
        /// </summary>
        OesElementIndexUint = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesFboRenderMipmap : int
    {
        /// <summary>
        /// Original was GL_OES_fbo_render_mipmap = 1
        /// </summary>
        OesFboRenderMipmap = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesFragmentPrecisionHigh : int
    {
        /// <summary>
        /// Original was GL_OES_fragment_precision_high = 1
        /// </summary>
        OesFragmentPrecisionHigh = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesGetProgramBinary : int
    {
        /// <summary>
        /// Original was GL_PROGRAM_BINARY_LENGTH_OES = 0x8741
        /// </summary>
        ProgramBinaryLengthOes = ((int)0x8741)        ,
        /// <summary>
        /// Original was GL_NUM_PROGRAM_BINARY_FORMATS_OES = 0x87FE
        /// </summary>
        NumProgramBinaryFormatsOes = ((int)0x87FE)        ,
        /// <summary>
        /// Original was GL_PROGRAM_BINARY_FORMATS_OES = 0x87FF
        /// </summary>
        ProgramBinaryFormatsOes = ((int)0x87FF)        ,
        /// <summary>
        /// Original was GL_OES_get_program_binary = 1
        /// </summary>
        OesGetProgramBinary = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesMapbuffer : int
    {
        /// <summary>
        /// Original was GL_WRITE_ONLY_OES = 0x88B9
        /// </summary>
        WriteOnlyOes = ((int)0x88B9)        ,
        /// <summary>
        /// Original was GL_BUFFER_ACCESS_OES = 0x88BB
        /// </summary>
        BufferAccessOes = ((int)0x88BB)        ,
        /// <summary>
        /// Original was GL_BUFFER_MAPPED_OES = 0x88BC
        /// </summary>
        BufferMappedOes = ((int)0x88BC)        ,
        /// <summary>
        /// Original was GL_BUFFER_MAP_POINTER_OES = 0x88BD
        /// </summary>
        BufferMapPointerOes = ((int)0x88BD)        ,
        /// <summary>
        /// Original was GL_OES_mapbuffer = 1
        /// </summary>
        OesMapbuffer = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesPackedDepthStencil : int
    {
        /// <summary>
        /// Original was GL_DEPTH_STENCIL_OES = 0x84F9
        /// </summary>
        DepthStencilOes = ((int)0x84F9)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_INT_24_8_OES = 0x84FA
        /// </summary>
        UnsignedInt248Oes = ((int)0x84FA)        ,
        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8_OES = 0x88F0
        /// </summary>
        Depth24Stencil8Oes = ((int)0x88F0)        ,
        /// <summary>
        /// Original was GL_OES_packed_depth_stencil = 1
        /// </summary>
        OesPackedDepthStencil = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesRgb8Rgba8 : int
    {
        /// <summary>
        /// Original was GL_RGB8_OES = 0x8051
        /// </summary>
        Rgb8Oes = ((int)0x8051)        ,
        /// <summary>
        /// Original was GL_RGBA8_OES = 0x8058
        /// </summary>
        Rgba8Oes = ((int)0x8058)        ,
        /// <summary>
        /// Original was GL_OES_rgb8_rgba8 = 1
        /// </summary>
        OesRgb8Rgba8 = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesStandardDerivatives : int
    {
        /// <summary>
        /// Original was GL_FRAGMENT_SHADER_DERIVATIVE_HINT_OES = 0x8B8B
        /// </summary>
        FragmentShaderDerivativeHintOes = ((int)0x8B8B)        ,
        /// <summary>
        /// Original was GL_OES_standard_derivatives = 1
        /// </summary>
        OesStandardDerivatives = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesStencil1 : int
    {
        /// <summary>
        /// Original was GL_STENCIL_INDEX1_OES = 0x8D46
        /// </summary>
        StencilIndex1Oes = ((int)0x8D46)        ,
        /// <summary>
        /// Original was GL_OES_stencil1 = 1
        /// </summary>
        OesStencil1 = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesStencil4 : int
    {
        /// <summary>
        /// Original was GL_STENCIL_INDEX4_OES = 0x8D47
        /// </summary>
        StencilIndex4Oes = ((int)0x8D47)        ,
        /// <summary>
        /// Original was GL_OES_stencil4 = 1
        /// </summary>
        OesStencil4 = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesTexture3D : int
    {
        /// <summary>
        /// Original was GL_TEXTURE_BINDING_3D_OES = 0x806A
        /// </summary>
        TextureBinding3DOes = ((int)0x806A)        ,
        /// <summary>
        /// Original was GL_TEXTURE_3D_OES = 0x806F
        /// </summary>
        Texture3DOes = ((int)0x806F)        ,
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_R_OES = 0x8072
        /// </summary>
        TextureWrapROes = ((int)0x8072)        ,
        /// <summary>
        /// Original was GL_MAX_3D_TEXTURE_SIZE_OES = 0x8073
        /// </summary>
        Max3DTextureSizeOes = ((int)0x8073)        ,
        /// <summary>
        /// Original was GL_SAMPLER_3D_OES = 0x8B5F
        /// </summary>
        Sampler3DOes = ((int)0x8B5F)        ,
        /// <summary>
        /// Original was GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_3D_ZOFFSET_OES = 0x8CD4
        /// </summary>
        FramebufferAttachmentTexture3DZoffsetOes = ((int)0x8CD4)        ,
        /// <summary>
        /// Original was GL_OES_texture_3D = 1
        /// </summary>
        OesTexture3D = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesTextureFloat : int
    {
        /// <summary>
        /// Original was GL_OES_texture_float = 1
        /// </summary>
        OesTextureFloat = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesTextureFloatLinear : int
    {
        /// <summary>
        /// Original was GL_OES_texture_float_linear = 1
        /// </summary>
        OesTextureFloatLinear = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesTextureHalfFloat : int
    {
        /// <summary>
        /// Original was GL_HALF_FLOAT_OES = 0x8D61
        /// </summary>
        HalfFloatOes = ((int)0x8D61)        ,
        /// <summary>
        /// Original was GL_OES_texture_half_float = 1
        /// </summary>
        OesTextureHalfFloat = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesTextureHalfFloatLinear : int
    {
        /// <summary>
        /// Original was GL_OES_texture_half_float_linear = 1
        /// </summary>
        OesTextureHalfFloatLinear = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesTextureNpot : int
    {
        /// <summary>
        /// Original was GL_OES_texture_npot = 1
        /// </summary>
        OesTextureNpot = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesVertexArrayObject : int
    {
        /// <summary>
        /// Original was GL_VERTEX_ARRAY_BINDING_OES = 0x85B5
        /// </summary>
        VertexArrayBindingOes = ((int)0x85B5)        ,
        /// <summary>
        /// Original was GL_OES_vertex_array_object = 1
        /// </summary>
        OesVertexArrayObject = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesVertexHalfFloat : int
    {
        /// <summary>
        /// Original was GL_OES_vertex_half_float = 1
        /// </summary>
        OesVertexHalfFloat = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OesVertexType1010102 : int
    {
        /// <summary>
        /// Original was GL_UNSIGNED_INT_10_10_10_2_OES = 0x8DF6
        /// </summary>
        UnsignedInt1010102Oes = ((int)0x8DF6)        ,
        /// <summary>
        /// Original was GL_INT_10_10_10_2_OES = 0x8DF7
        /// </summary>
        Int1010102Oes = ((int)0x8DF7)        ,
        /// <summary>
        /// Original was GL_OES_vertex_type_10_10_10_2 = 1
        /// </summary>
        OesVertexType1010102 = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum OpenGlEsCoreVersions : int
    {
        /// <summary>
        /// Original was GL_ES_VERSION_2_0 = 1
        /// </summary>
        EsVersion20 = ((int)1)        ,
    }

    /// <summary>
    /// Used in GL.CompressedTexSubImage2D, GL.ReadPixels, GL.TexImage2D, GL.TexSubImage2D
    /// </summary>
    public enum PixelFormat : int
    {
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT = 0x1902
        /// </summary>
        DepthComponent = ((int)0x1902)        ,
        /// <summary>
        /// Original was GL_ALPHA = 0x1906
        /// </summary>
        Alpha = ((int)0x1906)        ,
        /// <summary>
        /// Original was GL_RGB = 0x1907
        /// </summary>
        Rgb = ((int)0x1907)        ,
        /// <summary>
        /// Original was GL_RGBA = 0x1908
        /// </summary>
        Rgba = ((int)0x1908)        ,
        /// <summary>
        /// Original was GL_LUMINANCE = 0x1909
        /// </summary>
        Luminance = ((int)0x1909)        ,
        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA = 0x190A
        /// </summary>
        LuminanceAlpha = ((int)0x190A)        ,
    }

    /// <summary>
    /// Used in GL.CompressedTexImage2D, GL.CopyTexImage2D, GL.TexImage2D
    /// </summary>
    public enum PixelInternalFormat : int
    {
        /// <summary>
        /// Original was GL_Alpha = 0X1906
        /// </summary>
        Alpha = ((int)0X1906)        ,
        /// <summary>
        /// Original was GL_Rgb = 0X1907
        /// </summary>
        Rgb = ((int)0X1907)        ,
        /// <summary>
        /// Original was GL_Rgba = 0X1908
        /// </summary>
        Rgba = ((int)0X1908)        ,
        /// <summary>
        /// Original was GL_Luminance = 0X1909
        /// </summary>
        Luminance = ((int)0X1909)        ,
        /// <summary>
        /// Original was GL_LuminanceAlpha = 0X190a
        /// </summary>
        LuminanceAlpha = ((int)0X190a)        ,
    }

    /// <summary>
    /// Used in GL.PixelStore
    /// </summary>
    public enum PixelStoreParameter : int
    {
        /// <summary>
        /// Original was GL_UnpackAlignment = 0X0cf5
        /// </summary>
        UnpackAlignment = ((int)0X0cf5)        ,
        /// <summary>
        /// Original was GL_PackAlignment = 0X0d05
        /// </summary>
        PackAlignment = ((int)0X0d05)        ,
    }

    /// <summary>
    /// Used in GL.ReadPixels, GL.TexImage2D, GL.TexSubImage2D
    /// </summary>
    public enum PixelType : int
    {
        /// <summary>
        /// Original was GL_UnsignedByte = 0X1401
        /// </summary>
        UnsignedByte = ((int)0X1401)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033
        /// </summary>
        UnsignedShort4444 = ((int)0x8033)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034
        /// </summary>
        UnsignedShort5551 = ((int)0x8034)        ,
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_5_6_5 = 0x8363
        /// </summary>
        UnsignedShort565 = ((int)0x8363)        ,
    }

    /// <summary>
    /// Used in GL.GetProgram
    /// </summary>
    public enum ProgramParameter : int
    {
        /// <summary>
        /// Original was GL_DeleteStatus = 0X8b80
        /// </summary>
        DeleteStatus = ((int)0X8b80)        ,
        /// <summary>
        /// Original was GL_LinkStatus = 0X8b82
        /// </summary>
        LinkStatus = ((int)0X8b82)        ,
        /// <summary>
        /// Original was GL_ValidateStatus = 0X8b83
        /// </summary>
        ValidateStatus = ((int)0X8b83)        ,
        /// <summary>
        /// Original was GL_InfoLogLength = 0X8b84
        /// </summary>
        InfoLogLength = ((int)0X8b84)        ,
        /// <summary>
        /// Original was GL_AttachedShaders = 0X8b85
        /// </summary>
        AttachedShaders = ((int)0X8b85)        ,
        /// <summary>
        /// Original was GL_ActiveUniforms = 0X8b86
        /// </summary>
        ActiveUniforms = ((int)0X8b86)        ,
        /// <summary>
        /// Original was GL_ActiveUniformMaxLength = 0X8b87
        /// </summary>
        ActiveUniformMaxLength = ((int)0X8b87)        ,
        /// <summary>
        /// Original was GL_ActiveAttributes = 0X8b89
        /// </summary>
        ActiveAttributes = ((int)0X8b89)        ,
        /// <summary>
        /// Original was GL_ActiveAttributeMaxLength = 0X8b8a
        /// </summary>
        ActiveAttributeMaxLength = ((int)0X8b8a)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum QcomDriverControl : int
    {
        /// <summary>
        /// Original was GL_QCOM_driver_control = 1
        /// </summary>
        QcomDriverControl = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum QcomExtendedGet : int
    {
        /// <summary>
        /// Original was GL_TEXTURE_WIDTH_QCOM = 0x8BD2
        /// </summary>
        TextureWidthQcom = ((int)0x8BD2)        ,
        /// <summary>
        /// Original was GL_TEXTURE_HEIGHT_QCOM = 0x8BD3
        /// </summary>
        TextureHeightQcom = ((int)0x8BD3)        ,
        /// <summary>
        /// Original was GL_TEXTURE_DEPTH_QCOM = 0x8BD4
        /// </summary>
        TextureDepthQcom = ((int)0x8BD4)        ,
        /// <summary>
        /// Original was GL_TEXTURE_INTERNAL_FORMAT_QCOM = 0x8BD5
        /// </summary>
        TextureInternalFormatQcom = ((int)0x8BD5)        ,
        /// <summary>
        /// Original was GL_TEXTURE_FORMAT_QCOM = 0x8BD6
        /// </summary>
        TextureFormatQcom = ((int)0x8BD6)        ,
        /// <summary>
        /// Original was GL_TEXTURE_TYPE_QCOM = 0x8BD7
        /// </summary>
        TextureTypeQcom = ((int)0x8BD7)        ,
        /// <summary>
        /// Original was GL_TEXTURE_IMAGE_VALID_QCOM = 0x8BD8
        /// </summary>
        TextureImageValidQcom = ((int)0x8BD8)        ,
        /// <summary>
        /// Original was GL_TEXTURE_NUM_LEVELS_QCOM = 0x8BD9
        /// </summary>
        TextureNumLevelsQcom = ((int)0x8BD9)        ,
        /// <summary>
        /// Original was GL_TEXTURE_TARGET_QCOM = 0x8BDA
        /// </summary>
        TextureTargetQcom = ((int)0x8BDA)        ,
        /// <summary>
        /// Original was GL_TEXTURE_OBJECT_VALID_QCOM = 0x8BDB
        /// </summary>
        TextureObjectValidQcom = ((int)0x8BDB)        ,
        /// <summary>
        /// Original was GL_STATE_RESTORE = 0x8BDC
        /// </summary>
        StateRestore = ((int)0x8BDC)        ,
        /// <summary>
        /// Original was GL_QCOM_extended_get = 1
        /// </summary>
        QcomExtendedGet = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum QcomExtendedGet2 : int
    {
        /// <summary>
        /// Original was GL_QCOM_extended_get2 = 1
        /// </summary>
        QcomExtendedGet2 = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum QcomPerfmonGlobalMode : int
    {
        /// <summary>
        /// Original was GL_PERFMON_GLOBAL_MODE_QCOM = 0x8FA0
        /// </summary>
        PerfmonGlobalModeQcom = ((int)0x8FA0)        ,
        /// <summary>
        /// Original was GL_QCOM_perfmon_global_mode = 1
        /// </summary>
        QcomPerfmonGlobalMode = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum QcomTiledRendering : int
    {
        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT0_QCOM = 0x00000001
        /// </summary>
        ColorBufferBit0Qcom = ((int)0x00000001)        ,
        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT1_QCOM = 0x00000002
        /// </summary>
        ColorBufferBit1Qcom = ((int)0x00000002)        ,
        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT2_QCOM = 0x00000004
        /// </summary>
        ColorBufferBit2Qcom = ((int)0x00000004)        ,
        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT3_QCOM = 0x00000008
        /// </summary>
        ColorBufferBit3Qcom = ((int)0x00000008)        ,
        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT4_QCOM = 0x00000010
        /// </summary>
        ColorBufferBit4Qcom = ((int)0x00000010)        ,
        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT5_QCOM = 0x00000020
        /// </summary>
        ColorBufferBit5Qcom = ((int)0x00000020)        ,
        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT6_QCOM = 0x00000040
        /// </summary>
        ColorBufferBit6Qcom = ((int)0x00000040)        ,
        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT7_QCOM = 0x00000080
        /// </summary>
        ColorBufferBit7Qcom = ((int)0x00000080)        ,
        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT0_QCOM = 0x00000100
        /// </summary>
        DepthBufferBit0Qcom = ((int)0x00000100)        ,
        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT1_QCOM = 0x00000200
        /// </summary>
        DepthBufferBit1Qcom = ((int)0x00000200)        ,
        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT2_QCOM = 0x00000400
        /// </summary>
        DepthBufferBit2Qcom = ((int)0x00000400)        ,
        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT3_QCOM = 0x00000800
        /// </summary>
        DepthBufferBit3Qcom = ((int)0x00000800)        ,
        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT4_QCOM = 0x00001000
        /// </summary>
        DepthBufferBit4Qcom = ((int)0x00001000)        ,
        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT5_QCOM = 0x00002000
        /// </summary>
        DepthBufferBit5Qcom = ((int)0x00002000)        ,
        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT6_QCOM = 0x00004000
        /// </summary>
        DepthBufferBit6Qcom = ((int)0x00004000)        ,
        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT7_QCOM = 0x00008000
        /// </summary>
        DepthBufferBit7Qcom = ((int)0x00008000)        ,
        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT0_QCOM = 0x00010000
        /// </summary>
        StencilBufferBit0Qcom = ((int)0x00010000)        ,
        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT1_QCOM = 0x00020000
        /// </summary>
        StencilBufferBit1Qcom = ((int)0x00020000)        ,
        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT2_QCOM = 0x00040000
        /// </summary>
        StencilBufferBit2Qcom = ((int)0x00040000)        ,
        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT3_QCOM = 0x00080000
        /// </summary>
        StencilBufferBit3Qcom = ((int)0x00080000)        ,
        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT4_QCOM = 0x00100000
        /// </summary>
        StencilBufferBit4Qcom = ((int)0x00100000)        ,
        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT5_QCOM = 0x00200000
        /// </summary>
        StencilBufferBit5Qcom = ((int)0x00200000)        ,
        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT6_QCOM = 0x00400000
        /// </summary>
        StencilBufferBit6Qcom = ((int)0x00400000)        ,
        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT7_QCOM = 0x00800000
        /// </summary>
        StencilBufferBit7Qcom = ((int)0x00800000)        ,
        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT0_QCOM = 0x01000000
        /// </summary>
        MultisampleBufferBit0Qcom = ((int)0x01000000)        ,
        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT1_QCOM = 0x02000000
        /// </summary>
        MultisampleBufferBit1Qcom = ((int)0x02000000)        ,
        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT2_QCOM = 0x04000000
        /// </summary>
        MultisampleBufferBit2Qcom = ((int)0x04000000)        ,
        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT3_QCOM = 0x08000000
        /// </summary>
        MultisampleBufferBit3Qcom = ((int)0x08000000)        ,
        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT4_QCOM = 0x10000000
        /// </summary>
        MultisampleBufferBit4Qcom = ((int)0x10000000)        ,
        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT5_QCOM = 0x20000000
        /// </summary>
        MultisampleBufferBit5Qcom = ((int)0x20000000)        ,
        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT6_QCOM = 0x40000000
        /// </summary>
        MultisampleBufferBit6Qcom = ((int)0x40000000)        ,
        /// <summary>
        /// Original was GL_MULTISAMPLE_BUFFER_BIT7_QCOM = 0x80000000
        /// </summary>
        MultisampleBufferBit7Qcom = unchecked((int)0x80000000)        ,
        /// <summary>
        /// Original was GL_QCOM_tiled_rendering = 1
        /// </summary>
        QcomTiledRendering = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum QcomWriteonlyRendering : int
    {
        /// <summary>
        /// Original was GL_WRITEONLY_RENDERING_QCOM = 0x8823
        /// </summary>
        WriteonlyRenderingQcom = ((int)0x8823)        ,
        /// <summary>
        /// Original was GL_QCOM_writeonly_rendering = 1
        /// </summary>
        QcomWriteonlyRendering = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ReadFormat : int
    {
        /// <summary>
        /// Original was GL_IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A
        /// </summary>
        ImplementationColorReadType = ((int)0x8B9A)        ,
        /// <summary>
        /// Original was GL_IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B
        /// </summary>
        ImplementationColorReadFormat = ((int)0x8B9B)        ,
    }

    /// <summary>
    /// Used in GL.RenderbufferStorage
    /// </summary>
    public enum RenderbufferInternalFormat : int
    {
        /// <summary>
        /// Original was GL_Rgba4 = 0X8056
        /// </summary>
        Rgba4 = ((int)0X8056)        ,
        /// <summary>
        /// Original was GL_Rgb5A1 = 0X8057
        /// </summary>
        Rgb5A1 = ((int)0X8057)        ,
        /// <summary>
        /// Original was GL_DepthComponent16 = 0X81a5
        /// </summary>
        DepthComponent16 = ((int)0X81a5)        ,
        /// <summary>
        /// Original was GL_StencilIndex8 = 0X8d48
        /// </summary>
        StencilIndex8 = ((int)0X8d48)        ,
        /// <summary>
        /// Original was GL_Rgb565 = 0X8d62
        /// </summary>
        Rgb565 = ((int)0X8d62)        ,
    }

    /// <summary>
    /// Used in GL.GetRenderbufferParameter
    /// </summary>
    public enum RenderbufferParameterName : int
    {
        /// <summary>
        /// Original was GL_RenderbufferWidth = 0X8d42
        /// </summary>
        RenderbufferWidth = ((int)0X8d42)        ,
        /// <summary>
        /// Original was GL_RenderbufferHeight = 0X8d43
        /// </summary>
        RenderbufferHeight = ((int)0X8d43)        ,
        /// <summary>
        /// Original was GL_RenderbufferInternalFormat = 0X8d44
        /// </summary>
        RenderbufferInternalFormat = ((int)0X8d44)        ,
        /// <summary>
        /// Original was GL_RenderbufferRedSize = 0X8d50
        /// </summary>
        RenderbufferRedSize = ((int)0X8d50)        ,
        /// <summary>
        /// Original was GL_RenderbufferGreenSize = 0X8d51
        /// </summary>
        RenderbufferGreenSize = ((int)0X8d51)        ,
        /// <summary>
        /// Original was GL_RenderbufferBlueSize = 0X8d52
        /// </summary>
        RenderbufferBlueSize = ((int)0X8d52)        ,
        /// <summary>
        /// Original was GL_RenderbufferAlphaSize = 0X8d53
        /// </summary>
        RenderbufferAlphaSize = ((int)0X8d53)        ,
        /// <summary>
        /// Original was GL_RenderbufferDepthSize = 0X8d54
        /// </summary>
        RenderbufferDepthSize = ((int)0X8d54)        ,
        /// <summary>
        /// Original was GL_RenderbufferStencilSize = 0X8d55
        /// </summary>
        RenderbufferStencilSize = ((int)0X8d55)        ,
    }

    /// <summary>
    /// Used in GL.BindRenderbuffer, GL.FramebufferRenderbuffer, GL.GetRenderbufferParameter, GL.RenderbufferStorage
    /// </summary>
    public enum RenderbufferTarget : int
    {
        /// <summary>
        /// Original was GL_Renderbuffer = 0X8d41
        /// </summary>
        Renderbuffer = ((int)0X8d41)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SeparateBlendFunctions : int
    {
        /// <summary>
        /// Original was GL_CONSTANT_COLOR = 0x8001
        /// </summary>
        ConstantColor = ((int)0x8001)        ,
        /// <summary>
        /// Original was GL_ONE_MINUS_CONSTANT_COLOR = 0x8002
        /// </summary>
        OneMinusConstantColor = ((int)0x8002)        ,
        /// <summary>
        /// Original was GL_CONSTANT_ALPHA = 0x8003
        /// </summary>
        ConstantAlpha = ((int)0x8003)        ,
        /// <summary>
        /// Original was GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004
        /// </summary>
        OneMinusConstantAlpha = ((int)0x8004)        ,
        /// <summary>
        /// Original was GL_BLEND_COLOR = 0x8005
        /// </summary>
        BlendColor = ((int)0x8005)        ,
        /// <summary>
        /// Original was GL_BLEND_DST_RGB = 0x80C8
        /// </summary>
        BlendDstRgb = ((int)0x80C8)        ,
        /// <summary>
        /// Original was GL_BLEND_SRC_RGB = 0x80C9
        /// </summary>
        BlendSrcRgb = ((int)0x80C9)        ,
        /// <summary>
        /// Original was GL_BLEND_DST_ALPHA = 0x80CA
        /// </summary>
        BlendDstAlpha = ((int)0x80CA)        ,
        /// <summary>
        /// Original was GL_BLEND_SRC_ALPHA = 0x80CB
        /// </summary>
        BlendSrcAlpha = ((int)0x80CB)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ShaderBinary : int
    {
        /// <summary>
        /// Original was GL_SHADER_BINARY_FORMATS = 0x8DF8
        /// </summary>
        ShaderBinaryFormats = ((int)0x8DF8)        ,
        /// <summary>
        /// Original was GL_NUM_SHADER_BINARY_FORMATS = 0x8DF9
        /// </summary>
        NumShaderBinaryFormats = ((int)0x8DF9)        ,
    }

    /// <summary>
    /// Used in GL.ShaderBinary
    /// </summary>
    public enum ShaderBinaryFormat : int
    {
    }

    /// <summary>
    /// Used in GL.GetShader
    /// </summary>
    public enum ShaderParameter : int
    {
        /// <summary>
        /// Original was GL_ShaderType = 0X8b4f
        /// </summary>
        ShaderType = ((int)0X8b4f)        ,
        /// <summary>
        /// Original was GL_DeleteStatus = 0X8b80
        /// </summary>
        DeleteStatus = ((int)0X8b80)        ,
        /// <summary>
        /// Original was GL_CompileStatus = 0X8b81
        /// </summary>
        CompileStatus = ((int)0X8b81)        ,
        /// <summary>
        /// Original was GL_InfoLogLength = 0X8b84
        /// </summary>
        InfoLogLength = ((int)0X8b84)        ,
        /// <summary>
        /// Original was GL_ShaderSourceLength = 0X8b88
        /// </summary>
        ShaderSourceLength = ((int)0X8b88)        ,
    }

    /// <summary>
    /// Used in GL.GetShaderPrecisionFormat
    /// </summary>
    public enum ShaderPrecision : int
    {
        /// <summary>
        /// Original was GL_LowFloat = 0X8df0
        /// </summary>
        LowFloat = ((int)0X8df0)        ,
        /// <summary>
        /// Original was GL_MediumFloat = 0X8df1
        /// </summary>
        MediumFloat = ((int)0X8df1)        ,
        /// <summary>
        /// Original was GL_HighFloat = 0X8df2
        /// </summary>
        HighFloat = ((int)0X8df2)        ,
        /// <summary>
        /// Original was GL_LowInt = 0X8df3
        /// </summary>
        LowInt = ((int)0X8df3)        ,
        /// <summary>
        /// Original was GL_MediumInt = 0X8df4
        /// </summary>
        MediumInt = ((int)0X8df4)        ,
        /// <summary>
        /// Original was GL_HighInt = 0X8df5
        /// </summary>
        HighInt = ((int)0X8df5)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ShaderPrecisionSpecifiedTypes : int
    {
        /// <summary>
        /// Original was GL_LOW_FLOAT = 0x8DF0
        /// </summary>
        LowFloat = ((int)0x8DF0)        ,
        /// <summary>
        /// Original was GL_MEDIUM_FLOAT = 0x8DF1
        /// </summary>
        MediumFloat = ((int)0x8DF1)        ,
        /// <summary>
        /// Original was GL_HIGH_FLOAT = 0x8DF2
        /// </summary>
        HighFloat = ((int)0x8DF2)        ,
        /// <summary>
        /// Original was GL_LOW_INT = 0x8DF3
        /// </summary>
        LowInt = ((int)0x8DF3)        ,
        /// <summary>
        /// Original was GL_MEDIUM_INT = 0x8DF4
        /// </summary>
        MediumInt = ((int)0x8DF4)        ,
        /// <summary>
        /// Original was GL_HIGH_INT = 0x8DF5
        /// </summary>
        HighInt = ((int)0x8DF5)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Shaders : int
    {
        /// <summary>
        /// Original was GL_MAX_VERTEX_ATTRIBS = 0x8869
        /// </summary>
        MaxVertexAttribs = ((int)0x8869)        ,
        /// <summary>
        /// Original was GL_MAX_TEXTURE_IMAGE_UNITS = 0x8872
        /// </summary>
        MaxTextureImageUnits = ((int)0x8872)        ,
        /// <summary>
        /// Original was GL_FRAGMENT_SHADER = 0x8B30
        /// </summary>
        FragmentShader = ((int)0x8B30)        ,
        /// <summary>
        /// Original was GL_VERTEX_SHADER = 0x8B31
        /// </summary>
        VertexShader = ((int)0x8B31)        ,
        /// <summary>
        /// Original was GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C
        /// </summary>
        MaxVertexTextureImageUnits = ((int)0x8B4C)        ,
        /// <summary>
        /// Original was GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D
        /// </summary>
        MaxCombinedTextureImageUnits = ((int)0x8B4D)        ,
        /// <summary>
        /// Original was GL_SHADER_TYPE = 0x8B4F
        /// </summary>
        ShaderType = ((int)0x8B4F)        ,
        /// <summary>
        /// Original was GL_DELETE_STATUS = 0x8B80
        /// </summary>
        DeleteStatus = ((int)0x8B80)        ,
        /// <summary>
        /// Original was GL_LINK_STATUS = 0x8B82
        /// </summary>
        LinkStatus = ((int)0x8B82)        ,
        /// <summary>
        /// Original was GL_VALIDATE_STATUS = 0x8B83
        /// </summary>
        ValidateStatus = ((int)0x8B83)        ,
        /// <summary>
        /// Original was GL_ATTACHED_SHADERS = 0x8B85
        /// </summary>
        AttachedShaders = ((int)0x8B85)        ,
        /// <summary>
        /// Original was GL_ACTIVE_UNIFORMS = 0x8B86
        /// </summary>
        ActiveUniforms = ((int)0x8B86)        ,
        /// <summary>
        /// Original was GL_ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87
        /// </summary>
        ActiveUniformMaxLength = ((int)0x8B87)        ,
        /// <summary>
        /// Original was GL_ACTIVE_ATTRIBUTES = 0x8B89
        /// </summary>
        ActiveAttributes = ((int)0x8B89)        ,
        /// <summary>
        /// Original was GL_ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A
        /// </summary>
        ActiveAttributeMaxLength = ((int)0x8B8A)        ,
        /// <summary>
        /// Original was GL_SHADING_LANGUAGE_VERSION = 0x8B8C
        /// </summary>
        ShadingLanguageVersion = ((int)0x8B8C)        ,
        /// <summary>
        /// Original was GL_CURRENT_PROGRAM = 0x8B8D
        /// </summary>
        CurrentProgram = ((int)0x8B8D)        ,
        /// <summary>
        /// Original was GL_MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB
        /// </summary>
        MaxVertexUniformVectors = ((int)0x8DFB)        ,
        /// <summary>
        /// Original was GL_MAX_VARYING_VECTORS = 0x8DFC
        /// </summary>
        MaxVaryingVectors = ((int)0x8DFC)        ,
        /// <summary>
        /// Original was GL_MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD
        /// </summary>
        MaxFragmentUniformVectors = ((int)0x8DFD)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ShaderSource : int
    {
        /// <summary>
        /// Original was GL_COMPILE_STATUS = 0x8B81
        /// </summary>
        CompileStatus = ((int)0x8B81)        ,
        /// <summary>
        /// Original was GL_INFO_LOG_LENGTH = 0x8B84
        /// </summary>
        InfoLogLength = ((int)0x8B84)        ,
        /// <summary>
        /// Original was GL_SHADER_SOURCE_LENGTH = 0x8B88
        /// </summary>
        ShaderSourceLength = ((int)0x8B88)        ,
        /// <summary>
        /// Original was GL_SHADER_COMPILER = 0x8DFA
        /// </summary>
        ShaderCompiler = ((int)0x8DFA)        ,
    }

    /// <summary>
    /// Used in GL.CreateShader, GL.GetShaderPrecisionFormat
    /// </summary>
    public enum ShaderType : int
    {
        /// <summary>
        /// Original was GL_FragmentShader = 0X8b30
        /// </summary>
        FragmentShader = ((int)0X8b30)        ,
        /// <summary>
        /// Original was GL_VertexShader = 0X8b31
        /// </summary>
        VertexShader = ((int)0X8b31)        ,
    }

    /// <summary>
    /// Used in GL.StencilFunc, GL.StencilFuncSeparate
    /// </summary>
    public enum StencilFunction : int
    {
        /// <summary>
        /// Original was GL_NEVER = 0x0200
        /// </summary>
        Never = ((int)0x0200)        ,
        /// <summary>
        /// Original was GL_LESS = 0x0201
        /// </summary>
        Less = ((int)0x0201)        ,
        /// <summary>
        /// Original was GL_EQUAL = 0x0202
        /// </summary>
        Equal = ((int)0x0202)        ,
        /// <summary>
        /// Original was GL_LEQUAL = 0x0203
        /// </summary>
        Lequal = ((int)0x0203)        ,
        /// <summary>
        /// Original was GL_GREATER = 0x0204
        /// </summary>
        Greater = ((int)0x0204)        ,
        /// <summary>
        /// Original was GL_NOTEQUAL = 0x0205
        /// </summary>
        Notequal = ((int)0x0205)        ,
        /// <summary>
        /// Original was GL_GEQUAL = 0x0206
        /// </summary>
        Gequal = ((int)0x0206)        ,
        /// <summary>
        /// Original was GL_ALWAYS = 0x0207
        /// </summary>
        Always = ((int)0x0207)        ,
    }

    /// <summary>
    /// Used in GL.StencilOp, GL.StencilOpSeparate
    /// </summary>
    public enum StencilOp : int
    {
        /// <summary>
        /// Original was GL_Zero = 0X0000
        /// </summary>
        Zero = ((int)0X0000)        ,
        /// <summary>
        /// Original was GL_INVERT = 0x150A
        /// </summary>
        Invert = ((int)0x150A)        ,
        /// <summary>
        /// Original was GL_KEEP = 0x1E00
        /// </summary>
        Keep = ((int)0x1E00)        ,
        /// <summary>
        /// Original was GL_REPLACE = 0x1E01
        /// </summary>
        Replace = ((int)0x1E01)        ,
        /// <summary>
        /// Original was GL_INCR = 0x1E02
        /// </summary>
        Incr = ((int)0x1E02)        ,
        /// <summary>
        /// Original was GL_DECR = 0x1E03
        /// </summary>
        Decr = ((int)0x1E03)        ,
        /// <summary>
        /// Original was GL_INCR_WRAP = 0x8507
        /// </summary>
        IncrWrap = ((int)0x8507)        ,
        /// <summary>
        /// Original was GL_DECR_WRAP = 0x8508
        /// </summary>
        DecrWrap = ((int)0x8508)        ,
    }

    /// <summary>
    /// Used in GL.GetString
    /// </summary>
    public enum StringName : int
    {
        /// <summary>
        /// Original was GL_VENDOR = 0x1F00
        /// </summary>
        Vendor = ((int)0x1F00)        ,
        /// <summary>
        /// Original was GL_RENDERER = 0x1F01
        /// </summary>
        Renderer = ((int)0x1F01)        ,
        /// <summary>
        /// Original was GL_VERSION = 0x1F02
        /// </summary>
        Version = ((int)0x1F02)        ,
        /// <summary>
        /// Original was GL_EXTENSIONS = 0x1F03
        /// </summary>
        Extensions = ((int)0x1F03)        ,
        /// <summary>
        /// Original was GL_ShadingLanguageVersion = 0X8b8c
        /// </summary>
        ShadingLanguageVersion = ((int)0X8b8c)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureMagFilter : int
    {
        /// <summary>
        /// Original was GL_NEAREST = 0x2600
        /// </summary>
        Nearest = ((int)0x2600)        ,
        /// <summary>
        /// Original was GL_LINEAR = 0x2601
        /// </summary>
        Linear = ((int)0x2601)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureMinFilter : int
    {
        /// <summary>
        /// Original was GL_Nearest = 0X2600
        /// </summary>
        Nearest = ((int)0X2600)        ,
        /// <summary>
        /// Original was GL_Linear = 0X2601
        /// </summary>
        Linear = ((int)0X2601)        ,
        /// <summary>
        /// Original was GL_NEAREST_MIPMAP_NEAREST = 0x2700
        /// </summary>
        NearestMipmapNearest = ((int)0x2700)        ,
        /// <summary>
        /// Original was GL_LINEAR_MIPMAP_NEAREST = 0x2701
        /// </summary>
        LinearMipmapNearest = ((int)0x2701)        ,
        /// <summary>
        /// Original was GL_NEAREST_MIPMAP_LINEAR = 0x2702
        /// </summary>
        NearestMipmapLinear = ((int)0x2702)        ,
        /// <summary>
        /// Original was GL_LINEAR_MIPMAP_LINEAR = 0x2703
        /// </summary>
        LinearMipmapLinear = ((int)0x2703)        ,
    }

    /// <summary>
    /// Used in GL.TexParameter
    /// </summary>
    public enum TextureParameterName : int
    {
        /// <summary>
        /// Original was GL_TEXTURE_MAG_FILTER = 0x2800
        /// </summary>
        TextureMagFilter = ((int)0x2800)        ,
        /// <summary>
        /// Original was GL_TEXTURE_MIN_FILTER = 0x2801
        /// </summary>
        TextureMinFilter = ((int)0x2801)        ,
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_S = 0x2802
        /// </summary>
        TextureWrapS = ((int)0x2802)        ,
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_T = 0x2803
        /// </summary>
        TextureWrapT = ((int)0x2803)        ,
    }

    /// <summary>
    /// Used in GL.BindTexture, GL.CompressedTexImage2D, GL.CompressedTexSubImage2D, GL.CopyTexImage2D, GL.CopyTexSubImage2D, GL.FramebufferTexture2D, GL.GenerateMipmap, GL.GetTexParameter, GL.TexImage2D, GL.TexParameter, GL.TexSubImage2D
    /// </summary>
    public enum TextureTarget : int
    {
        /// <summary>
        /// Original was GL_Texture2D = 0X0de1
        /// </summary>
        Texture2D = ((int)0X0de1)        ,
        /// <summary>
        /// Original was GL_TEXTURE = 0x1702
        /// </summary>
        Texture = ((int)0x1702)        ,
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP = 0x8513
        /// </summary>
        TextureCubeMap = ((int)0x8513)        ,
        /// <summary>
        /// Original was GL_TEXTURE_BINDING_CUBE_MAP = 0x8514
        /// </summary>
        TextureBindingCubeMap = ((int)0x8514)        ,
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515
        /// </summary>
        TextureCubeMapPositiveX = ((int)0x8515)        ,
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516
        /// </summary>
        TextureCubeMapNegativeX = ((int)0x8516)        ,
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517
        /// </summary>
        TextureCubeMapPositiveY = ((int)0x8517)        ,
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518
        /// </summary>
        TextureCubeMapNegativeY = ((int)0x8518)        ,
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519
        /// </summary>
        TextureCubeMapPositiveZ = ((int)0x8519)        ,
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A
        /// </summary>
        TextureCubeMapNegativeZ = ((int)0x851A)        ,
        /// <summary>
        /// Original was GL_MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C
        /// </summary>
        MaxCubeMapTextureSize = ((int)0x851C)        ,
    }

    /// <summary>
    /// Used in GL.ActiveTexture
    /// </summary>
    public enum TextureUnit : int
    {
        /// <summary>
        /// Original was GL_TEXTURE0 = 0x84C0
        /// </summary>
        Texture0 = ((int)0x84C0)        ,
        /// <summary>
        /// Original was GL_TEXTURE1 = 0x84C1
        /// </summary>
        Texture1 = ((int)0x84C1)        ,
        /// <summary>
        /// Original was GL_TEXTURE2 = 0x84C2
        /// </summary>
        Texture2 = ((int)0x84C2)        ,
        /// <summary>
        /// Original was GL_TEXTURE3 = 0x84C3
        /// </summary>
        Texture3 = ((int)0x84C3)        ,
        /// <summary>
        /// Original was GL_TEXTURE4 = 0x84C4
        /// </summary>
        Texture4 = ((int)0x84C4)        ,
        /// <summary>
        /// Original was GL_TEXTURE5 = 0x84C5
        /// </summary>
        Texture5 = ((int)0x84C5)        ,
        /// <summary>
        /// Original was GL_TEXTURE6 = 0x84C6
        /// </summary>
        Texture6 = ((int)0x84C6)        ,
        /// <summary>
        /// Original was GL_TEXTURE7 = 0x84C7
        /// </summary>
        Texture7 = ((int)0x84C7)        ,
        /// <summary>
        /// Original was GL_TEXTURE8 = 0x84C8
        /// </summary>
        Texture8 = ((int)0x84C8)        ,
        /// <summary>
        /// Original was GL_TEXTURE9 = 0x84C9
        /// </summary>
        Texture9 = ((int)0x84C9)        ,
        /// <summary>
        /// Original was GL_TEXTURE10 = 0x84CA
        /// </summary>
        Texture10 = ((int)0x84CA)        ,
        /// <summary>
        /// Original was GL_TEXTURE11 = 0x84CB
        /// </summary>
        Texture11 = ((int)0x84CB)        ,
        /// <summary>
        /// Original was GL_TEXTURE12 = 0x84CC
        /// </summary>
        Texture12 = ((int)0x84CC)        ,
        /// <summary>
        /// Original was GL_TEXTURE13 = 0x84CD
        /// </summary>
        Texture13 = ((int)0x84CD)        ,
        /// <summary>
        /// Original was GL_TEXTURE14 = 0x84CE
        /// </summary>
        Texture14 = ((int)0x84CE)        ,
        /// <summary>
        /// Original was GL_TEXTURE15 = 0x84CF
        /// </summary>
        Texture15 = ((int)0x84CF)        ,
        /// <summary>
        /// Original was GL_TEXTURE16 = 0x84D0
        /// </summary>
        Texture16 = ((int)0x84D0)        ,
        /// <summary>
        /// Original was GL_TEXTURE17 = 0x84D1
        /// </summary>
        Texture17 = ((int)0x84D1)        ,
        /// <summary>
        /// Original was GL_TEXTURE18 = 0x84D2
        /// </summary>
        Texture18 = ((int)0x84D2)        ,
        /// <summary>
        /// Original was GL_TEXTURE19 = 0x84D3
        /// </summary>
        Texture19 = ((int)0x84D3)        ,
        /// <summary>
        /// Original was GL_TEXTURE20 = 0x84D4
        /// </summary>
        Texture20 = ((int)0x84D4)        ,
        /// <summary>
        /// Original was GL_TEXTURE21 = 0x84D5
        /// </summary>
        Texture21 = ((int)0x84D5)        ,
        /// <summary>
        /// Original was GL_TEXTURE22 = 0x84D6
        /// </summary>
        Texture22 = ((int)0x84D6)        ,
        /// <summary>
        /// Original was GL_TEXTURE23 = 0x84D7
        /// </summary>
        Texture23 = ((int)0x84D7)        ,
        /// <summary>
        /// Original was GL_TEXTURE24 = 0x84D8
        /// </summary>
        Texture24 = ((int)0x84D8)        ,
        /// <summary>
        /// Original was GL_TEXTURE25 = 0x84D9
        /// </summary>
        Texture25 = ((int)0x84D9)        ,
        /// <summary>
        /// Original was GL_TEXTURE26 = 0x84DA
        /// </summary>
        Texture26 = ((int)0x84DA)        ,
        /// <summary>
        /// Original was GL_TEXTURE27 = 0x84DB
        /// </summary>
        Texture27 = ((int)0x84DB)        ,
        /// <summary>
        /// Original was GL_TEXTURE28 = 0x84DC
        /// </summary>
        Texture28 = ((int)0x84DC)        ,
        /// <summary>
        /// Original was GL_TEXTURE29 = 0x84DD
        /// </summary>
        Texture29 = ((int)0x84DD)        ,
        /// <summary>
        /// Original was GL_TEXTURE30 = 0x84DE
        /// </summary>
        Texture30 = ((int)0x84DE)        ,
        /// <summary>
        /// Original was GL_TEXTURE31 = 0x84DF
        /// </summary>
        Texture31 = ((int)0x84DF)        ,
        /// <summary>
        /// Original was GL_ACTIVE_TEXTURE = 0x84E0
        /// </summary>
        ActiveTexture = ((int)0x84E0)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TextureWrapMode : int
    {
        /// <summary>
        /// Original was GL_REPEAT = 0x2901
        /// </summary>
        Repeat = ((int)0x2901)        ,
        /// <summary>
        /// Original was GL_CLAMP_TO_EDGE = 0x812F
        /// </summary>
        ClampToEdge = ((int)0x812F)        ,
        /// <summary>
        /// Original was GL_MIRRORED_REPEAT = 0x8370
        /// </summary>
        MirroredRepeat = ((int)0x8370)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum UniformTypes : int
    {
        /// <summary>
        /// Original was GL_FLOAT_VEC2 = 0x8B50
        /// </summary>
        FloatVec2 = ((int)0x8B50)        ,
        /// <summary>
        /// Original was GL_FLOAT_VEC3 = 0x8B51
        /// </summary>
        FloatVec3 = ((int)0x8B51)        ,
        /// <summary>
        /// Original was GL_FLOAT_VEC4 = 0x8B52
        /// </summary>
        FloatVec4 = ((int)0x8B52)        ,
        /// <summary>
        /// Original was GL_INT_VEC2 = 0x8B53
        /// </summary>
        IntVec2 = ((int)0x8B53)        ,
        /// <summary>
        /// Original was GL_INT_VEC3 = 0x8B54
        /// </summary>
        IntVec3 = ((int)0x8B54)        ,
        /// <summary>
        /// Original was GL_INT_VEC4 = 0x8B55
        /// </summary>
        IntVec4 = ((int)0x8B55)        ,
        /// <summary>
        /// Original was GL_BOOL = 0x8B56
        /// </summary>
        Bool = ((int)0x8B56)        ,
        /// <summary>
        /// Original was GL_BOOL_VEC2 = 0x8B57
        /// </summary>
        BoolVec2 = ((int)0x8B57)        ,
        /// <summary>
        /// Original was GL_BOOL_VEC3 = 0x8B58
        /// </summary>
        BoolVec3 = ((int)0x8B58)        ,
        /// <summary>
        /// Original was GL_BOOL_VEC4 = 0x8B59
        /// </summary>
        BoolVec4 = ((int)0x8B59)        ,
        /// <summary>
        /// Original was GL_FLOAT_MAT2 = 0x8B5A
        /// </summary>
        FloatMat2 = ((int)0x8B5A)        ,
        /// <summary>
        /// Original was GL_FLOAT_MAT3 = 0x8B5B
        /// </summary>
        FloatMat3 = ((int)0x8B5B)        ,
        /// <summary>
        /// Original was GL_FLOAT_MAT4 = 0x8B5C
        /// </summary>
        FloatMat4 = ((int)0x8B5C)        ,
        /// <summary>
        /// Original was GL_SAMPLER_2D = 0x8B5E
        /// </summary>
        Sampler2D = ((int)0x8B5E)        ,
        /// <summary>
        /// Original was GL_SAMPLER_CUBE = 0x8B60
        /// </summary>
        SamplerCube = ((int)0x8B60)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Unknown : int
    {
        /// <summary>
        /// Original was GL_EXT_multi_draw_arrays = 1
        /// </summary>
        ExtMultiDrawArrays = ((int)1)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum VertexArrays : int
    {
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622
        /// </summary>
        VertexAttribArrayEnabled = ((int)0x8622)        ,
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_SIZE = 0x8623
        /// </summary>
        VertexAttribArraySize = ((int)0x8623)        ,
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624
        /// </summary>
        VertexAttribArrayStride = ((int)0x8624)        ,
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_TYPE = 0x8625
        /// </summary>
        VertexAttribArrayType = ((int)0x8625)        ,
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_POINTER = 0x8645
        /// </summary>
        VertexAttribArrayPointer = ((int)0x8645)        ,
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A
        /// </summary>
        VertexAttribArrayNormalized = ((int)0x886A)        ,
        /// <summary>
        /// Original was GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F
        /// </summary>
        VertexAttribArrayBufferBinding = ((int)0x889F)        ,
    }

    /// <summary>
    /// Used in GL.GetVertexAttrib
    /// </summary>
    public enum VertexAttribParameter : int
    {
        /// <summary>
        /// Original was GL_VertexAttribArrayEnabled = 0X8622
        /// </summary>
        VertexAttribArrayEnabled = ((int)0X8622)        ,
        /// <summary>
        /// Original was GL_VertexAttribArraySize = 0X8623
        /// </summary>
        VertexAttribArraySize = ((int)0X8623)        ,
        /// <summary>
        /// Original was GL_VertexAttribArrayStride = 0X8624
        /// </summary>
        VertexAttribArrayStride = ((int)0X8624)        ,
        /// <summary>
        /// Original was GL_VertexAttribArrayType = 0X8625
        /// </summary>
        VertexAttribArrayType = ((int)0X8625)        ,
        /// <summary>
        /// Original was GL_CurrentVertexAttrib = 0X8626
        /// </summary>
        CurrentVertexAttrib = ((int)0X8626)        ,
        /// <summary>
        /// Original was GL_VertexAttribArrayNormalized = 0X886a
        /// </summary>
        VertexAttribArrayNormalized = ((int)0X886a)        ,
        /// <summary>
        /// Original was GL_VertexAttribArrayBufferBinding = 0X889f
        /// </summary>
        VertexAttribArrayBufferBinding = ((int)0X889f)        ,
    }

    /// <summary>
    /// Used in GL.GetVertexAttribPointer
    /// </summary>
    public enum VertexAttribPointerParameter : int
    {
        /// <summary>
        /// Original was GL_VertexAttribArrayPointer = 0X8645
        /// </summary>
        VertexAttribArrayPointer = ((int)0X8645)        ,
    }

    /// <summary>
    /// Used in GL.VertexAttribPointer
    /// </summary>
    public enum VertexAttribPointerType : int
    {
        /// <summary>
        /// Original was GL_Byte = 0X1400
        /// </summary>
        Byte = ((int)0X1400)        ,
        /// <summary>
        /// Original was GL_UnsignedByte = 0X1401
        /// </summary>
        UnsignedByte = ((int)0X1401)        ,
        /// <summary>
        /// Original was GL_Short = 0X1402
        /// </summary>
        Short = ((int)0X1402)        ,
        /// <summary>
        /// Original was GL_UnsignedShort = 0X1403
        /// </summary>
        UnsignedShort = ((int)0X1403)        ,
        /// <summary>
        /// Original was GL_Float = 0X1406
        /// </summary>
        Float = ((int)0X1406)        ,
        /// <summary>
        /// Original was GL_Fixed = 0X140c
        /// </summary>
        Fixed = ((int)0X140c)        ,
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum VivShaderBinary : int
    {
        /// <summary>
        /// Original was GL_SHADER_BINARY_VIV = 0x8FC4
        /// </summary>
        ShaderBinaryViv = ((int)0x8FC4)        ,
        /// <summary>
        /// Original was GL_VIV_shader_binary = 1
        /// </summary>
        VivShaderBinary = ((int)1)        ,
    }

}
