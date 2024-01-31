using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x02002543 RID: 9539
public sealed class GClass2804 : IRollback, IExecute, GInterface321
{
	// Token: 0x17002212 RID: 8722
	// (get) Token: 0x0600BF1F RID: 48927 RVA: 0x00002050 File Offset: 0x00000250
	public List<Item> ChangedItems
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600BF20 RID: 48928 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetOldPositions(GClass2495 grid, List<GClass2503> itemsWithLocation)
	{
		throw null;
	}

	// Token: 0x0600BF21 RID: 48929 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddItemToGrid(GClass2495 grid, GClass2503 item)
	{
		throw null;
	}

	// Token: 0x0600BF22 RID: 48930 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass2495 RemoveItemFromGrid(Item item)
	{
		throw null;
	}

	// Token: 0x0600BF23 RID: 48931 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct412 Execute()
	{
		throw null;
	}

	// Token: 0x0600BF24 RID: 48932 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RollBack()
	{
		throw null;
	}

	// Token: 0x0600BF25 RID: 48933 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvents(TraderControllerClass controller, CommandStatus status)
	{
		throw null;
	}

	// Token: 0x0600BF26 RID: 48934 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanExecute(TraderControllerClass itemController)
	{
		throw null;
	}

	// Token: 0x0400C0F9 RID: 49401
	private readonly Dictionary<GClass2495, List<GClass2503>> dictionary_0;

	// Token: 0x0400C0FA RID: 49402
	private readonly Dictionary<GClass2495, List<GClass2503>> dictionary_1;

	// Token: 0x0400C0FB RID: 49403
	private readonly Dictionary<Item, GClass2495> dictionary_2;

	// Token: 0x0400C0FC RID: 49404
	private readonly HashSet<GClass2495> hashSet_0;

	// Token: 0x0400C0FD RID: 49405
	private readonly LootItemClass gclass2625_0;

	// Token: 0x0400C0FE RID: 49406
	private readonly InventoryControllerClass gclass2757_0;

	// Token: 0x02002544 RID: 9540
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2130
	{
		// Token: 0x0600BF27 RID: 48935 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal List<GClass2503> method_0(KeyValuePair<GClass2495, List<GClass2503>> x)
		{
			throw null;
		}

		// Token: 0x0600BF28 RID: 48936 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<Item> method_1(List<GClass2503> x)
		{
			throw null;
		}

		// Token: 0x0600BF29 RID: 48937 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_2(GClass2503 y)
		{
			throw null;
		}

		// Token: 0x0400C0FF RID: 49407
		public static readonly GClass2804.Class2130 class2130_0;

		// Token: 0x0400C100 RID: 49408
		public static Func<KeyValuePair<GClass2495, List<GClass2503>>, List<GClass2503>> func_0;

		// Token: 0x0400C101 RID: 49409
		public static Func<GClass2503, Item> func_1;

		// Token: 0x0400C102 RID: 49410
		public static Func<List<GClass2503>, IEnumerable<Item>> func_2;
	}

	// Token: 0x02002545 RID: 9541
	[CompilerGenerated]
	private sealed class Class2131
	{
		// Token: 0x0600BF2A RID: 48938 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass2503 x)
		{
			throw null;
		}

		// Token: 0x0400C103 RID: 49411
		public Item item;
	}
}
