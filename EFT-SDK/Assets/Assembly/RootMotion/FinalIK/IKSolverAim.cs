using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010BE RID: 4286
	[Serializable]
	public class IKSolverAim : IKSolverHeuristic
	{
		// Token: 0x060059EE RID: 23022 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetAngle()
		{
			throw null;
		}

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x060059EF RID: 23023 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 transformAxis
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x060059F0 RID: 23024 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 transformPoleAxis
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060059F1 RID: 23025 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnInitiate()
		{
			throw null;
		}

		// Token: 0x060059F2 RID: 23026 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnUpdate()
		{
			throw null;
		}

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x060059F3 RID: 23027 RVA: 0x00002050 File Offset: 0x00000250
		protected override int minBones
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060059F4 RID: 23028 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x060059F5 RID: 23029 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_2()
		{
			throw null;
		}

		// Token: 0x060059F6 RID: 23030 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(Vector3 targetPosition, IKSolver.Bone bone, float weight)
		{
			throw null;
		}

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x060059F7 RID: 23031 RVA: 0x00002050 File Offset: 0x00000250
		protected override Vector3 localDirection
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040065AC RID: 26028
		public Transform transform;

		// Token: 0x040065AD RID: 26029
		public Vector3 axis;

		// Token: 0x040065AE RID: 26030
		public Vector3 poleAxis;

		// Token: 0x040065AF RID: 26031
		public Vector3 polePosition;

		// Token: 0x040065B0 RID: 26032
		[Range(0f, 1f)]
		public float poleWeight;

		// Token: 0x040065B1 RID: 26033
		public Transform poleTarget;

		// Token: 0x040065B2 RID: 26034
		[Range(0f, 1f)]
		public float clampWeight;

		// Token: 0x040065B3 RID: 26035
		[Range(0f, 2f)]
		public int clampSmoothing;

		// Token: 0x040065B4 RID: 26036
		public IKSolver.GDelegate40 OnPreIteration;

		// Token: 0x040065B5 RID: 26037
		private float step;

		// Token: 0x040065B6 RID: 26038
		private Vector3 clampedIKPosition;

		// Token: 0x040065B7 RID: 26039
		private RotationLimit transformLimit;

		// Token: 0x040065B8 RID: 26040
		private Transform lastTransform;
	}
}
