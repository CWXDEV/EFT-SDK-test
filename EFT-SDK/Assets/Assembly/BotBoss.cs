using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x02000288 RID: 648
public class BotBoss : GClass362, IBossToFollow
{
	// Token: 0x06000CF1 RID: 3313 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsFollowerSuitableForBoss(WildSpawnType follower, WildSpawnType boss)
	{
		throw null;
	}

	// Token: 0x14000018 RID: 24
	// (add) Token: 0x06000CF2 RID: 3314 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06000CF3 RID: 3315 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<BotOwner, List<BotOwner>> OnBossDead
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

	// Token: 0x14000019 RID: 25
	// (add) Token: 0x06000CF4 RID: 3316 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06000CF5 RID: 3317 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<BotOwner> OnBecomeBoss
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

	// Token: 0x1400001A RID: 26
	// (add) Token: 0x06000CF6 RID: 3318 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06000CF7 RID: 3319 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<BotOwner, FollowerStatusChange> OnFollowerStatusChange
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

	// Token: 0x1700033C RID: 828
	// (get) Token: 0x06000CF8 RID: 3320 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000CF9 RID: 3321 RVA: 0x00002050 File Offset: 0x00000250
	public bool IamBoss
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

	// Token: 0x1700033D RID: 829
	// (get) Token: 0x06000CFA RID: 3322 RVA: 0x00002050 File Offset: 0x00000250
	public bool AllowRequestSelf
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700033E RID: 830
	// (get) Token: 0x06000CFB RID: 3323 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000CFC RID: 3324 RVA: 0x00002050 File Offset: 0x00000250
	public BossWarnData BossWarnData
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

	// Token: 0x1700033F RID: 831
	// (get) Token: 0x06000CFD RID: 3325 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000CFE RID: 3326 RVA: 0x00002050 File Offset: 0x00000250
	public ABossLogic BossLogic
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

	// Token: 0x17000340 RID: 832
	// (get) Token: 0x06000CFF RID: 3327 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000D00 RID: 3328 RVA: 0x00002050 File Offset: 0x00000250
	public bool NeedProtection
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

	// Token: 0x17000341 RID: 833
	// (get) Token: 0x06000D01 RID: 3329 RVA: 0x00002050 File Offset: 0x00000250
	public PatrollingData PatrollingData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000342 RID: 834
	// (get) Token: 0x06000D02 RID: 3330 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsAI
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000343 RID: 835
	// (get) Token: 0x06000D03 RID: 3331 RVA: 0x00002050 File Offset: 0x00000250
	public BotOwner Owner
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000344 RID: 836
	// (get) Token: 0x06000D04 RID: 3332 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 PositionOrTargetCover
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000345 RID: 837
	// (get) Token: 0x06000D05 RID: 3333 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 PositionIfInCover
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000346 RID: 838
	// (get) Token: 0x06000D06 RID: 3334 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 Position
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000347 RID: 839
	// (get) Token: 0x06000D07 RID: 3335 RVA: 0x00002050 File Offset: 0x00000250
	public float MoveSpeed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000348 RID: 840
	// (get) Token: 0x06000D08 RID: 3336 RVA: 0x00002050 File Offset: 0x00000250
	public List<string> DebugInfoFollower
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000349 RID: 841
	// (get) Token: 0x06000D09 RID: 3337 RVA: 0x00002050 File Offset: 0x00000250
	public List<BotOwner> Followers
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700034A RID: 842
	// (get) Token: 0x06000D0A RID: 3338 RVA: 0x00002050 File Offset: 0x00000250
	public int FollowersTargetCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700034B RID: 843
	// (get) Token: 0x06000D0B RID: 3339 RVA: 0x00002050 File Offset: 0x00000250
	public int Id
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700034C RID: 844
	// (get) Token: 0x06000D0C RID: 3340 RVA: 0x00002050 File Offset: 0x00000250
	public int TargetFollowersCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000D0D RID: 3341 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PatrolPoint GetPatrolPosByIndex(int botFollowerIndex)
	{
		throw null;
	}

	// Token: 0x06000D0E RID: 3342 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ABossLogic GetBossLogic()
	{
		throw null;
	}

	// Token: 0x06000D0F RID: 3343 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x06000D10 RID: 3344 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IPlayer Player()
	{
		throw null;
	}

	// Token: 0x06000D11 RID: 3345 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public EnemyInfo CurEnemy()
	{
		throw null;
	}

	// Token: 0x06000D12 RID: 3346 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BotOwner GetFirstFollower(bool withGrenade)
	{
		throw null;
	}

	// Token: 0x06000D13 RID: 3347 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBoss(int followersCount)
	{
		throw null;
	}

	// Token: 0x06000D14 RID: 3348 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetWarnMode(EWarnMode mode)
	{
		throw null;
	}

	// Token: 0x06000D15 RID: 3349 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HaveFollowers()
	{
		throw null;
	}

	// Token: 0x06000D16 RID: 3350 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveFollower(BotOwner botFollower)
	{
		throw null;
	}

	// Token: 0x06000D17 RID: 3351 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsMe(IPlayer player)
	{
		throw null;
	}

	// Token: 0x06000D18 RID: 3352 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeletePlayer(Player getPlayer)
	{
		throw null;
	}

	// Token: 0x06000D19 RID: 3353 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool OfferSelf(BotOwner offer)
	{
		throw null;
	}

	// Token: 0x06000D1A RID: 3354 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06000D1B RID: 3355 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x06000D1C RID: 3356 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x04000D2C RID: 3372
	protected GClass386 _followers;

	// Token: 0x04000D2D RID: 3373
	private GInterface7 _patrolMove;
}
