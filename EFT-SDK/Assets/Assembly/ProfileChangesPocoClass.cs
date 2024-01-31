using System;
using System.Collections.Generic;
using EFT;
using EFT.Hideout;
using EFT.UI.Ragfair;
using Newtonsoft.Json;

// Token: 0x02001810 RID: 6160
public sealed class ProfileChangesPocoClass
{
	// Token: 0x04008B56 RID: 35670
	[JsonProperty("experience")]
	public int Experience;

	// Token: 0x04008B57 RID: 35671
	[JsonProperty("items")]
	public GClass1843 Stash;

	// Token: 0x04008B58 RID: 35672
	[JsonProperty("quests")]
	public RawQuestClass[] Quests;

	// Token: 0x04008B59 RID: 35673
	[JsonProperty("repeatableQuests")]
	public DailyQuestClass[] RepeatableQuests;

	// Token: 0x04008B5A RID: 35674
	[JsonProperty("ragFairOffers")]
	public Offer[] RagFairOffers;

	// Token: 0x04008B5B RID: 35675
	[JsonProperty("traderRelations")]
	public Dictionary<string, TraderData> TradersData;

	// Token: 0x04008B5C RID: 35676
	[JsonProperty("recipeUnlocked")]
	public Dictionary<string, bool> UnlockedRecipes;

	// Token: 0x04008B5D RID: 35677
	[JsonProperty("production")]
	public Dictionary<string, ProductionData> Production;

	// Token: 0x04008B5E RID: 35678
	[JsonProperty("improvements")]
	public Dictionary<string, GClass1910> Improvements;

	// Token: 0x04008B5F RID: 35679
	[JsonProperty("skills")]
	public SkillManager Skills;

	// Token: 0x04008B60 RID: 35680
	[JsonProperty("questsStatus")]
	public QuestDataClass[] QuestsStatus;

	// Token: 0x04008B61 RID: 35681
	[JsonProperty("changedHideoutStashes")]
	public Dictionary<EAreaType, HideoutAreaStashInfo> HideoutAreaStashes;
}
