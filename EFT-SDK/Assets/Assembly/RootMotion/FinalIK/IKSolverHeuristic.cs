using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010C6 RID: 4294
	[Serializable]
	public class IKSolverHeuristic : IKSolver
	{
		// Token: 0x06005A4F RID: 23119 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			throw null;
		}

		// Token: 0x06005A50 RID: 23120 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddBone(Transform bone)
		{
			throw null;
		}

		// Token: 0x06005A51 RID: 23121 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void StoreDefaultLocalState()
		{
			throw null;
		}

		// Token: 0x06005A52 RID: 23122 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void FixTransforms()
		{
			throw null;
		}

		// Token: 0x06005A53 RID: 23123 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool IsValid(ref string message)
		{
			throw null;
		}

		// Token: 0x06005A54 RID: 23124 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IKSolver.Point[] GetPoints()
		{
			throw null;
		}

		// Token: 0x06005A55 RID: 23125 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IKSolver.Point GetPoint(Transform transform)
		{
			throw null;
		}

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x06005A56 RID: 23126 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual int minBones
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x06005A57 RID: 23127 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual bool boneLengthCanBeZero
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x06005A58 RID: 23128 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual bool allowCommonParent
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06005A59 RID: 23129 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnInitiate()
		{
			throw null;
		}

		// Token: 0x06005A5A RID: 23130 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnUpdate()
		{
			throw null;
		}

		// Token: 0x06005A5B RID: 23131 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void InitiateBones()
		{
			throw null;
		}

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x06005A5C RID: 23132 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual Vector3 localDirection
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x06005A5D RID: 23133 RVA: 0x00002050 File Offset: 0x00000250
		protected float positionOffset
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06005A5E RID: 23134 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected Vector3 GetSingularityOffset()
		{
			throw null;
		}

		// Token: 0x06005A5F RID: 23135 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_0()
		{
			throw null;
		}

		// Token: 0x040065E6 RID: 26086
		public Transform target;

		// Token: 0x040065E7 RID: 26087
		public float tolerance;

		// Token: 0x040065E8 RID: 26088
		public int maxIterations;

		// Token: 0x040065E9 RID: 26089
		public bool useRotationLimits;

		// Token: 0x040065EA RID: 26090
		public bool XY;

		// Token: 0x040065EB RID: 26091
		public IKSolver.Bone[] bones;

		// Token: 0x040065EC RID: 26092
		protected Vector3 lastLocalDirection;

		// Token: 0x040065ED RID: 26093
		protected float chainLength;
	}
}
