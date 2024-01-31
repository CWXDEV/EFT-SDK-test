using System;
using System.Runtime.CompilerServices;

namespace EFT.Airdrop
{
	// Token: 0x02001E48 RID: 7752
	[Serializable]
	public class AirdropSurfaceSet
	{
		// Token: 0x17001933 RID: 6451
		// (get) Token: 0x06009EF5 RID: 40693 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsFull
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400A776 RID: 42870
		public BaseBallistic.ESurfaceSound Surface;

		// Token: 0x0400A777 RID: 42871
		public SoundBank LandingSoundBank;
	}
}
