using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Impostors
{
	// Token: 0x02001DBC RID: 7612
	[Serializable]
	public struct ImpostorBounds
	{
		// Token: 0x1700189D RID: 6301
		// (get) Token: 0x06009CD4 RID: 40148 RVA: 0x00002050 File Offset: 0x00000250
		public static int Stride
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400A471 RID: 42097
		public Vector3 Center;

		// Token: 0x0400A472 RID: 42098
		public float Size;

		// Token: 0x0400A473 RID: 42099
		public float Near;

		// Token: 0x0400A474 RID: 42100
		public float Far;

		// Token: 0x0400A475 RID: 42101
		public Vector2 Padding;
	}
}
