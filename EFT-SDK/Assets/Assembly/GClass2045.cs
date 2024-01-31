using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Diz.Binding;
using EFT.InventoryLogic;
using EFT.Trading;

// Token: 0x02001D23 RID: 7459
public sealed class GClass2045
{
	// Token: 0x140001CF RID: 463
	// (add) Token: 0x06009A5A RID: 39514 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009A5B RID: 39515 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GClass2045> OnChanged
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

	// Token: 0x140001D0 RID: 464
	// (add) Token: 0x06009A5C RID: 39516 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06009A5D RID: 39517 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnChangedFromInventory
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

	// Token: 0x170017F8 RID: 6136
	// (get) Token: 0x06009A5E RID: 39518 RVA: 0x00002050 File Offset: 0x00000250
	public int PreparedItemsCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170017F9 RID: 6137
	// (get) Token: 0x06009A5F RID: 39519 RVA: 0x00002050 File Offset: 0x00000250
	public int RequiredItemsCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170017FA RID: 6138
	// (get) Token: 0x06009A60 RID: 39520 RVA: 0x00002050 File Offset: 0x00000250
	public bool Enough
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170017FB RID: 6139
	// (get) Token: 0x06009A61 RID: 39521 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsDogtagRequired
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170017FC RID: 6140
	// (get) Token: 0x06009A62 RID: 39522 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009A63 RID: 39523 RVA: 0x00002050 File Offset: 0x00000250
	public int Quantity
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

	// Token: 0x06009A64 RID: 39524 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsRequired(Item item)
	{
		throw null;
	}

	// Token: 0x06009A65 RID: 39525 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PrepareItem(Item item)
	{
		throw null;
	}

	// Token: 0x06009A66 RID: 39526 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveItem(Item item)
	{
		throw null;
	}

	// Token: 0x06009A67 RID: 39527 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(GEventArgs2 args)
	{
		throw null;
	}

	// Token: 0x06009A68 RID: 39528 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(GEventArgs3 args)
	{
		throw null;
	}

	// Token: 0x06009A69 RID: 39529 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		throw null;
	}

	// Token: 0x06009A6A RID: 39530 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsEqual(GClass2045 requisite)
	{
		throw null;
	}

	// Token: 0x06009A6B RID: 39531 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Consume(GClass2045 requisite)
	{
		throw null;
	}

	// Token: 0x06009A6C RID: 39532 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsPreparedForTrade(Item item)
	{
		throw null;
	}

	// Token: 0x0400A19C RID: 41372
	private readonly HashSet<IItemOwner> hashSet_0;

	// Token: 0x0400A19D RID: 41373
	[CompilerGenerated]
	private Action<GClass2045> action_0;

	// Token: 0x0400A19E RID: 41374
	[CompilerGenerated]
	private Action action_1;

	// Token: 0x0400A19F RID: 41375
	public readonly Item RequiredItem;

	// Token: 0x0400A1A0 RID: 41376
	public readonly double Count;

	// Token: 0x0400A1A1 RID: 41377
	public readonly int Level;

	// Token: 0x0400A1A2 RID: 41378
	public readonly bool OnlyFunctional;

	// Token: 0x0400A1A3 RID: 41379
	public readonly bool IsEncoded;

	// Token: 0x0400A1A4 RID: 41380
	public readonly EDogtagExchangeSide Side;

	// Token: 0x0400A1A5 RID: 41381
	public readonly List<TradingItemReference> PreparedItems;

	// Token: 0x0400A1A6 RID: 41382
	[NonSerialized]
	public readonly BindableEvent PreparedChanged;

	// Token: 0x0400A1A7 RID: 41383
	private int int_0;

	// Token: 0x02001D24 RID: 7460
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1740
	{
		// Token: 0x06009A6D RID: 39533 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_0(TradingItemReference x)
		{
			throw null;
		}

		// Token: 0x06009A6E RID: 39534 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IItemOwner method_1(TradingItemReference itemRef)
		{
			throw null;
		}

		// Token: 0x0400A1A8 RID: 41384
		public static readonly GClass2045.Class1740 class1740_0;

		// Token: 0x0400A1A9 RID: 41385
		public static Func<TradingItemReference, int> func_0;

		// Token: 0x0400A1AA RID: 41386
		public static Func<TradingItemReference, IItemOwner> func_1;
	}

	// Token: 0x02001D25 RID: 7461
	[CompilerGenerated]
	private sealed class Class1741
	{
		// Token: 0x06009A6F RID: 39535 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(TradingItemReference itemRef)
		{
			throw null;
		}

		// Token: 0x0400A1AB RID: 41387
		public Item item;
	}

	// Token: 0x02001D26 RID: 7462
	[CompilerGenerated]
	private sealed class Class1742
	{
		// Token: 0x06009A70 RID: 39536 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(TradingItemReference itemReference)
		{
			throw null;
		}

		// Token: 0x0400A1AC RID: 41388
		public Item item;
	}

	// Token: 0x02001D27 RID: 7463
	[CompilerGenerated]
	private sealed class Class1743
	{
		// Token: 0x06009A71 RID: 39537 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(TradingItemReference itemReference)
		{
			throw null;
		}

		// Token: 0x0400A1AD RID: 41389
		public Item item;
	}
}
