using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.Animations.Recoil;
using EFT.InventoryLogic;
using UnityEngine;

namespace EFT.Animations
{
	// Token: 0x02001EF9 RID: 7929
	[Serializable]
	public class OldRecoilShotEffect : IRecoilShotEffect
	{
		// Token: 0x17001ACE RID: 6862
		// (get) Token: 0x0600A3BB RID: 41915 RVA: 0x00002050 File Offset: 0x00000250
		public RotationRecoilProcessBase HandRotationRecoilEffect
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001ACF RID: 6863
		// (get) Token: 0x0600A3BC RID: 41916 RVA: 0x00002050 File Offset: 0x00000250
		public RecoilProcessBase HandPositionRecoilEffect
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001AD0 RID: 6864
		// (get) Token: 0x0600A3BD RID: 41917 RVA: 0x00002050 File Offset: 0x00000250
		public RecoilProcessBase CameraRotationRecoilEffect
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Vector3 SeparateIntensityFactors { get; set; }

		// Token: 0x17001AD1 RID: 6865
		// (get) Token: 0x0600A3BE RID: 41918 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A3BF RID: 41919 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x17001AD2 RID: 6866
		// (get) Token: 0x0600A3C0 RID: 41920 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A3C1 RID: 41921 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x17001AD4 RID: 6868
		// (get) Token: 0x0600A3C2 RID: 41922 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A3C3 RID: 41923 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x17001AD5 RID: 6869
		// (get) Token: 0x0600A3C4 RID: 41924 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A3C5 RID: 41925 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x0600A3C6 RID: 41926 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FixedUpdate(float deltaTime)
		{
			throw null;
		}

		// Token: 0x0600A3C7 RID: 41927 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddRecoilForce(float incomingForce)
		{
			throw null;
		}

		// Token: 0x0600A3C8 RID: 41928 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CalculateBaseRecoilParameters(float recoilSuspensionY, float weaponRecoilAngle, float weaponRecoilDispersion, List<ShotsGroupSettings> shotsGroupSettingsList)
		{
			throw null;
		}

		// Token: 0x0600A3C9 RID: 41929 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RecalculateRecoilParamsOnChangeWeapon(WeaponTemplate template, BackendConfigSettingsClass.AimingConfiguration AimingConfig, Player.FirearmController firearmController, float recoilSuppressionX, float recoilSuppressionY, float recoilSuppressionFactor, float modsFactorRecoil)
		{
			throw null;
		}

		// Token: 0x0600A3CA RID: 41930 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float ConvertFromTaxanomy(float f)
		{
			throw null;
		}

		// Token: 0x0600A3CB RID: 41931 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetHandRotationRecoil()
		{
			throw null;
		}

		// Token: 0x0600A3CC RID: 41932 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetHandPositionRecoil()
		{
			throw null;
		}

		// Token: 0x0600A3CD RID: 41933 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetCameraRotationRecoil()
		{
			throw null;
		}

		// Token: 0x0400AB33 RID: 43827
		[Tooltip("Влияние внешних пассивных еффектов смещения, напр Эффект Дыхания")]
		public bool UseOffset;

		// Token: 0x0400AB34 RID: 43828
		[Tooltip("Задействовать отдачу")]
		public bool RecoilEffectOn;

		// Token: 0x0400AB35 RID: 43829
		[Tooltip("Настройки влияния на оси вращения смещения во время выстрела, здесь можно усилить ослабить кажду ось.")]
		public ShotEffector.RecoilShotVal[] ShotRecoilProcessValues;

		// Token: 0x0400AB36 RID: 43830
		[Tooltip("Базовый расброс силы вращения, все расчеты ведутся от нее")]
		public Vector2 BasicRecoilRotationStrength;

		// Token: 0x0400AB37 RID: 43831
		[Tooltip("Базовый расброс силы смещения позиции, все расчеты ведутся от нее")]
		public Vector2 BasicRecoilPositionStrength;

		// Token: 0x0400AB38 RID: 43832
		public OldRotationRecoilProcess HandRotationRecoil;

		// Token: 0x0400AB39 RID: 43833
		public RecoilProcessBase HandPositionRecoil;

		// Token: 0x0400AB3A RID: 43834
		public RecoilProcessBase CameraRotationRecoil;

		// Token: 0x0400AB3B RID: 43835
		[HideInInspector]
		public Vector2 BasicPlayerRecoilRotationStrength;

		// Token: 0x0400AB3C RID: 43836
		[HideInInspector]
		public Vector2 BasicPlayerRecoilPositionStrength;

		// Token: 0x0400AB3D RID: 43837
		[HideInInspector]
		public Vector2 BasicPlayerRecoilDegreeRange;

		// Token: 0x0400AB3E RID: 43838
		[HideInInspector]
		public Vector3 RecoilDirection;

		// Token: 0x0400AB3F RID: 43839
		[HideInInspector]
		public Vector2 BasicRecoilRadian;

		// Token: 0x0400AB40 RID: 43840
		[HideInInspector]
		public Vector3 IntensitySeparateFactors;

		// Token: 0x0400AB41 RID: 43841
		[HideInInspector]
		public Vector2 OverheatBarrelMove;

		// Token: 0x0400AB42 RID: 43842
		[HideInInspector]
		public float BarrelMoveMult;

		// Token: 0x0400AB43 RID: 43843
		private Player.FirearmController _firearmController;
	}
}
