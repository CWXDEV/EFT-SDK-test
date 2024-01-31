using System;
using UnityEngine;

namespace EFT.Weather
{
	// Token: 0x02001DEA RID: 7658
	[Serializable]
	public struct FogRemapRecordV2
	{
		// Token: 0x0400A574 RID: 42356
		public float Hour;

		// Token: 0x0400A575 RID: 42357
		public float OriginalFogValue;

		// Token: 0x0400A576 RID: 42358
		public AnimationCurve NewFogValue;

		// Token: 0x0400A577 RID: 42359
		public Gradient ColorMultiplier;

		// Token: 0x0400A578 RID: 42360
		public AnimationCurve DensityMultiplier;

		// Token: 0x0400A579 RID: 42361
		public AnimationCurve DensityPower;

		// Token: 0x0400A57A RID: 42362
		public AnimationCurve DensityBias;

		// Token: 0x0400A57B RID: 42363
		public AnimationCurve GreyscaleLerpFactor;

		// Token: 0x0400A57C RID: 42364
		public AnimationCurve SlicesDistribution;

		// Token: 0x0400A57D RID: 42365
		public AnimationCurve FogSoftParticleScale;

		// Token: 0x0400A57E RID: 42366
		public AnimationCurve DensityMultiplierFromTime;

		// Token: 0x0400A57F RID: 42367
		public AnimationCurve DensityPowerFromTime;

		// Token: 0x0400A580 RID: 42368
		public AnimationCurve DensityBiasFromTime;
	}
}
