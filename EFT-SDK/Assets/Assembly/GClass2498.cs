using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x020022D6 RID: 8918
public class GClass2498 : GClass2495
{
	// Token: 0x0600B510 RID: 46352 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Dictionary<Item, LocationInGrid> GetItemsForPlayer(string profileId)
	{
		throw null;
	}

	// Token: 0x0600B511 RID: 46353 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct415<int> AddItem(Item item, LocationInGrid location, string[] profileIds, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600B512 RID: 46354 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct415<int> AddItemWithoutRestrictions(Item item, LocationInGrid location, string[] profileIds)
	{
		throw null;
	}

	// Token: 0x0600B513 RID: 46355 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct415<GStruct369> RemoveItem(Item item, string profileId, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600B514 RID: 46356 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Dictionary<Item, LocationInGrid> GetUnknownItems(string profileId)
	{
		throw null;
	}

	// Token: 0x0600B515 RID: 46357 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSearched(string profileId, Item item)
	{
		throw null;
	}

	// Token: 0x0600B516 RID: 46358 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FindAll(string profileId)
	{
		throw null;
	}

	// Token: 0x0600B517 RID: 46359 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetKnownItems(string profileId, IEnumerable<string> items)
	{
		throw null;
	}

	// Token: 0x0600B518 RID: 46360 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string[] GetKnownItems(string profileId)
	{
		throw null;
	}

	// Token: 0x0600B519 RID: 46361 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass1392 GetSearchableInfo()
	{
		throw null;
	}

	// Token: 0x020022D7 RID: 8919
	[CompilerGenerated]
	private sealed class Class1976
	{
		// Token: 0x0600B51A RID: 46362 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal LocationInGrid method_0(KeyValuePair<Item, LocationInGrid> x)
		{
			throw null;
		}

		// Token: 0x0400B8CB RID: 47307
		public string[] knownItems;
	}

	// Token: 0x020022D8 RID: 8920
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1977
	{
		// Token: 0x0600B51B RID: 46363 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_0(KeyValuePair<Item, LocationInGrid> x)
		{
			throw null;
		}

		// Token: 0x0600B51C RID: 46364 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_1(KeyValuePair<Item, LocationInGrid> x)
		{
			throw null;
		}

		// Token: 0x0600B51D RID: 46365 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal LocationInGrid method_2(KeyValuePair<Item, LocationInGrid> x)
		{
			throw null;
		}

		// Token: 0x0600B51E RID: 46366 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_3(Item x)
		{
			throw null;
		}

		// Token: 0x0600B51F RID: 46367 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_4(Item i)
		{
			throw null;
		}

		// Token: 0x0400B8CC RID: 47308
		public static readonly GClass2498.Class1977 class1977_0;

		// Token: 0x0400B8CD RID: 47309
		public static Func<KeyValuePair<Item, LocationInGrid>, Item> func_0;

		// Token: 0x0400B8CE RID: 47310
		public static Func<KeyValuePair<Item, LocationInGrid>, Item> func_1;

		// Token: 0x0400B8CF RID: 47311
		public static Func<KeyValuePair<Item, LocationInGrid>, LocationInGrid> func_2;

		// Token: 0x0400B8D0 RID: 47312
		public static Func<Item, string> func_3;

		// Token: 0x0400B8D1 RID: 47313
		public static Func<Item, string> func_4;
	}

	// Token: 0x020022D9 RID: 8921
	[CompilerGenerated]
	private sealed class Class1978
	{
		// Token: 0x0600B520 RID: 46368 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(string x)
		{
			throw null;
		}

		// Token: 0x0400B8D2 RID: 47314
		public Item item;
	}

	// Token: 0x020022DA RID: 8922
	[CompilerGenerated]
	private sealed class Class1979
	{
		// Token: 0x0600B521 RID: 46369 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(KeyValuePair<Item, LocationInGrid> x)
		{
			throw null;
		}

		// Token: 0x0400B8D3 RID: 47315
		public string[] knownItems;
	}

	// Token: 0x020022DB RID: 8923
	[CompilerGenerated]
	private sealed class Class1980
	{
		// Token: 0x0600B522 RID: 46370 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(KeyValuePair<Item, LocationInGrid> pair)
		{
			throw null;
		}

		// Token: 0x0400B8D4 RID: 47316
		public Item item;
	}
}
