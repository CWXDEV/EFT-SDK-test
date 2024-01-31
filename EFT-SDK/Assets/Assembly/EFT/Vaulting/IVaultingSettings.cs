using System;

namespace EFT.Vaulting
{
	// Token: 0x02001E57 RID: 7767
	public interface IVaultingSettings
	{
		// Token: 0x17001941 RID: 6465
		// (get) Token: 0x06009F47 RID: 40775
		bool IsActive { get; }

		// Token: 0x17001942 RID: 6466
		// (get) Token: 0x06009F48 RID: 40776
		float VaultingInputTime { get; }

		// Token: 0x17001943 RID: 6467
		// (get) Token: 0x06009F49 RID: 40777
		IGridSettings GridSettings { get; }

		// Token: 0x17001944 RID: 6468
		// (get) Token: 0x06009F4A RID: 40778
		IMovesSettings MovesSettings { get; }
	}
}
