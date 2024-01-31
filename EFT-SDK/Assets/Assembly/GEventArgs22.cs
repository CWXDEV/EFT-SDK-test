using System;
using EFT.InventoryLogic;

// Token: 0x02002485 RID: 9349
public sealed class GEventArgs22 : EventArgs
{
	// Token: 0x0400BE01 RID: 48641
	public readonly Item Item;

	// Token: 0x0400BE02 RID: 48642
	public readonly IContainer Container;

	// Token: 0x0400BE03 RID: 48643
	public readonly bool RefreshIcon;

	// Token: 0x0400BE04 RID: 48644
	public readonly bool CheckMagazine;
}
