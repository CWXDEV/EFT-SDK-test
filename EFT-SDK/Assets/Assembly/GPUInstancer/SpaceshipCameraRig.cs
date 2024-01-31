using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GPUInstancer
{
	// Token: 0x02000E68 RID: 3688
	public class SpaceshipCameraRig : MonoBehaviour
	{
		// Token: 0x06004D06 RID: 19718 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x06004D07 RID: 19719 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FixedUpdate()
		{
			throw null;
		}

		// Token: 0x06004D08 RID: 19720 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(float deltaTime)
		{
			throw null;
		}

		// Token: 0x04005872 RID: 22642
		public Transform m_Target;

		// Token: 0x04005873 RID: 22643
		public float m_MoveSpeed;

		// Token: 0x04005874 RID: 22644
		public float m_TurnSpeed;

		// Token: 0x04005875 RID: 22645
		public float m_RollSpeed;

		// Token: 0x04005876 RID: 22646
		public bool m_FollowVelocity;

		// Token: 0x04005877 RID: 22647
		public bool m_FollowTilt;

		// Token: 0x04005878 RID: 22648
		public float m_SpinTurnLimit;

		// Token: 0x04005879 RID: 22649
		public float m_TargetVelocityLowerLimit;

		// Token: 0x0400587A RID: 22650
		public float m_SmoothTurnTime;

		// Token: 0x0400587B RID: 22651
		private Vector3 vector3_0;

		// Token: 0x0400587C RID: 22652
		private Rigidbody rigidbody_0;

		// Token: 0x0400587D RID: 22653
		private float float_0;

		// Token: 0x0400587E RID: 22654
		private float float_1;

		// Token: 0x0400587F RID: 22655
		private float float_2;

		// Token: 0x04005880 RID: 22656
		private Vector3 vector3_1;
	}
}
