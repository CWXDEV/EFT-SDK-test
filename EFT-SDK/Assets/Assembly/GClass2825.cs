using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Diz.LanguageExtensions;
using EFT.InventoryLogic;

// Token: 0x0200256F RID: 9583
public abstract class GClass2825
{
	// Token: 0x1700223C RID: 8764
	// (get) Token: 0x0600BFD4 RID: 49108 RVA: 0x00002050 File Offset: 0x00000250
	protected InventoryControllerClass GClass2757_0
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700223D RID: 8765
	// (get) Token: 0x0600BFD5 RID: 49109 RVA: 0x00002050 File Offset: 0x00000250
	protected LootItemClass[] GClass2625_0
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600BFD6 RID: 49110
	public abstract IEnumerable<Item> GetItemCollections(ItemAddress itemAddress);

	// Token: 0x0600BFD7 RID: 49111
	protected abstract bool Select(Item item, ItemAddress itemAddress, bool simulate, out Error error);

	// Token: 0x0600BFD8 RID: 49112
	public abstract bool InPlayerCollection(Item item);

	// Token: 0x0600BFD9 RID: 49113 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0(Item item)
	{
		throw null;
	}

	// Token: 0x0600BFDA RID: 49114 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_1(Item item)
	{
		throw null;
	}

	// Token: 0x0600BFDB RID: 49115 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Select(Item item, ItemAddress itemAddress, out Error error)
	{
		throw null;
	}

	// Token: 0x0600BFDC RID: 49116 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SelectCheck(Item item, ItemAddress itemAddress, out Error error)
	{
		throw null;
	}

	// Token: 0x0400C18F RID: 49551
	[CompilerGenerated]
	private readonly InventoryControllerClass gclass2757_0;

	// Token: 0x0400C190 RID: 49552
	[CompilerGenerated]
	private readonly LootItemClass[] gclass2625_0;
}
