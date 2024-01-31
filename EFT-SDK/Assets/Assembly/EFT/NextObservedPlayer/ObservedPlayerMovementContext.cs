using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.NextObservedPlayer
{
	// Token: 0x02002040 RID: 8256
	public class ObservedPlayerMovementContext : MonoBehaviour
	{
		// Token: 0x17001BED RID: 7149
		// (get) Token: 0x0600AAE2 RID: 43746 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AAE3 RID: 43747 RVA: 0x00002050 File Offset: 0x00000250
		public ICharacterController ObserverCharacterController
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

		// Token: 0x17001BEE RID: 7150
		// (get) Token: 0x0600AAE4 RID: 43748 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AAE5 RID: 43749 RVA: 0x00002050 File Offset: 0x00000250
		public GStruct164 CurrentPacket
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

		// Token: 0x17001BEF RID: 7151
		// (get) Token: 0x0600AAE6 RID: 43750 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AAE7 RID: 43751 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x17001BF0 RID: 7152
		// (get) Token: 0x0600AAE8 RID: 43752 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AAE9 RID: 43753 RVA: 0x00002050 File Offset: 0x00000250
		public EPlayerState CurrentState
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

		// Token: 0x17001BF1 RID: 7153
		// (get) Token: 0x0600AAEA RID: 43754 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AAEB RID: 43755 RVA: 0x00002050 File Offset: 0x00000250
		public EPlayerState PreviousState
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

		// Token: 0x0600AAEC RID: 43756 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialize(BifacialTransform playerTransform, ICharacterController characterController, PlayerAnimator animator)
		{
			throw null;
		}

		// Token: 0x0600AAED RID: 43757 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyRotation(Quaternion rotation)
		{
			throw null;
		}

		// Token: 0x0600AAEE RID: 43758 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void UpdateAnimatorRotationParameters()
		{
			throw null;
		}

		// Token: 0x0600AAEF RID: 43759 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PlayerAnimatorSetAimAngle(float movementContextPitch)
		{
			throw null;
		}

		// Token: 0x0600AAF0 RID: 43760 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PlayerAnimatorSetDeltaRotation(float movementContextPitch)
		{
			throw null;
		}

		// Token: 0x0400B1D7 RID: 45527
		[CompilerGenerated]
		private ICharacterController icharacterController_0;

		// Token: 0x0400B1D8 RID: 45528
		[CompilerGenerated]
		private GStruct164 gstruct164_0;

		// Token: 0x0400B1D9 RID: 45529
		protected PlayerAnimator _playerAnimator;

		// Token: 0x0400B1DA RID: 45530
		[CompilerGenerated]
		private EPlayerState eplayerState_0;

		// Token: 0x0400B1DB RID: 45531
		[CompilerGenerated]
		private EPlayerState eplayerState_1;

		// Token: 0x0400B1DC RID: 45532
		private Vector2 vector2_0;

		// Token: 0x0400B1DD RID: 45533
		private float float_0;

		// Token: 0x0400B1DE RID: 45534
		private BifacialTransform bifacialTransform_0;
	}
}
