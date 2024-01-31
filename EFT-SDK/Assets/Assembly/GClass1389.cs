using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x02001257 RID: 4695
public static class GClass1389
{
	// Token: 0x06006253 RID: 25171 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass1390 Deserialize(GInterface77 stream)
	{
		throw null;
	}

	// Token: 0x06006254 RID: 25172 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Serialize(GInterface77 stream, IEnumerable<Item> items)
	{
		throw null;
	}

	// Token: 0x06006255 RID: 25173 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Serialize(GInterface79 stream, GClass1391 item)
	{
		throw null;
	}

	// Token: 0x06006256 RID: 25174 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Deserialize(GInterface76 stream, out GClass1391 item)
	{
		throw null;
	}

	// Token: 0x06006257 RID: 25175 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void FillSearchInfo(GClass1391[] searchableItemInfos, SearchableItemClass[] items)
	{
		throw null;
	}

	// Token: 0x06006258 RID: 25176 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GClass1390 smethod_0(IEnumerable<Item> items)
	{
		throw null;
	}

	// Token: 0x02001258 RID: 4696
	[CompilerGenerated]
	private sealed class Class898
	{
		// Token: 0x06006259 RID: 25177 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(SearchableItemClass x)
		{
			throw null;
		}

		// Token: 0x04006EC4 RID: 28356
		public GClass1391 searchableItemInfo;
	}

	// Token: 0x02001259 RID: 4697
	[CompilerGenerated]
	private sealed class Class899
	{
		// Token: 0x0600625A RID: 25178 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass2495 x)
		{
			throw null;
		}

		// Token: 0x04006EC5 RID: 28357
		public GClass1392 gridInfo;
	}

	// Token: 0x0200125A RID: 4698
	[CompilerGenerated]
	[Serializable]
	private sealed class Class900
	{
		// Token: 0x0600625B RID: 25179 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass1391 method_0(SearchableItemClass item)
		{
			throw null;
		}

		// Token: 0x0600625C RID: 25180 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_1(KeyValuePair<string, BindableState<SearchedState>> x)
		{
			throw null;
		}

		// Token: 0x0600625D RID: 25181 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal SearchedState method_2(KeyValuePair<string, BindableState<SearchedState>> x)
		{
			throw null;
		}

		// Token: 0x0600625E RID: 25182 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass1392 method_3(GClass2498 grid)
		{
			throw null;
		}

		// Token: 0x04006EC6 RID: 28358
		public static readonly GClass1389.Class900 class900_0;

		// Token: 0x04006EC7 RID: 28359
		public static Func<KeyValuePair<string, BindableState<SearchedState>>, string> func_0;

		// Token: 0x04006EC8 RID: 28360
		public static Func<KeyValuePair<string, BindableState<SearchedState>>, SearchedState> func_1;

		// Token: 0x04006EC9 RID: 28361
		public static Func<GClass2498, GClass1392> func_2;

		// Token: 0x04006ECA RID: 28362
		public static Func<SearchableItemClass, GClass1391> func_3;
	}
}
