using System;
using EFT.InventoryLogic;

// Token: 0x02002562 RID: 9570
public interface GInterface333
{
	// Token: 0x17002226 RID: 8742
	// (get) Token: 0x0600BF6D RID: 49005
	GClass1742 FavoriteItems { get; }

	// Token: 0x0600BF6E RID: 49006
	bool ShouldSetFavoriteIcon(Item item, out bool isFavorite);
}
