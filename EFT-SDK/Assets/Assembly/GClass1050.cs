using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000E7F RID: 3711
public class GClass1050 : GClass1049
{
	// Token: 0x040059D2 RID: 22994
	public Dictionary<int, Matrix4x4[]> detailInstanceList;

	// Token: 0x040059D3 RID: 22995
	public Dictionary<int, ComputeBuffer> detailInstanceBuffers;

	// Token: 0x040059D4 RID: 22996
	public float[] heightMapData;

	// Token: 0x040059D5 RID: 22997
	public List<int[]> detailMapData;

	// Token: 0x040059D6 RID: 22998
	public List<int> totalDetailCounts;

	// Token: 0x040059D7 RID: 22999
	public Vector3 instanceStartPosition;
}
