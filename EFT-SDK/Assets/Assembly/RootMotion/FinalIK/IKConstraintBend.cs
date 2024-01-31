using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010B0 RID: 4272
	[Serializable]
	public class IKConstraintBend
	{
		// Token: 0x06005979 RID: 22905 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsValid(IKSolverFullBody solver, GClass1267.GDelegate37 logger)
		{
			throw null;
		}

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x0600597A RID: 22906 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600597B RID: 22907 RVA: 0x00002050 File Offset: 0x00000250
		public bool initiated
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x0600597C RID: 22908 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
			throw null;
		}

		// Token: 0x0600597D RID: 22909 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initiate(IKSolverFullBody solver)
		{
			throw null;
		}

		// Token: 0x0600597E RID: 22910 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
			throw null;
		}

		// Token: 0x0600597F RID: 22911 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LimitBend(float solverWeight, float positionWeight)
		{
			throw null;
		}

		// Token: 0x06005980 RID: 22912 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			throw null;
		}

		// Token: 0x06005981 RID: 22913 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_0(IKSolverFullBody solver, Vector3 tangent)
		{
			throw null;
		}

		// Token: 0x06005982 RID: 22914 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_1(IKSolverFullBody solver, Vector3 tangent)
		{
			throw null;
		}

		// Token: 0x0400652C RID: 25900
		public Transform bone1;

		// Token: 0x0400652D RID: 25901
		public Transform bone2;

		// Token: 0x0400652E RID: 25902
		public Transform bone3;

		// Token: 0x0400652F RID: 25903
		public Transform bendGoal;

		// Token: 0x04006530 RID: 25904
		public Vector3 direction;

		// Token: 0x04006531 RID: 25905
		public Quaternion rotationOffset;

		// Token: 0x04006532 RID: 25906
		[Range(0f, 1f)]
		public float weight;

		// Token: 0x04006533 RID: 25907
		public Vector3 defaultLocalDirection;

		// Token: 0x04006534 RID: 25908
		public Vector3 defaultChildDirection;

		// Token: 0x04006535 RID: 25909
		[NonSerialized]
		public float clampF;

		// Token: 0x04006536 RID: 25910
		private int chainIndex1;

		// Token: 0x04006537 RID: 25911
		private int nodeIndex1;

		// Token: 0x04006538 RID: 25912
		private int chainIndex2;

		// Token: 0x04006539 RID: 25913
		private int nodeIndex2;

		// Token: 0x0400653A RID: 25914
		private int chainIndex3;

		// Token: 0x0400653B RID: 25915
		private int nodeIndex3;
	}
}
