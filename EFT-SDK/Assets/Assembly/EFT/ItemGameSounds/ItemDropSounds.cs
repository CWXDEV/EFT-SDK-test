using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JsonType;
using UnityEngine;

namespace EFT.ItemGameSounds
{
	// Token: 0x02001D9D RID: 7581
	public class ItemDropSounds : ScriptableObject
	{
		// Token: 0x06009C54 RID: 40020 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public SoundBank GetSoundBank(BaseBallistic.ESurfaceSound surfaceSound, EItemDropSoundType dropSoundType)
		{
			throw null;
		}

		// Token: 0x0400A38D RID: 41869
		public AnimationCurve EnergyToVolumeCurve;

		// Token: 0x0400A38E RID: 41870
		public BaseBallistic.ESurfaceSound DefaultSurfaceSound;

		// Token: 0x0400A38F RID: 41871
		public ItemDropSurfaceSet[] SurfaceSets;

		// Token: 0x0400A390 RID: 41872
		private readonly Dictionary<BaseBallistic.ESurfaceSound, ItemDropSurfaceSet> dictionary_0;
	}
}
