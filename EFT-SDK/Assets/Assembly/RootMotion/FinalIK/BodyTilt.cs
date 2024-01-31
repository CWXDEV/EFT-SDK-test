using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010F5 RID: 4341
	public class BodyTilt : OffsetModifier
	{
		// Token: 0x06005B98 RID: 23448 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Start()
		{
			throw null;
		}

		// Token: 0x06005B99 RID: 23449 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnModifyOffset()
		{
			throw null;
		}

		// Token: 0x0400670D RID: 26381
		[Tooltip("Speed of tilting")]
		public float tiltSpeed;

		// Token: 0x0400670E RID: 26382
		[Tooltip("Sensitivity of tilting")]
		public float tiltSensitivity;

		// Token: 0x0400670F RID: 26383
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseLeft;

		// Token: 0x04006710 RID: 26384
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseRight;

		// Token: 0x04006711 RID: 26385
		private float float_1;

		// Token: 0x04006712 RID: 26386
		private Vector3 vector3_0;
	}
}
