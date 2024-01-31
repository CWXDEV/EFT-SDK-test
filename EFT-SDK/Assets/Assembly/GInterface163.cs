using System;
using EFT.InventoryLogic;

// Token: 0x02001AD9 RID: 6873
public interface GInterface163
{
	// Token: 0x140001A5 RID: 421
	// (add) Token: 0x06009099 RID: 37017
	// (remove) Token: 0x0600909A RID: 37018
	event Action<Item, int> OnConsumableItemChanged;

	// Token: 0x170015E7 RID: 5607
	// (get) Token: 0x0600909B RID: 37019
	GClass2700[] UsingItems { get; }

	// Token: 0x170015E8 RID: 5608
	// (get) Token: 0x0600909C RID: 37020
	GClass1428 Slots { get; }

	// Token: 0x170015E9 RID: 5609
	// (get) Token: 0x0600909D RID: 37021
	bool Changeable { get; }

	// Token: 0x170015EA RID: 5610
	// (get) Token: 0x0600909E RID: 37022
	float Consumption { get; }

	// Token: 0x170015EB RID: 5611
	// (get) Token: 0x0600909F RID: 37023
	float ConsumptionReduction { get; }

	// Token: 0x060090A0 RID: 37024
	void InstallConsumableItems(GClass2700[] installedSupplies);
}
