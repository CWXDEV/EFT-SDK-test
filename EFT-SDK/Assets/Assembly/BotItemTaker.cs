using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Comfort.Common;
using EFT;
using EFT.Interactive;
using EFT.InventoryLogic;
using UnityEngine;

// Token: 0x02000479 RID: 1145
public class BotItemTaker : GClass362
{
	// Token: 0x14000034 RID: 52
	// (add) Token: 0x06001BA0 RID: 7072 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001BA1 RID: 7073 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Item, IPlayer> OnItemTaken
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

	// Token: 0x170004E5 RID: 1253
	// (get) Token: 0x06001BA2 RID: 7074 RVA: 0x00002050 File Offset: 0x00000250
	private BotGlobalsMindSettings BotGlobalsMindSettings_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06001BA3 RID: 7075 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06001BA4 RID: 7076 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HaveItemToTake()
	{
		throw null;
	}

	// Token: 0x06001BA5 RID: 7077 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x06001BA6 RID: 7078 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RefreshClosestItems()
	{
		throw null;
	}

	// Token: 0x06001BA7 RID: 7079 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private ItemAddress method_0(Item item)
	{
		throw null;
	}

	// Token: 0x06001BA8 RID: 7080 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PickupAction(Player owner, GInterface321 possibleAction, Item rootItem, IPlayer lootItemLastOwner)
	{
		throw null;
	}

	// Token: 0x06001BA9 RID: 7081 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_1(LootItem throwedItem)
	{
		throw null;
	}

	// Token: 0x06001BAA RID: 7082 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(LootItem item)
	{
		throw null;
	}

	// Token: 0x06001BAB RID: 7083 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x06001BAC RID: 7084 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(LootItem itemToTake)
	{
		throw null;
	}

	// Token: 0x06001BAD RID: 7085 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(Vector3 position)
	{
		throw null;
	}

	// Token: 0x06001BAE RID: 7086 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6(LootItem item)
	{
		throw null;
	}

	// Token: 0x06001BAF RID: 7087 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_7(Vector3 transformPosition)
	{
		throw null;
	}

	// Token: 0x06001BB0 RID: 7088 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_8(LootItem item)
	{
		throw null;
	}

	// Token: 0x06001BB1 RID: 7089 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_9(EquipmentSlot slot, LootItem item)
	{
		throw null;
	}

	// Token: 0x06001BB2 RID: 7090 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_10(LootItem thrownItem)
	{
		throw null;
	}

	// Token: 0x06001BB3 RID: 7091 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_11(LootItem item)
	{
		throw null;
	}

	// Token: 0x06001BB4 RID: 7092 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x04001775 RID: 6005
	private const float DIST_TO_TAKE = 1.5f;

	// Token: 0x04001776 RID: 6006
	private const float LOOK_PERIOD = 1.5f;

	// Token: 0x04001777 RID: 6007
	private const int MAX_ITEMS = 10;

	// Token: 0x04001778 RID: 6008
	private const float PERIOD_REFRESH_IF_NO_PLACE = 60f;

	// Token: 0x04001779 RID: 6009
	private const float SDIST_TO_TAKE = 2.25f;

	// Token: 0x0400177A RID: 6010
	private readonly HashSet<LootItem> _thrownItems;

	// Token: 0x0400177B RID: 6011
	private readonly HashSet<LootItem> _preThrownItems;

	// Token: 0x0400177C RID: 6012
	private LootItem _itemToTake;

	// Token: 0x0400177D RID: 6013
	private bool _isCome;

	// Token: 0x0400177E RID: 6014
	private float _timeToTake;

	// Token: 0x0400177F RID: 6015
	private float _nextTimeToTake;

	// Token: 0x04001780 RID: 6016
	private float _nextRefreshTime;

	// Token: 0x04001781 RID: 6017
	private bool canPickUpMeds;

	// Token: 0x04001782 RID: 6018
	private bool canPickUpWeapons;

	// Token: 0x04001783 RID: 6019
	private Vector3 dir;

	// Token: 0x04001784 RID: 6020
	private float _prevDirUpdateTime;

	// Token: 0x04001785 RID: 6021
	private const float DIR_UPDATE_PERIOD = 2f;

	// Token: 0x0200047A RID: 1146
	[CompilerGenerated]
	private sealed class Class228
	{
		// Token: 0x06001BB5 RID: 7093 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(IResult result)
		{
			throw null;
		}

		// Token: 0x04001787 RID: 6023
		public GInterface321 possibleAction;

		// Token: 0x04001788 RID: 6024
		public IPlayer lootItemLastOwner;

		// Token: 0x04001789 RID: 6025
		public Player owner;

		// Token: 0x0400178A RID: 6026
		public Item rootItem;

		// Token: 0x0400178B RID: 6027
		public BotItemTaker botItemTaker_0;

		// Token: 0x0400178C RID: 6028
		public Callback callback_0;
	}

	// Token: 0x0200047B RID: 1147
	[CompilerGenerated]
	private sealed class Class229
	{
		// Token: 0x06001BB7 RID: 7095 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x0400178D RID: 6029
		public BotItemTaker botItemTaker_0;

		// Token: 0x0400178E RID: 6030
		public LootItem item;
	}
}
