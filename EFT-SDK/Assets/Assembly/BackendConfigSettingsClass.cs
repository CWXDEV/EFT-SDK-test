using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;
using EFT;
using EFT.HealthSystem;
using EFT.Interactive;
using EFT.InventoryLogic;
using EFT.Vaulting;
using EFT.Vehicle;
using JetBrains.Annotations;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020011DF RID: 4575
public sealed class BackendConfigSettingsClass
{
	// Token: 0x060061AD RID: 25005 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateTradersSettings(BackendConfigSettingsClass.TraderSettings[] tradersSettings)
	{
		throw null;
	}

	// Token: 0x17000F54 RID: 3924
	// (get) Token: 0x060061AE RID: 25006 RVA: 0x00002050 File Offset: 0x00000250
	public Dictionary<string, BackendConfigSettingsClass.GClass1363> Associations
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000F55 RID: 3925
	// (get) Token: 0x060061AF RID: 25007 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060061B0 RID: 25008 RVA: 0x00002050 File Offset: 0x00000250
	[UsedImplicitly]
	public BackendConfigSettingsClass.GClass1366[] RestrictionsInRaid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x04006B88 RID: 27528
	public BackendConfigSettingsClass.GlobalSkillsSettings SkillsSettings;

	// Token: 0x04006B89 RID: 27529
	public Dictionary<ETraderServiceType, BackendConfigSettingsClass.ServiceData> ServicesData;

	// Token: 0x04006B8A RID: 27530
	[JsonProperty("FenceSettings")]
	public readonly BackendConfigSettingsClass.FenceGlobalSettings FenceSettings;

	// Token: 0x04006B8B RID: 27531
	[JsonProperty("TradingSettings")]
	public readonly BackendConfigSettingsClass.TradingGlobalSettings TradingSettings;

	// Token: 0x04006B8C RID: 27532
	[JsonProperty("TradersSettings")]
	public readonly Dictionary<string, BackendConfigSettingsClass.TraderSettings> TradersSettings;

	// Token: 0x04006B8D RID: 27533
	public readonly BackendConfigSettingsClass.GClass1347 RepairSettings;

	// Token: 0x04006B8E RID: 27534
	[JsonProperty("exp")]
	public BackendConfigSettingsClass.GClass1350 Experience;

	// Token: 0x04006B8F RID: 27535
	public BackendConfigSettingsClass.AimingConfiguration Aiming;

	// Token: 0x04006B90 RID: 27536
	public BackendConfigSettingsClass.GClass1357 Health;

	// Token: 0x04006B91 RID: 27537
	public Dictionary<EArmorMaterial, BackendConfigSettingsClass.GClass1360> ArmorMaterials;

	// Token: 0x04006B92 RID: 27538
	public Dictionary<string, ExfiltrationRequirement[]> RequirementReferences;

	// Token: 0x04006B93 RID: 27539
	[JsonProperty("armor")]
	public BackendConfigSettingsClass.GClass1361 Armor;

	// Token: 0x04006B94 RID: 27540
	public RagfairSettingsClass RagFair;

	// Token: 0x04006B95 RID: 27541
	[JsonProperty("handbook")]
	public GClass1382 Handbook;

	// Token: 0x04006B96 RID: 27542
	[JsonProperty("MaxBotsAliveOnMap")]
	public int MaxBotsAliveOnMap;

	// Token: 0x04006B97 RID: 27543
	public float MarksmanAccuracy;

	// Token: 0x04006B98 RID: 27544
	public int SavagePlayCooldown;

	// Token: 0x04006B99 RID: 27545
	public int TimeBeforeDeploy;

	// Token: 0x04006B9A RID: 27546
	public int TimeBeforeDeployLocal;

	// Token: 0x04006B9B RID: 27547
	public float LoadTimeSpeedProgress;

	// Token: 0x04006B9C RID: 27548
	public float BaseLoadTime;

	// Token: 0x04006B9D RID: 27549
	public float BaseUnloadTime;

	// Token: 0x04006B9E RID: 27550
	public float BaseCheckTime;

	// Token: 0x04006B9F RID: 27551
	public float WAVE_COEF_LOW;

	// Token: 0x04006BA0 RID: 27552
	public float WAVE_COEF_MID;

	// Token: 0x04006BA1 RID: 27553
	public float WAVE_COEF_HIGH;

	// Token: 0x04006BA2 RID: 27554
	public float WAVE_COEF_HORDE;

	// Token: 0x04006BA3 RID: 27555
	public bool UncheckOnShot;

	// Token: 0x04006BA4 RID: 27556
	public int SessionsToShowHotKeys;

	// Token: 0x04006BA5 RID: 27557
	public string TODSkyDate;

	// Token: 0x04006BA6 RID: 27558
	public float SkillMinEffectiveness;

	// Token: 0x04006BA7 RID: 27559
	public float SkillFatiguePerPoint;

	// Token: 0x04006BA8 RID: 27560
	public float SkillFreshEffectiveness;

	// Token: 0x04006BA9 RID: 27561
	public int SkillFreshPoints;

	// Token: 0x04006BAA RID: 27562
	public int SkillPointsBeforeFatigue;

	// Token: 0x04006BAB RID: 27563
	public int SkillFatigueReset;

	// Token: 0x04006BAC RID: 27564
	public float SkillEnduranceWeightThreshold;

	// Token: 0x04006BAD RID: 27565
	public float AimPunchMagnitude;

	// Token: 0x04006BAE RID: 27566
	public bool SkillAtrophy;

	// Token: 0x04006BAF RID: 27567
	public bool AllowSelectEntryPoint;

	// Token: 0x04006BB0 RID: 27568
	public float LegsOverdamage;

	// Token: 0x04006BB1 RID: 27569
	public float HandsOverdamage;

	// Token: 0x04006BB2 RID: 27570
	public float StomachOverdamage;

	// Token: 0x04006BB3 RID: 27571
	public bool DiscardLimitsEnabled;

	// Token: 0x04006BB4 RID: 27572
	public BackendConfigSettingsClass.GClass1363[] Mastering;

	// Token: 0x04006BB5 RID: 27573
	public BackendConfigSettingsClass.GClass1365 Stamina;

	// Token: 0x04006BB6 RID: 27574
	public BackendConfigSettingsClass.GClass1364 StaminaRestoration;

	// Token: 0x04006BB7 RID: 27575
	public BackendConfigSettingsClass.GClass1364 StaminaDrain;

	// Token: 0x04006BB8 RID: 27576
	private Dictionary<EBodyPart, float> dictionary_0;

	// Token: 0x04006BB9 RID: 27577
	private Dictionary<string, BackendConfigSettingsClass.GClass1363> dictionary_1;

	// Token: 0x04006BBA RID: 27578
	public bool AzimuthPanelShowsPlayerOrientation;

	// Token: 0x04006BBB RID: 27579
	public Vector3 WallContusionAbsorption;

	// Token: 0x04006BBC RID: 27580
	public Vector2 WalkSpeed;

	// Token: 0x04006BBD RID: 27581
	public Vector2 SprintSpeed;

	// Token: 0x04006BBE RID: 27582
	private BackendConfigSettingsClass.GClass1366[] gclass1366_0;

	// Token: 0x04006BBF RID: 27583
	public EEventType[] EventType;

	// Token: 0x04006BC0 RID: 27584
	public int TeamSearchingTimeout;

	// Token: 0x04006BC1 RID: 27585
	public int GameSearchingTimeout;

	// Token: 0x04006BC2 RID: 27586
	public BackendConfigSettingsClass.GClass1367 Malfunction;

	// Token: 0x04006BC3 RID: 27587
	public BackendConfigSettingsClass.GClass1368 Overheat;

	// Token: 0x04006BC4 RID: 27588
	public BackendConfigSettingsClass.InertiaSettings Inertia;

	// Token: 0x04006BC5 RID: 27589
	public BackendConfigSettingsClass.GClass1369 Ballistic;

	// Token: 0x04006BC6 RID: 27590
	public BackendConfigSettingsClass.GClass1370 Airdrop;

	// Token: 0x04006BC7 RID: 27591
	public BackendConfigSettingsClass.GClass1371 BufferZone;

	// Token: 0x04006BC8 RID: 27592
	[JsonProperty("CoopSettings")]
	public readonly BackendConfigSettingsClass.GClass1372 CoopSettings;

	// Token: 0x04006BC9 RID: 27593
	[JsonProperty("EventSettings")]
	public readonly BackendConfigSettingsClass.GClass1373 EventSettings;

	// Token: 0x04006BCA RID: 27594
	[JsonProperty("BTRSettings")]
	public readonly BackendConfigSettingsClass.BTRGlobalSettings BTRSettings;

	// Token: 0x04006BCB RID: 27595
	[JsonProperty("ItemsCommonSettings")]
	public readonly BackendConfigSettingsClass.GClass1374 ItemsSettings;

	// Token: 0x04006BCC RID: 27596
	[JsonProperty("VaultingSettings")]
	public readonly BackendConfigSettingsClass.VaultingGlobalSettings VaultingSettings;

	// Token: 0x04006BCD RID: 27597
	[JsonProperty("WeaponFastDrawSettings")]
	public readonly BackendConfigSettingsClass.GClass1375 WeaponFastDrawGlobalSettings;

	// Token: 0x04006BCE RID: 27598
	[JsonProperty("AudioSettings")]
	public BackendConfigSettingsClass.GClass1376 AudioSettings;

	// Token: 0x04006BCF RID: 27599
	[JsonProperty("GraphicSettings")]
	public readonly BackendConfigSettingsClass.GClass1380 GraphicGlobalSettings;

	// Token: 0x04006BD0 RID: 27600
	[JsonProperty("FavoriteItemsSettings")]
	public BackendConfigSettingsClass.GClass1381 FavoriteItemsSettings;

	// Token: 0x020011E0 RID: 4576
	public sealed class GClass1310
	{
		// Token: 0x04006BD1 RID: 27601
		public float SkillPointsPerAreaUpgrade;

		// Token: 0x04006BD2 RID: 27602
		public float SkillPointsPerCraft;

		// Token: 0x04006BD3 RID: 27603
		public double SkillBoostPercent;

		// Token: 0x04006BD4 RID: 27604
		public float ConsumptionReductionPerLevel;

		// Token: 0x04006BD5 RID: 27605
		public Dictionary<EAreaType, BackendConfigSettingsClass.GClass1310.GClass1311> SkillPointsRate;

		// Token: 0x04006BD6 RID: 27606
		public Dictionary<EAreaType, BackendConfigSettingsClass.GClass1310.GClass1312> EliteSlots;

		// Token: 0x020011E1 RID: 4577
		public sealed class GClass1311
		{
			// Token: 0x17000F56 RID: 3926
			// (get) Token: 0x060061B1 RID: 25009 RVA: 0x00002050 File Offset: 0x00000250
			public float PointsPerResource
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x04006BD7 RID: 27607
			public float ResourceSpent;

			// Token: 0x04006BD8 RID: 27608
			public float PointsGained;
		}

		// Token: 0x020011E2 RID: 4578
		public sealed class GClass1312
		{
			// Token: 0x04006BD9 RID: 27609
			public int Slots;

			// Token: 0x04006BDA RID: 27610
			public int Container;
		}
	}

	// Token: 0x020011E3 RID: 4579
	public sealed class GClass1313
	{
		// Token: 0x17000F57 RID: 3927
		// (get) Token: 0x060061B2 RID: 25010 RVA: 0x00002050 File Offset: 0x00000250
		public float PointsPerOriginalCraft
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x060061B3 RID: 25011 RVA: 0x00002050 File Offset: 0x00000250
		public float CraftingCycleSeconds
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x060061B4 RID: 25012 RVA: 0x00002050 File Offset: 0x00000250
		public float PointsPerSecond
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04006BDB RID: 27611
		public float PointsPerCraftingCycle;

		// Token: 0x04006BDC RID: 27612
		public float CraftingCycleHours;

		// Token: 0x04006BDD RID: 27613
		public float PointsPerUniqueCraftCycle;

		// Token: 0x04006BDE RID: 27614
		public float UniqueCraftsPerCycle;

		// Token: 0x04006BDF RID: 27615
		public float CraftTimeReductionPerLevel;

		// Token: 0x04006BE0 RID: 27616
		public float ProductionTimeReductionPerLevel;

		// Token: 0x04006BE1 RID: 27617
		public float EliteExtraProductions;

		// Token: 0x04006BE2 RID: 27618
		[JsonProperty("CraftingPointsToInteligence")]
		public float CraftingPointsToIntelligence;
	}

	// Token: 0x020011E4 RID: 4580
	public class GClass1314
	{
		// Token: 0x04006BE3 RID: 27619
		public float HydrationRecoveryRate;

		// Token: 0x04006BE4 RID: 27620
		public float EnergyRecoveryRate;

		// Token: 0x04006BE5 RID: 27621
		public float IncreasePositiveEffectDurationRate;

		// Token: 0x04006BE6 RID: 27622
		public float DecreaseNegativeEffectDurationRate;

		// Token: 0x04006BE7 RID: 27623
		public float DecreasePoisonDurationRate;
	}

	// Token: 0x020011E5 RID: 4581
	public class GClass1315
	{
		// Token: 0x04006BE8 RID: 27624
		public float ImmunityMiscEffects;

		// Token: 0x04006BE9 RID: 27625
		public float ImmunityPoisonBuff;

		// Token: 0x04006BEA RID: 27626
		public float ImmunityPainKiller;

		// Token: 0x04006BEB RID: 27627
		public float HealthNegativeEffect;

		// Token: 0x04006BEC RID: 27628
		public float StimulatorNegativeBuff;
	}

	// Token: 0x020011E6 RID: 4582
	public class GClass1316
	{
		// Token: 0x04006BED RID: 27629
		public float MovementAction;

		// Token: 0x04006BEE RID: 27630
		public float SprintAction;

		// Token: 0x04006BEF RID: 27631
		public float GainPerFatigueStack;
	}

	// Token: 0x020011E7 RID: 4583
	public class GClass1317
	{
		// Token: 0x04006BF0 RID: 27632
		public float SprintActionMin;

		// Token: 0x04006BF1 RID: 27633
		public float SprintActionMax;

		// Token: 0x04006BF2 RID: 27634
		public float MovementActionMin;

		// Token: 0x04006BF3 RID: 27635
		public float MovementActionMax;

		// Token: 0x04006BF4 RID: 27636
		public float PushUpMin;

		// Token: 0x04006BF5 RID: 27637
		public float PushUpMax;

		// Token: 0x04006BF6 RID: 27638
		public float FistfightAction;

		// Token: 0x04006BF7 RID: 27639
		public float ThrowAction;
	}

	// Token: 0x020011E8 RID: 4584
	public class GClass1318
	{
		// Token: 0x04006BF8 RID: 27640
		public float DamageTakenAction;

		// Token: 0x04006BF9 RID: 27641
		public float HealthNegativeEffect;
	}

	// Token: 0x020011E9 RID: 4585
	public class GClass1319
	{
		// Token: 0x04006BFA RID: 27642
		public float SkillProgress;
	}

	// Token: 0x020011EA RID: 4586
	public class GClass1320
	{
		// Token: 0x04006BFB RID: 27643
		public float HealthNegativeEffect;

		// Token: 0x04006BFC RID: 27644
		public float LowHPDuration;
	}

	// Token: 0x020011EB RID: 4587
	public class GClass1321
	{
		// Token: 0x04006BFD RID: 27645
		public float ThrowAction;
	}

	// Token: 0x020011EC RID: 4588
	public class GClass1322
	{
		// Token: 0x04006BFE RID: 27646
		public float RecoilAction;

		// Token: 0x04006BFF RID: 27647
		public float RecoilBonusPerLevel;
	}

	// Token: 0x020011ED RID: 4589
	public class GClass1323
	{
		// Token: 0x04006C00 RID: 27648
		public float WeaponReloadAction;

		// Token: 0x04006C01 RID: 27649
		public float WeaponShotAction;

		// Token: 0x04006C02 RID: 27650
		public float WeaponFixAction;

		// Token: 0x04006C03 RID: 27651
		public float WeaponChamberAction;
	}

	// Token: 0x020011EE RID: 4590
	public class GClass1324
	{
		// Token: 0x04006C04 RID: 27652
		public float WeaponReloadAction;

		// Token: 0x04006C05 RID: 27653
		public float WeaponShotAction;

		// Token: 0x04006C06 RID: 27654
		public float WeaponFixAction;

		// Token: 0x04006C07 RID: 27655
		public float WeaponChamberAction;
	}

	// Token: 0x020011EF RID: 4591
	public class GClass1325
	{
		// Token: 0x04006C08 RID: 27656
		public float WeaponReloadAction;

		// Token: 0x04006C09 RID: 27657
		public float WeaponShotAction;

		// Token: 0x04006C0A RID: 27658
		public float WeaponFixAction;

		// Token: 0x04006C0B RID: 27659
		public float WeaponChamberAction;
	}

	// Token: 0x020011F0 RID: 4592
	public class GClass1326
	{
		// Token: 0x04006C0C RID: 27660
		public float WeaponReloadAction;

		// Token: 0x04006C0D RID: 27661
		public float WeaponShotAction;

		// Token: 0x04006C0E RID: 27662
		public float WeaponFixAction;

		// Token: 0x04006C0F RID: 27663
		public float WeaponChamberAction;
	}

	// Token: 0x020011F1 RID: 4593
	public class GClass1327
	{
		// Token: 0x04006C10 RID: 27664
		public float WeaponReloadAction;

		// Token: 0x04006C11 RID: 27665
		public float WeaponShotAction;

		// Token: 0x04006C12 RID: 27666
		public float WeaponFixAction;

		// Token: 0x04006C13 RID: 27667
		public float WeaponChamberAction;
	}

	// Token: 0x020011F2 RID: 4594
	public class GClass1328
	{
		// Token: 0x04006C14 RID: 27668
		public float WeaponReloadAction;

		// Token: 0x04006C15 RID: 27669
		public float WeaponShotAction;

		// Token: 0x04006C16 RID: 27670
		public float WeaponFixAction;

		// Token: 0x04006C17 RID: 27671
		public float WeaponChamberAction;
	}

	// Token: 0x020011F3 RID: 4595
	public class GClass1329
	{
		// Token: 0x04006C18 RID: 27672
		public float MovementAction;
	}

	// Token: 0x020011F4 RID: 4596
	public class GClass1330
	{
		// Token: 0x04006C19 RID: 27673
		public float SearchAction;

		// Token: 0x04006C1A RID: 27674
		public float FindAction;
	}

	// Token: 0x020011F5 RID: 4597
	public class GClass1331
	{
		// Token: 0x04006C1B RID: 27675
		public float RaidLoadedAmmoAction;

		// Token: 0x04006C1C RID: 27676
		public float RaidUnloadedAmmoAction;

		// Token: 0x04006C1D RID: 27677
		public float MagazineCheckAction;
	}

	// Token: 0x020011F6 RID: 4598
	public class GClass1332
	{
		// Token: 0x04006C1E RID: 27678
		public float OnlineAction;

		// Token: 0x04006C1F RID: 27679
		public float UniqueLoot;
	}

	// Token: 0x020011F7 RID: 4599
	public class GClass1333
	{
		// Token: 0x04006C20 RID: 27680
		public float ExamineAction;

		// Token: 0x04006C21 RID: 27681
		public float SkillProgress;

		// Token: 0x04006C22 RID: 27682
		public float RepairAction;

		// Token: 0x04006C23 RID: 27683
		[JsonProperty("WearAmountReducePerLevel")]
		public float WearAmountReducePerLevel;

		// Token: 0x04006C24 RID: 27684
		[JsonProperty("RepairPointsCostReduction")]
		public float RepairPointsCostReduction;
	}

	// Token: 0x020011F8 RID: 4600
	public class GClass1334
	{
		// Token: 0x04006C25 RID: 27685
		public float ExamineWithInstruction;

		// Token: 0x04006C26 RID: 27686
		public float FindActionTrue;

		// Token: 0x04006C27 RID: 27687
		public float FindActionFalse;
	}

	// Token: 0x020011F9 RID: 4601
	public class GClass1335
	{
		// Token: 0x04006C28 RID: 27688
		public float SkillProgressInt;

		// Token: 0x04006C29 RID: 27689
		public float SkillProgressAtn;

		// Token: 0x04006C2A RID: 27690
		public float SkillProgressPer;

		// Token: 0x04006C2B RID: 27691
		public BackendConfigSettingsClass.GClass1335.GClass1336 BonusSettings;

		// Token: 0x020011FA RID: 4602
		public class GClass1336
		{
			// Token: 0x04006C2C RID: 27692
			public BackendConfigSettingsClass.GClass1335.GClass1337 LevelBonusSettings;

			// Token: 0x04006C2D RID: 27693
			public BackendConfigSettingsClass.GClass1335.GClass1338 EliteBonusSettings;
		}

		// Token: 0x020011FB RID: 4603
		public class GClass1337
		{
			// Token: 0x04006C2E RID: 27694
			public float RepeatableQuestChangeDiscount;

			// Token: 0x04006C2F RID: 27695
			public float HealthRestoreDiscount;

			// Token: 0x04006C30 RID: 27696
			public float HealthRestoreTraderDiscount;

			// Token: 0x04006C31 RID: 27697
			public float InsuranceDiscount;

			// Token: 0x04006C32 RID: 27698
			public float InsuranceTraderDiscount;

			// Token: 0x04006C33 RID: 27699
			public float PaidExitDiscount;
		}

		// Token: 0x020011FC RID: 4604
		public class GClass1338
		{
			// Token: 0x04006C34 RID: 27700
			public float ScavCaseDiscount;

			// Token: 0x04006C35 RID: 27701
			public float FenceStandingLossDiscount;

			// Token: 0x04006C36 RID: 27702
			public int RepeatableQuestExtraCount;
		}
	}

	// Token: 0x020011FD RID: 4605
	public class GClass1339
	{
		// Token: 0x04006C37 RID: 27703
		public float AnySkillUp;

		// Token: 0x04006C38 RID: 27704
		public float SkillProgress;
	}

	// Token: 0x020011FE RID: 4606
	public class GClass1340
	{
		// Token: 0x04006C39 RID: 27705
		public float SurgeryAction;

		// Token: 0x04006C3A RID: 27706
		public float SkillProgress;
	}

	// Token: 0x020011FF RID: 4607
	public class GClass1341
	{
		// Token: 0x04006C3B RID: 27707
		public float WeaponShotAction;
	}

	// Token: 0x02001200 RID: 4608
	public class GClass1342
	{
		// Token: 0x04006C3C RID: 27708
		public float CommonBuffMinChanceValue;

		// Token: 0x04006C3D RID: 27709
		public float CommonBuffChanceLevelBonus;

		// Token: 0x04006C3E RID: 27710
		public float RareBuffChanceCoff;

		// Token: 0x04006C3F RID: 27711
		public float ReceivedDurabilityMaxPercent;
	}

	// Token: 0x02001201 RID: 4609
	public class GClass1343
	{
		// Token: 0x04006C40 RID: 27712
		public float SkillPointsPerRepair;

		// Token: 0x04006C41 RID: 27713
		[JsonProperty("WearAmountRepairGunsReducePerLevel")]
		public float WearAmountRepairGunsReducePerLevel;

		// Token: 0x04006C42 RID: 27714
		[JsonProperty("DurLossReducePerLevel")]
		public float DurabilityLossReducePerLevel;

		// Token: 0x04006C43 RID: 27715
		public BackendConfigSettingsClass.GClass1342 BuffSettings;
	}

	// Token: 0x02001202 RID: 4610
	public class GClass1344
	{
		// Token: 0x04006C44 RID: 27716
		public float MalfRepairSpeedBonusPerLevel;

		// Token: 0x04006C45 RID: 27717
		public float SkillPointsPerMalfFix;

		// Token: 0x04006C46 RID: 27718
		public float EliteDurabilityChanceReduceMult;

		// Token: 0x04006C47 RID: 27719
		public float EliteAmmoChanceReduceMult;

		// Token: 0x04006C48 RID: 27720
		public float EliteMagChanceReduceMult;
	}

	// Token: 0x02001203 RID: 4611
	public class GClass1345
	{
		// Token: 0x04006C49 RID: 27721
		public float WearAmountRepairLVestsReducePerLevel;

		// Token: 0x04006C4A RID: 27722
		public float WearChanceRepairLVestsReduceEliteLevel;

		// Token: 0x04006C4B RID: 27723
		public float MoveSpeedPenaltyReductionLVestsReducePerLevel;

		// Token: 0x04006C4C RID: 27724
		public float MeleeDamageLVestsReducePerLevel;

		// Token: 0x04006C4D RID: 27725
		public BackendConfigSettingsClass.GClass1342 BuffSettings;
	}

	// Token: 0x02001204 RID: 4612
	public class GClass1346
	{
		// Token: 0x04006C4E RID: 27726
		public float WearAmountRepairHVestsReducePerLevel;

		// Token: 0x04006C4F RID: 27727
		public float WearChanceRepairHVestsReduceEliteLevel;

		// Token: 0x04006C50 RID: 27728
		public float MoveSpeedPenaltyReductionHVestsReducePerLevel;

		// Token: 0x04006C51 RID: 27729
		public float BluntThroughputDamageHVestsReducePerLevel;

		// Token: 0x04006C52 RID: 27730
		public float RicochetChanceHVestsEliteLevel;

		// Token: 0x04006C53 RID: 27731
		public float RicochetChanceHVestsMaxDurabilityThreshold;

		// Token: 0x04006C54 RID: 27732
		public float RicochetChanceHVestsCurrentDurabilityThreshold;

		// Token: 0x04006C55 RID: 27733
		public BackendConfigSettingsClass.GClass1342 BuffSettings;
	}

	// Token: 0x02001205 RID: 4613
	public class GlobalSkillsSettings
	{
		// Token: 0x04006C56 RID: 27734
		public float SkillProgressRate;

		// Token: 0x04006C57 RID: 27735
		public float WeaponSkillProgressRate;

		// Token: 0x04006C58 RID: 27736
		public float WeaponSkillRecoilBonusPerLevel;

		// Token: 0x04006C59 RID: 27737
		public BackendConfigSettingsClass.GClass1310 HideoutManagement;

		// Token: 0x04006C5A RID: 27738
		public BackendConfigSettingsClass.GClass1313 Crafting;

		// Token: 0x04006C5B RID: 27739
		public BackendConfigSettingsClass.GClass1314 Metabolism;

		// Token: 0x04006C5C RID: 27740
		public BackendConfigSettingsClass.GClass1315 Immunity;

		// Token: 0x04006C5D RID: 27741
		public BackendConfigSettingsClass.GClass1316 Endurance;

		// Token: 0x04006C5E RID: 27742
		public BackendConfigSettingsClass.GClass1317 Strength;

		// Token: 0x04006C5F RID: 27743
		public BackendConfigSettingsClass.GClass1318 Vitality;

		// Token: 0x04006C60 RID: 27744
		public BackendConfigSettingsClass.GClass1319 Health;

		// Token: 0x04006C61 RID: 27745
		public BackendConfigSettingsClass.GClass1320 StressResistance;

		// Token: 0x04006C62 RID: 27746
		public BackendConfigSettingsClass.GClass1321 Throwing;

		// Token: 0x04006C63 RID: 27747
		public BackendConfigSettingsClass.GClass1322 RecoilControl;

		// Token: 0x04006C64 RID: 27748
		public BackendConfigSettingsClass.GClass1324 Pistol;

		// Token: 0x04006C65 RID: 27749
		public BackendConfigSettingsClass.GClass1325 Assault;

		// Token: 0x04006C66 RID: 27750
		public BackendConfigSettingsClass.GClass1326 Shotgun;

		// Token: 0x04006C67 RID: 27751
		public BackendConfigSettingsClass.GClass1327 Sniper;

		// Token: 0x04006C68 RID: 27752
		public BackendConfigSettingsClass.GClass1328 DMR;

		// Token: 0x04006C69 RID: 27753
		public BackendConfigSettingsClass.GClass1329 CovertMovement;

		// Token: 0x04006C6A RID: 27754
		public BackendConfigSettingsClass.GClass1330 Search;

		// Token: 0x04006C6B RID: 27755
		public BackendConfigSettingsClass.GClass1331 MagDrills;

		// Token: 0x04006C6C RID: 27756
		public BackendConfigSettingsClass.GClass1332 Perception;

		// Token: 0x04006C6D RID: 27757
		public BackendConfigSettingsClass.GClass1333 Intellect;

		// Token: 0x04006C6E RID: 27758
		public BackendConfigSettingsClass.GClass1334 Attention;

		// Token: 0x04006C6F RID: 27759
		public BackendConfigSettingsClass.GClass1335 Charisma;

		// Token: 0x04006C70 RID: 27760
		public BackendConfigSettingsClass.GClass1339 Memory;

		// Token: 0x04006C71 RID: 27761
		public BackendConfigSettingsClass.GClass1340 Surgery;

		// Token: 0x04006C72 RID: 27762
		public BackendConfigSettingsClass.GClass1341 AimDrills;

		// Token: 0x04006C73 RID: 27763
		public BackendConfigSettingsClass.GClass1343 WeaponTreatment;

		// Token: 0x04006C74 RID: 27764
		public BackendConfigSettingsClass.GClass1344 TroubleShooting;

		// Token: 0x04006C75 RID: 27765
		public BackendConfigSettingsClass.GClass1323 Revolver;

		// Token: 0x04006C76 RID: 27766
		public BackendConfigSettingsClass.GClass1345 LightVests;

		// Token: 0x04006C77 RID: 27767
		public BackendConfigSettingsClass.GClass1346 HeavyVests;
	}

	// Token: 0x02001206 RID: 4614
	[Serializable]
	public sealed class FenceLoyaltyLevel
	{
		// Token: 0x17000F5A RID: 3930
		// (get) Token: 0x060061B5 RID: 25013 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060061B6 RID: 25014 RVA: 0x00002050 File Offset: 0x00000250
		public double StandingRequired
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

		// Token: 0x17000F5B RID: 3931
		// (get) Token: 0x060061B7 RID: 25015 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060061B8 RID: 25016 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsMaxLevel
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

		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x060061B9 RID: 25017 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060061BA RID: 25018 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsMinLevel
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

		// Token: 0x060061BB RID: 25019 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(double minStanding, bool first, bool last)
		{
			throw null;
		}

		// Token: 0x04006C78 RID: 27768
		[JsonProperty("HostileBosses")]
		public readonly bool HostileBosses;

		// Token: 0x04006C79 RID: 27769
		[JsonProperty("ScavAttackSupport")]
		public readonly bool ScavAttackSupport;

		// Token: 0x04006C7A RID: 27770
		[JsonProperty("HostileScavs")]
		public readonly bool HostileScavs;

		// Token: 0x04006C7B RID: 27771
		[JsonProperty("BotSpreadoutChance")]
		public readonly float BotSpreadoutChance;

		// Token: 0x04006C7C RID: 27772
		[JsonProperty("BotGetInCoverChance")]
		public readonly float BotGetInCoverChance;

		// Token: 0x04006C7D RID: 27773
		[JsonProperty("BotApplySilenceChance")]
		public readonly float BotApplySilenceChance;

		// Token: 0x04006C7E RID: 27774
		[JsonProperty("BotStopChance")]
		public readonly float BotStopChance;

		// Token: 0x04006C7F RID: 27775
		[JsonProperty("BotHelpChance")]
		public readonly float BotHelpChance;

		// Token: 0x04006C80 RID: 27776
		[JsonProperty("BotFollowChance")]
		public readonly float BotFollowChance;

		// Token: 0x04006C81 RID: 27777
		[JsonProperty("SavageCooldownModifier")]
		public readonly float SavageCooldownModifier;

		// Token: 0x04006C82 RID: 27778
		[JsonProperty("ScavCaseTimeModifier")]
		public readonly float ScavCaseTimeModifier;

		// Token: 0x04006C83 RID: 27779
		[JsonProperty("PaidExitCostModifier")]
		public readonly float PaidExitCostModifier;

		// Token: 0x04006C84 RID: 27780
		[JsonProperty("ScavEquipmentSpawnChanceModifier")]
		public readonly float ScavEquipmentSpawnChanceModifier;

		// Token: 0x04006C85 RID: 27781
		[JsonProperty("PriceModifier")]
		public readonly float PriceModifier;

		// Token: 0x04006C86 RID: 27782
		[JsonProperty("ExfiltrationPriceModifier")]
		public readonly float ExfiltrationPriceModifier;

		// Token: 0x04006C87 RID: 27783
		[JsonProperty("AvailableExits")]
		public readonly int AvailableExits;

		// Token: 0x04006C88 RID: 27784
		[JsonProperty("PriceModTaxi")]
		public readonly float PriceModTaxi;

		// Token: 0x04006C89 RID: 27785
		[JsonProperty("PriceModDelivery")]
		public readonly float PriceModDelivery;

		// Token: 0x04006C8A RID: 27786
		[JsonProperty("PriceModCleanUp")]
		public readonly float PriceModCleanUp;

		// Token: 0x04006C8B RID: 27787
		[JsonProperty("CanInteractWithBtr")]
		public readonly bool CanInteractWithBtr;

		// Token: 0x04006C8C RID: 27788
		[JsonProperty("DeliveryGridSize")]
		public readonly Vector3 DeliveryGridSize;
	}

	// Token: 0x02001207 RID: 4615
	[Serializable]
	public class ServiceRequirements
	{
		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x060061BC RID: 25020 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060061BD RID: 25021 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("CompletedQuests")]
		public GClass2130<string> CompletedQuests
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

		// Token: 0x17000F5E RID: 3934
		// (get) Token: 0x060061BE RID: 25022 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060061BF RID: 25023 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("Standings")]
		public GClass2132<float> Standings
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

		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x060061C0 RID: 25024 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060061C1 RID: 25025 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("Side")]
		public ESideType SideType
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
	}

	// Token: 0x02001208 RID: 4616
	[Serializable]
	public class SubService
	{
		// Token: 0x04006C8D RID: 27789
		public string Id;

		// Token: 0x04006C8E RID: 27790
		public int Price;
	}

	// Token: 0x02001209 RID: 4617
	[Serializable]
	public class ServiceData
	{
		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x060061C2 RID: 25026 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060061C3 RID: 25027 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("TraderId")]
		public MongoID TraderId
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

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x060061C4 RID: 25028 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060061C5 RID: 25029 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("TraderServiceType")]
		public ETraderServiceType ServiceType
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

		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x060061C6 RID: 25030 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060061C7 RID: 25031 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("SubServices")]
		public BackendConfigSettingsClass.SubService[] SubServices
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x060061C8 RID: 25032 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060061C9 RID: 25033 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("Requirements")]
		public BackendConfigSettingsClass.ServiceRequirements TraderServiceRequirements
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

		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x060061CA RID: 25034 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060061CB RID: 25035 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("ServiceItemCost")]
		public GClass2132<int> ServiceItemCost
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

		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x060061CC RID: 25036 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060061CD RID: 25037 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("UniqueItems")]
		public MongoID[] UniqueItems
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

		// Token: 0x0200120A RID: 4618
		[CompilerGenerated]
		[Serializable]
		private sealed class Class895
		{
			// Token: 0x060061CE RID: 25038 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal BackendConfigSettingsClass.SubService method_0(KeyValuePair<string, int> subServiceData)
			{
				throw null;
			}

			// Token: 0x04006C8F RID: 27791
			public static readonly BackendConfigSettingsClass.ServiceData.Class895 class895_0;

			// Token: 0x04006C90 RID: 27792
			public static Func<KeyValuePair<string, int>, BackendConfigSettingsClass.SubService> func_0;
		}
	}

	// Token: 0x0200120B RID: 4619
	[Serializable]
	public sealed class FenceGlobalSettings
	{
		// Token: 0x060061CF RID: 25039 RVA: 0x00002050 File Offset: 0x00000250
		[OnDeserialized]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(StreamingContext context)
		{
			throw null;
		}

		// Token: 0x060061D0 RID: 25040 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BackendConfigSettingsClass.FenceLoyaltyLevel GetSettings(double standing)
		{
			throw null;
		}

		// Token: 0x04006C91 RID: 27793
		[JsonProperty("FenceId")]
		public string FenceId;

		// Token: 0x04006C92 RID: 27794
		[JsonProperty("Levels")]
		public readonly SortedDictionary<double, BackendConfigSettingsClass.FenceLoyaltyLevel> LoyaltyLevels;
	}

	// Token: 0x0200120C RID: 4620
	public interface GInterface95
	{
		// Token: 0x17000F66 RID: 3942
		// (get) Token: 0x060061D1 RID: 25041
		int ProfileLevel { get; }

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x060061D2 RID: 25042
		long SalesSum { get; }

		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x060061D3 RID: 25043
		double Standing { get; }
	}

	// Token: 0x0200120D RID: 4621
	[Serializable]
	public struct TraderLoyaltyLevel
	{
		// Token: 0x060061D4 RID: 25044 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool MeetsRequirements(BackendConfigSettingsClass.GInterface95 info)
		{
			throw null;
		}

		// Token: 0x04006C93 RID: 27795
		[JsonProperty("minLevel")]
		public readonly int MinProfileLevel;

		// Token: 0x04006C94 RID: 27796
		[JsonProperty("minSalesSum")]
		public readonly long MinSalesSum;

		// Token: 0x04006C95 RID: 27797
		[JsonProperty("minStanding")]
		public readonly double MinStanding;

		// Token: 0x04006C96 RID: 27798
		[JsonProperty("buy_price_coef")]
		public readonly double SellToTraderPriceCoef;

		// Token: 0x04006C97 RID: 27799
		[JsonProperty("repair_price_coef")]
		public readonly double RepairPriceCoef;

		// Token: 0x04006C98 RID: 27800
		[JsonProperty("insurance_price_coef")]
		public readonly double InsurancePriceCoef;

		// Token: 0x04006C99 RID: 27801
		[JsonProperty("exchange_price_coef")]
		public readonly double ExchangePriceCoef;

		// Token: 0x04006C9A RID: 27802
		[JsonProperty("heal_price_coef")]
		public readonly float HealPriceCoef;
	}

	// Token: 0x0200120E RID: 4622
	[Serializable]
	public class TraderSettings
	{
		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x060061D5 RID: 25045 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060061D6 RID: 25046 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("items_buy")]
		public BackendConfigSettingsClass.TraderSettings.HandbookEntities BuysItems
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x060061D7 RID: 25047 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060061D8 RID: 25048 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("items_buy_prohibited")]
		public BackendConfigSettingsClass.TraderSettings.HandbookEntities DoesNotBuyItems
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x060061D9 RID: 25049 RVA: 0x00002050 File Offset: 0x00000250
		public string FirstName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x060061DA RID: 25050 RVA: 0x00002050 File Offset: 0x00000250
		public string FullName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x060061DB RID: 25051 RVA: 0x00002050 File Offset: 0x00000250
		public string Nickname
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x060061DC RID: 25052 RVA: 0x00002050 File Offset: 0x00000250
		public string Description
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x060061DD RID: 25053 RVA: 0x00002050 File Offset: 0x00000250
		public string Location
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060061DE RID: 25054 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetLoyaltyLevel(BackendConfigSettingsClass.GInterface95 info)
		{
			throw null;
		}

		// Token: 0x060061DF RID: 25055 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BackendConfigSettingsClass.TraderLoyaltyLevel? GetLoyaltyLevelSettings(int loyaltyLevel)
		{
			throw null;
		}

		// Token: 0x060061E0 RID: 25056 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitSession(Func<Task<Texture2D>> avatarGetter)
		{
			throw null;
		}

		// Token: 0x060061E1 RID: 25057 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<Sprite> GetAvatar()
		{
			throw null;
		}

		// Token: 0x060061E2 RID: 25058 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<bool> GetAndAssignAvatar(Image image, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x060061E3 RID: 25059 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<bool> method_0(Image image, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x04006C9B RID: 27803
		[JsonProperty("_id")]
		public string Id;

		// Token: 0x04006C9C RID: 27804
		[JsonProperty("avatar")]
		public string AvatarURL;

		// Token: 0x04006C9D RID: 27805
		[JsonProperty("balance_rub")]
		public long BalanceRUB;

		// Token: 0x04006C9E RID: 27806
		[JsonProperty("balance_dol")]
		public long BalanceUSD;

		// Token: 0x04006C9F RID: 27807
		[JsonProperty("balance_eur")]
		public long BalanceEUR;

		// Token: 0x04006CA0 RID: 27808
		[JsonProperty("discount")]
		public float Discount;

		// Token: 0x04006CA1 RID: 27809
		[JsonProperty("discount_end")]
		public long DiscountEnd;

		// Token: 0x04006CA2 RID: 27810
		[JsonProperty("buyer_up")]
		public bool BuyerUp;

		// Token: 0x04006CA3 RID: 27811
		[JsonProperty("sell_modifier_for_prohibited_items")]
		public int ProhibitedItemsSellModifier;

		// Token: 0x04006CA4 RID: 27812
		[JsonProperty("currency")]
		public ECurrencyType Currency;

		// Token: 0x04006CA5 RID: 27813
		[JsonProperty("repair")]
		public BackendConfigSettingsClass.TraderRepair Repair;

		// Token: 0x04006CA6 RID: 27814
		[JsonProperty("insurance")]
		public BackendConfigSettingsClass.TraderInsurance Insurance;

		// Token: 0x04006CA7 RID: 27815
		[JsonProperty("customization_seller")]
		public bool CustomizationSeller;

		// Token: 0x04006CA8 RID: 27816
		[JsonProperty("medic")]
		public bool Medic;

		// Token: 0x04006CA9 RID: 27817
		[JsonProperty("availableInRaid")]
		public bool AvailableInRaid;

		// Token: 0x04006CAA RID: 27818
		[JsonProperty("unlockedByDefault")]
		public bool UnlockedByDefault;

		// Token: 0x04006CAB RID: 27819
		[JsonProperty("nextResupply")]
		public int NextResupply;

		// Token: 0x04006CAC RID: 27820
		[JsonProperty("loyaltyLevels")]
		public BackendConfigSettingsClass.TraderLoyaltyLevel[] LoyaltyLevels;

		// Token: 0x04006CAD RID: 27821
		private Sprite _avatar;

		// Token: 0x04006CAE RID: 27822
		private Func<Task<Texture2D>> _avatarGetter;

		// Token: 0x04006CAF RID: 27823
		private Task<Texture2D> _avatarTask;

		// Token: 0x0200120F RID: 4623
		[Serializable]
		public class HandbookEntities
		{
			// Token: 0x17000F70 RID: 3952
			// (get) Token: 0x060061E4 RID: 25060 RVA: 0x00002050 File Offset: 0x00000250
			public IEnumerable<string> Items
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000F71 RID: 3953
			// (get) Token: 0x060061E5 RID: 25061 RVA: 0x00002050 File Offset: 0x00000250
			public IEnumerable<string> Categories
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x060061E6 RID: 25062 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool Contains(ItemTemplate itemTemplate)
			{
				throw null;
			}

			// Token: 0x04006CB0 RID: 27824
			[JsonProperty("id_list")]
			private string[] _items;

			// Token: 0x04006CB1 RID: 27825
			[JsonProperty("category")]
			private string[] _categories;
		}
	}

	// Token: 0x02001212 RID: 4626
	[Serializable]
	public sealed class TraderRepair
	{
		// Token: 0x04006CBC RID: 27836
		[JsonProperty("quality")]
		public float Quality;

		// Token: 0x04006CBD RID: 27837
		[JsonProperty("excluded_category")]
		public string[] ExcludedCategories;

		// Token: 0x04006CBE RID: 27838
		[JsonProperty("currency")]
		public string Currency;

		// Token: 0x04006CBF RID: 27839
		[JsonProperty("currency_coefficient")]
		public float CurrencyCoefficient;

		// Token: 0x04006CC0 RID: 27840
		[JsonProperty("availability")]
		public bool Availability;
	}

	// Token: 0x02001213 RID: 4627
	[Serializable]
	public sealed class TraderInsurance
	{
		// Token: 0x04006CC1 RID: 27841
		[JsonProperty("availability")]
		public bool Availability;

		// Token: 0x04006CC2 RID: 27842
		[JsonProperty("min_payment")]
		public int MinPayment;

		// Token: 0x04006CC3 RID: 27843
		[JsonProperty("min_return_hour")]
		public int MinReturnHours;

		// Token: 0x04006CC4 RID: 27844
		[JsonProperty("max_return_hour")]
		public int MaxReturnHours;

		// Token: 0x04006CC5 RID: 27845
		[JsonProperty("excluded_category")]
		public string[] ExcludedCategories;
	}

	// Token: 0x02001214 RID: 4628
	public sealed class GClass1347
	{
		// Token: 0x04006CC6 RID: 27846
		public int armorClassDivisor;

		// Token: 0x04006CC7 RID: 27847
		public float durabilityPointCostArmor;

		// Token: 0x04006CC8 RID: 27848
		public float durabilityPointCostGuns;

		// Token: 0x04006CC9 RID: 27849
		public Dictionary<ERepairStrategyType, BackendConfigSettingsClass.GClass1347.GClass1348> RepairStrategies;

		// Token: 0x04006CCA RID: 27850
		public float currentDurabilityLossToRemoveBuff;

		// Token: 0x04006CCB RID: 27851
		public float maxDurabilityLossToRemoveBuff;

		// Token: 0x04006CCC RID: 27852
		public int minimumLevelToApplyBuff;

		// Token: 0x04006CCD RID: 27853
		public Dictionary<ERepairBuffType, BackendConfigSettingsClass.GClass1347.GClass1349> ItemEnhancementSettings;

		// Token: 0x02001215 RID: 4629
		public sealed class GClass1348
		{
			// Token: 0x04006CCE RID: 27854
			public string[] Filter;

			// Token: 0x04006CCF RID: 27855
			public ERepairBuffType[] BuffTypes;
		}

		// Token: 0x02001216 RID: 4630
		public sealed class GClass1349
		{
			// Token: 0x04006CD0 RID: 27856
			public float PriceModifier;
		}
	}

	// Token: 0x02001217 RID: 4631
	public sealed class GClass1350
	{
		// Token: 0x060061EB RID: 25067 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetMultForLootingAttempts(int count)
		{
			throw null;
		}

		// Token: 0x04006CD1 RID: 27857
		[JsonProperty("loot_attempts")]
		public BackendConfigSettingsClass.GClass1350.GClass1351[] LootAttempts;

		// Token: 0x04006CD2 RID: 27858
		[JsonProperty("expForLockedDoorOpen")]
		public int ExpForLockedDoorOpen;

		// Token: 0x04006CD3 RID: 27859
		[JsonProperty("expForLockedDoorBreach")]
		public int ExpForLockedDoorBreach;

		// Token: 0x04006CD4 RID: 27860
		[JsonProperty("kill")]
		public BackendConfigSettingsClass.GClass1350.GClass1352 Kill;

		// Token: 0x04006CD5 RID: 27861
		[JsonProperty("level")]
		public BackendConfigSettingsClass.GClass1350.GClass1354 Level;

		// Token: 0x04006CD6 RID: 27862
		[JsonProperty("heal")]
		public BackendConfigSettingsClass.GClass1350.GClass1355 Heal;

		// Token: 0x04006CD7 RID: 27863
		[JsonProperty("match_end")]
		public BackendConfigSettingsClass.GClass1350.GClass1356 MatchEnd;

		// Token: 0x04006CD8 RID: 27864
		[JsonProperty("triggerMult")]
		public float TriggerMult;

		// Token: 0x02001218 RID: 4632
		public sealed class GClass1351
		{
			// Token: 0x04006CD9 RID: 27865
			[JsonProperty("k_exp")]
			public float Mult;
		}

		// Token: 0x02001219 RID: 4633
		public sealed class GClass1352
		{
			// Token: 0x060061EC RID: 25068 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public int GetKillingBonusPercent(int killed)
			{
				throw null;
			}

			// Token: 0x04006CDA RID: 27866
			[JsonProperty("victimLevelExp")]
			public int VictimLevelExp;

			// Token: 0x04006CDB RID: 27867
			[JsonProperty("victimBotLevelExp")]
			public int VictimBotLevelExp;

			// Token: 0x04006CDC RID: 27868
			[JsonProperty("pmcHeadShotMult")]
			public float PmcHeadShotMult;

			// Token: 0x04006CDD RID: 27869
			[JsonProperty("botHeadShotMult")]
			public float BotHeadShotMult;

			// Token: 0x04006CDE RID: 27870
			[JsonProperty("pmcExpOnDamageAllHealth")]
			public float PmcExpOnDamageAllHealth;

			// Token: 0x04006CDF RID: 27871
			[JsonProperty("botExpOnDamageAllHealth")]
			public float BotExpOnDamageAllHealth;

			// Token: 0x04006CE0 RID: 27872
			[JsonProperty("longShotDistance")]
			public float LongShotDistance;

			// Token: 0x04006CE1 RID: 27873
			[JsonProperty("bloodLossToLitre")]
			public float BloodLossToLitre;

			// Token: 0x04006CE2 RID: 27874
			[JsonProperty("combo")]
			public BackendConfigSettingsClass.GClass1350.GClass1352.GClass1353[] Combo;

			// Token: 0x0200121A RID: 4634
			public sealed class GClass1353
			{
				// Token: 0x04006CE3 RID: 27875
				[JsonProperty("percent")]
				public int Percent;
			}
		}

		// Token: 0x0200121B RID: 4635
		public sealed class GClass1354
		{
			// Token: 0x04006CE4 RID: 27876
			[JsonProperty("exp_table")]
			public GClass2130<int> Table;

			// Token: 0x04006CE5 RID: 27877
			[JsonProperty("mastering1")]
			public int Mastering1;

			// Token: 0x04006CE6 RID: 27878
			[JsonProperty("mastering2")]
			public int Mastering2;
		}

		// Token: 0x0200121C RID: 4636
		public sealed class GClass1355
		{
			// Token: 0x04006CE7 RID: 27879
			[JsonProperty("expForHeal")]
			public float ExpForHeal;

			// Token: 0x04006CE8 RID: 27880
			[JsonProperty("expForEnergy")]
			public float ExpForEnergy;

			// Token: 0x04006CE9 RID: 27881
			[JsonProperty("expForHydration")]
			public float ExpForHydration;
		}

		// Token: 0x0200121D RID: 4637
		public sealed class GClass1356
		{
			// Token: 0x060061ED RID: 25069 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public int GetReward(ExitStatus status)
			{
				throw null;
			}

			// Token: 0x060061EE RID: 25070 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public float GetMultiplier(ExitStatus exitStatus)
			{
				throw null;
			}

			// Token: 0x04006CEA RID: 27882
			[JsonProperty("survived_exp_requirement")]
			public int SurvivedExpRequirement;

			// Token: 0x04006CEB RID: 27883
			[JsonProperty("survived_seconds_requirement")]
			public int SurvivedTimeRequirement;

			// Token: 0x04006CEC RID: 27884
			[JsonProperty("survived_exp_reward")]
			public int SurvivedReward;

			// Token: 0x04006CED RID: 27885
			[JsonProperty("mia_exp_reward")]
			public int MiaReward;

			// Token: 0x04006CEE RID: 27886
			[JsonProperty("runner_exp_reward")]
			public int RunnerReward;

			// Token: 0x04006CEF RID: 27887
			[JsonProperty("leftMult")]
			public float LeftMult;

			// Token: 0x04006CF0 RID: 27888
			[JsonProperty("killedMult")]
			public float KilledMult;

			// Token: 0x04006CF1 RID: 27889
			[JsonProperty("miaMult")]
			public float MiaMult;

			// Token: 0x04006CF2 RID: 27890
			[JsonProperty("survivedMult")]
			public float SurvivedMult;

			// Token: 0x04006CF3 RID: 27891
			[JsonProperty("runnerMult")]
			public float RunnerMult;
		}
	}

	// Token: 0x0200121E RID: 4638
	public class AimingConfiguration
	{
		// Token: 0x04006CF4 RID: 27892
		public Vector3 ProceduralIntensityByPose;

		// Token: 0x04006CF5 RID: 27893
		public float AimProceduralIntensity;

		// Token: 0x04006CF6 RID: 27894
		public float MinTimeHeavy;

		// Token: 0x04006CF7 RID: 27895
		public float MaxTimeHeavy;

		// Token: 0x04006CF8 RID: 27896
		public float MinTimeLight;

		// Token: 0x04006CF9 RID: 27897
		public float MaxTimeLight;

		// Token: 0x04006CFA RID: 27898
		public float HeavyWeight;

		// Token: 0x04006CFB RID: 27899
		public float LightWeight;

		// Token: 0x04006CFC RID: 27900
		public float RecoilScaling;

		// Token: 0x04006CFD RID: 27901
		public float RecoilDamping;

		// Token: 0x04006CFE RID: 27902
		public float CameraSnapGlobalMult;

		// Token: 0x04006CFF RID: 27903
		public Vector3 RecoilXIntensityByPose;

		// Token: 0x04006D00 RID: 27904
		public Vector3 RecoilYIntensityByPose;

		// Token: 0x04006D01 RID: 27905
		public Vector3 RecoilZIntensityByPose;

		// Token: 0x04006D02 RID: 27906
		public bool RecoilCrank;

		// Token: 0x04006D03 RID: 27907
		public float RecoilHandDamping;

		// Token: 0x04006D04 RID: 27908
		public float RecoilConvergenceMult;

		// Token: 0x04006D05 RID: 27909
		public float RecoilVertBonus;

		// Token: 0x04006D06 RID: 27910
		public float RecoilBackBonus;
	}

	// Token: 0x0200121F RID: 4639
	public sealed class GClass1357
	{
		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x060061EF RID: 25071 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060061F0 RID: 25072 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty]
		public BackendConfigSettingsClass.GClass1357.PlayerHealthFactorsSettings ProfileHealthSettings
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

		// Token: 0x04006D07 RID: 27911
		[CompilerGenerated]
		private BackendConfigSettingsClass.GClass1357.PlayerHealthFactorsSettings playerHealthFactorsSettings_0;

		// Token: 0x04006D08 RID: 27912
		public GClass2420 Effects;

		// Token: 0x04006D09 RID: 27913
		public BackendConfigSettingsClass.GClass1357.GClass1358 Falling;

		// Token: 0x04006D0A RID: 27914
		public BackendConfigSettingsClass.GClass1357.GClass1359 HealPrice;

		// Token: 0x02001220 RID: 4640
		public sealed class HealthFactorData
		{
			// Token: 0x17000F73 RID: 3955
			// (get) Token: 0x060061F1 RID: 25073 RVA: 0x00002050 File Offset: 0x00000250
			public ValueStruct ValueStruct
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000F74 RID: 3956
			// (get) Token: 0x060061F2 RID: 25074 RVA: 0x00002050 File Offset: 0x00000250
			public Profile.GClass1753.ValueInfo ValueInfo
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000F75 RID: 3957
			// (get) Token: 0x060061F3 RID: 25075 RVA: 0x00002050 File Offset: 0x00000250
			public HealthValue HealthValue
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x04006D0B RID: 27915
			public float Minimum;

			// Token: 0x04006D0C RID: 27916
			public float Maximum;

			// Token: 0x04006D0D RID: 27917
			public float Default;

			// Token: 0x04006D0E RID: 27918
			public float OverDamageReceivedMultiplier;
		}

		// Token: 0x02001221 RID: 4641
		[Serializable]
		public sealed class PlayerHealthFactorsSettings
		{
			// Token: 0x17000F76 RID: 3958
			// (get) Token: 0x060061F4 RID: 25076 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060061F5 RID: 25077 RVA: 0x00002050 File Offset: 0x00000250
			[JsonProperty]
			public Dictionary<EBodyPart, BackendConfigSettingsClass.GClass1357.HealthFactorData> BodyPartsSettings
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

			// Token: 0x17000F78 RID: 3960
			// (get) Token: 0x060061F6 RID: 25078 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060061F7 RID: 25079 RVA: 0x00002050 File Offset: 0x00000250
			[JsonProperty]
			public string DefaultStimulatorBuff
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
		}

		// Token: 0x02001222 RID: 4642
		public sealed class GClass1358
		{
			// Token: 0x04006D0F RID: 27919
			public float DamagePerMeter;

			// Token: 0x04006D10 RID: 27920
			public float SafeHeight;
		}

		// Token: 0x02001223 RID: 4643
		public sealed class GClass1359
		{
			// Token: 0x060061F8 RID: 25080 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsFastHealFree(Profile profile)
			{
				throw null;
			}

			// Token: 0x04006D11 RID: 27921
			public float HealthPointPrice;

			// Token: 0x04006D12 RID: 27922
			public float HydrationPointPrice;

			// Token: 0x04006D13 RID: 27923
			public float EnergyPointPrice;

			// Token: 0x04006D14 RID: 27924
			public int TrialLevels;

			// Token: 0x04006D15 RID: 27925
			public int TrialRaids;
		}
	}

	// Token: 0x02001224 RID: 4644
	public sealed class GClass1360
	{
		// Token: 0x04006D16 RID: 27926
		public float Destructibility;

		// Token: 0x04006D17 RID: 27927
		public float MinRepairDegradation;

		// Token: 0x04006D18 RID: 27928
		public float MaxRepairDegradation;

		// Token: 0x04006D19 RID: 27929
		public float ExplosionDestructibility;

		// Token: 0x04006D1A RID: 27930
		public float MinRepairKitDegradation;

		// Token: 0x04006D1B RID: 27931
		public float MaxRepairKitDegradation;
	}

	// Token: 0x02001225 RID: 4645
	public sealed class GClass1361
	{
		// Token: 0x060061F9 RID: 25081 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BackendConfigSettingsClass.GClass1361.GClass1362 GetArmorClass(int classIndex)
		{
			throw null;
		}

		// Token: 0x04006D1C RID: 27932
		[JsonProperty("class")]
		public BackendConfigSettingsClass.GClass1361.GClass1362[] ArmorClass;

		// Token: 0x02001226 RID: 4646
		public sealed class GClass1362
		{
			// Token: 0x04006D1D RID: 27933
			[JsonProperty("resistance")]
			public int Resistance;
		}
	}

	// Token: 0x02001227 RID: 4647
	public sealed class GClass1363
	{
		// Token: 0x04006D1E RID: 27934
		public string[] Templates;

		// Token: 0x04006D1F RID: 27935
		[JsonProperty("Name")]
		public string Id;

		// Token: 0x04006D20 RID: 27936
		public int Level2;

		// Token: 0x04006D21 RID: 27937
		public int Level3;
	}

	// Token: 0x02001228 RID: 4648
	public sealed class GClass1364
	{
		// Token: 0x060061FA RID: 25082 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetAt(float normalEnergy)
		{
			throw null;
		}

		// Token: 0x04006D22 RID: 27938
		public float LowerLeftPoint;

		// Token: 0x04006D23 RID: 27939
		public float LowerRightPoint;

		// Token: 0x04006D24 RID: 27940
		public float LeftPlatoPoint;

		// Token: 0x04006D25 RID: 27941
		public float RightPlatoPoint;

		// Token: 0x04006D26 RID: 27942
		public float RightLimit;

		// Token: 0x04006D27 RID: 27943
		public float ZeroValue;
	}

	// Token: 0x02001229 RID: 4649
	public sealed class GClass1365
	{
		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x060061FB RID: 25083 RVA: 0x00002050 File Offset: 0x00000250
		public float LowerOverweightLimit
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x060061FC RID: 25084 RVA: 0x00002050 File Offset: 0x00000250
		public float UpperOverweightLimit
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04006D28 RID: 27944
		public float Capacity;

		// Token: 0x04006D29 RID: 27945
		public float SprintDrainRate;

		// Token: 0x04006D2A RID: 27946
		public float BaseRestorationRate;

		// Token: 0x04006D2B RID: 27947
		public float JumpConsumption;

		// Token: 0x04006D2C RID: 27948
		public float WeaponFastSwitchConsumption;

		// Token: 0x04006D2D RID: 27949
		public float GrenadeHighThrow;

		// Token: 0x04006D2E RID: 27950
		public float GrenadeLowThrow;

		// Token: 0x04006D2F RID: 27951
		public float AimDrainRate;

		// Token: 0x04006D30 RID: 27952
		public float AimRangeFinderDrainRate;

		// Token: 0x04006D31 RID: 27953
		public float OxygenCapacity;

		// Token: 0x04006D32 RID: 27954
		public float OxygenRestoration;

		// Token: 0x04006D33 RID: 27955
		public float HandsCapacity;

		// Token: 0x04006D34 RID: 27956
		public float HandsRestoration;

		// Token: 0x04006D35 RID: 27957
		public Vector2 WalkOverweightLimits;

		// Token: 0x04006D36 RID: 27958
		public Vector2 BaseOverweightLimits;

		// Token: 0x04006D37 RID: 27959
		public Vector2 SprintOverweightLimits;

		// Token: 0x04006D38 RID: 27960
		public Vector2 WalkSpeedOverweightLimits;

		// Token: 0x04006D39 RID: 27961
		public Vector2 CrouchConsumption;

		// Token: 0x04006D3A RID: 27962
		public Vector2 WalkConsumption;

		// Token: 0x04006D3B RID: 27963
		public Vector2 TransitionSpeed;

		// Token: 0x04006D3C RID: 27964
		public Vector2 VaultLegsConsumption;

		// Token: 0x04006D3D RID: 27965
		public Vector2 VaultOneHandConsumption;

		// Token: 0x04006D3E RID: 27966
		public Vector3 ClimbLegsConsumption;

		// Token: 0x04006D3F RID: 27967
		public Vector3 ClimbOneHandConsumption;

		// Token: 0x04006D40 RID: 27968
		public Vector3 ClimbTwoHandsConsumption;

		// Token: 0x04006D41 RID: 27969
		public Vector2 PoseLevelIncreaseSpeed;

		// Token: 0x04006D42 RID: 27970
		public Vector2 PoseLevelDecreaseSpeed;

		// Token: 0x04006D43 RID: 27971
		public Vector2 StandupConsumption;

		// Token: 0x04006D44 RID: 27972
		public Vector2 PoseLevelConsumptionPerNotch;

		// Token: 0x04006D45 RID: 27973
		public Vector2 SoundRadius;

		// Token: 0x04006D46 RID: 27974
		public float SprintSpeedLowerLimit;

		// Token: 0x04006D47 RID: 27975
		public float SprintSensitivityLowerLimit;

		// Token: 0x04006D48 RID: 27976
		public float AimingSpeedMultiplier;

		// Token: 0x04006D49 RID: 27977
		public float WalkVisualEffectMultiplier;

		// Token: 0x04006D4A RID: 27978
		public Vector3 AimConsumptionByPose;

		// Token: 0x04006D4B RID: 27979
		public Vector3 RestorationMultiplierByPose;

		// Token: 0x04006D4C RID: 27980
		public Vector3 OverweightConsumptionByPose;

		// Token: 0x04006D4D RID: 27981
		public float ProneConsumption;

		// Token: 0x04006D4E RID: 27982
		public float BaseHoldBreathConsumption;

		// Token: 0x04006D4F RID: 27983
		public float ExhaustedMeleeSpeed;

		// Token: 0x04006D50 RID: 27984
		public float FatigueRestorationRate;

		// Token: 0x04006D51 RID: 27985
		public float FatigueAmountToCreateEffect;

		// Token: 0x04006D52 RID: 27986
		public float ExhaustedMeleeDamageMultiplier;

		// Token: 0x04006D53 RID: 27987
		public float FallDamageMultiplier;

		// Token: 0x04006D54 RID: 27988
		public float SafeHeightOverweight;

		// Token: 0x04006D55 RID: 27989
		public Vector2 HoldBreathStaminaMultiplier;

		// Token: 0x04006D56 RID: 27990
		public bool StaminaExhaustionCausesJiggle;

		// Token: 0x04006D57 RID: 27991
		public bool StaminaExhaustionStartsBreathSound;

		// Token: 0x04006D58 RID: 27992
		public bool StaminaExhaustionRocksCamera;
	}

	// Token: 0x0200122A RID: 4650
	public sealed class GClass1366
	{
		// Token: 0x04006D59 RID: 27993
		public string TemplateId;

		// Token: 0x04006D5A RID: 27994
		public int MaxInLobby;

		// Token: 0x04006D5B RID: 27995
		public int MaxInRaid;
	}

	// Token: 0x0200122B RID: 4651
	public sealed class GClass1367
	{
		// Token: 0x04006D5C RID: 27996
		public float AmmoMalfChanceMult;

		// Token: 0x04006D5D RID: 27997
		public float MagazineMalfChanceMult;

		// Token: 0x04006D5E RID: 27998
		public float MalfRepairHardSlideMult;

		// Token: 0x04006D5F RID: 27999
		public float MalfRepairOneHandBrokenMult;

		// Token: 0x04006D60 RID: 28000
		public float MalfRepairTwoHandsBrokenMult;

		// Token: 0x04006D61 RID: 28001
		public bool AllowMalfForBots;

		// Token: 0x04006D62 RID: 28002
		public int ShowGlowAttemptsCount;

		// Token: 0x04006D63 RID: 28003
		public float OutToIdleSpeedMultForPistol;

		// Token: 0x04006D64 RID: 28004
		public float IdleToOutSpeedMultOnMalf;

		// Token: 0x04006D65 RID: 28005
		public float TimeToQuickdrawPistol;

		// Token: 0x04006D66 RID: 28006
		public Vector3 DurRangeToIgnoreMalfs;

		// Token: 0x04006D67 RID: 28007
		public float DurFeedWt;

		// Token: 0x04006D68 RID: 28008
		public float DurMisfireWt;

		// Token: 0x04006D69 RID: 28009
		public float DurJamWt;

		// Token: 0x04006D6A RID: 28010
		public float DurSoftSlideWt;

		// Token: 0x04006D6B RID: 28011
		public float DurHardSlideMinWt;

		// Token: 0x04006D6C RID: 28012
		public float DurHardSlideMaxWt;

		// Token: 0x04006D6D RID: 28013
		public float AmmoMisfireWt;

		// Token: 0x04006D6E RID: 28014
		public float AmmoFeedWt;

		// Token: 0x04006D6F RID: 28015
		public float AmmoJamWt;

		// Token: 0x04006D70 RID: 28016
		public float OverheatFeedWt;

		// Token: 0x04006D71 RID: 28017
		public float OverheatJamWt;

		// Token: 0x04006D72 RID: 28018
		public float OverheatSoftSlideWt;

		// Token: 0x04006D73 RID: 28019
		public float OverheatHardSlideMinWt;

		// Token: 0x04006D74 RID: 28020
		public float OverheatHardSlideMaxWt;
	}

	// Token: 0x0200122C RID: 4652
	public sealed class GClass1368
	{
		// Token: 0x04006D75 RID: 28021
		public float MinOverheat;

		// Token: 0x04006D76 RID: 28022
		public float MaxOverheat;

		// Token: 0x04006D77 RID: 28023
		public float OverheatProblemsStart;

		// Token: 0x04006D78 RID: 28024
		public float ModHeatFactor;

		// Token: 0x04006D79 RID: 28025
		public float ModCoolFactor;

		// Token: 0x04006D7A RID: 28026
		public float MinWearOnOverheat;

		// Token: 0x04006D7B RID: 28027
		public float MaxWearOnOverheat;

		// Token: 0x04006D7C RID: 28028
		public float MinWearOnMaxOverheat;

		// Token: 0x04006D7D RID: 28029
		public float MaxWearOnMaxOverheat;

		// Token: 0x04006D7E RID: 28030
		public float OverheatWearLimit;

		// Token: 0x04006D7F RID: 28031
		public float MaxCOIIncreaseMult;

		// Token: 0x04006D80 RID: 28032
		public float MinMalfChance;

		// Token: 0x04006D81 RID: 28033
		public float MaxMalfChance;

		// Token: 0x04006D82 RID: 28034
		public float DurReduceMinMult;

		// Token: 0x04006D83 RID: 28035
		public float DurReduceMaxMult;

		// Token: 0x04006D84 RID: 28036
		public float BarrelMoveRndDuration;

		// Token: 0x04006D85 RID: 28037
		public float BarrelMoveMaxMult;

		// Token: 0x04006D86 RID: 28038
		public float FireratePitchMult;

		// Token: 0x04006D87 RID: 28039
		public float FirerateReduceMinMult;

		// Token: 0x04006D88 RID: 28040
		public float FirerateReduceMaxMult;

		// Token: 0x04006D89 RID: 28041
		public float FirerateOverheatBorder;

		// Token: 0x04006D8A RID: 28042
		public bool EnableSlideOnMaxOverheat;

		// Token: 0x04006D8B RID: 28043
		public float StartSlideOverheat;

		// Token: 0x04006D8C RID: 28044
		public float FixSlideOverheat;

		// Token: 0x04006D8D RID: 28045
		public float AutoshotMinOverheat;

		// Token: 0x04006D8E RID: 28046
		public float AutoshotChance;

		// Token: 0x04006D8F RID: 28047
		public float AutoshotPossibilityDuration;

		// Token: 0x04006D90 RID: 28048
		public float HeatVisibleFactor;

		// Token: 0x04006D91 RID: 28049
		public float HeatThermalFactor;

		// Token: 0x04006D92 RID: 28050
		public float MaxOverheatCoolCoef;
	}

	// Token: 0x0200122D RID: 4653
	public sealed class InertiaSettings
	{
		// Token: 0x04006D93 RID: 28051
		public Vector2 ExitMovementStateSpeedThreshold;

		// Token: 0x04006D94 RID: 28052
		public Vector2 WalkInertia;

		// Token: 0x04006D95 RID: 28053
		public float FallThreshold;

		// Token: 0x04006D96 RID: 28054
		public Vector2 SpeedLimitAfterFallMin;

		// Token: 0x04006D97 RID: 28055
		public Vector2 SpeedLimitAfterFallMax;

		// Token: 0x04006D98 RID: 28056
		public Vector2 SpeedLimitDurationMin;

		// Token: 0x04006D99 RID: 28057
		public Vector2 SpeedLimitDurationMax;

		// Token: 0x04006D9A RID: 28058
		public Vector2 SpeedInertiaAfterJump;

		// Token: 0x04006D9B RID: 28059
		public float BaseJumpPenaltyDuration;

		// Token: 0x04006D9C RID: 28060
		public float DurationPower;

		// Token: 0x04006D9D RID: 28061
		public float BaseJumpPenalty;

		// Token: 0x04006D9E RID: 28062
		public float PenaltyPower;

		// Token: 0x04006D9F RID: 28063
		public Vector2 InertiaTiltCurveMin;

		// Token: 0x04006DA0 RID: 28064
		public Vector2 InertiaTiltCurveMax;

		// Token: 0x04006DA1 RID: 28065
		public Vector2 InertiaBackwardCoef;

		// Token: 0x04006DA2 RID: 28066
		public Vector2 TiltInertiaMaxSpeed;

		// Token: 0x04006DA3 RID: 28067
		public Vector2 TiltStartSideBackSpeed;

		// Token: 0x04006DA4 RID: 28068
		public Vector2 TiltMaxSideBackSpeed;

		// Token: 0x04006DA5 RID: 28069
		public Vector2 TiltAcceleration;

		// Token: 0x04006DA6 RID: 28070
		public int AverageRotationFrameSpan;

		// Token: 0x04006DA7 RID: 28071
		public Vector2 SprintSpeedInertiaCurveMin;

		// Token: 0x04006DA8 RID: 28072
		public Vector2 SprintSpeedInertiaCurveMax;

		// Token: 0x04006DA9 RID: 28073
		public Vector2 SprintBrakeInertia;

		// Token: 0x04006DAA RID: 28074
		public Vector2 SprintTransitionMotionPreservation;

		// Token: 0x04006DAB RID: 28075
		public Vector3 InertiaLimits;

		// Token: 0x04006DAC RID: 28076
		public Vector2 WeaponFlipSpeed;

		// Token: 0x04006DAD RID: 28077
		public float InertiaLimitsStep;

		// Token: 0x04006DAE RID: 28078
		public Vector2 SprintAccelerationLimits;

		// Token: 0x04006DAF RID: 28079
		public Vector2 PreSprintAccelerationLimits;

		// Token: 0x04006DB0 RID: 28080
		public Vector2 SideTime;

		// Token: 0x04006DB1 RID: 28081
		public Vector2 DiagonalTime;

		// Token: 0x04006DB2 RID: 28082
		public float MinDirectionBlendTime;

		// Token: 0x04006DB3 RID: 28083
		public Vector2 MoveTimeRange;

		// Token: 0x04006DB4 RID: 28084
		public Vector2 MinMovementAccelerationRangeRight;

		// Token: 0x04006DB5 RID: 28085
		public Vector2 MaxMovementAccelerationRangeRight;

		// Token: 0x04006DB6 RID: 28086
		public float SuddenChangesSmoothness;

		// Token: 0x04006DB7 RID: 28087
		public Vector2 MaxTimeWithoutInput;

		// Token: 0x04006DB8 RID: 28088
		public Vector2 ProneDirectionAccelerationRange;

		// Token: 0x04006DB9 RID: 28089
		public Vector2 ProneSpeedAccelerationRange;

		// Token: 0x04006DBA RID: 28090
		public Vector2 DiagonalStayTimeRange;

		// Token: 0x04006DBB RID: 28091
		public Vector2 CrouchSpeedAccelerationRange;
	}

	// Token: 0x0200122E RID: 4654
	public sealed class GClass1369
	{
		// Token: 0x04006DBC RID: 28092
		public float GlobalDamageDegradationCoefficient;
	}

	// Token: 0x0200122F RID: 4655
	public sealed class GClass1370
	{
		// Token: 0x04006DBD RID: 28093
		public int PlaneMinFlightHeight;

		// Token: 0x04006DBE RID: 28094
		public int PlaneMaxFlightHeight;

		// Token: 0x04006DBF RID: 28095
		public int PlaneSpeed;

		// Token: 0x04006DC0 RID: 28096
		public int PlaneAdditionalDistance;

		// Token: 0x04006DC1 RID: 28097
		public int ParachuteStartOpenHeight;

		// Token: 0x04006DC2 RID: 28098
		public int ParachuteEndOpenHeight;

		// Token: 0x04006DC3 RID: 28099
		public int PlaneAirdropDuration;

		// Token: 0x04006DC4 RID: 28100
		public int SmokeActivateHeight;

		// Token: 0x04006DC5 RID: 28101
		public int PlaneAirdropSmoke;

		// Token: 0x04006DC6 RID: 28102
		public int PlaneAirdropFlareWait;
	}

	// Token: 0x02001230 RID: 4656
	public sealed class GClass1371
	{
		// Token: 0x04006DC7 RID: 28103
		public float CustomerCriticalTimeStart;

		// Token: 0x04006DC8 RID: 28104
		public float CustomerKickNotifTime;

		// Token: 0x04006DC9 RID: 28105
		public float CustomerAccessTime;
	}

	// Token: 0x02001231 RID: 4657
	public sealed class GClass1372
	{
		// Token: 0x04006DCA RID: 28106
		public string[] AvailableVersions;
	}

	// Token: 0x02001232 RID: 4658
	public sealed class GClass1373
	{
		// Token: 0x04006DCB RID: 28107
		public bool EventActive;

		// Token: 0x04006DCC RID: 28108
		public int EventTime;

		// Token: 0x04006DCD RID: 28109
		public int WeatherChangeTime;

		// Token: 0x04006DCE RID: 28110
		public float ExitTimeMultiplier;

		// Token: 0x04006DCF RID: 28111
		public float StaminaMultiplier;

		// Token: 0x04006DD0 RID: 28112
		public GClass1479 EventWeather;

		// Token: 0x04006DD1 RID: 28113
		public GClass1479 SummonSuccessWeather;

		// Token: 0x04006DD2 RID: 28114
		public GClass1479 SummonFailedWeather;

		// Token: 0x04006DD3 RID: 28115
		public string[] LocationsToIgnore;
	}

	// Token: 0x02001233 RID: 4659
	[Serializable]
	public sealed class BTRGlobalSettings
	{
		// Token: 0x04006DD4 RID: 28116
		public string[] LocationsWithBTR;

		// Token: 0x04006DD5 RID: 28117
		public int BasePriceTaxi;

		// Token: 0x04006DD6 RID: 28118
		public int AddPriceTaxi;

		// Token: 0x04006DD7 RID: 28119
		public int CleanUpPrice;

		// Token: 0x04006DD8 RID: 28120
		public int DeliveryPrice;

		// Token: 0x04006DD9 RID: 28121
		public float ModDeliveryCost;

		// Token: 0x04006DDA RID: 28122
		public float BearPriceMod;

		// Token: 0x04006DDB RID: 28123
		public float UsecPriceMod;

		// Token: 0x04006DDC RID: 28124
		public float ScavPriceMod;

		// Token: 0x04006DDD RID: 28125
		public float CoefficientDiscountCharisma;

		// Token: 0x04006DDE RID: 28126
		public int TaxiMinPrice;

		// Token: 0x04006DDF RID: 28127
		public int DeliveryMinPrice;

		// Token: 0x04006DE0 RID: 28128
		public int BotCoverMinPrice;

		// Token: 0x04006DE1 RID: 28129
		public float DiameterWheel;

		// Token: 0x04006DE2 RID: 28130
		public float HeightWheel;

		// Token: 0x04006DE3 RID: 28131
		public float HeightWheelOffset;

		// Token: 0x04006DE4 RID: 28132
		public float HeightWheelMaxPosLimit;

		// Token: 0x04006DE5 RID: 28133
		public float HeightWheelMinPosLimit;

		// Token: 0x04006DE6 RID: 28134
		public float SnapToSurfaceWheelsSpeed;

		// Token: 0x04006DE7 RID: 28135
		public float CheckSurfaceForWheelsTimer;

		// Token: 0x04006DE8 RID: 28136
		public Dictionary<string, BTRMapPath> MapsConfigs;
	}

	// Token: 0x02001234 RID: 4660
	public sealed class GClass1374
	{
		// Token: 0x04006DE9 RID: 28137
		public float ItemRemoveAfterInterruptionTime;
	}

	// Token: 0x02001235 RID: 4661
	[Serializable]
	public sealed class TradingGlobalSettings
	{
		// Token: 0x04006DEA RID: 28138
		public BackendConfigSettingsClass.BuyoutRestrictions BuyoutRestrictions;
	}

	// Token: 0x02001236 RID: 4662
	[Serializable]
	public sealed class BuyoutRestrictions
	{
		// Token: 0x04006DEB RID: 28139
		public float MinFoodDrinkResource;

		// Token: 0x04006DEC RID: 28140
		public float MinMedsResource;

		// Token: 0x04006DED RID: 28141
		public float MinDurability;
	}

	// Token: 0x02001237 RID: 4663
	[Serializable]
	public sealed class VaultingGlobalSettings : IVaultingSettings
	{
		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x060061FD RID: 25085 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060061FE RID: 25086 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("IsActive")]
		public bool IsActive
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x060061FF RID: 25087 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006200 RID: 25088 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("VaultingInputTime")]
		public float VaultingInputTime
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000F7D RID: 3965
		// (get) Token: 0x06006201 RID: 25089 RVA: 0x00002050 File Offset: 0x00000250
		bool IVaultingSettings.IsActive
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000F7E RID: 3966
		// (get) Token: 0x06006202 RID: 25090 RVA: 0x00002050 File Offset: 0x00000250
		float IVaultingSettings.VaultingInputTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000F7F RID: 3967
		// (get) Token: 0x06006203 RID: 25091 RVA: 0x00002050 File Offset: 0x00000250
		IGridSettings IVaultingSettings.GridSettings
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x06006204 RID: 25092 RVA: 0x00002050 File Offset: 0x00000250
		IMovesSettings IVaultingSettings.MovesSettings
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04006DEE RID: 28142
		[JsonProperty("GridSettings")]
		public readonly BackendConfigSettingsClass.GridSettings GridSettings;

		// Token: 0x04006DEF RID: 28143
		[JsonProperty("MovesSettings")]
		public readonly BackendConfigSettingsClass.MovesSettings MovesSettings;
	}

	// Token: 0x02001238 RID: 4664
	[Serializable]
	public sealed class GridSettings : IGridSettings
	{
		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x06006205 RID: 25093 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006206 RID: 25094 RVA: 0x00002050 File Offset: 0x00000250
		public float GridSizeX
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x06006207 RID: 25095 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006208 RID: 25096 RVA: 0x00002050 File Offset: 0x00000250
		public float GridSizeY
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x06006209 RID: 25097 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600620A RID: 25098 RVA: 0x00002050 File Offset: 0x00000250
		public float GridSizeZ
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x0600620B RID: 25099 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600620C RID: 25100 RVA: 0x00002050 File Offset: 0x00000250
		public float SteppingLengthX
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x0600620D RID: 25101 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600620E RID: 25102 RVA: 0x00002050 File Offset: 0x00000250
		public float SteppingLengthY
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000F86 RID: 3974
		// (get) Token: 0x0600620F RID: 25103 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006210 RID: 25104 RVA: 0x00002050 File Offset: 0x00000250
		public float SteppingLengthZ
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000F87 RID: 3975
		// (get) Token: 0x06006211 RID: 25105 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006212 RID: 25106 RVA: 0x00002050 File Offset: 0x00000250
		public float GridOffsetX
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000F88 RID: 3976
		// (get) Token: 0x06006213 RID: 25107 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006214 RID: 25108 RVA: 0x00002050 File Offset: 0x00000250
		public float GridOffsetY
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x06006215 RID: 25109 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006216 RID: 25110 RVA: 0x00002050 File Offset: 0x00000250
		public float GridOffsetZ
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public float OffsetFactor { get; }
	}

	// Token: 0x02001239 RID: 4665
	[Serializable]
	public sealed class MovesSettings : IMovesSettings
	{
		// Token: 0x17000F8B RID: 3979
		// (get) Token: 0x06006217 RID: 25111 RVA: 0x00002050 File Offset: 0x00000250
		IVaultSettings IMovesSettings.VaultSettings
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000F8C RID: 3980
		// (get) Token: 0x06006218 RID: 25112 RVA: 0x00002050 File Offset: 0x00000250
		IClimbSettings IMovesSettings.ClimbSettings
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04006DF0 RID: 28144
		[JsonProperty("VaultSettings")]
		public readonly BackendConfigSettingsClass.VaultSettings VaultSettings;

		// Token: 0x04006DF1 RID: 28145
		[JsonProperty("ClimbSettings")]
		public readonly BackendConfigSettingsClass.ClimbSettings ClimbSettings;
	}

	// Token: 0x0200123A RID: 4666
	[Serializable]
	public sealed class VaultSettings : IBaseMoveSettings, IVaultSettings
	{
		// Token: 0x17000F8D RID: 3981
		// (get) Token: 0x06006219 RID: 25113 RVA: 0x00002050 File Offset: 0x00000250
		bool IBaseMoveSettings.IsActive
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000F8E RID: 3982
		// (get) Token: 0x0600621A RID: 25114 RVA: 0x00002050 File Offset: 0x00000250
		float IBaseMoveSettings.MaxWithoutHandHeight
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000F8F RID: 3983
		// (get) Token: 0x0600621B RID: 25115 RVA: 0x00002050 File Offset: 0x00000250
		IMoveRestrictions IBaseMoveSettings.MoveRestrictions
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000F90 RID: 3984
		// (get) Token: 0x0600621C RID: 25116 RVA: 0x00002050 File Offset: 0x00000250
		IAutoMoveRestrictions IBaseMoveSettings.AutoMoveRestrictions
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04006DF2 RID: 28146
		[JsonProperty("IsActive")]
		public readonly bool IsActive;

		// Token: 0x04006DF3 RID: 28147
		[JsonProperty("MaxWithoutHandHeight")]
		public readonly float MaxWithoutHandHeight;

		// Token: 0x04006DF4 RID: 28148
		[JsonProperty("SpeedRange")]
		public readonly Vector2 SpeedRange;

		// Token: 0x04006DF5 RID: 28149
		[JsonProperty("MoveRestrictions")]
		public readonly BackendConfigSettingsClass.MoveRestrictions MoveRestrictions;

		// Token: 0x04006DF6 RID: 28150
		[JsonProperty("AutoMoveRestrictions")]
		public readonly BackendConfigSettingsClass.AutoMoveRestrictions AutoMoveRestrictions;
	}

	// Token: 0x0200123B RID: 4667
	[Serializable]
	public sealed class ClimbSettings : IBaseMoveSettings, IClimbSettings
	{
		// Token: 0x17000F91 RID: 3985
		// (get) Token: 0x0600621D RID: 25117 RVA: 0x00002050 File Offset: 0x00000250
		bool IBaseMoveSettings.IsActive
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000F92 RID: 3986
		// (get) Token: 0x0600621E RID: 25118 RVA: 0x00002050 File Offset: 0x00000250
		float IBaseMoveSettings.MaxWithoutHandHeight
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000F93 RID: 3987
		// (get) Token: 0x0600621F RID: 25119 RVA: 0x00002050 File Offset: 0x00000250
		float IClimbSettings.MaxOneHandHeight
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000F94 RID: 3988
		// (get) Token: 0x06006220 RID: 25120 RVA: 0x00002050 File Offset: 0x00000250
		IMoveRestrictions IBaseMoveSettings.MoveRestrictions
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000F95 RID: 3989
		// (get) Token: 0x06006221 RID: 25121 RVA: 0x00002050 File Offset: 0x00000250
		IAutoMoveRestrictions IBaseMoveSettings.AutoMoveRestrictions
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04006DF7 RID: 28151
		[JsonProperty("IsActive")]
		public readonly bool IsActive;

		// Token: 0x04006DF8 RID: 28152
		[JsonProperty("MaxWithoutHandHeight")]
		public readonly float MaxWithoutHandHeight;

		// Token: 0x04006DF9 RID: 28153
		[JsonProperty("MaxOneHandHeight")]
		public readonly float MaxOneHandHeight;

		// Token: 0x04006DFA RID: 28154
		[JsonProperty("SpeedRange")]
		public readonly Vector2 SpeedRange;

		// Token: 0x04006DFB RID: 28155
		[JsonProperty("MoveRestrictions")]
		public BackendConfigSettingsClass.MoveRestrictions MoveRestrictions;

		// Token: 0x04006DFC RID: 28156
		[JsonProperty("AutoMoveRestrictions")]
		public BackendConfigSettingsClass.AutoMoveRestrictions AutoMoveRestrictions;
	}

	// Token: 0x0200123C RID: 4668
	[Serializable]
	public sealed class MoveRestrictions : IVaultingRestrictions, IMoveRestrictions
	{
		// Token: 0x17000F96 RID: 3990
		// (get) Token: 0x06006222 RID: 25122 RVA: 0x00002050 File Offset: 0x00000250
		bool IVaultingRestrictions.IsActive
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000F97 RID: 3991
		// (get) Token: 0x06006223 RID: 25123 RVA: 0x00002050 File Offset: 0x00000250
		float IVaultingRestrictions.MinDistantToInteract
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000F98 RID: 3992
		// (get) Token: 0x06006224 RID: 25124 RVA: 0x00002050 File Offset: 0x00000250
		float IVaultingRestrictions.MinHeight
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000F99 RID: 3993
		// (get) Token: 0x06006225 RID: 25125 RVA: 0x00002050 File Offset: 0x00000250
		float IVaultingRestrictions.MaxHeight
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000F9A RID: 3994
		// (get) Token: 0x06006226 RID: 25126 RVA: 0x00002050 File Offset: 0x00000250
		float IVaultingRestrictions.MinLength
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000F9B RID: 3995
		// (get) Token: 0x06006227 RID: 25127 RVA: 0x00002050 File Offset: 0x00000250
		float IVaultingRestrictions.MaxLength
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04006DFD RID: 28157
		public bool IsActive;

		// Token: 0x04006DFE RID: 28158
		public float MinDistantToInteract;

		// Token: 0x04006DFF RID: 28159
		public float MinHeight;

		// Token: 0x04006E00 RID: 28160
		public float MaxHeight;

		// Token: 0x04006E01 RID: 28161
		public float MinLength;

		// Token: 0x04006E02 RID: 28162
		public float MaxLength;
	}

	// Token: 0x0200123D RID: 4669
	[Serializable]
	public sealed class AutoMoveRestrictions : IVaultingRestrictions, IAutoMoveRestrictions
	{
		// Token: 0x17000F9C RID: 3996
		// (get) Token: 0x06006228 RID: 25128 RVA: 0x00002050 File Offset: 0x00000250
		bool IVaultingRestrictions.IsActive
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000F9D RID: 3997
		// (get) Token: 0x06006229 RID: 25129 RVA: 0x00002050 File Offset: 0x00000250
		float IVaultingRestrictions.MinDistantToInteract
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000F9E RID: 3998
		// (get) Token: 0x0600622A RID: 25130 RVA: 0x00002050 File Offset: 0x00000250
		float IVaultingRestrictions.MinHeight
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000F9F RID: 3999
		// (get) Token: 0x0600622B RID: 25131 RVA: 0x00002050 File Offset: 0x00000250
		float IVaultingRestrictions.MaxHeight
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000FA0 RID: 4000
		// (get) Token: 0x0600622C RID: 25132 RVA: 0x00002050 File Offset: 0x00000250
		float IVaultingRestrictions.MinLength
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000FA1 RID: 4001
		// (get) Token: 0x0600622D RID: 25133 RVA: 0x00002050 File Offset: 0x00000250
		float IVaultingRestrictions.MaxLength
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04006E03 RID: 28163
		public bool IsActive;

		// Token: 0x04006E04 RID: 28164
		public float MinDistantToInteract;

		// Token: 0x04006E05 RID: 28165
		public float MinHeight;

		// Token: 0x04006E06 RID: 28166
		public float MaxHeight;

		// Token: 0x04006E07 RID: 28167
		public float MinLength;

		// Token: 0x04006E08 RID: 28168
		public float MaxLength;
	}

	// Token: 0x0200123E RID: 4670
	public sealed class GClass1375
	{
		// Token: 0x04006E09 RID: 28169
		public float WeaponPistolFastSwitchMaxSpeedMult;

		// Token: 0x04006E0A RID: 28170
		public float WeaponPistolFastSwitchMinSpeedMult;

		// Token: 0x04006E0B RID: 28171
		public float WeaponFastSwitchMaxSpeedMult;

		// Token: 0x04006E0C RID: 28172
		public float WeaponFastSwitchMinSpeedMult;

		// Token: 0x04006E0D RID: 28173
		public float HandShakeMaxDuration;

		// Token: 0x04006E0E RID: 28174
		public float HandShakeTremorIntensity;

		// Token: 0x04006E0F RID: 28175
		public float HandShakeCurveFrequency;

		// Token: 0x04006E10 RID: 28176
		public float HandShakeCurveIntensity;
	}

	// Token: 0x0200123F RID: 4671
	public sealed class GClass1376
	{
		// Token: 0x0600622E RID: 25134 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetPreset(int type, out BackendConfigSettingsClass.GClass1376.GClass1377 preset)
		{
			throw null;
		}

		// Token: 0x04006E11 RID: 28177
		[JsonProperty("AudioGroupPresets")]
		public BackendConfigSettingsClass.GClass1376.GClass1377[] Presets;

		// Token: 0x04006E12 RID: 28178
		[JsonProperty("EnvironmentSettings")]
		public BackendConfigSettingsClass.GClass1376.GClass1378 EnvironmentSettings;

		// Token: 0x04006E13 RID: 28179
		private Dictionary<int, BackendConfigSettingsClass.GClass1376.GClass1377> dictionary_0;

		// Token: 0x02001240 RID: 4672
		public sealed class GClass1377
		{
			// Token: 0x04006E14 RID: 28180
			public string Name;

			// Token: 0x04006E15 RID: 28181
			public int GroupType;

			// Token: 0x04006E16 RID: 28182
			public float OverallVolume;

			// Token: 0x04006E17 RID: 28183
			public bool OcclusionEnabled;

			// Token: 0x04006E18 RID: 28184
			public float OcclusionIntensity;

			// Token: 0x04006E19 RID: 28185
			public bool DisabledBinauralByDistance;

			// Token: 0x04006E1A RID: 28186
			public float DistanceToAllowBinaural;

			// Token: 0x04006E1B RID: 28187
			public float HeightToAllowBinaural;

			// Token: 0x04006E1C RID: 28188
			public float AngleToAllowBinaural;
		}

		// Token: 0x02001241 RID: 4673
		public sealed class GClass1378
		{
			// Token: 0x0600622F RID: 25135 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public float GetMultBySurface(BaseBallistic.ESurfaceSound surfaceType)
			{
				throw null;
			}

			// Token: 0x06006230 RID: 25136 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_0()
			{
				throw null;
			}

			// Token: 0x04006E1D RID: 28189
			public float SnowStepsVolumeMultiplier;

			// Token: 0x04006E1E RID: 28190
			public List<BackendConfigSettingsClass.GClass1376.GClass1379> SurfaceMultipliers;

			// Token: 0x04006E1F RID: 28191
			private Dictionary<BaseBallistic.ESurfaceSound, float> dictionary_0;
		}

		// Token: 0x02001242 RID: 4674
		public sealed class GClass1379
		{
			// Token: 0x04006E20 RID: 28192
			public BaseBallistic.ESurfaceSound SurfaceType;

			// Token: 0x04006E21 RID: 28193
			public float VolumeMult;
		}
	}

	// Token: 0x02001243 RID: 4675
	public sealed class GClass1380
	{
		// Token: 0x04006E22 RID: 28194
		public bool ExperimentalFogInCity;
	}

	// Token: 0x02001244 RID: 4676
	public sealed class GClass1381
	{
		// Token: 0x04006E23 RID: 28195
		public int WeaponStandMaxItemsCount;

		// Token: 0x04006E24 RID: 28196
		public int PlaceOfFameMaxItemsCount;
	}
}
