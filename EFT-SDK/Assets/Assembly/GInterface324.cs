using System;
using System.Collections.Generic;
using EFT.InventoryLogic;
using JetBrains.Annotations;

// Token: 0x02002514 RID: 9492
public interface GInterface324 : IRollback, GInterface321
{
	// Token: 0x170021D4 RID: 8660
	// (get) Token: 0x0600BE4E RID: 48718
	[CanBeNull]
	ItemAddress From { get; }

	// Token: 0x170021D5 RID: 8661
	// (get) Token: 0x0600BE4F RID: 48719
	[CanBeNull]
	ItemAddress To { get; }

	// Token: 0x170021D6 RID: 8662
	// (get) Token: 0x0600BE50 RID: 48720
	bool ItemsDestroyRequired { get; }

	// Token: 0x170021D7 RID: 8663
	// (get) Token: 0x0600BE51 RID: 48721
	bool DestroysMainItem { get; }

	// Token: 0x170021D8 RID: 8664
	// (get) Token: 0x0600BE52 RID: 48722
	IEnumerable<GStruct368> ItemsToDestroy { get; }

	// Token: 0x0600BE53 RID: 48723
	bool Contains(Item item, out GStruct368 numberToDestroy);
}
