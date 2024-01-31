using System;

namespace BitPacking
{
	// Token: 0x02000F91 RID: 3985
	public enum BitPackingTag
	{
		// Token: 0x04005F3A RID: 24378
		Unknown,
		// Token: 0x04005F3B RID: 24379
		DebugBotStruct1,
		// Token: 0x04005F3C RID: 24380
		DebugBotStruct2,
		// Token: 0x04005F3D RID: 24381
		DebugBotStruct3,
		// Token: 0x04005F3E RID: 24382
		DebugBotStruct4,
		// Token: 0x04005F3F RID: 24383
		DebugBotStruct5,
		// Token: 0x04005F40 RID: 24384
		DebugBotStruct6,
		// Token: 0x04005F41 RID: 24385
		DebugBotStruct7,
		// Token: 0x04005F42 RID: 24386
		DebugBotStruct8,
		// Token: 0x04005F43 RID: 24387
		DebugBotStruct9,
		// Token: 0x04005F44 RID: 24388
		DebugBotStruct10,
		// Token: 0x04005F45 RID: 24389
		DebugBotStruct11,
		// Token: 0x04005F46 RID: 24390
		DebugBotStruct12,
		// Token: 0x04005F47 RID: 24391
		DebugBotStruct13,
		// Token: 0x04005F48 RID: 24392
		DebugBotStruct14,
		// Token: 0x04005F49 RID: 24393
		DebugBotStruct15,
		// Token: 0x04005F4A RID: 24394
		DebugBotStruct16,
		// Token: 0x04005F4B RID: 24395
		DebugBotStruct17,
		// Token: 0x04005F4C RID: 24396
		DebugBotStruct18,
		// Token: 0x04005F4D RID: 24397
		DebugBotSpawnStructDataAlive,
		// Token: 0x04005F4E RID: 24398
		DebugBotSpawnStructDataProfileWait,
		// Token: 0x04005F4F RID: 24399
		DebugBotSpawnStructDataDelayed,
		// Token: 0x04005F50 RID: 24400
		DebugBotSpawnStructDataSpawnProcess,
		// Token: 0x04005F51 RID: 24401
		DebugBotSpawnStructDataSpawnHour,
		// Token: 0x04005F52 RID: 24402
		DebugBotSpawnStructDataGroupsCount,
		// Token: 0x04005F53 RID: 24403
		DebugBotSpawnStructDataGroupsCountArray,
		// Token: 0x04005F54 RID: 24404
		DebugBotSpawnStructDataSpawnBundlesWait,
		// Token: 0x04005F55 RID: 24405
		DebugGroupStructA,
		// Token: 0x04005F56 RID: 24406
		DebugGroupStructB,
		// Token: 0x04005F57 RID: 24407
		DebugGroupStructC,
		// Token: 0x04005F58 RID: 24408
		DebugGroupStructD,
		// Token: 0x04005F59 RID: 24409
		DebugGroupStructF,
		// Token: 0x04005F5A RID: 24410
		DebugGroupStructG,
		// Token: 0x04005F5B RID: 24411
		DebugGroupStructGE,
		// Token: 0x04005F5C RID: 24412
		DebugGroupStructGN,
		// Token: 0x04005F5D RID: 24413
		DebugGroupStructGA,
		// Token: 0x04005F5E RID: 24414
		GameWorldPacketExtension1,
		// Token: 0x04005F5F RID: 24415
		GameWorldPacketExtension2,
		// Token: 0x04005F60 RID: 24416
		GameWorldPacketExtension3,
		// Token: 0x04005F61 RID: 24417
		GameWorldPacketExtension4,
		// Token: 0x04005F62 RID: 24418
		QuaternionQuantizer,
		// Token: 0x04005F63 RID: 24419
		WriteUInt32UsingBitRange1,
		// Token: 0x04005F64 RID: 24420
		WriteUInt32UsingBitRange2,
		// Token: 0x04005F65 RID: 24421
		PhraseCommandPacket0,
		// Token: 0x04005F66 RID: 24422
		PhraseCommandPacket1,
		// Token: 0x04005F67 RID: 24423
		LimitedIntSettings,
		// Token: 0x04005F68 RID: 24424
		Client2ServerPacket0,
		// Token: 0x04005F69 RID: 24425
		Client2ServerPacket1,
		// Token: 0x04005F6A RID: 24426
		Client2ServerPacket2,
		// Token: 0x04005F6B RID: 24427
		Client2ServerPacket3,
		// Token: 0x04005F6C RID: 24428
		InteractWithDoorPacket0,
		// Token: 0x04005F6D RID: 24429
		InteractWithDoorPacket1,
		// Token: 0x04005F6E RID: 24430
		MovementInfoPacket0,
		// Token: 0x04005F6F RID: 24431
		MovementInfoPacket1,
		// Token: 0x04005F70 RID: 24432
		MovementInfoPacket2,
		// Token: 0x04005F71 RID: 24433
		MovementInfoPacket3,
		// Token: 0x04005F72 RID: 24434
		HandsChangePacket0,
		// Token: 0x04005F73 RID: 24435
		HandsChangePacket1,
		// Token: 0x04005F74 RID: 24436
		HandsChangePacket2,
		// Token: 0x04005F75 RID: 24437
		HandsChangePacket3,
		// Token: 0x04005F76 RID: 24438
		HandsChangePacket4,
		// Token: 0x04005F77 RID: 24439
		HandsChangePacket5,
		// Token: 0x04005F78 RID: 24440
		HandsChangePacket6,
		// Token: 0x04005F79 RID: 24441
		HandsChangePacket7,
		// Token: 0x04005F7A RID: 24442
		HandsChangePacket8,
		// Token: 0x04005F7B RID: 24443
		HandsChangePacket9,
		// Token: 0x04005F7C RID: 24444
		HandsChangePacket10,
		// Token: 0x04005F7D RID: 24445
		HandsChangePacket11,
		// Token: 0x04005F7E RID: 24446
		HandsChangePacket12,
		// Token: 0x04005F7F RID: 24447
		HandsChangePacket13,
		// Token: 0x04005F80 RID: 24448
		HandsChangePacket14,
		// Token: 0x04005F81 RID: 24449
		HandsChangePacket15,
		// Token: 0x04005F82 RID: 24450
		HandsChangePacket16,
		// Token: 0x04005F83 RID: 24451
		HandsChangePacket17,
		// Token: 0x04005F84 RID: 24452
		HandsChangePacket18,
		// Token: 0x04005F85 RID: 24453
		HandsChangePacket19,
		// Token: 0x04005F86 RID: 24454
		HandsChangePacket20,
		// Token: 0x04005F87 RID: 24455
		HandsChangePacket21,
		// Token: 0x04005F88 RID: 24456
		HandsChangePacket22,
		// Token: 0x04005F89 RID: 24457
		HandsChangePacket23,
		// Token: 0x04005F8A RID: 24458
		SelfPlayerInfo0,
		// Token: 0x04005F8B RID: 24459
		SelfPlayerInfo1,
		// Token: 0x04005F8C RID: 24460
		SelfPlayerInfo2,
		// Token: 0x04005F8D RID: 24461
		SelfPlayerInfo3,
		// Token: 0x04005F8E RID: 24462
		SelfPlayerInfo4,
		// Token: 0x04005F8F RID: 24463
		SelfPlayerInfo5,
		// Token: 0x04005F90 RID: 24464
		DetailedHitInfo0,
		// Token: 0x04005F91 RID: 24465
		DetailedHitInfo1,
		// Token: 0x04005F92 RID: 24466
		DetailedHitInfo2,
		// Token: 0x04005F93 RID: 24467
		DetailedHitInfo3,
		// Token: 0x04005F94 RID: 24468
		DetailedHitInfo4,
		// Token: 0x04005F95 RID: 24469
		InventoryOperationStatus,
		// Token: 0x04005F96 RID: 24470
		ServerWorld0,
		// Token: 0x04005F97 RID: 24471
		ServerWorld1,
		// Token: 0x04005F98 RID: 24472
		DebugBotDataSender0,
		// Token: 0x04005F99 RID: 24473
		DebugBotDataSender1,
		// Token: 0x04005F9A RID: 24474
		DebugBotDataSender2,
		// Token: 0x04005F9B RID: 24475
		DataSender0,
		// Token: 0x04005F9C RID: 24476
		DataSender1,
		// Token: 0x04005F9D RID: 24477
		DataSender2,
		// Token: 0x04005F9E RID: 24478
		DataSender3,
		// Token: 0x04005F9F RID: 24479
		ServerFixedUpdate,
		// Token: 0x04005FA0 RID: 24480
		ServerTime,
		// Token: 0x04005FA1 RID: 24481
		TrajectoryLengthSettings,
		// Token: 0x04005FA2 RID: 24482
		DamageSerializationSettings,
		// Token: 0x04005FA3 RID: 24483
		StaminaBurnRateSerializationSettings,
		// Token: 0x04005FA4 RID: 24484
		PenetrationPowerSerializationSettings,
		// Token: 0x04005FA5 RID: 24485
		ArmorDamageSerializationSettings,
		// Token: 0x04005FA6 RID: 24486
		HitCosSerializationSettings,
		// Token: 0x04005FA7 RID: 24487
		BulletMassGram,
		// Token: 0x04005FA8 RID: 24488
		BulletDiameterMilimeters,
		// Token: 0x04005FA9 RID: 24489
		BallisticCoefficient,
		// Token: 0x04005FAA RID: 24490
		DurationSettings,
		// Token: 0x04005FAB RID: 24491
		PoseLevelSettings,
		// Token: 0x04005FAC RID: 24492
		SpeedSettings,
		// Token: 0x04005FAD RID: 24493
		TiltSettings,
		// Token: 0x04005FAE RID: 24494
		DeltaTimeSettings,
		// Token: 0x04005FAF RID: 24495
		AddEffectEffectId,
		// Token: 0x04005FB0 RID: 24496
		RemoveEffect,
		// Token: 0x04005FB1 RID: 24497
		EffectNextState,
		// Token: 0x04005FB2 RID: 24498
		EffectStateTime,
		// Token: 0x04005FB3 RID: 24499
		EffectStrengthEffectId,
		// Token: 0x04005FB4 RID: 24500
		EffectMedResourceEffectId,
		// Token: 0x04005FB5 RID: 24501
		EffectStimulatorBuff0,
		// Token: 0x04005FB6 RID: 24502
		EffectStimulatorBuff1,
		// Token: 0x04005FB7 RID: 24503
		HealerDone,
		// Token: 0x04005FB8 RID: 24504
		ToggleTacticalComboPacket0,
		// Token: 0x04005FB9 RID: 24505
		SelectedMode,
		// Token: 0x04005FBA RID: 24506
		ScopeCalibrationIndex,
		// Token: 0x04005FBB RID: 24507
		SelectedMode0,
		// Token: 0x04005FBC RID: 24508
		ScopeIndexInsideSight0,
		// Token: 0x04005FBD RID: 24509
		ScopeCalibrationIndex0,
		// Token: 0x04005FBE RID: 24510
		SightsModePacketLength,
		// Token: 0x04005FBF RID: 24511
		AmmoIdsLength,
		// Token: 0x04005FC0 RID: 24512
		AmmoLoadedToMag,
		// Token: 0x04005FC1 RID: 24513
		BorderZonePacketPacketId,
		// Token: 0x04005FC2 RID: 24514
		IClientPlayerDataSenderPacketsCount,
		// Token: 0x04005FC3 RID: 24515
		LootSyncPacketRotationQuantizer,
		// Token: 0x04005FC4 RID: 24516
		CorpseSyncPacketRotationQuantizer,
		// Token: 0x04005FC5 RID: 24517
		GrenadeSyncPacketRotationQuantizer,
		// Token: 0x04005FC6 RID: 24518
		AddEffectStrength,
		// Token: 0x04005FC7 RID: 24519
		EffectStrengthStrength,
		// Token: 0x04005FC8 RID: 24520
		EffectMedResourceResource,
		// Token: 0x04005FC9 RID: 24521
		BodyHealth,
		// Token: 0x04005FCA RID: 24522
		Energy,
		// Token: 0x04005FCB RID: 24523
		Hydration,
		// Token: 0x04005FCC RID: 24524
		Temperature,
		// Token: 0x04005FCD RID: 24525
		Poison,
		// Token: 0x04005FCE RID: 24526
		HealthRatesHealRate,
		// Token: 0x04005FCF RID: 24527
		HealthRatesDamageRate,
		// Token: 0x04005FD0 RID: 24528
		HealthRatesDamageMultiplier,
		// Token: 0x04005FD1 RID: 24529
		HealthRatesEnergy,
		// Token: 0x04005FD2 RID: 24530
		HealthRatesHydration,
		// Token: 0x04005FD3 RID: 24531
		HealthRatesTemperature,
		// Token: 0x04005FD4 RID: 24532
		ArmorUpdateDurability,
		// Token: 0x04005FD5 RID: 24533
		HeadRotationX,
		// Token: 0x04005FD6 RID: 24534
		HeadRotationY,
		// Token: 0x04005FD7 RID: 24535
		ShotInfoFragmentId,
		// Token: 0x04005FD8 RID: 24536
		ShotInfoShotsCount,
		// Token: 0x04005FD9 RID: 24537
		InteractiveObjectsCount,
		// Token: 0x04005FDA RID: 24538
		LauncherReloadInfoAmmoIds,
		// Token: 0x04005FDB RID: 24539
		ArmorUpdateId,
		// Token: 0x04005FDC RID: 24540
		PoisonUpdateId,
		// Token: 0x04005FDD RID: 24541
		PoisonUpdateResource,
		// Token: 0x04005FDE RID: 24542
		InventoryOperationStatusError,
		// Token: 0x04005FDF RID: 24543
		DebugGroupStructName,
		// Token: 0x04005FE0 RID: 24544
		DebugGroupStructEnemiesCountId,
		// Token: 0x04005FE1 RID: 24545
		DebugBotStructName,
		// Token: 0x04005FE2 RID: 24546
		DebugBotStructTarget,
		// Token: 0x04005FE3 RID: 24547
		DebugBotStructProfileId,
		// Token: 0x04005FE4 RID: 24548
		DebugBotStructNodeInfo,
		// Token: 0x04005FE5 RID: 24549
		DebugBotStructNodeReasonInfo,
		// Token: 0x04005FE6 RID: 24550
		DebugBotStructFightType,
		// Token: 0x04005FE7 RID: 24551
		MedEffectItemId,
		// Token: 0x04005FE8 RID: 24552
		StimulatorBuffsName,
		// Token: 0x04005FE9 RID: 24553
		EInteractionTypeItemId,
		// Token: 0x04005FEA RID: 24554
		HandsChangePacketItemId,
		// Token: 0x04005FEB RID: 24555
		QuickReloadMagMagId,
		// Token: 0x04005FEC RID: 24556
		TacticalComboStatusId,
		// Token: 0x04005FED RID: 24557
		SightModeStatusId,
		// Token: 0x04005FEE RID: 24558
		ReloadMagPacketMagId,
		// Token: 0x04005FEF RID: 24559
		ReloadBarrelsAmmoId,
		// Token: 0x04005FF0 RID: 24560
		ReloadWithAmmoAmmoIds,
		// Token: 0x04005FF1 RID: 24561
		SearchedStateKey,
		// Token: 0x04005FF2 RID: 24562
		SearchableItemInfoId,
		// Token: 0x04005FF3 RID: 24563
		KnownItemsArrayString,
		// Token: 0x04005FF4 RID: 24564
		KnownItemsDictKey,
		// Token: 0x04005FF5 RID: 24565
		SearchableGridInfoId,
		// Token: 0x04005FF6 RID: 24566
		KnownItemsDictValue,
		// Token: 0x04005FF7 RID: 24567
		DebugZoneInfoStructZonesCount,
		// Token: 0x04005FF8 RID: 24568
		DebugZoneInfoStructWildTypesCount,
		// Token: 0x04005FF9 RID: 24569
		DebugZoneInfoStructZoneName,
		// Token: 0x04005FFA RID: 24570
		DebugZoneInfoStructBlockElement,
		// Token: 0x04005FFB RID: 24571
		DebugBotStructHandsAnim,
		// Token: 0x04005FFC RID: 24572
		DebugBotStructShotNameWeapon,
		// Token: 0x04005FFD RID: 24573
		const_195,
		// Token: 0x04005FFE RID: 24574
		const_196,
		// Token: 0x04005FFF RID: 24575
		ChamberFireIndex,
		// Token: 0x04006000 RID: 24576
		Overheat,
		// Token: 0x04006001 RID: 24577
		Halloween,
		// Token: 0x04006002 RID: 24578
		CamoraIndex,
		// Token: 0x04006003 RID: 24579
		Airplane,
		// Token: 0x04006004 RID: 24580
		DevelopSynchronizableData,
		// Token: 0x04006005 RID: 24581
		Airdrop,
		// Token: 0x04006006 RID: 24582
		SyncPacketObjectId,
		// Token: 0x04006007 RID: 24583
		GameWorldPacketSyncObjectsPacketsCount,
		// Token: 0x04006008 RID: 24584
		ConditionValue1,
		// Token: 0x04006009 RID: 24585
		ConditionValue2,
		// Token: 0x0400600A RID: 24586
		WeaponOverlap,
		// Token: 0x0400600B RID: 24587
		DataProvider,
		// Token: 0x0400600C RID: 24588
		InteractWithBtr
	}
}
