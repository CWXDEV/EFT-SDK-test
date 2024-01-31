using System;
using EFT;
using EFT.InventoryLogic;
using Newtonsoft.Json;

// Token: 0x0200195E RID: 6494
public interface GInterface151
{
	// Token: 0x17001541 RID: 5441
	// (get) Token: 0x06008B72 RID: 35698
	[JsonIgnore]
	IExchangeRequirement[] Requirements { get; }

	// Token: 0x17001542 RID: 5442
	// (get) Token: 0x06008B73 RID: 35699
	[JsonIgnore]
	Item Item { get; }

	// Token: 0x17001543 RID: 5443
	// (get) Token: 0x06008B74 RID: 35700
	EMemberCategory MemberType { get; }

	// Token: 0x17001544 RID: 5444
	// (get) Token: 0x06008B75 RID: 35701
	int CurrentItemCount { get; }

	// Token: 0x17001545 RID: 5445
	// (get) Token: 0x06008B76 RID: 35702
	bool OnlyMoney { get; }

	// Token: 0x17001546 RID: 5446
	// (get) Token: 0x06008B77 RID: 35703
	string Id { get; }

	// Token: 0x17001547 RID: 5447
	// (get) Token: 0x06008B78 RID: 35704
	bool SellInOnePiece { get; }

	// Token: 0x17001548 RID: 5448
	// (get) Token: 0x06008B79 RID: 35705
	DateTime EndTime { get; }

	// Token: 0x17001549 RID: 5449
	// (get) Token: 0x06008B7A RID: 35706
	int BuyRestrictionMax { get; }

	// Token: 0x1700154A RID: 5450
	// (get) Token: 0x06008B7B RID: 35707
	// (set) Token: 0x06008B7C RID: 35708
	int BuyRestrictionCurrent { get; set; }
}
