Shader "Custom/WhiteToTransparentShader"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _TransparencyColor ("Transparency Color", Color) = (1, 1, 1, 1)
    }
    SubShader
    {
        Tags {"Queue"="Transparent" "RenderType"="Transparent"}
        Blend SrcAlpha OneMinusSrcAlpha
        LOD 100

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            sampler2D _MainTex;
            float4 _TransparencyColor;

            struct appdata_t
            {
                float4 vertex : POSITION;
                float2 texcoord : TEXCOORD0;
            };

            struct v2f
            {
                float2 texcoord : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            v2f vert (appdata_t v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.texcoord = v.texcoord;
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                float4 texColor = tex2D(_MainTex, i.texcoord);

                // Make the specified color transparent
                if (all(abs(texColor.rgb - _TransparencyColor.rgb) < 0.1))
                {
                    texColor.a = 0;
                }
                return texColor;
            }
            ENDCG
        }
    }
}
