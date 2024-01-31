using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010D0 RID: 4304
	[Serializable]
	public class InteractionLookAt
	{
		// Token: 0x06005AC0 RID: 23232 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Look(Transform target, float time)
		{
			throw null;
		}

		// Token: 0x06005AC1 RID: 23233 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			throw null;
		}

		// Token: 0x06005AC2 RID: 23234 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SolveSpine()
		{
			throw null;
		}

		// Token: 0x06005AC3 RID: 23235 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SolveHead()
		{
			throw null;
		}

		// Token: 0x0400664C RID: 26188
		[Tooltip("(Optional) reference to the LookAtIK component that will be used to make the character look at the objects that it is interacting with.")]
		public LookAtIK ik;

		// Token: 0x0400664D RID: 26189
		[Tooltip("Interpolation speed of the LookAtIK target.")]
		public float lerpSpeed;

		// Token: 0x0400664E RID: 26190
		[Tooltip("Interpolation speed of the LookAtIK weight.")]
		public float weightSpeed;

		// Token: 0x0400664F RID: 26191
		[HideInInspector]
		public bool isPaused;

		// Token: 0x04006650 RID: 26192
		private Transform lookAtTarget;

		// Token: 0x04006651 RID: 26193
		private float stopLookTime;

		// Token: 0x04006652 RID: 26194
		private float weight;

		// Token: 0x04006653 RID: 26195
		private bool firstFBBIKSolve;
	}
}
