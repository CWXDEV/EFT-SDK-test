using System;
using EFT.UI;

// Token: 0x02002AE8 RID: 10984
public interface GInterface367 : IDisposable
{
	// Token: 0x0600DA2B RID: 55851
	void Show(InventoryControllerClass leftSideInventoryController = null, ItemsPanel.EItemsTab tab = ItemsPanel.EItemsTab.Gear);

	// Token: 0x0600DA2C RID: 55852
	void Close();
}
