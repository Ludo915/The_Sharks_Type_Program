Shader "Custom/BlackToTransparentShader" {
    Properties {
        _MainTex ("Texture", 2D) = "white" { }
        _TransparencyColor ("Transparency Color", Color) = (30.0, 29.0, 30.0, 1.0) // Color to make transparent
        _Tolerance ("Color Tolerance", Float) = 0.1 // Tolerance for color matching
    }
    SubShader { 
        LOD 100
        Tags { "Queue"="Transparent" "RenderType"="Transparent" }
        Blend SrcAlpha OneMinusSrcAlpha
  
        Pass {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
  
            #include "UnityCG.cginc"
  
            struct appdata_t {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };
  
            struct v2f {
                float2 uv : TEXCOORD0;
                float4 pos : SV_POSITION;
            };
  
            sampler2D _MainTex;
            float4 _TransparencyColor;
            float _Tolerance;
  
            v2f vert (appdata_t v) {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }
  
            fixed4 frag (v2f i) : SV_Target {
                // Sample the texture
                fixed4 texColor = tex2D(_MainTex, i.uv);
  
                // Calculate the difference between the sampled color and the transparency color
                float3 diff = abs(texColor.rgb - _TransparencyColor.rgb / 1.0);
  
                // If the difference is within tolerance, make the color transparent
                if (diff.r < _Tolerance && diff.g < _Tolerance && diff.b < _Tolerance) {
                    texColor.a = 0; // Make the alpha 0 for transparency
                }
  
                return texColor;
            }
            ENDCG
        }
    }
  }
  