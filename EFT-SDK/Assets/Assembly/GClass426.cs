using System;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x0200041D RID: 1053
public class GClass426 : GClass362
{
	// Token: 0x1400002C RID: 44
	// (add) Token: 0x06001988 RID: 6536 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06001989 RID: 6537 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<PatrolPointContainer> OnTargetPatrolPointSetted
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

	// Token: 0x170004AB RID: 1195
	// (get) Token: 0x0600198A RID: 6538 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600198B RID: 6539 RVA: 0x00002050 File Offset: 0x00000250
	public PatrolPointContainer PatrolPoint
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

	// Token: 0x0600198C RID: 6540 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPointSetter(Action<PatrolPointContainer, int> pointSetted)
	{
		throw null;
	}

	// Token: 0x0600198D RID: 6541 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetWayChanged(Action wayChanged)
	{
		throw null;
	}

	// Token: 0x0600198E RID: 6542 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PatrolPointContainer GetPreferableNext()
	{
		throw null;
	}

	// Token: 0x0600198F RID: 6543 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetWay(PatrolWay way, GDelegate4 findPointAction, Action<BotOwner, PatrolWay> findPointForFollower = null)
	{
		throw null;
	}

	// Token: 0x06001990 RID: 6544 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTarget(PatrolPointContainer point, int index = -1)
	{
		throw null;
	}

	// Token: 0x06001991 RID: 6545 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetReservedPatrolPoint(PatrolPointContainer p, int index = -1)
	{
		throw null;
	}

	// Token: 0x06001992 RID: 6546 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(PatrolPointContainer p, int index = -1)
	{
		throw null;
	}

	// Token: 0x06001993 RID: 6547 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(PatrolPoint point)
	{
		throw null;
	}

	// Token: 0x06001994 RID: 6548 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x06001995 RID: 6549 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x040015E9 RID: 5609
	public PatrolWay Way;

	// Token: 0x040015EA RID: 5610
	public PatrolPointContainer _reservedPatrolPoint;

	// Token: 0x040015EB RID: 5611
	private Action action_0;

	// Token: 0x040015EC RID: 5612
	private Action<PatrolPointContainer, int> action_1;

	// Token: 0x040015ED RID: 5613
	private PatrolPoint patrolPoint_0;

	// Token: 0x040015EE RID: 5614
	[CompilerGenerated]
	private Action<PatrolPointContainer> action_2;

	// Token: 0x040015EF RID: 5615
	[CompilerGenerated]
	private PatrolPointContainer patrolPointContainer_0;
}
