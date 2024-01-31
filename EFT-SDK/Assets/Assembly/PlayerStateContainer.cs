using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x02000734 RID: 1844
public class PlayerStateContainer : StateMachineBehaviour, IStateBehaviour, IPlayerStateContainerBehaviour
{
	// Token: 0x17000795 RID: 1941
	// (get) Token: 0x06002B5A RID: 11098 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002B5B RID: 11099 RVA: 0x00002050 File Offset: 0x00000250
	public bool DefaultState
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

	// Token: 0x17000796 RID: 1942
	// (get) Token: 0x06002B5C RID: 11100 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002B5D RID: 11101 RVA: 0x00002050 File Offset: 0x00000250
	public EPlayerState PlayerStateName
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

	// Token: 0x17000797 RID: 1943
	// (get) Token: 0x06002B5E RID: 11102 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002B5F RID: 11103 RVA: 0x00002050 File Offset: 0x00000250
	public BaseMovementState EncapsulatedState
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

	// Token: 0x17000798 RID: 1944
	// (get) Token: 0x06002B60 RID: 11104 RVA: 0x00002050 File Offset: 0x00000250
	public int FullNameHash
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06002B61 RID: 11105 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(Func<EPlayerState, int, bool, BaseMovementState> newStateFunc)
	{
		throw null;
	}

	// Token: 0x06002B62 RID: 11106 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deinit()
	{
		throw null;
	}

	// Token: 0x06002B63 RID: 11107 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public sealed override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		throw null;
	}

	// Token: 0x06002B64 RID: 11108 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public sealed override void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		throw null;
	}

	// Token: 0x06002B65 RID: 11109 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		throw null;
	}

	// Token: 0x0400294D RID: 10573
	public bool IsDefaultState;

	// Token: 0x0400294E RID: 10574
	public EPlayerState Name;

	// Token: 0x0400294F RID: 10575
	public EStateType Type;

	// Token: 0x04002950 RID: 10576
	public EMovementDirection AdditionalDirectionInfo;

	// Token: 0x04002951 RID: 10577
	public float RotationSpeedClamp;

	// Token: 0x04002952 RID: 10578
	public float StateSensitivity;

	// Token: 0x04002953 RID: 10579
	public bool CanInteract;

	// Token: 0x04002954 RID: 10580
	public bool DisableRootMotion;

	// Token: 0x04002955 RID: 10581
	public bool CreateUniqueMovementStateObject;

	// Token: 0x04002956 RID: 10582
	public float AnimationAuthority;

	// Token: 0x04002957 RID: 10583
	public float AuthoritySpeed;

	// Token: 0x04002958 RID: 10584
	public AnimationCurve SmoothLerpAnimCurve;

	// Token: 0x04002959 RID: 10585
	[HideInInspector]
	public string StateFullName;

	// Token: 0x0400295A RID: 10586
	[HideInInspector]
	public int StateFullNameHash;

	// Token: 0x0400295B RID: 10587
	[HideInInspector]
	public float StateLength;

	// Token: 0x0400295C RID: 10588
	public AnimatorPose FirstPersonPose;

	// Token: 0x0400295D RID: 10589
	[CompilerGenerated]
	private BaseMovementState baseMovementState_0;
}
