using System;
using UnityEngine;

// Token: 0x020000B2 RID: 178
[Serializable]
public class TOD_NightParameters
{
	// Token: 0x040003D3 RID: 979
	[Tooltip("Color of the light that hits the atmosphere at night.\nInterpolates from left (day) to right (night).")]
	public Gradient SkyColor;

	// Token: 0x040003D4 RID: 980
	[Tooltip("Color of the light that hits the ground at night.\nInterpolates from left (day) to right (night).")]
	public Gradient LightColor;

	// Token: 0x040003D5 RID: 981
	[Tooltip("Color of the god rays at night.\nInterpolates from left (day) to right (night).")]
	public Gradient RayColor;

	// Token: 0x040003D6 RID: 982
	[Tooltip("Color of the clouds at night.\nInterpolates from left (day) to right (night).")]
	public Gradient CloudColor;

	// Token: 0x040003D7 RID: 983
	[Tooltip("Color of the ambient light at night.\nInterpolates from left (day) to right (night).")]
	public Gradient AmbientColor;

	// Token: 0x040003D8 RID: 984
	public float LightIntensity;

	// Token: 0x040003D9 RID: 985
	public float ShadowStrength;

	// Token: 0x040003DA RID: 986
	[Tooltip("Brightness multiplier of the color gradients at night.")]
	[Range(0f, 1f)]
	public float ColorMultiplier;

	// Token: 0x040003DB RID: 987
	[Range(0f, 1f)]
	[Tooltip("Brightness multiplier of the ambient light at night.")]
	public float AmbientMultiplier;

	// Token: 0x040003DC RID: 988
	[Range(0f, 1f)]
	[Tooltip("Brightness multiplier of the reflection probe at night.")]
	public float ReflectionMultiplier;
}
