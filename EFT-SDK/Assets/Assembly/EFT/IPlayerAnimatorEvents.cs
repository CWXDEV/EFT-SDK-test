using System;

namespace EFT
{
	// Token: 0x0200158F RID: 5519
	public interface IPlayerAnimatorEvents
	{
		// Token: 0x17001288 RID: 4744
		// (get) Token: 0x06007676 RID: 30326
		IVaultingSoundsEvents VaultingSoundsEvents { get; }

		// Token: 0x17001289 RID: 4745
		// (get) Token: 0x06007677 RID: 30327
		IVaultingSoundsEvents SprintVaultSoundsEvents { get; }

		// Token: 0x1700128A RID: 4746
		// (get) Token: 0x06007678 RID: 30328
		IVaultingSoundsEvents ClimbSoundsEvents { get; }
	}
}
