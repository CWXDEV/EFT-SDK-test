using System;
using UnityEngine;

namespace EFT.Weather
{
	// Token: 0x02001DE8 RID: 7656
	[Serializable]
	public struct FogRemapRecord
	{
		// Token: 0x0400A568 RID: 42344
		public float Hour;

		// Token: 0x0400A569 RID: 42345
		public float OriginalFogValue;

		// Token: 0x0400A56A RID: 42346
		public float NewFogValue;

		// Token: 0x0400A56B RID: 42347
		public Color ColorMultiplier;

		// Token: 0x0400A56C RID: 42348
		public float DensityMultiplier;

		// Token: 0x0400A56D RID: 42349
		public float DensityPower;

		// Token: 0x0400A56E RID: 42350
		public float DensityBias;

		// Token: 0x0400A56F RID: 42351
		public float GreyscaleLerpFactor;

		// Token: 0x0400A570 RID: 42352
		public float SlicesDistribution;

		// Token: 0x0400A571 RID: 42353
		public float FogSoftParticleScale;
	}
}
