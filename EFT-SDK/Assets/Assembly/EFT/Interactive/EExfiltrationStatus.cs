using System;

namespace EFT.Interactive
{
	// Token: 0x02002728 RID: 10024
	public enum EExfiltrationStatus : byte
	{
		// Token: 0x0400C8DF RID: 51423
		NotPresent = 1,
		// Token: 0x0400C8E0 RID: 51424
		UncompleteRequirements,
		// Token: 0x0400C8E1 RID: 51425
		Countdown,
		// Token: 0x0400C8E2 RID: 51426
		RegularMode,
		// Token: 0x0400C8E3 RID: 51427
		Pending,
		// Token: 0x0400C8E4 RID: 51428
		AwaitsManualActivation
	}
}
