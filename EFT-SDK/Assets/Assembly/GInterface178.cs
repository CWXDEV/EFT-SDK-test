using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Comfort.Common;
using EFT;
using EFT.Trading;
using UnityEngine;

// Token: 0x02001D2F RID: 7471
public interface GInterface178
{
	// Token: 0x06009A9C RID: 39580
	Task<Result<ECaptchaResult>> RequestCaptcha();

	// Token: 0x06009A9D RID: 39581
	Task<Result<TraderAssortment>> GetTraderAssortment(string traderId);

	// Token: 0x06009A9E RID: 39582
	Task<Result<SupplyData>> GetSupplyData(string traderId);

	// Token: 0x06009A9F RID: 39583
	void ConfirmSell(string traderId, TradingItemReference[] items, int price, Callback onFinished);

	// Token: 0x06009AA0 RID: 39584
	Task<IResult> SellAllFromSavage(string playerId, string petId);

	// Token: 0x06009AA1 RID: 39585
	void BuyCustomizationWear(string offer, IEnumerable<GClass1223> items, Callback onFinished);

	// Token: 0x06009AA2 RID: 39586
	Task<IResult> ConfirmPurchase(string traderId, string itemId, int count, int schemeId, TradingItemReference[] items);

	// Token: 0x06009AA3 RID: 39587
	Task<Texture2D> LoadAvatar(string url);

	// Token: 0x1700180B RID: 6155
	// (get) Token: 0x06009AA4 RID: 39588
	IEnumerable<TraderClass> Traders { get; }

	// Token: 0x1700180C RID: 6156
	// (get) Token: 0x06009AA5 RID: 39589
	IEnumerable<TraderClass> DisplayableTraders { get; }

	// Token: 0x1700180D RID: 6157
	// (get) Token: 0x06009AA6 RID: 39590
	IEnumerable<TraderClass> Insurers { get; }

	// Token: 0x1700180E RID: 6158
	// (get) Token: 0x06009AA7 RID: 39591
	IEnumerable<TraderClass> Repairers { get; }

	// Token: 0x1700180F RID: 6159
	// (get) Token: 0x06009AA8 RID: 39592
	InsuranceCompanyClass InsuranceCompany { get; }

	// Token: 0x17001810 RID: 6160
	// (get) Token: 0x06009AA9 RID: 39593
	TraderClass Medic { get; }

	// Token: 0x06009AAA RID: 39594
	TraderClass GetTrader(string traderId);

	// Token: 0x06009AAB RID: 39595
	void GetOffers(string traderId, Callback<GClass2938[]> onFinished);

	// Token: 0x06009AAC RID: 39596
	Task<IResult> RepairItemsByTrader(string traderId, RepairItem repairItem);

	// Token: 0x06009AAD RID: 39597
	void InsureItems(string[] items, string traderId, Callback callback);

	// Token: 0x06009AAE RID: 39598
	void GetInsurancePrice(string[] traderId, string[] itemIds, Callback<Dictionary<string, Dictionary<string, int>>> callback);
}
