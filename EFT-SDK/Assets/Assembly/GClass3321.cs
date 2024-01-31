using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x02002317 RID: 8983
public sealed class GClass3321 : InventoryError
{
	// Token: 0x0600B5D7 RID: 46551 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x0400B968 RID: 47464
	public readonly Item Item;

	// Token: 0x0400B969 RID: 47465
	public readonly StackSlot StackSlot;

	// Token: 0x0400B96A RID: 47466
	public readonly int MaxAllowedCount;
}
