using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x02000442 RID: 1090
public class UseSurgeKitReservWay : AReserveWayAction
{
	// Token: 0x170004C0 RID: 1216
	// (get) Token: 0x06001A53 RID: 6739 RVA: 0x00002050 File Offset: 0x00000250
	public override Vector3 GoTo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170004C1 RID: 1217
	// (get) Token: 0x06001A54 RID: 6740 RVA: 0x00002050 File Offset: 0x00000250
	public override Vector3 LookShootTo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06001A55 RID: 6741 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override ReserveWayResult ManualUpdate(BotOwner bot)
	{
		throw null;
	}

	// Token: 0x06001A56 RID: 6742 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void RefreshData()
	{
		throw null;
	}

	// Token: 0x06001A57 RID: 6743 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void RefreshBot()
	{
		throw null;
	}

	// Token: 0x06001A58 RID: 6744 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override float TimeToUse(BotOwner owner)
	{
		throw null;
	}

	// Token: 0x06001A59 RID: 6745 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ComeTo(BotOwner bot)
	{
		throw null;
	}

	// Token: 0x06001A5A RID: 6746 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void AutoFix()
	{
		throw null;
	}

	// Token: 0x06001A5B RID: 6747 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void DrawGizmos()
	{
		throw null;
	}

	// Token: 0x04001689 RID: 5769
	public Transform lookToPoint;

	// Token: 0x0400168A RID: 5770
	public float ChaceToUse100;

	// Token: 0x0400168B RID: 5771
	public float ChaceToSit100;

	// Token: 0x0400168C RID: 5772
	private bool bool_0;

	// Token: 0x0400168D RID: 5773
	private EMedsType emedsType_0;

	// Token: 0x0400168E RID: 5774
	private bool bool_1;

	// Token: 0x0400168F RID: 5775
	private float float_0;

	// Token: 0x04001690 RID: 5776
	private readonly List<EMedsType> list_0;
}
