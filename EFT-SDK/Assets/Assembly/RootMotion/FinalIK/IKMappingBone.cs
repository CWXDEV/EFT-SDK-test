using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010B4 RID: 4276
	[Serializable]
	public class IKMappingBone : IKMapping
	{
		// Token: 0x060059AA RID: 22954 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			throw null;
		}

		// Token: 0x060059AB RID: 22955 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StoreDefaultLocalState()
		{
			throw null;
		}

		// Token: 0x060059AC RID: 22956 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FixTransforms()
		{
			throw null;
		}

		// Token: 0x060059AD RID: 22957 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initiate(IKSolverFullBody solver)
		{
			throw null;
		}

		// Token: 0x060059AE RID: 22958 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReadPose()
		{
			throw null;
		}

		// Token: 0x060059AF RID: 22959 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WritePose(float solverWeight)
		{
			throw null;
		}

		// Token: 0x04006573 RID: 25971
		public Transform bone;

		// Token: 0x04006574 RID: 25972
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		// Token: 0x04006575 RID: 25973
		private IKMapping.BoneMap boneMap;
	}
}
