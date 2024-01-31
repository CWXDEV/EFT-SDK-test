using System;
using EFT.InventoryLogic;
using JetBrains.Annotations;

// Token: 0x020025A7 RID: 9639
public interface GInterface337 : GInterface336
{
	// Token: 0x17002244 RID: 8772
	// (get) Token: 0x0600C02F RID: 49199
	Item Item1 { get; }

	// Token: 0x17002245 RID: 8773
	// (get) Token: 0x0600C030 RID: 49200
	[CanBeNull]
	ItemAddress From1 { get; }

	// Token: 0x17002246 RID: 8774
	// (get) Token: 0x0600C031 RID: 49201
	[CanBeNull]
	ItemAddress To1 { get; }
}
