using System;
using EFT;

// Token: 0x020023D0 RID: 9168
public interface GInterface308
{
	// Token: 0x0600B8ED RID: 47341
	bool IsEncoded();

	// Token: 0x0600B8EE RID: 47342
	bool IsInitializedHandler();

	// Token: 0x0600B8EF RID: 47343
	void InitializeHandler(Player player);

	// Token: 0x0600B8F0 RID: 47344
	void OnAddRecodableItem(Player player);

	// Token: 0x0600B8F1 RID: 47345
	void OnRemoveRecodableItem();
}
