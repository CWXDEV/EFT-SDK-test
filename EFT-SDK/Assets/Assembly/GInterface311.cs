using System;
using EFT.InventoryLogic;
using JetBrains.Annotations;

// Token: 0x0200244A RID: 9290
public interface GInterface311 : IContainer, IItemOwner
{
	// Token: 0x14000294 RID: 660
	// (add) Token: 0x0600BA8B RID: 47755
	// (remove) Token: 0x0600BA8C RID: 47756
	event Action<Item> OnItemFound;

	// Token: 0x1700213E RID: 8510
	// (get) Token: 0x0600BA8D RID: 47757
	GClass2515 FastAccess { get; }

	// Token: 0x1700213F RID: 8511
	// (get) Token: 0x0600BA8E RID: 47758
	[CanBeNull]
	Item ItemInHands { get; }
}
