using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT
{
	// Token: 0x020015B2 RID: 5554
	public abstract class BaseMovementState
	{
		// Token: 0x1700130C RID: 4876
		// (get) Token: 0x060078C2 RID: 30914 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060078C3 RID: 30915 RVA: 0x00002050 File Offset: 0x00000250
		public bool CanInteract
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

		// Token: 0x1700130D RID: 4877
		// (get) Token: 0x060078C4 RID: 30916 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060078C5 RID: 30917 RVA: 0x00002050 File Offset: 0x00000250
		public virtual bool DisableRootMotion
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

		// Token: 0x060078C6 RID: 30918
		public abstract void OnStateEnter(float stateInfoNormalizedTime);

		// Token: 0x060078C7 RID: 30919
		public abstract void OnStateExit(float stateInfoNormalizedTime);

		// Token: 0x060078C8 RID: 30920
		public abstract void OnStateMove(float stateInfoNormalizedTime);

		// Token: 0x060078C9 RID: 30921 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ReEnter()
		{
			throw null;
		}

		// Token: 0x060078CA RID: 30922 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Enter(bool isFromSameState)
		{
			throw null;
		}

		// Token: 0x060078CB RID: 30923 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Exit(bool toSameState)
		{
			throw null;
		}

		// Token: 0x060078CC RID: 30924
		public abstract void AssignAnimatorPose(AnimatorPose firstPersonPose);

		// Token: 0x04007DDC RID: 32220
		public EStateType Type;

		// Token: 0x04007DDD RID: 32221
		public EPlayerState Name;

		// Token: 0x04007DDE RID: 32222
		public string AnimatorStateName;

		// Token: 0x04007DDF RID: 32223
		public int AnimatorStateHash;

		// Token: 0x04007DE0 RID: 32224
		public float AnimationAuthority;

		// Token: 0x04007DE1 RID: 32225
		public float AuthoritySpeed;

		// Token: 0x04007DE2 RID: 32226
		public float StateLength;

		// Token: 0x04007DE3 RID: 32227
		public float StateSensitivity;

		// Token: 0x04007DE4 RID: 32228
		public EMovementDirection AdditionalDirectionInfo;

		// Token: 0x04007DE5 RID: 32229
		public AnimationCurve SmoothLerpAnimCurve;

		// Token: 0x04007DE6 RID: 32230
		public float RotationSpeedClamp;
	}
}
