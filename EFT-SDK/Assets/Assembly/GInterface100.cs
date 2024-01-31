using System;
using EFT;
using UnityEngine;

// Token: 0x020012C8 RID: 4808
public interface GInterface100
{
	// Token: 0x17001008 RID: 4104
	// (get) Token: 0x060063B1 RID: 25521
	GameObject gameObject { get; }

	// Token: 0x17001009 RID: 4105
	// (get) Token: 0x060063B2 RID: 25522
	GameStatus Status { get; }

	// Token: 0x1700100A RID: 4106
	// (get) Token: 0x060063B3 RID: 25523
	GameTimerClass GameTimer { get; }

	// Token: 0x1700100B RID: 4107
	// (get) Token: 0x060063B4 RID: 25524
	float PastTime { get; }
}
