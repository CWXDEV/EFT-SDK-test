using System;

namespace EFT.Counters
{
	// Token: 0x02001ED9 RID: 7897
	public enum CounterTag
	{
		// Token: 0x0400A99F RID: 43423
		LootItem,
		// Token: 0x0400A9A0 RID: 43424
		HeadShots,
		// Token: 0x0400A9A1 RID: 43425
		BloodLoss,
		// Token: 0x0400A9A2 RID: 43426
		BodyPartsDestroyed,
		// Token: 0x0400A9A3 RID: 43427
		BodyPartDamage,
		// Token: 0x0400A9A4 RID: 43428
		Heal,
		// Token: 0x0400A9A5 RID: 43429
		Fractures,
		// Token: 0x0400A9A6 RID: 43430
		Contusions,
		// Token: 0x0400A9A7 RID: 43431
		Dehydrations,
		// Token: 0x0400A9A8 RID: 43432
		Exhaustions,
		// Token: 0x0400A9A9 RID: 43433
		Medicines,
		// Token: 0x0400A9AA RID: 43434
		UsedFoods,
		// Token: 0x0400A9AB RID: 43435
		UsedDrinks,
		// Token: 0x0400A9AC RID: 43436
		TriggerVisited,
		// Token: 0x0400A9AD RID: 43437
		Triggers,
		// Token: 0x0400A9AE RID: 43438
		Pedometer,
		// Token: 0x0400A9AF RID: 43439
		Money,
		// Token: 0x0400A9B0 RID: 43440
		BodiesLooted,
		// Token: 0x0400A9B1 RID: 43441
		SafeLooted,
		// Token: 0x0400A9B2 RID: 43442
		LockableContainers,
		// Token: 0x0400A9B3 RID: 43443
		Weapons,
		// Token: 0x0400A9B4 RID: 43444
		Ammunitions,
		// Token: 0x0400A9B5 RID: 43445
		Mods,
		// Token: 0x0400A9B6 RID: 43446
		ThrowWeapons,
		// Token: 0x0400A9B7 RID: 43447
		SpecialItems,
		// Token: 0x0400A9B8 RID: 43448
		FoodDrinks,
		// Token: 0x0400A9B9 RID: 43449
		Keys,
		// Token: 0x0400A9BA RID: 43450
		BartItems,
		// Token: 0x0400A9BB RID: 43451
		MobContainers,
		// Token: 0x0400A9BC RID: 43452
		Equipments,
		// Token: 0x0400A9BD RID: 43453
		CauseBodyDamage,
		// Token: 0x0400A9BE RID: 43454
		CauseArmorDamage,
		// Token: 0x0400A9BF RID: 43455
		HitCount,
		// Token: 0x0400A9C0 RID: 43456
		LongShots,
		// Token: 0x0400A9C1 RID: 43457
		LongestShot,
		// Token: 0x0400A9C2 RID: 43458
		LongestKillShot,
		// Token: 0x0400A9C3 RID: 43459
		LongestKillShotOnBot,
		// Token: 0x0400A9C4 RID: 43460
		CurrentWinStreak,
		// Token: 0x0400A9C5 RID: 43461
		LongestWinStreak,
		// Token: 0x0400A9C6 RID: 43462
		Sessions,
		// Token: 0x0400A9C7 RID: 43463
		ExitStatus,
		// Token: 0x0400A9C8 RID: 43464
		Pmc,
		// Token: 0x0400A9C9 RID: 43465
		Scav,
		// Token: 0x0400A9CA RID: 43466
		LifeTime,
		// Token: 0x0400A9CB RID: 43467
		AmmoUsed,
		// Token: 0x0400A9CC RID: 43468
		AmmoReached,
		// Token: 0x0400A9CD RID: 43469
		Deaths,
		// Token: 0x0400A9CE RID: 43470
		KilledLevel0010,
		// Token: 0x0400A9CF RID: 43471
		KilledLevel1030,
		// Token: 0x0400A9D0 RID: 43472
		KilledLevel3050,
		// Token: 0x0400A9D1 RID: 43473
		KilledLevel5070,
		// Token: 0x0400A9D2 RID: 43474
		KilledLevel7099,
		// Token: 0x0400A9D3 RID: 43475
		KilledLevel100,
		// Token: 0x0400A9D4 RID: 43476
		KilledBear,
		// Token: 0x0400A9D5 RID: 43477
		KilledUsec,
		// Token: 0x0400A9D6 RID: 43478
		KilledSavage,
		// Token: 0x0400A9D7 RID: 43479
		KilledPmc,
		// Token: 0x0400A9D8 RID: 43480
		KilledBoss,
		// Token: 0x0400A9D9 RID: 43481
		LongestKillStreak,
		// Token: 0x0400A9DA RID: 43482
		KilledWithKnife,
		// Token: 0x0400A9DB RID: 43483
		KilledWithPistol,
		// Token: 0x0400A9DC RID: 43484
		KilledWithSmg,
		// Token: 0x0400A9DD RID: 43485
		KilledWithShotgun,
		// Token: 0x0400A9DE RID: 43486
		KilledWithAssaultRifle,
		// Token: 0x0400A9DF RID: 43487
		KilledWithAssaultCarbine,
		// Token: 0x0400A9E0 RID: 43488
		KilledWithGrenadeLauncher,
		// Token: 0x0400A9E1 RID: 43489
		KilledWithMachineGun,
		// Token: 0x0400A9E2 RID: 43490
		KilledWithMarksmanRifle,
		// Token: 0x0400A9E3 RID: 43491
		KilledWithSniperRifle,
		// Token: 0x0400A9E4 RID: 43492
		KilledWithSpecialWeapon,
		// Token: 0x0400A9E5 RID: 43493
		KilledWithThrowWeapon,
		// Token: 0x0400A9E6 RID: 43494
		KilledWithTemplate,
		// Token: 0x0400A9E7 RID: 43495
		KilledBossName,
		// Token: 0x0400A9E8 RID: 43496
		RSPShoot,
		// Token: 0x0400A9E9 RID: 43497
		Kills,
		// Token: 0x0400A9EA RID: 43498
		Exp,
		// Token: 0x0400A9EB RID: 43499
		ExpKill,
		// Token: 0x0400A9EC RID: 43500
		ExpLooting,
		// Token: 0x0400A9ED RID: 43501
		ExpKillBase,
		// Token: 0x0400A9EE RID: 43502
		ExpKillBodyPartBonus,
		// Token: 0x0400A9EF RID: 43503
		ExpKillStreakBonus,
		// Token: 0x0400A9F0 RID: 43504
		ExpDamage,
		// Token: 0x0400A9F1 RID: 43505
		ExpItemLooting,
		// Token: 0x0400A9F2 RID: 43506
		ExpContainerLooting,
		// Token: 0x0400A9F3 RID: 43507
		ExpDoorUnlocked,
		// Token: 0x0400A9F4 RID: 43508
		ExpDoorBreached,
		// Token: 0x0400A9F5 RID: 43509
		ExpHeal,
		// Token: 0x0400A9F6 RID: 43510
		ExpEnergy,
		// Token: 0x0400A9F7 RID: 43511
		ExpHydration,
		// Token: 0x0400A9F8 RID: 43512
		ExpExitStatus,
		// Token: 0x0400A9F9 RID: 43513
		ExpTrigger,
		// Token: 0x0400A9FA RID: 43514
		ExpStationaryContainer,
		// Token: 0x0400A9FB RID: 43515
		ExpExamine,
		// Token: 0x0400A9FC RID: 43516
		FenceStanding,
		// Token: 0x0400A9FD RID: 43517
		CombatDamage,
		// Token: 0x0400A9FE RID: 43518
		UsecRaidRemainKills,
		// Token: 0x0400A9FF RID: 43519
		RepeatableQuest,
		// Token: 0x0400AA00 RID: 43520
		DailyTotalCompleteCount,
		// Token: 0x0400AA01 RID: 43521
		DailyVeryEasyCount,
		// Token: 0x0400AA02 RID: 43522
		DailyEasyCount,
		// Token: 0x0400AA03 RID: 43523
		DailyMediumCount,
		// Token: 0x0400AA04 RID: 43524
		DailyHardCount,
		// Token: 0x0400AA05 RID: 43525
		DailyVeryHardCount,
		// Token: 0x0400AA06 RID: 43526
		DailyAvgCompletionTimeDay,
		// Token: 0x0400AA07 RID: 43527
		DailyAvgCompletionTimeWeek,
		// Token: 0x0400AA08 RID: 43528
		DailyMaxCompleteStreak,
		// Token: 0x0400AA09 RID: 43529
		DailyCurrentCompleteStreak,
		// Token: 0x0400AA0A RID: 43530
		QuestTypes,
		// Token: 0x0400AA0B RID: 43531
		DailyTotalFailCount,
		// Token: 0x0400AA0C RID: 43532
		DailyMaxFailStreak,
		// Token: 0x0400AA0D RID: 43533
		DailyMoneyEarned,
		// Token: 0x0400AA0E RID: 43534
		DailyExpEarned,
		// Token: 0x0400AA0F RID: 43535
		ShootingRangePoints,
		// Token: 0x0400AA10 RID: 43536
		LightkeeperVisited,
		// Token: 0x0400AA11 RID: 43537
		LightkeeperWhoAreYou,
		// Token: 0x0400AA12 RID: 43538
		BtrNews
	}
}
