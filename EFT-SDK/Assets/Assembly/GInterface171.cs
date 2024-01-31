using System;
using System.Threading.Tasks;
using EFT.Hideout;
using EFT.UI;

// Token: 0x02001B51 RID: 6993
public interface GInterface171 : IDisposable, IUIView
{
	// Token: 0x06009373 RID: 37747
	Task Show(RelatedData info, Stage stage, ELevelType levelType, AreaData areaData, InventoryControllerClass inventoryController, ISession session);
}
