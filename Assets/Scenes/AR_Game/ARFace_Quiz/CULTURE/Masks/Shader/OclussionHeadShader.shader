Shader "Custom/ARMaskShader"
{
	Properties
	{
		_MainTex("Texture", 2D) = "white" {}
	}
		SubShader
	{
		ZWrite On
			ColorMask 0

			Tags{ "Queue" = "Geometry-1"}

	   Pass
	   {
		   Color(1,0,0,1)
	   }
	}
}
