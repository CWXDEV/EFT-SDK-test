using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Game.Spawning;
using UnityEngine;

// Token: 0x020002D7 RID: 727
public abstract class GClass455
{
	// Token: 0x170003B4 RID: 948
	// (get) Token: 0x06000F40 RID: 3904 RVA: 0x00002050 File Offset: 0x00000250
	public string PlayerProfileId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170003B5 RID: 949
	// (get) Token: 0x06000F41 RID: 3905 RVA: 0x00002050 File Offset: 0x00000250
	public int PlayerId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170003B6 RID: 950
	// (get) Token: 0x06000F42 RID: 3906 RVA: 0x00002050 File Offset: 0x00000250
	public string PlayerGroupId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000F43 RID: 3907 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool method_0(IPlayer player)
	{
		throw null;
	}

	// Token: 0x06000F44 RID: 3908 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool method_1(IPlayer player)
	{
		throw null;
	}

	// Token: 0x06000F45 RID: 3909 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_2(IPlayer player, EBotEnemyCause cause)
	{
		throw null;
	}

	// Token: 0x06000F46 RID: 3910 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reactivate()
	{
		throw null;
	}

	// Token: 0x06000F47 RID: 3911
	protected abstract bool OutOfRange(Vector3 position);

	// Token: 0x06000F48 RID: 3912
	protected abstract void ActivateService(Player playerServiceOwner, bool reactivate);

	// Token: 0x06000F49 RID: 3913 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x04000EB7 RID: 3767
	protected Player player_0;

	// Token: 0x04000EB8 RID: 3768
	protected List<Player> list_0;

	// Token: 0x04000EB9 RID: 3769
	protected BotLighthouseKeeperServices botLighthouseKeeperServices_0;

	// Token: 0x04000EBA RID: 3770
	protected IPlayersCollection iplayersCollection_0;

	// Token: 0x04000EBB RID: 3771
	protected GClass551.GInterface13 ginterface13_0;
}
