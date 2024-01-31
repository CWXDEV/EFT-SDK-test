using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x02000310 RID: 784
public abstract class BaseLogicLayerSimpleClass : BaseLogicLayerClass
{
	// Token: 0x060010C4 RID: 4292 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static BotLogicDecision TryMoveToEnemy(BotOwner bot, BotLogicDecision runDecision = BotLogicDecision.runToEnemy)
	{
		throw null;
	}

	// Token: 0x060010C5 RID: 4293 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CheckMedsToStop(BotOwner bot)
	{
		throw null;
	}

	// Token: 0x060010C6 RID: 4294 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsPointInsideDangerZone(BotOwner bot, Vector3 point)
	{
		throw null;
	}

	// Token: 0x060010C7 RID: 4295 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool method_2()
	{
		throw null;
	}

	// Token: 0x060010C8 RID: 4296 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func<CoverSearchData, CustomNavigationPoint> p, bool checkCurrent)
	{
		throw null;
	}

	// Token: 0x060010C9 RID: 4297 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public AICoreActionResultStruct<BotLogicDecision>? InFightLogic()
	{
		throw null;
	}

	// Token: 0x060010CA RID: 4298 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CalcActionNextFrame(BotLogicDecision? nextLogic = null)
	{
		throw null;
	}

	// Token: 0x060010CB RID: 4299 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool method_3()
	{
		throw null;
	}

	// Token: 0x060010CC RID: 4300 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool method_4(EnemyInfo info)
	{
		throw null;
	}

	// Token: 0x060010CD RID: 4301 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool method_5(out string cause)
	{
		throw null;
	}

	// Token: 0x060010CE RID: 4302 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool method_6()
	{
		throw null;
	}

	// Token: 0x060010CF RID: 4303 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual BotLogicDecision HoldFor(float sec)
	{
		throw null;
	}

	// Token: 0x060010D0 RID: 4304 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected AICoreActionResultStruct<BotLogicDecision> method_7(float holdperiod = 0f, string pref = null)
	{
		throw null;
	}

	// Token: 0x060010D1 RID: 4305 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool method_8()
	{
		throw null;
	}

	// Token: 0x060010D2 RID: 4306 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool method_9(EnemyInfo enemy)
	{
		throw null;
	}

	// Token: 0x060010D3 RID: 4307 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected CustomNavigationPoint method_10(CoverSearchData data, Func<CoverSearchData, CustomNavigationPoint> p, bool checkCurrent)
	{
		throw null;
	}

	// Token: 0x060010D4 RID: 4308 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndRunAwayGrenade()
	{
		throw null;
	}

	// Token: 0x060010D5 RID: 4309 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndSimplePatrol()
	{
		throw null;
	}

	// Token: 0x060010D6 RID: 4310 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndGoToPoint()
	{
		throw null;
	}

	// Token: 0x060010D7 RID: 4311 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndLayNode()
	{
		throw null;
	}

	// Token: 0x060010D8 RID: 4312 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndAlternativePatrol()
	{
		throw null;
	}

	// Token: 0x060010D9 RID: 4313 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndFollowerPatrolItem()
	{
		throw null;
	}

	// Token: 0x060010DA RID: 4314 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndTakeItem()
	{
		throw null;
	}

	// Token: 0x060010DB RID: 4315 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndDropItem()
	{
		throw null;
	}

	// Token: 0x060010DC RID: 4316 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndGestus()
	{
		throw null;
	}

	// Token: 0x060010DD RID: 4317 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndPeaceHardAim()
	{
		throw null;
	}

	// Token: 0x060010DE RID: 4318 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndPeaceLook()
	{
		throw null;
	}

	// Token: 0x060010DF RID: 4319 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndEatDrink()
	{
		throw null;
	}

	// Token: 0x060010E0 RID: 4320 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndFriendlyTilt()
	{
		throw null;
	}

	// Token: 0x060010E1 RID: 4321 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndDeadBody()
	{
		throw null;
	}

	// Token: 0x060010E2 RID: 4322 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndLeaveMap()
	{
		throw null;
	}

	// Token: 0x060010E3 RID: 4323 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndShootFromPlace()
	{
		throw null;
	}

	// Token: 0x060010E4 RID: 4324 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndGrenadeSuicide()
	{
		throw null;
	}

	// Token: 0x060010E5 RID: 4325 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndAxeTarget()
	{
		throw null;
	}

	// Token: 0x060010E6 RID: 4326 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndHealAnotherTarget()
	{
		throw null;
	}

	// Token: 0x060010E7 RID: 4327 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndStimulators()
	{
		throw null;
	}

	// Token: 0x060010E8 RID: 4328 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndSuppressStationary()
	{
		throw null;
	}

	// Token: 0x060010E9 RID: 4329 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndRunToStationary()
	{
		throw null;
	}

	// Token: 0x060010EA RID: 4330 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndPanicSitting()
	{
		throw null;
	}

	// Token: 0x060010EB RID: 4331 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndRunToEnemyZigZag()
	{
		throw null;
	}

	// Token: 0x060010EC RID: 4332 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndOneMeleeAttack()
	{
		throw null;
	}

	// Token: 0x060010ED RID: 4333 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndRunToEnemy()
	{
		throw null;
	}

	// Token: 0x060010EE RID: 4334 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndSuppressFire()
	{
		throw null;
	}

	// Token: 0x060010EF RID: 4335 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndStandBy()
	{
		throw null;
	}

	// Token: 0x060010F0 RID: 4336 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndTurnAway()
	{
		throw null;
	}

	// Token: 0x060010F1 RID: 4337 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndDogFight()
	{
		throw null;
	}

	// Token: 0x060010F2 RID: 4338 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndShootFromCover()
	{
		throw null;
	}

	// Token: 0x060010F3 RID: 4339 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndSearch()
	{
		throw null;
	}

	// Token: 0x060010F4 RID: 4340 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndSuppressGrenade()
	{
		throw null;
	}

	// Token: 0x060010F5 RID: 4341 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndGoToCoverPoint()
	{
		throw null;
	}

	// Token: 0x060010F6 RID: 4342 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool CanSearchEnemy()
	{
		throw null;
	}

	// Token: 0x060010F7 RID: 4343 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool method_11(float period)
	{
		throw null;
	}

	// Token: 0x060010F8 RID: 4344 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndHeal()
	{
		throw null;
	}

	// Token: 0x060010F9 RID: 4345 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndGoToEnemy()
	{
		throw null;
	}

	// Token: 0x060010FA RID: 4346 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndAttackMoving()
	{
		throw null;
	}

	// Token: 0x060010FB RID: 4347 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndHoldPosition()
	{
		throw null;
	}

	// Token: 0x060010FC RID: 4348 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndRunToCoverZigZag()
	{
		throw null;
	}

	// Token: 0x060010FD RID: 4349 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override AICoreActionEndStruct EndRunToCover()
	{
		throw null;
	}

	// Token: 0x04001006 RID: 4102
	private const float float_0 = 5f;

	// Token: 0x04001007 RID: 4103
	protected bool bool_2;

	// Token: 0x04001008 RID: 4104
	protected float float_1;

	// Token: 0x04001009 RID: 4105
	protected BotLogicDecision? nullable_0;

	// Token: 0x0400100A RID: 4106
	private bool bool_3;
}
