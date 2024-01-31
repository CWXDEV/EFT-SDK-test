using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Counters;

// Token: 0x020004B6 RID: 1206
public sealed class PlayerLoyaltyData
{
	// Token: 0x1700054A RID: 1354
	// (get) Token: 0x06001D6E RID: 7534 RVA: 0x00002050 File Offset: 0x00000250
	public bool HostileScavs
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700054B RID: 1355
	// (get) Token: 0x06001D6F RID: 7535 RVA: 0x00002050 File Offset: 0x00000250
	public bool BossNoAttack
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700054C RID: 1356
	// (get) Token: 0x06001D70 RID: 7536 RVA: 0x00002050 File Offset: 0x00000250
	public float ChanceApplyStopRequest
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700054D RID: 1357
	// (get) Token: 0x06001D71 RID: 7537 RVA: 0x00002050 File Offset: 0x00000250
	public float ChanceApplyGetInCoverRequest
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700054E RID: 1358
	// (get) Token: 0x06001D72 RID: 7538 RVA: 0x00002050 File Offset: 0x00000250
	public float ChanceApplySilenceRequest
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700054F RID: 1359
	// (get) Token: 0x06001D73 RID: 7539 RVA: 0x00002050 File Offset: 0x00000250
	public float ChanceApplySpreadoutRequest
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000550 RID: 1360
	// (get) Token: 0x06001D74 RID: 7540 RVA: 0x00002050 File Offset: 0x00000250
	public float ChanceApplyHelpRequest
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000551 RID: 1361
	// (get) Token: 0x06001D75 RID: 7541 RVA: 0x00002050 File Offset: 0x00000250
	public float ChanceApplyFollowRequest
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000552 RID: 1362
	// (get) Token: 0x06001D76 RID: 7542 RVA: 0x00002050 File Offset: 0x00000250
	public bool ScavAttackSupport
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000553 RID: 1363
	// (get) Token: 0x06001D77 RID: 7543 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsAggressor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000554 RID: 1364
	// (get) Token: 0x06001D78 RID: 7544 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001D79 RID: 7545 RVA: 0x00002050 File Offset: 0x00000250
	public bool CanBeFreeKilled
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

	// Token: 0x06001D7A RID: 7546 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void KillEnemy(Player victim)
	{
		throw null;
	}

	// Token: 0x06001D7B RID: 7547 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MarkAsAggressor(IPlayer victim)
	{
		throw null;
	}

	// Token: 0x06001D7C RID: 7548 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool WasAttackedBy(IPlayer person)
	{
		throw null;
	}

	// Token: 0x06001D7D RID: 7549 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MarkAsCanBeFreeKilled()
	{
		throw null;
	}

	// Token: 0x06001D7E RID: 7550 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(Player victim, string title, double standingDelta)
	{
		throw null;
	}

	// Token: 0x06001D7F RID: 7551 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(Player victim)
	{
		throw null;
	}

	// Token: 0x06001D80 RID: 7552 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(Player victim)
	{
		throw null;
	}

	// Token: 0x06001D81 RID: 7553 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(double standingDelta, EFenceStandingSource standingSource)
	{
		throw null;
	}

	// Token: 0x06001D82 RID: 7554 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(GClass1745 victimSettings)
	{
		throw null;
	}

	// Token: 0x06001D83 RID: 7555 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(PlayerLoyaltyData loyaltyData)
	{
		throw null;
	}

	// Token: 0x040018E1 RID: 6369
	private const float AGGRESSOR_PERIOD = 180f;

	// Token: 0x040018E2 RID: 6370
	private double _endAggressor;

	// Token: 0x040018E3 RID: 6371
	private readonly Player _player;

	// Token: 0x040018E4 RID: 6372
	private readonly Profile.FenceTraderInfo _loyaltySetting;

	// Token: 0x040018E5 RID: 6373
	private int _regularScavKills;

	// Token: 0x040018E6 RID: 6374
	private ValueTuple<double, EFenceStandingSource> _aggressorBonus;

	// Token: 0x040018E7 RID: 6375
	private readonly Dictionary<string, bool> _enemies;
}
