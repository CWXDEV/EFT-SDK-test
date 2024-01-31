using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020002E0 RID: 736
public class BotStandBy : GClass362
{
	// Token: 0x170003C2 RID: 962
	// (get) Token: 0x06000F8E RID: 3982 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000F8F RID: 3983 RVA: 0x00002050 File Offset: 0x00000250
	public BotStandByType StandByType
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

	// Token: 0x170003C3 RID: 963
	// (get) Token: 0x06000F90 RID: 3984 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000F91 RID: 3985 RVA: 0x00002050 File Offset: 0x00000250
	public bool CanDoStandBy
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

	// Token: 0x06000F92 RID: 3986 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitPoints(float distToActivate, float distToSleep)
	{
		throw null;
	}

	// Token: 0x06000F93 RID: 3987 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
		throw null;
	}

	// Token: 0x06000F94 RID: 3988 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06000F95 RID: 3989 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateNode()
	{
		throw null;
	}

	// Token: 0x06000F96 RID: 3990 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetHit()
	{
		throw null;
	}

	// Token: 0x06000F97 RID: 3991 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DebugActivate(bool val)
	{
		throw null;
	}

	// Token: 0x06000F98 RID: 3992 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string DistancesInfo()
	{
		throw null;
	}

	// Token: 0x06000F99 RID: 3993 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06000F9A RID: 3994 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x04000ED9 RID: 3801
	private float DIST_TO_SLEEP;

	// Token: 0x04000EDA RID: 3802
	private float DIST_TO_ACTIVATE;

	// Token: 0x04000EDB RID: 3803
	private readonly float MIN_TIME_AFTER_HIT;

	// Token: 0x04000EDC RID: 3804
	private float _nextCheckTime;

	// Token: 0x04000EDD RID: 3805
	private float _nextTimePosibleGoTo;

	// Token: 0x04000EDE RID: 3806
	private BotStandByType standByType;

	// Token: 0x04000EDF RID: 3807
	private Vector3? _curPoint;
}
