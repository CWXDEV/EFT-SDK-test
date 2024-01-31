using System;
using UnityEngine;

// Token: 0x02001EC1 RID: 7873
public interface GInterface206
{
	// Token: 0x17001A71 RID: 6769
	// (get) Token: 0x0600A2B6 RID: 41654
	Collider TargetCollider { get; }

	// Token: 0x17001A72 RID: 6770
	// (get) Token: 0x0600A2B7 RID: 41655
	float MainObstacleLength { get; }

	// Token: 0x17001A73 RID: 6771
	// (get) Token: 0x0600A2B8 RID: 41656
	float MainObstacleHeight { get; }

	// Token: 0x17001A74 RID: 6772
	// (get) Token: 0x0600A2B9 RID: 41657
	float DistanceToMainObstacle { get; }

	// Token: 0x17001A75 RID: 6773
	// (get) Token: 0x0600A2BA RID: 41658
	float BehindObstacleRatio { get; }

	// Token: 0x17001A76 RID: 6774
	// (get) Token: 0x0600A2BB RID: 41659
	float? MinRoofHeight { get; }

	// Token: 0x17001A77 RID: 6775
	// (get) Token: 0x0600A2BC RID: 41660
	bool IsTerrain { get; }

	// Token: 0x0600A2BD RID: 41661
	void CalculateSurface(GStruct268 data);
}
