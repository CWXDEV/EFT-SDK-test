using System;
using EFT.Airdrop;
using EFT.InventoryLogic;

// Token: 0x02001E45 RID: 7749
public interface GInterface188
{
	// Token: 0x06009EF0 RID: 40688
	void SendAirdropContainerData(EAirdropType containerType, Item item, int ObjectId, string id);

	// Token: 0x06009EF1 RID: 40689
	void SendFlareSuccessEvent(string profileId, bool canSendAirdrop);
}
