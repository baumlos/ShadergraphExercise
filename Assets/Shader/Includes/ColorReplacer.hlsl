void Replace(float MaskColorValue, float MaskShadowValue, float4 Color, float ShadowFactor, out float4 FinalColor)
{
   FinalColor = (MaskColorValue * Color) + (MaskShadowValue * Color * (1 - ShadowFactor));
}