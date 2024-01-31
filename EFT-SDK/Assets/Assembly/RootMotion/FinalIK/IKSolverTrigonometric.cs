using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010CC RID: 4300
	[Serializable]
	public class IKSolverTrigonometric : IKSolver
	{
		// Token: 0x06005A85 RID: 23173 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
			throw null;
		}

		// Token: 0x06005A86 RID: 23174 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBendGoalPosition(Vector3 goalPosition, Vector3 ikPos)
		{
			throw null;
		}

		// Token: 0x06005A87 RID: 23175 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBendPlaneToCurrent()
		{
			throw null;
		}

		// Token: 0x06005A88 RID: 23176 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetIKRotation(Quaternion rotation)
		{
			throw null;
		}

		// Token: 0x06005A89 RID: 23177 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetIKRotationWeight(float weight)
		{
			throw null;
		}

		// Token: 0x06005A8A RID: 23178 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Quaternion GetIKRotation()
		{
			throw null;
		}

		// Token: 0x06005A8B RID: 23179 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetIKRotationWeight()
		{
			throw null;
		}

		// Token: 0x06005A8C RID: 23180 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IKSolver.Point[] GetPoints()
		{
			throw null;
		}

		// Token: 0x06005A8D RID: 23181 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IKSolver.Point GetPoint(Transform transform)
		{
			throw null;
		}

		// Token: 0x06005A8E RID: 23182 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void StoreDefaultLocalState()
		{
			throw null;
		}

		// Token: 0x06005A8F RID: 23183 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void FixTransforms()
		{
			throw null;
		}

		// Token: 0x06005A90 RID: 23184 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool IsValid(ref string message)
		{
			throw null;
		}

		// Token: 0x06005A91 RID: 23185 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			throw null;
		}

		// Token: 0x06005A92 RID: 23186 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
			throw null;
		}

		// Token: 0x06005A93 RID: 23187 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SolveVirtual(IKSolver.Bone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
			throw null;
		}

		// Token: 0x06005A94 RID: 23188 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SolveVirtualPositions(IKSolver.Bone bone1, IKSolver.Bone bone2, IKSolver.Bone bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
			throw null;
		}

		// Token: 0x06005A95 RID: 23189 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Vector3 smethod_0(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			throw null;
		}

		// Token: 0x06005A96 RID: 23190 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnInitiate()
		{
			throw null;
		}

		// Token: 0x06005A97 RID: 23191 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_0()
		{
			throw null;
		}

		// Token: 0x06005A98 RID: 23192 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x06005A99 RID: 23193 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnUpdate()
		{
			throw null;
		}

		// Token: 0x06005A9A RID: 23194 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnInitiateVirtual()
		{
			throw null;
		}

		// Token: 0x06005A9B RID: 23195 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnUpdateVirtual()
		{
			throw null;
		}

		// Token: 0x06005A9C RID: 23196 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnPostSolveVirtual()
		{
			throw null;
		}

		// Token: 0x06005A9D RID: 23197 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			throw null;
		}

		// Token: 0x04006617 RID: 26135
		public Transform target;

		// Token: 0x04006618 RID: 26136
		[Range(0f, 1f)]
		public float IKRotationWeight;

		// Token: 0x04006619 RID: 26137
		public Quaternion IKRotation;

		// Token: 0x0400661A RID: 26138
		public Vector3 bendNormal;

		// Token: 0x0400661B RID: 26139
		public IKSolverTrigonometric.TrigonometricBone bone1;

		// Token: 0x0400661C RID: 26140
		public IKSolverTrigonometric.TrigonometricBone bone2;

		// Token: 0x0400661D RID: 26141
		public IKSolverTrigonometric.TrigonometricBone bone3;

		// Token: 0x0400661E RID: 26142
		protected Vector3 weightIKPosition;

		// Token: 0x0400661F RID: 26143
		protected bool directHierarchy;

		// Token: 0x020010CD RID: 4301
		[Serializable]
		public class TrigonometricBone : IKSolver.Bone
		{
			// Token: 0x06005A9E RID: 23198 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
				throw null;
			}

			// Token: 0x06005A9F RID: 23199 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				throw null;
			}

			// Token: 0x06005AA0 RID: 23200 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				throw null;
			}

			// Token: 0x04006620 RID: 26144
			private Quaternion targetToLocalSpace;

			// Token: 0x04006621 RID: 26145
			private Vector3 defaultLocalBendNormal;
		}
	}
}
