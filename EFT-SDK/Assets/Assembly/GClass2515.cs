using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;

// Token: 0x0200231F RID: 8991
public class GClass2515
{
	// Token: 0x0600B5EF RID: 46575 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item GetBoundItem(EBoundItem boundItem)
	{
		throw null;
	}

	// Token: 0x0400B995 RID: 47509
	public readonly Dictionary<EBoundItem, Slot> BoundCells;

	// Token: 0x0400B996 RID: 47510
	public readonly Dictionary<EBoundItem, Item> BoundItems;
}
