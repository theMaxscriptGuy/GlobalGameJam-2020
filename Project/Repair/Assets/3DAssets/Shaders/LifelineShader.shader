Shader "Unlit/LifelineShader"
{
    Properties
    {
        _ColorA("Color A", Color) = (1,0,0,1)
        _ColorB("Color B", Color) = (1,0,0,1)
        _FillAmount ("Fill Amount", Range(0,1)) = 0
    }
    SubShader
    {
        Tags {"Queue" = "Transparent" "RenderType" = "Transparent" }
        LOD 100
        Blend SrcAlpha OneMinusSrcAlpha
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            half _FillAmount;
            half4 _ColorA;
            half4 _ColorB;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            fixed4 frag(v2f i) : SV_Target
            {
                float val = lerp(0, _FillAmount, i.uv.x);
                // sample the texture
                fixed4 col = 0;
                if (i.uv.x < _FillAmount)
                {
                    col.rgb = _ColorA.rgb;
                    col.a = 1;
                }
                else
                {
                    col = _ColorB;
                }
                    
                return col;
            }
            ENDCG
        }
    }
}
