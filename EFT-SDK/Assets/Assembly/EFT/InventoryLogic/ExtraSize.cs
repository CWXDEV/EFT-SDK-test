using System;
using System.Runtime.CompilerServices;

namespace EFT.InventoryLogic
{
	// Token: 0x020024B0 RID: 9392
	public struct ExtraSize
	{
		// Token: 0x0600BC1B RID: 48155 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ExtraSize Merge(ExtraSize op1, ExtraSize op2)
		{
			throw null;
		}

		// Token: 0x0600BC1C RID: 48156 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct23 Apply(int width, int height)
		{
			throw null;
		}

		// Token: 0x0600BC1D RID: 48157 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400BEF5 RID: 48885
		public int Left;

		// Token: 0x0400BEF6 RID: 48886
		public int Right;

		// Token: 0x0400BEF7 RID: 48887
		public int Up;

		// Token: 0x0400BEF8 RID: 48888
		public int Down;

		// Token: 0x0400BEF9 RID: 48889
		public int ForcedLeft;

		// Token: 0x0400BEFA RID: 48890
		public int ForcedRight;

		// Token: 0x0400BEFB RID: 48891
		public int ForcedUp;

		// Token: 0x0400BEFC RID: 48892
		public int ForcedDown;
	}
}
