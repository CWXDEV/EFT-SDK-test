using System;
using System.Runtime.CompilerServices;

// Token: 0x0200029A RID: 666
public class BotAssaultDangerArea : GClass362
{
	// Token: 0x17000366 RID: 870
	// (get) Token: 0x06000D89 RID: 3465 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000D8A RID: 3466 RVA: 0x00002050 File Offset: 0x00000250
	public MiniAssaultBotsGroup AssaultGroup
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

	// Token: 0x17000367 RID: 871
	// (get) Token: 0x06000D8B RID: 3467 RVA: 0x00002050 File Offset: 0x00000250
	public bool HaveTarget
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000368 RID: 872
	// (get) Token: 0x06000D8C RID: 3468 RVA: 0x00002050 File Offset: 0x00000250
	public EBotAssaultAreaStatus ShallAssault
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000D8D RID: 3469 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AreaCompleted()
	{
		throw null;
	}

	// Token: 0x06000D8E RID: 3470 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FindCover()
	{
		throw null;
	}

	// Token: 0x06000D8F RID: 3471 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BotLogicDecision ManualUpdate()
	{
		throw null;
	}

	// Token: 0x06000D90 RID: 3472 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanDoAssault()
	{
		throw null;
	}

	// Token: 0x06000D91 RID: 3473 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ComeToCoverComplete()
	{
		throw null;
	}

	// Token: 0x06000D92 RID: 3474 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06000D93 RID: 3475 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetActivaArea(MiniAssaultBotsGroup botZoneDangerArea)
	{
		throw null;
	}

	// Token: 0x06000D94 RID: 3476 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ShallEndHoldPosition()
	{
		throw null;
	}

	// Token: 0x06000D95 RID: 3477 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CustomNavigationPoint GetCloseCover()
	{
		throw null;
	}

	// Token: 0x04000D5F RID: 3423
	private const float DIST_TO_COME_CLOSE = 20f;

	// Token: 0x04000D60 RID: 3424
	private CustomNavigationPoint _pointToBeClose;

	// Token: 0x04000D61 RID: 3425
	private float _lastEndHoldPos;

	// Token: 0x04000D62 RID: 3426
	private float _lastCHeckHoldPoint;
}
