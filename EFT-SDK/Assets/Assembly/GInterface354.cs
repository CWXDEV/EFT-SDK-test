using System;
using UnityEngine;

// Token: 0x020027FC RID: 10236
public interface GInterface354
{
	// Token: 0x0600CCF5 RID: 52469
	Quaternion GetRandomRotation(int random);

	// Token: 0x0600CCF6 RID: 52470
	float GetRandomFloat(int random);

	// Token: 0x0600CCF7 RID: 52471
	Vector3 GetRandomDirection(int random);

	// Token: 0x0600CCF8 RID: 52472
	float GetNormalDistributedRandomFloat(int random, float mean, float stdDiviation);
}
