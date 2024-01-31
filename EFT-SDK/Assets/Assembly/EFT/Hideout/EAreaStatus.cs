using System;

namespace EFT.Hideout
{
	// Token: 0x02001B49 RID: 6985
	public enum EAreaStatus
	{
		// Token: 0x040099B0 RID: 39344
		NotSet,
		// Token: 0x040099B1 RID: 39345
		LockedToConstruct,
		// Token: 0x040099B2 RID: 39346
		ReadyToConstruct,
		// Token: 0x040099B3 RID: 39347
		Constructing,
		// Token: 0x040099B4 RID: 39348
		ReadyToInstallConstruct,
		// Token: 0x040099B5 RID: 39349
		LockedToUpgrade,
		// Token: 0x040099B6 RID: 39350
		ReadyToUpgrade,
		// Token: 0x040099B7 RID: 39351
		Upgrading,
		// Token: 0x040099B8 RID: 39352
		ReadyToInstallUpgrade,
		// Token: 0x040099B9 RID: 39353
		NoFutureUpgrades,
		// Token: 0x040099BA RID: 39354
		AutoUpgrading
	}
}
