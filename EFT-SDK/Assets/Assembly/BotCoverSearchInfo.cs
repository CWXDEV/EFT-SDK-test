using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x020002A3 RID: 675
public class BotCoverSearchInfo : GClass362, GInterface1
{
	// Token: 0x1700036D RID: 877
	// (get) Token: 0x06000DC1 RID: 3521 RVA: 0x00002050 File Offset: 0x00000250
	public StandartBotBrain Brain
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700036E RID: 878
	// (get) Token: 0x06000DC2 RID: 3522 RVA: 0x00002050 File Offset: 0x00000250
	public CustomNavigationPoint LastCover
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700036F RID: 879
	// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x00002050 File Offset: 0x00000250
	public int ConnectionGroupId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000370 RID: 880
	// (get) Token: 0x06000DC4 RID: 3524 RVA: 0x00002050 File Offset: 0x00000250
	public WildSpawnType Type
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000371 RID: 881
	// (get) Token: 0x06000DC5 RID: 3525 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 Position
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000372 RID: 882
	// (get) Token: 0x06000DC6 RID: 3526 RVA: 0x00002050 File Offset: 0x00000250
	public DebugCoverFindGraphSearchData LastDebug
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000373 RID: 883
	// (get) Token: 0x06000DC7 RID: 3527 RVA: 0x00002050 File Offset: 0x00000250
	public IBossToFollow BossToFollow
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000374 RID: 884
	// (get) Token: 0x06000DC8 RID: 3528 RVA: 0x00002050 File Offset: 0x00000250
	public ICoversData Covers
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000375 RID: 885
	// (get) Token: 0x06000DC9 RID: 3529 RVA: 0x00002050 File Offset: 0x00000250
	public int Id
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000376 RID: 886
	// (get) Token: 0x06000DCA RID: 3530 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsDamaged
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000377 RID: 887
	// (get) Token: 0x06000DCB RID: 3531 RVA: 0x00002050 File Offset: 0x00000250
	public BotGrenadeController BotGrenadeController
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000378 RID: 888
	// (get) Token: 0x06000DCC RID: 3532 RVA: 0x00002050 File Offset: 0x00000250
	public LayerMask LookSensorMask
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000379 RID: 889
	// (get) Token: 0x06000DCD RID: 3533 RVA: 0x00002050 File Offset: 0x00000250
	public CustomNavigationPoint CurCustomCoverPoint
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700037A RID: 890
	// (get) Token: 0x06000DCE RID: 3534 RVA: 0x00002050 File Offset: 0x00000250
	public BotSettingsComponents Settings
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700037B RID: 891
	// (get) Token: 0x06000DCF RID: 3535 RVA: 0x00002050 File Offset: 0x00000250
	public EnemyInfo GoalEnemy
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000DD0 RID: 3536 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public HashSet<Vector3> CarePositions()
	{
		throw null;
	}

	// Token: 0x06000DD1 RID: 3537 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<NavGraphVoxelSimple> GetVoxelesInRadius(int step)
	{
		throw null;
	}

	// Token: 0x06000DD2 RID: 3538 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float MaxShootDist()
	{
		throw null;
	}

	// Token: 0x06000DD3 RID: 3539 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NavGraphVoxelSimple GetVoxelSafe(Vector3 centerPos)
	{
		throw null;
	}

	// Token: 0x06000DD4 RID: 3540 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLastSearchDebug(DebugCoverFindGraphSearchData debug)
	{
		throw null;
	}

	// Token: 0x06000DD5 RID: 3541 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsCurrentPointGood(CoverSearchType dataSearchType, CoverSearchData data, out CustomNavigationPoint point)
	{
		throw null;
	}

	// Token: 0x06000DD6 RID: 3542 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<NavGraphVoxelSimple> GetVoxelesExtended(Vector3 pos, int r)
	{
		throw null;
	}

	// Token: 0x06000DD7 RID: 3543 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GroupPoint GetClosest(Vector3 pos, int botCGid)
	{
		throw null;
	}

	// Token: 0x06000DD8 RID: 3544 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TryDrawGizmosLastSearchDebugByFull()
	{
		throw null;
	}

	// Token: 0x06000DD9 RID: 3545 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TryDrawGizmosLastSearchDebugClosest()
	{
		throw null;
	}

	// Token: 0x06000DDA RID: 3546 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLastSearchClosestsDebug(GClass300<GClass311> list, Vector3 startPos)
	{
		throw null;
	}

	// Token: 0x04000D7E RID: 3454
	private DebugCoverFindGraphSearchData _lastDebug;

	// Token: 0x04000D7F RID: 3455
	private GClass315 _lastDebugClosests;

	// Token: 0x04000D80 RID: 3456
	public int DebugLastCoverDrawSteps;

	// Token: 0x04000D81 RID: 3457
	public int DebugLastCoverDrawClosests;
}
