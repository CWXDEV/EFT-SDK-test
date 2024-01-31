using System;
using System.Runtime.CompilerServices;
using EFT.Interactive;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT
{
	// Token: 0x020015B3 RID: 5555
	[Serializable]
	public class MovementState : BaseMovementState
	{
		// Token: 0x1700130E RID: 4878
		// (get) Token: 0x060078CD RID: 30925 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060078CE RID: 30926 RVA: 0x00002050 File Offset: 0x00000250
		public Vector2 Direction
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

		// Token: 0x060078CF RID: 30927 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnStateEnter(float normalizedTime)
		{
			throw null;
		}

		// Token: 0x060078D0 RID: 30928 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnStateMove(float normalizedTime)
		{
			throw null;
		}

		// Token: 0x1700130F RID: 4879
		// (set) Token: 0x060078D1 RID: 30929 RVA: 0x00002050 File Offset: 0x00000250
		public override bool DisableRootMotion
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060078D2 RID: 30930 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnStateExit(float normalizedTime)
		{
			throw null;
		}

		// Token: 0x060078D3 RID: 30931 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void ManualAnimatorMoveUpdate(float deltaTime)
		{
			throw null;
		}

		// Token: 0x060078D4 RID: 30932 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void ProcessRotation(float deltaTime)
		{
			throw null;
		}

		// Token: 0x060078D5 RID: 30933 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void ProcessUpperbodyRotation(float deltaTime)
		{
			throw null;
		}

		// Token: 0x060078D6 RID: 30934 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void UpdateRotationSpeed(float deltaTime)
		{
			throw null;
		}

		// Token: 0x17001310 RID: 4880
		// (get) Token: 0x060078D7 RID: 30935 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060078D8 RID: 30936 RVA: 0x00002050 File Offset: 0x00000250
		protected float FreefallTime
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

		// Token: 0x060078D9 RID: 30937 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void LimitMotion(ref Vector3 motion, float deltaTime)
		{
			throw null;
		}

		// Token: 0x060078DA RID: 30938 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void ApplyGravity(ref Vector3 motion, float deltaTime)
		{
			throw null;
		}

		// Token: 0x060078DB RID: 30939 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CalculateMotionShortage()
		{
			throw null;
		}

		// Token: 0x060078DC RID: 30940 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void ApplyMotion(ref Vector3 motion, float deltaTime)
		{
			throw null;
		}

		// Token: 0x060078DD RID: 30941 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void ProcessAnimatorMovement(float deltaTime)
		{
			throw null;
		}

		// Token: 0x060078DE RID: 30942 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void BlendMotion(ref Vector3 motion, float deltaTime)
		{
			throw null;
		}

		// Token: 0x17001311 RID: 4881
		// (get) Token: 0x060078DF RID: 30943 RVA: 0x00002050 File Offset: 0x00000250
		public virtual bool CanLoot
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060078E0 RID: 30944 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Move(Vector2 direction)
		{
			throw null;
		}

		// Token: 0x060078E1 RID: 30945 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Rotate(Vector2 deltaRotation, bool ignoreClamp = false)
		{
			throw null;
		}

		// Token: 0x060078E2 RID: 30946 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 ClampRotation(Vector3 deltaRotation)
		{
			throw null;
		}

		// Token: 0x060078E3 RID: 30947 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Loot(bool enabled)
		{
			throw null;
		}

		// Token: 0x060078E4 RID: 30948 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Pickup(bool enabled, [CanBeNull] Action action)
		{
			throw null;
		}

		// Token: 0x060078E5 RID: 30949 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Examine(bool enabled, [CanBeNull] Action action)
		{
			throw null;
		}

		// Token: 0x060078E6 RID: 30950 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnThrow(bool enable)
		{
			throw null;
		}

		// Token: 0x060078E7 RID: 30951 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnReload(bool enable)
		{
			throw null;
		}

		// Token: 0x060078E8 RID: 30952 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnInventory(bool enable)
		{
			throw null;
		}

		// Token: 0x060078E9 RID: 30953 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ChangePose(float poseDelta)
		{
			throw null;
		}

		// Token: 0x060078EA RID: 30954 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ChangeSpeed(float speedDelta)
		{
			throw null;
		}

		// Token: 0x060078EB RID: 30955 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetBlindFireAnim(float blindFire)
		{
			throw null;
		}

		// Token: 0x060078EC RID: 30956 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetTilt(float tilt)
		{
			throw null;
		}

		// Token: 0x060078ED RID: 30957 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Kick()
		{
			throw null;
		}

		// Token: 0x060078EE RID: 30958 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Jump()
		{
			throw null;
		}

		// Token: 0x060078EF RID: 30959 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Vaulting()
		{
			throw null;
		}

		// Token: 0x060078F0 RID: 30960 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Prone()
		{
			throw null;
		}

		// Token: 0x060078F1 RID: 30961 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Plant(bool enabled, bool multitool, float plantTime, Action<bool> action)
		{
			throw null;
		}

		// Token: 0x060078F2 RID: 30962 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void EnableSprint(bool enable, bool isToggle = false)
		{
			throw null;
		}

		// Token: 0x060078F3 RID: 30963 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void EnableBreath(bool enable)
		{
			throw null;
		}

		// Token: 0x060078F4 RID: 30964 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartDoorInteraction(WorldInteractiveObject interactive, InteractionResult interactionResult, Action callback)
		{
			throw null;
		}

		// Token: 0x060078F5 RID: 30965 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ExecuteDoorInteraction(WorldInteractiveObject interactive, InteractionResult interactionResult, [CanBeNull] Action callback, Player user)
		{
			throw null;
		}

		// Token: 0x060078F6 RID: 30966 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetStep(int step)
		{
			throw null;
		}

		// Token: 0x060078F7 RID: 30967 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Cancel()
		{
			throw null;
		}

		// Token: 0x060078F8 RID: 30968 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnInteraction()
		{
			throw null;
		}

		// Token: 0x060078F9 RID: 30969 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void BlindFire(int b)
		{
			throw null;
		}

		// Token: 0x060078FA RID: 30970 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void DropStationary()
		{
			throw null;
		}

		// Token: 0x060078FB RID: 30971 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void AssignAnimatorPose(AnimatorPose animatorPose)
		{
			throw null;
		}

		// Token: 0x04007DE9 RID: 32233
		protected MovementContext MovementContext;

		// Token: 0x04007DEA RID: 32234
		public float NormalizedTime;

		// Token: 0x04007DEB RID: 32235
		protected bool StickToGround;

		// Token: 0x04007DEC RID: 32236
		public bool PlantMultitool;

		// Token: 0x04007DED RID: 32237
		public float PlantTime;

		// Token: 0x04007DEE RID: 32238
		public static Vector3 G;

		// Token: 0x04007DEF RID: 32239
		public static float G_y;

		// Token: 0x04007DF0 RID: 32240
		protected Vector3? Destination;

		// Token: 0x04007DF2 RID: 32242
		private Vector3 _currentDownForce;

		// Token: 0x04007DF3 RID: 32243
		private Vector3 _motionShortage;

		// Token: 0x04007DF4 RID: 32244
		private RollingMedian _sqrShortage;
	}
}
