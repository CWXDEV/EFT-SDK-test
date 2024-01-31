using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.InventoryLogic
{
	// Token: 0x020023FD RID: 9213
	public class WeaponTemplate : GClass2529, GInterface285, GInterface286, GInterface299
	{
		// Token: 0x1700209A RID: 8346
		// (get) Token: 0x0600B952 RID: 47442 RVA: 0x00002050 File Offset: 0x00000250
		public string MasteringLocalizationKey
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700209B RID: 8347
		// (get) Token: 0x0600B953 RID: 47443 RVA: 0x00002050 File Offset: 0x00000250
		public AmmoTemplate DefAmmoTemplate
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700209C RID: 8348
		// (get) Token: 0x0600B954 RID: 47444 RVA: 0x00002050 File Offset: 0x00000250
		int GInterface299.Durability
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700209D RID: 8349
		// (get) Token: 0x0600B955 RID: 47445 RVA: 0x00002050 File Offset: 0x00000250
		int GInterface299.MaxDurability
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700209E RID: 8350
		// (get) Token: 0x0600B956 RID: 47446 RVA: 0x00002050 File Offset: 0x00000250
		float GInterface299.MinRepairDegradation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700209F RID: 8351
		// (get) Token: 0x0600B957 RID: 47447 RVA: 0x00002050 File Offset: 0x00000250
		float GInterface299.MaxRepairDegradation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020A0 RID: 8352
		// (get) Token: 0x0600B958 RID: 47448 RVA: 0x00002050 File Offset: 0x00000250
		float GInterface299.MinRepairKitDegradation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020A1 RID: 8353
		// (get) Token: 0x0600B959 RID: 47449 RVA: 0x00002050 File Offset: 0x00000250
		float GInterface299.MaxRepairKitDegradation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020A2 RID: 8354
		// (get) Token: 0x0600B95A RID: 47450 RVA: 0x00002050 File Offset: 0x00000250
		int GInterface286.SizeReduceRight
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020A3 RID: 8355
		// (get) Token: 0x0600B95B RID: 47451 RVA: 0x00002050 File Offset: 0x00000250
		string GInterface286.FoldedSlot
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020A4 RID: 8356
		// (get) Token: 0x0600B95C RID: 47452 RVA: 0x00002050 File Offset: 0x00000250
		Weapon.EFireMode[] GInterface285.AvailablEFireModes
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170020A5 RID: 8357
		// (get) Token: 0x0600B95D RID: 47453 RVA: 0x00002050 File Offset: 0x00000250
		int GInterface285.BurstShotsCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400BC12 RID: 48146
		public const int SINGLE_FIRE_RATE_DEFAULT = 240;

		// Token: 0x0400BC13 RID: 48147
		public const bool CAN_QUEUE_SECOND_SHOT_DEFAULT = true;

		// Token: 0x0400BC14 RID: 48148
		public Weapon.EReloadMode ReloadMode;

		// Token: 0x0400BC15 RID: 48149
		public string weapClass;

		// Token: 0x0400BC16 RID: 48150
		public string weapUseType;

		// Token: 0x0400BC17 RID: 48151
		public string ammoCaliber;

		// Token: 0x0400BC18 RID: 48152
		public bool AdjustCollimatorsToTrajectory;

		// Token: 0x0400BC19 RID: 48153
		public object[] weapAmmoTypes;

		// Token: 0x0400BC1A RID: 48154
		public float Durability;

		// Token: 0x0400BC1B RID: 48155
		public float MaxDurability;

		// Token: 0x0400BC1C RID: 48156
		public float RepairComplexity;

		// Token: 0x0400BC1D RID: 48157
		public float OperatingResource;

		// Token: 0x0400BC1E RID: 48158
		public float RecoilCategoryMultiplierHandRotation;

		// Token: 0x0400BC1F RID: 48159
		public float RecoilReturnSpeedHandRotation;

		// Token: 0x0400BC20 RID: 48160
		public float RecoilDampingHandRotation;

		// Token: 0x0400BC21 RID: 48161
		public float RecoilCamera;

		// Token: 0x0400BC22 RID: 48162
		public int RecoilStableIndexShot;

		// Token: 0x0400BC23 RID: 48163
		public float RecoilForceBack;

		// Token: 0x0400BC24 RID: 48164
		public float RecoilForceUp;

		// Token: 0x0400BC25 RID: 48165
		public int RecolDispersion;

		// Token: 0x0400BC26 RID: 48166
		public float RecoilPosZMult;

		// Token: 0x0400BC27 RID: 48167
		public float RecoilReturnPathDampingHandRotation;

		// Token: 0x0400BC28 RID: 48168
		public float RecoilReturnPathOffsetHandRotation;

		// Token: 0x0400BC29 RID: 48169
		public int RecoilAngle;

		// Token: 0x0400BC2A RID: 48170
		public float RecoilStableAngleIncreaseStep;

		// Token: 0x0400BC2B RID: 48171
		public Vector3 ProgressRecoilAngleOnStable;

		// Token: 0x0400BC2C RID: 48172
		public Vector3 RecoilCenter;

		// Token: 0x0400BC2D RID: 48173
		public Vector2 PostRecoilVerticalRangeHandRotation;

		// Token: 0x0400BC2E RID: 48174
		public Vector2 PostRecoilHorizontalRangeHandRotation;

		// Token: 0x0400BC2F RID: 48175
		public Vector2 CameraToWeaponAngleSpeedRange;

		// Token: 0x0400BC30 RID: 48176
		public float CameraToWeaponAngleStep;

		// Token: 0x0400BC31 RID: 48177
		public ShotsGroupSettings[] ShotsGroupSettings;

		// Token: 0x0400BC32 RID: 48178
		public float CameraSnap;

		// Token: 0x0400BC33 RID: 48179
		public float Ergonomics;

		// Token: 0x0400BC34 RID: 48180
		public float Velocity;

		// Token: 0x0400BC35 RID: 48181
		public int durabSpawnMin;

		// Token: 0x0400BC36 RID: 48182
		public int durabSpawnMax;

		// Token: 0x0400BC37 RID: 48183
		public bool isFastReload;

		// Token: 0x0400BC38 RID: 48184
		public bool isChamberLoad;

		// Token: 0x0400BC39 RID: 48185
		public int ShotgunDispersion;

		// Token: 0x0400BC3A RID: 48186
		public int bFirerate;

		// Token: 0x0400BC3B RID: 48187
		public int SingleFireRate;

		// Token: 0x0400BC3C RID: 48188
		public bool CanQueueSecondShot;

		// Token: 0x0400BC3D RID: 48189
		public int bEffDist;

		// Token: 0x0400BC3E RID: 48190
		public int bHearDist;

		// Token: 0x0400BC3F RID: 48191
		public bool isBoltCatch;

		// Token: 0x0400BC40 RID: 48192
		public string defMagType;

		// Token: 0x0400BC41 RID: 48193
		public string defAmmo;

		// Token: 0x0400BC42 RID: 48194
		public float AimPlane;

		// Token: 0x0400BC43 RID: 48195
		public Slot[] Chambers;

		// Token: 0x0400BC44 RID: 48196
		public float CenterOfImpact;

		// Token: 0x0400BC45 RID: 48197
		public float DoubleActionAccuracyPenalty;

		// Token: 0x0400BC46 RID: 48198
		public float DeviationMax;

		// Token: 0x0400BC47 RID: 48199
		public float DeviationCurve;

		// Token: 0x0400BC48 RID: 48200
		public bool MustBoltBeOpennedForExternalReload;

		// Token: 0x0400BC49 RID: 48201
		public bool MustBoltBeOpennedForInternalReload;

		// Token: 0x0400BC4A RID: 48202
		public bool Foldable;

		// Token: 0x0400BC4B RID: 48203
		public bool Retractable;

		// Token: 0x0400BC4C RID: 48204
		public bool BoltAction;

		// Token: 0x0400BC4D RID: 48205
		public bool ManualBoltCatch;

		// Token: 0x0400BC4E RID: 48206
		public Vector3 TacticalReloadStiffnes;

		// Token: 0x0400BC4F RID: 48207
		public float TacticalReloadFixation;

		// Token: 0x0400BC50 RID: 48208
		public Vector3 RotationCenter;

		// Token: 0x0400BC51 RID: 48209
		public Vector3 RotationCenterNoStock;

		// Token: 0x0400BC52 RID: 48210
		public int IronSightRange;

		// Token: 0x0400BC53 RID: 48211
		public float HipInnaccuracyGain;

		// Token: 0x0400BC54 RID: 48212
		public float HipAccuracyRestorationDelay;

		// Token: 0x0400BC55 RID: 48213
		public float HipAccuracyRestorationSpeed;

		// Token: 0x0400BC56 RID: 48214
		private AmmoTemplate _defAmmoTemplate;

		// Token: 0x0400BC57 RID: 48215
		public bool CompactHandling;

		// Token: 0x0400BC58 RID: 48216
		public float SightingRange;

		// Token: 0x0400BC59 RID: 48217
		public bool AllowJam;

		// Token: 0x0400BC5A RID: 48218
		public bool AllowFeed;

		// Token: 0x0400BC5B RID: 48219
		public bool AllowMisfire;

		// Token: 0x0400BC5C RID: 48220
		public bool AllowSlide;

		// Token: 0x0400BC5D RID: 48221
		public float BaseMalfunctionChance;

		// Token: 0x0400BC5E RID: 48222
		public float AimSensitivity;

		// Token: 0x0400BC5F RID: 48223
		public float DurabilityBurnRatio;

		// Token: 0x0400BC60 RID: 48224
		public float HeatFactorGun;

		// Token: 0x0400BC61 RID: 48225
		public float CoolFactorGun;

		// Token: 0x0400BC62 RID: 48226
		public bool AllowOverheat;

		// Token: 0x0400BC63 RID: 48227
		public float HeatFactorByShot;

		// Token: 0x0400BC64 RID: 48228
		public float CoolFactorGunMods;

		// Token: 0x0400BC65 RID: 48229
		public bool IsFlareGun;

		// Token: 0x0400BC66 RID: 48230
		public bool IsOneoff;

		// Token: 0x0400BC67 RID: 48231
		public bool IsGrenadeLauncher;

		// Token: 0x0400BC68 RID: 48232
		public bool NoFiremodeOnBoltcatch;

		// Token: 0x0400BC69 RID: 48233
		public bool IsStationaryWeapon;

		// Token: 0x0400BC6A RID: 48234
		public bool IsBeltMachineGun;

		// Token: 0x0400BC6B RID: 48235
		public bool BlockLeftStance;

		// Token: 0x0400BC6C RID: 48236
		public bool WithAnimatorAiming;

		// Token: 0x0400BC6D RID: 48237
		public float MinRepairDegradation;

		// Token: 0x0400BC6E RID: 48238
		public float MaxRepairDegradation;

		// Token: 0x0400BC6F RID: 48239
		public int SizeReduceRight;

		// Token: 0x0400BC70 RID: 48240
		public string FoldedSlot;

		// Token: 0x0400BC71 RID: 48241
		public Weapon.EFireMode[] weapFireType;

		// Token: 0x0400BC72 RID: 48242
		public int BurstShotsCount;
	}
}
