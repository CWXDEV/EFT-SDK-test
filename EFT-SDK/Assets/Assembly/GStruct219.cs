using System;
using System.Runtime.InteropServices;
using EFT.Quests;

// Token: 0x02001632 RID: 5682
[StructLayout(LayoutKind.Auto)]
public struct GStruct219
{
	// Token: 0x04008078 RID: 32888
	public int QuestId;

	// Token: 0x04008079 RID: 32889
	public EQuestStatus Status;

	// Token: 0x0400807A RID: 32890
	public int ConditionId;

	// Token: 0x0400807B RID: 32891
	public double Value;

	// Token: 0x0400807C RID: 32892
	public bool Notify;
}
