using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x02000446 RID: 1094
public class PatrolDataFollower : GClass362
{
	// Token: 0x170004C4 RID: 1220
	// (get) Token: 0x06001A68 RID: 6760 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001A69 RID: 6761 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsInited
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

	// Token: 0x170004C5 RID: 1221
	// (get) Token: 0x06001A6A RID: 6762 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsMainWay
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170004C6 RID: 1222
	// (get) Token: 0x06001A6B RID: 6763 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001A6C RID: 6764 RVA: 0x00002050 File Offset: 0x00000250
	public bool HaveProblems
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

	// Token: 0x06001A6D RID: 6765 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(PatrolFollowerType followerType, GClass435 simple)
	{
		throw null;
	}

	// Token: 0x06001A6E RID: 6766 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(PatrolFollowerType followerType, GClass432 bossPatrolMoveSimple)
	{
		throw null;
	}

	// Token: 0x06001A6F RID: 6767 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitPlayer(Player player)
	{
		throw null;
	}

	// Token: 0x06001A70 RID: 6768 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06001A71 RID: 6769 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SetTarget(GStruct20 trg, Vector3? lookSide)
	{
		throw null;
	}

	// Token: 0x06001A72 RID: 6770 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetProblemsSomebody(bool trg)
	{
		throw null;
	}

	// Token: 0x06001A73 RID: 6771 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopFor(float period)
	{
		throw null;
	}

	// Token: 0x06001A74 RID: 6772 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x06001A75 RID: 6773 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetIndex(int index)
	{
		throw null;
	}

	// Token: 0x06001A76 RID: 6774 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFolloweType(bool front)
	{
		throw null;
	}

	// Token: 0x06001A77 RID: 6775 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCloseToTarget(bool closeToPoint)
	{
		throw null;
	}

	// Token: 0x06001A78 RID: 6776 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDrawGizmosSelected()
	{
		throw null;
	}

	// Token: 0x06001A79 RID: 6777 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06001A7A RID: 6778 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0400169C RID: 5788
	private GClass480 followerAIBase;

	// Token: 0x0400169D RID: 5789
	private GClass427 followerPlayerBase;

	// Token: 0x0400169E RID: 5790
	private readonly int _index;

	// Token: 0x0400169F RID: 5791
	private Vector3? _safeTarget;

	// Token: 0x040016A0 RID: 5792
	private float _endStopTime;
}
