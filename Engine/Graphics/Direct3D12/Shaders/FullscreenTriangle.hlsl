struct VSOutput
{
    noperspective float4 Position : SV_Position;
    noperspective float2 UV : TEXTCOORD;
};

VSOutput FullscreenTriangleVS(in uint VertedIdx : SV_VertexID)
{
    VSOutput output;
    
    // TODO: Write fullscreen triangle code
    output.Position = float4(0, 0, 0, 1);
    
    return output;
}