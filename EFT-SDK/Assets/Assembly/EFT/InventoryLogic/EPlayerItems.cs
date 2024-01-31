using System;

namespace EFT.InventoryLogic
{
	// Token: 0x02002455 RID: 9301
	[Flags]
	public enum EPlayerItems
	{
		// Token: 0x0400BD61 RID: 48481
		Stash = 1,
		// Token: 0x0400BD62 RID: 48482
		Equipment = 2,
		// Token: 0x0400BD63 RID: 48483
		QuestItems = 4,
		// Token: 0x0400BD64 RID: 48484
		SortingTable = 8,
		// Token: 0x0400BD65 RID: 48485
		HideoutStashes = 16,
		// Token: 0x0400BD66 RID: 48486
		All = 31,
		// Token: 0x0400BD67 RID: 48487
		AllExceptHideoutStashes = 15,
		// Token: 0x0400BD68 RID: 48488
		NonQuestItems = 27,
		// Token: 0x0400BD69 RID: 48489
		NonQuestItemsExceptHideoutStashes = 11
	}
}
