using System;
using UnityEngine;

// Token: 0x0200065F RID: 1631
public interface GInterface23
{
	// Token: 0x170006B1 RID: 1713
	Quaternion this[int index] { get; set; }

	// Token: 0x170006B2 RID: 1714
	// (get) Token: 0x06002568 RID: 9576
	bool IsAlternative { get; }

	// Token: 0x170006B3 RID: 1715
	// (get) Token: 0x06002569 RID: 9577
	bool IsCached { get; }

	// Token: 0x170006B4 RID: 1716
	// (get) Token: 0x0600256A RID: 9578
	Vector3 Position { get; }

	// Token: 0x170006B5 RID: 1717
	// (get) Token: 0x0600256B RID: 9579
	Quaternion Rotation { get; }
}
