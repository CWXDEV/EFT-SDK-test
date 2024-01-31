using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x02000353 RID: 851
public class GClass78 : BaseLogicLayerSimpleClass
{
	// Token: 0x060013E0 RID: 5088 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override AICoreActionResultStruct<BotLogicDecision> GetDecision()
	{
		throw null;
	}

	// Token: 0x060013E1 RID: 5089 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool ShallUseNow()
	{
		throw null;
	}

	// Token: 0x060013E2 RID: 5090 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string Name()
	{
		throw null;
	}

	// Token: 0x060013E3 RID: 5091 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndRunToCover()
	{
		throw null;
	}

	// Token: 0x060013E4 RID: 5092 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x060013E5 RID: 5093 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndGoToCoverPoint()
	{
		throw null;
	}

	// Token: 0x060013E6 RID: 5094 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_12()
	{
		throw null;
	}

	// Token: 0x060013E7 RID: 5095 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndRunToEnemy()
	{
		throw null;
	}

	// Token: 0x060013E8 RID: 5096 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndOneMeleeAttack()
	{
		throw null;
	}

	// Token: 0x060013E9 RID: 5097 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndHoldPosition()
	{
		throw null;
	}

	// Token: 0x060013EA RID: 5098 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_13()
	{
		throw null;
	}

	// Token: 0x060013EB RID: 5099 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_14()
	{
		throw null;
	}

	// Token: 0x060013EC RID: 5100 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_15()
	{
		throw null;
	}

	// Token: 0x060013ED RID: 5101 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Dispose()
	{
		throw null;
	}

	// Token: 0x0400112D RID: 4397
	public const float DIST_TO_MISFIRE = 60f;

	// Token: 0x0400112E RID: 4398
	public const float DELTA_START_ATTACK = 18f;

	// Token: 0x0400112F RID: 4399
	public const float DELTA_HIT_ATTACK = 12f;

	// Token: 0x04001130 RID: 4400
	public const float DIST_TO_RUN_TO_ENEMY = 15f;

	// Token: 0x04001131 RID: 4401
	public const float DIST_TO_TELEPORT = 60f;

	// Token: 0x04001132 RID: 4402
	public const float PERFECT_DIST = 50f;

	// Token: 0x04001133 RID: 4403
	public const int BUFF_UPDATE_TIME = 5;

	// Token: 0x04001134 RID: 4404
	private float float_2;

	// Token: 0x04001135 RID: 4405
	private float float_3;

	// Token: 0x04001136 RID: 4406
	private Vector3 vector3_0;

	// Token: 0x04001137 RID: 4407
	private float float_4;

	// Token: 0x04001138 RID: 4408
	private readonly HashSet<IPlayer> hashSet_0;

	// Token: 0x02000354 RID: 852
	[CompilerGenerated]
	private sealed class Class189
	{
		// Token: 0x060013EE RID: 5102 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GroupPoint point)
		{
			throw null;
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(GroupPoint point)
		{
			throw null;
		}

		// Token: 0x04001139 RID: 4409
		public Vector3 posEnemy;
	}
}
