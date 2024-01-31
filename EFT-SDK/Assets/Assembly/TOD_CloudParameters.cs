using System;
using UnityEngine;

// Token: 0x020000B6 RID: 182
[Serializable]
public class TOD_CloudParameters
{
	// Token: 0x040003EB RID: 1003
	public float Density;

	// Token: 0x040003EC RID: 1004
	public float Sharpness;

	// Token: 0x040003ED RID: 1005
	public float Brightness;

	// Token: 0x040003EE RID: 1006
	public int Billboards;

	// Token: 0x040003EF RID: 1007
	public float ShadowStrength;

	// Token: 0x040003F0 RID: 1008
	[Tooltip("Scale of the first cloud layer.")]
	public Vector2 Scale1;

	// Token: 0x040003F1 RID: 1009
	[Tooltip("Scale of the second cloud layer.")]
	public Vector2 Scale2;
}
