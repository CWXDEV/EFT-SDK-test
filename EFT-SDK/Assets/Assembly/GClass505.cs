using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x020004BB RID: 1211
public class GClass505 : BotRequest
{
	// Token: 0x1700055B RID: 1371
	// (get) Token: 0x06001DA7 RID: 7591 RVA: 0x00002050 File Offset: 0x00000250
	public override EBotRequestMode RequestMode
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06001DA8 RID: 7592 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanStartExecute(BotOwner executor)
	{
		throw null;
	}

	// Token: 0x06001DA9 RID: 7593 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanProceed()
	{
		throw null;
	}

	// Token: 0x06001DAA RID: 7594 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void PlayerDestroy(Player player)
	{
		throw null;
	}

	// Token: 0x06001DAB RID: 7595 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 CurTragte()
	{
		throw null;
	}

	// Token: 0x06001DAC RID: 7596 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsExecuterFar()
	{
		throw null;
	}

	// Token: 0x06001DAD RID: 7597 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsExecuterTooFar()
	{
		throw null;
	}

	// Token: 0x06001DAE RID: 7598 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override AICoreActionEndStruct EndHoldPosition()
	{
		throw null;
	}

	// Token: 0x06001DAF RID: 7599 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanRequest(BotOwner requester)
	{
		throw null;
	}

	// Token: 0x06001DB0 RID: 7600 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_0()
	{
		throw null;
	}

	// Token: 0x0400190E RID: 6414
	public const float EXECUTER_FAR_SQRT = 64f;

	// Token: 0x0400190F RID: 6415
	public const float MAX_SQRT_DIST = 2500f;

	// Token: 0x04001910 RID: 6416
	public const float MAX_SQRT_DIST_FROM_TAKE_POINT = 40000f;

	// Token: 0x04001911 RID: 6417
	public Vector3 StartExecuterPosition;

	// Token: 0x04001912 RID: 6418
	private float float_0;
}
