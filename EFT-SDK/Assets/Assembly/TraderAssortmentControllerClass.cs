using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;
using Diz.Binding;
using EFT;
using EFT.InventoryLogic;
using EFT.Trading;
using JetBrains.Annotations;

// Token: 0x02001D16 RID: 7446
public sealed class TraderAssortmentControllerClass
{
	// Token: 0x140001CC RID: 460
	// (add) Token: 0x06009A16 RID: 39446 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009A17 RID: 39447 RVA: 0x00002050 File Offset: 0x00000250
	public event Action RequisiteChanged
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

	// Token: 0x140001CD RID: 461
	// (add) Token: 0x06009A18 RID: 39448 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009A19 RID: 39449 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Item> ItemPrepared
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

	// Token: 0x170017F0 RID: 6128
	// (get) Token: 0x06009A1A RID: 39450 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009A1B RID: 39451 RVA: 0x00002050 File Offset: 0x00000250
	public int CurrentQuantity
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x170017F1 RID: 6129
	// (get) Token: 0x06009A1C RID: 39452 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009A1D RID: 39453 RVA: 0x00002050 File Offset: 0x00000250
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

	// Token: 0x170017F2 RID: 6130
	// (get) Token: 0x06009A1E RID: 39454 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009A1F RID: 39455 RVA: 0x00002050 File Offset: 0x00000250
	public Dictionary<string, int> LoyalLevelItems
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

	// Token: 0x170017F3 RID: 6131
	// (get) Token: 0x06009A20 RID: 39456 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009A21 RID: 39457 RVA: 0x00002050 File Offset: 0x00000250
	public TraderClass.GStruct242 PreparedSum
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

	// Token: 0x170017F4 RID: 6132
	// (get) Token: 0x06009A22 RID: 39458 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009A23 RID: 39459 RVA: 0x00002050 File Offset: 0x00000250
	public bool TransactionInProgress
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

	// Token: 0x170017F5 RID: 6133
	// (get) Token: 0x06009A24 RID: 39460 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009A25 RID: 39461 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsValid
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

	// Token: 0x06009A26 RID: 39462 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task UpdateAssortment(bool ignoreTimeout)
	{
		throw null;
	}

	// Token: 0x06009A27 RID: 39463 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PrepareToSell(Item item, LocationInGrid location)
	{
		throw null;
	}

	// Token: 0x06009A28 RID: 39464 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsBeingSold(Item item)
	{
		throw null;
	}

	// Token: 0x06009A29 RID: 39465 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GClass2765 method_0(Item item)
	{
		throw null;
	}

	// Token: 0x06009A2A RID: 39466 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool QuickFindTradingAppropriatePlace(Item item, Callback callback = null)
	{
		throw null;
	}

	// Token: 0x170017F6 RID: 6134
	// (get) Token: 0x06009A2B RID: 39467 RVA: 0x00002050 File Offset: 0x00000250
	private LootItemClass[] GClass2625_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06009A2C RID: 39468 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanPrepareItemToSell(Item item)
	{
		throw null;
	}

	// Token: 0x06009A2D RID: 39469 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BarterScheme GetSchemeForItem(Item item)
	{
		throw null;
	}

	// Token: 0x06009A2E RID: 39470 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BarterScheme GetSchemeForClone(Item item)
	{
		throw null;
	}

	// Token: 0x06009A2F RID: 39471 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public TraderClass.GStruct242? GetBarterPrice(params Item[] items)
	{
		throw null;
	}

	// Token: 0x06009A30 RID: 39472 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SelectItem(Item item)
	{
		throw null;
	}

	// Token: 0x06009A31 RID: 39473 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x06009A32 RID: 39474 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2([CanBeNull] Item selectedItem, int schemeIndex)
	{
		throw null;
	}

	// Token: 0x06009A33 RID: 39475 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(GClass2045 requisite)
	{
		throw null;
	}

	// Token: 0x06009A34 RID: 39476 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearSellItems()
	{
		throw null;
	}

	// Token: 0x06009A35 RID: 39477 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnprepareSellItem(Item item)
	{
		throw null;
	}

	// Token: 0x06009A36 RID: 39478 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearPreparedItems()
	{
		throw null;
	}

	// Token: 0x06009A37 RID: 39479 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x06009A38 RID: 39480 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task Purchase()
	{
		throw null;
	}

	// Token: 0x06009A39 RID: 39481 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Sell()
	{
		throw null;
	}

	// Token: 0x06009A3A RID: 39482 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> SellAsSavage(string playerId, string petId)
	{
		throw null;
	}

	// Token: 0x06009A3B RID: 39483 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private TradingItemReference[] method_5()
	{
		throw null;
	}

	// Token: 0x06009A3C RID: 39484 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6(TradingItemReference[] itemReferences)
	{
		throw null;
	}

	// Token: 0x06009A3D RID: 39485 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_7(Item subItem)
	{
		throw null;
	}

	// Token: 0x06009A3E RID: 39486 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GClass2045 method_8(GClass1841 x)
	{
		throw null;
	}

	// Token: 0x06009A3F RID: 39487 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GStruct413<GClass2779> method_9(KeyValuePair<Item, LocationInGrid> item)
	{
		throw null;
	}

	// Token: 0x0400A152 RID: 41298
	private const string string_0 = "Error";

	// Token: 0x0400A153 RID: 41299
	private readonly GInterface178 ginterface178_0;

	// Token: 0x0400A154 RID: 41300
	private readonly GClass2495 gclass2495_0;

	// Token: 0x0400A155 RID: 41301
	private readonly ItemFactory gclass1483_0;

	// Token: 0x0400A156 RID: 41302
	private readonly TraderClass gclass2046_0;

	// Token: 0x0400A157 RID: 41303
	private readonly string string_1;

	// Token: 0x0400A158 RID: 41304
	private readonly Dictionary<Item, Item> dictionary_0;

	// Token: 0x0400A159 RID: 41305
	private Dictionary<string, BarterScheme> dictionary_1;

	// Token: 0x0400A15A RID: 41306
	public readonly BindableEvent SelectedItemChanged;

	// Token: 0x0400A15B RID: 41307
	public readonly BindableEvent ValidityChanged;

	// Token: 0x0400A15C RID: 41308
	public readonly BindableEvent QuantityChanged;

	// Token: 0x0400A15D RID: 41309
	public readonly BindableEvent PreparedSumChanged;

	// Token: 0x0400A15E RID: 41310
	public readonly BindableEvent AssortmentUpdated;

	// Token: 0x0400A15F RID: 41311
	public readonly BindableEvent TransactionChanged;

	// Token: 0x0400A160 RID: 41312
	public readonly BindableEvent PreparedItemsChanged;

	// Token: 0x0400A161 RID: 41313
	[CompilerGenerated]
	private Action action_0;

	// Token: 0x0400A162 RID: 41314
	[CompilerGenerated]
	private Action<Item> action_1;

	// Token: 0x0400A163 RID: 41315
	public readonly TraderControllerClass TraderController;

	// Token: 0x0400A164 RID: 41316
	public readonly StashClass SellingStash;

	// Token: 0x0400A165 RID: 41317
	public readonly GClass2495 SellingTableGrid;

	// Token: 0x0400A166 RID: 41318
	public readonly List<GClass2045> CurrentRequisites;

	// Token: 0x0400A167 RID: 41319
	private int int_0;

	// Token: 0x0400A168 RID: 41320
	[CompilerGenerated]
	private Item item_0;

	// Token: 0x0400A169 RID: 41321
	[CompilerGenerated]
	private Dictionary<string, int> dictionary_2;

	// Token: 0x0400A16A RID: 41322
	[CompilerGenerated]
	private TraderClass.GStruct242 gstruct242_0;

	// Token: 0x0400A16B RID: 41323
	private bool bool_0;

	// Token: 0x0400A16C RID: 41324
	[CompilerGenerated]
	private bool bool_1;

	// Token: 0x02001D17 RID: 7447
	[CompilerGenerated]
	private sealed class Class1733
	{
		// Token: 0x06009A40 RID: 39488 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Dictionary<string, Item> method_0()
		{
			throw null;
		}

		// Token: 0x0400A16D RID: 41325
		public TraderAssortmentControllerClass gclass2043_0;

		// Token: 0x0400A16E RID: 41326
		public GClass1186[] allItems;
	}

	// Token: 0x02001D18 RID: 7448
	[CompilerGenerated]
	private sealed class Class1734
	{
		// Token: 0x06009A41 RID: 39489 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Item x)
		{
			throw null;
		}

		// Token: 0x0400A16F RID: 41327
		public string newItemId;
	}

	// Token: 0x02001D1A RID: 7450
	[CompilerGenerated]
	private sealed class Class1735
	{
		// Token: 0x06009A44 RID: 39492 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Item sellableItem)
		{
			throw null;
		}

		// Token: 0x0400A179 RID: 41337
		public Item subItem;
	}

	// Token: 0x02001D1B RID: 7451
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1736
	{
		// Token: 0x06009A45 RID: 39493 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal double method_0(BarterVariant y)
		{
			throw null;
		}

		// Token: 0x06009A46 RID: 39494 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal double method_1(GClass1841 j)
		{
			throw null;
		}

		// Token: 0x06009A47 RID: 39495 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_2(GClass2045 requisite)
		{
			throw null;
		}

		// Token: 0x06009A48 RID: 39496 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<TradingItemReference> method_3(GClass2045 x)
		{
			throw null;
		}

		// Token: 0x06009A49 RID: 39497 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal TradingItemReference method_4(Item x)
		{
			throw null;
		}

		// Token: 0x0400A17A RID: 41338
		public static readonly TraderAssortmentControllerClass.Class1736 class1736_0;

		// Token: 0x0400A17B RID: 41339
		public static Func<GClass1841, double> func_0;

		// Token: 0x0400A17C RID: 41340
		public static Func<BarterVariant, double> func_1;

		// Token: 0x0400A17D RID: 41341
		public static Func<GClass2045, bool> func_2;

		// Token: 0x0400A17E RID: 41342
		public static Func<GClass2045, IEnumerable<TradingItemReference>> func_3;

		// Token: 0x0400A17F RID: 41343
		public static Func<Item, TradingItemReference> func_4;
	}

	// Token: 0x02001D1D RID: 7453
	[CompilerGenerated]
	private sealed class Class1737
	{
		// Token: 0x06009A4C RID: 39500 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x0400A186 RID: 41350
		public TraderAssortmentControllerClass gclass2043_0;

		// Token: 0x0400A187 RID: 41351
		public TradingItemReference[] itemReferences;
	}
}
