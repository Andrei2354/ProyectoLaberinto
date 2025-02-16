Shader "Custom/Outline"
{
    Properties
    {
        _Color ("Color", Color) = (1,1,0,1)
        _MainTex ("Base (RGB)", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "Queue" = "Overlay" }
        Pass
        {
            ZTest Always
            ZWrite Off
            Blend SrcAlpha OneMinusSrcAlpha
            Color[_Color]
        }
    }
}
