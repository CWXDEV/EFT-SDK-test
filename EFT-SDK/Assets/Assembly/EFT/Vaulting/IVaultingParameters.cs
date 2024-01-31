using System;
using UnityEngine;

namespace EFT.Vaulting
{
	// Token: 0x02001E6D RID: 7789
	public interface IVaultingParameters
	{
		// Token: 0x1700197B RID: 6523
		// (get) Token: 0x06009FC5 RID: 40901
		float VaultingLength { get; }

		// Token: 0x1700197C RID: 6524
		// (get) Token: 0x06009FC6 RID: 40902
		float VaultingHeight { get; }

		// Token: 0x1700197D RID: 6525
		// (get) Token: 0x06009FC7 RID: 40903
		float BehindObstacleRatio { get; }

		// Token: 0x1700197E RID: 6526
		// (get) Token: 0x06009FC8 RID: 40904
		float AbsoluteForwardVelocity { get; }

		// Token: 0x1700197F RID: 6527
		// (get) Token: 0x06009FC9 RID: 40905
		Vector3 MaxWeightPointPosition { get; }

		// Token: 0x06009FCA RID: 40906
		EVaultingStrategy GetVaultingStrategy();

		// Token: 0x06009FCB RID: 40907
		EVaultingStrategy GetAutoVaultingStrategy();
	}
}
