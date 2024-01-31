using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT.NetworkPackets;
using UnityEngine;

// Token: 0x020020BB RID: 8379
[StructLayout(LayoutKind.Auto)]
public struct GStruct332
{
	// Token: 0x17001C96 RID: 7318
	// (get) Token: 0x0600AD45 RID: 44357 RVA: 0x00002050 File Offset: 0x00000250
	public bool HasHitSomething
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600AD46 RID: 44358 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x0400B3A4 RID: 45988
	public const int EMPTY_ID = -1;

	// Token: 0x0400B3A5 RID: 45989
	public Vector3 HitPosition;

	// Token: 0x0400B3A6 RID: 45990
	public float Damage;

	// Token: 0x0400B3A7 RID: 45991
	public int AmmoId;

	// Token: 0x0400B3A8 RID: 45992
	public byte FragmentId;

	// Token: 0x0400B3A9 RID: 45993
	public EHitType HitType;

	// Token: 0x0400B3AA RID: 45994
	public int HittedId;

	// Token: 0x0400B3AB RID: 45995
	public int FireIndex;

	// Token: 0x0400B3AC RID: 45996
	public EBodyPart BodyPart;

	// Token: 0x0400B3AD RID: 45997
	public EBodyPartColliderType BodyPartColliderType;

	// Token: 0x0400B3AE RID: 45998
	public EArmorPlateCollider ArmorPlateCollider;

	// Token: 0x0400B3AF RID: 45999
	public ulong ServerFrame;

	// Token: 0x0400B3B0 RID: 46000
	public float PenetrationPower;

	// Token: 0x0400B3B1 RID: 46001
	public float ArmorDamage;

	// Token: 0x0400B3B2 RID: 46002
	public GStruct333[] ShotTrajectoryParts;

	// Token: 0x0400B3B3 RID: 46003
	public float HitCos;

	// Token: 0x0400B3B4 RID: 46004
	public int Seed;

	// Token: 0x0400B3B5 RID: 46005
	public float TimeStamp;

	// Token: 0x0400B3B6 RID: 46006
	public float StaminaBurnRate;

	// Token: 0x0400B3B7 RID: 46007
	public string HitArmorID;
}
