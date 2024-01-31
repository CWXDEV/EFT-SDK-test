using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;

// Token: 0x02002564 RID: 9572
public sealed class GClass2817 : GClass2816
{
	// Token: 0x0600BF73 RID: 49011 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Highlight(bool selected)
	{
		throw null;
	}

	// Token: 0x0600BF74 RID: 49012 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass2817 CreateModdingChild(Item item)
	{
		throw null;
	}

	// Token: 0x0600BF75 RID: 49013 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass2817 CreateModdingChild(Item item, ItemAddress targetAddress)
	{
		throw null;
	}

	// Token: 0x0600BF76 RID: 49014 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override GClass2816 CreateSelectableChild(Item item, ItemAddress targetAddress)
	{
		throw null;
	}

	// Token: 0x0400C16E RID: 49518
	public readonly GClass2817.GInterface334 ModdingSelectionContext;

	// Token: 0x02002565 RID: 9573
	public interface GInterface334 : GClass2816.GInterface335
	{
		// Token: 0x0600BF77 RID: 49015
		bool IsInventoryItem(Item item);

		// Token: 0x0600BF78 RID: 49016
		IEnumerable<Item> GetAllItems(ItemAddress itemAddress);

		// Token: 0x0600BF79 RID: 49017
		void Highlight([CanBeNull] GClass2816 context, bool selected);
	}
}
