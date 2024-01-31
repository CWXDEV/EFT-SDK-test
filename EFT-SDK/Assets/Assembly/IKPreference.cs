using System;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Token: 0x0200093A RID: 2362
public class IKPreference : StateMachineBehaviour
{
	// Token: 0x0600355F RID: 13663 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		throw null;
	}

	// Token: 0x06003560 RID: 13664 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		throw null;
	}

	// Token: 0x06003561 RID: 13665 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(Animator animator)
	{
		throw null;
	}

	// Token: 0x0400364A RID: 13898
	public LimbIK[] footIKs;

	// Token: 0x0400364B RID: 13899
	public bool IKEnabledEnter;

	// Token: 0x0400364C RID: 13900
	public bool IKEnabledExit;
}
