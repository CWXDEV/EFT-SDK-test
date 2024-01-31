using System;

namespace EFT.InventoryLogic
{
	// Token: 0x0200249D RID: 9373
	public enum EItemAttributeId
	{
		// Token: 0x0400BE4B RID: 48715
		Undefined,
		// Token: 0x0400BE4C RID: 48716
		ArmorZone,
		// Token: 0x0400BE4D RID: 48717
		Ricochet,
		// Token: 0x0400BE4E RID: 48718
		ArmorClass,
		// Token: 0x0400BE4F RID: 48719
		ArmorMaterial,
		// Token: 0x0400BE50 RID: 48720
		ChangeMovementSpeed,
		// Token: 0x0400BE51 RID: 48721
		ChangeTurningSpeed,
		// Token: 0x0400BE52 RID: 48722
		Ergonomics,
		// Token: 0x0400BE53 RID: 48723
		Mastering,
		// Token: 0x0400BE54 RID: 48724
		ArmorPoints,
		// Token: 0x0400BE55 RID: 48725
		CompatibleWith,
		// Token: 0x0400BE56 RID: 48726
		Weight,
		// Token: 0x0400BE57 RID: 48727
		ContainerSize,
		// Token: 0x0400BE58 RID: 48728
		Size,
		// Token: 0x0400BE59 RID: 48729
		MoneySum,
		// Token: 0x0400BE5A RID: 48730
		KeyUses,
		// Token: 0x0400BE5B RID: 48731
		Keys,
		// Token: 0x0400BE5C RID: 48732
		UseTime,
		// Token: 0x0400BE5D RID: 48733
		Nickname,
		// Token: 0x0400BE5E RID: 48734
		Side,
		// Token: 0x0400BE5F RID: 48735
		Level,
		// Token: 0x0400BE60 RID: 48736
		DeathTime,
		// Token: 0x0400BE61 RID: 48737
		Status,
		// Token: 0x0400BE62 RID: 48738
		Weapon,
		// Token: 0x0400BE63 RID: 48739
		KnifeHitRadius,
		// Token: 0x0400BE64 RID: 48740
		KnifeHitSlashDam,
		// Token: 0x0400BE65 RID: 48741
		KnifeHitStabDam,
		// Token: 0x0400BE66 RID: 48742
		HpResource,
		// Token: 0x0400BE67 RID: 48743
		MaxDurability,
		// Token: 0x0400BE68 RID: 48744
		Durability,
		// Token: 0x0400BE69 RID: 48745
		BulletSpeed,
		// Token: 0x0400BE6A RID: 48746
		Caliber,
		// Token: 0x0400BE6B RID: 48747
		CenterOfImpact,
		// Token: 0x0400BE6C RID: 48748
		Recoil,
		// Token: 0x0400BE6D RID: 48749
		HeavyBleedingDelta = 71,
		// Token: 0x0400BE6E RID: 48750
		LightBleedingDelta,
		// Token: 0x0400BE6F RID: 48751
		MaxCount = 34,
		// Token: 0x0400BE70 RID: 48752
		LoadUnloadSpeed,
		// Token: 0x0400BE71 RID: 48753
		CheckTimeSpeed,
		// Token: 0x0400BE72 RID: 48754
		MinCheckLevel,
		// Token: 0x0400BE73 RID: 48755
		RaidModdable,
		// Token: 0x0400BE74 RID: 48756
		EffectiveDistance,
		// Token: 0x0400BE75 RID: 48757
		Loudness,
		// Token: 0x0400BE76 RID: 48758
		Accuracy,
		// Token: 0x0400BE77 RID: 48759
		Velocity,
		// Token: 0x0400BE78 RID: 48760
		SightingRange,
		// Token: 0x0400BE79 RID: 48761
		OpticCrate = 57,
		// Token: 0x0400BE7A RID: 48762
		Resource = 44,
		// Token: 0x0400BE7B RID: 48763
		FoodResource = 55,
		// Token: 0x0400BE7C RID: 48764
		FuelResource,
		// Token: 0x0400BE7D RID: 48765
		PoisonedWeapon = 58,
		// Token: 0x0400BE7E RID: 48766
		ExplosionDelay = 45,
		// Token: 0x0400BE7F RID: 48767
		MaximumThrowDamage,
		// Token: 0x0400BE80 RID: 48768
		ExplosionDistance,
		// Token: 0x0400BE81 RID: 48769
		FragmentsCount,
		// Token: 0x0400BE82 RID: 48770
		RecoilUp,
		// Token: 0x0400BE83 RID: 48771
		RecoilBack,
		// Token: 0x0400BE84 RID: 48772
		WeaponFireType,
		// Token: 0x0400BE85 RID: 48773
		AmmoCaliber,
		// Token: 0x0400BE86 RID: 48774
		FireRate,
		// Token: 0x0400BE87 RID: 48775
		EffectiveDist,
		// Token: 0x0400BE88 RID: 48776
		SingleFireRate = 61,
		// Token: 0x0400BE89 RID: 48777
		BlindnessProtection = 60,
		// Token: 0x0400BE8A RID: 48778
		DurabilityBurn = 65,
		// Token: 0x0400BE8B RID: 48779
		MalfMisfireChance,
		// Token: 0x0400BE8C RID: 48780
		MalfFeedChance,
		// Token: 0x0400BE8D RID: 48781
		HeatFactor = 73,
		// Token: 0x0400BE8E RID: 48782
		CoolFactor,
		// Token: 0x0400BE8F RID: 48783
		PyrotechnicDelay = 68,
		// Token: 0x0400BE90 RID: 48784
		LimitedDiscard,
		// Token: 0x0400BE91 RID: 48785
		CanBeUsedInRaid = 75,
		// Token: 0x0400BE92 RID: 48786
		RepairResource,
		// Token: 0x0400BE93 RID: 48787
		MalfunctionProtectionCommonBuff,
		// Token: 0x0400BE94 RID: 48788
		WeaponSpreadCommonBuff,
		// Token: 0x0400BE95 RID: 48789
		DamageReductionCommonBuff,
		// Token: 0x0400BE96 RID: 48790
		MalfunctionProtectionRareBuff,
		// Token: 0x0400BE97 RID: 48791
		WeaponSpreadRareBuff,
		// Token: 0x0400BE98 RID: 48792
		DamageReductionRareBuff,
		// Token: 0x0400BE99 RID: 48793
		ArmorType,
		// Token: 0x0400BE9A RID: 48794
		DestroyedAfterUnpacking,
		// Token: 0x0400BE9B RID: 48795
		EncodeState,
		// Token: 0x0400BE9C RID: 48796
		UsedInRaid,
		// Token: 0x0400BE9D RID: 48797
		CannotDroppedInRaid,
		// Token: 0x0400BE9E RID: 48798
		ArmorPlate
	}
}
