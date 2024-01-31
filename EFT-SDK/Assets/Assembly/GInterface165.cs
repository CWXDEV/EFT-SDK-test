using System;
using System.Collections.Generic;
using EFT.InventoryLogic;

// Token: 0x02001AEC RID: 6892
public interface GInterface165
{
	// Token: 0x140001A7 RID: 423
	// (add) Token: 0x06009108 RID: 37128
	// (remove) Token: 0x06009109 RID: 37129
	event Action<GInterface165> OnCompleteItemsCountChanged;

	// Token: 0x170015FB RID: 5627
	// (get) Token: 0x0600910A RID: 37130
	bool AnyItemsReady { get; }

	// Token: 0x170015FC RID: 5628
	// (get) Token: 0x0600910B RID: 37131
	bool Fulfilled { get; }

	// Token: 0x170015FD RID: 5629
	// (get) Token: 0x0600910C RID: 37132
	int CompleteItemsCount { get; }

	// Token: 0x170015FE RID: 5630
	// (get) Token: 0x0600910D RID: 37133
	int EarliestCompleteTime { get; }

	// Token: 0x0600910E RID: 37134
	void AddItem(string scheme, Item item);

	// Token: 0x0600910F RID: 37135
	void SetItems(string scheme, IEnumerable<Item> items, int completeTime);

	// Token: 0x06009110 RID: 37136
	int GetItemsCount(string scheme);

	// Token: 0x06009111 RID: 37137
	int GetItemsLimit(string scheme);

	// Token: 0x06009112 RID: 37138
	List<Item> GetItems(string scheme);

	// Token: 0x06009113 RID: 37139
	ValueTuple<string, List<Item>> FindCompleteItems();

	// Token: 0x06009114 RID: 37140
	void Clear(string scheme);

	// Token: 0x06009115 RID: 37141
	void InitStorage(IEnumerable<GClass1919> schemes);

	// Token: 0x06009116 RID: 37142
	void SetAdditionalProductionLimit(int additionalLimit);
}
