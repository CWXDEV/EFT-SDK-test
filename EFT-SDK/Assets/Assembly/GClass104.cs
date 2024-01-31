using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000371 RID: 881
public class GClass104 : BaseLogicLayerSimpleClass
{
	// Token: 0x060014EB RID: 5355 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCorePosition(Vector3 corePosition)
	{
		throw null;
	}

	// Token: 0x060014EC RID: 5356 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x060014ED RID: 5357 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override CustomNavigationPoint FindPoint(CoverSearchData data, Func<CoverSearchData, CustomNavigationPoint> p, bool checkCurrent)
	{
		throw null;
	}

	// Token: 0x060014EE RID: 5358 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override AICoreActionResultStruct<BotLogicDecision> GetDecision()
	{
		throw null;
	}

	// Token: 0x060014EF RID: 5359 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool ShallUseNow()
	{
		throw null;
	}

	// Token: 0x060014F0 RID: 5360 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDrawGizmos()
	{
		throw null;
	}

	// Token: 0x060014F1 RID: 5361 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string Name()
	{
		throw null;
	}

	// Token: 0x060014F2 RID: 5362 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndRunToCover()
	{
		throw null;
	}

	// Token: 0x060014F3 RID: 5363 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndAlternativePatrol()
	{
		throw null;
	}

	// Token: 0x060014F4 RID: 5364 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndSimplePatrol()
	{
		throw null;
	}

	// Token: 0x060014F5 RID: 5365 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndFollowerPatrolItem()
	{
		throw null;
	}

	// Token: 0x060014F6 RID: 5366 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndHoldPosition()
	{
		throw null;
	}

	// Token: 0x060014F7 RID: 5367 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool IsPointGood(CustomNavigationPoint cachedPoint)
	{
		throw null;
	}

	// Token: 0x060014F8 RID: 5368 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private CustomNavigationPoint method_12(CustomNavigationPoint b, CustomNavigationPoint a)
	{
		throw null;
	}

	// Token: 0x060014F9 RID: 5369 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private CustomNavigationPoint method_13()
	{
		throw null;
	}

	// Token: 0x060014FA RID: 5370 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_14()
	{
		throw null;
	}

	// Token: 0x04001191 RID: 4497
	public const float SDIST_TREE_CLOSE = 900f;

	// Token: 0x04001192 RID: 4498
	protected Vector3 vector3_0;

	// Token: 0x04001193 RID: 4499
	protected CustomNavigationPoint customNavigationPoint_0;

	// Token: 0x04001194 RID: 4500
	private readonly float float_2;

	// Token: 0x04001195 RID: 4501
	private bool bool_4;

	// Token: 0x04001196 RID: 4502
	private readonly bool bool_5;

	// Token: 0x04001197 RID: 4503
	private float float_3;

	// Token: 0x04001198 RID: 4504
	private CoverLevel coverLevel_0;
}
