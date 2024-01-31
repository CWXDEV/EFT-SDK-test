using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x0200043F RID: 1087
public class ShootReservWay : AReserveWayAction
{
	// Token: 0x170004BB RID: 1211
	// (get) Token: 0x06001A3B RID: 6715 RVA: 0x00002050 File Offset: 0x00000250
	public override Vector3 GoTo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170004BC RID: 1212
	// (get) Token: 0x06001A3C RID: 6716 RVA: 0x00002050 File Offset: 0x00000250
	public override Vector3 LookShootTo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06001A3D RID: 6717 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override ReserveWayResult ManualUpdate(BotOwner bot)
	{
		throw null;
	}

	// Token: 0x06001A3E RID: 6718 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ComeTo(BotOwner bot)
	{
		throw null;
	}

	// Token: 0x06001A3F RID: 6719 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void AutoFix()
	{
		throw null;
	}

	// Token: 0x06001A40 RID: 6720 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void RefreshData()
	{
		throw null;
	}

	// Token: 0x06001A41 RID: 6721 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void RefreshBot()
	{
		throw null;
	}

	// Token: 0x06001A42 RID: 6722 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DrawGizmos()
	{
		throw null;
	}

	// Token: 0x04001675 RID: 5749
	public List<Transform> TargetToShoot;

	// Token: 0x04001676 RID: 5750
	public float StayPeriod;

	// Token: 0x04001677 RID: 5751
	public float ShootPeriod;

	// Token: 0x04001678 RID: 5752
	private float float_0;

	// Token: 0x04001679 RID: 5753
	private bool bool_0;

	// Token: 0x0400167A RID: 5754
	private bool bool_1;

	// Token: 0x0400167B RID: 5755
	private Vector3 vector3_0;
}
