Shader "Unlit/UnlitAnaglyphShader"
{
    Properties
    {
        _TexL("TextureL", 2D) = "white" {} // <--
        _TexR("TextureR", 2D) = "white" {} // <--
    }
        SubShader
    {
        Tags { "RenderType" = "Opaque" }
        LOD 100

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            // make fog work
            #pragma multi_compile_fog

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                UNITY_FOG_COORDS(1)
                float4 vertex : SV_POSITION;
            };

            sampler2D _TexL; // <--
            float4 _TexL_ST; // <--
            sampler2D _TexR; // <--
            float4 _TexR_ST; // <--

            v2f vert(appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _TexL); // <--
                UNITY_TRANSFER_FOG(o,o.vertex);
                return o;
            }

            fixed4 frag(v2f i) : SV_Target
            {
                // sample the texture
                fixed4 col = tex2D(_TexL, i.uv); // <--
                fixed4 colR = tex2D(_TexR, i.uv); // <--
                col.gb = colR.gb; // <--
                // apply fog
                UNITY_APPLY_FOG(i.fogCoord, col);
                return col;
            }
            ENDCG
        }
    }
}
//nanikore