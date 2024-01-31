using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x02001B14 RID: 6932
public sealed class GClass1923 : GInterface165
{
	// Token: 0x140001B5 RID: 437
	// (add) Token: 0x0600925C RID: 37468 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600925D RID: 37469 RVA: 0x00002050 File Offset: 0x00000250
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

	// Token: 0x17001649 RID: 5705
	// (get) Token: 0x0600925E RID: 37470 RVA: 0x00002050 File Offset: 0x00000250
	public bool AnyItemsReady
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700164A RID: 5706
	// (get) Token: 0x0600925F RID: 37471 RVA: 0x00002050 File Offset: 0x00000250
	public bool Fulfilled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700164B RID: 5707
	// (get) Token: 0x06009260 RID: 37472 RVA: 0x00002050 File Offset: 0x00000250
	public int CompleteItemsCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700164C RID: 5708
	// (get) Token: 0x06009261 RID: 37473 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009262 RID: 37474 RVA: 0x00002050 File Offset: 0x00000250
	public int EarliestCompleteTime
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

	// Token: 0x06009263 RID: 37475 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitStorage(IEnumerable<GClass1919> schemes)
	{
		throw null;
	}

	// Token: 0x06009264 RID: 37476 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAdditionalProductionLimit(int additionalLimit)
	{
		throw null;
	}

	// Token: 0x06009265 RID: 37477 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddItem(string scheme, Item item)
	{
		throw null;
	}

	// Token: 0x06009266 RID: 37478 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear(string scheme)
	{
		throw null;
	}

	// Token: 0x06009267 RID: 37479 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ValueTuple<string, List<Item>> FindCompleteItems()
	{
		throw null;
	}

	// Token: 0x06009268 RID: 37480 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<Item> GetItems(string scheme)
	{
		throw null;
	}

	// Token: 0x06009269 RID: 37481 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetItemsCount(string scheme)
	{
		throw null;
	}

	// Token: 0x0600926A RID: 37482 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetItemsLimit(string scheme)
	{
		throw null;
	}

	// Token: 0x0600926B RID: 37483 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetItems(string scheme, IEnumerable<Item> items, int completeTime)
	{
		throw null;
	}

	// Token: 0x0400990C RID: 39180
	[CompilerGenerated]
	private Action<GInterface165> action_0;

	// Token: 0x0400990D RID: 39181
	private readonly List<Item> list_0;

	// Token: 0x0400990E RID: 39182
	private int int_0;

	// Token: 0x0400990F RID: 39183
	private int int_1;

	// Token: 0x04009910 RID: 39184
	private string string_0;

	// Token: 0x04009911 RID: 39185
	[CompilerGenerated]
	private int int_2;
}
