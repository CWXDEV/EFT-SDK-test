using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.InventoryLogic;
using UnityEngine;

// Token: 0x020002BF RID: 703
public class BotGiftData : GClass362
{
	// Token: 0x17000394 RID: 916
	// (get) Token: 0x06000E64 RID: 3684 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000E65 RID: 3685 RVA: 0x00002050 File Offset: 0x00000250
	public GiftTarget GiftTarget
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

	// Token: 0x06000E66 RID: 3686 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(Item itm, IPlayer pl)
	{
		throw null;
	}

	// Token: 0x06000E67 RID: 3687 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsItemTaken(Item itm)
	{
		throw null;
	}

	// Token: 0x06000E68 RID: 3688 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HaveUngiftedPlayerNear()
	{
		throw null;
	}

	// Token: 0x06000E69 RID: 3689 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateGiftTarget()
	{
		throw null;
	}

	// Token: 0x06000E6A RID: 3690 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GiftTarget GetGiftTarget(IPlayer player)
	{
		throw null;
	}

	// Token: 0x06000E6B RID: 3691 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsPlayerOnDistance(IPlayer player, float dist)
	{
		throw null;
	}

	// Token: 0x06000E6C RID: 3692 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x06000E6D RID: 3693 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x06000E6E RID: 3694 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CalcGiftsOnStart()
	{
		throw null;
	}

	// Token: 0x04000E21 RID: 3617
	public const float DROP_GIFT_DISTANCE = 5f;

	// Token: 0x04000E22 RID: 3618
	private const float GIFT_PLAYER_DISTANCE = 25f;

	// Token: 0x04000E23 RID: 3619
	private const float GIFT_PLAYER_LOSE_TARGET_DISTANCE = 35f;

	// Token: 0x04000E24 RID: 3620
	private const float REPEAT_TRY_GIFT_PLAYER_TIME = 60f;

	// Token: 0x04000E25 RID: 3621
	private Vector3 pointToDrop;

	// Token: 0x04000E27 RID: 3623
	private Dictionary<IPlayer, GiftTarget> _gifterPlayers;

	// Token: 0x04000E28 RID: 3624
	private EquipmentSlot[] slots;

	// Token: 0x04000E29 RID: 3625
	private readonly int _additionalGiftsLimit;

	// Token: 0x04000E2A RID: 3626
	private List<Item> _takenItems;

	// Token: 0x04000E2B RID: 3627
	private float _nextCheckTime;
}
