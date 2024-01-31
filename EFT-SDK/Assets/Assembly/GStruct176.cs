using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Token: 0x02001531 RID: 5425
[StructLayout(LayoutKind.Auto)]
public struct GStruct176
{
	// Token: 0x0600744E RID: 29774 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x0600744F RID: 29775 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Serialize(GStruct176 info, GInterface79 writer)
	{
		throw null;
	}

	// Token: 0x06007450 RID: 29776 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct176 Deserialize(GInterface76 reader)
	{
		throw null;
	}

	// Token: 0x04007A8C RID: 31372
	public bool HasData;

	// Token: 0x04007A8D RID: 31373
	public int ProfileId;

	// Token: 0x04007A8E RID: 31374
	public float TimeStamp;

	// Token: 0x04007A8F RID: 31375
	public GStruct174 PrevFrame;

	// Token: 0x04007A90 RID: 31376
	public GStruct174 CurrentFrame;

	// Token: 0x04007A91 RID: 31377
	public Vector3 InterpolatedPosition;

	// Token: 0x04007A92 RID: 31378
	public Vector3 InterpolatedStomachPosition;

	// Token: 0x04007A93 RID: 31379
	public Vector3 InterpolatedHeadPosition;

	// Token: 0x04007A94 RID: 31380
	public float Layer0NT;
}
