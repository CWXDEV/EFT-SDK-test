using System;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x020002A4 RID: 676
public interface ICoversData
{
	// Token: 0x06000DDB RID: 3547
	CustomNavigationPoint FindClosestPoint(Vector3 dataCenterPos, bool noRestrictions = false, [CanBeNull] Func<GroupPoint, bool> goodFunc = null);

	// Token: 0x06000DDC RID: 3548
	CustomNavigationPoint GetFreeClosePoint(Vector3 pos, float minSDistToEnemy);

	// Token: 0x1700037C RID: 892
	// (get) Token: 0x06000DDD RID: 3549
	int ConnectionGroupId { get; }

	// Token: 0x1700037D RID: 893
	// (get) Token: 0x06000DDE RID: 3550
	CustomNavigationPoint LastCustomNavigationPoint { get; }

	// Token: 0x06000DDF RID: 3551
	GroupPoint GetClosest(Vector3 center, int connectionGroupId);

	// Token: 0x06000DE0 RID: 3552
	GroupPoint GetClosestByClosestsVoxeles(Vector3 center);
}
