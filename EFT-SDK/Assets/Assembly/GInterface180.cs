using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EFT;
using EFT.Counters;
using EFT.Quests;
using EFT.Trading;
using JetBrains.Annotations;

// Token: 0x02001D4F RID: 7503
public interface GInterface180
{
	// Token: 0x17001815 RID: 6165
	// (get) Token: 0x06009B09 RID: 39689
	string InitialDescriptionKey { get; }

	// Token: 0x06009B0A RID: 39690
	Task<string> ExecuteDialogOption(GStruct243 dialogData);

	// Token: 0x06009B0B RID: 39691
	Task<string> ExecuteQuestAction(GStruct243 dialogData, EQuestActionType actionType, GClass1246 completedQuest, [CanBeNull] ConditionItem condition);

	// Token: 0x06009B0C RID: 39692
	Task<string> ExecuteServiceAction(GStruct243 dialogData, IEnumerable<MongoID> handoverItems, bool anyReward);

	// Token: 0x06009B0D RID: 39693
	void SaveDialogState(CounterTag tag, int value);
}
