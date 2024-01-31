using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x02001AE9 RID: 6889
public sealed class GClass1911 : GInterface165
{
	// Token: 0x140001A6 RID: 422
	// (add) Token: 0x060090EC RID: 37100 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060090ED RID: 37101 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GInterface165> OnCompleteItemsCountChanged
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

	// Token: 0x170015F5 RID: 5621
	// (get) Token: 0x060090EE RID: 37102 RVA: 0x00002050 File Offset: 0x00000250
	public bool AnyItemsReady
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170015F6 RID: 5622
	// (get) Token: 0x060090EF RID: 37103 RVA: 0x00002050 File Offset: 0x00000250
	public int EarliestCompleteTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170015F7 RID: 5623
	// (get) Token: 0x060090F0 RID: 37104 RVA: 0x00002050 File Offset: 0x00000250
	public bool Fulfilled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170015F8 RID: 5624
	// (get) Token: 0x060090F1 RID: 37105 RVA: 0x00002050 File Offset: 0x00000250
	public int CompleteItemsCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060090F2 RID: 37106 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitStorage(IEnumerable<GClass1919> schemes)
	{
		throw null;
	}

	// Token: 0x060090F3 RID: 37107 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAdditionalProductionLimit(int additionalLimit)
	{
		throw null;
	}

	// Token: 0x060090F4 RID: 37108 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddItem(string scheme, Item item)
	{
		throw null;
	}

	// Token: 0x060090F5 RID: 37109 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetItems(string scheme, IEnumerable<Item> items, int completeTime)
	{
		throw null;
	}

	// Token: 0x060090F6 RID: 37110 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear(string scheme)
	{
		throw null;
	}

	// Token: 0x060090F7 RID: 37111 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ValueTuple<string, List<Item>> FindCompleteItems()
	{
		throw null;
	}

	// Token: 0x060090F8 RID: 37112 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<Item> GetItems(string scheme)
	{
		throw null;
	}

	// Token: 0x060090F9 RID: 37113 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetItemsCount(string scheme)
	{
		throw null;
	}

	// Token: 0x060090FA RID: 37114 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetItemsLimit(string scheme)
	{
		throw null;
	}

	// Token: 0x0400982F RID: 38959
	[CompilerGenerated]
	private Action<GInterface165> action_0;

	// Token: 0x04009830 RID: 38960
	private readonly Dictionary<string, List<Item>> dictionary_0;

	// Token: 0x04009831 RID: 38961
	private readonly Dictionary<string, int> dictionary_1;

	// Token: 0x04009832 RID: 38962
	private Dictionary<string, int> dictionary_2;

	// Token: 0x04009833 RID: 38963
	private int int_0;

	// Token: 0x02001AEA RID: 6890
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1624
	{
		// Token: 0x060090FB RID: 37115 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(KeyValuePair<string, List<Item>> x)
		{
			throw null;
		}

		// Token: 0x060090FC RID: 37116 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(KeyValuePair<string, List<Item>> x)
		{
			throw null;
		}

		// Token: 0x060090FD RID: 37117 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_2(KeyValuePair<string, List<Item>> x)
		{
			throw null;
		}

		// Token: 0x04009834 RID: 38964
		public static readonly GClass1911.Class1624 class1624_0;

		// Token: 0x04009835 RID: 38965
		public static Func<KeyValuePair<string, List<Item>>, bool> func_0;

		// Token: 0x04009836 RID: 38966
		public static Func<KeyValuePair<string, List<Item>>, bool> func_1;

		// Token: 0x04009837 RID: 38967
		public static Func<KeyValuePair<string, List<Item>>, bool> func_2;
	}
}
