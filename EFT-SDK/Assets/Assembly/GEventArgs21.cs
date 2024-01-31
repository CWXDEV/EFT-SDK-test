using System;
using EFT.InventoryLogic;

// Token: 0x02002484 RID: 9348
public sealed class GEventArgs21 : EventArgs
{
	// Token: 0x0400BDFE RID: 48638
	public readonly string[] Items;

	// Token: 0x0400BDFF RID: 48639
	public string TraderId;

	// Token: 0x0400BE00 RID: 48640
	public readonly CommandStatus Status;
}
