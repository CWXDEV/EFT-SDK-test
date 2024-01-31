using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x020022CF RID: 8911
public class GClass2500 : IEnumerable, IEnumerable<KeyValuePair<Item, LocationInGrid>>
{
	// Token: 0x17001EDE RID: 7902
	public LocationInGrid this[Item item]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001EDF RID: 7903
	// (get) Token: 0x0600B4FB RID: 46331 RVA: 0x00002050 File Offset: 0x00000250
	public Dictionary<Item, LocationInGrid>.KeyCollection Keys
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001EE0 RID: 7904
	// (get) Token: 0x0600B4FC RID: 46332 RVA: 0x00002050 File Offset: 0x00000250
	public Dictionary<Item, LocationInGrid>.ValueCollection Values
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001EE1 RID: 7905
	// (get) Token: 0x0600B4FD RID: 46333 RVA: 0x00002050 File Offset: 0x00000250
	public int Count
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600B4FE RID: 46334 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Add(Item item, GClass2495 grid, LocationInGrid location)
	{
		throw null;
	}

	// Token: 0x0600B4FF RID: 46335 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Remove(Item item, GClass2495 grid)
	{
		throw null;
	}

	// Token: 0x0600B500 RID: 46336 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Clear()
	{
		throw null;
	}

	// Token: 0x0600B501 RID: 46337 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsKey(Item item)
	{
		throw null;
	}

	// Token: 0x0600B502 RID: 46338 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Item FindItem(string itemId)
	{
		throw null;
	}

	// Token: 0x0600B503 RID: 46339 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator<KeyValuePair<Item, LocationInGrid>> GetEnumerator()
	{
		throw null;
	}

	// Token: 0x0600B504 RID: 46340 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		throw null;
	}

	// Token: 0x0400B8BF RID: 47295
	protected readonly Dictionary<Item, LocationInGrid> dictionary_0;

	// Token: 0x0400B8C0 RID: 47296
	protected readonly List<Item> list_0;
}
