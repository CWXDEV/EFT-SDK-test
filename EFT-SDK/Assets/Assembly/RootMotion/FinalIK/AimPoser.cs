using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010F0 RID: 4336
	public class AimPoser : MonoBehaviour
	{
		// Token: 0x06005B91 RID: 23441 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AimPoser.Pose GetPose(Vector3 localDirection)
		{
			throw null;
		}

		// Token: 0x06005B92 RID: 23442 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPoseActive(AimPoser.Pose pose)
		{
			throw null;
		}

		// Token: 0x040066F9 RID: 26361
		public float angleBuffer;

		// Token: 0x040066FA RID: 26362
		public AimPoser.Pose[] poses;

		// Token: 0x020010F1 RID: 4337
		[Serializable]
		public class Pose
		{
			// Token: 0x06005B93 RID: 23443 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsInDirection(Vector3 d)
			{
				throw null;
			}

			// Token: 0x06005B94 RID: 23444 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetAngleBuffer(float value)
			{
				throw null;
			}

			// Token: 0x040066FB RID: 26363
			public bool visualize;

			// Token: 0x040066FC RID: 26364
			public string name;

			// Token: 0x040066FD RID: 26365
			public Vector3 direction;

			// Token: 0x040066FE RID: 26366
			public float yaw;

			// Token: 0x040066FF RID: 26367
			public float pitch;

			// Token: 0x04006700 RID: 26368
			private float angleBuffer;
		}
	}
}
