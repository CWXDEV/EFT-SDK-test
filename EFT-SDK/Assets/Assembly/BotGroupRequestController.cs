using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Interactive;
using EFT.InventoryLogic;
using UnityEngine;

// Token: 0x02000488 RID: 1160
public class BotGroupRequestController
{
	// Token: 0x14000036 RID: 54
	// (add) Token: 0x06001BF2 RID: 7154 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001BF3 RID: 7155 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<BotRequest> OnAddRequest
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

	// Token: 0x170004F0 RID: 1264
	// (get) Token: 0x06001BF4 RID: 7156 RVA: 0x00002050 File Offset: 0x00000250
	public int RequestsCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06001BF5 RID: 7157 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetRequestsCount<T>() where T : BotRequest
	{
		throw null;
	}

	// Token: 0x06001BF6 RID: 7158 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FindForMe(BotOwner executer)
	{
		throw null;
	}

	// Token: 0x06001BF7 RID: 7159 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveAllRequestByRequester(Player requester)
	{
		throw null;
	}

	// Token: 0x06001BF8 RID: 7160 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryAddRequest(BotRequest request)
	{
		throw null;
	}

	// Token: 0x06001BF9 RID: 7161 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryActivateSuppressionRequest(IPlayer requester, EnemyInfo enemy)
	{
		throw null;
	}

	// Token: 0x06001BFA RID: 7162 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass515 TryWarnPlayerRequest(IPlayer requester, Player player2warn, Action<Player> callback, Action<Player> disposeCallback, Func<BotOwner, bool> canStartRequest, EWarnMode warnMode, GClass361 dataWarn)
	{
		throw null;
	}

	// Token: 0x06001BFB RID: 7163 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryActivateThrowGrenadeRequest(IPlayer requester, Vector3 placeToThrow, ThrowWeapType? throwType, out GClass514 request)
	{
		throw null;
	}

	// Token: 0x06001BFC RID: 7164 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryActivateGoToPointRequest(IPlayer requester, Vector3 point, Action completeCallback = null, Action disposeCallback = null)
	{
		throw null;
	}

	// Token: 0x06001BFD RID: 7165 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryActivateThrowGrenadeRequest(IPlayer requester, Player targetToThrow, bool onlyCached)
	{
		throw null;
	}

	// Token: 0x06001BFE RID: 7166 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryAskSuppressionRequest(IPlayer requester, EnemyInfo player)
	{
		throw null;
	}

	// Token: 0x06001BFF RID: 7167 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryAskHideRequest(IPlayer requester)
	{
		throw null;
	}

	// Token: 0x06001C00 RID: 7168 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TryAskHideRequest(IPlayer player, BotOwner posibleExecuter)
	{
		throw null;
	}

	// Token: 0x06001C01 RID: 7169 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryAskFollowMeRequest(IPlayer player, BotOwner posibleExecuter)
	{
		throw null;
	}

	// Token: 0x06001C02 RID: 7170 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TryActivateSuppressionRequest(IPlayer player, BotOwner posibleExecuter)
	{
		throw null;
	}

	// Token: 0x06001C03 RID: 7171 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryActivateGetInCover(IPlayer player, BotOwner posibleExecuter, Vector3? nearestPoint, float period = -1f)
	{
		throw null;
	}

	// Token: 0x06001C04 RID: 7172 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryActivateThrowGrenadeRequest(IPlayer requester, BotOwner posibleExecuter, ThrowWeapType? throwType = null)
	{
		throw null;
	}

	// Token: 0x06001C05 RID: 7173 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TryAskHoldRequest(IPlayer player, BotOwner posibleExecuter)
	{
		throw null;
	}

	// Token: 0x06001C06 RID: 7174 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TryActivateGoToCheckRequest(IPlayer player, BotOwner posibleExecuter)
	{
		throw null;
	}

	// Token: 0x06001C07 RID: 7175 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveRequest(BotRequest botRequest)
	{
		throw null;
	}

	// Token: 0x06001C08 RID: 7176 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryActivateThrowGrenadeRequest(IPlayer requester, Player targetToThrow, bool onlyCached = false, Action callbackFinish = null)
	{
		throw null;
	}

	// Token: 0x06001C09 RID: 7177 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryActivateWait(IPlayer player, BotOwner posibleExecuter)
	{
		throw null;
	}

	// Token: 0x06001C0A RID: 7178 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryActivateOpenDoorRequest(IPlayer requester, Door door, Action completeCallback)
	{
		throw null;
	}

	// Token: 0x06001C0B RID: 7179 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryActivateThrowGrenadePlaceRequest(IPlayer requester, Player targetToThrow, Action callbackFinish = null)
	{
		throw null;
	}

	// Token: 0x06001C0C RID: 7180 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_0(IPlayer player, BotRequest request, BotOwner posibleExecuter)
	{
		throw null;
	}

	// Token: 0x040017C1 RID: 6081
	private readonly List<BotRequest> _listOfRequests;

	// Token: 0x040017C2 RID: 6082
	private readonly BotsGroup _botGroup;

	// Token: 0x02000489 RID: 1161
	[CompilerGenerated]
	[Serializable]
	private sealed class Class232<T> where T : BotRequest
	{
		// Token: 0x06001C0D RID: 7181 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(BotRequest x)
		{
			throw null;
		}

		// Token: 0x040017C4 RID: 6084
		public static readonly BotGroupRequestController.Class232<T> class232_0;

		// Token: 0x040017C5 RID: 6085
		public static Func<BotRequest, bool> func_0;
	}

	// Token: 0x0200048A RID: 1162
	[CompilerGenerated]
	private sealed class Class233
	{
		// Token: 0x06001C0E RID: 7182 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(BotRequest x)
		{
			throw null;
		}

		// Token: 0x040017C6 RID: 6086
		public Player requester;
	}

	// Token: 0x0200048B RID: 1163
	[CompilerGenerated]
	[Serializable]
	private sealed class Class234
	{
		// Token: 0x06001C0F RID: 7183 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x040017C7 RID: 6087
		public static readonly BotGroupRequestController.Class234 class234_0;

		// Token: 0x040017C8 RID: 6088
		public static Action action_0;
	}
}
