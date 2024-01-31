using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200037F RID: 895
public class GClass119 : GClass114
{
	// Token: 0x17000420 RID: 1056
	// (get) Token: 0x060015B1 RID: 5553 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060015B2 RID: 5554 RVA: 0x00002050 File Offset: 0x00000250
	public CustomNavigationPoint PointToShoot
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000421 RID: 1057
	// (get) Token: 0x060015B3 RID: 5555 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060015B4 RID: 5556 RVA: 0x00002050 File Offset: 0x00000250
	public bool HaveCoverToShoot
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x060015B5 RID: 5557 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool ShallUseNow()
	{
		throw null;
	}

	// Token: 0x060015B6 RID: 5558 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string Name()
	{
		throw null;
	}

	// Token: 0x060015B7 RID: 5559 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnActivate()
	{
		throw null;
	}

	// Token: 0x060015B8 RID: 5560 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetInside(bool isInside)
	{
		throw null;
	}

	// Token: 0x060015B9 RID: 5561 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDelay(float delay)
	{
		throw null;
	}

	// Token: 0x060015BA RID: 5562 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override AICoreActionResultStruct<BotLogicDecision> GetDecision()
	{
		throw null;
	}

	// Token: 0x060015BB RID: 5563 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CustomNavigationPoint FollowerCheckData()
	{
		throw null;
	}

	// Token: 0x060015BC RID: 5564 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBoss(GClass377 sectantPriest)
	{
		throw null;
	}

	// Token: 0x060015BD RID: 5565 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCorePosition(Vector3 corePoint)
	{
		throw null;
	}

	// Token: 0x060015BE RID: 5566 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndRunToCover()
	{
		throw null;
	}

	// Token: 0x060015BF RID: 5567 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndOneMeleeAttack()
	{
		throw null;
	}

	// Token: 0x060015C0 RID: 5568 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_12()
	{
		throw null;
	}

	// Token: 0x060015C1 RID: 5569 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndHoldPosition()
	{
		throw null;
	}

	// Token: 0x060015C2 RID: 5570 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_13()
	{
		throw null;
	}

	// Token: 0x060015C3 RID: 5571 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Dispose()
	{
		throw null;
	}

	// Token: 0x04001230 RID: 4656
	public const float DIST_CHANGE_TO_MEELE_FROM_FIRE = 5f;

	// Token: 0x04001231 RID: 4657
	public const float PERIOD_SEEN_TOATTACK = 4f;

	// Token: 0x04001232 RID: 4658
	private const string string_0 = "SupShootSect_IN";

	// Token: 0x04001233 RID: 4659
	private const string string_1 = "SupShootSect_OUT";

	// Token: 0x04001234 RID: 4660
	private const float float_2 = 30f;

	// Token: 0x04001235 RID: 4661
	private GClass377 gclass377_0;

	// Token: 0x04001236 RID: 4662
	private float float_3;

	// Token: 0x04001237 RID: 4663
	private float float_4;

	// Token: 0x04001238 RID: 4664
	private bool bool_4;

	// Token: 0x04001239 RID: 4665
	private bool bool_5;

	// Token: 0x0400123A RID: 4666
	private string string_2;

	// Token: 0x0400123B RID: 4667
	private Vector3 vector3_0;

	// Token: 0x0400123C RID: 4668
	private readonly GClass295 gclass295_0;

	// Token: 0x0400123D RID: 4669
	private readonly bool bool_6;

	// Token: 0x0400123E RID: 4670
	[CompilerGenerated]
	private CustomNavigationPoint customNavigationPoint_0;

	// Token: 0x0400123F RID: 4671
	[CompilerGenerated]
	private bool bool_7;
}
