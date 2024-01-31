using System;

namespace EFT.Quests
{
	// Token: 0x02003052 RID: 12370
	public enum EQuestStatus
	{
		// Token: 0x0400F931 RID: 63793
		Locked,
		// Token: 0x0400F932 RID: 63794
		AvailableForStart,
		// Token: 0x0400F933 RID: 63795
		Started,
		// Token: 0x0400F934 RID: 63796
		AvailableForFinish,
		// Token: 0x0400F935 RID: 63797
		Success,
		// Token: 0x0400F936 RID: 63798
		Fail,
		// Token: 0x0400F937 RID: 63799
		FailRestartable,
		// Token: 0x0400F938 RID: 63800
		MarkedAsFailed,
		// Token: 0x0400F939 RID: 63801
		Expired,
		// Token: 0x0400F93A RID: 63802
		AvailableAfter
	}
}
