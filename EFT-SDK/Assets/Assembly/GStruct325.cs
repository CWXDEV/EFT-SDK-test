using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT;
using UnityEngine;

// Token: 0x020020B1 RID: 8369
[StructLayout(LayoutKind.Auto)]
public struct GStruct325
{
	// Token: 0x0600AD38 RID: 44344 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x0400B37F RID: 45951
	public EBodyPart BodyPart;

	// Token: 0x0400B380 RID: 45952
	public EDamageType DamageType;

	// Token: 0x0400B381 RID: 45953
	public float Damage;

	// Token: 0x0400B382 RID: 45954
	public Vector3 HitPoint;

	// Token: 0x0400B383 RID: 45955
	public string DamagerPlayerProfileID;

	// Token: 0x0400B384 RID: 45956
	public Vector3 HitNormal;
}
