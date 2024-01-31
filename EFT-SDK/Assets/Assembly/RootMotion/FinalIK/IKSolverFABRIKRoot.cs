using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010C1 RID: 4289
	[Serializable]
	public class IKSolverFABRIKRoot : IKSolver
	{
		// Token: 0x06005A15 RID: 23061 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool IsValid(ref string message)
		{
			throw null;
		}

		// Token: 0x06005A16 RID: 23062 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void StoreDefaultLocalState()
		{
			throw null;
		}

		// Token: 0x06005A17 RID: 23063 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void FixTransforms()
		{
			throw null;
		}

		// Token: 0x06005A18 RID: 23064 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnInitiate()
		{
			throw null;
		}

		// Token: 0x06005A19 RID: 23065 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_0(int index)
		{
			throw null;
		}

		// Token: 0x06005A1A RID: 23066 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnUpdate()
		{
			throw null;
		}

		// Token: 0x06005A1B RID: 23067 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IKSolver.Point[] GetPoints()
		{
			throw null;
		}

		// Token: 0x06005A1C RID: 23068 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IKSolver.Point GetPoint(Transform transform)
		{
			throw null;
		}

		// Token: 0x06005A1D RID: 23069 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(ref IKSolver.Point[] array, FABRIKChain chain)
		{
			throw null;
		}

		// Token: 0x06005A1E RID: 23070 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_2()
		{
			throw null;
		}

		// Token: 0x040065BD RID: 26045
		public int iterations;

		// Token: 0x040065BE RID: 26046
		[Range(0f, 1f)]
		public float rootPin;

		// Token: 0x040065BF RID: 26047
		public FABRIKChain[] chains;

		// Token: 0x040065C0 RID: 26048
		private bool zeroWeightApplied;

		// Token: 0x040065C1 RID: 26049
		private bool[] isRoot;

		// Token: 0x040065C2 RID: 26050
		private Vector3 rootDefaultPosition;
	}
}
