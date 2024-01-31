using System;
using UnityEngine;

// Token: 0x02001EAF RID: 7855
public interface GInterface201
{
	// Token: 0x17001A23 RID: 6691
	// (get) Token: 0x0600A21E RID: 41502
	// (set) Token: 0x0600A21F RID: 41503
	float GridOffsetX { get; set; }

	// Token: 0x17001A24 RID: 6692
	// (get) Token: 0x0600A220 RID: 41504
	// (set) Token: 0x0600A221 RID: 41505
	float GridOffsetY { get; set; }

	// Token: 0x17001A25 RID: 6693
	// (get) Token: 0x0600A222 RID: 41506
	// (set) Token: 0x0600A223 RID: 41507
	float GridOffsetZ { get; set; }

	// Token: 0x17001A26 RID: 6694
	// (get) Token: 0x0600A224 RID: 41508
	// (set) Token: 0x0600A225 RID: 41509
	float CurrentVelocity { get; set; }

	// Token: 0x17001A27 RID: 6695
	// (get) Token: 0x0600A226 RID: 41510
	// (set) Token: 0x0600A227 RID: 41511
	float OffsetFactor { get; set; }

	// Token: 0x17001A28 RID: 6696
	// (get) Token: 0x0600A228 RID: 41512
	// (set) Token: 0x0600A229 RID: 41513
	Vector3 ForwardProjection { get; set; }

	// Token: 0x17001A29 RID: 6697
	// (get) Token: 0x0600A22A RID: 41514
	// (set) Token: 0x0600A22B RID: 41515
	Vector3 PlayerRealForward { get; set; }
}
