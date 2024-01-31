using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Comfort.Common;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.InventoryLogic
{
	// Token: 0x020023FE RID: 9214
	[Serializable]
	public class Weapon : LootItemClass, GInterface320
	{
		// Token: 0x170020A6 RID: 8358
		// (get) Token: 0x0600B95E RID: 47454 RVA: 0x00002050 File Offset: 0x00000250
		public Weapon.EReloadMode ReloadMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020A7 RID: 8359
		// (get) Token: 0x0600B95F RID: 47455 RVA: 0x00002050 File Offset: 0x00000250
		public string WeapClass
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020A8 RID: 8360
		// (get) Token: 0x0600B960 RID: 47456 RVA: 0x00002050 File Offset: 0x00000250
		public Weapon.EFireMode[] WeapFireType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020A9 RID: 8361
		// (get) Token: 0x0600B961 RID: 47457 RVA: 0x00002050 File Offset: 0x00000250
		public float RecoilForceBack
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020AA RID: 8362
		// (get) Token: 0x0600B962 RID: 47458 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsBoltCatch
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020AB RID: 8363
		// (get) Token: 0x0600B963 RID: 47459 RVA: 0x00002050 File Offset: 0x00000250
		public bool MustBoltBeOpennedForExternalReload
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020AC RID: 8364
		// (get) Token: 0x0600B964 RID: 47460 RVA: 0x00002050 File Offset: 0x00000250
		public bool MustBoltBeOpennedForInternalReload
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020AD RID: 8365
		// (get) Token: 0x0600B965 RID: 47461 RVA: 0x00002050 File Offset: 0x00000250
		public bool BoltAction
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020AE RID: 8366
		// (get) Token: 0x0600B966 RID: 47462 RVA: 0x00002050 File Offset: 0x00000250
		public float DoubleActionAccuracyPenalty
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020AF RID: 8367
		// (get) Token: 0x0600B967 RID: 47463 RVA: 0x00002050 File Offset: 0x00000250
		public bool CompactHandling
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020B0 RID: 8368
		// (get) Token: 0x0600B968 RID: 47464 RVA: 0x00002050 File Offset: 0x00000250
		public bool ManualBoltCatch
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020B1 RID: 8369
		// (get) Token: 0x0600B969 RID: 47465 RVA: 0x00002050 File Offset: 0x00000250
		public float SightingRange
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020B2 RID: 8370
		// (get) Token: 0x0600B96A RID: 47466 RVA: 0x00002050 File Offset: 0x00000250
		public int FireRate
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020B3 RID: 8371
		// (get) Token: 0x0600B96B RID: 47467 RVA: 0x00002050 File Offset: 0x00000250
		public bool AllowJam
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020B4 RID: 8372
		// (get) Token: 0x0600B96C RID: 47468 RVA: 0x00002050 File Offset: 0x00000250
		public bool AllowFeed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020B5 RID: 8373
		// (get) Token: 0x0600B96D RID: 47469 RVA: 0x00002050 File Offset: 0x00000250
		public bool AllowMisfire
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020B6 RID: 8374
		// (get) Token: 0x0600B96E RID: 47470 RVA: 0x00002050 File Offset: 0x00000250
		public bool AllowSlide
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020B7 RID: 8375
		// (get) Token: 0x0600B96F RID: 47471 RVA: 0x00002050 File Offset: 0x00000250
		public bool AllowOverheat
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020B8 RID: 8376
		// (get) Token: 0x0600B970 RID: 47472 RVA: 0x00002050 File Offset: 0x00000250
		public bool AllowMalfunction
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020B9 RID: 8377
		// (get) Token: 0x0600B971 RID: 47473 RVA: 0x00002050 File Offset: 0x00000250
		public float BaseMalfunctionChance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020BA RID: 8378
		// (get) Token: 0x0600B972 RID: 47474 RVA: 0x00002050 File Offset: 0x00000250
		public float DurabilityBurnRatio
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020BE RID: 8382
		// (get) Token: 0x0600B973 RID: 47475 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsFlareGun
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020BF RID: 8383
		// (get) Token: 0x0600B974 RID: 47476 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsOneOff
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020C0 RID: 8384
		// (get) Token: 0x0600B975 RID: 47477 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsGrenadeLauncher
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020C1 RID: 8385
		// (get) Token: 0x0600B976 RID: 47478 RVA: 0x00002050 File Offset: 0x00000250
		public bool NoFiremodeOnBoltcatch
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020C2 RID: 8386
		// (get) Token: 0x0600B977 RID: 47479 RVA: 0x00002050 File Offset: 0x00000250
		public string AmmoCaliber
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020C3 RID: 8387
		// (get) Token: 0x0600B978 RID: 47480 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsStationaryWeapon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020C4 RID: 8388
		// (get) Token: 0x0600B979 RID: 47481 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsBeltMachineGun
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020C5 RID: 8389
		// (get) Token: 0x0600B97A RID: 47482 RVA: 0x00002050 File Offset: 0x00000250
		public bool BlockLeftStance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020C6 RID: 8390
		// (get) Token: 0x0600B97B RID: 47483 RVA: 0x00002050 File Offset: 0x00000250
		public bool WithAnimatorAiming
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020C7 RID: 8391
		// (get) Token: 0x0600B97C RID: 47484 RVA: 0x00002050 File Offset: 0x00000250
		public int SingleFireRate
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020C8 RID: 8392
		// (get) Token: 0x0600B97D RID: 47485 RVA: 0x00002050 File Offset: 0x00000250
		public bool CanQueueSecondShot
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020C9 RID: 8393
		// (get) Token: 0x0600B97E RID: 47486 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B97F RID: 47487 RVA: 0x00002050 File Offset: 0x00000250
		public Slot[] Chambers
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

		// Token: 0x170020CA RID: 8394
		// (get) Token: 0x0600B980 RID: 47488 RVA: 0x00002050 File Offset: 0x00000250
		public Slot FirstFreeChamberSlot
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020CB RID: 8395
		// (get) Token: 0x0600B981 RID: 47489 RVA: 0x00002050 File Offset: 0x00000250
		public Slot FirstLoadedChamberSlot
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020CC RID: 8396
		// (get) Token: 0x0600B982 RID: 47490 RVA: 0x00002050 File Offset: 0x00000250
		public Slot[] FreeChambersForLoading
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020CD RID: 8397
		// (get) Token: 0x0600B983 RID: 47491 RVA: 0x00002050 File Offset: 0x00000250
		public int FreeChamberSlotsCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020CE RID: 8398
		// (get) Token: 0x0600B984 RID: 47492 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsMultiBarrel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020CF RID: 8399
		// (get) Token: 0x0600B985 RID: 47493 RVA: 0x00002050 File Offset: 0x00000250
		public bool SupportsInternalReload
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B986 RID: 47494 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FoldableComponent GetFoldable()
		{
			throw null;
		}

		// Token: 0x170020D0 RID: 8400
		// (get) Token: 0x0600B987 RID: 47495 RVA: 0x00002050 File Offset: 0x00000250
		public bool Folded
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020D1 RID: 8401
		// (get) Token: 0x0600B988 RID: 47496 RVA: 0x00002050 File Offset: 0x00000250
		public float DeviationCurve
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020D2 RID: 8402
		// (get) Token: 0x0600B989 RID: 47497 RVA: 0x00002050 File Offset: 0x00000250
		private float Single_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020D3 RID: 8403
		// (get) Token: 0x0600B98A RID: 47498 RVA: 0x00002050 File Offset: 0x00000250
		public float RecoilBase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public float SpeedFactor { get; }

		// Token: 0x170020D4 RID: 8404
		// (get) Token: 0x0600B98B RID: 47499 RVA: 0x00002050 File Offset: 0x00000250
		public float RecoilDelta
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020D5 RID: 8405
		// (get) Token: 0x0600B98C RID: 47500 RVA: 0x00002050 File Offset: 0x00000250
		public float StockRecoilDelta
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020D6 RID: 8406
		// (get) Token: 0x0600B98D RID: 47501 RVA: 0x00002050 File Offset: 0x00000250
		public float RecoilTotal
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020D7 RID: 8407
		// (get) Token: 0x0600B98E RID: 47502 RVA: 0x00002050 File Offset: 0x00000250
		public float ErgonomicsTotal
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020D8 RID: 8408
		// (get) Token: 0x0600B98F RID: 47503 RVA: 0x00002050 File Offset: 0x00000250
		public float ErgonomicsDelta
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B990 RID: 47504 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetSightingRange()
		{
			throw null;
		}

		// Token: 0x170020D9 RID: 8409
		// (get) Token: 0x0600B991 RID: 47505 RVA: 0x00002050 File Offset: 0x00000250
		public int EmptyTacticalSlotCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020DA RID: 8410
		// (get) Token: 0x0600B992 RID: 47506 RVA: 0x00002050 File Offset: 0x00000250
		public bool CanReloadFast
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020DB RID: 8411
		// (get) Token: 0x0600B993 RID: 47507 RVA: 0x00002050 File Offset: 0x00000250
		public bool CanLoadAmmoToChamber
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020DC RID: 8412
		// (get) Token: 0x0600B994 RID: 47508 RVA: 0x00002050 File Offset: 0x00000250
		public float ShotgunDispersionBase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020DD RID: 8413
		// (get) Token: 0x0600B995 RID: 47509 RVA: 0x00002050 File Offset: 0x00000250
		public float TotalShotgunDispersion
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020DE RID: 8414
		// (get) Token: 0x0600B996 RID: 47510 RVA: 0x00002050 File Offset: 0x00000250
		public float CenterOfImpactBase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020DF RID: 8415
		// (get) Token: 0x0600B997 RID: 47511 RVA: 0x00002050 File Offset: 0x00000250
		public float CenterOfImpactDelta
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020E0 RID: 8416
		// (get) Token: 0x0600B998 RID: 47512 RVA: 0x00002050 File Offset: 0x00000250
		public float StockDoubleActionAccuracyPenaltyMult
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B999 RID: 47513 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetTotalCenterOfImpact(bool includeAmmo)
		{
			throw null;
		}

		// Token: 0x170020E1 RID: 8417
		// (get) Token: 0x0600B99A RID: 47514 RVA: 0x00002050 File Offset: 0x00000250
		public float TotalAccuracy
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B99B RID: 47515 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetBarrelDeviation()
		{
			throw null;
		}

		// Token: 0x0600B99C RID: 47516 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_10(float durability)
		{
			throw null;
		}

		// Token: 0x170020E2 RID: 8418
		// (get) Token: 0x0600B99D RID: 47517 RVA: 0x00002050 File Offset: 0x00000250
		public float VelocityBase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020E3 RID: 8419
		// (get) Token: 0x0600B99E RID: 47518 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		public AmmoTemplate CurrentAmmoTemplate
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020E4 RID: 8420
		// (get) Token: 0x0600B99F RID: 47519 RVA: 0x00002050 File Offset: 0x00000250
		public float VelocityDelta
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020E6 RID: 8422
		// (get) Token: 0x0600B9A0 RID: 47520 RVA: 0x00002050 File Offset: 0x00000250
		public float TotalVelocity
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B9A1 RID: 47521 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsModSuitable(Mod mod)
		{
			throw null;
		}

		// Token: 0x170020E7 RID: 8423
		// (get) Token: 0x0600B9A2 RID: 47522 RVA: 0x00002050 File Offset: 0x00000250
		public override IEnumerable<IContainer> Containers
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B9A3 RID: 47523 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Item FindItem(string itemId)
		{
			throw null;
		}

		// Token: 0x0600B9A4 RID: 47524 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IContainer GetContainer(string containerId)
		{
			throw null;
		}

		// Token: 0x170020E8 RID: 8424
		// (get) Token: 0x0600B9A5 RID: 47525 RVA: 0x00002050 File Offset: 0x00000250
		public override IEnumerable<EItemInfoButton> ItemInteractionButtons
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B9A6 RID: 47526 RVA: 0x00002050 File Offset: 0x00000250
		[OnDeserializing]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11(StreamingContext context)
		{
			throw null;
		}

		// Token: 0x170020E9 RID: 8425
		// (get) Token: 0x0600B9A7 RID: 47527 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3[] OpticCalibrationPointsForAll
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B9A8 RID: 47528 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CreateOpticCalibrationPoints(SightComponent sight)
		{
			throw null;
		}

		// Token: 0x0600B9A9 RID: 47529 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RecalculateOpticCalibrationPoints()
		{
			throw null;
		}

		// Token: 0x0600B9AA RID: 47530 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12(SightComponent sight, int scopeIndex)
		{
			throw null;
		}

		// Token: 0x0600B9AB RID: 47531 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3[] CreateOpticCalibrationData(int[] opticCalibrationDistances, AmmoTemplate ammoTemplate, float speedFactor, float deltaTime)
		{
			throw null;
		}

		// Token: 0x0600B9AC RID: 47532 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 CalculateShotDirectionForIron(Vector3 localPosition, float CachedSpeedFactor, int calibrationRange)
		{
			throw null;
		}

		// Token: 0x0600B9AD RID: 47533 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 ZeroLevelPosition(Vector3 direction, Vector3 startPosition, float height, out float time)
		{
			throw null;
		}

		// Token: 0x0600B9AE RID: 47534 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnShot(float ammoBurnRatio, float ammoHeatFactor, float skillWeaponTreatmentFactor, BackendConfigSettingsClass.GClass1368 overheatSettings, float pastTime)
		{
			throw null;
		}

		// Token: 0x0600B9AF RID: 47535 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CanQuickdrawPistolAfterMalf(float pastTime, BackendConfigSettingsClass.GClass1367 malfSettings)
		{
			throw null;
		}

		// Token: 0x0600B9B0 RID: 47536 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetCurrentOverheat(float pastTime, BackendConfigSettingsClass.GClass1368 overheatSettings, out float modsCoolFactor)
		{
			throw null;
		}

		// Token: 0x0600B9B1 RID: 47537 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetCurrentOverheat(float pastTime, BackendConfigSettingsClass.GClass1368 overheatSettings, List<Mod> weaponCurrentMods, out float modsCoolFactor)
		{
			throw null;
		}

		// Token: 0x0600B9B2 RID: 47538 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector2 GetCurrentOverheatBarrelMove(float pastTime, float timeToChangeDir)
		{
			throw null;
		}

		// Token: 0x0600B9B3 RID: 47539 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetDurabilityLossOnShot(float ammoBurnRatio, float overheatFactor, float skillWeaponTreatmentFactor, out float modsBurnRatio)
		{
			throw null;
		}

		// Token: 0x0600B9B4 RID: 47540 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetShotOverheat(float ammoHeatFactor, float globalModHeatFactor, out float modsHeatFactor)
		{
			throw null;
		}

		// Token: 0x0600B9B5 RID: 47541 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ValidateMalfunction(Weapon.EMalfunctionState malfState)
		{
			throw null;
		}

		// Token: 0x170020EA RID: 8426
		// (get) Token: 0x0600B9B6 RID: 47542 RVA: 0x00002050 File Offset: 0x00000250
		float GInterface320.Weight
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020EB RID: 8427
		// (get) Token: 0x0600B9B7 RID: 47543 RVA: 0x00002050 File Offset: 0x00000250
		float GInterface320.RecoilForceBack
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020EC RID: 8428
		// (get) Token: 0x0600B9B8 RID: 47544 RVA: 0x00002050 File Offset: 0x00000250
		float GInterface320.RecoilBase
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020ED RID: 8429
		// (get) Token: 0x0600B9B9 RID: 47545 RVA: 0x00002050 File Offset: 0x00000250
		float GInterface320.RecoilDelta
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020EF RID: 8431
		// (get) Token: 0x0600B9BA RID: 47546 RVA: 0x00002050 File Offset: 0x00000250
		bool GInterface320.IsUnderbarrelWeapon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020F0 RID: 8432
		// (get) Token: 0x0600B9BB RID: 47547 RVA: 0x00002050 File Offset: 0x00000250
		Weapon.GClass2738 GInterface320.MalfState
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020F1 RID: 8433
		// (get) Token: 0x0600B9BC RID: 47548 RVA: 0x00002050 File Offset: 0x00000250
		Item GInterface320.Item
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020F2 RID: 8434
		// (get) Token: 0x0600B9BD RID: 47549 RVA: 0x00002050 File Offset: 0x00000250
		WeaponTemplate GInterface320.WeaponTemplate
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B9BE RID: 47550 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		int GInterface320.GetCurrentMagazineCount()
		{
			throw null;
		}

		// Token: 0x170020F3 RID: 8435
		// (get) Token: 0x0600B9BF RID: 47551 RVA: 0x00002050 File Offset: 0x00000250
		public new WeaponTemplate Template
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020F4 RID: 8436
		// (get) Token: 0x0600B9C0 RID: 47552 RVA: 0x00002050 File Offset: 0x00000250
		public Weapon.EFireMode SelectedFireMode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020F5 RID: 8437
		// (get) Token: 0x0600B9C1 RID: 47553 RVA: 0x00002050 File Offset: 0x00000250
		public bool HasChambers
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020F6 RID: 8438
		// (get) Token: 0x0600B9C2 RID: 47554 RVA: 0x00002050 File Offset: 0x00000250
		public int ChamberAmmoCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020F7 RID: 8439
		// (get) Token: 0x0600B9C3 RID: 47555 RVA: 0x00002050 File Offset: 0x00000250
		public int ShellsInWeaponCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020F8 RID: 8440
		// (get) Token: 0x0600B9C4 RID: 47556 RVA: 0x00002050 File Offset: 0x00000250
		public int ShellsInChamberCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B9C5 RID: 47557 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashSum()
		{
			throw null;
		}

		// Token: 0x170020F9 RID: 8441
		// (get) Token: 0x0600B9C6 RID: 47558 RVA: 0x00002050 File Offset: 0x00000250
		public IEnumerable<Mod> Mods
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B9C7 RID: 47559 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetModsHashSumWithoutMag()
		{
			throw null;
		}

		// Token: 0x0600B9C8 RID: 47560 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public T GetFirstOrDefaultMod<T>()
		{
			throw null;
		}

		// Token: 0x170020FA RID: 8442
		// (get) Token: 0x0600B9C9 RID: 47561 RVA: 0x00002050 File Offset: 0x00000250
		public override IEnumerable<Slot> AllSlots
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x14000292 RID: 658
		// (add) Token: 0x0600B9CA RID: 47562 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600B9CB RID: 47563 RVA: 0x00002050 File Offset: 0x00000250
		public event Func<Weapon.EMalfunctionState, bool> OnMalfunctionValidate
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x170020FB RID: 8443
		// (get) Token: 0x0600B9CC RID: 47564 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600B9CD RID: 47565 RVA: 0x00002050 File Offset: 0x00000250
		public AmmoTemplate[] ShellsInChambers
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

		// Token: 0x0600B9CE RID: 47566 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetShellsIndexes(List<int> shellsIndexes)
		{
			throw null;
		}

		// Token: 0x0600B9CF RID: 47567 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetShellsInWeaponCount()
		{
			throw null;
		}

		// Token: 0x170020FC RID: 8444
		// (get) Token: 0x0600B9D0 RID: 47568 RVA: 0x00002050 File Offset: 0x00000250
		public bool HasShellsInChamberBarrelOnlyWeapon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600B9D1 RID: 47569 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Slot GetMagazineSlot()
		{
			throw null;
		}

		// Token: 0x0600B9D2 RID: 47570 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool HasMagazineWithBelt()
		{
			throw null;
		}

		// Token: 0x0600B9D3 RID: 47571 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override MagazineClass GetCurrentMagazine()
		{
			throw null;
		}

		// Token: 0x0600B9D4 RID: 47572 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetCurrentMagazineCount()
		{
			throw null;
		}

		// Token: 0x0600B9D5 RID: 47573 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetMaxMagazineCount()
		{
			throw null;
		}

		// Token: 0x0600B9D6 RID: 47574 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass2664 GetUnderbarrelWeapon()
		{
			throw null;
		}

		// Token: 0x0600B9D7 RID: 47575 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Slot GetLauncherSlot()
		{
			throw null;
		}

		// Token: 0x0600B9D8 RID: 47576 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override GStruct412 Apply([NotNull] TraderControllerClass itemController, [NotNull] Item item, int count, bool simulate)
		{
			throw null;
		}

		// Token: 0x0600B9D9 RID: 47577 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Slot method_13(Slot x)
		{
			throw null;
		}

		// Token: 0x0600B9DA RID: 47578 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_14()
		{
			throw null;
		}

		// Token: 0x0600B9DB RID: 47579 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_15()
		{
			throw null;
		}

		// Token: 0x0600B9DC RID: 47580 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string method_16()
		{
			throw null;
		}

		// Token: 0x0600B9DD RID: 47581 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_17()
		{
			throw null;
		}

		// Token: 0x0600B9DE RID: 47582 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_18()
		{
			throw null;
		}

		// Token: 0x0600B9DF RID: 47583 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string method_19()
		{
			throw null;
		}

		// Token: 0x0600B9E0 RID: 47584 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_20()
		{
			throw null;
		}

		// Token: 0x0600B9E1 RID: 47585 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string method_21()
		{
			throw null;
		}

		// Token: 0x0600B9E2 RID: 47586 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_22()
		{
			throw null;
		}

		// Token: 0x0600B9E3 RID: 47587 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_23()
		{
			throw null;
		}

		// Token: 0x0600B9E4 RID: 47588 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string method_24()
		{
			throw null;
		}

		// Token: 0x0600B9E5 RID: 47589 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_25()
		{
			throw null;
		}

		// Token: 0x0600B9E6 RID: 47590 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_26()
		{
			throw null;
		}

		// Token: 0x0600B9E7 RID: 47591 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string method_27()
		{
			throw null;
		}

		// Token: 0x0600B9E8 RID: 47592 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_28()
		{
			throw null;
		}

		// Token: 0x0600B9E9 RID: 47593 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_29()
		{
			throw null;
		}

		// Token: 0x0600B9EA RID: 47594 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string method_30()
		{
			throw null;
		}

		// Token: 0x0600B9EB RID: 47595 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_31()
		{
			throw null;
		}

		// Token: 0x0600B9EC RID: 47596 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string method_32()
		{
			throw null;
		}

		// Token: 0x0600B9ED RID: 47597 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_33()
		{
			throw null;
		}

		// Token: 0x0600B9EE RID: 47598 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string method_34()
		{
			throw null;
		}

		// Token: 0x0600B9EF RID: 47599 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_35()
		{
			throw null;
		}

		// Token: 0x0600B9F0 RID: 47600 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string method_36()
		{
			throw null;
		}

		// Token: 0x0600B9F1 RID: 47601 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_37()
		{
			throw null;
		}

		// Token: 0x0600B9F2 RID: 47602 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string method_38()
		{
			throw null;
		}

		// Token: 0x0600B9F3 RID: 47603 RVA: 0x00002050 File Offset: 0x00000250
		[DebuggerHidden]
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerable<IContainer> method_39()
		{
			throw null;
		}

		// Token: 0x0600B9F4 RID: 47604 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static IResult smethod_1(GClass2763 slotItemAddress, ref Weapon.Struct738 struct738_0)
		{
			throw null;
		}

		// Token: 0x0400BC73 RID: 48243
		public const string WEAPON_CLASS_PISTOL = "pistol";

		// Token: 0x0400BC74 RID: 48244
		public const float MOA_ON_100_METERS = 2.9089f;

		// Token: 0x0400BC75 RID: 48245
		private const float ERGONOMICS_MIN = 0f;

		// Token: 0x0400BC76 RID: 48246
		private const float ERGONOMICS_MAX = 100f;

		// Token: 0x0400BC77 RID: 48247
		public readonly RepairableComponent Repairable;

		// Token: 0x0400BC78 RID: 48248
		public readonly FoldableComponent Foldable;

		// Token: 0x0400BC79 RID: 48249
		public readonly FireModeComponent FireMode;

		// Token: 0x0400BC7A RID: 48250
		public BuffComponent Buff;

		// Token: 0x0400BC7C RID: 48252
		private static readonly IEnumerable<EItemInfoButton> _weaponInteractions;

		// Token: 0x0400BC7D RID: 48253
		private Vector3[] _opticCalibrationPoints;

		// Token: 0x0400BC7E RID: 48254
		private GClass2989 _opticTrajectoryInfosForAGS;

		// Token: 0x0400BC7F RID: 48255
		public const float OVERHEAT_PROBLEMS_START = 100f;

		// Token: 0x0400BC80 RID: 48256
		private static List<Mod> _preallocatedMods;

		// Token: 0x0400BC81 RID: 48257
		public readonly Weapon.GClass2738 MalfState;

		// Token: 0x0400BC82 RID: 48258
		private Slot _magSlotCache;

		// Token: 0x0400BC83 RID: 48259
		private int _lastModsCalculateFrame;

		// Token: 0x0400BC84 RID: 48260
		private IEnumerable<Mod> _mods;

		// Token: 0x0400BC85 RID: 48261
		public BindableState<int> AimIndex;

		// Token: 0x0400BC86 RID: 48262
		public bool CompatibleAmmo;

		// Token: 0x0400BC87 RID: 48263
		public bool Armed;

		// Token: 0x0400BC88 RID: 48264
		public bool IsUnderBarrelDeviceActive;

		// Token: 0x0400BC8A RID: 48266
		public bool CylinderHammerClosed;

		// Token: 0x0400BC8B RID: 48267
		private AmmoTemplate[] _shellsInChambers;

		// Token: 0x020023FF RID: 9215
		public enum EMalfunctionState
		{
			// Token: 0x0400BC8D RID: 48269
			None,
			// Token: 0x0400BC8E RID: 48270
			Misfire,
			// Token: 0x0400BC8F RID: 48271
			Jam,
			// Token: 0x0400BC90 RID: 48272
			HardSlide,
			// Token: 0x0400BC91 RID: 48273
			SoftSlide,
			// Token: 0x0400BC92 RID: 48274
			Feed
		}

		// Token: 0x02002400 RID: 9216
		[Flags]
		public enum EMalfunctionSource
		{
			// Token: 0x0400BC94 RID: 48276
			Durability = 0,
			// Token: 0x0400BC95 RID: 48277
			Ammo = 1,
			// Token: 0x0400BC96 RID: 48278
			Magazine = 2,
			// Token: 0x0400BC97 RID: 48279
			Overheat = 4,
			// Token: 0x0400BC98 RID: 48280
			ConsoleCommand = 8,
			// Token: 0x0400BC99 RID: 48281
			Effect = 16
		}

		// Token: 0x02002401 RID: 9217
		public class GClass2738
		{
			// Token: 0x14000293 RID: 659
			// (add) Token: 0x0600B9F5 RID: 47605 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x0600B9F6 RID: 47606 RVA: 0x00002050 File Offset: 0x00000250
			public event Action OnStateChanged
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				add
				{
					throw null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				remove
				{
					throw null;
				}
			}

			// Token: 0x170020FD RID: 8445
			// (get) Token: 0x0600B9F7 RID: 47607 RVA: 0x00002050 File Offset: 0x00000250
			public IEnumerable<string> PlayersWhoKnowAboutMalfunction
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170020FE RID: 8446
			// (get) Token: 0x0600B9F8 RID: 47608 RVA: 0x00002050 File Offset: 0x00000250
			public IEnumerable<string> PlayersWhoKnowMalfType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170020FF RID: 8447
			// (get) Token: 0x0600B9F9 RID: 47609 RVA: 0x00002050 File Offset: 0x00000250
			public IDictionary<string, Weapon.EMalfunctionSource> PlayersReducedMalfChances
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002100 RID: 8448
			// (get) Token: 0x0600B9FA RID: 47610 RVA: 0x00002050 File Offset: 0x00000250
			public bool IsAnyMalfExceptMisfire
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002101 RID: 8449
			// (get) Token: 0x0600B9FB RID: 47611 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600B9FC RID: 47612 RVA: 0x00002050 File Offset: 0x00000250
			public Weapon.EMalfunctionState State
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

			// Token: 0x17002102 RID: 8450
			// (get) Token: 0x0600B9FD RID: 47613 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600B9FE RID: 47614 RVA: 0x00002050 File Offset: 0x00000250
			public Weapon.EMalfunctionSource Source
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

			// Token: 0x0600B9FF RID: 47615 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void ChangeStateSilent(Weapon.EMalfunctionState state)
			{
				throw null;
			}

			// Token: 0x0600BA00 RID: 47616 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsKnownMalfunction(string profileId)
			{
				throw null;
			}

			// Token: 0x0600BA01 RID: 47617 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsKnownMalfType(string profileId)
			{
				throw null;
			}

			// Token: 0x0600BA02 RID: 47618 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void AddPlayerWhoKnowMalfunction(string playerId, bool clearRest = false)
			{
				throw null;
			}

			// Token: 0x0600BA03 RID: 47619 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void AddPlayerWhoKnowMalfType(string playerId)
			{
				throw null;
			}

			// Token: 0x0600BA04 RID: 47620 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void ClearPlayersWhoKnow()
			{
				throw null;
			}

			// Token: 0x0600BA05 RID: 47621 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Repair()
			{
				throw null;
			}

			// Token: 0x0600BA06 RID: 47622 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool HasMalfReduceChance(string profileId, Weapon.EMalfunctionSource malfSource)
			{
				throw null;
			}

			// Token: 0x0600BA07 RID: 47623 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void AddMalfReduceChance(string profileId, Weapon.EMalfunctionSource malfSource)
			{
				throw null;
			}

			// Token: 0x0600BA08 RID: 47624 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void CopyFrom(GClass1491 descriptor, ItemFactory itemFactory)
			{
				throw null;
			}

			// Token: 0x0400BC9A RID: 48282
			[CompilerGenerated]
			private Action action_0;

			// Token: 0x0400BC9B RID: 48283
			public BulletClass AmmoToFire;

			// Token: 0x0400BC9C RID: 48284
			public BulletClass AmmoWillBeLoadedToChamber;

			// Token: 0x0400BC9D RID: 48285
			public BulletClass MalfunctionedAmmo;

			// Token: 0x0400BC9E RID: 48286
			public float LastShotOverheat;

			// Token: 0x0400BC9F RID: 48287
			public float LastShotTime;

			// Token: 0x0400BCA0 RID: 48288
			public float LastMalfunctionTime;

			// Token: 0x0400BCA1 RID: 48289
			public float OverheatBarrelMoveMult;

			// Token: 0x0400BCA2 RID: 48290
			public Vector2 OverheatBarrelMoveDir;

			// Token: 0x0400BCA3 RID: 48291
			public float OverheatFirerateMult;

			// Token: 0x0400BCA4 RID: 48292
			public bool OverheatFirerateMultInited;

			// Token: 0x0400BCA5 RID: 48293
			public bool SlideOnOverheatReached;

			// Token: 0x0400BCA6 RID: 48294
			public bool AutoshotChanceInited;

			// Token: 0x0400BCA7 RID: 48295
			public float AutoshotTime;

			// Token: 0x0400BCA8 RID: 48296
			private Weapon.EMalfunctionState emalfunctionState_0;

			// Token: 0x0400BCA9 RID: 48297
			private readonly List<string> list_0;

			// Token: 0x0400BCAA RID: 48298
			private readonly List<string> list_1;

			// Token: 0x0400BCAB RID: 48299
			private readonly Dictionary<string, Weapon.EMalfunctionSource> dictionary_0;

			// Token: 0x0400BCAC RID: 48300
			[CompilerGenerated]
			private Weapon.EMalfunctionSource emalfunctionSource_0;
		}

		// Token: 0x02002402 RID: 9218
		[Flags]
		public enum EFireMode : byte
		{
			// Token: 0x0400BCAE RID: 48302
			fullauto = 0,
			// Token: 0x0400BCAF RID: 48303
			single = 1,
			// Token: 0x0400BCB0 RID: 48304
			doublet = 2,
			// Token: 0x0400BCB1 RID: 48305
			burst = 3,
			// Token: 0x0400BCB2 RID: 48306
			doubleaction = 4,
			// Token: 0x0400BCB3 RID: 48307
			semiauto = 5
		}

		// Token: 0x02002403 RID: 9219
		public enum EReloadMode
		{
			// Token: 0x0400BCB5 RID: 48309
			ExternalMagazine,
			// Token: 0x0400BCB6 RID: 48310
			InternalMagazine,
			// Token: 0x0400BCB7 RID: 48311
			OnlyBarrel,
			// Token: 0x0400BCB8 RID: 48312
			ExternalMagazineWithInternalReloadSupport
		}

		// Token: 0x02002404 RID: 9220
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2042
		{
			// Token: 0x0600BA09 RID: 47625 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EItemAttributeDisplayType method_0()
			{
				throw null;
			}

			// Token: 0x0600BA0A RID: 47626 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EItemAttributeDisplayType method_1()
			{
				throw null;
			}

			// Token: 0x0600BA0B RID: 47627 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EItemAttributeDisplayType method_2()
			{
				throw null;
			}

			// Token: 0x0600BA0C RID: 47628 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EItemAttributeDisplayType method_3()
			{
				throw null;
			}

			// Token: 0x0600BA0D RID: 47629 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EItemAttributeDisplayType method_4()
			{
				throw null;
			}

			// Token: 0x0600BA0E RID: 47630 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EItemAttributeDisplayType method_5()
			{
				throw null;
			}

			// Token: 0x0600BA0F RID: 47631 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EItemAttributeDisplayType method_6()
			{
				throw null;
			}

			// Token: 0x0600BA10 RID: 47632 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EItemAttributeDisplayType method_7()
			{
				throw null;
			}

			// Token: 0x0600BA11 RID: 47633 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EItemAttributeDisplayType method_8()
			{
				throw null;
			}

			// Token: 0x0600BA12 RID: 47634 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EItemAttributeDisplayType method_9()
			{
				throw null;
			}

			// Token: 0x0600BA13 RID: 47635 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_10(Mod mod)
			{
				throw null;
			}

			// Token: 0x0600BA14 RID: 47636 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_11(Mod mod)
			{
				throw null;
			}

			// Token: 0x0600BA15 RID: 47637 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_12(Mod mod)
			{
				throw null;
			}

			// Token: 0x0600BA16 RID: 47638 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_13(Mod mod)
			{
				throw null;
			}

			// Token: 0x0600BA17 RID: 47639 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_14(Mod mod)
			{
				throw null;
			}

			// Token: 0x0600BA18 RID: 47640 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_15(Mod mod)
			{
				throw null;
			}

			// Token: 0x0600BA19 RID: 47641 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_16(Mod x)
			{
				throw null;
			}

			// Token: 0x0600BA1A RID: 47642 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_17(Slot x)
			{
				throw null;
			}

			// Token: 0x0600BA1B RID: 47643 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_18(Slot x)
			{
				throw null;
			}

			// Token: 0x0600BA1C RID: 47644 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_19(Mod mod)
			{
				throw null;
			}

			// Token: 0x0600BA1D RID: 47645 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_20(Mod mod)
			{
				throw null;
			}

			// Token: 0x0600BA1E RID: 47646 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_21(Mod mod)
			{
				throw null;
			}

			// Token: 0x0600BA1F RID: 47647 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_22(Slot x)
			{
				throw null;
			}

			// Token: 0x0600BA20 RID: 47648 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Item method_23(Slot slot)
			{
				throw null;
			}

			// Token: 0x0600BA21 RID: 47649 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_24(Slot x)
			{
				throw null;
			}

			// Token: 0x0600BA22 RID: 47650 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_25(Slot slot)
			{
				throw null;
			}

			// Token: 0x0600BA23 RID: 47651 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_26(Slot slot)
			{
				throw null;
			}

			// Token: 0x0400BCB9 RID: 48313
			public static readonly Weapon.Class2042 class2042_0;

			// Token: 0x0400BCBA RID: 48314
			public static Func<EItemAttributeDisplayType> func_0;

			// Token: 0x0400BCBB RID: 48315
			public static Func<EItemAttributeDisplayType> func_1;

			// Token: 0x0400BCBC RID: 48316
			public static Func<EItemAttributeDisplayType> func_2;

			// Token: 0x0400BCBD RID: 48317
			public static Func<EItemAttributeDisplayType> func_3;

			// Token: 0x0400BCBE RID: 48318
			public static Func<EItemAttributeDisplayType> func_4;

			// Token: 0x0400BCBF RID: 48319
			public static Func<EItemAttributeDisplayType> func_5;

			// Token: 0x0400BCC0 RID: 48320
			public static Func<EItemAttributeDisplayType> func_6;

			// Token: 0x0400BCC1 RID: 48321
			public static Func<EItemAttributeDisplayType> func_7;

			// Token: 0x0400BCC2 RID: 48322
			public static Func<EItemAttributeDisplayType> func_8;

			// Token: 0x0400BCC3 RID: 48323
			public static Func<EItemAttributeDisplayType> func_9;

			// Token: 0x0400BCC4 RID: 48324
			public static Func<Mod, bool> func_10;

			// Token: 0x0400BCC5 RID: 48325
			public static Func<Mod, float> func_11;

			// Token: 0x0400BCC6 RID: 48326
			public static Func<Mod, float> func_12;

			// Token: 0x0400BCC7 RID: 48327
			public static Func<Mod, bool> func_13;

			// Token: 0x0400BCC8 RID: 48328
			public static Func<Mod, float> func_14;

			// Token: 0x0400BCC9 RID: 48329
			public static Func<Mod, float> func_15;

			// Token: 0x0400BCCA RID: 48330
			public static Func<Mod, float> func_16;

			// Token: 0x0400BCCB RID: 48331
			public static Func<Slot, bool> func_17;

			// Token: 0x0400BCCC RID: 48332
			public static Func<Slot, bool> func_18;

			// Token: 0x0400BCCD RID: 48333
			public static Func<Mod, int> func_19;

			// Token: 0x0400BCCE RID: 48334
			public static Func<Mod, bool> func_20;

			// Token: 0x0400BCCF RID: 48335
			public static Func<Mod, float> func_21;

			// Token: 0x0400BCD0 RID: 48336
			public static Func<Slot, bool> func_22;

			// Token: 0x0400BCD1 RID: 48337
			public static Func<Slot, Item> func_23;

			// Token: 0x0400BCD2 RID: 48338
			public static Predicate<Slot> predicate_0;

			// Token: 0x0400BCD3 RID: 48339
			public static Func<Slot, bool> func_24;

			// Token: 0x0400BCD4 RID: 48340
			public static Func<Slot, bool> func_25;
		}

		// Token: 0x02002406 RID: 9222
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		public struct Struct738
		{
			// Token: 0x0400BCDC RID: 48348
			public TraderControllerClass itemController;
		}
	}
}
