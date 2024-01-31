using System;
using UnityEngine;

namespace EFT.Vaulting.Models
{
	// Token: 0x02001EAA RID: 7850
	public struct VaultingPoint
	{
		// Token: 0x0400A90C RID: 43276
		public int Index;

		// Token: 0x0400A90D RID: 43277
		public Vector3 LocalPoint;

		// Token: 0x0400A90E RID: 43278
		public Vector3 WorldPoint;

		// Token: 0x0400A90F RID: 43279
		public float Weight;

		// Token: 0x0400A910 RID: 43280
		public Collider Collider;
	}
}
