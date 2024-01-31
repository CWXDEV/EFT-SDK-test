using System;
using Comfort.Common;

// Token: 0x02001506 RID: 5382
public interface IHandsController : GInterface123, GInterface124, GInterface126
{
	// Token: 0x1700123F RID: 4671
	// (get) Token: 0x060073BF RID: 29631
	GrenadeClass Item { get; }

	// Token: 0x060073C0 RID: 29632
	void ExamineWeapon();

	// Token: 0x060073C1 RID: 29633
	void PullRingForHighThrow();

	// Token: 0x17001240 RID: 4672
	// (get) Token: 0x060073C2 RID: 29634
	bool WaitingForHighThrow { get; }

	// Token: 0x060073C3 RID: 29635
	void HighThrow();

	// Token: 0x060073C4 RID: 29636
	void PullRingForLowThrow();

	// Token: 0x17001241 RID: 4673
	// (get) Token: 0x060073C5 RID: 29637
	bool WaitingForLowThrow { get; }

	// Token: 0x060073C6 RID: 29638
	void LowThrow();

	// Token: 0x060073C7 RID: 29639
	void SetOnUsedCallback(Callback<IHandsController> callback);

	// Token: 0x060073C8 RID: 29640
	bool CanThrow();
}
