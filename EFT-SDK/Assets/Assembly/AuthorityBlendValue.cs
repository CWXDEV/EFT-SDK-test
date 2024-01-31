using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x020008F0 RID: 2288
public class AuthorityBlendValue : StateMachineBehaviour
{
	// Token: 0x060033BF RID: 13247 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		throw null;
	}

	// Token: 0x04003461 RID: 13409
	[HideInInspector]
	public Player.ValueBlender Blender;

	// Token: 0x04003462 RID: 13410
	[HideInInspector]
	public Player.ValueBlender Temporary_Right_Hand_Copy;

	// Token: 0x04003463 RID: 13411
	public float Speed;

	// Token: 0x04003464 RID: 13412
	public float Target;

	// Token: 0x04003465 RID: 13413
	public bool RightHand;
}
