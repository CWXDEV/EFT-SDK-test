using System;

namespace EFT.InventoryLogic
{
	// Token: 0x0200255A RID: 9562
	[Flags]
	public enum ETargetContainer
	{
		// Token: 0x0400C15A RID: 49498
		None = 1,
		// Token: 0x0400C15B RID: 49499
		Stash = 2,
		// Token: 0x0400C15C RID: 49500
		Equipment = 4,
		// Token: 0x0400C15D RID: 49501
		SortingTable = 8,
		// Token: 0x0400C15E RID: 49502
		HideoutAreaStash = 16,
		// Token: 0x0400C15F RID: 49503
		All = 30
	}
}
