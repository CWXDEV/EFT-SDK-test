using System;
using System.Collections.Generic;
using EFT;
using EFT.Quests;
using UnityEngine;

// Token: 0x0200303C RID: 12348
public interface GInterface381
{
	// Token: 0x17002998 RID: 10648
	// (get) Token: 0x0600F2A8 RID: 62120
	string Id { get; }

	// Token: 0x17002999 RID: 10649
	// (get) Token: 0x0600F2A9 RID: 62121
	GClass3220 Conditions { get; }

	// Token: 0x1700299A RID: 10650
	// (get) Token: 0x0600F2AA RID: 62122
	ConditionCounterManager ConditionCountersManager { get; }

	// Token: 0x1700299B RID: 10651
	// (get) Token: 0x0600F2AB RID: 62123
	Dictionary<Condition, GClass3231> ProgressCheckers { get; }

	// Token: 0x1700299C RID: 10652
	// (get) Token: 0x0600F2AC RID: 62124
	HashSet<string> CompletedConditions { get; }

	// Token: 0x1700299D RID: 10653
	// (get) Token: 0x0600F2AD RID: 62125
	EQuestStatus QuestStatus { get; }

	// Token: 0x1700299E RID: 10654
	// (get) Token: 0x0600F2AE RID: 62126
	EQuestStatus[] CurrentStatusTransitions { get; }

	// Token: 0x1700299F RID: 10655
	// (get) Token: 0x0600F2AF RID: 62127
	ETaskPlayerSide PlayerSide { get; }

	// Token: 0x170029A0 RID: 10656
	// (get) Token: 0x0600F2B0 RID: 62128
	Dictionary<EQuestStatus, List<GClass3244>> Rewards { get; }

	// Token: 0x170029A1 RID: 10657
	// (get) Token: 0x0600F2B1 RID: 62129
	bool ReadyToFail { get; }

	// Token: 0x170029A2 RID: 10658
	// (get) Token: 0x0600F2B2 RID: 62130
	bool InstantComplete { get; }

	// Token: 0x170029A3 RID: 10659
	// (get) Token: 0x0600F2B3 RID: 62131
	bool ServerOnly { get; }

	// Token: 0x170029A4 RID: 10660
	// (get) Token: 0x0600F2B4 RID: 62132
	int FailTime { get; }

	// Token: 0x170029A5 RID: 10661
	// (get) Token: 0x0600F2B5 RID: 62133
	GClass3365 AvailableForFinishConditions { get; }

	// Token: 0x170029A6 RID: 10662
	// (get) Token: 0x0600F2B6 RID: 62134
	string Description { get; }

	// Token: 0x170029A7 RID: 10663
	// (get) Token: 0x0600F2B7 RID: 62135
	string Image { get; }

	// Token: 0x170029A8 RID: 10664
	// (get) Token: 0x0600F2B8 RID: 62136
	// (set) Token: 0x0600F2B9 RID: 62137
	Sprite Sprite { get; set; }

	// Token: 0x0600F2BA RID: 62138
	bool IsDone();

	// Token: 0x0600F2BB RID: 62139
	void SetStatus(EQuestStatus status, bool notify, bool fromServer);

	// Token: 0x0600F2BC RID: 62140
	bool IsConditionDone(Condition condition);

	// Token: 0x0600F2BD RID: 62141
	IEnumerable<TCondition> GetConditions<TCondition>(EQuestStatus status) where TCondition : Condition;

	// Token: 0x0600F2BE RID: 62142
	Condition GetCondition(string conditionId);

	// Token: 0x0600F2BF RID: 62143
	Condition GetCondition(int conditionId);

	// Token: 0x0600F2C0 RID: 62144
	Condition GetVisibilityCondition(string conditionId);

	// Token: 0x0600F2C1 RID: 62145
	Condition GetVisibilityCondition(int conditionId);

	// Token: 0x0600F2C2 RID: 62146
	void CheckForStatusChange(EQuestStatus status, bool notify, bool fromServer, bool canFail, Action<GInterface381> onFailed = null);

	// Token: 0x0600F2C3 RID: 62147
	void CheckForStatusChange(bool fromServer, bool canFail);

	// Token: 0x0600F2C4 RID: 62148
	void UpdateConditionsVisibility();

	// Token: 0x0600F2C5 RID: 62149
	bool CheckVisibilityStatus(Condition condition);

	// Token: 0x0600F2C6 RID: 62150
	void TransitionStatus(EQuestStatus status, bool fromServer);

	// Token: 0x0600F2C7 RID: 62151
	void DisconnectConditions();
}
