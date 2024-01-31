using System;
using System.Runtime.CompilerServices;
using EFT.Vaulting;
using UnityEngine;

namespace EFT
{
	// Token: 0x02001779 RID: 6009
	[Serializable]
	public class SurfaceSet
	{
		// Token: 0x170013E8 RID: 5096
		// (get) Token: 0x0600806B RID: 32875 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsFull
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600806C RID: 32876 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetVaultingSoundSet(EVaultingSoundType soundType, out VaultingSoundSet vaultingSet)
		{
			throw null;
		}

		// Token: 0x040088E5 RID: 35045
		public BaseBallistic.ESurfaceSound Surface;

		// Token: 0x040088E6 RID: 35046
		public SoundBank RunSoundBank;

		// Token: 0x040088E7 RID: 35047
		public SoundBank SprintSoundBank;

		// Token: 0x040088E8 RID: 35048
		public SoundBank StopSoundBank;

		// Token: 0x040088E9 RID: 35049
		public SoundBank LandingSoundBank;

		// Token: 0x040088EA RID: 35050
		public SoundBank TurnSoundBank;

		// Token: 0x040088EB RID: 35051
		public SoundBank DuckSoundBank;

		// Token: 0x040088EC RID: 35052
		public SoundBank ProneSoundBank;

		// Token: 0x040088ED RID: 35053
		public SoundBank ProneDropSoundBank;

		// Token: 0x040088EE RID: 35054
		public SoundBank JumpSoundBank;

		// Token: 0x040088EF RID: 35055
		[Space]
		[Header("Vaulting Sounds")]
		public VaultingSoundSet VaultSoundSet;

		// Token: 0x040088F0 RID: 35056
		public VaultingSoundSet SprintVaultSoundSet;

		// Token: 0x040088F1 RID: 35057
		public VaultingSoundSet ClimbSoundSet;
	}
}
