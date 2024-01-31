using System;
using EFT.Utilities;

namespace EFT.Hideout
{
	// Token: 0x02001A6C RID: 6764
	[Serializable]
	public sealed class Pattern<T>
	{
		// Token: 0x0400960A RID: 38410
		public T Value;

		// Token: 0x0400960B RID: 38411
		public float Probability;

		// Token: 0x0400960C RID: 38412
		public RandomBetweenFloats Delay;
	}
}
