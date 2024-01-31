using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Diz.LanguageExtensions;
using EFT.Interactive;
using EFT.InventoryLogic;
using EFT.MovingPlatforms;
using EFT.ObstacleCollision;
using EFT.Vaulting;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT
{
	// Token: 0x020015AB RID: 5547
	public class MovementContext : GInterface190
	{
		// Token: 0x17001295 RID: 4757
		// (get) Token: 0x0600770F RID: 30479 RVA: 0x00002050 File Offset: 0x00000250
		public ICharacterController CharacterController
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001296 RID: 4758
		// (get) Token: 0x06007710 RID: 30480 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007711 RID: 30481 RVA: 0x00002050 File Offset: 0x00000250
		public RollingMedian AverageRotationSpeed
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

		// Token: 0x17001297 RID: 4759
		// (get) Token: 0x06007712 RID: 30482 RVA: 0x00002050 File Offset: 0x00000250
		public RaycastHitData GroundHit
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001298 RID: 4760
		// (get) Token: 0x06007713 RID: 30483 RVA: 0x00002050 File Offset: 0x00000250
		public int GroundMask
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001299 RID: 4761
		// (get) Token: 0x06007714 RID: 30484 RVA: 0x00002050 File Offset: 0x00000250
		public float StraightenTimer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1400014F RID: 335
		// (add) Token: 0x06007715 RID: 30485 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06007716 RID: 30486 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<EPhysicalCondition, EPhysicalCondition> PhysicalConditionChanged
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

		// Token: 0x14000150 RID: 336
		// (add) Token: 0x06007717 RID: 30487 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06007718 RID: 30488 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<ECantRotate> OnCantRotate
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

		// Token: 0x1700129A RID: 4762
		// (get) Token: 0x06007719 RID: 30489 RVA: 0x00002050 File Offset: 0x00000250
		public EPhysicalCondition PhysicalCondition
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x14000151 RID: 337
		// (add) Token: 0x0600771A RID: 30490 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600771B RID: 30491 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<float, float, float, int> OnMaxSpeedChangedEvent
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

		// Token: 0x14000152 RID: 338
		// (add) Token: 0x0600771C RID: 30492 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600771D RID: 30493 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnCharacterControllerSpeedLimitChanged
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

		// Token: 0x1700129B RID: 4763
		// (get) Token: 0x0600771E RID: 30494 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600771F RID: 30495 RVA: 0x00002050 File Offset: 0x00000250
		public float StateSpeedLimit
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

		// Token: 0x1700129C RID: 4764
		// (get) Token: 0x06007720 RID: 30496 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007721 RID: 30497 RVA: 0x00002050 File Offset: 0x00000250
		public float StateSprintSpeedLimit
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

		// Token: 0x1700129D RID: 4765
		// (get) Token: 0x06007722 RID: 30498 RVA: 0x00002050 File Offset: 0x00000250
		public SkillManager SkillManager
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700129E RID: 4766
		// (get) Token: 0x06007723 RID: 30499 RVA: 0x00002050 File Offset: 0x00000250
		public float Overweight
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700129F RID: 4767
		// (get) Token: 0x06007724 RID: 30500 RVA: 0x00002050 File Offset: 0x00000250
		public float Inertia
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012A0 RID: 4768
		// (get) Token: 0x06007725 RID: 30501 RVA: 0x00002050 File Offset: 0x00000250
		public float MoveSideInertia
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012A1 RID: 4769
		// (get) Token: 0x06007726 RID: 30502 RVA: 0x00002050 File Offset: 0x00000250
		public float MoveDiagonalInertia
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012A2 RID: 4770
		// (get) Token: 0x06007727 RID: 30503 RVA: 0x00002050 File Offset: 0x00000250
		public EFTHardSettings Settings
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012A3 RID: 4771
		// (get) Token: 0x06007728 RID: 30504 RVA: 0x00002050 File Offset: 0x00000250
		public LeftStanceController LeftStanceController
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012A4 RID: 4772
		// (get) Token: 0x06007729 RID: 30505 RVA: 0x00002050 File Offset: 0x00000250
		public IObstacleCollisionFacade ObstacleCollisionFacade
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012A5 RID: 4773
		// (get) Token: 0x0600772A RID: 30506 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600772B RID: 30507 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsAxesIgnored
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

		// Token: 0x170012A6 RID: 4774
		// (get) Token: 0x0600772C RID: 30508 RVA: 0x00002050 File Offset: 0x00000250
		public BackendConfigSettingsClass.InertiaSettings InertiaSettings
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600772D RID: 30509 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetProneStateForce()
		{
			throw null;
		}

		// Token: 0x170012A7 RID: 4775
		// (get) Token: 0x0600772E RID: 30510 RVA: 0x00002050 File Offset: 0x00000250
		public bool AutoVaultingSettingEnabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012A8 RID: 4776
		// (get) Token: 0x0600772F RID: 30511 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007730 RID: 30512 RVA: 0x00002050 File Offset: 0x00000250
		public virtual bool IsInPronePose
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

		// Token: 0x170012A9 RID: 4777
		// (get) Token: 0x06007731 RID: 30513 RVA: 0x00002050 File Offset: 0x00000250
		public float VaultingHeight
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012AA RID: 4778
		// (get) Token: 0x06007732 RID: 30514 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007733 RID: 30515 RVA: 0x00002050 File Offset: 0x00000250
		public BaseMovementState CurrentState
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

		// Token: 0x170012AB RID: 4779
		// (get) Token: 0x06007734 RID: 30516 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007735 RID: 30517 RVA: 0x00002050 File Offset: 0x00000250
		public BaseMovementState PreviousState
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

		// Token: 0x14000153 RID: 339
		// (add) Token: 0x06007736 RID: 30518 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06007737 RID: 30519 RVA: 0x00002050 File Offset: 0x00000250
		public event MovementContext.GDelegate63 OnStateChanged
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

		// Token: 0x14000154 RID: 340
		// (add) Token: 0x06007738 RID: 30520 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06007739 RID: 30521 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<int> OnPoseChanged
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

		// Token: 0x170012AC RID: 4780
		// (get) Token: 0x0600773A RID: 30522 RVA: 0x00002050 File Offset: 0x00000250
		public int PoseToInt
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x14000155 RID: 341
		// (add) Token: 0x0600773B RID: 30523 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600773C RID: 30524 RVA: 0x00002050 File Offset: 0x00000250
		public event MovementContext.GDelegate64 OnClientAnimatorStateIndexChanged
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

		// Token: 0x0600773D RID: 30525 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCurrentClientAnimatorStateIndex(int hashTableIndex)
		{
			throw null;
		}

		// Token: 0x170012AD RID: 4781
		// (get) Token: 0x0600773E RID: 30526 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600773F RID: 30527 RVA: 0x00002050 File Offset: 0x00000250
		public float LastDeltaTime
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

		// Token: 0x170012AE RID: 4782
		// (get) Token: 0x06007740 RID: 30528 RVA: 0x00002050 File Offset: 0x00000250
		public bool LeftStanceEnabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012AF RID: 4783
		// (get) Token: 0x06007741 RID: 30529 RVA: 0x00002050 File Offset: 0x00000250
		private float Single_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012B0 RID: 4784
		// (get) Token: 0x06007742 RID: 30530 RVA: 0x00002050 File Offset: 0x00000250
		private float Single_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012B1 RID: 4785
		// (get) Token: 0x06007743 RID: 30531 RVA: 0x00002050 File Offset: 0x00000250
		private float Single_2
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012B2 RID: 4786
		// (get) Token: 0x06007744 RID: 30532 RVA: 0x00002050 File Offset: 0x00000250
		private GClass684 GClass684_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06007745 RID: 30533 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool PhysicalConditionIs(EPhysicalCondition c)
		{
			throw null;
		}

		// Token: 0x06007746 RID: 30534 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool PhysicalConditionContainsAny(EPhysicalCondition c)
		{
			throw null;
		}

		// Token: 0x06007747 RID: 30535 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool SetPhysicalCondition(EPhysicalCondition c, bool val)
		{
			throw null;
		}

		// Token: 0x06007748 RID: 30536 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetPhysicalCondition()
		{
			throw null;
		}

		// Token: 0x06007749 RID: 30537 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CopyPhysicalCondition(EPhysicalCondition conditionForCopy)
		{
			throw null;
		}

		// Token: 0x170012B3 RID: 4787
		// (get) Token: 0x0600774A RID: 30538 RVA: 0x00002050 File Offset: 0x00000250
		public PlayerAnimator PlayerAnimator
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600774B RID: 30539 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GrounderSetActive(bool grounderIsOn)
		{
			throw null;
		}

		// Token: 0x0600774C RID: 30540 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnJump()
		{
			throw null;
		}

		// Token: 0x0600774D RID: 30541 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayBreachSound()
		{
			throw null;
		}

		// Token: 0x0600774E RID: 30542 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnBreach()
		{
			throw null;
		}

		// Token: 0x0600774F RID: 30543 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnJumpEnd()
		{
			throw null;
		}

		// Token: 0x06007750 RID: 30544 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 RibcagePosition()
		{
			throw null;
		}

		// Token: 0x06007751 RID: 30545 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Transform RootJointTransform()
		{
			throw null;
		}

		// Token: 0x06007752 RID: 30546 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector2 CalculateLookAtDirection(Vector3 target, Vector3 playerPos, float relativeRootHeight = 0f)
		{
			throw null;
		}

		// Token: 0x06007753 RID: 30547 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddStateSpeedLimit(float speedLimit, Player.ESpeedLimit cause)
		{
			throw null;
		}

		// Token: 0x06007754 RID: 30548 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddStateSpeedLimit(float speedLimit, Player.ESpeedLimit cause, float duration)
		{
			throw null;
		}

		// Token: 0x06007755 RID: 30549 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEnterObstacle(ObstacleCollider obstacle)
		{
			throw null;
		}

		// Token: 0x06007756 RID: 30550 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnExitObstacle(ObstacleCollider obstacle)
		{
			throw null;
		}

		// Token: 0x06007759 RID: 30553 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(float powerCoef = 1f)
		{
			throw null;
		}

		// Token: 0x0600775A RID: 30554 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(float spreadDistance, Color color)
		{
			throw null;
		}

		// Token: 0x0600775B RID: 30555 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveStateSpeedLimit(Player.ESpeedLimit cause)
		{
			throw null;
		}

		// Token: 0x0600775C RID: 30556 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600775D RID: 30557 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600775E RID: 30558 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAimingSlowdown(bool isAiming, float slow)
		{
			throw null;
		}

		// Token: 0x0600775F RID: 30559 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float ClampSpeed(float speed)
		{
			throw null;
		}

		// Token: 0x170012B4 RID: 4788
		// (get) Token: 0x06007760 RID: 30560 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007761 RID: 30561 RVA: 0x00002050 File Offset: 0x00000250
		public float SprintSpeed
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

		// Token: 0x170012B5 RID: 4789
		// (get) Token: 0x06007762 RID: 30562 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007763 RID: 30563 RVA: 0x00002050 File Offset: 0x00000250
		public float SmoothedCharacterMovementSpeed
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

		// Token: 0x14000156 RID: 342
		// (add) Token: 0x06007764 RID: 30564 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06007765 RID: 30565 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<float, int> OnSmoothedPoseLevelChange
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

		// Token: 0x170012B6 RID: 4790
		// (get) Token: 0x06007766 RID: 30566 RVA: 0x00002050 File Offset: 0x00000250
		public float ActualLinearVelocity
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012B7 RID: 4791
		// (get) Token: 0x06007767 RID: 30567 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007768 RID: 30568 RVA: 0x00002050 File Offset: 0x00000250
		public float SmoothedPoseLevel
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

		// Token: 0x170012B8 RID: 4792
		// (get) Token: 0x06007769 RID: 30569 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600776A RID: 30570 RVA: 0x00002050 File Offset: 0x00000250
		public float SmoothedTilt
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

		// Token: 0x0600776B RID: 30571 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static MovementContext Create(Player player, Func<IAnimator> animatorGetter, Func<ICharacterController> characterControllerGetter, LayerMask groundMask)
		{
			throw null;
		}

		// Token: 0x0600776C RID: 30572 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static TMovementContext Create<TMovementContext>(Player player, Func<IAnimator> animatorGetter, Func<ICharacterController> characterControllerGetter, LayerMask groundMask) where TMovementContext : MovementContext, new()
		{
			throw null;
		}

		// Token: 0x0600776D RID: 30573 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_0()
		{
			throw null;
		}

		// Token: 0x0600776E RID: 30574 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void InitComponents()
		{
			throw null;
		}

		// Token: 0x0600776F RID: 30575 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x06007770 RID: 30576 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Init()
		{
			throw null;
		}

		// Token: 0x06007771 RID: 30577 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void WeightRelatedValuesUpdated()
		{
			throw null;
		}

		// Token: 0x06007772 RID: 30578 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Dispose()
		{
			throw null;
		}

		// Token: 0x06007773 RID: 30579 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitMovementStates(IPlayerStateContainerBehaviour[] playerStates)
		{
			throw null;
		}

		// Token: 0x06007774 RID: 30580 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Flash(ref Vector3 motion)
		{
			throw null;
		}

		// Token: 0x170012B9 RID: 4793
		// (get) Token: 0x06007775 RID: 30581 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007776 RID: 30582 RVA: 0x00002050 File Offset: 0x00000250
		public MovingPlatform Platform
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

		// Token: 0x170012BA RID: 4794
		// (get) Token: 0x06007777 RID: 30583 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007778 RID: 30584 RVA: 0x00002050 File Offset: 0x00000250
		public virtual Vector3 PlatformMotion
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

		// Token: 0x170012BB RID: 4795
		// (get) Token: 0x06007779 RID: 30585 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsOnPlatformWithCooldown
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x14000157 RID: 343
		// (add) Token: 0x0600777A RID: 30586 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600777B RID: 30587 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<CollisionFlags> OnMotionApplied
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

		// Token: 0x0600777C RID: 30588 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ApplyApproachMotion(Vector3 motion, float deltaTime)
		{
			throw null;
		}

		// Token: 0x0600777D RID: 30589 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ApplyMotion(Vector3 motion, float deltaTime)
		{
			throw null;
		}

		// Token: 0x0600777E RID: 30590 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AnimatorStatesLateUpdate()
		{
			throw null;
		}

		// Token: 0x0600777F RID: 30591 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void DirectApplyMotion(Vector3 motion, float deltaTime)
		{
			throw null;
		}

		// Token: 0x06007780 RID: 30592 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x06007781 RID: 30593 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ValidateMotion()
		{
			throw null;
		}

		// Token: 0x06007782 RID: 30594 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8(float deltaTime)
		{
			throw null;
		}

		// Token: 0x06007783 RID: 30595 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ApplyRotation(Quaternion rotation)
		{
			throw null;
		}

		// Token: 0x06007784 RID: 30596 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateStationaryDeltaAngle()
		{
			throw null;
		}

		// Token: 0x06007785 RID: 30597 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void UpdateDeltaAngle()
		{
			throw null;
		}

		// Token: 0x06007786 RID: 30598 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void UpdateAnimatorRotationParameters()
		{
			throw null;
		}

		// Token: 0x170012BC RID: 4796
		// (get) Token: 0x06007787 RID: 30599 RVA: 0x00002050 File Offset: 0x00000250
		public Quaternion TransformRotation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012BD RID: 4797
		// (get) Token: 0x06007788 RID: 30600 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007789 RID: 30601 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 TransformPosition
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

		// Token: 0x0600778A RID: 30602 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 InverseTransformPoint(Vector3 vector3)
		{
			throw null;
		}

		// Token: 0x170012BF RID: 4799
		// (get) Token: 0x0600778B RID: 30603 RVA: 0x00002050 File Offset: 0x00000250
		public BifacialTransform PlayerTransform
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012C0 RID: 4800
		// (get) Token: 0x0600778C RID: 30604 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsAI
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600778D RID: 30605 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddRotaionDelta(float rotationDelta)
		{
			throw null;
		}

		// Token: 0x170012C1 RID: 4801
		// (get) Token: 0x0600778E RID: 30606 RVA: 0x00002050 File Offset: 0x00000250
		public float MaxSpeed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012C2 RID: 4802
		// (get) Token: 0x0600778F RID: 30607 RVA: 0x00002050 File Offset: 0x00000250
		public float SprintingSpeed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012C3 RID: 4803
		// (get) Token: 0x06007790 RID: 30608 RVA: 0x00002050 File Offset: 0x00000250
		public float PreviousYaw
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012C4 RID: 4804
		// (get) Token: 0x06007791 RID: 30609 RVA: 0x00002050 File Offset: 0x00000250
		public float HandsToBodyAngle
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012C5 RID: 4805
		// (get) Token: 0x06007792 RID: 30610 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007793 RID: 30611 RVA: 0x00002050 File Offset: 0x00000250
		public float TrunkRotationLimit
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

		// Token: 0x170012C6 RID: 4806
		// (get) Token: 0x06007794 RID: 30612 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007795 RID: 30613 RVA: 0x00002050 File Offset: 0x00000250
		public Vector2 PitchLimit
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

		// Token: 0x170012C7 RID: 4807
		// (get) Token: 0x06007796 RID: 30614 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007797 RID: 30615 RVA: 0x00002050 File Offset: 0x00000250
		public Vector2 MovementDirection
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

		// Token: 0x170012C8 RID: 4808
		// (get) Token: 0x06007798 RID: 30616 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 AbsoluteMovementDirection
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06007799 RID: 30617 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdatePoseAfterProne()
		{
			throw null;
		}

		// Token: 0x0600779A RID: 30618 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool SetPoseLevel(float poseLevel, bool force = false)
		{
			throw null;
		}

		// Token: 0x170012C9 RID: 4809
		// (get) Token: 0x0600779B RID: 30619 RVA: 0x00002050 File Offset: 0x00000250
		public float TransitionSpeed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600779C RID: 30620 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CalculatePoseLevelValues(float poseLevel, float maxPoseLevel, Vector3 characterControllerCenter, float characterControllerSkinWidth, bool prone, out float poseLevelResult, out float characterControllerHeight, out Vector3 characterControllerCenterResult)
		{
			throw null;
		}

		// Token: 0x0600779D RID: 30621 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CalculatePoseLevelValues(float poseLevel, Vector3 characterControllerCenter, float characterControllerSkinWidth, bool prone, out float characterControllerHeight, out Vector3 characterControllerCenterResult)
		{
			throw null;
		}

		// Token: 0x0600779E RID: 30622 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AdjustCharacterController(bool prone)
		{
			throw null;
		}

		// Token: 0x170012CA RID: 4810
		// (get) Token: 0x0600779F RID: 30623 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 PlayerColliderCenter
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060077A0 RID: 30624 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 PlayerColliderCenterOfHeight(float h)
		{
			throw null;
		}

		// Token: 0x060077A1 RID: 30625 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 PlayerColliderPointOnCenterAxis(float relativeHeight)
		{
			throw null;
		}

		// Token: 0x060077A2 RID: 30626 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SmoothPoseLevel(float deltaTime)
		{
			throw null;
		}

		// Token: 0x060077A3 RID: 30627 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual float GetPenetrationDepth(Vector3? axis = null, float extraCastLn = 0f)
		{
			throw null;
		}

		// Token: 0x060077A4 RID: 30628 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual float GetSpherePenetrationDepth(Vector3? axis = null, float radius = 0.1f, float extraCastLn = 0f)
		{
			throw null;
		}

		// Token: 0x060077A5 RID: 30629 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool CanProneTilt(int direction)
		{
			throw null;
		}

		// Token: 0x060077A6 RID: 30630 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool CanRoll(int direction)
		{
			throw null;
		}

		// Token: 0x060077A7 RID: 30631 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CanRoll(int direction, Vector3 shift, Vector3 size)
		{
			throw null;
		}

		// Token: 0x060077A8 RID: 30632 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool HeadBump(float velocity)
		{
			throw null;
		}

		// Token: 0x060077A9 RID: 30633 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool LegacyTwoPointSteadyGroundCheck(Vector3 origin, float castLn)
		{
			throw null;
		}

		// Token: 0x060077AA RID: 30634 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool OverlapOrHasNoGround(float depth, Vector3? axis = null, float width = 0f, float heightDivider = 4f, float extraCastLn = 0f)
		{
			throw null;
		}

		// Token: 0x060077AB RID: 30635 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool HasGround(float depth, Vector3? axis = null, float extraCastLn = 0f)
		{
			throw null;
		}

		// Token: 0x14000158 RID: 344
		// (add) Token: 0x060077AC RID: 30636 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060077AD RID: 30637 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<float> OnTiltChanged
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

		// Token: 0x14000159 RID: 345
		// (add) Token: 0x060077AE RID: 30638 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060077AF RID: 30639 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<float> StationaryTiltChanged
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

		// Token: 0x060077B0 RID: 30640 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBlindFire(float blind)
		{
			throw null;
		}

		// Token: 0x060077B1 RID: 30641 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetTilt(float tilt, bool force = false)
		{
			throw null;
		}

		// Token: 0x170012CB RID: 4811
		// (get) Token: 0x060077B2 RID: 30642 RVA: 0x00002050 File Offset: 0x00000250
		public float CovertMovementVolume
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012CC RID: 4812
		// (get) Token: 0x060077B3 RID: 30643 RVA: 0x00002050 File Offset: 0x00000250
		public int CovertNoiseLevel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012CD RID: 4813
		// (get) Token: 0x060077B4 RID: 30644 RVA: 0x00002050 File Offset: 0x00000250
		public float CovertMovementVolumeBySpeed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012CE RID: 4814
		// (get) Token: 0x060077B5 RID: 30645 RVA: 0x00002050 File Offset: 0x00000250
		public float CovertEquipmentNoise
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060077B6 RID: 30646 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateCovertEfficiency(float speed, bool force = false)
		{
			throw null;
		}

		// Token: 0x060077B7 RID: 30647 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetCharacterMovementSpeed(float characterMovementSpeed, bool force = false)
		{
			throw null;
		}

		// Token: 0x170012CF RID: 4815
		// (get) Token: 0x060077B8 RID: 30648 RVA: 0x00002050 File Offset: 0x00000250
		public float ClampedSpeed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012D0 RID: 4816
		// (get) Token: 0x060077B9 RID: 30649 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060077BA RID: 30650 RVA: 0x00002050 File Offset: 0x00000250
		public float CharacterMovementSpeed
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

		// Token: 0x170012D1 RID: 4817
		// (get) Token: 0x060077BB RID: 30651 RVA: 0x00002050 File Offset: 0x00000250
		public float PoseLevel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012D2 RID: 4818
		// (get) Token: 0x060077BC RID: 30652 RVA: 0x00002050 File Offset: 0x00000250
		public float Tilt
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012D3 RID: 4819
		// (get) Token: 0x060077BD RID: 30653 RVA: 0x00002050 File Offset: 0x00000250
		public Vector2 YawLimit
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012D4 RID: 4820
		// (get) Token: 0x060077BE RID: 30654 RVA: 0x00002050 File Offset: 0x00000250
		public float SurfacePitch
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060077BF RID: 30655 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector2 ClampRotation(Vector2 rotation)
		{
			throw null;
		}

		// Token: 0x170012D5 RID: 4821
		// (get) Token: 0x060077C0 RID: 30656 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060077C1 RID: 30657 RVA: 0x00002050 File Offset: 0x00000250
		public Vector2 Rotation
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

		// Token: 0x170012D6 RID: 4822
		// (get) Token: 0x060077C2 RID: 30658 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 LookDirection
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012D7 RID: 4823
		// (get) Token: 0x060077C3 RID: 30659 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 PlayerRealForward
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012D8 RID: 4824
		// (get) Token: 0x060077C4 RID: 30660 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 PlayerRealRight
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012D9 RID: 4825
		// (get) Token: 0x060077C5 RID: 30661 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060077C6 RID: 30662 RVA: 0x00002050 File Offset: 0x00000250
		public Vector2 PreviousRotation
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

		// Token: 0x060077C7 RID: 30663 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(Vector2 rotation)
		{
			throw null;
		}

		// Token: 0x060077C8 RID: 30664 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10()
		{
			throw null;
		}

		// Token: 0x060077C9 RID: 30665 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11(Vector2 rotation)
		{
			throw null;
		}

		// Token: 0x060077CA RID: 30666 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDirectlyLookRotations(Vector2 current, Vector2 previous)
		{
			throw null;
		}

		// Token: 0x060077CB RID: 30667 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RestorePreviousYaw()
		{
			throw null;
		}

		// Token: 0x170012DA RID: 4826
		// (get) Token: 0x060077CC RID: 30668 RVA: 0x00002050 File Offset: 0x00000250
		public float Yaw
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012DB RID: 4827
		// (get) Token: 0x060077CD RID: 30669 RVA: 0x00002050 File Offset: 0x00000250
		public float Pitch
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012DC RID: 4828
		// (get) Token: 0x060077CE RID: 30670 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060077CF RID: 30671 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsGrounded
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

		// Token: 0x170012DD RID: 4829
		// (get) Token: 0x060077D0 RID: 30672 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060077D1 RID: 30673 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 SurfaceNormal
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

		// Token: 0x170012DE RID: 4830
		// (get) Token: 0x060077D2 RID: 30674 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060077D3 RID: 30675 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 PlayerSurfaceUpAlignNormal
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

		// Token: 0x170012DF RID: 4831
		// (get) Token: 0x060077D4 RID: 30676 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060077D5 RID: 30677 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 Slope
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

		// Token: 0x1400015A RID: 346
		// (add) Token: 0x060077D6 RID: 30678 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060077D7 RID: 30679 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<int, int> OnStepChanged
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

		// Token: 0x170012E0 RID: 4832
		// (get) Token: 0x060077D8 RID: 30680 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 Velocity
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012E1 RID: 4833
		// (get) Token: 0x060077D9 RID: 30681 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060077DA RID: 30682 RVA: 0x00002050 File Offset: 0x00000250
		public int Step
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

		// Token: 0x170012E2 RID: 4834
		// (get) Token: 0x060077DB RID: 30683 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060077DC RID: 30684 RVA: 0x00002050 File Offset: 0x00000250
		public Action PickupAction
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

		// Token: 0x170012E3 RID: 4835
		// (get) Token: 0x060077DD RID: 30685 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060077DE RID: 30686 RVA: 0x00002050 File Offset: 0x00000250
		public Action<bool> PlantAction
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

		// Token: 0x060077DF RID: 30687 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetYawLimit(Vector2 yawLimit)
		{
			throw null;
		}

		// Token: 0x060077E0 RID: 30688 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetRotationLimit(Vector2 yawLimit, Vector2 pitchLimit)
		{
			throw null;
		}

		// Token: 0x060077E1 RID: 30689 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPitchSmoothly(Vector2 pitchLimit)
		{
			throw null;
		}

		// Token: 0x060077E2 RID: 30690 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ManualUpdate(float deltaTime)
		{
			throw null;
		}

		// Token: 0x060077E3 RID: 30691 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LateFixedUpdate()
		{
			throw null;
		}

		// Token: 0x060077E4 RID: 30692 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SmoothPitchLimitations(float deltaTime)
		{
			throw null;
		}

		// Token: 0x060077E5 RID: 30693 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void PreSprintAcceleration(float deltaTime)
		{
			throw null;
		}

		// Token: 0x060077E6 RID: 30694 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SprintAcceleration(float deltaTime)
		{
			throw null;
		}

		// Token: 0x060077E7 RID: 30695 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ProcessSpeedLimits(float deltaTime)
		{
			throw null;
		}

		// Token: 0x060077E8 RID: 30696 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CheckFlying(float deltaTime)
		{
			throw null;
		}

		// Token: 0x060077E9 RID: 30697 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ResetFlying()
		{
			throw null;
		}

		// Token: 0x060077EA RID: 30698 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void DetectSurfaceNormal()
		{
			throw null;
		}

		// Token: 0x170012E5 RID: 4837
		// (get) Token: 0x060077EB RID: 30699 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060077EC RID: 30700 RVA: 0x00002050 File Offset: 0x00000250
		public float FallHeight
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

		// Token: 0x170012E6 RID: 4838
		// (get) Token: 0x060077ED RID: 30701 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060077EE RID: 30702 RVA: 0x00002050 File Offset: 0x00000250
		public float JumpHeight
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

		// Token: 0x060077EF RID: 30703 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void UpdateGroundCollision(float deltaTime)
		{
			throw null;
		}

		// Token: 0x060077F0 RID: 30704 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual bool GroundCollisionRaycast(Ray ray, float groundDistance, float additionSearch, float deltaTime, out RaycastHit groundHit)
		{
			throw null;
		}

		// Token: 0x060077F1 RID: 30705 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected bool GroundCollisionSpherecast(Ray ray, float radius, float groundDistance, float additionSearch, out RaycastHit groundHit)
		{
			throw null;
		}

		// Token: 0x060077F2 RID: 30706 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_12(float deltaTime)
		{
			throw null;
		}

		// Token: 0x060077F3 RID: 30707 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13(float deltaTime)
		{
			throw null;
		}

		// Token: 0x060077F4 RID: 30708 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_14(float smoothDiff, float deltaTime)
		{
			throw null;
		}

		// Token: 0x060077F5 RID: 30709 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_15(float smoothDiff, float deltaTime)
		{
			throw null;
		}

		// Token: 0x060077F6 RID: 30710 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_16(float deltaTime)
		{
			throw null;
		}

		// Token: 0x170012E7 RID: 4839
		// (get) Token: 0x060077F7 RID: 30711 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsSprintEnabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060077F8 RID: 30712 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector2 ApplyExternalSense(Vector2 deltaRotation)
		{
			throw null;
		}

		// Token: 0x060077F9 RID: 30713 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsHoldingBreath()
		{
			throw null;
		}

		// Token: 0x060077FA RID: 30714 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EnableSprint(bool enable)
		{
			throw null;
		}

		// Token: 0x060077FB RID: 30715 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TryJump()
		{
			throw null;
		}

		// Token: 0x060077FC RID: 30716 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryVaulting()
		{
			throw null;
		}

		// Token: 0x060077FD RID: 30717 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnVault()
		{
			throw null;
		}

		// Token: 0x060077FE RID: 30718 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClimb()
		{
			throw null;
		}

		// Token: 0x170012E8 RID: 4840
		// (get) Token: 0x060077FF RID: 30719 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007800 RID: 30720 RVA: 0x00002050 File Offset: 0x00000250
		public float VaultingSpeed
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

		// Token: 0x06007801 RID: 30721 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_17(Vector2 speedRange, EVaultingStrategy strategy)
		{
			throw null;
		}

		// Token: 0x06007802 RID: 30722 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HoldBreath(bool enable)
		{
			throw null;
		}

		// Token: 0x06007803 RID: 30723 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OverrideState(BaseMovementState enteredState)
		{
			throw null;
		}

		// Token: 0x06007804 RID: 30724 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ExitOverridenState()
		{
			throw null;
		}

		// Token: 0x06007805 RID: 30725 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ProcessStateEnter(BaseMovementState enteredState)
		{
			throw null;
		}

		// Token: 0x06007806 RID: 30726 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ToggleFirearmAimByBodyAction()
		{
			throw null;
		}

		// Token: 0x06007807 RID: 30727 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_1(BaseMovementState enteredState, BaseMovementState previousState)
		{
			throw null;
		}

		// Token: 0x06007808 RID: 30728 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPickupInHands(bool isPickup)
		{
			throw null;
		}

		// Token: 0x06007809 RID: 30729 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSidebackSpeed(float value)
		{
			throw null;
		}

		// Token: 0x0600780A RID: 30730 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSidestep(float value)
		{
			throw null;
		}

		// Token: 0x0600780B RID: 30731 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBlindFireFloat(float value)
		{
			throw null;
		}

		// Token: 0x0600780C RID: 30732 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetSidestep()
		{
			throw null;
		}

		// Token: 0x0600780D RID: 30733 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InteractWith(WorldInteractiveObject interactiveObject, InteractionResult interactionResult, Action callback)
		{
			throw null;
		}

		// Token: 0x0600780E RID: 30734 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ExecuteInteraction(WorldInteractiveObject interactiveObject, InteractionResult interactionResult)
		{
			throw null;
		}

		// Token: 0x0600780F RID: 30735 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void StartInteraction(WorldInteractiveObject interactive, InteractionResult interactionResult, Action callback)
		{
			throw null;
		}

		// Token: 0x06007810 RID: 30736 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_18(WorldInteractiveObject interactive, InteractionResult interactionResult, Action callback)
		{
			throw null;
		}

		// Token: 0x06007811 RID: 30737 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReleaseDoorIfInteractingWithOne()
		{
			throw null;
		}

		// Token: 0x06007812 RID: 30738 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 VelocityProjectionOnRealForward()
		{
			throw null;
		}

		// Token: 0x06007813 RID: 30739 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StopAnyInteractions()
		{
			throw null;
		}

		// Token: 0x06007814 RID: 30740 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetHandProgress()
		{
			throw null;
		}

		// Token: 0x06007815 RID: 30741 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetInteractInHands(bool isInteracting, int animationId = 1)
		{
			throw null;
		}

		// Token: 0x06007816 RID: 30742 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetIKInteraction(GripPose grip)
		{
			throw null;
		}

		// Token: 0x06007817 RID: 30743 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EndIkInteraction()
		{
			throw null;
		}

		// Token: 0x06007818 RID: 30744 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RestoreDefaultAlignment(float normalTime)
		{
			throw null;
		}

		// Token: 0x06007819 RID: 30745 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AlignToSurface(float deltaTime, Vector3? axis = null)
		{
			throw null;
		}

		// Token: 0x0600781A RID: 30746 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TwoPointAlignment(Vector3 anchorPoint1, Vector3 anchorPoint2, float deltaTime)
		{
			throw null;
		}

		// Token: 0x0600781B RID: 30747 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnePointAlignment(Vector3 normal, float deltaTime)
		{
			throw null;
		}

		// Token: 0x170012E9 RID: 4841
		// (get) Token: 0x0600781C RID: 30748 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 ForwardProjectionOnSurface
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012EA RID: 4842
		// (get) Token: 0x0600781D RID: 30749 RVA: 0x00002050 File Offset: 0x00000250
		public virtual bool CanProne
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600781E RID: 30750 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_19(Vector3 test)
		{
			throw null;
		}

		// Token: 0x170012EB RID: 4843
		// (get) Token: 0x0600781F RID: 30751 RVA: 0x00002050 File Offset: 0x00000250
		public virtual bool CanSprint
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012EC RID: 4844
		// (get) Token: 0x06007820 RID: 30752 RVA: 0x00002050 File Offset: 0x00000250
		public virtual bool CanJump
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012ED RID: 4845
		// (get) Token: 0x06007821 RID: 30753 RVA: 0x00002050 File Offset: 0x00000250
		public virtual bool CanWalk
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012EE RID: 4846
		// (get) Token: 0x06007822 RID: 30754 RVA: 0x00002050 File Offset: 0x00000250
		public virtual bool CanMoveInProne
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012EF RID: 4847
		// (get) Token: 0x06007823 RID: 30755 RVA: 0x00002050 File Offset: 0x00000250
		public bool CanSit
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06007824 RID: 30756 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool CanStandAt(float h)
		{
			throw null;
		}

		// Token: 0x170012F0 RID: 4848
		// (get) Token: 0x06007825 RID: 30757 RVA: 0x00002050 File Offset: 0x00000250
		public float Overlap
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012F1 RID: 4849
		// (get) Token: 0x06007826 RID: 30758 RVA: 0x00002050 File Offset: 0x00000250
		public float OverlapDepth
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012F2 RID: 4850
		// (get) Token: 0x06007827 RID: 30759 RVA: 0x00002050 File Offset: 0x00000250
		public Player.BetterValueBlender IK
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06007828 RID: 30760 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SpawnKeyInHands(Item item, string parentBone)
		{
			throw null;
		}

		// Token: 0x06007829 RID: 30761 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveKeyFromHand()
		{
			throw null;
		}

		// Token: 0x0600782A RID: 30762 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsHandsProcessing()
		{
			throw null;
		}

		// Token: 0x0600782B RID: 30763 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LockedDoorOpened(bool breached)
		{
			throw null;
		}

		// Token: 0x170012F3 RID: 4851
		// (get) Token: 0x0600782C RID: 30764 RVA: 0x00002050 File Offset: 0x00000250
		public Dictionary<EPlayerState, BaseMovementState> States
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600782D RID: 30765 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected BaseMovementState GetNewStateFabric(EPlayerState name, int stateNameHash, bool createUnique)
		{
			throw null;
		}

		// Token: 0x0600782E RID: 30766 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected BaseMovementState GetNewAIStateFabric(EPlayerState name, int stateNameHash, bool createUnique)
		{
			throw null;
		}

		// Token: 0x0600782F RID: 30767 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_20(IPlayerStateContainerBehaviour[] states)
		{
			throw null;
		}

		// Token: 0x06007830 RID: 30768 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetStateHashTableIndex(int hash)
		{
			throw null;
		}

		// Token: 0x06007831 RID: 30769 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetStateHash(int index)
		{
			throw null;
		}

		// Token: 0x06007832 RID: 30770 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public EPlayerState GetStateNameByHash(int hash)
		{
			throw null;
		}

		// Token: 0x06007833 RID: 30771 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static EPlayerState GetStateNameByIndex(int index)
		{
			throw null;
		}

		// Token: 0x170012F4 RID: 4852
		// (get) Token: 0x06007834 RID: 30772 RVA: 0x00002050 File Offset: 0x00000250
		public int CurrentAnimatorStateIndex
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06007835 RID: 30773 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual BaseMovementState GetNewState(EPlayerState name, bool isAI = false)
		{
			throw null;
		}

		// Token: 0x06007836 RID: 30774 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FovCompensationOn(bool on)
		{
			throw null;
		}

		// Token: 0x06007837 RID: 30775 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ProjectMotionToSurface(ref Vector3 motion)
		{
			throw null;
		}

		// Token: 0x170012F5 RID: 4853
		// (get) Token: 0x06007838 RID: 30776 RVA: 0x00002050 File Offset: 0x00000250
		public IPlayerStateContainerBehaviour[] GetInitedMovementState
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06007839 RID: 30777 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ApplyGravity(ref Vector3 motion, float deltaTime, bool stickToGround)
		{
			throw null;
		}

		// Token: 0x170012F6 RID: 4854
		// (get) Token: 0x0600783A RID: 30778 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 POMOffset
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600783B RID: 30779 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void LimitMotionXZ(ref Vector3 motion, float deltaTime, float threshold = 0.0001f)
		{
			throw null;
		}

		// Token: 0x0600783C RID: 30780 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 RotationOverlapPrediction(Vector3 motion, Quaternion rotation, Transform rotationPivot)
		{
			throw null;
		}

		// Token: 0x0600783D RID: 30781 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsAbleToRotate(Vector3 motion)
		{
			throw null;
		}

		// Token: 0x0600783E RID: 30782 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool IsAbleToRotate(Vector3 motion, float deltaYaw, Quaternion predictionRotation, Transform pivot, out ECantRotate cause)
		{
			throw null;
		}

		// Token: 0x0600783F RID: 30783 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void LimitProneMotion(ref Vector3 motion)
		{
			throw null;
		}

		// Token: 0x06007840 RID: 30784 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPatrol(bool b)
		{
			throw null;
		}

		// Token: 0x06007841 RID: 30785 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RestorePreviousPatrol()
		{
			throw null;
		}

		// Token: 0x170012F7 RID: 4855
		// (get) Token: 0x06007842 RID: 30786 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007843 RID: 30787 RVA: 0x00002050 File Offset: 0x00000250
		public bool BlockFirearms
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

		// Token: 0x06007844 RID: 30788 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetSpeedAfterSprint()
		{
			throw null;
		}

		// Token: 0x170012F8 RID: 4856
		// (get) Token: 0x06007845 RID: 30789 RVA: 0x00002050 File Offset: 0x00000250
		public Quaternion AnimatorDeltaRotation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012F9 RID: 4857
		// (get) Token: 0x06007846 RID: 30790 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 PlayerAnimatorDeltaPosition
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012FA RID: 4858
		// (set) Token: 0x06007847 RID: 30791 RVA: 0x00002050 File Offset: 0x00000250
		public float PlayerAnimatorTransitionSpeed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06007848 RID: 30792 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RaiseChangeSpeedEvent()
		{
			throw null;
		}

		// Token: 0x06007849 RID: 30793 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void IgnoreInteractionCollision(Collider c2, bool ignore)
		{
			throw null;
		}

		// Token: 0x0600784A RID: 30794 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator UnignoreCollision()
		{
			throw null;
		}

		// Token: 0x0600784B RID: 30795 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnControllerColliderHit(ControllerColliderHit hit)
		{
			throw null;
		}

		// Token: 0x0600784C RID: 30796 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected string ControllerColliderHits()
		{
			throw null;
		}

		// Token: 0x0600784D RID: 30797 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBlindFire(int b)
		{
			throw null;
		}

		// Token: 0x0600784E RID: 30798 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeSpeedLimit(float speedDelta, Player.ESpeedLimit cause)
		{
			throw null;
		}

		// Token: 0x0600784F RID: 30799 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeSpeedLimit(float speedDelta, Player.ESpeedLimit cause, float duration)
		{
			throw null;
		}

		// Token: 0x06007850 RID: 30800 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RotateFail(ECantRotate cantRotate)
		{
			throw null;
		}

		// Token: 0x06007851 RID: 30801 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PlayerAnimatorEnableInert(bool enabled)
		{
			throw null;
		}

		// Token: 0x06007852 RID: 30802 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PlayerAnimatorEnableSprint(bool enabled, bool dontChangeLeftStanceValue = false)
		{
			throw null;
		}

		// Token: 0x06007853 RID: 30803 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PlayerAnimatorSetSprintToIdleSpeed(float value)
		{
			throw null;
		}

		// Token: 0x06007854 RID: 30804 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PlayerAnimatorEnableKick(bool enabled)
		{
			throw null;
		}

		// Token: 0x06007855 RID: 30805 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PlayerAnimatorEnableLanding(bool enabled)
		{
			throw null;
		}

		// Token: 0x06007856 RID: 30806 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PlayerAnimatorEnableJump(bool enabled)
		{
			throw null;
		}

		// Token: 0x06007857 RID: 30807 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PlayerAnimatorEnableLoot(bool enabled)
		{
			throw null;
		}

		// Token: 0x06007858 RID: 30808 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PlayerAnimatorSetAimAngle(float movementContextPitch)
		{
			throw null;
		}

		// Token: 0x06007859 RID: 30809 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PlayerAnimatorSetDeltaRotation(float movementContextPitch)
		{
			throw null;
		}

		// Token: 0x0600785A RID: 30810 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PlayerAnimatorEnableFallingDown(bool enabled)
		{
			throw null;
		}

		// Token: 0x0600785B RID: 30811 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PlayerAnimatorEnableProneReload(bool enabled)
		{
			throw null;
		}

		// Token: 0x0600785C RID: 30812 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PlayerAnimatorSetDiscreteDirection(EMovementDirection discreteDirection)
		{
			throw null;
		}

		// Token: 0x0600785D RID: 30813 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PlayerAnimatorEnableProne(bool enabled)
		{
			throw null;
		}

		// Token: 0x0600785E RID: 30814 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PlayerAnimatorSetCharacterMovementSpeed(float smoothedCharacterMovementSpeed)
		{
			throw null;
		}

		// Token: 0x0600785F RID: 30815 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PlayerAnimatorSetPoseLevel(float smoothedPoseLevel)
		{
			throw null;
		}

		// Token: 0x06007860 RID: 30816 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PlayerAnimatorSetTilt(float smoothedTilt)
		{
			throw null;
		}

		// Token: 0x06007861 RID: 30817 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PlayerAnimatorSetBlindFire(float blindFire)
		{
			throw null;
		}

		// Token: 0x06007862 RID: 30818 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PlayerAnimatorSetMovementDirection(Vector2 movementDirection)
		{
			throw null;
		}

		// Token: 0x06007863 RID: 30819 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PlayerAnimatorSetStep(int step)
		{
			throw null;
		}

		// Token: 0x06007864 RID: 30820 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PlayerAnimatorSetFallingDownFloat(float val)
		{
			throw null;
		}

		// Token: 0x06007865 RID: 30821 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PlayerAnimatorSetInteraction(bool isInteracting, bool approached = false)
		{
			throw null;
		}

		// Token: 0x06007866 RID: 30822 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PlayerAnimatorSetKickSucceed(bool nextBreachResult)
		{
			throw null;
		}

		// Token: 0x06007867 RID: 30823 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PlayerAnimatorSetDoorBreak(bool isInteracting, bool approached = false)
		{
			throw null;
		}

		// Token: 0x06007868 RID: 30824 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PlayerAnimatorSetDeflected(bool deflected)
		{
			throw null;
		}

		// Token: 0x06007869 RID: 30825 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PlayerAnimatorSetSwingSpeed(float speed)
		{
			throw null;
		}

		// Token: 0x0600786A RID: 30826 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayerAnimatorSetWeaponId(PlayerAnimator.EWeaponAnimationType index)
		{
			throw null;
		}

		// Token: 0x0600786B RID: 30827 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayerAnimatorSetApproached(bool b)
		{
			throw null;
		}

		// Token: 0x0600786C RID: 30828 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayerAnimatorSetStationary(bool b)
		{
			throw null;
		}

		// Token: 0x0600786D RID: 30829 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayerAnimatorSetStationaryAnimation(int index)
		{
			throw null;
		}

		// Token: 0x0600786E RID: 30830 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayerAnimatorSetObstacleHeight(float height)
		{
			throw null;
		}

		// Token: 0x0600786F RID: 30831 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayerAnimatorSetObstacleLength(float length)
		{
			throw null;
		}

		// Token: 0x06007870 RID: 30832 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayerAnimatorSetDoVault(bool doVault)
		{
			throw null;
		}

		// Token: 0x06007871 RID: 30833 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayerAnimatorSetDoClimb(bool doClimb)
		{
			throw null;
		}

		// Token: 0x06007872 RID: 30834 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayerAnimatorSetAbsoluteForwardVelocity(float velocity)
		{
			throw null;
		}

		// Token: 0x06007873 RID: 30835 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayerAnimatorSetBehindObstacleRatio(float height)
		{
			throw null;
		}

		// Token: 0x06007874 RID: 30836 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float PlayerAnimatorGetObstacleLength()
		{
			throw null;
		}

		// Token: 0x06007875 RID: 30837 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float PlayerAnimatorGetObstacleHeight()
		{
			throw null;
		}

		// Token: 0x06007876 RID: 30838 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayerAnimatorSetIsVaulting(bool isVaulting)
		{
			throw null;
		}

		// Token: 0x06007877 RID: 30839 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool PlayerAnimatorGetIsVaulting()
		{
			throw null;
		}

		// Token: 0x06007878 RID: 30840 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool PlayerAnimatorIsJumpSetted()
		{
			throw null;
		}

		// Token: 0x06007879 RID: 30841 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateVaultingSpeedLimit()
		{
			throw null;
		}

		// Token: 0x0600787A RID: 30842 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsAnimatorInTransitionState(int layer)
		{
			throw null;
		}

		// Token: 0x0600787B RID: 30843 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayerAnimatorPointOfView(EPointOfView pointOfView)
		{
			throw null;
		}

		// Token: 0x170012FB RID: 4859
		// (get) Token: 0x0600787C RID: 30844 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsAnimatorInteractionOn
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012FC RID: 4860
		// (get) Token: 0x0600787D RID: 30845 RVA: 0x00002050 File Offset: 0x00000250
		public virtual Error CanInteract
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170012FD RID: 4861
		// (set) Token: 0x0600787E RID: 30846 RVA: 0x00002050 File Offset: 0x00000250
		public virtual bool StateLocksInventory
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170012FE RID: 4862
		// (get) Token: 0x0600787F RID: 30847 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007880 RID: 30848 RVA: 0x00002050 File Offset: 0x00000250
		public StationaryWeapon StationaryWeapon
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

		// Token: 0x170012FF RID: 4863
		// (get) Token: 0x06007881 RID: 30849 RVA: 0x00002050 File Offset: 0x00000250
		public bool isStationaryWeaponInHands
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001300 RID: 4864
		// (get) Token: 0x06007882 RID: 30850 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007883 RID: 30851 RVA: 0x00002050 File Offset: 0x00000250
		public EMovementDirection DiscreteDirection
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

		// Token: 0x17001301 RID: 4865
		// (get) Token: 0x06007884 RID: 30852 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007885 RID: 30853 RVA: 0x00002050 File Offset: 0x00000250
		public float PoseInertia
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

		// Token: 0x17001302 RID: 4866
		// (get) Token: 0x06007886 RID: 30854 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007887 RID: 30855 RVA: 0x00002050 File Offset: 0x00000250
		public float WalkInertia
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

		// Token: 0x17001303 RID: 4867
		// (get) Token: 0x06007888 RID: 30856 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007889 RID: 30857 RVA: 0x00002050 File Offset: 0x00000250
		public float SprintBrakeInertia
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

		// Token: 0x17001304 RID: 4868
		// (get) Token: 0x0600788A RID: 30858 RVA: 0x00002050 File Offset: 0x00000250
		public float DeltaRotation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600788B RID: 30859 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ToggleBlockInputPlayerRotation(bool block)
		{
			throw null;
		}

		// Token: 0x0600788C RID: 30860 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetInventory()
		{
			throw null;
		}

		// Token: 0x0600788D RID: 30861 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CancelInventoryAnimation()
		{
			throw null;
		}

		// Token: 0x0600788E RID: 30862 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetProjectionOnRealForwardSurface(Vector3 point)
		{
			throw null;
		}

		// Token: 0x0600788F RID: 30863 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetStationaryWeapon(Action<Player.AbstractHandsController, Player.AbstractHandsController> callback)
		{
			throw null;
		}

		// Token: 0x06007890 RID: 30864 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void DropStationary(GStruct168.EStationaryCommand command)
		{
			throw null;
		}

		// Token: 0x1400015B RID: 347
		// (add) Token: 0x06007891 RID: 30865 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06007892 RID: 30866 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<Player.AbstractHandsController, Player.AbstractHandsController> OnHandsControllerChanged
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x1400015C RID: 348
		// (add) Token: 0x06007893 RID: 30867 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06007894 RID: 30868 RVA: 0x00002050 File Offset: 0x00000250
		public event Action HandsChangingEvent
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x06007895 RID: 30869 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateStateValues(ref float stateSensitivity, ref float stateClamp)
		{
			throw null;
		}

		// Token: 0x06007896 RID: 30870 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AssignAnimatorPose(AnimatorPose animatorPose)
		{
			throw null;
		}

		// Token: 0x06007897 RID: 30871 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPOMCollider(PlayerOverlapManager.EExtrusionCollider collider)
		{
			throw null;
		}

		// Token: 0x06007898 RID: 30872 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CreateSpeedLimiter(GClass1735.Config config)
		{
			throw null;
		}

		// Token: 0x06007899 RID: 30873 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual GClass1735 SpeedLimiterBuilder(GClass1735.Config config)
		{
			throw null;
		}

		// Token: 0x0600789A RID: 30874 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void UpdateCharacterControllerSpeedLimit()
		{
			throw null;
		}

		// Token: 0x0600789B RID: 30875 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_21(float maxSpeed)
		{
			throw null;
		}

		// Token: 0x0600789C RID: 30876 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_22()
		{
			throw null;
		}

		// Token: 0x0600789D RID: 30877 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetCanUsePropState()
		{
			throw null;
		}

		// Token: 0x0600789E RID: 30878 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetUpDiscreteDirection(EMovementDirection direction)
		{
			throw null;
		}

		// Token: 0x0600789F RID: 30879 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateSprintInertia()
		{
			throw null;
		}

		// Token: 0x060078A0 RID: 30880 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SubscribeToSprintResetAction()
		{
			throw null;
		}

		// Token: 0x060078A1 RID: 30881 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SprintExitDelegate(EPlayerState previousState, EPlayerState nextState)
		{
			throw null;
		}

		// Token: 0x17001305 RID: 4869
		// (get) Token: 0x060078A2 RID: 30882 RVA: 0x00002050 File Offset: 0x00000250
		public WorldInteractiveObject InteractionDoor
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001306 RID: 4870
		// (get) Token: 0x060078A3 RID: 30883 RVA: 0x00002050 File Offset: 0x00000250
		public InteractionResult InteractionDoorResult
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060078A4 RID: 30884 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_23(bool enable)
		{
			throw null;
		}

		// Token: 0x060078A5 RID: 30885 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_24()
		{
			throw null;
		}

		// Token: 0x17001307 RID: 4871
		// (get) Token: 0x060078A6 RID: 30886 RVA: 0x00002050 File Offset: 0x00000250
		Vector3 GInterface190.MovementDirection
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001308 RID: 4872
		// (get) Token: 0x060078A7 RID: 30887 RVA: 0x00002050 File Offset: 0x00000250
		public Transform VaultingGridRoot
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001309 RID: 4873
		// (get) Token: 0x060078A8 RID: 30888 RVA: 0x00002050 File Offset: 0x00000250
		public bool UsingMedicineOrFood
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060078A9 RID: 30889 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_25()
		{
			throw null;
		}

		// Token: 0x060078AA RID: 30890 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_26(EPhysicalCondition flag, ref MovementContext.Struct236 struct236_0)
		{
			throw null;
		}

		// Token: 0x060078AB RID: 30891 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_27()
		{
			throw null;
		}

		// Token: 0x060078AC RID: 30892 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector2 method_28()
		{
			throw null;
		}

		// Token: 0x060078AD RID: 30893 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_29()
		{
			throw null;
		}

		// Token: 0x060078AE RID: 30894 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_30()
		{
			throw null;
		}

		// Token: 0x060078AF RID: 30895 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_31()
		{
			throw null;
		}

		// Token: 0x04007D1F RID: 32031
		private float _slopeTreshold;

		// Token: 0x04007D20 RID: 32032
		protected Player _player;

		// Token: 0x04007D21 RID: 32033
		private bool _isBot;

		// Token: 0x04007D22 RID: 32034
		private Func<ICharacterController> _characterControllerGetter;

		// Token: 0x04007D23 RID: 32035
		protected BifacialTransform _playerTransform;

		// Token: 0x04007D24 RID: 32036
		protected PlayerAnimator _playerAnimator;

		// Token: 0x04007D25 RID: 32037
		public GStruct197 InteractionInfo;

		// Token: 0x04007D26 RID: 32038
		public BaseMovementState OverridenState;

		// Token: 0x04007D27 RID: 32039
		public BaseMovementState PickUpState;

		// Token: 0x04007D28 RID: 32040
		public BaseMovementState PlantState;

		// Token: 0x04007D29 RID: 32041
		public int BlindFire;

		// Token: 0x04007D2A RID: 32042
		public bool IgnoreDeltaMovement;

		// Token: 0x04007D2B RID: 32043
		public float FreefallTime;

		// Token: 0x04007D2C RID: 32044
		private EMovementDirection _discreteDirection;

		// Token: 0x04007D2D RID: 32045
		private float _smoothedPoseLevel;

		// Token: 0x04007D2E RID: 32046
		private float _poseLevel;

		// Token: 0x04007D2F RID: 32047
		public bool CanSlope;

		// Token: 0x04007D30 RID: 32048
		protected float _handsToBodyAngle;

		// Token: 0x04007D31 RID: 32049
		private float _smoothedCharacterMovementSpeed;

		// Token: 0x04007D32 RID: 32050
		private float _sprintSpeed;

		// Token: 0x04007D33 RID: 32051
		private float _tilt;

		// Token: 0x04007D34 RID: 32052
		private float _smoothedTilt;

		// Token: 0x04007D35 RID: 32053
		private int _step;

		// Token: 0x04007D36 RID: 32054
		private Vector2 _movementDirection;

		// Token: 0x04007D37 RID: 32055
		private Vector2 _rotation;

		// Token: 0x04007D38 RID: 32056
		private Vector2 _previousRotation;

		// Token: 0x04007D39 RID: 32057
		private IObstacleCollisionFacade _obstacleCollisionFacade;

		// Token: 0x04007D3B RID: 32059
		protected RaycastHitData _groundHit;

		// Token: 0x04007D3C RID: 32060
		public float CheckGroundedRayDistance;

		// Token: 0x04007D3D RID: 32061
		public float CheckGroundedCastedSphereContraction;

		// Token: 0x04007D3E RID: 32062
		private List<Collider> _ignoredColliders;

		// Token: 0x04007D3F RID: 32063
		private Collider[] _coroutineColliders;

		// Token: 0x04007D40 RID: 32064
		private float _lastSpeedCovertCheck;

		// Token: 0x04007D41 RID: 32065
		private float _nextStepNoise;

		// Token: 0x04007D42 RID: 32066
		private float _nextJumpNoise;

		// Token: 0x04007D43 RID: 32067
		[CanBeNull]
		protected GClass1735 _speedLimiter;

		// Token: 0x04007D44 RID: 32068
		protected LayerMask _groundMask;

		// Token: 0x04007D45 RID: 32069
		private LayerMask _groundMaskPlusWater;

		// Token: 0x04007D46 RID: 32070
		private LayerMask _groundMaskPlusPlayer;

		// Token: 0x04007D47 RID: 32071
		private int _grounderMask;

		// Token: 0x04007D48 RID: 32072
		private Vector2 _yawLimit;

		// Token: 0x04007D49 RID: 32073
		private Vector2 _pitchLimit;

		// Token: 0x04007D4A RID: 32074
		private Vector2 _pitchTargetLimit;

		// Token: 0x04007D4B RID: 32075
		private Vector3 _prevSecPos;

		// Token: 0x04007D4C RID: 32076
		private float _straightenTimer;

		// Token: 0x04007D4D RID: 32077
		public const float TIME_TO_STRAIGHTEN_UP = 2f;

		// Token: 0x04007D4E RID: 32078
		private const float CC_PRONE_STEP_OFFSET = 0.15f;

		// Token: 0x04007D4F RID: 32079
		private const float CC_NORMAL_STEP_OFFSET = 0.25f;

		// Token: 0x04007D50 RID: 32080
		private const float CC_PRONE_SLOPLE_LIMIT = 45f;

		// Token: 0x04007D51 RID: 32081
		private const float CC_NORMAL_SLOPLE_LIMIT = 60f;

		// Token: 0x04007D52 RID: 32082
		public const float COVERT_MOVEMENT_THRESHOLD = 0.4f;

		// Token: 0x04007D53 RID: 32083
		public const float COVERT_MOVEMENT_BLEND_RANGE = 0.2f;

		// Token: 0x04007D54 RID: 32084
		public float CovertEfficiency;

		// Token: 0x04007D55 RID: 32085
		public bool SoftSurface;

		// Token: 0x04007D56 RID: 32086
		private bool _patrolStatus;

		// Token: 0x04007D57 RID: 32087
		private float _relativeSpeed;

		// Token: 0x04007D59 RID: 32089
		private Action _unsubFromSprintExit;

		// Token: 0x04007D5B RID: 32091
		private EPhysicalCondition _physicalCondition;

		// Token: 0x04007D5C RID: 32092
		protected readonly Collider[] _overlapColliders;

		// Token: 0x04007D5F RID: 32095
		public bool NextBreachResult;

		// Token: 0x04007D60 RID: 32096
		private bool _speedLimitIsDirty;

		// Token: 0x04007D63 RID: 32099
		public float LevelOnApproachStart;

		// Token: 0x04007D65 RID: 32101
		private Action _unsubscribeOnStrengthSkillLevelChanged;

		// Token: 0x04007D66 RID: 32102
		private LeftStanceController _leftStanceController;

		// Token: 0x04007D67 RID: 32103
		private ValueTuple<Player.ESpeedLimit, float> _nextSpeedLimitToExpire;

		// Token: 0x04007D68 RID: 32104
		private bool _isInPronePose;

		// Token: 0x04007D69 RID: 32105
		private bool _isAutoVaultingEnabled;

		// Token: 0x04007D6E RID: 32110
		public BindableState<bool> CanUseProp;

		// Token: 0x04007D70 RID: 32112
		private int _currentClientAnimatorStateIndex;

		// Token: 0x04007D71 RID: 32113
		public WorldInteractiveObject.GStruct385 InteractionParameters;

		// Token: 0x04007D73 RID: 32115
		private float _timeSinceLastJump;

		// Token: 0x04007D74 RID: 32116
		private float _inertiaAppliedTime;

		// Token: 0x04007D75 RID: 32117
		private float _levelOnJumpEnd;

		// Token: 0x04007D76 RID: 32118
		private float _speedOnJumpEnd;

		// Token: 0x04007D77 RID: 32119
		private RaycastHit _predictionHit;

		// Token: 0x04007D78 RID: 32120
		protected float TiltInertia;

		// Token: 0x04007D79 RID: 32121
		private float _maxTiltStep;

		// Token: 0x04007D7A RID: 32122
		private float _tiltStepMultiplier;

		// Token: 0x04007D7B RID: 32123
		private float _prevTilt;

		// Token: 0x04007D7C RID: 32124
		private bool _isImpostorCastTried;

		// Token: 0x04007D7D RID: 32125
		private GClass684 _impostorCC;

		// Token: 0x04007D7E RID: 32126
		private Dictionary<Player.ESpeedLimit, float> _speedLimits;

		// Token: 0x04007D7F RID: 32127
		private Dictionary<Player.ESpeedLimit, float> _speedLimitTimings;

		// Token: 0x04007D80 RID: 32128
		private List<ObstacleCollider> _enteredObstacles;

		// Token: 0x04007D82 RID: 32130
		private MovingPlatform _platform;

		// Token: 0x04007D84 RID: 32132
		public Quaternion PlatformRotation;

		// Token: 0x04007D85 RID: 32133
		private bool _isOnPlatform;

		// Token: 0x04007D86 RID: 32134
		private float _getOffFromPlatformTime;

		// Token: 0x04007D87 RID: 32135
		private const float GET_OFF_FROM_PLATFORM_COOLDOWN = 2f;

		// Token: 0x04007D88 RID: 32136
		public Vector3 LastBlendMotionDelta;

		// Token: 0x04007D89 RID: 32137
		public Vector3 InputMotion;

		// Token: 0x04007D8A RID: 32138
		public Vector3 InputMotionBeforeLimit;

		// Token: 0x04007D8B RID: 32139
		private int _motionFrame;

		// Token: 0x04007D8D RID: 32141
		private bool _scheduleDirectApplyMotion;

		// Token: 0x04007D8E RID: 32142
		private Vector3 _scheduledMotion;

		// Token: 0x04007D8F RID: 32143
		private float _scheduledDeltaTime;

		// Token: 0x04007D90 RID: 32144
		private bool _impostorCCLateUpdRequested;

		// Token: 0x04007D91 RID: 32145
		public Vector3 PreviousPosition;

		// Token: 0x04007D92 RID: 32146
		public const float HEIGHT_FOR_PRONE = 0.3f;

		// Token: 0x04007D93 RID: 32147
		public const float HEIGHT_FROM_CROUCH = 1.2f;

		// Token: 0x04007D94 RID: 32148
		public const float HEIGHT_TO_STAND = 1.6f;

		// Token: 0x04007D95 RID: 32149
		public static readonly Vector2 CCCenterPoseLevel;

		// Token: 0x04007D96 RID: 32150
		public const float CC_CENTER_POSE_LEVEL_FOR_PRONE = 0.35f;

		// Token: 0x04007D97 RID: 32151
		private float _accumulatedDeltaPose;

		// Token: 0x04007D9B RID: 32155
		private Vector2 _myRotation;

		// Token: 0x04007D9C RID: 32156
		private Quaternion _myTransformRotation;

		// Token: 0x04007D9D RID: 32157
		private GClass730 _averageRotationX;

		// Token: 0x04007D9E RID: 32158
		private Vector3 _lookDirection;

		// Token: 0x04007D9F RID: 32159
		private Vector3 _playerRealForward;

		// Token: 0x04007DA0 RID: 32160
		private bool _previousGroundResult;

		// Token: 0x04007DA1 RID: 32161
		private bool _isGrounded;

		// Token: 0x04007DA4 RID: 32164
		private RollingMedian NormalDotHistory;

		// Token: 0x04007DA5 RID: 32165
		private List<ControllerColliderHit> CCHits;

		// Token: 0x04007DA6 RID: 32166
		private List<ControllerColliderHit> CCAllHits;

		// Token: 0x04007DA7 RID: 32167
		private float _timeSinceLastCCCollision;

		// Token: 0x04007DA9 RID: 32169
		public RollingMedian VerticalSpeed;

		// Token: 0x04007DAD RID: 32173
		private float _startFallingHeight;

		// Token: 0x04007DAE RID: 32174
		private float _startFlyHeight;

		// Token: 0x04007DAF RID: 32175
		public Action<float, float> OnGrounded;

		// Token: 0x04007DB3 RID: 32179
		private float _surfacePitch;

		// Token: 0x04007DB4 RID: 32180
		private Vector3 _surfaceDirection;

		// Token: 0x04007DB5 RID: 32181
		private Vector3 _surfaceNormalInterpolated;

		// Token: 0x04007DB6 RID: 32182
		private Collider[] _collidersAllocated;

		// Token: 0x04007DB7 RID: 32183
		private readonly Dictionary<EPlayerState, BaseMovementState> _states;

		// Token: 0x04007DB8 RID: 32184
		private List<int> _stateHashes;

		// Token: 0x04007DB9 RID: 32185
		private Dictionary<int, int> _statesHashToIndex;

		// Token: 0x04007DBA RID: 32186
		private Dictionary<int, EPlayerState> _statesHashToName;

		// Token: 0x04007DBB RID: 32187
		private static Dictionary<int, EPlayerState> _statesIndexToName;

		// Token: 0x04007DBC RID: 32188
		private int _lastNormalHashSuperCrutch;

		// Token: 0x04007DBD RID: 32189
		private float _lastPlayerHeight;

		// Token: 0x04007DBE RID: 32190
		private bool _hasLastHeight;

		// Token: 0x04007DBF RID: 32191
		private IPlayerStateContainerBehaviour[] _movementStates;

		// Token: 0x04007DC0 RID: 32192
		private bool _isInPatrol;

		// Token: 0x04007DC1 RID: 32193
		private bool _blockFirearms;

		// Token: 0x04007DC4 RID: 32196
		public float _poseInertia;

		// Token: 0x04007DC5 RID: 32197
		public float _currentPoseInertia;

		// Token: 0x04007DC6 RID: 32198
		private StationaryWeapon _stationaryWeapon;

		// Token: 0x04007DC7 RID: 32199
		public Action<Player> RotationAction;

		// Token: 0x04007DC8 RID: 32200
		public static Vector3 CachedVaultingRotation;

		// Token: 0x04007DC9 RID: 32201
		public static Quaternion LastVaultingRotation;

		// Token: 0x04007DCA RID: 32202
		public static Action<Player> DefaultRotationFunction;

		// Token: 0x04007DCB RID: 32203
		public static Action<Player> VaultingRotationFunction;

		// Token: 0x04007DCC RID: 32204
		public static Action<Player> UtesRotationFunction;

		// Token: 0x04007DCD RID: 32205
		public static Action<Player> AGSRotationFunction;

		// Token: 0x04007DD0 RID: 32208
		public Quaternion VaultingCachedLookRotation;

		// Token: 0x020015AC RID: 5548
		// (Invoke) Token: 0x060078B0 RID: 30896
		public delegate void GDelegate63(EPlayerState previousState, EPlayerState nextState);

		// Token: 0x020015AD RID: 5549
		// (Invoke) Token: 0x060078B3 RID: 30899
		public delegate void GDelegate64(int oldStateHashIndex, int newStateHashIndex);

		// Token: 0x020015AE RID: 5550
		[CompilerGenerated]
		[StructLayout(LayoutKind.Auto)]
		public struct Struct236
		{
			// Token: 0x04007DD1 RID: 32209
			public MovementContext movementContext_0;

			// Token: 0x04007DD2 RID: 32210
			public EPhysicalCondition conditions;
		}

		// Token: 0x020015AF RID: 5551
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1142
		{
			// Token: 0x060078B6 RID: 30902 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_0(IPlayerStateContainerBehaviour x)
			{
				throw null;
			}

			// Token: 0x060078B7 RID: 30903 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_1(IPlayerStateContainerBehaviour x)
			{
				throw null;
			}

			// Token: 0x060078B8 RID: 30904 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EPlayerState method_2(IPlayerStateContainerBehaviour x)
			{
				throw null;
			}

			// Token: 0x060078B9 RID: 30905 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_3(Player player)
			{
				throw null;
			}

			// Token: 0x060078BA RID: 30906 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_4(Player player)
			{
				throw null;
			}

			// Token: 0x060078BB RID: 30907 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_5(Player player)
			{
				throw null;
			}

			// Token: 0x060078BC RID: 30908 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_6(Player player)
			{
				throw null;
			}

			// Token: 0x04007DD3 RID: 32211
			public static readonly MovementContext.Class1142 class1142_0;

			// Token: 0x04007DD4 RID: 32212
			public static Func<IPlayerStateContainerBehaviour, int> func_0;

			// Token: 0x04007DD5 RID: 32213
			public static Func<IPlayerStateContainerBehaviour, int> func_1;

			// Token: 0x04007DD6 RID: 32214
			public static Func<IPlayerStateContainerBehaviour, EPlayerState> func_2;
		}

		// Token: 0x020015B1 RID: 5553
		[CompilerGenerated]
		private sealed class Class1144
		{
			// Token: 0x060078C1 RID: 30913 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Player.AbstractHandsController controller, Player.AbstractHandsController handsController)
			{
				throw null;
			}

			// Token: 0x04007DDA RID: 32218
			public MovementContext movementContext_0;

			// Token: 0x04007DDB RID: 32219
			public Action<Player.AbstractHandsController, Player.AbstractHandsController> callback;
		}
	}
}
