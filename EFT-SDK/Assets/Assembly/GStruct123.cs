using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Token: 0x020011D5 RID: 4565
[StructLayout(LayoutKind.Auto)]
public struct GStruct123 : GInterface141<GStruct123>
{
	// Token: 0x17000F52 RID: 3922
	// (get) Token: 0x06006171 RID: 24945 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06006172 RID: 24946 RVA: 0x00002050 File Offset: 0x00000250
	public GInterface141<GStruct123> Nested
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x04006B51 RID: 27473
	public int NetId;

	// Token: 0x04006B52 RID: 27474
	public Vector3 HitPosition;

	// Token: 0x04006B53 RID: 27475
	[CompilerGenerated]
	private GInterface141<GStruct123> ginterface141_0;
}
