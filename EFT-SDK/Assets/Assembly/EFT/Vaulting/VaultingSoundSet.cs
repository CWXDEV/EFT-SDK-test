using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace EFT.Vaulting
{
	// Token: 0x02001E76 RID: 7798
	[Serializable]
	public class VaultingSoundSet
	{
		// Token: 0x06009FFA RID: 40954 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetSoundElement(EVaultingSoundState soundState, out VaultingSoundSet.VaultingSoundElement element)
		{
			throw null;
		}

		// Token: 0x0400A81E RID: 43038
		[SerializeField]
		private List<VaultingSoundSet.VaultingSoundElement> VaultingBanks;

		// Token: 0x02001E77 RID: 7799
		[Serializable]
		public class VaultingSoundElement
		{
			// Token: 0x0400A81F RID: 43039
			[FormerlySerializedAs("SoundStateType")]
			public EVaultingSoundState SoundState;

			// Token: 0x0400A820 RID: 43040
			public SoundBank SoundBank;

			// Token: 0x0400A821 RID: 43041
			public VolumeRange VolumeRange;
		}
	}
}
