using System;
using System.Collections.Generic;
using EFT;
using UnityEngine;

// Token: 0x02000144 RID: 324
public interface GInterface1
{
	// Token: 0x170001E3 RID: 483
	// (get) Token: 0x060006C0 RID: 1728
	WildSpawnType Type { get; }

	// Token: 0x170001E4 RID: 484
	// (get) Token: 0x060006C1 RID: 1729
	Vector3 Position { get; }

	// Token: 0x170001E5 RID: 485
	// (get) Token: 0x060006C2 RID: 1730
	EnemyInfo GoalEnemy { get; }

	// Token: 0x170001E6 RID: 486
	// (get) Token: 0x060006C3 RID: 1731
	BotSettingsComponents Settings { get; }

	// Token: 0x170001E7 RID: 487
	// (get) Token: 0x060006C4 RID: 1732
	IBossToFollow BossToFollow { get; }

	// Token: 0x170001E8 RID: 488
	// (get) Token: 0x060006C5 RID: 1733
	ICoversData Covers { get; }

	// Token: 0x170001E9 RID: 489
	// (get) Token: 0x060006C6 RID: 1734
	int Id { get; }

	// Token: 0x170001EA RID: 490
	// (get) Token: 0x060006C7 RID: 1735
	bool IsDamaged { get; }

	// Token: 0x170001EB RID: 491
	// (get) Token: 0x060006C8 RID: 1736
	BotGrenadeController BotGrenadeController { get; }

	// Token: 0x170001EC RID: 492
	// (get) Token: 0x060006C9 RID: 1737
	LayerMask LookSensorMask { get; }

	// Token: 0x170001ED RID: 493
	// (get) Token: 0x060006CA RID: 1738
	CustomNavigationPoint CurCustomCoverPoint { get; }

	// Token: 0x170001EE RID: 494
	// (get) Token: 0x060006CB RID: 1739
	StandartBotBrain Brain { get; }

	// Token: 0x170001EF RID: 495
	// (get) Token: 0x060006CC RID: 1740
	CustomNavigationPoint LastCover { get; }

	// Token: 0x170001F0 RID: 496
	// (get) Token: 0x060006CD RID: 1741
	int ConnectionGroupId { get; }

	// Token: 0x060006CE RID: 1742
	HashSet<Vector3> CarePositions();

	// Token: 0x060006CF RID: 1743
	List<NavGraphVoxelSimple> GetVoxelesInRadius(int step);

	// Token: 0x060006D0 RID: 1744
	float MaxShootDist();

	// Token: 0x060006D1 RID: 1745
	NavGraphVoxelSimple GetVoxelSafe(Vector3 centerPos);

	// Token: 0x060006D2 RID: 1746
	void SetLastSearchDebug(DebugCoverFindGraphSearchData debug);

	// Token: 0x060006D3 RID: 1747
	bool IsCurrentPointGood(CoverSearchType dataSearchType, CoverSearchData data, out CustomNavigationPoint point);

	// Token: 0x060006D4 RID: 1748
	List<NavGraphVoxelSimple> GetVoxelesExtended(Vector3 pos, int r);

	// Token: 0x060006D5 RID: 1749
	GroupPoint GetClosest(Vector3 pos, int botCGid);
}
