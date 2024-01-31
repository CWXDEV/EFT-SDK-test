using System;
using UnityEngine;

// Token: 0x02001EC8 RID: 7880
public interface GInterface209
{
	// Token: 0x17001A8C RID: 6796
	// (get) Token: 0x0600A2E0 RID: 41696
	float? AverageHeight { get; }

	// Token: 0x17001A8D RID: 6797
	// (get) Token: 0x0600A2E1 RID: 41697
	float? AverageLength { get; }

	// Token: 0x17001A8E RID: 6798
	// (get) Token: 0x0600A2E2 RID: 41698
	float? AverageDistance { get; }

	// Token: 0x17001A8F RID: 6799
	// (get) Token: 0x0600A2E3 RID: 41699
	// (set) Token: 0x0600A2E4 RID: 41700
	Vector3? CurrentMotion { get; set; }

	// Token: 0x17001A90 RID: 6800
	// (get) Token: 0x0600A2E5 RID: 41701
	// (set) Token: 0x0600A2E6 RID: 41702
	float VerticalOffset { get; set; }

	// Token: 0x0600A2E7 RID: 41703
	void CalculateParameters(GStruct271 data);
}
