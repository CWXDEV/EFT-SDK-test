using System;
using UnityEngine;

// Token: 0x020000B1 RID: 177
[Serializable]
public class TOD_DayParameters
{
	// Token: 0x040003C9 RID: 969
	[Header("left (day) to right (night) (2 hours)")]
	[Tooltip("Color of the light that hits the atmosphere at day.\nInterpolates from left (day) to right (night).")]
	public Gradient SkyColor;

	// Token: 0x040003CA RID: 970
	[Tooltip("Color of the light that hits the ground at day.\nInterpolates from left (day) to right (night).")]
	public Gradient LightColor;

	// Token: 0x040003CB RID: 971
	[Tooltip("Color of the god rays at day.\nInterpolates from left (day) to right (night).")]
	public Gradient RayColor;

	// Token: 0x040003CC RID: 972
	[Tooltip("Color of the clouds at day.\nInterpolates from left (day) to right (night).")]
	public Gradient CloudColor;

	// Token: 0x040003CD RID: 973
	[Tooltip("Color of the ambient light at day.\nInterpolates from left (day) to right (night).")]
	public Gradient AmbientColor;

	// Token: 0x040003CE RID: 974
	public float LightIntensity;

	// Token: 0x040003CF RID: 975
	public float ShadowStrength;

	// Token: 0x040003D0 RID: 976
	[Tooltip("Brightness multiplier of the color gradients at day.")]
	[Range(0f, 1f)]
	public float ColorMultiplier;

	// Token: 0x040003D1 RID: 977
	[Range(0f, 1f)]
	[Tooltip("Brightness multiplier of the ambient light at day.")]
	public float AmbientMultiplier;

	// Token: 0x040003D2 RID: 978
	[Tooltip("Brightness multiplier of the reflection probe at day.")]
	[Range(0f, 1f)]
	public float ReflectionMultiplier;
}
