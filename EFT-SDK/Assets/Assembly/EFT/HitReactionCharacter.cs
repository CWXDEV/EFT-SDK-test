using System;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

namespace EFT
{
	// Token: 0x02001850 RID: 6224
	public class HitReactionCharacter : MonoBehaviour
	{
		// Token: 0x06008553 RID: 34131 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x04008C2A RID: 35882
		[SerializeField]
		private string mixingAnim;

		// Token: 0x04008C2B RID: 35883
		[SerializeField]
		private Transform recursiveMixingTransform;

		// Token: 0x04008C2C RID: 35884
		[SerializeField]
		private Camera cam;

		// Token: 0x04008C2D RID: 35885
		[SerializeField]
		private HitReaction hitReaction;

		// Token: 0x04008C2E RID: 35886
		[SerializeField]
		private float hitForce;
	}
}
