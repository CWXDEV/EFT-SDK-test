using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010B5 RID: 4277
	[Serializable]
	public class IKMappingLimb : IKMapping
	{
		// Token: 0x060059B0 RID: 22960 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			throw null;
		}

		// Token: 0x060059B1 RID: 22961 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IKMapping.BoneMap GetBoneMap(IKMappingLimb.BoneMapType boneMap)
		{
			throw null;
		}

		// Token: 0x060059B2 RID: 22962 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
			throw null;
		}

		// Token: 0x060059B3 RID: 22963 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, Transform parentBone = null)
		{
			throw null;
		}

		// Token: 0x060059B4 RID: 22964 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StoreDefaultLocalState()
		{
			throw null;
		}

		// Token: 0x060059B5 RID: 22965 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FixTransforms()
		{
			throw null;
		}

		// Token: 0x060059B6 RID: 22966 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initiate(IKSolverFullBody solver)
		{
			throw null;
		}

		// Token: 0x060059B7 RID: 22967 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReadPose()
		{
			throw null;
		}

		// Token: 0x060059B8 RID: 22968 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
			throw null;
		}

		// Token: 0x04006576 RID: 25974
		public Transform parentBone;

		// Token: 0x04006577 RID: 25975
		public Transform bone1;

		// Token: 0x04006578 RID: 25976
		public Transform bone2;

		// Token: 0x04006579 RID: 25977
		public Transform bone3;

		// Token: 0x0400657A RID: 25978
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		// Token: 0x0400657B RID: 25979
		[Range(0f, 1f)]
		public float weight;

		// Token: 0x0400657C RID: 25980
		private IKMapping.BoneMap boneMapParent;

		// Token: 0x0400657D RID: 25981
		private IKMapping.BoneMap boneMap1;

		// Token: 0x0400657E RID: 25982
		private IKMapping.BoneMap boneMap2;

		// Token: 0x0400657F RID: 25983
		private IKMapping.BoneMap boneMap3;

		// Token: 0x020010B6 RID: 4278
		[Serializable]
		public enum BoneMapType
		{
			// Token: 0x04006581 RID: 25985
			Parent,
			// Token: 0x04006582 RID: 25986
			Bone1,
			// Token: 0x04006583 RID: 25987
			Bone2,
			// Token: 0x04006584 RID: 25988
			Bone3
		}
	}
}
