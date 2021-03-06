namespace Ryujinx.Graphics.Gpu
{
    enum NvGpuEngine3dReg
    {
        FrameBufferNAddress  = 0x200,
        FrameBufferNWidth    = 0x202,
        FrameBufferNHeight   = 0x203,
        FrameBufferNFormat   = 0x204,
        VertexAttribNFormat  = 0x458,
        BlendSeparateAlpha   = 0x4cf,
        BlendEquationRgb     = 0x4d0,
        BlendFuncSrcRgb      = 0x4d1,
        BlendFuncDstRgb      = 0x4d2,
        BlendEquationAlpha   = 0x4d3,
        BlendFuncSrcAlpha    = 0x4d4,
        BlendFuncDstAlpha    = 0x4d6,
        BlendEnableMaster    = 0x4d7,
        VertexArrayElemBase  = 0x50d,
        TexHeaderPoolOffset  = 0x55d,
        TexSamplerPoolOffset = 0x557,
        ShaderAddress        = 0x582,
        VertexBeginGl        = 0x586,
        IndexArrayAddress    = 0x5f2,
        IndexArrayEndAddr    = 0x5f4,
        IndexArrayFormat     = 0x5f6,
        IndexBatchFirst      = 0x5f7,
        IndexBatchCount      = 0x5f8,
        QueryAddress         = 0x6c0,
        QuerySequence        = 0x6c2,
        QueryControl         = 0x6c3,
        VertexArrayNControl  = 0x700,
        VertexArrayNAddress  = 0x701,
        VertexArrayNDivisor  = 0x703,
        VertexArrayNEndAddr  = 0x7c0,
        ShaderNControl       = 0x800,
        ShaderNOffset        = 0x801,
        ShaderNMaxGprs       = 0x803,
        ShaderNType          = 0x804,
        ConstBufferNSize     = 0x8e0,
        ConstBufferNAddress  = 0x8e1,
        ConstBufferNOffset   = 0x8e3,
        TextureCbIndex       = 0x982
    }
}