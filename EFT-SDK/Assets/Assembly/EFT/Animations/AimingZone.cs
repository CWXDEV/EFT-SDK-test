using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Animations
{
	// Token: 0x02001EEE RID: 7918
	[Serializable]
	public class AimingZone
	{
		// Token: 0x0600A38E RID: 41870 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Rotate(Vector2 deltaRotation)
		{
			throw null;
		}

		// Token: 0x0600A38F RID: 41871 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x0600A390 RID: 41872 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetAimingRotation()
		{
			throw null;
		}

		// Token: 0x0600A391 RID: 41873 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector2 GetBodyRotation()
		{
			throw null;
		}

		// Token: 0x0400AABB RID: 43707
		private readonly float _aimingZoneRadius;

		// Token: 0x0400AABC RID: 43708
		private readonly float _aimingSensitivity;

		// Token: 0x0400AABD RID: 43709
		private Vector2 _rotation;

		// Token: 0x0400AABE RID: 43710
		private Vector2 _cachedAimingRotation;
	}
}
