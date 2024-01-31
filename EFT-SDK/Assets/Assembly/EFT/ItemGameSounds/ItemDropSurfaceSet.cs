using System;
using System.Runtime.CompilerServices;
using JsonType;

namespace EFT.ItemGameSounds
{
	// Token: 0x02001D9E RID: 7582
	[Serializable]
	public class ItemDropSurfaceSet
	{
		// Token: 0x06009C55 RID: 40021 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SoundBank GetBank(EItemDropSoundType dropSoundType)
		{
			throw null;
		}

		// Token: 0x0400A391 RID: 41873
		public BaseBallistic.ESurfaceSound Surface;

		// Token: 0x0400A392 RID: 41874
		public SoundBank PistolDropSoundBank;

		// Token: 0x0400A393 RID: 41875
		public SoundBank RiffleDropSoundBank;

		// Token: 0x0400A394 RID: 41876
		public SoundBank SubGunDropSoundBank;
	}
}
