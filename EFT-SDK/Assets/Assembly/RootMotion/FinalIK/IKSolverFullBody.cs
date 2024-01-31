using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010C2 RID: 4290
	[Serializable]
	public class IKSolverFullBody : IKSolver
	{
		// Token: 0x06005A1F RID: 23071 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public FBIKChain GetChain(Transform transform)
		{
			throw null;
		}

		// Token: 0x06005A20 RID: 23072 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetChainIndex(Transform transform)
		{
			throw null;
		}

		// Token: 0x06005A21 RID: 23073 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IKSolver.Node GetNode(int chainIndex, int nodeIndex)
		{
			throw null;
		}

		// Token: 0x06005A22 RID: 23074 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
			throw null;
		}

		// Token: 0x06005A23 RID: 23075 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IKSolver.Point[] GetPoints()
		{
			throw null;
		}

		// Token: 0x06005A24 RID: 23076 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IKSolver.Point GetPoint(Transform transform)
		{
			throw null;
		}

		// Token: 0x06005A25 RID: 23077 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool IsValid(ref string message)
		{
			throw null;
		}

		// Token: 0x06005A26 RID: 23078 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void StoreDefaultLocalState()
		{
			throw null;
		}

		// Token: 0x06005A27 RID: 23079 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void FixTransforms()
		{
			throw null;
		}

		// Token: 0x06005A28 RID: 23080 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnInitiate()
		{
			throw null;
		}

		// Token: 0x06005A29 RID: 23081 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnUpdate()
		{
			throw null;
		}

		// Token: 0x06005A2A RID: 23082 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void ReadPose()
		{
			throw null;
		}

		// Token: 0x06005A2B RID: 23083 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Solve()
		{
			throw null;
		}

		// Token: 0x06005A2C RID: 23084 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void ApplyBendConstraints()
		{
			throw null;
		}

		// Token: 0x06005A2D RID: 23085 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void WritePose()
		{
			throw null;
		}

		// Token: 0x040065C3 RID: 26051
		[Range(0f, 10f)]
		public int iterations;

		// Token: 0x040065C4 RID: 26052
		public FBIKChain[] chain;

		// Token: 0x040065C5 RID: 26053
		public IKEffector[] effectors;

		// Token: 0x040065C6 RID: 26054
		public IKMappingSpine spineMapping;

		// Token: 0x040065C7 RID: 26055
		public IKMappingBone[] boneMappings;

		// Token: 0x040065C8 RID: 26056
		public IKMappingLimb[] limbMappings;

		// Token: 0x040065C9 RID: 26057
		public IKSolver.GDelegate39 OnPreRead;

		// Token: 0x040065CA RID: 26058
		public IKSolver.GDelegate39 OnPreSolve;

		// Token: 0x040065CB RID: 26059
		public IKSolver.GDelegate40 OnPreIteration;

		// Token: 0x040065CC RID: 26060
		public IKSolver.GDelegate40 OnPostIteration;

		// Token: 0x040065CD RID: 26061
		public IKSolver.GDelegate39 OnPreBend;

		// Token: 0x040065CE RID: 26062
		public IKSolver.GDelegate39 OnPostSolve;

		// Token: 0x040065CF RID: 26063
		public IKSolver.GDelegate39 OnStoreDefaultLocalState;

		// Token: 0x040065D0 RID: 26064
		public IKSolver.GDelegate39 OnFixTransforms;
	}
}
