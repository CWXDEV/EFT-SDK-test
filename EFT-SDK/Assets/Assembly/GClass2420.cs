using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.HealthSystem;

// Token: 0x0200218E RID: 8590
public class GClass2420
{
	// Token: 0x0400B558 RID: 46424
	public GClass2420.GClass2421 Existence;

	// Token: 0x0400B559 RID: 46425
	public GClass2420.GClass2422 Dehydration;

	// Token: 0x0400B55A RID: 46426
	public GClass2420.GClass2423 LightBleeding;

	// Token: 0x0400B55B RID: 46427
	public GClass2420.GClass2423 HeavyBleeding;

	// Token: 0x0400B55C RID: 46428
	public GClass2420.GClass2424 Fracture;

	// Token: 0x0400B55D RID: 46429
	public GClass2420.GClass2425 Contusion;

	// Token: 0x0400B55E RID: 46430
	public GClass2420.GClass2426 Disorientation;

	// Token: 0x0400B55F RID: 46431
	public GClass2420.GClass2427 Exhaustion;

	// Token: 0x0400B560 RID: 46432
	public GClass2420.GClass2428 LowEdgeHealth;

	// Token: 0x0400B561 RID: 46433
	public GClass2420.GClass2429 RadExposure;

	// Token: 0x0400B562 RID: 46434
	public GClass2420.GClass2430 Stun;

	// Token: 0x0400B563 RID: 46435
	public GClass2420.GClass2431 Intoxication;

	// Token: 0x0400B564 RID: 46436
	public GClass2420.GClass2432 LethalIntoxication;

	// Token: 0x0400B565 RID: 46437
	public GClass2420.GClass2434 Regeneration;

	// Token: 0x0400B566 RID: 46438
	public GClass2420.GClass2437 Wound;

	// Token: 0x0400B567 RID: 46439
	public GClass2420.GClass2439 Berserk;

	// Token: 0x0400B568 RID: 46440
	public GClass2420.GClass2441 MedEffect;

	// Token: 0x0400B569 RID: 46441
	public GClass2420.GClass2440 Flash;

	// Token: 0x0400B56A RID: 46442
	public GClass2420.GClass2442 Pain;

	// Token: 0x0400B56B RID: 46443
	public GClass2420.GClass2443 PainKiller;

	// Token: 0x0400B56C RID: 46444
	public GClass2420.GClass2444 SandingScreen;

	// Token: 0x0400B56D RID: 46445
	public GClass2420.GClass2445 Stimulator;

	// Token: 0x0400B56E RID: 46446
	public GClass2420.GClass2447 Tremor;

	// Token: 0x0400B56F RID: 46447
	public GClass2420.GClass2438 ChronicStaminaFatigue;

	// Token: 0x0400B570 RID: 46448
	public GClass2420.GClass2448 BodyTemperature;

	// Token: 0x0400B571 RID: 46449
	public GClass2420.GClass2449 HealthBoost;

	// Token: 0x0400B572 RID: 46450
	public GClass2420.GClass2451 MildMusclePain;

	// Token: 0x0400B573 RID: 46451
	public GClass2420.GClass2451 SevereMusclePain;

	// Token: 0x0200218F RID: 8591
	public class GClass2421
	{
		// Token: 0x0400B574 RID: 46452
		public float EnergyLoopTime;

		// Token: 0x0400B575 RID: 46453
		public float HydrationLoopTime;

		// Token: 0x0400B576 RID: 46454
		public float EnergyDamage;

		// Token: 0x0400B577 RID: 46455
		public float HydrationDamage;

		// Token: 0x0400B578 RID: 46456
		public float DestroyedStomachEnergyTimeFactor;

		// Token: 0x0400B579 RID: 46457
		public float DestroyedStomachHydrationTimeFactor;
	}

	// Token: 0x02002190 RID: 8592
	public class GClass2422
	{
		// Token: 0x0400B57A RID: 46458
		public float DefaultDelay;

		// Token: 0x0400B57B RID: 46459
		public float DefaultResidueTime;

		// Token: 0x0400B57C RID: 46460
		public float DamageOnStrongDehydration;

		// Token: 0x0400B57D RID: 46461
		public float StrongDehydrationLoopTime;
	}

	// Token: 0x02002191 RID: 8593
	public class GClass2423
	{
		// Token: 0x0400B57E RID: 46462
		public float DefaultDelay;

		// Token: 0x0400B57F RID: 46463
		public float DefaultResidueTime;

		// Token: 0x0400B580 RID: 46464
		public float DamageEnergy;

		// Token: 0x0400B581 RID: 46465
		public float DamageHealth;

		// Token: 0x0400B582 RID: 46466
		public float EnergyLoopTime;

		// Token: 0x0400B583 RID: 46467
		public float HealthLoopTime;

		// Token: 0x0400B584 RID: 46468
		public float DamageHealthDehydrated;

		// Token: 0x0400B585 RID: 46469
		public float HealthLoopTimeDehydrated;

		// Token: 0x0400B586 RID: 46470
		public float LifeTimeDehydrated;

		// Token: 0x0400B587 RID: 46471
		public int HealExperience;

		// Token: 0x0400B588 RID: 46472
		public float RemovePrice;

		// Token: 0x0400B589 RID: 46473
		public float EliteVitalityDuration;

		// Token: 0x0400B58A RID: 46474
		public GClass2420.GClass2450 Probability;
	}

	// Token: 0x02002192 RID: 8594
	public class GClass2424
	{
		// Token: 0x0400B58B RID: 46475
		public float DefaultDelay;

		// Token: 0x0400B58C RID: 46476
		public float DefaultResidueTime;

		// Token: 0x0400B58D RID: 46477
		public int HealExperience;

		// Token: 0x0400B58E RID: 46478
		public float RemovePrice;

		// Token: 0x0400B58F RID: 46479
		public GClass2420.GClass2450 FallingProbability;

		// Token: 0x0400B590 RID: 46480
		public GClass2420.GClass2450 BulletHitProbability;
	}

	// Token: 0x02002193 RID: 8595
	public class GClass2425
	{
	}

	// Token: 0x02002194 RID: 8596
	public class GClass2426
	{
	}

	// Token: 0x02002195 RID: 8597
	public class GClass2427
	{
		// Token: 0x0400B591 RID: 46481
		public float DefaultDelay;

		// Token: 0x0400B592 RID: 46482
		public float DefaultResidueTime;

		// Token: 0x0400B593 RID: 46483
		public float Damage;

		// Token: 0x0400B594 RID: 46484
		public float DamageLoopTime;
	}

	// Token: 0x02002196 RID: 8598
	public class GClass2428
	{
		// Token: 0x0400B595 RID: 46485
		public float DefaultDelay;

		// Token: 0x0400B596 RID: 46486
		public float DefaultResidueTime;

		// Token: 0x0400B597 RID: 46487
		public float StartCommonHealth;
	}

	// Token: 0x02002197 RID: 8599
	public class GClass2429
	{
		// Token: 0x0400B598 RID: 46488
		public float Damage;

		// Token: 0x0400B599 RID: 46489
		public float DamageLoopTime;
	}

	// Token: 0x02002198 RID: 8600
	public class GClass2430
	{
	}

	// Token: 0x02002199 RID: 8601
	public class GClass2431
	{
		// Token: 0x0400B59A RID: 46490
		public float DefaultDelay;

		// Token: 0x0400B59B RID: 46491
		public float DefaultResidueTime;

		// Token: 0x0400B59C RID: 46492
		public float DamageHealth;

		// Token: 0x0400B59D RID: 46493
		public float HealthLoopTime;

		// Token: 0x0400B59E RID: 46494
		public int HealExperience;

		// Token: 0x0400B59F RID: 46495
		public float RemovePrice;
	}

	// Token: 0x0200219A RID: 8602
	public class GClass2432
	{
		// Token: 0x0400B5A0 RID: 46496
		public float DefaultDelay;

		// Token: 0x0400B5A1 RID: 46497
		public float DefaultResidueTime;

		// Token: 0x0400B5A2 RID: 46498
		public int HealExperience;

		// Token: 0x0400B5A3 RID: 46499
		public float RemovePrice;
	}

	// Token: 0x0200219B RID: 8603
	public class GClass2433
	{
	}

	// Token: 0x0200219C RID: 8604
	public class GClass2434
	{
		// Token: 0x0400B5A4 RID: 46500
		public float LoopTime;

		// Token: 0x0400B5A5 RID: 46501
		public float MinimumHealthPercentage;

		// Token: 0x0400B5A6 RID: 46502
		public float Energy;

		// Token: 0x0400B5A7 RID: 46503
		public float Hydration;

		// Token: 0x0400B5A8 RID: 46504
		public Dictionary<EBodyPart, GClass2420.GClass2434.GClass2435> BodyHealth;

		// Token: 0x0400B5A9 RID: 46505
		public Dictionary<string, GClass2420.GClass2434.GClass2436> Influences;

		// Token: 0x0200219D RID: 8605
		public class GClass2435
		{
			// Token: 0x0400B5AA RID: 46506
			public float Value;
		}

		// Token: 0x0200219E RID: 8606
		public class GClass2436
		{
			// Token: 0x0400B5AB RID: 46507
			public float HealthSlowDownPercentage;

			// Token: 0x0400B5AC RID: 46508
			public float HydrationSlowDownPercentage;

			// Token: 0x0400B5AD RID: 46509
			public float EnergySlowDownPercentage;
		}
	}

	// Token: 0x0200219F RID: 8607
	public class GClass2437
	{
		// Token: 0x0400B5AE RID: 46510
		public float WorkingTime;

		// Token: 0x0400B5AF RID: 46511
		public float ThresholdMin;

		// Token: 0x0400B5B0 RID: 46512
		public float ThresholdMax;
	}

	// Token: 0x020021A0 RID: 8608
	public class GClass2438
	{
		// Token: 0x0400B5B1 RID: 46513
		public float EnergyRate;

		// Token: 0x0400B5B2 RID: 46514
		public float TicksEvery;

		// Token: 0x0400B5B3 RID: 46515
		public float WorkingTime;

		// Token: 0x0400B5B4 RID: 46516
		public float EnergyRatePerStack;
	}

	// Token: 0x020021A1 RID: 8609
	public class GClass2439
	{
		// Token: 0x0400B5B5 RID: 46517
		public float DefaultDelay;

		// Token: 0x0400B5B6 RID: 46518
		public float WorkingTime;

		// Token: 0x0400B5B7 RID: 46519
		public float DefaultResidueTime;
	}

	// Token: 0x020021A2 RID: 8610
	public class GClass2440
	{
	}

	// Token: 0x020021A3 RID: 8611
	public class GClass2441
	{
		// Token: 0x0400B5B8 RID: 46520
		public float LoopTime;

		// Token: 0x0400B5B9 RID: 46521
		public float StartDelay;

		// Token: 0x0400B5BA RID: 46522
		public float DrinkStartDelay;

		// Token: 0x0400B5BB RID: 46523
		public float FoodStartDelay;

		// Token: 0x0400B5BC RID: 46524
		public float DrugsStartDelay;

		// Token: 0x0400B5BD RID: 46525
		public float MedKitStartDelay;

		// Token: 0x0400B5BE RID: 46526
		public float MedicalStartDelay;

		// Token: 0x0400B5BF RID: 46527
		public float StimulatorStartDelay;
	}

	// Token: 0x020021A4 RID: 8612
	public class GClass2442
	{
		// Token: 0x0400B5C0 RID: 46528
		public float TremorDelay;

		// Token: 0x0400B5C1 RID: 46529
		public int HealExperience;
	}

	// Token: 0x020021A5 RID: 8613
	public class GClass2443
	{
	}

	// Token: 0x020021A6 RID: 8614
	public class GClass2444
	{
	}

	// Token: 0x020021A7 RID: 8615
	public class GClass2445
	{
		// Token: 0x0600B129 RID: 45353 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass2420.GClass2445.GClass2446 GetPersonalBuffSettings(string buffName, int index, SkillManager skills, float strength = 1f)
		{
			throw null;
		}

		// Token: 0x0400B5C2 RID: 46530
		public float BuffLoopTime;

		// Token: 0x0400B5C3 RID: 46531
		public Dictionary<string, GClass2420.GClass2445.GClass2446[]> Buffs;

		// Token: 0x020021A8 RID: 8616
		public class GClass2446 : ICloneable
		{
			// Token: 0x17001DA0 RID: 7584
			// (get) Token: 0x0600B12A RID: 45354 RVA: 0x00002050 File Offset: 0x00000250
			public string BuffName
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600B12B RID: 45355 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public object Clone()
			{
				throw null;
			}

			// Token: 0x17001DA1 RID: 7585
			// (get) Token: 0x0600B12C RID: 45356 RVA: 0x00002050 File Offset: 0x00000250
			public bool IsBuff
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600B12D RID: 45357 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public string GetFullStringValue(string displayName)
			{
				throw null;
			}

			// Token: 0x0600B12E RID: 45358 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public string GetStringValue()
			{
				throw null;
			}

			// Token: 0x0400B5C4 RID: 46532
			public EStimulatorBuffType BuffType;

			// Token: 0x0400B5C5 RID: 46533
			public float Chance;

			// Token: 0x0400B5C6 RID: 46534
			public float Delay;

			// Token: 0x0400B5C7 RID: 46535
			public float Duration;

			// Token: 0x0400B5C8 RID: 46536
			public float Value;

			// Token: 0x0400B5C9 RID: 46537
			public bool AbsoluteValue;

			// Token: 0x0400B5CA RID: 46538
			public string SkillName;

			// Token: 0x0400B5CB RID: 46539
			public GClass2420.GClass2450 Probability;

			// Token: 0x0400B5CC RID: 46540
			public EBodyPart[] AppliesTo;

			// Token: 0x0400B5CD RID: 46541
			private static readonly HashSet<string> hashSet_0;
		}
	}

	// Token: 0x020021A9 RID: 8617
	public class GClass2447
	{
		// Token: 0x0400B5CE RID: 46542
		public float DefaultDelay;

		// Token: 0x0400B5CF RID: 46543
		public float DefaultResidueTime;
	}

	// Token: 0x020021AA RID: 8618
	public class GClass2448
	{
		// Token: 0x0400B5D0 RID: 46544
		public float DefaultBuildUpTime;

		// Token: 0x0400B5D1 RID: 46545
		public float DefaultResidueTime;

		// Token: 0x0400B5D2 RID: 46546
		public float LoopTime;
	}

	// Token: 0x020021AB RID: 8619
	public sealed class GClass2449
	{
		// Token: 0x0400B5D3 RID: 46547
		public float LoopTime;
	}

	// Token: 0x020021AC RID: 8620
	public sealed class GClass2450
	{
		// Token: 0x0600B12F RID: 45359 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Try(float x, float cap, float bias = 0f)
		{
			throw null;
		}

		// Token: 0x0600B130 RID: 45360 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetX(float x)
		{
			throw null;
		}

		// Token: 0x0400B5D4 RID: 46548
		public EProbabilityFunctionType FunctionType;

		// Token: 0x0400B5D5 RID: 46549
		public float K;

		// Token: 0x0400B5D6 RID: 46550
		public float B;

		// Token: 0x0400B5D7 RID: 46551
		public float Threshold;
	}

	// Token: 0x020021AD RID: 8621
	public sealed class GClass2451
	{
		// Token: 0x0400B5D8 RID: 46552
		public float GymEffectivity;

		// Token: 0x0400B5D9 RID: 46553
		public float TraumaChance;
	}
}
