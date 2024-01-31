using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02001102 RID: 4354
	public class OffsetPose : MonoBehaviour
	{
		// Token: 0x06005BC6 RID: 23494 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
			throw null;
		}

		// Token: 0x06005BC7 RID: 23495 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
			throw null;
		}

		// Token: 0x0400674E RID: 26446
		public OffsetPose.EffectorLink[] effectorLinks;

		// Token: 0x02001103 RID: 4355
		[Serializable]
		public class EffectorLink
		{
			// Token: 0x06005BC8 RID: 23496 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
				throw null;
			}

			// Token: 0x0400674F RID: 26447
			public FullBodyBipedEffector effector;

			// Token: 0x04006750 RID: 26448
			public Vector3 offset;

			// Token: 0x04006751 RID: 26449
			public Vector3 pin;

			// Token: 0x04006752 RID: 26450
			public Vector3 pinWeight;
		}
	}
}
