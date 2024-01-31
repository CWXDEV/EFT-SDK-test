using System;
using System.Runtime.InteropServices;
using UnityEngine;

// Token: 0x02000D40 RID: 3392
[StructLayout(LayoutKind.Auto)]
public struct GStruct73
{
	// Token: 0x040052F0 RID: 21232
	public GStruct73.ENodeType Type;

	// Token: 0x040052F1 RID: 21233
	public Vector3 Position;

	// Token: 0x040052F2 RID: 21234
	public float PortalClosednessStatus;

	// Token: 0x040052F3 RID: 21235
	public float MaxClosednessCost;

	// Token: 0x02000D41 RID: 3393
	public enum ENodeType
	{
		// Token: 0x040052F5 RID: 21237
		Emitter,
		// Token: 0x040052F6 RID: 21238
		Portal,
		// Token: 0x040052F7 RID: 21239
		Listener
	}
}
