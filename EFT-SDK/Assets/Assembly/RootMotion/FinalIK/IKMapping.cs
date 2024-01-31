using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010B2 RID: 4274
	[Serializable]
	public class IKMapping
	{
		// Token: 0x0600598E RID: 22926 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			throw null;
		}

		// Token: 0x0600598F RID: 22927 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Initiate(IKSolverFullBody solver)
		{
			throw null;
		}

		// Token: 0x06005990 RID: 22928 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, GClass1267.GDelegate37 logger = null)
		{
			throw null;
		}

		// Token: 0x06005991 RID: 22929 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			throw null;
		}

		// Token: 0x020010B3 RID: 4275
		[Serializable]
		public class BoneMap
		{
			// Token: 0x06005992 RID: 22930 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
				throw null;
			}

			// Token: 0x17000E0E RID: 3598
			// (get) Token: 0x06005993 RID: 22931 RVA: 0x00002050 File Offset: 0x00000250
			public Vector3 swingDirection
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06005994 RID: 22932 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void StoreDefaultLocalState()
			{
				throw null;
			}

			// Token: 0x06005995 RID: 22933 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void FixTransform(bool position)
			{
				throw null;
			}

			// Token: 0x17000E0F RID: 3599
			// (get) Token: 0x06005996 RID: 22934 RVA: 0x00002050 File Offset: 0x00000250
			public bool isNodeBone
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06005997 RID: 22935 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetLength(IKMapping.BoneMap nextBone)
			{
				throw null;
			}

			// Token: 0x06005998 RID: 22936 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetLocalSwingAxis(IKMapping.BoneMap swingTarget)
			{
				throw null;
			}

			// Token: 0x06005999 RID: 22937 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetLocalSwingAxis(IKMapping.BoneMap bone1, IKMapping.BoneMap bone2)
			{
				throw null;
			}

			// Token: 0x0600599A RID: 22938 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
				throw null;
			}

			// Token: 0x0600599B RID: 22939 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
				throw null;
			}

			// Token: 0x0600599C RID: 22940 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void UpdatePlane(bool rotation, bool position)
			{
				throw null;
			}

			// Token: 0x0600599D RID: 22941 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetIKPosition()
			{
				throw null;
			}

			// Token: 0x0600599E RID: 22942 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void MaintainRotation()
			{
				throw null;
			}

			// Token: 0x0600599F RID: 22943 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetToIKPosition()
			{
				throw null;
			}

			// Token: 0x060059A0 RID: 22944 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void FixToNode(IKSolverFullBody solver, float weight, IKSolver.Node fixNode = null)
			{
				throw null;
			}

			// Token: 0x060059A1 RID: 22945 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				throw null;
			}

			// Token: 0x060059A2 RID: 22946 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void PositionToPlane(IKSolverFullBody solver)
			{
				throw null;
			}

			// Token: 0x060059A3 RID: 22947 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
				throw null;
			}

			// Token: 0x060059A4 RID: 22948 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Swing(Vector3 swingTarget, float weight)
			{
				throw null;
			}

			// Token: 0x060059A5 RID: 22949 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
				throw null;
			}

			// Token: 0x060059A6 RID: 22950 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
				throw null;
			}

			// Token: 0x060059A7 RID: 22951 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void RotateToMaintain(float weight)
			{
				throw null;
			}

			// Token: 0x060059A8 RID: 22952 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Quaternion method_0(IKSolverFullBody solver)
			{
				throw null;
			}

			// Token: 0x17000E10 RID: 3600
			// (get) Token: 0x060059A9 RID: 22953 RVA: 0x00002050 File Offset: 0x00000250
			private Quaternion Quaternion_0
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0400655D RID: 25949
			public Transform transform;

			// Token: 0x0400655E RID: 25950
			public int chainIndex;

			// Token: 0x0400655F RID: 25951
			public int nodeIndex;

			// Token: 0x04006560 RID: 25952
			public Vector3 defaultLocalPosition;

			// Token: 0x04006561 RID: 25953
			public Quaternion defaultLocalRotation;

			// Token: 0x04006562 RID: 25954
			public Vector3 localSwingAxis;

			// Token: 0x04006563 RID: 25955
			public Vector3 localTwistAxis;

			// Token: 0x04006564 RID: 25956
			public Vector3 planePosition;

			// Token: 0x04006565 RID: 25957
			public Vector3 ikPosition;

			// Token: 0x04006566 RID: 25958
			public Quaternion defaultLocalTargetRotation;

			// Token: 0x04006567 RID: 25959
			private Quaternion maintainRotation;

			// Token: 0x04006568 RID: 25960
			public float length;

			// Token: 0x04006569 RID: 25961
			public Quaternion animatedRotation;

			// Token: 0x0400656A RID: 25962
			private Transform planeBone1;

			// Token: 0x0400656B RID: 25963
			private Transform planeBone2;

			// Token: 0x0400656C RID: 25964
			private Transform planeBone3;

			// Token: 0x0400656D RID: 25965
			private int plane1ChainIndex;

			// Token: 0x0400656E RID: 25966
			private int plane1NodeIndex;

			// Token: 0x0400656F RID: 25967
			private int plane2ChainIndex;

			// Token: 0x04006570 RID: 25968
			private int plane2NodeIndex;

			// Token: 0x04006571 RID: 25969
			private int plane3ChainIndex;

			// Token: 0x04006572 RID: 25970
			private int plane3NodeIndex;
		}
	}
}
