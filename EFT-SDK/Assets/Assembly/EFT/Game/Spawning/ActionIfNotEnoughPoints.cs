using System;

namespace EFT.Game.Spawning
{
	// Token: 0x02002694 RID: 9876
	public enum ActionIfNotEnoughPoints
	{
		// Token: 0x0400C5BB RID: 50619
		ReturnFoundPoints,
		// Token: 0x0400C5BC RID: 50620
		ReturnNothing,
		// Token: 0x0400C5BD RID: 50621
		DuplicateIfAtLeastOne,
		// Token: 0x0400C5BE RID: 50622
		FillWithDiscardedPointsAndDuplicates
	}
}
