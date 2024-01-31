using System;
using Comfort.Common;
using EFT.InventoryLogic;

// Token: 0x0200150B RID: 5387
public interface GInterface132<T> : GInterface123, GInterface131 where T : Item
{
	// Token: 0x17001245 RID: 4677
	// (get) Token: 0x060073D9 RID: 29657
	T Item { get; }

	// Token: 0x060073DA RID: 29658
	void SetOnUsedCallback(Callback<GInterface132<T>> callback);
}
