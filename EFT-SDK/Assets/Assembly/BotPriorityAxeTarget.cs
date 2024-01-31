using System;
using System.Runtime.CompilerServices;

// Token: 0x0200041E RID: 1054
public class BotPriorityAxeTarget : GClass362
{
	// Token: 0x170004AC RID: 1196
	// (get) Token: 0x06001996 RID: 6550 RVA: 0x00002050 File Offset: 0x00000250
	public bool HavePointToGo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170004AD RID: 1197
	// (get) Token: 0x06001997 RID: 6551 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001998 RID: 6552 RVA: 0x00002050 File Offset: 0x00000250
	public bool AllPursuit
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x06001999 RID: 6553 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FindTarget()
	{
		throw null;
	}

	// Token: 0x0600199A RID: 6554 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsPointInsideDangerZone()
	{
		throw null;
	}

	// Token: 0x0600199B RID: 6555 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x0600199C RID: 6556 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsInPossibleRadius()
	{
		throw null;
	}

	// Token: 0x0600199D RID: 6557 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x040015F0 RID: 5616
	private const float CHECK_PERIOD = 2f;

	// Token: 0x040015F1 RID: 5617
	private const float Y_DELTA = 1.5f;

	// Token: 0x040015F2 RID: 5618
	private float _nextCheckPeriod;

	// Token: 0x040015F3 RID: 5619
	private float _nextGo;

	// Token: 0x040015F4 RID: 5620
	private float _runDist;

	// Token: 0x040015F5 RID: 5621
	private float _runSDist;

	// Token: 0x040015F6 RID: 5622
	private CustomNavigationPoint _closestPoint;

	// Token: 0x040015F7 RID: 5623
	private EnemyInfo _closestPerson;

	// Token: 0x040015F8 RID: 5624
	private bool _allPursuit;

	// Token: 0x040015F9 RID: 5625
	private float _prevDistPursuit;

	// Token: 0x040015FA RID: 5626
	private float _possibleRadiusLostTime;

	// Token: 0x0200041F RID: 1055
	[CompilerGenerated]
	private sealed class Class215
	{
		// Token: 0x0600199E RID: 6558 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GroupPoint point)
		{
			throw null;
		}

		// Token: 0x040015FB RID: 5627
		public EnemyInfo closestPerson;
	}
}
