using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using EFT;
using EFT.InventoryLogic;
using Newtonsoft.Json;

// Token: 0x0200245C RID: 9308
public class GClass2740 : ISerializer<Inventory>
{
	// Token: 0x0600BB0D RID: 47885 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Inventory Deserialize()
	{
		throw null;
	}

	// Token: 0x0600BB0E RID: 47886 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Serialize(Inventory inventory)
	{
		throw null;
	}

	// Token: 0x0400BD8B RID: 48523
	public GClass1186[] items;

	// Token: 0x0400BD8C RID: 48524
	public string equipment;

	// Token: 0x0400BD8D RID: 48525
	[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
	[DefaultValue(null)]
	public string stash;

	// Token: 0x0400BD8E RID: 48526
	[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
	[DefaultValue(null)]
	public string questRaidItems;

	// Token: 0x0400BD8F RID: 48527
	[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
	[DefaultValue(null)]
	public string questStashItems;

	// Token: 0x0400BD90 RID: 48528
	[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
	[DefaultValue(null)]
	public string sortingTable;

	// Token: 0x0400BD91 RID: 48529
	public Dictionary<EBoundItem, string> fastPanel;

	// Token: 0x0400BD92 RID: 48530
	public Dictionary<EAreaType, string> hideoutAreaStashes;

	// Token: 0x0400BD93 RID: 48531
	[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
	public GClass1742 favoriteItems;

	// Token: 0x0200245D RID: 9309
	[CompilerGenerated]
	private sealed class Class2057
	{
		// Token: 0x0600BB0F RID: 47887 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(KeyValuePair<EBoundItem, string> x)
		{
			throw null;
		}

		// Token: 0x0600BB10 RID: 47888 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_1(KeyValuePair<EBoundItem, string> x)
		{
			throw null;
		}

		// Token: 0x0400BD94 RID: 48532
		public Dictionary<string, Item> realItems;
	}

	// Token: 0x0200245E RID: 9310
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2058
	{
		// Token: 0x0600BB11 RID: 47889 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal EBoundItem method_0(KeyValuePair<EBoundItem, string> x)
		{
			throw null;
		}

		// Token: 0x0600BB12 RID: 47890 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(KeyValuePair<EAreaType, LootItemClass> x)
		{
			throw null;
		}

		// Token: 0x0600BB13 RID: 47891 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal EAreaType method_2(KeyValuePair<EAreaType, LootItemClass> x)
		{
			throw null;
		}

		// Token: 0x0600BB14 RID: 47892 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_3(KeyValuePair<EAreaType, LootItemClass> x)
		{
			throw null;
		}

		// Token: 0x0600BB15 RID: 47893 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_4(KeyValuePair<EBoundItem, Item> x)
		{
			throw null;
		}

		// Token: 0x0600BB16 RID: 47894 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal EBoundItem method_5(KeyValuePair<EBoundItem, Item> x)
		{
			throw null;
		}

		// Token: 0x0600BB17 RID: 47895 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_6(KeyValuePair<EBoundItem, Item> x)
		{
			throw null;
		}

		// Token: 0x0400BD95 RID: 48533
		public static readonly GClass2740.Class2058 class2058_0;

		// Token: 0x0400BD96 RID: 48534
		public static Func<KeyValuePair<EBoundItem, string>, EBoundItem> func_0;

		// Token: 0x0400BD97 RID: 48535
		public static Func<KeyValuePair<EAreaType, LootItemClass>, bool> func_1;

		// Token: 0x0400BD98 RID: 48536
		public static Func<KeyValuePair<EAreaType, LootItemClass>, EAreaType> func_2;

		// Token: 0x0400BD99 RID: 48537
		public static Func<KeyValuePair<EAreaType, LootItemClass>, string> func_3;

		// Token: 0x0400BD9A RID: 48538
		public static Func<KeyValuePair<EBoundItem, Item>, bool> func_4;

		// Token: 0x0400BD9B RID: 48539
		public static Func<KeyValuePair<EBoundItem, Item>, EBoundItem> func_5;

		// Token: 0x0400BD9C RID: 48540
		public static Func<KeyValuePair<EBoundItem, Item>, string> func_6;
	}
}
