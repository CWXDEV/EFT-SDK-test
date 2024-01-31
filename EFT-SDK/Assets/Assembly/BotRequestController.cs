using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Interactive;
using EFT.InventoryLogic;
using UnityEngine;

// Token: 0x020002D2 RID: 722
public class BotRequestController
{
	// Token: 0x170003B1 RID: 945
	// (get) Token: 0x06000F04 RID: 3844 RVA: 0x00002050 File Offset: 0x00000250
	public float LastSetRequestTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170003B2 RID: 946
	// (get) Token: 0x06000F05 RID: 3845 RVA: 0x00002050 File Offset: 0x00000250
	public BotGroupRequestController GroupRequestController
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000F06 RID: 3846 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetRequestsCount<T>() where T : BotRequest
	{
		throw null;
	}

	// Token: 0x06000F07 RID: 3847 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(BotRequest obj)
	{
		throw null;
	}

	// Token: 0x06000F08 RID: 3848 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryThrowSuppressionRequest()
	{
		throw null;
	}

	// Token: 0x06000F09 RID: 3849 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ThrowWarnPlayerRequest(Player playerToWarn, Action<Player> completeCallback, Action<Player> disposeCallback, Func<BotOwner, bool> canStartRequest, EWarnMode warnMode, GClass361 dataWarn, out GClass515 warnPlayerRequest)
	{
		throw null;
	}

	// Token: 0x06000F0A RID: 3850 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryActivateGoToPointRequest(Vector3 point, Action completeCallback = null, Action disposeCallback = null)
	{
		throw null;
	}

	// Token: 0x06000F0B RID: 3851 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryActivateThrowGrenadeRequest(Vector3 placeToThrow, ThrowWeapType? throwType, out GClass514 request)
	{
		throw null;
	}

	// Token: 0x06000F0C RID: 3852 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryActivateOpenDoorRequest(Door door, Action completeCallback)
	{
		throw null;
	}

	// Token: 0x06000F0D RID: 3853 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryActivateThrowGrenadeRequestToPlace(Player targetToThrow, Action callbackFinish = null)
	{
		throw null;
	}

	// Token: 0x06000F0E RID: 3854 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryActivateThrowGrenadeRequest(Player targetToThrow, bool onlyCached = false, Action callbackFinish = null)
	{
		throw null;
	}

	// Token: 0x06000F0F RID: 3855 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TrySayNegative(IPlayer player, BotRequestType rejectedRequest)
	{
		throw null;
	}

	// Token: 0x06000F10 RID: 3856 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
		throw null;
	}

	// Token: 0x06000F11 RID: 3857 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TryToFind()
	{
		throw null;
	}

	// Token: 0x06000F12 RID: 3858 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCurrentRequest(BotRequest possibleRequest)
	{
		throw null;
	}

	// Token: 0x06000F13 RID: 3859 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CompleteRequest(BotRequest botRequest)
	{
		throw null;
	}

	// Token: 0x06000F14 RID: 3860 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetTimer()
	{
		throw null;
	}

	// Token: 0x06000F15 RID: 3861 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveAllRequestByRequester(Player getPlayer)
	{
		throw null;
	}

	// Token: 0x06000F16 RID: 3862 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HaveActivatedRequests()
	{
		throw null;
	}

	// Token: 0x06000F17 RID: 3863 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryStopCurrent(Player player, bool withTalk = true)
	{
		throw null;
	}

	// Token: 0x06000F18 RID: 3864 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DoNotAcceptRequests(BotRequest lastRequestFailed)
	{
		throw null;
	}

	// Token: 0x06000F19 RID: 3865 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsAvailableByTime(BotRequestType brt)
	{
		throw null;
	}

	// Token: 0x06000F1A RID: 3866 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_1()
	{
		throw null;
	}

	// Token: 0x06000F1B RID: 3867 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x06000F1C RID: 3868 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x04000E9B RID: 3739
	public const float PHRASE_DIST_SQRT = 25f;

	// Token: 0x04000E9C RID: 3740
	private const float DELTA_TIME_ACTIVATE_REQUEST_SEC = 10f;

	// Token: 0x04000E9D RID: 3741
	private const float DELTA_TIME_SEARCH_REQUEST_FO_SELF = 10f;

	// Token: 0x04000E9E RID: 3742
	public BotRequest CurRequest;

	// Token: 0x04000E9F RID: 3743
	private readonly BotOwner _owner;

	// Token: 0x04000EA0 RID: 3744
	private float _nextFindTime;

	// Token: 0x04000EA1 RID: 3745
	private float _nextRequestTime;

	// Token: 0x04000EA2 RID: 3746
	private float _nextGoToPointRequestTime;

	// Token: 0x04000EA3 RID: 3747
	private float _nextThrowGrenadeRequestTime;

	// Token: 0x04000EA4 RID: 3748
	private BotGroupRequestController _groupRequestController;

	// Token: 0x04000EA5 RID: 3749
	private readonly Dictionary<BotRequestType, float> _blockUntil;

	// Token: 0x04000EA6 RID: 3750
	private float _lastSetRequestTime;
}
