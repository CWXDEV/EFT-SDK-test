using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010B7 RID: 4279
	[Serializable]
	public class IKMappingSpine : IKMapping
	{
		// Token: 0x060059B9 RID: 22969 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			throw null;
		}

		// Token: 0x060059BA RID: 22970 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
			throw null;
		}

		// Token: 0x060059BB RID: 22971 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StoreDefaultLocalState()
		{
			throw null;
		}

		// Token: 0x060059BC RID: 22972 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FixTransforms()
		{
			throw null;
		}

		// Token: 0x060059BD RID: 22973 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initiate(IKSolverFullBody solver)
		{
			throw null;
		}

		// Token: 0x060059BE RID: 22974 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_0()
		{
			throw null;
		}

		// Token: 0x060059BF RID: 22975 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReadPose()
		{
			throw null;
		}

		// Token: 0x060059C0 RID: 22976 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WritePose(IKSolverFullBody solver)
		{
			throw null;
		}

		// Token: 0x060059C1 RID: 22977 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ForwardReach(Vector3 position)
		{
			throw null;
		}

		// Token: 0x060059C2 RID: 22978 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(Vector3 position)
		{
			throw null;
		}

		// Token: 0x060059C3 RID: 22979 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(IKSolverFullBody solver)
		{
			throw null;
		}

		// Token: 0x04006585 RID: 25989
		public Transform[] spineBones;

		// Token: 0x04006586 RID: 25990
		public Transform leftUpperArmBone;

		// Token: 0x04006587 RID: 25991
		public Transform rightUpperArmBone;

		// Token: 0x04006588 RID: 25992
		public Transform leftThighBone;

		// Token: 0x04006589 RID: 25993
		public Transform rightThighBone;

		// Token: 0x0400658A RID: 25994
		[Range(1f, 3f)]
		public int iterations;

		// Token: 0x0400658B RID: 25995
		[Range(0f, 1f)]
		public float twistWeight;

		// Token: 0x0400658C RID: 25996
		private int rootNodeIndex;

		// Token: 0x0400658D RID: 25997
		private IKMapping.BoneMap[] spine;

		// Token: 0x0400658E RID: 25998
		private IKMapping.BoneMap leftUpperArm;

		// Token: 0x0400658F RID: 25999
		private IKMapping.BoneMap rightUpperArm;

		// Token: 0x04006590 RID: 26000
		private IKMapping.BoneMap leftThigh;

		// Token: 0x04006591 RID: 26001
		private IKMapping.BoneMap rightThigh;

		// Token: 0x04006592 RID: 26002
		private bool useFABRIK;
	}
}
