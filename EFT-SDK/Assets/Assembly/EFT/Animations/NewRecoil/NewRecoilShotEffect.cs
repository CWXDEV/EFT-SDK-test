using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.Animations.Recoil;
using EFT.InventoryLogic;
using UnityEngine;

namespace EFT.Animations.NewRecoil
{
	// Token: 0x02001F12 RID: 7954
	[Serializable]
	public class NewRecoilShotEffect : IRecoilShotEffect
	{
		// Token: 0x17001AFE RID: 6910
		// (get) Token: 0x0600A488 RID: 42120 RVA: 0x00002050 File Offset: 0x00000250
		public RotationRecoilProcessBase HandRotationRecoilEffect
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001AFF RID: 6911
		// (get) Token: 0x0600A489 RID: 42121 RVA: 0x00002050 File Offset: 0x00000250
		public RecoilProcessBase HandPositionRecoilEffect
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001B00 RID: 6912
		// (get) Token: 0x0600A48A RID: 42122 RVA: 0x00002050 File Offset: 0x00000250
		public RecoilProcessBase CameraRotationRecoilEffect
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Vector3 SeparateIntensityFactors { get; set; }

		// Token: 0x17001B01 RID: 6913
		// (get) Token: 0x0600A48B RID: 42123 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A48C RID: 42124 RVA: 0x00002050 File Offset: 0x00000250
		public ShotEffector.RecoilShotVal[] RecoilProcessValues
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

		// Token: 0x17001B02 RID: 6914
		// (get) Token: 0x0600A48D RID: 42125 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A48E RID: 42126 RVA: 0x00002050 File Offset: 0x00000250
		public Vector2 RecoilRotationStrength
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

		// Token: 0x17001B04 RID: 6916
		// (get) Token: 0x0600A48F RID: 42127 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A490 RID: 42128 RVA: 0x00002050 File Offset: 0x00000250
		public Vector2 DegreeRecoil
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

		// Token: 0x17001B05 RID: 6917
		// (get) Token: 0x0600A491 RID: 42129 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A492 RID: 42130 RVA: 0x00002050 File Offset: 0x00000250
		public Vector2 RecoilRadian
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

		// Token: 0x0600A493 RID: 42131 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FixedUpdate(float deltaTime)
		{
			throw null;
		}

		// Token: 0x0600A494 RID: 42132 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddRecoilForce(float incomingForce)
		{
			throw null;
		}

		// Token: 0x0600A495 RID: 42133 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_0()
		{
			throw null;
		}

		// Token: 0x0600A496 RID: 42134 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(Vector2 finalRecoilRadian, float rotationRecoilPower, float positionRecoilPower)
		{
			throw null;
		}

		// Token: 0x0600A497 RID: 42135 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(float incomingForce, out float rotationRecoilPower, out float positionRecoilPower)
		{
			throw null;
		}

		// Token: 0x0600A498 RID: 42136 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(out Vector2 recoilRadian)
		{
			throw null;
		}

		// Token: 0x0600A499 RID: 42137 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CalculateBaseRecoilParameters(float recoilSuspensionY, float weaponRecoilAngle, float weaponRecoilDispersion, List<ShotsGroupSettings> shotsGroupSettingsList)
		{
			throw null;
		}

		// Token: 0x0600A49A RID: 42138 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RecalculateRecoilParamsOnChangeWeapon(WeaponTemplate template, BackendConfigSettingsClass.AimingConfiguration AimingConfig, Player.FirearmController firearmController, float recoilSuppressionX, float recoilSuppressionY, float recoilSuppressionFactor, float modsFactorRecoil)
		{
			throw null;
		}

		// Token: 0x0600A49B RID: 42139 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600A49C RID: 42140 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600A49D RID: 42141 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetHandRotationRecoil()
		{
			throw null;
		}

		// Token: 0x0600A49E RID: 42142 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetHandPositionRecoil()
		{
			throw null;
		}

		// Token: 0x0600A49F RID: 42143 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetCameraRotationRecoil()
		{
			throw null;
		}

		// Token: 0x0400AC5C RID: 44124
		[Tooltip("Влияние внешних пассивных еффектов смещения, напр Эффект Дыхания")]
		public bool UseOffset;

		// Token: 0x0400AC5D RID: 44125
		[Tooltip("Задействовать отдачу")]
		public bool RecoilEffectOn;

		// Token: 0x0400AC5E RID: 44126
		public bool ProgressPowerOn;

		// Token: 0x0400AC5F RID: 44127
		[Tooltip("С какого выстрела по счету начинаеться прогрессирование силы выстрела до полной")]
		public int ProgressPowerShot;

		// Token: 0x0400AC60 RID: 44128
		[Tooltip("Мультипликатор  входящих параметров разброса вращения")]
		public float IncomingRotationStrengthMultiplier;

		// Token: 0x0400AC61 RID: 44129
		[Tooltip("Настройки влияния на оси вращения смещения во время выстрела, здесь можно усилить ослабить кажду ось.")]
		public ShotEffector.RecoilShotVal[] ShotRecoilProcessValues;

		// Token: 0x0400AC62 RID: 44130
		[Tooltip("Настройки групп выстрелов, если один и тот же выстрел попадает в разные группы, то значения из этих групп суммируются при расчетах. Приходит из таксы")]
		public List<ShotsGroupSettings> ShotsGroupsSettings;

		// Token: 0x0400AC63 RID: 44131
		[Tooltip("Базовый расброс силы вращения, все расчеты ведутся от нее")]
		public Vector2 BasicRecoilRotationStrengthRange;

		// Token: 0x0400AC64 RID: 44132
		[Tooltip("Базовый расброс силы смещения позиции, все расчеты ведутся от нее")]
		public Vector2 BasicRecoilPositionStrengthRange;

		// Token: 0x0400AC65 RID: 44133
		[Tooltip("Номер выстрела стабилизации во время автоматического огня")]
		public int RecoilStableShotIndex;

		// Token: 0x0400AC66 RID: 44134
		public NewRotationRecoilProcess HandRotationRecoil;

		// Token: 0x0400AC67 RID: 44135
		public RecoilProcessBase HandPositionRecoil;

		// Token: 0x0400AC68 RID: 44136
		public RecoilProcessBase CameraRotationRecoil;

		// Token: 0x0400AC69 RID: 44137
		[HideInInspector]
		public Vector2 BasicPlayerRecoilRotationStrength;

		// Token: 0x0400AC6A RID: 44138
		[HideInInspector]
		public Vector2 BasicPlayerRecoilPositionStrength;

		// Token: 0x0400AC6B RID: 44139
		[HideInInspector]
		public Vector2 BasicPlayerRecoilDegreeRange;

		// Token: 0x0400AC6C RID: 44140
		[HideInInspector]
		public Vector3 RecoilDirection;

		// Token: 0x0400AC6D RID: 44141
		[HideInInspector]
		public Vector2 BasicRecoilRadian;

		// Token: 0x0400AC6E RID: 44142
		[HideInInspector]
		public Vector3 IntensitySeparateFactors;

		// Token: 0x0400AC6F RID: 44143
		[HideInInspector]
		public Vector2 OverheatBarrelMove;

		// Token: 0x0400AC70 RID: 44144
		[HideInInspector]
		public float BarrelMoveMult;

		// Token: 0x0400AC71 RID: 44145
		private Player.FirearmController _firearmController;

		// Token: 0x0400AC72 RID: 44146
		private int _autoFireShotIndex;

		// Token: 0x0400AC73 RID: 44147
		private bool _autoFireOn;
	}
}
