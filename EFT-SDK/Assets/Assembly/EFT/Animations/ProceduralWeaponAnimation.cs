using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.Animations
{
	// Token: 0x02001EFF RID: 7935
	public class ProceduralWeaponAnimation : MonoBehaviour
	{
		// Token: 0x17001AD6 RID: 6870
		// (get) Token: 0x0600A3D5 RID: 41941 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001AD7 RID: 6871
		// (get) Token: 0x0600A3D6 RID: 41942 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 VCameraTarget
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001AD8 RID: 6872
		// (get) Token: 0x0600A3D7 RID: 41943 RVA: 0x00002050 File Offset: 0x00000250
		private float Single_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001AD9 RID: 6873
		// (get) Token: 0x0600A3D8 RID: 41944 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 ShotDirection
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001ADA RID: 6874
		// (get) Token: 0x0600A3D9 RID: 41945 RVA: 0x00002050 File Offset: 0x00000250
		private float Single_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x14000226 RID: 550
		// (add) Token: 0x0600A3DA RID: 41946 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600A3DB RID: 41947 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnPreCollision
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

		// Token: 0x17001ADB RID: 6875
		// (get) Token: 0x0600A3DC RID: 41948 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		public SightComponent CurrentAimingMod
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001ADC RID: 6876
		// (get) Token: 0x0600A3DD RID: 41949 RVA: 0x00002050 File Offset: 0x00000250
		protected int AimIndex
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001ADD RID: 6877
		// (get) Token: 0x0600A3DE RID: 41950 RVA: 0x00002050 File Offset: 0x00000250
		public Transform AimPointParent
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001ADE RID: 6878
		// (get) Token: 0x0600A3DF RID: 41951 RVA: 0x00002050 File Offset: 0x00000250
		public float AimingSpeed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001ADF RID: 6879
		// (get) Token: 0x0600A3E0 RID: 41952 RVA: 0x00002050 File Offset: 0x00000250
		public float AimSwayStrength
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001AE0 RID: 6880
		// (get) Token: 0x0600A3E1 RID: 41953 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A3E2 RID: 41954 RVA: 0x00002050 File Offset: 0x00000250
		public bool CrankRecoil
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

		// Token: 0x17001AE5 RID: 6885
		// (get) Token: 0x0600A3E3 RID: 41955 RVA: 0x00002050 File Offset: 0x00000250
		private float Single_2
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001AE6 RID: 6886
		// (get) Token: 0x0600A3E4 RID: 41956 RVA: 0x00002050 File Offset: 0x00000250
		public BackendConfigSettingsClass.AimingConfiguration Aiming
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001AE7 RID: 6887
		// (get) Token: 0x0600A3E5 RID: 41957 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A3E6 RID: 41958 RVA: 0x00002050 File Offset: 0x00000250
		public bool Sprint
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

		// Token: 0x17001AE8 RID: 6888
		// (get) Token: 0x0600A3E7 RID: 41959 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A3E8 RID: 41960 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsAiming
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

		// Token: 0x17001AE9 RID: 6889
		// (get) Token: 0x0600A3EA RID: 41962 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A3E9 RID: 41961 RVA: 0x00002050 File Offset: 0x00000250
		public int Pose
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

		// Token: 0x17001AEA RID: 6890
		// (get) Token: 0x0600A3EC RID: 41964 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A3EB RID: 41963 RVA: 0x00002050 File Offset: 0x00000250
		public bool LeftStance
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

		// Token: 0x17001AEB RID: 6891
		// (get) Token: 0x0600A3ED RID: 41965 RVA: 0x00002050 File Offset: 0x00000250
		public float ExternalHeadRotation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001AEC RID: 6892
		// (get) Token: 0x0600A3EE RID: 41966 RVA: 0x00002050 File Offset: 0x00000250
		public float IntensityByPoseLevel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001AED RID: 6893
		// (get) Token: 0x0600A3EF RID: 41967 RVA: 0x00002050 File Offset: 0x00000250
		public float IntensityByAiming
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001AEE RID: 6894
		// (get) Token: 0x0600A3F0 RID: 41968 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A3F1 RID: 41969 RVA: 0x00002050 File Offset: 0x00000250
		public EPointOfView PointOfView
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

		// Token: 0x17001AEF RID: 6895
		// (get) Token: 0x0600A3F2 RID: 41970 RVA: 0x00002050 File Offset: 0x00000250
		public bool FirstPersonPointOfView
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001AF0 RID: 6896
		// (get) Token: 0x0600A3F4 RID: 41972 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A3F3 RID: 41971 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsGrenadeLauncher
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

		// Token: 0x17001AF1 RID: 6897
		// (get) Token: 0x0600A3F5 RID: 41973 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A3F6 RID: 41974 RVA: 0x00002050 File Offset: 0x00000250
		public bool OverlappingAllowsBlindfire
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

		// Token: 0x17001AF2 RID: 6898
		// (get) Token: 0x0600A3F7 RID: 41975 RVA: 0x00002050 File Offset: 0x00000250
		private float Single_3
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001AF3 RID: 6899
		// (get) Token: 0x0600A3F8 RID: 41976 RVA: 0x00002050 File Offset: 0x00000250
		public ProceduralWeaponAnimation.SightNBone CurrentScope
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001AF4 RID: 6900
		// (get) Token: 0x0600A3F9 RID: 41977 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A3FA RID: 41978 RVA: 0x00002050 File Offset: 0x00000250
		public float Overweight
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

		// Token: 0x17001AF5 RID: 6901
		// (get) Token: 0x0600A3FC RID: 41980 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A3FB RID: 41979 RVA: 0x00002050 File Offset: 0x00000250
		public bool TacticalReload
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

		// Token: 0x17001AF6 RID: 6902
		// (get) Token: 0x0600A3FD RID: 41981 RVA: 0x00002050 File Offset: 0x00000250
		public float VisorStepFrequency
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001AF7 RID: 6903
		// (get) Token: 0x0600A3FE RID: 41982 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A3FF RID: 41983 RVA: 0x00002050 File Offset: 0x00000250
		public bool ShotNeedsFovAdjustments
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

		// Token: 0x0600A400 RID: 41984 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x0600A401 RID: 41985 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(int fov)
		{
			throw null;
		}

		// Token: 0x0600A402 RID: 41986 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600A403 RID: 41987 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600A404 RID: 41988 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600A405 RID: 41989 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PreCalibrate()
		{
			throw null;
		}

		// Token: 0x0600A406 RID: 41990 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Calibrate()
		{
			throw null;
		}

		// Token: 0x0600A407 RID: 41991 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CalculateLocalSightTarget()
		{
			throw null;
		}

		// Token: 0x0600A408 RID: 41992 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(float distance)
		{
			throw null;
		}

		// Token: 0x0600A409 RID: 41993 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_4(Vector3 point)
		{
			throw null;
		}

		// Token: 0x0600A40A RID: 41994 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(Vector3 point)
		{
			throw null;
		}

		// Token: 0x0600A40B RID: 41995 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(Vector3 point)
		{
			throw null;
		}

		// Token: 0x0600A40C RID: 41996 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(Vector3 point)
		{
			throw null;
		}

		// Token: 0x0600A40D RID: 41997 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpticCalibrationSwitchUp()
		{
			throw null;
		}

		// Token: 0x0600A40E RID: 41998 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpticCalibrationSwitchDown()
		{
			throw null;
		}

		// Token: 0x0600A40F RID: 41999 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpticCalibrationSwitch(bool isUp)
		{
			throw null;
		}

		// Token: 0x0600A410 RID: 42000 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScopesModeUpdated()
		{
			throw null;
		}

		// Token: 0x0600A411 RID: 42001 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearPreviousWeapon()
		{
			throw null;
		}

		// Token: 0x0600A412 RID: 42002 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_8(GInterface127 firearms, GInterface320 weapon, WeaponPrefab wp, SkillManager.GClass1768 buffInfo)
		{
			throw null;
		}

		// Token: 0x0600A413 RID: 42003 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_9(WeaponPrefab wp)
		{
			throw null;
		}

		// Token: 0x0600A414 RID: 42004 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateSwaySettings()
		{
			throw null;
		}

		// Token: 0x0600A415 RID: 42005 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PhysicalConditionUpdated(EPhysicalCondition updated, EPhysicalCondition full)
		{
			throw null;
		}

		// Token: 0x0600A416 RID: 42006 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateWeaponVariables()
		{
			throw null;
		}

		// Token: 0x0600A417 RID: 42007 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CheckShouldMoveWeaponCloser()
		{
			throw null;
		}

		// Token: 0x0600A418 RID: 42008 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ManualSetVariables(float aimingSpeed, float aimSwayStrength, float overweight, float ergonomicWeight)
		{
			throw null;
		}

		// Token: 0x0600A419 RID: 42009 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLauncherWeaponBone(Transform weaponRoot, Transform propBone)
		{
			throw null;
		}

		// Token: 0x0600A41A RID: 42010 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateWeaponBoneByLauncherWeaponBone()
		{
			throw null;
		}

		// Token: 0x0600A41B RID: 42011 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitTransforms(TransformLinks hierarchy, GClass671 ccv = null)
		{
			throw null;
		}

		// Token: 0x0600A41C RID: 42012 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FindAimTransformsWithoutSights()
		{
			throw null;
		}

		// Token: 0x0600A41D RID: 42013 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FindUnderbarrelWeaponSight()
		{
			throw null;
		}

		// Token: 0x0600A41E RID: 42014 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetScopeRotation()
		{
			throw null;
		}

		// Token: 0x0600A41F RID: 42015 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FindAimTransforms()
		{
			throw null;
		}

		// Token: 0x0600A420 RID: 42016 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10()
		{
			throw null;
		}

		// Token: 0x0600A421 RID: 42017 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11()
		{
			throw null;
		}

		// Token: 0x0600A422 RID: 42018 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12()
		{
			throw null;
		}

		// Token: 0x0600A423 RID: 42019 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("align collimator")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13()
		{
			throw null;
		}

		// Token: 0x0600A424 RID: 42020 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_14()
		{
			throw null;
		}

		// Token: 0x0600A425 RID: 42021 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Align")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_15()
		{
			throw null;
		}

		// Token: 0x0600A426 RID: 42022 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_16(Transform t)
		{
			throw null;
		}

		// Token: 0x0600A427 RID: 42023 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateTacticalReload()
		{
			throw null;
		}

		// Token: 0x0600A428 RID: 42024 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ZeroAdjustments()
		{
			throw null;
		}

		// Token: 0x0600A429 RID: 42025 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BlendAnimatorPose(float dt)
		{
			throw null;
		}

		// Token: 0x0600A42A RID: 42026 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_17()
		{
			throw null;
		}

		// Token: 0x0600A42B RID: 42027 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyPosition()
		{
			throw null;
		}

		// Token: 0x0600A42C RID: 42028 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyStationaryWeaponPosition()
		{
			throw null;
		}

		// Token: 0x0600A42D RID: 42029 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RotateAround(Transform t, Vector3 worldPivot, Vector3 rotation)
		{
			throw null;
		}

		// Token: 0x0600A42E RID: 42030 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeferredRotateWithCustomOrder(Transform t, Vector3 worldPivot, Vector3 rotation)
		{
			throw null;
		}

		// Token: 0x0600A42F RID: 42031 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeferredRotate(Transform t, Vector3 worldPivot, Vector3 rotation)
		{
			throw null;
		}

		// Token: 0x0600A430 RID: 42032 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyComplexRotation(float dt)
		{
			throw null;
		}

		// Token: 0x0600A431 RID: 42033 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyAimingAlignment(float dt)
		{
			throw null;
		}

		// Token: 0x0600A432 RID: 42034 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplySimpleRotation(float dt)
		{
			throw null;
		}

		// Token: 0x0600A433 RID: 42035 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyTacticalReloadTransformations()
		{
			throw null;
		}

		// Token: 0x0600A434 RID: 42036 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AvoidObstacles()
		{
			throw null;
		}

		// Token: 0x0600A435 RID: 42037 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetStrategy(EPointOfView pointOfView)
		{
			throw null;
		}

		// Token: 0x0600A436 RID: 42038 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetStrategy(GInterface34 strategy)
		{
			throw null;
		}

		// Token: 0x0600A437 RID: 42039 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHeadRotation(Vector3 headRot)
		{
			throw null;
		}

		// Token: 0x0600A438 RID: 42040 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetHeadRotation()
		{
			throw null;
		}

		// Token: 0x0600A439 RID: 42041 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StationaryCamera(float dt)
		{
			throw null;
		}

		// Token: 0x0600A43A RID: 42042 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AdjustOpticsPAG17()
		{
			throw null;
		}

		// Token: 0x0600A43B RID: 42043 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CalculateCameraPosition()
		{
			throw null;
		}

		// Token: 0x0600A43C RID: 42044 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_18()
		{
			throw null;
		}

		// Token: 0x0600A43D RID: 42045 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LerpCamera(float dt)
		{
			throw null;
		}

		// Token: 0x0600A43E RID: 42046 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_19(float deltaTime)
		{
			throw null;
		}

		// Token: 0x0600A43F RID: 42047 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_20()
		{
			throw null;
		}

		// Token: 0x0600A440 RID: 42048 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_21(Transform t)
		{
			throw null;
		}

		// Token: 0x0600A441 RID: 42049 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_22()
		{
			throw null;
		}

		// Token: 0x0600A442 RID: 42050 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateCameraFovForced()
		{
			throw null;
		}

		// Token: 0x0600A443 RID: 42051 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_23(bool forced = false)
		{
			throw null;
		}

		// Token: 0x0600A444 RID: 42052 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LateTransformations(float dt)
		{
			throw null;
		}

		// Token: 0x0600A445 RID: 42053 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetLeftStanceCurrentCurveValue(float value)
		{
			throw null;
		}

		// Token: 0x0600A446 RID: 42054 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Shoot(float str = 1f)
		{
			throw null;
		}

		// Token: 0x0600A447 RID: 42055 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x0600A448 RID: 42056 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x0600A449 RID: 42057 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetSpring()
		{
			throw null;
		}

		// Token: 0x0600A44A RID: 42058 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_24()
		{
			throw null;
		}

		// Token: 0x0600A44B RID: 42059 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetFovParams(float scale)
		{
			throw null;
		}

		// Token: 0x0600A44C RID: 42060 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_25(int currentScopeIndex)
		{
			throw null;
		}

		// Token: 0x0600A44D RID: 42061 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartBlindFire(int blindfire)
		{
			throw null;
		}

		// Token: 0x0600A44E RID: 42062 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator ApplyFovAdjustments(Player player)
		{
			throw null;
		}

		// Token: 0x0600A44F RID: 42063 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetFovAdjustments(Player player)
		{
			throw null;
		}

		// Token: 0x0600A450 RID: 42064 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AgsCalibrate(bool calibrate)
		{
			throw null;
		}

		// Token: 0x0600A451 RID: 42065 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdatePossibleTilt(float smoothedCharacterMovementSpeed, float smoothedPoseLevel)
		{
			throw null;
		}

		// Token: 0x0600A452 RID: 42066 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AssignAnimatorPose(AnimatorPose animatorPose)
		{
			throw null;
		}

		// Token: 0x0600A453 RID: 42067 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ObservedCalibration()
		{
			throw null;
		}

		// Token: 0x0600A454 RID: 42068 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartFovCoroutine(Player player)
		{
			throw null;
		}

		// Token: 0x0600A455 RID: 42069 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartHandShake(float lackOfStamina, float fullStaminaCost)
		{
			throw null;
		}

		// Token: 0x0600A456 RID: 42070 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_26(float duration, float tremorIntensity, float curveFrequency, float curveIntensity)
		{
			throw null;
		}

		// Token: 0x0400AB70 RID: 43888
		private static readonly WaitForEndOfFrame _waitForEndOfFrame;

		// Token: 0x0400AB71 RID: 43889
		private const float PITCH_TOLERANCE = 0.1f;

		// Token: 0x0400AB72 RID: 43890
		public const string MOD_CAMERA_BONE = "mod_aim_camera";

		// Token: 0x0400AB73 RID: 43891
		public const string LAUNCHER_CAMERA_BONE = "launcher_0_aim_camera";

		// Token: 0x0400AB74 RID: 43892
		public const string LINE_OF_SIGHT_P0 = "mod_align_rear";

		// Token: 0x0400AB75 RID: 43893
		public const string LINE_OF_SIGHT_P1 = "mod_align_front";

		// Token: 0x0400AB76 RID: 43894
		public const string CAMERA_BONE = "aim_camera";

		// Token: 0x0400AB77 RID: 43895
		private const int SCOPE_ROTATION_RANGE = 55;

		// Token: 0x0400AB78 RID: 43896
		private const float AGS_HEIGHT_STEP = 0.5f;

		// Token: 0x0400AB79 RID: 43897
		public PlayerSpring HandsContainer;

		// Token: 0x0400AB7A RID: 43898
		public GameObject CameraContainer;

		// Token: 0x0400AB7B RID: 43899
		public EProceduralAnimationMask Mask;

		// Token: 0x0400AB7C RID: 43900
		public BreathEffector Breath;

		// Token: 0x0400AB7D RID: 43901
		public WalkEffector Walk;

		// Token: 0x0400AB7E RID: 43902
		public MotionEffector MotionReact;

		// Token: 0x0400AB7F RID: 43903
		public ForceEffector ForceReact;

		// Token: 0x0400AB80 RID: 43904
		public ShotEffector Shootingg;

		// Token: 0x0400AB81 RID: 43905
		public TurnAwayEffector TurnAway;

		// Token: 0x0400AB82 RID: 43906
		public CustomEffector CustomEffector;

		// Token: 0x0400AB83 RID: 43907
		public HandShakeEffector HandShakeEffector;

		// Token: 0x0400AB84 RID: 43908
		public Vector3 Offset;

		// Token: 0x0400AB85 RID: 43909
		public Vector2 AgsDeltaHeightRange;

		// Token: 0x0400AB86 RID: 43910
		private float _overweight;

		// Token: 0x0400AB87 RID: 43911
		private readonly Quaternion _rotation90deg;

		// Token: 0x0400AB88 RID: 43912
		private GClass671 _ccv;

		// Token: 0x0400AB89 RID: 43913
		private Transform _launcherWeaponRootBone;

		// Token: 0x0400AB8A RID: 43914
		private Transform _launcherPropBone;

		// Token: 0x0400AB8B RID: 43915
		private Transform _launcherScope;

		// Token: 0x0400AB8C RID: 43916
		private float _cachedUnderbarrelSightAngle;

		// Token: 0x0400AB8D RID: 43917
		private float _cachedUnderbarrelSightPosition;

		// Token: 0x0400AB8E RID: 43918
		private float _lineOfSightDeltaAngle;

		// Token: 0x0400AB8F RID: 43919
		private float _currentLineOfSightDeltaAngle;

		// Token: 0x0400AB90 RID: 43920
		public Vector2 _cameraShiftToLineOfSight;

		// Token: 0x0400AB91 RID: 43921
		private Transform _bone0;

		// Token: 0x0400AB92 RID: 43922
		private Transform _bone1;

		// Token: 0x0400AB93 RID: 43923
		private bool _hasPairOfIronSightTransforms;

		// Token: 0x0400AB94 RID: 43924
		private const float NoButtShift = 0.05f;

		// Token: 0x0400AB95 RID: 43925
		public List<ProceduralWeaponAnimation.SightNBone> ScopeAimTransforms;

		// Token: 0x0400AB96 RID: 43926
		public float WeaponFlipSpeed;

		// Token: 0x0400AB97 RID: 43927
		public float CameraSmoothTime;

		// Token: 0x0400AB98 RID: 43928
		private Vector3 vel;

		// Token: 0x0400AB99 RID: 43929
		private Quaternion _scopeRotation;

		// Token: 0x0400AB9A RID: 43930
		private Quaternion _targetScopeRotation;

		// Token: 0x0400AB9B RID: 43931
		private float _targetScopeRotationDeg;

		// Token: 0x0400AB9C RID: 43932
		private GInterface127 _firearmAnimationData;

		// Token: 0x0400AB9D RID: 43933
		private Player.FirearmController _firearmController;

		// Token: 0x0400AB9E RID: 43934
		private float _leftStanceCurrentCurveValue;

		// Token: 0x0400AB9F RID: 43935
		[SerializeField]
		private bool _crankRecoil;

		// Token: 0x0400ABA0 RID: 43936
		private bool _isAiming;

		// Token: 0x0400ABA1 RID: 43937
		private bool _sprinting;

		// Token: 0x0400ABA2 RID: 43938
		public bool _shouldMoveWeaponCloser;

		// Token: 0x0400ABA3 RID: 43939
		[SerializeField]
		private Vector3 _vCameraTarget;

		// Token: 0x0400ABA4 RID: 43940
		public Vector3 RotationCameraOffset;

		// Token: 0x0400ABA5 RID: 43941
		public EPointOfView _pointOfView;

		// Token: 0x0400ABA6 RID: 43942
		private float _aimingSpeed;

		// Token: 0x0400ABA7 RID: 43943
		private float _overweightAimingMultiplier;

		// Token: 0x0400ABA8 RID: 43944
		public WeaponPrefab.AimPlane _currentAimingPlane;

		// Token: 0x0400ABA9 RID: 43945
		public WeaponPrefab.AimPlane _farPlane;

		// Token: 0x0400ABAA RID: 43946
		private readonly List<ProceduralWeaponAnimation.SightNBone> _optics;

		// Token: 0x0400ABAB RID: 43947
		private Vector3 _cameraByFOVOffset;

		// Token: 0x0400ABAC RID: 43948
		public float _fovCompensatoryDistance;

		// Token: 0x0400ABAD RID: 43949
		private float _maxScopeDepthAndAimPlaneDelta;

		// Token: 0x0400ABAE RID: 43950
		private float _previousPitch;

		// Token: 0x0400ABAF RID: 43951
		public float _agsDeltaHeight;

		// Token: 0x0400ABB0 RID: 43952
		private Quaternion _cameraIdenity;

		// Token: 0x0400ABB1 RID: 43953
		private Quaternion _rotationOffset;

		// Token: 0x0400ABB2 RID: 43954
		private float _compensatoryScale;

		// Token: 0x0400ABB3 RID: 43955
		public Vector3 _shotDirection;

		// Token: 0x0400ABB4 RID: 43956
		private float _blindfireStrength;

		// Token: 0x0400ABB5 RID: 43957
		public Vector3 TacticalReloadStiffnes;

		// Token: 0x0400ABB6 RID: 43958
		public float TacticalReloadPosition;

		// Token: 0x0400ABB7 RID: 43959
		private Player.ValueBlenderDelay _tacticalReload;

		// Token: 0x0400ABB8 RID: 43960
		[Tooltip("Диапазон возможной скорости, с которой камера будет доворачиваться до угла задирания оружия, активизируется при автоматическом огне")]
		public Vector2 CameraToWeaponAngleSpeedRange;

		// Token: 0x0400ABB9 RID: 43961
		[Tooltip("Шаг роста скорости, с которой камера будет доворачиваться до угла задирания оружия, активизируется при автоматическом огне")]
		public float CameraToWeaponAngleStep;

		// Token: 0x0400ABBA RID: 43962
		public float CameraSmoothSteady;

		// Token: 0x0400ABBB RID: 43963
		public float CameraSmoothRecoil;

		// Token: 0x0400ABBC RID: 43964
		private const float CameraSmoothTransitionDelay = 0.2f;

		// Token: 0x0400ABBD RID: 43965
		public float CameraSmoothOut;

		// Token: 0x0400ABBE RID: 43966
		public Action AvailableScopesChanged;

		// Token: 0x0400ABBF RID: 43967
		private float _cameraRecoilLerpTempSpeed;

		// Token: 0x0400ABC0 RID: 43968
		private Quaternion _previousCameraTargetRotation;

		// Token: 0x0400ABC1 RID: 43969
		private Quaternion _currentRecoilCameraRotate;

		// Token: 0x0400ABC2 RID: 43970
		private const float ScopeDefaultStateAngleRotation = 180f;

		// Token: 0x0400ABC3 RID: 43971
		public Player.BetterValueBlender CameraSmoothBlender;

		// Token: 0x0400ABC4 RID: 43972
		public Vector3 AimSwayMax;

		// Token: 0x0400ABC5 RID: 43973
		public Vector3 AimSwayMin;

		// Token: 0x0400ABC6 RID: 43974
		public float SwayFalloff;

		// Token: 0x0400ABC7 RID: 43975
		public float AimSwayStartsThreshold;

		// Token: 0x0400ABC8 RID: 43976
		public float AimSwayMaxThreshold;

		// Token: 0x0400ABC9 RID: 43977
		private float _aimSwayStrength;

		// Token: 0x0400ABCA RID: 43978
		private Vector3 _aimSwayDirection;

		// Token: 0x0400ABCB RID: 43979
		private Player.ValueBlender _aimSwayBlender;

		// Token: 0x0400ABCC RID: 43980
		public Vector3 PlayerBonesThirdRootOffset;

		// Token: 0x0400ABCD RID: 43981
		public Quaternion PlayerBonesThirdRootRotationOffset;

		// Token: 0x0400ABCE RID: 43982
		private Vector3 _prediction;

		// Token: 0x0400ABCF RID: 43983
		private Quaternion _local;

		// Token: 0x0400ABD0 RID: 43984
		private Quaternion _temporaryRotation;

		// Token: 0x0400ABD1 RID: 43985
		private Vector3 _temporaryPosition;

		// Token: 0x0400ABD2 RID: 43986
		private float _animatorPoseBlend;

		// Token: 0x0400ABD3 RID: 43987
		private int _pose;

		// Token: 0x0400ABD4 RID: 43988
		private bool _isGrenadeMode;

		// Token: 0x0400ABD5 RID: 43989
		private bool _isLeftStance;

		// Token: 0x0400ABD6 RID: 43990
		private readonly Player.ValueBlender _grenadeLauncherBlender;

		// Token: 0x0400ABD7 RID: 43991
		public float SmoothedTilt;

		// Token: 0x0400ABD8 RID: 43992
		public float PossibleTilt;

		// Token: 0x0400ABD9 RID: 43993
		public float _launcherZeroZ;

		// Token: 0x0400ABDA RID: 43994
		public float _launcherRotationZeroX;

		// Token: 0x0400ABDB RID: 43995
		public Vector3 RotationZeroSum;

		// Token: 0x0400ABDC RID: 43996
		public Vector3 PositionZeroSum;

		// Token: 0x0400ABDD RID: 43997
		public Player.BetterValueBlender BlindfireBlender;

		// Token: 0x0400ABDE RID: 43998
		public Player.ValueBlender TiltBlender;

		// Token: 0x0400ABDF RID: 43999
		public Vector3 BlindFireOffset;

		// Token: 0x0400ABE0 RID: 44000
		public Vector3 BlindFireRotation;

		// Token: 0x0400ABE1 RID: 44001
		public Vector3 BlindFireCamera;

		// Token: 0x0400ABE2 RID: 44002
		public Vector3 SideFireOffset;

		// Token: 0x0400ABE3 RID: 44003
		public Vector3 SideFireRotation;

		// Token: 0x0400ABE4 RID: 44004
		public Vector3 SideFireCamera;

		// Token: 0x0400ABE5 RID: 44005
		public float Pitch;

		// Token: 0x0400ABE6 RID: 44006
		public float AimingDisplacementStr;

		// Token: 0x0400ABE7 RID: 44007
		private float _weight;

		// Token: 0x0400ABE8 RID: 44008
		private float _ergonomicWeight;

		// Token: 0x0400ABE9 RID: 44009
		private float _swayStrength;

		// Token: 0x0400ABEA RID: 44010
		private float _displacementStr;

		// Token: 0x0400ABEB RID: 44011
		public Vector3 BlindFireEndPosition;

		// Token: 0x0400ABEC RID: 44012
		private bool _tacticalReloadAvailable;

		// Token: 0x0400ABED RID: 44013
		private bool _updateCalibration;

		// Token: 0x0400ABEF RID: 44015
		private Vector3 _headRotationVec;

		// Token: 0x0400ABF0 RID: 44016
		private SkillManager.GClass1768 _buffInfo;

		// Token: 0x0400ABF1 RID: 44017
		private Vector3 _localCalibratePoint;

		// Token: 0x0400ABF2 RID: 44018
		private GInterface34 _strategy;

		// Token: 0x0400ABF3 RID: 44019
		private bool _adjustCollimatorsToTrajectory;

		// Token: 0x0400ABF4 RID: 44020
		private Action _unbindScopeCycle;

		// Token: 0x0400ABF5 RID: 44021
		private Vector3 _localAimShift;

		// Token: 0x0400ABF6 RID: 44022
		private readonly float _aimLeftStanceAdditionalOffset;

		// Token: 0x0400ABF7 RID: 44023
		private Action _fovEvent;

		// Token: 0x0400ABF8 RID: 44024
		private Coroutine _handShakeCoroutine;

		// Token: 0x0400ABFB RID: 44027
		private float _swayFactor;

		// Token: 0x0400ABFC RID: 44028
		private Vector3 _blindFireRotation;

		// Token: 0x0400ABFD RID: 44029
		private Vector3 _blindFirePosition;

		// Token: 0x0400ABFE RID: 44030
		public List<ValueTuple<AnimatorPose, float, bool>> ActiveBlends;

		// Token: 0x0400ABFF RID: 44031
		[SerializeField]
		private Vector3 vector;

		// Token: 0x0400AC00 RID: 44032
		private const float ScopeRotationThreshold = 1f;

		// Token: 0x02001F00 RID: 7936
		public class GClass2208
		{
			// Token: 0x0600A457 RID: 42071 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public static float GetValue(float speed, float height)
			{
				throw null;
			}

			// Token: 0x0400AC01 RID: 44033
			private const float float_0 = 0.3f;

			// Token: 0x0400AC02 RID: 44034
			private const float float_1 = 0.1f;

			// Token: 0x0400AC03 RID: 44035
			private const float float_2 = 1f;

			// Token: 0x0400AC04 RID: 44036
			private static Vector3 vector3_0;

			// Token: 0x0400AC05 RID: 44037
			private static Vector3 vector3_1;

			// Token: 0x0400AC06 RID: 44038
			private static Vector3 vector3_2;

			// Token: 0x0400AC07 RID: 44039
			private static Vector3 vector3_3;

			// Token: 0x0400AC08 RID: 44040
			private static float float_3;
		}

		// Token: 0x02001F01 RID: 7937
		public class SightNBone
		{
			// Token: 0x17001AF8 RID: 6904
			// (get) Token: 0x0600A458 RID: 42072 RVA: 0x00002050 File Offset: 0x00000250
			public bool IsOptic
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0400AC09 RID: 44041
			public SightComponent Mod;

			// Token: 0x0400AC0A RID: 44042
			public Transform Bone;

			// Token: 0x0400AC0B RID: 44043
			public ScopePrefabCache ScopePrefabCache;

			// Token: 0x0400AC0C RID: 44044
			public int Depth;

			// Token: 0x0400AC0D RID: 44045
			public float Rotation;

			// Token: 0x0400AC0E RID: 44046
			public float LeftStanceRotation;

			// Token: 0x0400AC0F RID: 44047
			public bool AlignIfAvailable;

			// Token: 0x0400AC10 RID: 44048
			public bool BoneRelatesToOptics;

			// Token: 0x0400AC11 RID: 44049
			public float EyeGuardShift;
		}

		// Token: 0x02001F02 RID: 7938
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1816
		{
			// Token: 0x0600A459 RID: 42073 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(ProtrudableComponent x)
			{
				throw null;
			}

			// Token: 0x0600A45A RID: 42074 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(ProtrudableComponent x)
			{
				throw null;
			}

			// Token: 0x0600A45B RID: 42075 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_2(Slot x)
			{
				throw null;
			}

			// Token: 0x0600A45C RID: 42076 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_3(Slot x)
			{
				throw null;
			}

			// Token: 0x0600A45D RID: 42077 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_4(Slot slot)
			{
				throw null;
			}

			// Token: 0x0600A45E RID: 42078 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_5(Mod x)
			{
				throw null;
			}

			// Token: 0x0600A45F RID: 42079 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_6(ProceduralWeaponAnimation.SightNBone sat)
			{
				throw null;
			}

			// Token: 0x0600A460 RID: 42080 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Item method_7(Slot x)
			{
				throw null;
			}

			// Token: 0x0400AC12 RID: 44050
			public static readonly ProceduralWeaponAnimation.Class1816 class1816_0;

			// Token: 0x0400AC13 RID: 44051
			public static Func<ProtrudableComponent, bool> func_0;

			// Token: 0x0400AC14 RID: 44052
			public static Func<ProtrudableComponent, bool> func_1;

			// Token: 0x0400AC15 RID: 44053
			public static Func<Slot, bool> func_2;

			// Token: 0x0400AC16 RID: 44054
			public static Func<Slot, string> func_3;

			// Token: 0x0400AC17 RID: 44055
			public static Func<Slot, bool> func_4;

			// Token: 0x0400AC18 RID: 44056
			public static Func<Mod, string> func_5;

			// Token: 0x0400AC19 RID: 44057
			public static Func<ProceduralWeaponAnimation.SightNBone, bool> func_6;

			// Token: 0x0400AC1A RID: 44058
			public static Func<Slot, Item> func_7;
		}

		// Token: 0x02001F03 RID: 7939
		[CompilerGenerated]
		private sealed class Class1817
		{
			// Token: 0x0600A461 RID: 42081 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(ProceduralWeaponAnimation.SightNBone x)
			{
				throw null;
			}

			// Token: 0x0400AC1B RID: 44059
			public Transform scope;
		}

		// Token: 0x02001F04 RID: 7940
		[CompilerGenerated]
		private sealed class Class1818
		{
			// Token: 0x0600A462 RID: 42082 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_0(Transform x)
			{
				throw null;
			}

			// Token: 0x0600A463 RID: 42083 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_1(Transform x)
			{
				throw null;
			}

			// Token: 0x0400AC1C RID: 44060
			public Transform c;
		}

		// Token: 0x02001F05 RID: 7941
		[CompilerGenerated]
		private sealed class Class1819
		{
			// Token: 0x0600A464 RID: 42084 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(WeaponPrefab.AimPlane x)
			{
				throw null;
			}

			// Token: 0x0400AC1D RID: 44061
			public ProceduralWeaponAnimation.SightNBone scope;
		}
	}
}
