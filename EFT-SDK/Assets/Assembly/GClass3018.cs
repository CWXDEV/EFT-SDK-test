using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.InventoryLogic;
using EFT.Trading;

// Token: 0x020029A0 RID: 10656
public static class GClass3018
{
	// Token: 0x0600D3F2 RID: 54258 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dictionary<GInterface151, GClass1866> RecalculateReferences(Item[] inventoryItems, Dictionary<GInterface151, int> countableToPurchase, IComparer<Item> comparer = null)
	{
		throw null;
	}

	// Token: 0x0600D3F3 RID: 54259 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool smethod_0(Item item, IExchangeRequirement requirement)
	{
		throw null;
	}

	// Token: 0x0600D3F4 RID: 54260 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsFunctional(Item item)
	{
		throw null;
	}

	// Token: 0x0600D3F5 RID: 54261 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsExchangeable(this Item item, bool onlyFunctional = true)
	{
		throw null;
	}

	// Token: 0x0600D3F6 RID: 54262 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsPreparedForTrade(this List<GClass2045> requisites, Item item)
	{
		throw null;
	}

	// Token: 0x0600D3F7 RID: 54263 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AutoFill(this List<GClass2045> requisites, IEnumerable<Item> allItems, Predicate<Item> predicate = null)
	{
		throw null;
	}

	// Token: 0x0600D3F8 RID: 54264 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass1860 AsItemReference(this TradingItemReference tradingItemReference)
	{
		throw null;
	}

	// Token: 0x020029A1 RID: 10657
	[CompilerGenerated]
	private sealed class Class2444
	{
		// Token: 0x0600D3F9 RID: 54265 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Item x)
		{
			throw null;
		}

		// Token: 0x0600D3FA RID: 54266 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(Item x)
		{
			throw null;
		}

		// Token: 0x0600D3FB RID: 54267 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_2(Item x)
		{
			throw null;
		}

		// Token: 0x0400D65B RID: 54875
		public IExchangeRequirement requirement;
	}

	// Token: 0x020029A2 RID: 10658
	[CompilerGenerated]
	private sealed class Class2445
	{
		// Token: 0x0600D3FC RID: 54268 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(KeyValuePair<Item, int> x)
		{
			throw null;
		}

		// Token: 0x0400D65C RID: 54876
		public string templateId;

		// Token: 0x0400D65D RID: 54877
		public Func<KeyValuePair<Item, int>, bool> func_0;
	}

	// Token: 0x020029A3 RID: 10659
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2446
	{
		// Token: 0x0600D3FD RID: 54269 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Item x)
		{
			throw null;
		}

		// Token: 0x0600D3FE RID: 54270 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(Item x)
		{
			throw null;
		}

		// Token: 0x0600D3FF RID: 54271 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_2(Item x)
		{
			throw null;
		}

		// Token: 0x0600D400 RID: 54272 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal DogtagComponent method_3(Item x)
		{
			throw null;
		}

		// Token: 0x0600D401 RID: 54273 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_4(DogtagComponent x)
		{
			throw null;
		}

		// Token: 0x0600D402 RID: 54274 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_5(DogtagComponent x)
		{
			throw null;
		}

		// Token: 0x0600D403 RID: 54275 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_6(DogtagComponent x)
		{
			throw null;
		}

		// Token: 0x0600D404 RID: 54276 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_7(KeyValuePair<Item, int> x)
		{
			throw null;
		}

		// Token: 0x0600D405 RID: 54277 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal DogtagComponent method_8(Item x)
		{
			throw null;
		}

		// Token: 0x0600D406 RID: 54278 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_9(DogtagComponent x)
		{
			throw null;
		}

		// Token: 0x0600D407 RID: 54279 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_10(DogtagComponent x)
		{
			throw null;
		}

		// Token: 0x0600D408 RID: 54280 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_11(DogtagComponent x)
		{
			throw null;
		}

		// Token: 0x0600D409 RID: 54281 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_12(Item x)
		{
			throw null;
		}

		// Token: 0x0600D40A RID: 54282 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_13(Item x)
		{
			throw null;
		}

		// Token: 0x0600D40B RID: 54283 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_14(Item x)
		{
			throw null;
		}

		// Token: 0x0400D65E RID: 54878
		public static readonly GClass3018.Class2446 class2446_0;

		// Token: 0x0400D65F RID: 54879
		public static Func<Item, bool> func_0;

		// Token: 0x0400D660 RID: 54880
		public static Func<Item, bool> func_1;

		// Token: 0x0400D661 RID: 54881
		public static Func<Item, int> func_2;

		// Token: 0x0400D662 RID: 54882
		public static Func<Item, DogtagComponent> func_3;

		// Token: 0x0400D663 RID: 54883
		public static Func<DogtagComponent, bool> func_4;

		// Token: 0x0400D664 RID: 54884
		public static Func<DogtagComponent, int> func_5;

		// Token: 0x0400D665 RID: 54885
		public static Func<DogtagComponent, Item> func_6;

		// Token: 0x0400D666 RID: 54886
		public static Func<KeyValuePair<Item, int>, int> func_7;

		// Token: 0x0400D667 RID: 54887
		public static Func<Item, DogtagComponent> func_8;

		// Token: 0x0400D668 RID: 54888
		public static Func<DogtagComponent, bool> func_9;

		// Token: 0x0400D669 RID: 54889
		public static Func<DogtagComponent, int> func_10;

		// Token: 0x0400D66A RID: 54890
		public static Func<DogtagComponent, Item> func_11;

		// Token: 0x0400D66B RID: 54891
		public static Func<Item, bool> func_12;

		// Token: 0x0400D66C RID: 54892
		public static Func<Item, bool> func_13;

		// Token: 0x0400D66D RID: 54893
		public static Func<Item, int> func_14;
	}

	// Token: 0x020029A4 RID: 10660
	[CompilerGenerated]
	private sealed class Class2447
	{
		// Token: 0x0400D66E RID: 54894
		public List<GClass2045> requisites;

		// Token: 0x0400D66F RID: 54895
		public bool hasPredicate;

		// Token: 0x0400D670 RID: 54896
		public Predicate<Item> predicate;
	}

	// Token: 0x020029A5 RID: 10661
	[CompilerGenerated]
	private sealed class Class2448
	{
		// Token: 0x0600D40C RID: 54284 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Item x)
		{
			throw null;
		}

		// Token: 0x0600D40D RID: 54285 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(Item x)
		{
			throw null;
		}

		// Token: 0x0400D671 RID: 54897
		public GClass2045 requisite;

		// Token: 0x0400D672 RID: 54898
		public GClass3018.Class2447 class2447_0;
	}
}
