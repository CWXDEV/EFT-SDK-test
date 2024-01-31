using System;

namespace EFT.NextObservedPlayer
{
	// Token: 0x02001F27 RID: 7975
	public enum CommandMessageType
	{
		// Token: 0x0400ACA9 RID: 44201
		None,
		// Token: 0x0400ACAA RID: 44202
		Death,
		// Token: 0x0400ACAB RID: 44203
		Phrase,
		// Token: 0x0400ACAC RID: 44204
		SkillParameters,
		// Token: 0x0400ACAD RID: 44205
		Temperature,
		// Token: 0x0400ACAE RID: 44206
		HealthStatus,
		// Token: 0x0400ACAF RID: 44207
		MedEffectStatus,
		// Token: 0x0400ACB0 RID: 44208
		MedEffectResource,
		// Token: 0x0400ACB1 RID: 44209
		PhysicalParameters,
		// Token: 0x0400ACB2 RID: 44210
		VoIP,
		// Token: 0x0400ACB3 RID: 44211
		TakeDamage,
		// Token: 0x0400ACB4 RID: 44212
		HeadDeviceInfo,
		// Token: 0x0400ACB5 RID: 44213
		EffectOnPlayer,
		// Token: 0x0400ACB6 RID: 44214
		SetAnimationLayerWeight,
		// Token: 0x0400ACB7 RID: 44215
		SetHands,
		// Token: 0x0400ACB8 RID: 44216
		ShotFirearm,
		// Token: 0x0400ACB9 RID: 44217
		DryShotFirearm,
		// Token: 0x0400ACBA RID: 44218
		FlareShotFirearm,
		// Token: 0x0400ACBB RID: 44219
		SwingGrenade,
		// Token: 0x0400ACBC RID: 44220
		ThrowGrenade,
		// Token: 0x0400ACBD RID: 44221
		Gesture,
		// Token: 0x0400ACBE RID: 44222
		ArmorChangedInfo,
		// Token: 0x0400ACBF RID: 44223
		ArmorDurabilityChanged,
		// Token: 0x0400ACC0 RID: 44224
		EquipChanged,
		// Token: 0x0400ACC1 RID: 44225
		ExamineWeapon,
		// Token: 0x0400ACC2 RID: 44226
		ChangeFireMode,
		// Token: 0x0400ACC3 RID: 44227
		TacticalModeToggle,
		// Token: 0x0400ACC4 RID: 44228
		ScopeModeToggle,
		// Token: 0x0400ACC5 RID: 44229
		ModChanged,
		// Token: 0x0400ACC6 RID: 44230
		SingleBarrelReloadStart,
		// Token: 0x0400ACC7 RID: 44231
		SetChamberState,
		// Token: 0x0400ACC8 RID: 44232
		Malfunction,
		// Token: 0x0400ACC9 RID: 44233
		RepairMalfunction,
		// Token: 0x0400ACCA RID: 44234
		ReloadExternalMagazine,
		// Token: 0x0400ACCB RID: 44235
		SetExternalMagazineState,
		// Token: 0x0400ACCC RID: 44236
		ReloadInternalMagazine,
		// Token: 0x0400ACCD RID: 44237
		ReloadCylinderMagazine,
		// Token: 0x0400ACCE RID: 44238
		AbortReloadCylinderMagazine,
		// Token: 0x0400ACCF RID: 44239
		SyncCylinderMagazine,
		// Token: 0x0400ACD0 RID: 44240
		RollCylinder,
		// Token: 0x0400ACD1 RID: 44241
		CylinderCamoraIndex,
		// Token: 0x0400ACD2 RID: 44242
		Rechamber,
		// Token: 0x0400ACD3 RID: 44243
		LoadAmmoToChamber,
		// Token: 0x0400ACD4 RID: 44244
		DischargeChamber,
		// Token: 0x0400ACD5 RID: 44245
		LoadAmmoToCamora,
		// Token: 0x0400ACD6 RID: 44246
		DischargeAmmoFromCamora,
		// Token: 0x0400ACD7 RID: 44247
		ToggleUnderbarrel,
		// Token: 0x0400ACD8 RID: 44248
		UnderbarrelShot,
		// Token: 0x0400ACD9 RID: 44249
		UnderbarrelReload,
		// Token: 0x0400ACDA RID: 44250
		UnderbarrelRangeValue,
		// Token: 0x0400ACDB RID: 44251
		LoadAmmoToUnderbarrel,
		// Token: 0x0400ACDC RID: 44252
		DischargeAmmoFromUnderbarrel,
		// Token: 0x0400ACDD RID: 44253
		BoltActionReloadAfterFire,
		// Token: 0x0400ACDE RID: 44254
		Interact,
		// Token: 0x0400ACDF RID: 44255
		DoorUnlockInteraction,
		// Token: 0x0400ACE0 RID: 44256
		DoorBreachInteraction,
		// Token: 0x0400ACE1 RID: 44257
		BtrGoInInteraction,
		// Token: 0x0400ACE2 RID: 44258
		BtrGoOutInteraction,
		// Token: 0x0400ACE3 RID: 44259
		InventoryOpenStatus,
		// Token: 0x0400ACE4 RID: 44260
		Aiming,
		// Token: 0x0400ACE5 RID: 44261
		CompassState,
		// Token: 0x0400ACE6 RID: 44262
		MeleeAttack,
		// Token: 0x0400ACE7 RID: 44263
		BreakMeleeCombo,
		// Token: 0x0400ACE8 RID: 44264
		IdleStateSync,
		// Token: 0x0400ACE9 RID: 44265
		RadioTransmitterStatus,
		// Token: 0x0400ACEA RID: 44266
		InventoryOperation,
		// Token: 0x0400ACEB RID: 44267
		SetStationaryWeapon,
		// Token: 0x0400ACEC RID: 44268
		SyncStationaryMagazine,
		// Token: 0x0400ACED RID: 44269
		InsertMagazine,
		// Token: 0x0400ACEE RID: 44270
		PullOutMagazine,
		// Token: 0x0400ACEF RID: 44271
		MagAndChamberState,
		// Token: 0x0400ACF0 RID: 44272
		ThrowItemAsLoot,
		// Token: 0x0400ACF1 RID: 44273
		ReloadInternalMagWithOpenBolt,
		// Token: 0x0400ACF2 RID: 44274
		SetAbortReloadInternalMagWithOpenBolt,
		// Token: 0x0400ACF3 RID: 44275
		SetFinishReloadInternalMagWithOpenBolt,
		// Token: 0x0400ACF4 RID: 44276
		ReloadMultiBarrelWeapon,
		// Token: 0x0400ACF5 RID: 44277
		Pickup,
		// Token: 0x0400ACF6 RID: 44278
		StartSearchContent,
		// Token: 0x0400ACF7 RID: 44279
		StopSearchContent,
		// Token: 0x0400ACF8 RID: 44280
		SetLeftStance,
		// Token: 0x0400ACF9 RID: 44281
		SetVoiceMuffledStatus,
		// Token: 0x0400ACFA RID: 44282
		SetUnderRoofStatus
	}
}
