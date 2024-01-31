using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.InventoryLogic;

// Token: 0x02002BC2 RID: 11202
public sealed class GClass3069 : IDisposable
{
	// Token: 0x14000305 RID: 773
	// (add) Token: 0x0600DCC6 RID: 56518 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600DCC7 RID: 56519 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Item, bool> OnItemSelectionChanged
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x14000306 RID: 774
	// (add) Token: 0x0600DCC8 RID: 56520 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600DCC9 RID: 56521 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Item> OnItemChanged
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x14000307 RID: 775
	// (add) Token: 0x0600DCCA RID: 56522 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600DCCB RID: 56523 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<bool, Item> OnOfferTakesMaxCellsChanged
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x170026A4 RID: 9892
	// (get) Token: 0x0600DCCC RID: 56524 RVA: 0x00002050 File Offset: 0x00000250
	public IReadOnlyCollection<Item> SelectedItems
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170026A5 RID: 9893
	// (get) Token: 0x0600DCCD RID: 56525 RVA: 0x00002050 File Offset: 0x00000250
	public int OfferItemCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170026A6 RID: 9894
	// (get) Token: 0x0600DCCE RID: 56526 RVA: 0x00002050 File Offset: 0x00000250
	private int Int32_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170026A7 RID: 9895
	// (get) Token: 0x0600DCCF RID: 56527 RVA: 0x00002050 File Offset: 0x00000250
	public string[] SelectedItemsIds
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170026A8 RID: 9896
	// (get) Token: 0x0600DCD0 RID: 56528 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600DCD1 RID: 56529 RVA: 0x00002050 File Offset: 0x00000250
	public Item SelectedItem
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x170026A9 RID: 9897
	// (get) Token: 0x0600DCD2 RID: 56530 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600DCD3 RID: 56531 RVA: 0x00002050 File Offset: 0x00000250
	public bool AutoSelectSimilar
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x170026AA RID: 9898
	// (get) Token: 0x0600DCD4 RID: 56532 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600DCD5 RID: 56533 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsOfferTakesMaxCellsCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x170026AB RID: 9899
	// (get) Token: 0x0600DCD6 RID: 56534 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsAllSelectedItemSame
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600DCD7 RID: 56535 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item GetFirstAvailableItemOrNull()
	{
		throw null;
	}

	// Token: 0x0600DCD8 RID: 56536 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TrySelectFirstAvailableItem()
	{
		throw null;
	}

	// Token: 0x0600DCD9 RID: 56537 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SelectItem(Item selectedItem)
	{
		throw null;
	}

	// Token: 0x0600DCDA RID: 56538 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeselectItem(Item item)
	{
		throw null;
	}

	// Token: 0x0600DCDB RID: 56539 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InvokeItemChanged(Item item)
	{
		throw null;
	}

	// Token: 0x0600DCDC RID: 56540 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(Item item)
	{
		throw null;
	}

	// Token: 0x0600DCDD RID: 56541 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x0600DCDE RID: 56542 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int method_2(Item item)
	{
		throw null;
	}

	// Token: 0x0600DCDF RID: 56543 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_3(Item item)
	{
		throw null;
	}

	// Token: 0x0600DCE0 RID: 56544 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearSelectedList()
	{
		throw null;
	}

	// Token: 0x0600DCE1 RID: 56545 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_4(Item item, out string error)
	{
		throw null;
	}

	// Token: 0x0600DCE2 RID: 56546 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HighlightedAtRagfair(Item item)
	{
		throw null;
	}

	// Token: 0x0600DCE3 RID: 56547 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0600DCE4 RID: 56548 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_5(Item item)
	{
		throw null;
	}

	// Token: 0x0600DCE5 RID: 56549 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_6(Item item)
	{
		throw null;
	}

	// Token: 0x0400E12F RID: 57647
	[CompilerGenerated]
	private Action<Item, bool> action_0;

	// Token: 0x0400E130 RID: 57648
	[CompilerGenerated]
	private Action<Item> action_1;

	// Token: 0x0400E131 RID: 57649
	[CompilerGenerated]
	private Action<bool, Item> action_2;

	// Token: 0x0400E132 RID: 57650
	private readonly Profile profile_0;

	// Token: 0x0400E133 RID: 57651
	private readonly GClass2495 gclass2495_0;

	// Token: 0x0400E134 RID: 57652
	public readonly GClass2822 ItemContext;

	// Token: 0x0400E135 RID: 57653
	private readonly HashSet<Item> hashSet_0;

	// Token: 0x0400E136 RID: 57654
	[CompilerGenerated]
	private Item item_0;

	// Token: 0x0400E137 RID: 57655
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x0400E138 RID: 57656
	private bool bool_1;

	// Token: 0x02002BC3 RID: 11203
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2656
	{
		// Token: 0x0600DCE6 RID: 56550 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_0(Item x)
		{
			throw null;
		}

		// Token: 0x0600DCE7 RID: 56551 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_1(Item item)
		{
			throw null;
		}

		// Token: 0x0400E139 RID: 57657
		public static readonly GClass3069.Class2656 class2656_0;

		// Token: 0x0400E13A RID: 57658
		public static Func<Item, int> func_0;

		// Token: 0x0400E13B RID: 57659
		public static Func<Item, string> func_1;
	}

	// Token: 0x02002BC4 RID: 11204
	[CompilerGenerated]
	private sealed class Class2657
	{
		// Token: 0x0600DCE8 RID: 56552 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Item item)
		{
			throw null;
		}

		// Token: 0x0600DCE9 RID: 56553 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(Item item)
		{
			throw null;
		}

		// Token: 0x0600DCEA RID: 56554 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_2(Item item)
		{
			throw null;
		}

		// Token: 0x0400E13C RID: 57660
		public Item selectedItem;

		// Token: 0x0400E13D RID: 57661
		public GClass3069 gclass3069_0;
	}
}
