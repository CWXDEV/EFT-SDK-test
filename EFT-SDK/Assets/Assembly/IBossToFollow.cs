using System;
using System.Collections.Generic;
using EFT;
using UnityEngine;

// Token: 0x02000289 RID: 649
public interface IBossToFollow
{
	// Token: 0x1700034D RID: 845
	// (get) Token: 0x06000D1D RID: 3357
	bool NeedProtection { get; }

	// Token: 0x1700034E RID: 846
	// (get) Token: 0x06000D1E RID: 3358
	PatrollingData PatrollingData { get; }

	// Token: 0x1700034F RID: 847
	// (get) Token: 0x06000D1F RID: 3359
	Vector3 PositionOrTargetCover { get; }

	// Token: 0x17000350 RID: 848
	// (get) Token: 0x06000D20 RID: 3360
	Vector3 PositionIfInCover { get; }

	// Token: 0x17000351 RID: 849
	// (get) Token: 0x06000D21 RID: 3361
	Vector3 Position { get; }

	// Token: 0x17000352 RID: 850
	// (get) Token: 0x06000D22 RID: 3362
	float MoveSpeed { get; }

	// Token: 0x17000353 RID: 851
	// (get) Token: 0x06000D23 RID: 3363
	bool IsAI { get; }

	// Token: 0x17000354 RID: 852
	// (get) Token: 0x06000D24 RID: 3364
	List<BotOwner> Followers { get; }

	// Token: 0x17000355 RID: 853
	// (get) Token: 0x06000D25 RID: 3365
	int FollowersTargetCount { get; }

	// Token: 0x06000D26 RID: 3366
	void RemoveFollower(BotOwner owner);

	// Token: 0x06000D27 RID: 3367
	bool IsMe(IPlayer player);

	// Token: 0x06000D28 RID: 3368
	IPlayer Player();

	// Token: 0x06000D29 RID: 3369
	EnemyInfo CurEnemy();

	// Token: 0x06000D2A RID: 3370
	BotOwner GetFirstFollower(bool withGrenade);

	// Token: 0x06000D2B RID: 3371
	PatrolPoint GetPatrolPosByIndex(int botFollowerIndex);

	// Token: 0x06000D2C RID: 3372
	ABossLogic GetBossLogic();
}
