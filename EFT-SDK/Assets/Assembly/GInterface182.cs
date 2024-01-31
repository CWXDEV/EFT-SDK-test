using System;
using System.Threading;
using System.Threading.Tasks;
using Comfort.Common;
using EFT;
using EFT.InventoryLogic;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02001D86 RID: 7558
public interface GInterface182
{
	// Token: 0x17001869 RID: 6249
	// (get) Token: 0x06009BC9 RID: 39881
	string RepairerId { get; }

	// Token: 0x1700186A RID: 6250
	// (get) Token: 0x06009BCA RID: 39882
	string[] Targets { get; }

	// Token: 0x1700186B RID: 6251
	// (get) Token: 0x06009BCB RID: 39883
	string LocalizedName { get; }

	// Token: 0x06009BCC RID: 39884
	double GetRepairPriceCoefficient(Item item);

	// Token: 0x06009BCD RID: 39885
	bool TryGetEnhancementChance(Item item, float receiveDurabilityPercent, out double enhancementChance);

	// Token: 0x1700186C RID: 6252
	// (get) Token: 0x06009BCE RID: 39886
	double Standing { get; }

	// Token: 0x1700186D RID: 6253
	// (get) Token: 0x06009BCF RID: 39887
	int LoyaltyLevel { get; }

	// Token: 0x1700186E RID: 6254
	// (get) Token: 0x06009BD0 RID: 39888
	int MaxLoyaltyLevel { get; }

	// Token: 0x1700186F RID: 6255
	// (get) Token: 0x06009BD1 RID: 39889
	float CurrencyCoefficient { get; }

	// Token: 0x06009BD2 RID: 39890
	Task<bool> GetAndAssignAvatar(Image image, CancellationToken cancellationToken);

	// Token: 0x06009BD3 RID: 39891
	float GetRepairQuality(Item item);

	// Token: 0x06009BD4 RID: 39892
	Task<IResult> RepairItems(RepairItem repairItems, GClass2726 draggedRepairKit = null);

	// Token: 0x06009BD5 RID: 39893
	Vector2 GetDegradationValues(RepairableComponent repairable, Item item);
}
