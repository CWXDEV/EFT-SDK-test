using System;
using EFT;
using EFT.InventoryLogic;
using Newtonsoft.Json;

// Token: 0x020023D8 RID: 9176
public class RepairKitClass : ItemTemplate
{
	// Token: 0x0400BBCC RID: 48076
	[JsonProperty("MaxRepairResource")]
	public int MaxRepairResource;

	// Token: 0x0400BBCD RID: 48077
	[JsonProperty("TargetItemFilter")]
	public string[] TargetItemFilter;

	// Token: 0x0400BBCE RID: 48078
	[JsonProperty("RepairQuality")]
	public float RepairQuality;

	// Token: 0x0400BBCF RID: 48079
	[JsonProperty("RepairStrategyTypes")]
	public ERepairStrategyType[] RepairStrategyTypes;
}
