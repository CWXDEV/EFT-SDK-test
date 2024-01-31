using System;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x02000424 RID: 1060
public class PatrolPointChooserBasic
{
	// Token: 0x170004AE RID: 1198
	// (get) Token: 0x060019B3 RID: 6579 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060019B4 RID: 6580 RVA: 0x00002050 File Offset: 0x00000250
	public bool WasCutted
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

	// Token: 0x170004AF RID: 1199
	// (get) Token: 0x060019B5 RID: 6581 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060019B6 RID: 6582 RVA: 0x00002050 File Offset: 0x00000250
	public float PathDistCoef
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

	// Token: 0x170004B0 RID: 1200
	// (get) Token: 0x060019B7 RID: 6583 RVA: 0x00002050 File Offset: 0x00000250
	protected GClass426 PointControl
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170004B1 RID: 1201
	// (get) Token: 0x060019B8 RID: 6584 RVA: 0x00002050 File Offset: 0x00000250
	protected GClass431 PathControl
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060019B9 RID: 6585 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ChooseStartWay()
	{
		throw null;
	}

	// Token: 0x060019BA RID: 6586 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PatrolPointContainer FindPointForFollower(BotOwner follower, PatrolWay way)
	{
		throw null;
	}

	// Token: 0x060019BB RID: 6587 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual PatrolPointContainer FindNextPoint(bool withSetting, bool withoutNext, int minSubTargets = -1, bool canCut = true, GDelegate3 pointFilter = null)
	{
		throw null;
	}

	// Token: 0x060019BC RID: 6588 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Disable()
	{
		throw null;
	}

	// Token: 0x060019BD RID: 6589 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ShallChangeWay(bool force = false)
	{
		throw null;
	}

	// Token: 0x060019BE RID: 6590 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void NextPointDecision(Action callback)
	{
		throw null;
	}

	// Token: 0x060019BF RID: 6591 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool IsWaySuitableByNameId(string nameId)
	{
		throw null;
	}

	// Token: 0x060019C0 RID: 6592 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void LogPatrolData()
	{
		throw null;
	}

	// Token: 0x060019C1 RID: 6593 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual bool TryToFindWay(out PatrolWay way, out float delta)
	{
		throw null;
	}

	// Token: 0x060019C2 RID: 6594 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected PatrolPointContainer GetTargetNext()
	{
		throw null;
	}

	// Token: 0x060019C3 RID: 6595 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Dispose()
	{
		throw null;
	}

	// Token: 0x060019C4 RID: 6596 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_0(PatrolWay x)
	{
		throw null;
	}

	// Token: 0x060019C5 RID: 6597 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_1(PatrolWay x)
	{
		throw null;
	}

	// Token: 0x060019C6 RID: 6598 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_2(PatrolWay x)
	{
		throw null;
	}

	// Token: 0x04001601 RID: 5633
	protected const float NEXT_POINT_DIST_SQRT = 4f;

	// Token: 0x04001602 RID: 5634
	protected BotOwner _owner;

	// Token: 0x04001603 RID: 5635
	protected float _nextChangeWay;

	// Token: 0x04001604 RID: 5636
	protected bool _canChangeWays;

	// Token: 0x04001605 RID: 5637
	protected bool _errorPrinted;

	// Token: 0x02000425 RID: 1061
	[CompilerGenerated]
	[Serializable]
	private sealed class Class216
	{
		// Token: 0x060019C7 RID: 6599 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(PatrolWay x)
		{
			throw null;
		}

		// Token: 0x060019C8 RID: 6600 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(PatrolWay x)
		{
			throw null;
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_2(PatrolPoint x)
		{
			throw null;
		}

		// Token: 0x04001608 RID: 5640
		public static readonly PatrolPointChooserBasic.Class216 class216_0;

		// Token: 0x04001609 RID: 5641
		public static Func<PatrolWay, bool> func_0;

		// Token: 0x0400160A RID: 5642
		public static Func<PatrolWay, bool> func_1;

		// Token: 0x0400160B RID: 5643
		public static Func<PatrolPoint, bool> func_2;
	}

	// Token: 0x02000426 RID: 1062
	[CompilerGenerated]
	private sealed class Class217
	{
		// Token: 0x060019CA RID: 6602 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(PatrolPoint x)
		{
			throw null;
		}

		// Token: 0x0400160C RID: 5644
		public BotOwner follower;
	}

	// Token: 0x02000427 RID: 1063
	[CompilerGenerated]
	private sealed class Class218
	{
		// Token: 0x060019CB RID: 6603 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(PatrolPoint point)
		{
			throw null;
		}

		// Token: 0x0400160D RID: 5645
		public PatrolPointChooserBasic patrolPointChooserBasic_0;

		// Token: 0x0400160E RID: 5646
		public int minSubTargets;

		// Token: 0x0400160F RID: 5647
		public GDelegate3 pointFilter;
	}
}
