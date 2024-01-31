using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Comfort.Common;
using EFT.InventoryLogic;

// Token: 0x02000478 RID: 1144
public class BotItemDropper : GClass362
{
	// Token: 0x14000033 RID: 51
	// (add) Token: 0x06001B98 RID: 7064 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001B99 RID: 7065 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Item> OnItemDrop
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

	// Token: 0x06001B9A RID: 7066 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06001B9B RID: 7067 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RefreshItemToDrop()
	{
		throw null;
	}

	// Token: 0x06001B9C RID: 7068 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetItemToDropNext(Item item)
	{
		throw null;
	}

	// Token: 0x06001B9D RID: 7069 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetItemToDropNext(string itemId)
	{
		throw null;
	}

	// Token: 0x06001B9E RID: 7070 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TryDoDrop()
	{
		throw null;
	}

	// Token: 0x06001B9F RID: 7071 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(IResult result)
	{
		throw null;
	}

	// Token: 0x0400176E RID: 5998
	private const float POSSIBLE_DROP_ITEM_PERIOD_SEC = 3f;

	// Token: 0x0400176F RID: 5999
	private readonly List<Item> itemsListCache;

	// Token: 0x04001770 RID: 6000
	private Item _itemToDropNext;

	// Token: 0x04001771 RID: 6001
	private float _nextTimeDrop;

	// Token: 0x04001772 RID: 6002
	private readonly HashSet<string> _possibleItemsTIdsToDrop;

	// Token: 0x04001773 RID: 6003
	private readonly List<Item> _itemsToDropCache;
}
