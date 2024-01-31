using System;

namespace EFT.Interactive
{
	// Token: 0x020027D6 RID: 10198
	[Flags]
	public enum EVolumeRelationsMask
	{
		// Token: 0x0400CC6B RID: 52331
		Self = 1,
		// Token: 0x0400CC6C RID: 52332
		Connected = 2,
		// Token: 0x0400CC6D RID: 52333
		NotRelative = 4,
		// Token: 0x0400CC6E RID: 52334
		Vertical = 8,
		// Token: 0x0400CC6F RID: 52335
		Isolated = 16,
		// Token: 0x0400CC70 RID: 52336
		Stairs = 32
	}
}
