using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.UI;
using Sirenix.OdinInspector;
using UnityEngine;

// Token: 0x020009B6 RID: 2486
public class StatedUIButtonAnimation : SerializedMonoBehaviour, GInterface360<EButtonAnimationState>, GInterface359
{
	// Token: 0x0600377D RID: 14205 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TransitionToState(EButtonAnimationState state)
	{
		throw null;
	}

	// Token: 0x0600377E RID: 14206 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetState(EButtonAnimationState state)
	{
		throw null;
	}

	// Token: 0x0600377F RID: 14207 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(EButtonAnimationState state)
	{
		throw null;
	}

	// Token: 0x06003780 RID: 14208 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Stop()
	{
		throw null;
	}

	// Token: 0x04003900 RID: 14592
	[SerializeField]
	private Dictionary<EButtonAnimationState, GameObject[]> _states;
}
