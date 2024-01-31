using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020008F6 RID: 2294
public class IKAuthority : Authority
{
	// Token: 0x060033DE RID: 13278 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		throw null;
	}

	// Token: 0x060033DF RID: 13279 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		throw null;
	}

	// Token: 0x060033E0 RID: 13280 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		throw null;
	}

	// Token: 0x0400347E RID: 13438
	public bool Exit;

	// Token: 0x0400347F RID: 13439
	public float Speed;

	// Token: 0x04003480 RID: 13440
	private bool bool_0;
}
