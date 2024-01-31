using System;
using UnityEngine;

// Token: 0x020000B3 RID: 179
[Serializable]
public class TOD_SunParameters
{
	// Token: 0x040003DD RID: 989
	[Tooltip("Color of the sun spot.\nInterpolates from left (day) to right (night).")]
	public Gradient MeshColor;

	// Token: 0x040003DE RID: 990
	public float MeshSize;

	// Token: 0x040003DF RID: 991
	public float MeshBrightness;

	// Token: 0x040003E0 RID: 992
	public float MeshContrast;
}
