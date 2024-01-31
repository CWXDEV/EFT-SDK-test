using System;
using System.Collections.Generic;
using EFT;
using UnityEngine;

// Token: 0x0200044D RID: 1101
public interface GInterface8
{
	// Token: 0x1400002D RID: 45
	// (add) Token: 0x06001A91 RID: 6801
	// (remove) Token: 0x06001A92 RID: 6802
	event Action OnPositionsRecalculated;

	// Token: 0x170004CA RID: 1226
	// (get) Token: 0x06001A93 RID: 6803
	Vector3? PointForBoss { get; }

	// Token: 0x06001A94 RID: 6804
	Dictionary<BotOwner, Vector3> FollowersPositions();

	// Token: 0x06001A95 RID: 6805
	void SetFollowersPositions();

	// Token: 0x06001A96 RID: 6806
	Vector3 GetTargetToLook();
}
