using System;
using EFT.InventoryLogic;

// Token: 0x02002512 RID: 9490
public interface GInterface322 : IRollback, GInterface321
{
	// Token: 0x170021D1 RID: 8657
	// (get) Token: 0x0600BE4B RID: 48715
	Item Item { get; }

	// Token: 0x170021D2 RID: 8658
	// (get) Token: 0x0600BE4C RID: 48716
	Item ResultItem { get; }
}
