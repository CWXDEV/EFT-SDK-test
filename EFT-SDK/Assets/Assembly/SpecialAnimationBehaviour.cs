using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x020008FB RID: 2299
public class SpecialAnimationBehaviour : StateMachineBehaviour
{
	// Token: 0x060033EF RID: 13295 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		throw null;
	}

	// Token: 0x060033F0 RID: 13296 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		throw null;
	}

	// Token: 0x060033F1 RID: 13297 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		throw null;
	}

	// Token: 0x0400349E RID: 13470
	public IKSettings IKDisable;

	// Token: 0x0400349F RID: 13471
	public bool EnableSpecialAnimation;

	// Token: 0x040034A0 RID: 13472
	public float TresholdTime;

	// Token: 0x040034A1 RID: 13473
	public bool LeftArmReverseSnatching;

	// Token: 0x040034A2 RID: 13474
	private bool bool_0;

	// Token: 0x040034A3 RID: 13475
	public Player Player;
}
