using System;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x02000311 RID: 785
public abstract class BaseLogicLayerClass : AICoreLayerClass<BotLogicDecision>
{
	// Token: 0x060010FE RID: 4350 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static BotLogicDecision HoldOrCover(BotOwner owner)
	{
		throw null;
	}

	// Token: 0x060010FF RID: 4351 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static BotLogicDecision HoldOrCoverRun(BotOwner owner)
	{
		throw null;
	}

	// Token: 0x17000404 RID: 1028
	// (get) Token: 0x06001100 RID: 4352 RVA: 0x00002050 File Offset: 0x00000250
	public sealed override int Priority
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06001101 RID: 4353 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void DecisionChanged(AICoreActionResultStruct<BotLogicDecision>? prevDecision, AICoreActionResultStruct<BotLogicDecision> nextDecision)
	{
		throw null;
	}

	// Token: 0x06001102 RID: 4354 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override AICoreActionEndStruct ShallEndCurrentDecision(AICoreActionResultStruct<BotLogicDecision> curDecision)
	{
		throw null;
	}

	// Token: 0x06001103 RID: 4355 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private AICoreActionEndStruct method_0()
	{
		throw null;
	}

	// Token: 0x06001104 RID: 4356 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndAttackMovingWithSuppress()
	{
		throw null;
	}

	// Token: 0x06001105 RID: 4357 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndGoToPoint()
	{
		throw null;
	}

	// Token: 0x06001106 RID: 4358 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndStandBy()
	{
		throw null;
	}

	// Token: 0x06001107 RID: 4359 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndKhorovodChristmasEvent()
	{
		throw null;
	}

	// Token: 0x06001108 RID: 4360 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndSummon()
	{
		throw null;
	}

	// Token: 0x06001109 RID: 4361 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private AICoreActionEndStruct method_1()
	{
		throw null;
	}

	// Token: 0x0600110A RID: 4362 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndDoGiftChristmasEvent()
	{
		throw null;
	}

	// Token: 0x0600110B RID: 4363 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndTurnAway()
	{
		throw null;
	}

	// Token: 0x0600110C RID: 4364 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndDogFight()
	{
		throw null;
	}

	// Token: 0x0600110D RID: 4365 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndRunToStationary()
	{
		throw null;
	}

	// Token: 0x0600110E RID: 4366 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndPanicSitting()
	{
		throw null;
	}

	// Token: 0x0600110F RID: 4367 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndRunToEnemyZigZag()
	{
		throw null;
	}

	// Token: 0x06001110 RID: 4368 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndRunToEnemy()
	{
		throw null;
	}

	// Token: 0x06001111 RID: 4369 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndSuppressFire()
	{
		throw null;
	}

	// Token: 0x06001112 RID: 4370 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndGoToCoverPoint()
	{
		throw null;
	}

	// Token: 0x06001113 RID: 4371 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndPlayerFollow()
	{
		throw null;
	}

	// Token: 0x06001114 RID: 4372 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndRepairMalfunction()
	{
		throw null;
	}

	// Token: 0x06001115 RID: 4373 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndCrawlNode()
	{
		throw null;
	}

	// Token: 0x06001116 RID: 4374 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndLayNode()
	{
		throw null;
	}

	// Token: 0x06001117 RID: 4375 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndSearch()
	{
		throw null;
	}

	// Token: 0x06001118 RID: 4376 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndShootFromCover()
	{
		throw null;
	}

	// Token: 0x06001119 RID: 4377 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndHeal()
	{
		throw null;
	}

	// Token: 0x0600111A RID: 4378 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndSimplePatrol()
	{
		throw null;
	}

	// Token: 0x0600111B RID: 4379 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndShootFromPlace()
	{
		throw null;
	}

	// Token: 0x0600111C RID: 4380 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndAttackMoving()
	{
		throw null;
	}

	// Token: 0x0600111D RID: 4381 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndRunToCover()
	{
		throw null;
	}

	// Token: 0x0600111E RID: 4382 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndSuppressGrenade()
	{
		throw null;
	}

	// Token: 0x0600111F RID: 4383 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndRunAndThrowGrenadeFromPlace()
	{
		throw null;
	}

	// Token: 0x06001120 RID: 4384 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndThrowGrenadeFromPlace()
	{
		throw null;
	}

	// Token: 0x06001121 RID: 4385 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndOneMeleeAttack()
	{
		throw null;
	}

	// Token: 0x06001122 RID: 4386 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndHealAnotherTarget()
	{
		throw null;
	}

	// Token: 0x06001123 RID: 4387 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndAxeTarget()
	{
		throw null;
	}

	// Token: 0x06001124 RID: 4388 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndStimulators()
	{
		throw null;
	}

	// Token: 0x06001125 RID: 4389 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndShootFromStationary()
	{
		throw null;
	}

	// Token: 0x06001126 RID: 4390 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndSuppressStationary()
	{
		throw null;
	}

	// Token: 0x06001127 RID: 4391 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndGrenadeSuicide()
	{
		throw null;
	}

	// Token: 0x06001128 RID: 4392 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndLeaveMap()
	{
		throw null;
	}

	// Token: 0x06001129 RID: 4393 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndDeadBody()
	{
		throw null;
	}

	// Token: 0x0600112A RID: 4394 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndFriendlyTilt()
	{
		throw null;
	}

	// Token: 0x0600112B RID: 4395 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndEatDrink()
	{
		throw null;
	}

	// Token: 0x0600112C RID: 4396 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndWatchSecondWeapon()
	{
		throw null;
	}

	// Token: 0x0600112D RID: 4397 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndRunToCoverZigZag()
	{
		throw null;
	}

	// Token: 0x0600112E RID: 4398 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndRunAwayGrenade()
	{
		throw null;
	}

	// Token: 0x0600112F RID: 4399 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndFollowerPatrolItem()
	{
		throw null;
	}

	// Token: 0x06001130 RID: 4400 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndAlternativePatrol()
	{
		throw null;
	}

	// Token: 0x06001131 RID: 4401 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndTakeItem()
	{
		throw null;
	}

	// Token: 0x06001132 RID: 4402 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndDropItem()
	{
		throw null;
	}

	// Token: 0x06001133 RID: 4403 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndGestus()
	{
		throw null;
	}

	// Token: 0x06001134 RID: 4404 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndPeaceful()
	{
		throw null;
	}

	// Token: 0x06001135 RID: 4405 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndPeaceHardAim()
	{
		throw null;
	}

	// Token: 0x06001136 RID: 4406 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndPeaceLook()
	{
		throw null;
	}

	// Token: 0x06001137 RID: 4407 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndGoToEnemy()
	{
		throw null;
	}

	// Token: 0x06001138 RID: 4408 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndHoldPosition()
	{
		throw null;
	}

	// Token: 0x06001139 RID: 4409 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndFlashed()
	{
		throw null;
	}

	// Token: 0x0600113A RID: 4410 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndShootToSmoke()
	{
		throw null;
	}

	// Token: 0x0600113B RID: 4411 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndDoorOpenRequest()
	{
		throw null;
	}

	// Token: 0x0600113C RID: 4412 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndWarnPlayerRequest()
	{
		throw null;
	}

	// Token: 0x0600113D RID: 4413 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndFollowMeRequest()
	{
		throw null;
	}

	// Token: 0x0600113E RID: 4414 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndDebugMove()
	{
		throw null;
	}

	// Token: 0x0600113F RID: 4415 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndDebugRun()
	{
		throw null;
	}

	// Token: 0x06001140 RID: 4416 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndDebugDrop()
	{
		throw null;
	}

	// Token: 0x06001141 RID: 4417 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndDebugTake()
	{
		throw null;
	}

	// Token: 0x06001142 RID: 4418 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndDebugGestus()
	{
		throw null;
	}

	// Token: 0x06001143 RID: 4419 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndDebugLay()
	{
		throw null;
	}

	// Token: 0x06001144 RID: 4420 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndDebugGrenade()
	{
		throw null;
	}

	// Token: 0x06001145 RID: 4421 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndDebugMelee()
	{
		throw null;
	}

	// Token: 0x06001146 RID: 4422 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndDebugShuttle()
	{
		throw null;
	}

	// Token: 0x06001147 RID: 4423 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndDebugMeleeChange()
	{
		throw null;
	}

	// Token: 0x06001148 RID: 4424 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndDebugRotateHead()
	{
		throw null;
	}

	// Token: 0x06001149 RID: 4425 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndDebugRotate()
	{
		throw null;
	}

	// Token: 0x0600114A RID: 4426 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndDebugRotateLay()
	{
		throw null;
	}

	// Token: 0x0600114B RID: 4427 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndDebugRunToPoint()
	{
		throw null;
	}

	// Token: 0x0600114C RID: 4428 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndDebugRunToCloseCover()
	{
		throw null;
	}

	// Token: 0x0600114D RID: 4429 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndDebugZigZagRunNode()
	{
		throw null;
	}

	// Token: 0x0600114E RID: 4430 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndMedsNode()
	{
		throw null;
	}

	// Token: 0x0600114F RID: 4431 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndDebugShoot()
	{
		throw null;
	}

	// Token: 0x06001150 RID: 4432 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndDebugStationary()
	{
		throw null;
	}

	// Token: 0x06001151 RID: 4433 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual AICoreActionEndStruct EndDebugWeaponChange()
	{
		throw null;
	}

	// Token: 0x0400100B RID: 4107
	protected BotOwner botOwner_0;

	// Token: 0x0400100C RID: 4108
	protected bool bool_1;

	// Token: 0x0400100D RID: 4109
	protected AICoreActionEndStruct gstruct7_0;

	// Token: 0x0400100E RID: 4110
	protected AICoreActionEndStruct gstruct7_1;

	// Token: 0x0400100F RID: 4111
	[CompilerGenerated]
	private readonly int int_0;
}
