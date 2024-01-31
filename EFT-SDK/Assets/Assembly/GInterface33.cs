using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;
using UnityEngine;

// Token: 0x020008D5 RID: 2261
public interface GInterface33
{
	// Token: 0x0600330D RID: 13069
	bool TryGetEnhancementChance(float repairAmount, out double enhancementChance);

	// Token: 0x0600330E RID: 13070
	string RepairabilityText(bool isRepairKit);

	// Token: 0x0600330F RID: 13071
	int TemplateDurability();

	// Token: 0x06003310 RID: 13072
	float Durability();

	// Token: 0x06003311 RID: 13073
	float MaxDurability();

	// Token: 0x06003312 RID: 13074
	float GetCurrentDurabilityFraction();

	// Token: 0x06003313 RID: 13075
	float GetMaxDurabilityFraction();

	// Token: 0x06003314 RID: 13076
	float HowMuchRepairScoresCanAccept();

	// Token: 0x06003315 RID: 13077
	ValueTuple<bool, bool> GetBuffState();

	// Token: 0x06003316 RID: 13078
	Vector2 GetDegradationValues(float repairAmount);

	// Token: 0x06003317 RID: 13079
	double GetPriceRate();

	// Token: 0x06003318 RID: 13080
	bool CanRepair(GInterface182 repairer, string[] excludedCategories);

	// Token: 0x06003319 RID: 13081
	float GetRepairQualityForDisplay();

	// Token: 0x0600331A RID: 13082
	float GetRepairQuality();

	// Token: 0x0600331B RID: 13083
	double GetRepairPrice(float repairValue, GClass799 repairKit);

	// Token: 0x0600331C RID: 13084
	bool IsNoCorrespondingArea();

	// Token: 0x0600331D RID: 13085
	bool IsEligibleForBuff();

	// Token: 0x0600331E RID: 13086
	bool BrokenItemError();

	// Token: 0x0600331F RID: 13087
	int GetCurrencyPrice(float amount);

	// Token: 0x170008BE RID: 2238
	// (get) Token: 0x06003320 RID: 13088
	List<GClass799> RepairKitsCollections { get; }

	// Token: 0x170008BF RID: 2239
	// (get) Token: 0x06003321 RID: 13089
	IEnumerable<GInterface182> Repairers { get; }

	// Token: 0x170008C0 RID: 2240
	// (get) Token: 0x06003322 RID: 13090
	// (set) Token: 0x06003323 RID: 13091
	GInterface182 CurrentRepairer { get; set; }

	// Token: 0x06003324 RID: 13092
	void AddRepairKitToRepairers(GClass2726 repairKit);

	// Token: 0x06003325 RID: 13093
	Task<IResult> RepairItem(float repairAmount, GClass2726 draggedRepairKit);
}
