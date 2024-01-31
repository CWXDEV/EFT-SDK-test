using System;
using EFT.InventoryLogic;

// Token: 0x020021EE RID: 8686
public interface GInterface275 : IEffect, GInterface231, GInterface232, GInterface235
{
	// Token: 0x17001DC1 RID: 7617
	// (get) Token: 0x0600B165 RID: 45413
	Item MedItem { get; }

	// Token: 0x17001DC2 RID: 7618
	// (get) Token: 0x0600B166 RID: 45414
	float Amount { get; }

	// Token: 0x17001DC3 RID: 7619
	// (get) Token: 0x0600B167 RID: 45415
	bool NoMove { get; }
}
