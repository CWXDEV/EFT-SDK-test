using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace EFT.InventoryLogic
{
	// Token: 0x020022DE RID: 8926
	public interface IContainer
	{
		// Token: 0x17001EE5 RID: 7909
		// (get) Token: 0x0600B524 RID: 46372
		string ID { get; }

		// Token: 0x17001EE6 RID: 7910
		// (get) Token: 0x0600B525 RID: 46373
		IEnumerable<Item> Items { get; }

		// Token: 0x17001EE7 RID: 7911
		// (get) Token: 0x0600B526 RID: 46374
		// (set) Token: 0x0600B527 RID: 46375
		ItemFilter[] Filters { get; set; }

		// Token: 0x17001EE8 RID: 7912
		// (get) Token: 0x0600B528 RID: 46376
		Item ParentItem { get; }

		// Token: 0x17001EE9 RID: 7913
		// (get) Token: 0x0600B529 RID: 46377
		EParentMergeType MergeContainerWithChildren { get; }

		// Token: 0x0600B52A RID: 46378
		int GetHashSum();

		// Token: 0x0600B52B RID: 46379
		[CanBeNull]
		Item FindItem(string itemId);

		// Token: 0x0600B52C RID: 46380
		bool CheckCompatibility(Item item);
	}
}
