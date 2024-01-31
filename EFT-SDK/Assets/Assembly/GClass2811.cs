using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x0200255C RID: 9564
public class GClass2811<T> : GClass2809 where T : Item
{
	// Token: 0x0600BF59 RID: 48985 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override GClass2809 CreateChild(Item item)
	{
		throw null;
	}

	// Token: 0x0400C160 RID: 49504
	public readonly T CastItem;
}
