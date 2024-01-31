using System;
using UnityEngine;

// Token: 0x020000B5 RID: 181
[Serializable]
public class TOD_StarParameters
{
	// Token: 0x040003E8 RID: 1000
	public float Tiling;

	// Token: 0x040003E9 RID: 1001
	public float Brightness;

	// Token: 0x040003EA RID: 1002
	[Tooltip("Type of the stars position calculation.")]
	public TOD_StarsPositionType Position;
}
