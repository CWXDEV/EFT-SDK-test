using System;
using Koenigz.PerfectCulling;
using UnityEngine;

// Token: 0x02000DBA RID: 3514
public interface GInterface63
{
	// Token: 0x17000BC0 RID: 3008
	// (get) Token: 0x06004A25 RID: 18981
	string Name { get; }

	// Token: 0x06004A26 RID: 18982
	void InitializeSamplingProvider();

	// Token: 0x06004A27 RID: 18983
	bool IsSamplingPositionActive(PerfectCullingBakingBehaviour bakingBehaviour, Vector3 pos);
}
