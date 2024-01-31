using System;

namespace EFT.Game.Spawning
{
	// Token: 0x0200268B RID: 9867
	[Flags]
	public enum ESpawnCategoryMask
	{
		// Token: 0x0400C5B0 RID: 50608
		None = 0,
		// Token: 0x0400C5B1 RID: 50609
		Player = 1,
		// Token: 0x0400C5B2 RID: 50610
		Bot = 2,
		// Token: 0x0400C5B3 RID: 50611
		Boss = 4,
		// Token: 0x0400C5B4 RID: 50612
		Coop = 8,
		// Token: 0x0400C5B5 RID: 50613
		Group = 16,
		// Token: 0x0400C5B6 RID: 50614
		Opposite = 32,
		// Token: 0x0400C5B7 RID: 50615
		All = 7
	}
}
