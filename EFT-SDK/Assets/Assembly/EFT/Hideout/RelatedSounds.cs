using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001BB4 RID: 7092
	[Serializable]
	public sealed class RelatedSounds
	{
		// Token: 0x06009504 RID: 38148 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<AudioClip> GetSounds(params EAreaActivityType[] soundTypes)
		{
			throw null;
		}

		// Token: 0x06009505 RID: 38149 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AudioClip GetSound(EAreaActivityType soundType)
		{
			throw null;
		}

		// Token: 0x04009BC2 RID: 39874
		public Dictionary<EAreaActivityType, AudioClip> Data;

		// Token: 0x04009BC3 RID: 39875
		public AudioSequence WorkingSequence;

		// Token: 0x04009BC4 RID: 39876
		[NonSerialized]
		public Dictionary<EAreaActivityType, AudioClip> FallbackSounds;
	}
}
