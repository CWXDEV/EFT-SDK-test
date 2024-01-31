using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Weather
{
	// Token: 0x02001DF9 RID: 7673
	[Serializable]
	public class WiresController
	{
		// Token: 0x06009E05 RID: 40453 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update(Vector2 wind)
		{
			throw null;
		}

		// Token: 0x06009E06 RID: 40454 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(Vector3 wind, float magnitudeNormalized, float freqMult)
		{
			throw null;
		}

		// Token: 0x0400A63E RID: 42558
		public float StrengthMultiplyer;

		// Token: 0x0400A63F RID: 42559
		public float MaxValue;

		// Token: 0x0400A640 RID: 42560
		public float FreqDelta;

		// Token: 0x0400A641 RID: 42561
		public float WindScale;

		// Token: 0x0400A642 RID: 42562
		public float WindFreq;

		// Token: 0x0400A643 RID: 42563
		public float MaxWinFreq;

		// Token: 0x0400A644 RID: 42564
		public float DetailWindAmp;

		// Token: 0x0400A645 RID: 42565
		public float DetailWindScale;

		// Token: 0x0400A646 RID: 42566
		public float DetailWindFreq;

		// Token: 0x0400A647 RID: 42567
		public float WiresMaxWindOffsetMultiplier;

		// Token: 0x0400A648 RID: 42568
		public float WiresMaxWindAmplitudeMultiplier;

		// Token: 0x0400A649 RID: 42569
		private Vector2 _windFuncOffsetAndScale;

		// Token: 0x0400A64A RID: 42570
		private static readonly int _wireWind;

		// Token: 0x0400A64B RID: 42571
		private static readonly int _wireWindFreq;

		// Token: 0x0400A64C RID: 42572
		private static readonly int _wireWindScale;

		// Token: 0x0400A64D RID: 42573
		private static readonly int _wireDetailWindScale;

		// Token: 0x0400A64E RID: 42574
		private static readonly int _wireDetailWindFreq;

		// Token: 0x0400A64F RID: 42575
		private static readonly int _wireDetailWindAmp;

		// Token: 0x0400A650 RID: 42576
		private static readonly int _funcOffsetAndScale;
	}
}
