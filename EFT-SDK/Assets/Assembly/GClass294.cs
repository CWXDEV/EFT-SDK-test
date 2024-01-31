using System;
using EFT;

// Token: 0x020003BD RID: 957
public abstract class GClass294 : GClass291
{
	// Token: 0x1700042F RID: 1071
	// (get) Token: 0x06001704 RID: 5892
	public abstract BotOwner Bot { get; }

	// Token: 0x06001705 RID: 5893
	public abstract void SetBoss(GClass377 sectantPriest);

	// Token: 0x06001706 RID: 5894
	public abstract void SetAttackWithDelay(float minDelayToSupportSec);

	// Token: 0x06001707 RID: 5895
	public abstract bool IsCurShootAndRun();

	// Token: 0x06001708 RID: 5896
	public abstract bool TryChangeToMelee();
}
