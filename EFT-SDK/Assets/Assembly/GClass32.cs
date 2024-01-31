using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000316 RID: 790
public class GClass32 : BaseLogicLayerSimpleClass
{
	// Token: 0x17000409 RID: 1033
	// (get) Token: 0x0600117B RID: 4475 RVA: 0x00002050 File Offset: 0x00000250
	protected virtual Vector3? TargetPosition
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700040A RID: 1034
	// (get) Token: 0x0600117C RID: 4476 RVA: 0x00002050 File Offset: 0x00000250
	protected virtual int TargetEnvironmentId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600117D RID: 4477 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override AICoreActionResultStruct<BotLogicDecision> GetDecision()
	{
		throw null;
	}

	// Token: 0x0600117E RID: 4478 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CustomNavigationPoint FindPoint(CoverSearchData data, Func<CoverSearchData, CustomNavigationPoint> p, bool checkCurrent)
	{
		throw null;
	}

	// Token: 0x0600117F RID: 4479 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool ShallUseNow()
	{
		throw null;
	}

	// Token: 0x06001180 RID: 4480 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string Name()
	{
		throw null;
	}

	// Token: 0x06001181 RID: 4481 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndShootFromPlace()
	{
		throw null;
	}

	// Token: 0x06001182 RID: 4482 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndSuppressGrenade()
	{
		throw null;
	}

	// Token: 0x06001183 RID: 4483 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x06001184 RID: 4484 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndAttackMoving()
	{
		throw null;
	}

	// Token: 0x06001185 RID: 4485 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndHoldPosition()
	{
		throw null;
	}

	// Token: 0x06001186 RID: 4486 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndRunToEnemy()
	{
		throw null;
	}

	// Token: 0x06001187 RID: 4487 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndGoToEnemy()
	{
		throw null;
	}

	// Token: 0x06001188 RID: 4488 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndGoToPoint()
	{
		throw null;
	}

	// Token: 0x06001189 RID: 4489 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndRunToCover()
	{
		throw null;
	}

	// Token: 0x0600118A RID: 4490 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndRunToEnemyZigZag()
	{
		throw null;
	}

	// Token: 0x0600118B RID: 4491 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_12()
	{
		throw null;
	}

	// Token: 0x0600118C RID: 4492 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private CoverSearchData method_13()
	{
		throw null;
	}

	// Token: 0x0600118D RID: 4493 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_14(GroupPoint point)
	{
		throw null;
	}

	// Token: 0x0600118E RID: 4494 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_15()
	{
		throw null;
	}

	// Token: 0x0600118F RID: 4495 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_16()
	{
		throw null;
	}

	// Token: 0x04001016 RID: 4118
	public const float PERIOD_NO_VISION = 1f;

	// Token: 0x04001017 RID: 4119
	public const float WAIT_PERIOD_SEC = 900f;

	// Token: 0x04001018 RID: 4120
	private const bool bool_4 = true;

	// Token: 0x04001019 RID: 4121
	private float float_2;

	// Token: 0x0400101A RID: 4122
	private float float_3;
}
