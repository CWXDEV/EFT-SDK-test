using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Quests;
using Newtonsoft.Json;

// Token: 0x02003054 RID: 12372
public class RawQuestClass
{
	// Token: 0x170029C1 RID: 10689
	// (get) Token: 0x0600F32A RID: 62250 RVA: 0x00002050 File Offset: 0x00000250
	[JsonIgnore]
	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170029C2 RID: 10690
	// (get) Token: 0x0600F32B RID: 62251 RVA: 0x00002050 File Offset: 0x00000250
	[JsonIgnore]
	public virtual string NameLocaleKey
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170029C3 RID: 10691
	// (get) Token: 0x0600F32C RID: 62252 RVA: 0x00002050 File Offset: 0x00000250
	[JsonIgnore]
	public string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170029C4 RID: 10692
	// (get) Token: 0x0600F32D RID: 62253 RVA: 0x00002050 File Offset: 0x00000250
	[JsonIgnore]
	public string DescriptionKey
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170029C5 RID: 10693
	// (get) Token: 0x0600F32E RID: 62254 RVA: 0x00002050 File Offset: 0x00000250
	[JsonIgnore]
	public string ChangeQuestText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170029C6 RID: 10694
	// (get) Token: 0x0600F32F RID: 62255 RVA: 0x00002050 File Offset: 0x00000250
	[JsonIgnore]
	public string SuccessMessageText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600F330 RID: 62256 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ETaskPlayerSide GetPlayerSide()
	{
		throw null;
	}

	// Token: 0x0600F331 RID: 62257 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual GClass1246 CreateNewQuest(QuestDataClass statusData, Dictionary<string, GClass3218> conditionCounters, bool fromServer)
	{
		throw null;
	}

	// Token: 0x0400F94A RID: 63818
	[JsonProperty("_id")]
	public string Id;

	// Token: 0x0400F94B RID: 63819
	[JsonProperty("location")]
	public string LocationId;

	// Token: 0x0400F94C RID: 63820
	[JsonProperty("min_level")]
	public int Level;

	// Token: 0x0400F94D RID: 63821
	[JsonProperty("restartable")]
	public bool Restartable;

	// Token: 0x0400F94E RID: 63822
	[JsonProperty("traderId")]
	public string TraderId;

	// Token: 0x0400F94F RID: 63823
	[JsonProperty("image")]
	public string Image;

	// Token: 0x0400F950 RID: 63824
	[JsonProperty("type")]
	public RawQuestClass.EQuestType QuestType;

	// Token: 0x0400F951 RID: 63825
	[JsonProperty("templateId")]
	public string TemplateId;

	// Token: 0x0400F952 RID: 63826
	[JsonProperty("status")]
	public EQuestStatus AppearStatus;

	// Token: 0x0400F953 RID: 63827
	[JsonProperty("KeyQuest")]
	public bool KeyQuest;

	// Token: 0x0400F954 RID: 63828
	[JsonProperty("rewards")]
	public Dictionary<EQuestStatus, List<GClass3244>> Rewards;

	// Token: 0x0400F955 RID: 63829
	[JsonProperty("conditions")]
	public GClass3220 Conditions;

	// Token: 0x0400F956 RID: 63830
	[JsonProperty("canShowNotificationsInGame")]
	public bool CanShowNotificationsInGame;

	// Token: 0x0400F957 RID: 63831
	[JsonProperty("instantComplete")]
	public bool InstantComplete;

	// Token: 0x0400F958 RID: 63832
	[JsonProperty("side")]
	public EPlayerGroup PlayerGroup;

	// Token: 0x0400F959 RID: 63833
	[JsonProperty("secretQuest")]
	public bool ServerOnly;

	// Token: 0x0400F95A RID: 63834
	[JsonProperty("name")]
	private string string_0;

	// Token: 0x0400F95B RID: 63835
	[JsonProperty("successMessageText")]
	public string QuestSuccessMessageKey;

	// Token: 0x0400F95C RID: 63836
	[JsonProperty("changeQuestMessageText")]
	private string string_1;

	// Token: 0x0400F95D RID: 63837
	[JsonProperty("description")]
	private string string_2;

	// Token: 0x0400F95E RID: 63838
	[JsonProperty("acceptPlayerMessage")]
	public string AcceptPlayerMessageKey;

	// Token: 0x0400F95F RID: 63839
	[JsonProperty("declinePlayerMessage")]
	public string DeclinePlayerMessageKey;

	// Token: 0x0400F960 RID: 63840
	[JsonProperty("completePlayerMessage")]
	public string CompletePlayerMessageKey;

	// Token: 0x02003055 RID: 12373
	public enum EQuestType
	{
		// Token: 0x0400F962 RID: 63842
		PickUp,
		// Token: 0x0400F963 RID: 63843
		Elimination,
		// Token: 0x0400F964 RID: 63844
		Discover,
		// Token: 0x0400F965 RID: 63845
		Completion,
		// Token: 0x0400F966 RID: 63846
		Exploration,
		// Token: 0x0400F967 RID: 63847
		Levelling,
		// Token: 0x0400F968 RID: 63848
		Experience,
		// Token: 0x0400F969 RID: 63849
		Standing,
		// Token: 0x0400F96A RID: 63850
		Loyalty,
		// Token: 0x0400F96B RID: 63851
		Merchant,
		// Token: 0x0400F96C RID: 63852
		Skill,
		// Token: 0x0400F96D RID: 63853
		Multi,
		// Token: 0x0400F96E RID: 63854
		WeaponAssembly
	}

	// Token: 0x02003056 RID: 12374
	public enum EStatQuestType
	{
		// Token: 0x0400F970 RID: 63856
		BringItemToTrader,
		// Token: 0x0400F971 RID: 63857
		Eliminate,
		// Token: 0x0400F972 RID: 63858
		SurviveOnLocation
	}
}
