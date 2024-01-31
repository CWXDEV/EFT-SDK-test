using System;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x0200028A RID: 650
public class BotFollower : GClass362
{
	// Token: 0x06000D2D RID: 3373 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static BotFollower Create(BotOwner bot)
	{
		throw null;
	}

	// Token: 0x1400001B RID: 27
	// (add) Token: 0x06000D2E RID: 3374 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06000D2F RID: 3375 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<IBossToFollow> OnBossFinded
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

	// Token: 0x1400001C RID: 28
	// (add) Token: 0x06000D30 RID: 3376 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06000D31 RID: 3377 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Player> OnBossDead
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

	// Token: 0x17000356 RID: 854
	// (get) Token: 0x06000D32 RID: 3378 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000D33 RID: 3379 RVA: 0x00002050 File Offset: 0x00000250
	public IBossToFollow BossToFollow
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x17000357 RID: 855
	// (get) Token: 0x06000D34 RID: 3380 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000D35 RID: 3381 RVA: 0x00002050 File Offset: 0x00000250
	public PatrolDataFollower PatrolDataFollower
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000358 RID: 856
	// (get) Token: 0x06000D36 RID: 3382 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000D37 RID: 3383 RVA: 0x00002050 File Offset: 0x00000250
	public BotFollowerFight BotFollowerFight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000359 RID: 857
	// (get) Token: 0x06000D38 RID: 3384 RVA: 0x00002050 File Offset: 0x00000250
	public bool HaveBoss
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700035A RID: 858
	// (get) Token: 0x06000D39 RID: 3385 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000D3A RID: 3386 RVA: 0x00002050 File Offset: 0x00000250
	public int Index
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected set
		{
			throw null;
		}
	}

	// Token: 0x1700035B RID: 859
	// (get) Token: 0x06000D3B RID: 3387 RVA: 0x00002050 File Offset: 0x00000250
	public virtual bool NeedToProtectBoss
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700035C RID: 860
	// (get) Token: 0x06000D3C RID: 3388 RVA: 0x00002050 File Offset: 0x00000250
	public int FollowersTargetCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000D3D RID: 3389 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(float period)
	{
		throw null;
	}

	// Token: 0x06000D3E RID: 3390 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Activate()
	{
		throw null;
	}

	// Token: 0x06000D3F RID: 3391 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TryFindBoss()
	{
		throw null;
	}

	// Token: 0x06000D40 RID: 3392 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetToFollow(IBossToFollow boss, int index, bool changeLogicMode = false)
	{
		throw null;
	}

	// Token: 0x06000D41 RID: 3393 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawGizmos()
	{
		throw null;
	}

	// Token: 0x06000D42 RID: 3394 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawGizmosSelected()
	{
		throw null;
	}

	// Token: 0x06000D43 RID: 3395 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update(BotOwner bot)
	{
		throw null;
	}

	// Token: 0x06000D44 RID: 3396 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void BossFindAction()
	{
		throw null;
	}

	// Token: 0x06000D45 RID: 3397 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(float? maxDist = null)
	{
		throw null;
	}

	// Token: 0x06000D46 RID: 3398 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(float? maxDist = null)
	{
		throw null;
	}

	// Token: 0x06000D47 RID: 3399 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(Player player, IPlayer lastAggressor, DamageInfo damageInfo, EBodyPart part)
	{
		throw null;
	}

	// Token: 0x06000D48 RID: 3400 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(GClass346 pairData)
	{
		throw null;
	}

	// Token: 0x06000D49 RID: 3401 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool Dispose()
	{
		throw null;
	}

	// Token: 0x04000D35 RID: 3381
	private PatrolDataFollower _patrolDataFollower;

	// Token: 0x04000D36 RID: 3382
	private BotFollowerFight _botFollowerFight;
}
