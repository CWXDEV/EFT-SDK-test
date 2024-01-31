using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x020004BA RID: 1210
public abstract class BotRequest
{
	// Token: 0x17000556 RID: 1366
	// (get) Token: 0x06001D8D RID: 7565 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001D8E RID: 7566 RVA: 0x00002050 File Offset: 0x00000250
	public bool CanExecuteByMyself
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

	// Token: 0x17000557 RID: 1367
	// (get) Token: 0x06001D8F RID: 7567 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001D90 RID: 7568 RVA: 0x00002050 File Offset: 0x00000250
	public bool Taken
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

	// Token: 0x17000558 RID: 1368
	// (get) Token: 0x06001D91 RID: 7569
	public abstract EBotRequestMode RequestMode { get; }

	// Token: 0x17000559 RID: 1369
	// (get) Token: 0x06001D92 RID: 7570 RVA: 0x00002050 File Offset: 0x00000250
	protected virtual float requestLifetime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700055A RID: 1370
	// (get) Token: 0x06001D93 RID: 7571 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001D94 RID: 7572 RVA: 0x00002050 File Offset: 0x00000250
	public bool Removed
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x06001D95 RID: 7573 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanStartExecute(BotOwner executor)
	{
		throw null;
	}

	// Token: 0x06001D96 RID: 7574
	public abstract bool CanRequest(BotOwner requester);

	// Token: 0x06001D97 RID: 7575
	public abstract bool CanProceed();

	// Token: 0x06001D98 RID: 7576 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerDestroy(Player player)
	{
		throw null;
	}

	// Token: 0x06001D99 RID: 7577 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Take(BotOwner executor)
	{
		throw null;
	}

	// Token: 0x06001D9A RID: 7578 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEndTimeOnTake(float period)
	{
		throw null;
	}

	// Token: 0x06001D9B RID: 7579 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Activate()
	{
		throw null;
	}

	// Token: 0x06001D9C RID: 7580 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanRequest(Player player)
	{
		throw null;
	}

	// Token: 0x06001D9D RID: 7581 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckIsEndBeforeTake()
	{
		throw null;
	}

	// Token: 0x06001D9E RID: 7582 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Complete()
	{
		throw null;
	}

	// Token: 0x06001D9F RID: 7583 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddPossibleExecutors(BotOwner owner)
	{
		throw null;
	}

	// Token: 0x06001DA0 RID: 7584 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UseOnlySelf()
	{
		throw null;
	}

	// Token: 0x06001DA1 RID: 7585 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SetGroup(BotGroupRequestController groupRequestController)
	{
		throw null;
	}

	// Token: 0x06001DA2 RID: 7586 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckSelfEnd()
	{
		throw null;
	}

	// Token: 0x06001DA3 RID: 7587 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ExecutorInfo()
	{
		throw null;
	}

	// Token: 0x06001DA4 RID: 7588 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Dispose()
	{
		throw null;
	}

	// Token: 0x06001DA5 RID: 7589 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool FindPoint(CoverSearchData data, Func<CoverSearchData, CustomNavigationPoint> func, bool checkCurrent, out CustomNavigationPoint customNavigationPoint)
	{
		throw null;
	}

	// Token: 0x06001DA6 RID: 7590 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual AICoreActionEndStruct EndHoldPosition()
	{
		throw null;
	}

	// Token: 0x040018FD RID: 6397
	protected AICoreActionEndStruct FinishNodeLogic;

	// Token: 0x040018FE RID: 6398
	protected AICoreActionEndStruct ContinueNodeLogic;

	// Token: 0x040018FF RID: 6399
	public const float BASE_REQUEST_LIFETIME_SEC = 120f;

	// Token: 0x04001900 RID: 6400
	public IPlayer Requester;

	// Token: 0x04001901 RID: 6401
	public BotRequestType BotRequestType;

	// Token: 0x04001902 RID: 6402
	public float EndTimeBeforeTaken;

	// Token: 0x04001903 RID: 6403
	public float EndTimeByExecutor;

	// Token: 0x04001904 RID: 6404
	public bool ShallEndByExecutor;

	// Token: 0x04001905 RID: 6405
	public bool EndIfCantExecute;

	// Token: 0x04001906 RID: 6406
	public bool DisposeOtherRequestsWhenTaken;

	// Token: 0x04001907 RID: 6407
	protected BotOwner Executor;

	// Token: 0x04001908 RID: 6408
	private BotGroupRequestController _groupRequestController;

	// Token: 0x04001909 RID: 6409
	private List<BotOwner> _possibleExecutors;

	// Token: 0x0400190C RID: 6412
	protected float _takenTime;
}
