using System;
using UnityEngine;

// Token: 0x02001EE4 RID: 7908
public interface GInterface213
{
	// Token: 0x17001ABE RID: 6846
	// (get) Token: 0x0600A364 RID: 41828
	Vector3 Velocity { get; }

	// Token: 0x17001ABF RID: 6847
	// (get) Token: 0x0600A365 RID: 41829
	Vector3 Acceleration { get; }

	// Token: 0x17001AC0 RID: 6848
	// (get) Token: 0x0600A366 RID: 41830
	Vector3 NormalizedDirection { get; }

	// Token: 0x0600A367 RID: 41831
	void Tick();
}
