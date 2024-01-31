using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x020002DC RID: 732
public class BotLighthouseKeeperServices
{
	// Token: 0x170003BB RID: 955
	// (get) Token: 0x06000F74 RID: 3956 RVA: 0x00002050 File Offset: 0x00000250
	public List<BotLighthouseKeeperFriendlyExUsecs> FriendlyExUsecs
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170003BC RID: 956
	// (get) Token: 0x06000F75 RID: 3957 RVA: 0x00002050 File Offset: 0x00000250
	public List<BotLighthouseKeeperFriendlyZryachiy> FriendlyZryachiy
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170003BD RID: 957
	// (get) Token: 0x06000F76 RID: 3958 RVA: 0x00002050 File Offset: 0x00000250
	public List<int> MarkedPlayers
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000F77 RID: 3959 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsPlayerExUsecFriendly(IPlayer player)
	{
		throw null;
	}

	// Token: 0x06000F78 RID: 3960 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsPlayerZryachiyFriendly(IPlayer player)
	{
		throw null;
	}

	// Token: 0x06000F79 RID: 3961 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShallWarn(BotOwner owner, Player playerToWarn)
	{
		throw null;
	}

	// Token: 0x06000F7A RID: 3962 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnFriendlyExUsecPurchased(Player player)
	{
		throw null;
	}

	// Token: 0x06000F7B RID: 3963 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnFriendlyZryachiyPurchased(Player player)
	{
		throw null;
	}

	// Token: 0x06000F7C RID: 3964 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CancelAllLighthouseKeeperServicesForPlayersTeam(IPlayer player)
	{
		throw null;
	}

	// Token: 0x06000F7D RID: 3965 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(string playerProfileId)
	{
		throw null;
	}

	// Token: 0x06000F7E RID: 3966 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsExUsecsServiceActive(IPlayer player)
	{
		throw null;
	}

	// Token: 0x06000F7F RID: 3967 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(IPlayer player)
	{
		throw null;
	}

	// Token: 0x06000F80 RID: 3968 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x04000EC4 RID: 3780
	private const float CHECK_FRIENDLY_PERIOD = 5f;

	// Token: 0x04000EC5 RID: 3781
	private float _nextCheckTime;

	// Token: 0x04000EC6 RID: 3782
	private BotsController _botsController;

	// Token: 0x04000EC7 RID: 3783
	private List<BotLighthouseKeeperFriendlyExUsecs> _friendlyExUsecs;

	// Token: 0x04000EC8 RID: 3784
	private List<BotLighthouseKeeperFriendlyZryachiy> _friendlyZryachiy;

	// Token: 0x04000EC9 RID: 3785
	private List<int> _markedPlayers;
}
