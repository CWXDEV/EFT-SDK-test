using System;
using UnityEngine;

// Token: 0x020000B4 RID: 180
[Serializable]
public class TOD_MoonParameters
{
	// Token: 0x040003E1 RID: 993
	[Tooltip("Color of the moon mesh.\nInterpolates from left (day) to right (night).")]
	public Gradient MeshColor;

	// Token: 0x040003E2 RID: 994
	public float MeshSize;

	// Token: 0x040003E3 RID: 995
	public float MeshBrightness;

	// Token: 0x040003E4 RID: 996
	public float MeshContrast;

	// Token: 0x040003E5 RID: 997
	[Tooltip("Color of the moon halo.\nInterpolates from left (day) to right (night).")]
	public Gradient HaloColor;

	// Token: 0x040003E6 RID: 998
	public float HaloSize;

	// Token: 0x040003E7 RID: 999
	[Tooltip("Type of the moon position calculation.")]
	public TOD_MoonPositionType Position;
}
