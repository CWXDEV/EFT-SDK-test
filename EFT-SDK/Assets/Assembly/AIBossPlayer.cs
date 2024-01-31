using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x020004AE RID: 1198
public class AIBossPlayer : IBossToFollow
{
	// Token: 0x17000527 RID: 1319
	// (get) Token: 0x06001D00 RID: 7424 RVA: 0x00002050 File Offset: 0x00000250
	public bool IAmBoos
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000528 RID: 1320
	// (get) Token: 0x06001D01 RID: 7425 RVA: 0x00002050 File Offset: 0x00000250
	public bool NeedProtection
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000529 RID: 1321
	// (get) Token: 0x06001D02 RID: 7426 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001D03 RID: 7427 RVA: 0x00002050 File Offset: 0x00000250
	public PatrollingData PatrollingData
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

	// Token: 0x1700052A RID: 1322
	// (get) Token: 0x06001D04 RID: 7428 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 Position
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700052B RID: 1323
	// (get) Token: 0x06001D05 RID: 7429 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 PositionOrTargetCover
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700052C RID: 1324
	// (get) Token: 0x06001D06 RID: 7430 RVA: 0x00002050 File Offset: 0x00000250
	public List<BotOwner> Followers
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700052D RID: 1325
	// (get) Token: 0x06001D07 RID: 7431 RVA: 0x00002050 File Offset: 0x00000250
	public int FollowersTargetCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700052E RID: 1326
	// (get) Token: 0x06001D08 RID: 7432 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 PositionIfInCover
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700052F RID: 1327
	// (get) Token: 0x06001D09 RID: 7433 RVA: 0x00002050 File Offset: 0x00000250
	public float MoveSpeed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000530 RID: 1328
	// (get) Token: 0x06001D0A RID: 7434 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsAI
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06001D0B RID: 7435 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PatrolPoint GetPatrolPosByIndex(int botFollowerIndex)
	{
		throw null;
	}

	// Token: 0x06001D0C RID: 7436 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ABossLogic GetBossLogic()
	{
		throw null;
	}

	// Token: 0x06001D0D RID: 7437 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveFollower(BotOwner owner)
	{
		throw null;
	}

	// Token: 0x06001D0E RID: 7438 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsMe(IPlayer player)
	{
		throw null;
	}

	// Token: 0x06001D0F RID: 7439 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IPlayer Player()
	{
		throw null;
	}

	// Token: 0x06001D10 RID: 7440 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public EnemyInfo CurEnemy()
	{
		throw null;
	}

	// Token: 0x06001D11 RID: 7441 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BotOwner GetFirstFollower(bool withGrenade)
	{
		throw null;
	}

	// Token: 0x06001D12 RID: 7442 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OfferBot(BotOwner bot)
	{
		throw null;
	}

	// Token: 0x06001D13 RID: 7443 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x040018AB RID: 6315
	private readonly Player _player;
}
