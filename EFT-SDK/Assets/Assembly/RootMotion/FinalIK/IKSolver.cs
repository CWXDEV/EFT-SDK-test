using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010B8 RID: 4280
	[Serializable]
	public abstract class IKSolver
	{
		// Token: 0x060059C4 RID: 22980 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsValid()
		{
			throw null;
		}

		// Token: 0x060059C5 RID: 22981
		public abstract bool IsValid(ref string message);

		// Token: 0x060059C6 RID: 22982 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initiate(Transform root)
		{
			throw null;
		}

		// Token: 0x060059C7 RID: 22983 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			throw null;
		}

		// Token: 0x060059C8 RID: 22984 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Vector3 GetIKPosition()
		{
			throw null;
		}

		// Token: 0x060059C9 RID: 22985 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetIKPosition(Vector3 position)
		{
			throw null;
		}

		// Token: 0x060059CA RID: 22986 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetIKPositionWeight()
		{
			throw null;
		}

		// Token: 0x060059CB RID: 22987 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetIKPositionWeight(float weight)
		{
			throw null;
		}

		// Token: 0x060059CC RID: 22988 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Transform GetRoot()
		{
			throw null;
		}

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x060059CD RID: 22989 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060059CE RID: 22990 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x060059CF RID: 22991
		public abstract IKSolver.Point[] GetPoints();

		// Token: 0x060059D0 RID: 22992
		public abstract IKSolver.Point GetPoint(Transform transform);

		// Token: 0x060059D1 RID: 22993
		public abstract void FixTransforms();

		// Token: 0x060059D2 RID: 22994
		public abstract void StoreDefaultLocalState();

		// Token: 0x060059D3 RID: 22995
		protected abstract void OnInitiate();

		// Token: 0x060059D4 RID: 22996
		protected abstract void OnUpdate();

		// Token: 0x060059D5 RID: 22997 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void LogWarning(string message)
		{
			throw null;
		}

		// Token: 0x060059D6 RID: 22998 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Transform ContainsDuplicateBone(IKSolver.Bone[] bones)
		{
			throw null;
		}

		// Token: 0x060059D7 RID: 22999 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool HierarchyIsValid(IKSolver.Bone[] bones)
		{
			throw null;
		}

		// Token: 0x060059D8 RID: 23000 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static float PreSolveBones(ref IKSolver.Bone[] bones)
		{
			throw null;
		}

		// Token: 0x060059D9 RID: 23001 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SolverRotateBonesAroundPoint(IKSolver.Bone[] bones, int index, Vector3 point, Quaternion rotation)
		{
			throw null;
		}

		// Token: 0x060059DA RID: 23002 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SolverRotate(IKSolver.Bone[] bones, int index, Quaternion rotation)
		{
			throw null;
		}

		// Token: 0x04006593 RID: 26003
		public bool Quick;

		// Token: 0x04006594 RID: 26004
		[HideInInspector]
		public Vector3 IKPosition;

		// Token: 0x04006595 RID: 26005
		[Range(0f, 1f)]
		public float IKPositionWeight;

		// Token: 0x04006597 RID: 26007
		public IKSolver.GDelegate39 OnPreInitiate;

		// Token: 0x04006598 RID: 26008
		public IKSolver.GDelegate39 OnPostInitiate;

		// Token: 0x04006599 RID: 26009
		public IKSolver.GDelegate39 OnPreUpdate;

		// Token: 0x0400659A RID: 26010
		public IKSolver.GDelegate39 OnPostUpdate;

		// Token: 0x0400659B RID: 26011
		protected bool firstInitiation;

		// Token: 0x0400659C RID: 26012
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		// Token: 0x020010B9 RID: 4281
		[Serializable]
		public class Point
		{
			// Token: 0x060059DB RID: 23003 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void StoreDefaultLocalState()
			{
				throw null;
			}

			// Token: 0x060059DC RID: 23004 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void FixTransform()
			{
				throw null;
			}

			// Token: 0x060059DD RID: 23005 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void UpdateSolverPosition()
			{
				throw null;
			}

			// Token: 0x060059DE RID: 23006 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void UpdateSolverLocalPosition()
			{
				throw null;
			}

			// Token: 0x060059DF RID: 23007 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void UpdateSolverState()
			{
				throw null;
			}

			// Token: 0x060059E0 RID: 23008 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void UpdateSolverLocalState()
			{
				throw null;
			}

			// Token: 0x0400659D RID: 26013
			public Transform transform;

			// Token: 0x0400659E RID: 26014
			[Range(0f, 1f)]
			public float weight;

			// Token: 0x0400659F RID: 26015
			public Vector3 solverPosition;

			// Token: 0x040065A0 RID: 26016
			public Quaternion solverRotation;

			// Token: 0x040065A1 RID: 26017
			public Vector3 defaultLocalPosition;

			// Token: 0x040065A2 RID: 26018
			public Quaternion defaultLocalRotation;
		}

		// Token: 0x020010BA RID: 4282
		[Serializable]
		public class Bone : IKSolver.Point
		{
			// Token: 0x17000E12 RID: 3602
			// (get) Token: 0x060059E1 RID: 23009 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060059E2 RID: 23010 RVA: 0x00002050 File Offset: 0x00000250
			public RotationLimit rotationLimit
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
				[MethodImpl(MethodImplOptions.NoInlining)]
				set
				{
					throw null;
				}
			}

			// Token: 0x060059E3 RID: 23011 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
				throw null;
			}

			// Token: 0x060059E4 RID: 23012 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SolverSwing(IKSolver.Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
				throw null;
			}

			// Token: 0x060059E5 RID: 23013 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
				throw null;
			}

			// Token: 0x060059E6 RID: 23014 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Quaternion GetSolverSwing(Vector3 swingTarget, float weight = 1f)
			{
				throw null;
			}

			// Token: 0x060059E7 RID: 23015 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetToSolverPosition()
			{
				throw null;
			}

			// Token: 0x040065A3 RID: 26019
			public float length;

			// Token: 0x040065A4 RID: 26020
			public float sqrMag;

			// Token: 0x040065A5 RID: 26021
			public Vector3 axis;

			// Token: 0x040065A6 RID: 26022
			private RotationLimit _rotationLimit;

			// Token: 0x040065A7 RID: 26023
			private bool isLimited;
		}

		// Token: 0x020010BB RID: 4283
		[Serializable]
		public class Node : IKSolver.Point
		{
			// Token: 0x040065A8 RID: 26024
			public float length;

			// Token: 0x040065A9 RID: 26025
			public float effectorPositionWeight;

			// Token: 0x040065AA RID: 26026
			public float effectorRotationWeight;

			// Token: 0x040065AB RID: 26027
			public Vector3 offset;
		}

		// Token: 0x020010BC RID: 4284
		// (Invoke) Token: 0x060059E8 RID: 23016
		public delegate void GDelegate39();

		// Token: 0x020010BD RID: 4285
		// (Invoke) Token: 0x060059EB RID: 23019
		public delegate void GDelegate40(int i);
	}
}
