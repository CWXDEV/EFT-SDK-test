using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x020003CA RID: 970
public class BotSearchData : GClass362
{
	// Token: 0x06001742 RID: 5954 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static BotSearchData Create(BotOwner bot)
	{
		throw null;
	}

	// Token: 0x17000431 RID: 1073
	// (get) Token: 0x06001743 RID: 5955 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001744 RID: 5956 RVA: 0x00002050 File Offset: 0x00000250
	public BotSearchPoint SearchPoint
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

	// Token: 0x06001745 RID: 5957 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Activate()
	{
		throw null;
	}

	// Token: 0x06001746 RID: 5958 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RefreshSearchPoint()
	{
		throw null;
	}

	// Token: 0x06001747 RID: 5959 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void UpdateByNode()
	{
		throw null;
	}

	// Token: 0x06001748 RID: 5960 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void GoStraightCoverPoint(Vector3 goTo)
	{
		throw null;
	}

	// Token: 0x06001749 RID: 5961 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(BotSearchPoint nextSearchPoint)
	{
		throw null;
	}

	// Token: 0x0600174A RID: 5962 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private BotSearchPoint method_1()
	{
		throw null;
	}

	// Token: 0x0600174B RID: 5963 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private BotSearchPoint method_2()
	{
		throw null;
	}

	// Token: 0x0600174C RID: 5964 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private BotSearchPoint method_3()
	{
		throw null;
	}

	// Token: 0x0600174D RID: 5965 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x0600174E RID: 5966 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5()
	{
		throw null;
	}

	// Token: 0x0600174F RID: 5967 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0400145B RID: 5211
	protected bool _going;

	// Token: 0x0400145C RID: 5212
	private float _updatePointTimer;

	// Token: 0x0400145D RID: 5213
	private bool isReachableLast;

	// Token: 0x0400145E RID: 5214
	private CustomNavigationPoint closePoint;

	// Token: 0x0400145F RID: 5215
	private float _nextPosibleCheckTime;

	// Token: 0x04001460 RID: 5216
	private float _nextPosibleGoRefresh;

	// Token: 0x04001461 RID: 5217
	private float _lastCheckEnemyPos;

	// Token: 0x04001463 RID: 5219
	private BotSearchPoint _lastSearchPoint;
}
