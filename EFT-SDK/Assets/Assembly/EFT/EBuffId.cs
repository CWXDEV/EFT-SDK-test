using System;

namespace EFT
{
	// Token: 0x0200165B RID: 5723
	public enum EBuffId
	{
		// Token: 0x040081F5 RID: 33269
		None,
		// Token: 0x040081F6 RID: 33270
		EnduranceBuffEnduranceInc,
		// Token: 0x040081F7 RID: 33271
		EnduranceBuffJumpCostRed,
		// Token: 0x040081F8 RID: 33272
		EnduranceBuffBreathTimeInc,
		// Token: 0x040081F9 RID: 33273
		EnduranceBuffRestorationTimeRed,
		// Token: 0x040081FA RID: 33274
		EnduranceBreathElite,
		// Token: 0x040081FB RID: 33275
		EnduranceHands,
		// Token: 0x040081FC RID: 33276
		StrengthBuffLiftWeightInc,
		// Token: 0x040081FD RID: 33277
		StrengthBuffSprintSpeedInc,
		// Token: 0x040081FE RID: 33278
		StrengthBuffJumpHeightInc,
		// Token: 0x040081FF RID: 33279
		StrengthBuffThrowDistanceInc,
		// Token: 0x04008200 RID: 33280
		StrengthBuffMeleePowerInc,
		// Token: 0x04008201 RID: 33281
		StrengthBuffElite,
		// Token: 0x04008202 RID: 33282
		StrengthBuffMeleeCrits,
		// Token: 0x04008203 RID: 33283
		StrengthBuffAim,
		// Token: 0x04008204 RID: 33284
		VitalityBuffBleedChanceRed,
		// Token: 0x04008205 RID: 33285
		VitalityBuffSurviobilityInc,
		// Token: 0x04008206 RID: 33286
		VitalityBuffRegeneration,
		// Token: 0x04008207 RID: 33287
		VitalityBuffBleedStop,
		// Token: 0x04008208 RID: 33288
		HealthBreakChanceRed,
		// Token: 0x04008209 RID: 33289
		HealthOfflineRegenerationInc,
		// Token: 0x0400820A RID: 33290
		HealthEnergy,
		// Token: 0x0400820B RID: 33291
		HealthHydration,
		// Token: 0x0400820C RID: 33292
		HealthEliteAbsorbDamage,
		// Token: 0x0400820D RID: 33293
		HealthElitePosion,
		// Token: 0x0400820E RID: 33294
		StressPainChance,
		// Token: 0x0400820F RID: 33295
		StressTremor,
		// Token: 0x04008210 RID: 33296
		StressBerserk,
		// Token: 0x04008211 RID: 33297
		MetabolismRatioPlus,
		// Token: 0x04008212 RID: 33298
		MetabolismEnergyExpenses,
		// Token: 0x04008213 RID: 33299
		MetabolismPhysicsForget,
		// Token: 0x04008214 RID: 33300
		MetabolismPhysicsForget2,
		// Token: 0x04008215 RID: 33301
		MetabolismEliteBuffNoDyhydration,
		// Token: 0x04008216 RID: 33302
		MetabolismEliteNoForget,
		// Token: 0x04008217 RID: 33303
		PerceptionHearing,
		// Token: 0x04008218 RID: 33304
		PerceptionFov,
		// Token: 0x04008219 RID: 33305
		PerceptionLootDot,
		// Token: 0x0400821A RID: 33306
		PerceptionmEliteNoIdea,
		// Token: 0x0400821B RID: 33307
		IntellectLearningSpeed,
		// Token: 0x0400821C RID: 33308
		IntellectWeaponMaintance,
		// Token: 0x0400821D RID: 33309
		IntellectEliteNaturalLearner,
		// Token: 0x0400821E RID: 33310
		IntellectEliteAmmoCounter,
		// Token: 0x0400821F RID: 33311
		IntellectEliteContainerScope,
		// Token: 0x04008220 RID: 33312
		IntellectRepairPointsCostReduction,
		// Token: 0x04008221 RID: 33313
		AttentionLootSpeed,
		// Token: 0x04008222 RID: 33314
		AttentionRareLoot,
		// Token: 0x04008223 RID: 33315
		AttentionEliteLuckySearch,
		// Token: 0x04008224 RID: 33316
		AttentionEliteExtraLootExp,
		// Token: 0x04008225 RID: 33317
		MagDrillsLoadSpeed,
		// Token: 0x04008226 RID: 33318
		MagDrillsUnloadSpeed,
		// Token: 0x04008227 RID: 33319
		MagDrillsInventoryCheckSpeed,
		// Token: 0x04008228 RID: 33320
		MagDrillsInventoryCheckAccuracy,
		// Token: 0x04008229 RID: 33321
		MagDrillsInstantCheck,
		// Token: 0x0400822A RID: 33322
		MagDrillsLoadProgression,
		// Token: 0x0400822B RID: 33323
		CharismaBuff1,
		// Token: 0x0400822C RID: 33324
		CharismaBuff2,
		// Token: 0x0400822D RID: 33325
		CharismaEliteBuff1,
		// Token: 0x0400822E RID: 33326
		CharismaEliteBuff2,
		// Token: 0x0400822F RID: 33327
		CharismaDailyQuestsRerollDiscount,
		// Token: 0x04008230 RID: 33328
		CharismaHealingDiscount,
		// Token: 0x04008231 RID: 33329
		CharismaInsuranceDiscount,
		// Token: 0x04008232 RID: 33330
		CharismaExfiltrationDiscount,
		// Token: 0x04008233 RID: 33331
		CharismaScavCaseDiscount,
		// Token: 0x04008234 RID: 33332
		CharismaFenceRepPenaltyReduction,
		// Token: 0x04008235 RID: 33333
		CharismaAdditionalDailyQuests,
		// Token: 0x04008236 RID: 33334
		MemoryMentalForget1,
		// Token: 0x04008237 RID: 33335
		MemoryMentalForget2,
		// Token: 0x04008238 RID: 33336
		MemoryEliteMentalNoDegradation,
		// Token: 0x04008239 RID: 33337
		WeaponReloadBuff,
		// Token: 0x0400823A RID: 33338
		WeaponRecoilBuff,
		// Token: 0x0400823B RID: 33339
		WeaponSwapBuff,
		// Token: 0x0400823C RID: 33340
		DrawSpeed,
		// Token: 0x0400823D RID: 33341
		DrawElite,
		// Token: 0x0400823E RID: 33342
		DrawTremor,
		// Token: 0x0400823F RID: 33343
		DrawSound,
		// Token: 0x04008240 RID: 33344
		AimMasterElite,
		// Token: 0x04008241 RID: 33345
		AimMasterWiggle,
		// Token: 0x04008242 RID: 33346
		AimMasterSpeed,
		// Token: 0x04008243 RID: 33347
		RecoilControlImprove,
		// Token: 0x04008244 RID: 33348
		RecoilControlElite,
		// Token: 0x04008245 RID: 33349
		CovertMovementSoundVolume,
		// Token: 0x04008246 RID: 33350
		ProneMovementSpeed,
		// Token: 0x04008247 RID: 33351
		ProneMovementVolume,
		// Token: 0x04008248 RID: 33352
		ProneMovementElite,
		// Token: 0x04008249 RID: 33353
		TroubleFixing,
		// Token: 0x0400824A RID: 33354
		TroubleFixingAmmoElite,
		// Token: 0x0400824B RID: 33355
		TroubleFixingExamineMalfElite,
		// Token: 0x0400824C RID: 33356
		WeaponErgonomicsBuff,
		// Token: 0x0400824D RID: 33357
		WeaponDoubleMastering,
		// Token: 0x0400824E RID: 33358
		WeaponDoubleActionRecoilReduceBuff,
		// Token: 0x0400824F RID: 33359
		WeaponStiffHands,
		// Token: 0x04008250 RID: 33360
		ThrowingStrengthBuff,
		// Token: 0x04008251 RID: 33361
		ThrowingEnergyExpenses,
		// Token: 0x04008252 RID: 33362
		ThrowingWeaponsBuffElite,
		// Token: 0x04008253 RID: 33363
		CovertMovementSpeed,
		// Token: 0x04008254 RID: 33364
		CovertMovementElite,
		// Token: 0x04008255 RID: 33365
		CovertMovementLoud,
		// Token: 0x04008256 RID: 33366
		CovertMovementEquipment,
		// Token: 0x04008257 RID: 33367
		SearchSpeed,
		// Token: 0x04008258 RID: 33368
		SearchDouble,
		// Token: 0x04008259 RID: 33369
		SurgeryReducePenalty,
		// Token: 0x0400825A RID: 33370
		SurgerySpeed,
		// Token: 0x0400825B RID: 33371
		HideoutResourceConsumption,
		// Token: 0x0400825C RID: 33372
		HideoutZoneBonusBoost,
		// Token: 0x0400825D RID: 33373
		HideoutExtraSlots,
		// Token: 0x0400825E RID: 33374
		CraftingElite,
		// Token: 0x0400825F RID: 33375
		CraftingSingleTimeReduce,
		// Token: 0x04008260 RID: 33376
		CraftingContinueTimeReduce,
		// Token: 0x04008261 RID: 33377
		MetabolismPoisonTime,
		// Token: 0x04008262 RID: 33378
		MetabolismMiscDebuffTime,
		// Token: 0x04008263 RID: 33379
		ImmunityMiscEffects,
		// Token: 0x04008264 RID: 33380
		ImmunityPoisonBuff,
		// Token: 0x04008265 RID: 33381
		ImmunityPainKiller,
		// Token: 0x04008266 RID: 33382
		ImmunityPoisonChance,
		// Token: 0x04008267 RID: 33383
		ImmunityMiscEffectsChance,
		// Token: 0x04008268 RID: 33384
		WeaponDurabilityLossOnShotReduce,
		// Token: 0x04008269 RID: 33385
		WearAmountRepairGunsReducePerLevel,
		// Token: 0x0400826A RID: 33386
		WearChanceRepairGunsReduceEliteLevel,
		// Token: 0x0400826B RID: 33387
		TroubleFixingMagElite,
		// Token: 0x0400826C RID: 33388
		TroubleFixingDurElite,
		// Token: 0x0400826D RID: 33389
		LightVestMoveSpeedPenaltyReduction,
		// Token: 0x0400826E RID: 33390
		LightVestMeleeWeaponDamageReduction,
		// Token: 0x0400826F RID: 33391
		LightVestRepairDegradationReduction,
		// Token: 0x04008270 RID: 33392
		LightVestBleedingProtection,
		// Token: 0x04008271 RID: 33393
		LightVestDeteriorationChanceOnRepairReduce,
		// Token: 0x04008272 RID: 33394
		HeavyVestMoveSpeedPenaltyReduction,
		// Token: 0x04008273 RID: 33395
		HeavyVestBluntThroughputDamageReduction,
		// Token: 0x04008274 RID: 33396
		HeavyVestRepairDegradationReduction,
		// Token: 0x04008275 RID: 33397
		HeavyVestNoBodyDamageDeflectChance,
		// Token: 0x04008276 RID: 33398
		HeavyVestDeteriorationChanceOnRepairReduce
	}
}
