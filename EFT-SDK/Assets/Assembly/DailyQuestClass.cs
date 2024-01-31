using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Newtonsoft.Json;

// Token: 0x02003062 RID: 12386
public sealed class DailyQuestClass
{
	// Token: 0x170029C9 RID: 10697
	// (get) Token: 0x0600F345 RID: 62277 RVA: 0x00002050 File Offset: 0x00000250
	public int UpdateTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600F346 RID: 62278 RVA: 0x00002050 File Offset: 0x00000250
	[OnDeserialized]
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_0(StreamingContext context)
	{
		throw null;
	}

	// Token: 0x0400F97E RID: 63870
	[JsonProperty("id")]
	public readonly string Id;

	// Token: 0x0400F97F RID: 63871
	[JsonProperty("name")]
	public readonly string Name;

	// Token: 0x0400F980 RID: 63872
	[JsonProperty("unavailableTime", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public readonly int UnavailableTime;

	// Token: 0x0400F981 RID: 63873
	[JsonProperty("endTime")]
	public readonly int ExpirationTime;

	// Token: 0x0400F982 RID: 63874
	[JsonProperty("activeQuests")]
	public GClass3247[] Quests;

	// Token: 0x0400F983 RID: 63875
	[JsonProperty("changeRequirement")]
	public Dictionary<string, GStruct404> QuestChangeRequirement;

	// Token: 0x0400F984 RID: 63876
	[JsonProperty("inactiveQuests", DefaultValueHandling = DefaultValueHandling.Ignore)]
	public GClass3247[] InactiveQuests;
}
