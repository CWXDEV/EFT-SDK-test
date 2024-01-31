using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010C7 RID: 4295
	[Serializable]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		// Token: 0x06005A60 RID: 23136 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MaintainRotation()
		{
			throw null;
		}

		// Token: 0x06005A61 RID: 23137 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MaintainBend()
		{
			throw null;
		}

		// Token: 0x06005A62 RID: 23138 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnInitiateVirtual()
		{
			throw null;
		}

		// Token: 0x06005A63 RID: 23139 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnUpdateVirtual()
		{
			throw null;
		}

		// Token: 0x06005A64 RID: 23140 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnPostSolveVirtual()
		{
			throw null;
		}

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x06005A65 RID: 23141 RVA: 0x00002050 File Offset: 0x00000250
		private IKSolverLimb.AxisDirection[] AxisDirection_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06005A66 RID: 23142 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(ref IKSolverLimb.AxisDirection[] axisDirections)
		{
			throw null;
		}

		// Token: 0x06005A67 RID: 23143 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_3()
		{
			throw null;
		}

		// Token: 0x06005A68 RID: 23144 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
			throw null;
		}

		// Token: 0x040065EE RID: 26094
		public AvatarIKGoal goal;

		// Token: 0x040065EF RID: 26095
		public IKSolverLimb.BendModifier bendModifier;

		// Token: 0x040065F0 RID: 26096
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		// Token: 0x040065F1 RID: 26097
		[Range(0f, 1f)]
		public float bendModifierWeight;

		// Token: 0x040065F2 RID: 26098
		public Transform bendGoal;

		// Token: 0x040065F3 RID: 26099
		private bool maintainBendFor1Frame;

		// Token: 0x040065F4 RID: 26100
		private bool maintainRotationFor1Frame;

		// Token: 0x040065F5 RID: 26101
		private Quaternion defaultRootRotation;

		// Token: 0x040065F6 RID: 26102
		private Quaternion parentDefaultRotation;

		// Token: 0x040065F7 RID: 26103
		private Quaternion bone3RotationBeforeSolve;

		// Token: 0x040065F8 RID: 26104
		private Quaternion maintainRotation;

		// Token: 0x040065F9 RID: 26105
		private Quaternion bone3DefaultRotation;

		// Token: 0x040065FA RID: 26106
		private Vector3 _bendNormal;

		// Token: 0x040065FB RID: 26107
		private Vector3 animationNormal;

		// Token: 0x040065FC RID: 26108
		private IKSolverLimb.AxisDirection[] axisDirectionsLeft;

		// Token: 0x040065FD RID: 26109
		private IKSolverLimb.AxisDirection[] axisDirectionsRight;

		// Token: 0x020010C8 RID: 4296
		[Serializable]
		public enum BendModifier
		{
			// Token: 0x040065FF RID: 26111
			Animation,
			// Token: 0x04006600 RID: 26112
			Target,
			// Token: 0x04006601 RID: 26113
			Parent,
			// Token: 0x04006602 RID: 26114
			Arm,
			// Token: 0x04006603 RID: 26115
			Goal,
			// Token: 0x04006604 RID: 26116
			Custom
		}

		// Token: 0x020010C9 RID: 4297
		[Serializable]
		public struct AxisDirection
		{
			// Token: 0x04006605 RID: 26117
			public Vector3 direction;

			// Token: 0x04006606 RID: 26118
			public Vector3 axis;

			// Token: 0x04006607 RID: 26119
			public float dot;
		}
	}
}
