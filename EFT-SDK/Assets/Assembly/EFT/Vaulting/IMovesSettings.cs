using System;

namespace EFT.Vaulting
{
	// Token: 0x02001E59 RID: 7769
	public interface IMovesSettings
	{
		// Token: 0x1700194F RID: 6479
		// (get) Token: 0x06009F55 RID: 40789
		IVaultSettings VaultSettings { get; }

		// Token: 0x17001950 RID: 6480
		// (get) Token: 0x06009F56 RID: 40790
		IClimbSettings ClimbSettings { get; }
	}
}
