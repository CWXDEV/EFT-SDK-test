using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT.NetworkPackets;
using UnityEngine;

// Token: 0x020020B3 RID: 8371
[StructLayout(LayoutKind.Auto)]
public struct GStruct327
{
	// Token: 0x17001C92 RID: 7314
	// (get) Token: 0x0600AD3A RID: 44346 RVA: 0x00002050 File Offset: 0x00000250
	public bool HasHitSomething
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400B388 RID: 45960
	public const int EMPTY_ID = -1;

	// Token: 0x0400B389 RID: 45961
	public int HittedId;

	// Token: 0x0400B38A RID: 45962
	public EBodyPart EBodyPart;

	// Token: 0x0400B38B RID: 45963
	public EBodyPartColliderType EColliderType;

	// Token: 0x0400B38C RID: 45964
	public EArmorPlateCollider ArmorPlateCollider;

	// Token: 0x0400B38D RID: 45965
	public ulong ServerFrame;

	// Token: 0x0400B38E RID: 45966
	public Vector3 HitPosition;

	// Token: 0x0400B38F RID: 45967
	public EHitType HitType;

	// Token: 0x0400B390 RID: 45968
	public bool IsStab;

	// Token: 0x0400B391 RID: 45969
	public float TimeStamp;
}
