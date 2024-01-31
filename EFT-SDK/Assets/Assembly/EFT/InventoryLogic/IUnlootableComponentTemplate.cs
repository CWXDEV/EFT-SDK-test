using System;

namespace EFT.InventoryLogic
{
	// Token: 0x020022B8 RID: 8888
	public interface IUnlootableComponentTemplate
	{
		// Token: 0x17001ECF RID: 7887
		// (get) Token: 0x0600B49E RID: 46238
		string SlotName { get; }

		// Token: 0x17001ED0 RID: 7888
		// (get) Token: 0x0600B49F RID: 46239
		EPlayerSideMask Side { get; }
	}
}
