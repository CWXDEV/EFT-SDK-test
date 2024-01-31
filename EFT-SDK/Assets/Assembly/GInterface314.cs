using System;
using System.Collections.Generic;
using EFT.InventoryLogic;

// Token: 0x02002460 RID: 9312
public interface GInterface314
{
	// Token: 0x0600BB1C RID: 47900
	IEnumerable<GStruct368> GetItemsOverDiscardLimit(Item item);

	// Token: 0x0600BB1D RID: 47901
	bool HasDiscardLimit(Item item, out int limit);

	// Token: 0x0600BB1E RID: 47902
	void SubtractFromDiscardLimits(Item rootItem, IEnumerable<GStruct368> destroyedItems);

	// Token: 0x0600BB1F RID: 47903
	void AddDiscardLimits(Item item, IEnumerable<GStruct368> destroyedItems);

	// Token: 0x0600BB20 RID: 47904
	void ResetDiscardLimits();
}
