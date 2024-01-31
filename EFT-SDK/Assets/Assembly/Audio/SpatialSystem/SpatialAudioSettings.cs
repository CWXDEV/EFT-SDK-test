using System;
using UnityEngine;

namespace Audio.SpatialSystem
{
	// Token: 0x02000D45 RID: 3397
	public sealed class SpatialAudioSettings
	{
		// Token: 0x04005305 RID: 21253
		public bool OcclusionEnabled;

		// Token: 0x04005306 RID: 21254
		public float OcclusionIntensity;

		// Token: 0x04005307 RID: 21255
		public EOcclusionTest OcclusionTest;

		// Token: 0x04005308 RID: 21256
		public float OcclusionDistanceCoefficient;

		// Token: 0x04005309 RID: 21257
		public float OcclusionRotationCoefficient;

		// Token: 0x0400530A RID: 21258
		public float IndoorToOutdoorFactor;

		// Token: 0x0400530B RID: 21259
		public float OutdoorToIndoorFactor;

		// Token: 0x0400530C RID: 21260
		public bool IncludeReverbEffect;

		// Token: 0x0400530D RID: 21261
		public AnimationCurve ObstructionVolumeCurve;

		// Token: 0x0400530E RID: 21262
		public AnimationCurve PropagationVolumeCurve;

		// Token: 0x0400530F RID: 21263
		public AnimationCurve OcclusionLowPassFilterCurve;

		// Token: 0x04005310 RID: 21264
		public AnimationCurve PropagationLowPassFilterCurve;

		// Token: 0x04005311 RID: 21265
		public AnimationCurve DistanceLowPassFilterCurve;

		// Token: 0x04005312 RID: 21266
		public AnimationCurve DistanceHighPassFilterCurve;

		// Token: 0x04005313 RID: 21267
		public readonly AudioFilterFrequencySettings FrequencySettings;
	}
}
