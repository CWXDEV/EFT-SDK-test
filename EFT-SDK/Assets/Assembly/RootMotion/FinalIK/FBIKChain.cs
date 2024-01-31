using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010AD RID: 4269
	[Serializable]
	public class FBIKChain
	{
		// Token: 0x06005960 RID: 22880 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetNodes(params Transform[] boneTransforms)
		{
			throw null;
		}

		// Token: 0x06005961 RID: 22881 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetNodeIndex(Transform boneTransform)
		{
			throw null;
		}

		// Token: 0x06005962 RID: 22882 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsValid(ref string message)
		{
			throw null;
		}

		// Token: 0x06005963 RID: 22883 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initiate(IKSolverFullBody solver)
		{
			throw null;
		}

		// Token: 0x06005964 RID: 22884 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
			throw null;
		}

		// Token: 0x06005965 RID: 22885 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(IKSolverFullBody solver)
		{
			throw null;
		}

		// Token: 0x06005966 RID: 22886 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Reach(IKSolverFullBody solver)
		{
			throw null;
		}

		// Token: 0x06005967 RID: 22887 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 Push(IKSolverFullBody solver)
		{
			throw null;
		}

		// Token: 0x06005968 RID: 22888 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
			throw null;
		}

		// Token: 0x06005969 RID: 22889 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Stage1(IKSolverFullBody solver)
		{
			throw null;
		}

		// Token: 0x0600596A RID: 22890 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
			throw null;
		}

		// Token: 0x0600596B RID: 22891 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
			throw null;
		}

		// Token: 0x0600596C RID: 22892 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_1(Vector3 pos1, Vector3 pos2, float length)
		{
			throw null;
		}

		// Token: 0x0600596D RID: 22893 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			throw null;
		}

		// Token: 0x0600596E RID: 22894 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(IKSolverFullBody solver)
		{
			throw null;
		}

		// Token: 0x0600596F RID: 22895 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
			throw null;
		}

		// Token: 0x06005970 RID: 22896 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ForwardReach(Vector3 position)
		{
			throw null;
		}

		// Token: 0x06005971 RID: 22897 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(Vector3 position)
		{
			throw null;
		}

		// Token: 0x04006509 RID: 25865
		[Range(0f, 1f)]
		public float pin;

		// Token: 0x0400650A RID: 25866
		[Range(0f, 1f)]
		public float pull;

		// Token: 0x0400650B RID: 25867
		[Range(0f, 1f)]
		public float push;

		// Token: 0x0400650C RID: 25868
		[Range(-1f, 1f)]
		public float pushParent;

		// Token: 0x0400650D RID: 25869
		[Range(0f, 1f)]
		public float reach;

		// Token: 0x0400650E RID: 25870
		public FBIKChain.Smoothing reachSmoothing;

		// Token: 0x0400650F RID: 25871
		public FBIKChain.Smoothing pushSmoothing;

		// Token: 0x04006510 RID: 25872
		public IKSolver.Node[] nodes;

		// Token: 0x04006511 RID: 25873
		public int[] children;

		// Token: 0x04006512 RID: 25874
		public FBIKChain.ChildConstraint[] childConstraints;

		// Token: 0x04006513 RID: 25875
		public IKConstraintBend bendConstraint;

		// Token: 0x04006514 RID: 25876
		private float rootLength;

		// Token: 0x04006515 RID: 25877
		private bool initiated;

		// Token: 0x04006516 RID: 25878
		private float length;

		// Token: 0x04006517 RID: 25879
		private float distance;

		// Token: 0x04006518 RID: 25880
		private IKSolver.Point p;

		// Token: 0x04006519 RID: 25881
		private float reachForce;

		// Token: 0x0400651A RID: 25882
		private float pullParentSum;

		// Token: 0x0400651B RID: 25883
		private float[] crossFades;

		// Token: 0x0400651C RID: 25884
		private float sqrMag1;

		// Token: 0x0400651D RID: 25885
		private float sqrMag2;

		// Token: 0x0400651E RID: 25886
		private float sqrMagDif;

		// Token: 0x0400651F RID: 25887
		private const float maxLimbLength = 0.99999f;

		// Token: 0x020010AE RID: 4270
		[Serializable]
		public class ChildConstraint
		{
			// Token: 0x17000E0A RID: 3594
			// (get) Token: 0x06005972 RID: 22898 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06005973 RID: 22899 RVA: 0x00002050 File Offset: 0x00000250
			public float nominalDistance
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

			// Token: 0x17000E0B RID: 3595
			// (get) Token: 0x06005974 RID: 22900 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06005975 RID: 22901 RVA: 0x00002050 File Offset: 0x00000250
			public bool isRigid
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

			// Token: 0x06005976 RID: 22902 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Initiate(IKSolverFullBody solver)
			{
				throw null;
			}

			// Token: 0x06005977 RID: 22903 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void OnPreSolve(IKSolverFullBody solver)
			{
				throw null;
			}

			// Token: 0x06005978 RID: 22904 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Solve(IKSolverFullBody solver)
			{
				throw null;
			}

			// Token: 0x04006520 RID: 25888
			public float pushElasticity;

			// Token: 0x04006521 RID: 25889
			public float pullElasticity;

			// Token: 0x04006522 RID: 25890
			[SerializeField]
			private Transform bone1;

			// Token: 0x04006523 RID: 25891
			[SerializeField]
			private Transform bone2;

			// Token: 0x04006524 RID: 25892
			private float crossFade;

			// Token: 0x04006525 RID: 25893
			private float inverseCrossFade;

			// Token: 0x04006526 RID: 25894
			private int chain1Index;

			// Token: 0x04006527 RID: 25895
			private int chain2Index;
		}

		// Token: 0x020010AF RID: 4271
		[Serializable]
		public enum Smoothing
		{
			// Token: 0x04006529 RID: 25897
			None,
			// Token: 0x0400652A RID: 25898
			Exponential,
			// Token: 0x0400652B RID: 25899
			Cubic
		}
	}
}
