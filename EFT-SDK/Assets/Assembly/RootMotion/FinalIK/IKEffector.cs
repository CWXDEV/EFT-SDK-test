using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010B1 RID: 4273
	[Serializable]
	public class IKEffector
	{
		// Token: 0x06005983 RID: 22915 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			throw null;
		}

		// Token: 0x06005984 RID: 22916 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
			throw null;
		}

		// Token: 0x06005985 RID: 22917 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsValid(IKSolver solver, ref string message)
		{
			throw null;
		}

		// Token: 0x06005986 RID: 22918 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initiate(IKSolverFullBody solver)
		{
			throw null;
		}

		// Token: 0x06005987 RID: 22919 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetOffset(IKSolverFullBody solver)
		{
			throw null;
		}

		// Token: 0x06005988 RID: 22920 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetToTarget()
		{
			throw null;
		}

		// Token: 0x06005989 RID: 22921 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPreSolve(IKSolverFullBody solver)
		{
			throw null;
		}

		// Token: 0x0600598A RID: 22922 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPostWrite()
		{
			throw null;
		}

		// Token: 0x0600598B RID: 22923 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Quaternion method_0(IKSolverFullBody solver)
		{
			throw null;
		}

		// Token: 0x0600598C RID: 22924 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update(IKSolverFullBody solver)
		{
			throw null;
		}

		// Token: 0x0600598D RID: 22925 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_1(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			throw null;
		}

		// Token: 0x0400653D RID: 25917
		public Transform bone;

		// Token: 0x0400653E RID: 25918
		public Transform target;

		// Token: 0x0400653F RID: 25919
		[Range(0f, 1f)]
		public float positionWeight;

		// Token: 0x04006540 RID: 25920
		[Range(0f, 1f)]
		public float rotationWeight;

		// Token: 0x04006541 RID: 25921
		public Vector3 position;

		// Token: 0x04006542 RID: 25922
		public Quaternion rotation;

		// Token: 0x04006543 RID: 25923
		public Vector3 positionOffset;

		// Token: 0x04006545 RID: 25925
		public bool effectChildNodes;

		// Token: 0x04006546 RID: 25926
		[Range(0f, 1f)]
		public float maintainRelativePositionWeight;

		// Token: 0x04006547 RID: 25927
		public Transform[] childBones;

		// Token: 0x04006548 RID: 25928
		public Transform planeBone1;

		// Token: 0x04006549 RID: 25929
		public Transform planeBone2;

		// Token: 0x0400654A RID: 25930
		public Transform planeBone3;

		// Token: 0x0400654B RID: 25931
		public Quaternion planeRotationOffset;

		// Token: 0x0400654C RID: 25932
		private float posW;

		// Token: 0x0400654D RID: 25933
		private float rotW;

		// Token: 0x0400654E RID: 25934
		private Vector3[] localPositions;

		// Token: 0x0400654F RID: 25935
		private bool usePlaneNodes;

		// Token: 0x04006550 RID: 25936
		private Quaternion animatedPlaneRotation;

		// Token: 0x04006551 RID: 25937
		private Vector3 animatedPosition;

		// Token: 0x04006552 RID: 25938
		private bool firstUpdate;

		// Token: 0x04006553 RID: 25939
		private int chainIndex;

		// Token: 0x04006554 RID: 25940
		private int nodeIndex;

		// Token: 0x04006555 RID: 25941
		private int plane1ChainIndex;

		// Token: 0x04006556 RID: 25942
		private int plane1NodeIndex;

		// Token: 0x04006557 RID: 25943
		private int plane2ChainIndex;

		// Token: 0x04006558 RID: 25944
		private int plane2NodeIndex;

		// Token: 0x04006559 RID: 25945
		private int plane3ChainIndex;

		// Token: 0x0400655A RID: 25946
		private int plane3NodeIndex;

		// Token: 0x0400655B RID: 25947
		private int[] childChainIndexes;

		// Token: 0x0400655C RID: 25948
		private int[] childNodeIndexes;
	}
}
