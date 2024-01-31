using System;
using System.Collections.Generic;
using EFT.Quests;
using JetBrains.Annotations;
using Newtonsoft.Json;

// Token: 0x02003051 RID: 12369
public sealed class QuestDataClass
{
	// Token: 0x0400F929 RID: 63785
	[JsonProperty("qid")]
	public string Id;

	// Token: 0x0400F92A RID: 63786
	[JsonProperty("startTime")]
	public int StartTime;

	// Token: 0x0400F92B RID: 63787
	[JsonProperty("status")]
	public EQuestStatus Status;

	// Token: 0x0400F92C RID: 63788
	[JsonProperty("statusTimers")]
	public Dictionary<EQuestStatus, double> StatusStartTimestamps;

	// Token: 0x0400F92D RID: 63789
	[JsonProperty("completedConditions")]
	public HashSet<string> CompletedConditions;

	// Token: 0x0400F92E RID: 63790
	[JsonProperty("availableAfter")]
	public int AvailableAfter;

	// Token: 0x0400F92F RID: 63791
	[CanBeNull]
	[JsonIgnore]
	public RawQuestClass Template;
}
