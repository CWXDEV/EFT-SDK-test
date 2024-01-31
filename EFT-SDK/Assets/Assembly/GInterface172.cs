using System;
using EFT;
using EFT.Hideout;
using EFT.UI;

// Token: 0x02001BB8 RID: 7096
public interface GInterface172 : IDisposable, IUIView
{
	// Token: 0x06009517 RID: 38167
	void Show(ItemUiContext itemUiContext, InventoryControllerClass inventoryController, Requirement requirement, EAreaType areaType, bool ignoreFulfillment);
}
