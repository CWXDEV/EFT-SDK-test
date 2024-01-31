using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x020002A5 RID: 677
public class BotCoversData : GClass362, ICoversData
{
	// Token: 0x1700037E RID: 894
	// (get) Token: 0x06000DE1 RID: 3553 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000DE2 RID: 3554 RVA: 0x00002050 File Offset: 0x00000250
	public CoverSearchData LastSearchData
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

	// Token: 0x06000DE3 RID: 3555 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual HashSet<Vector3> CarePositions()
	{
		throw null;
	}

	// Token: 0x06000DE4 RID: 3556 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		throw null;
	}

	// Token: 0x06000DE5 RID: 3557 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CustomNavigationPoint GetFreeClosePoint(Vector3 pos, float minSDistToEnemy, bool printErrorLogsIfFail = false)
	{
		throw null;
	}

	// Token: 0x06000DE6 RID: 3558 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<CustomNavigationPoint> GetClosePoints(Vector3 pos, float dist)
	{
		throw null;
	}

	// Token: 0x06000DE7 RID: 3559 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CustomNavigationPoint ClosestGreenPoint(Vector3 pos, out float sDist, float minDistToTarget = 0f, Vector3? trg = null, int? placeId = null, CoverPointMaster.GStruct10? friendCover = null, CoverLevel coverLvl = CoverLevel.Stay, bool printErrorLogsIfFail = false)
	{
		throw null;
	}

	// Token: 0x06000DE8 RID: 3560 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CustomNavigationPoint GetClosestPoint(Vector3 pos, Func<GroupPoint, bool> goodFunc = null, bool noRestrictions = true, bool printErrorLogsIfFail = false, int maxIterations = 1000)
	{
		throw null;
	}

	// Token: 0x06000DE9 RID: 3561 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CustomNavigationPoint FindHidePoint(Vector3 pos, float minLvl, CoverPointMaster.GStruct10? friednData = null, bool onlyWithInsideCover = false, int? placeId = null, bool printErrorLogsIfFail = false)
	{
		throw null;
	}

	// Token: 0x06000DEA RID: 3562 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CustomNavigationPoint FindClosestPoint(Vector3 pos, float minDistToTarget, Vector3 trg, bool noRestrictions = false, Func<GroupPoint, bool> isGood = null, bool printErrorLogsIfFail = false)
	{
		throw null;
	}

	// Token: 0x06000DEB RID: 3563 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<NavGraphVoxelSimple> GetVoxelesInRadius(int step)
	{
		throw null;
	}

	// Token: 0x06000DEC RID: 3564 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BotOwner GetClosestFriend(out float sqrDist)
	{
		throw null;
	}

	// Token: 0x06000DED RID: 3565 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float DistToClosestFriend()
	{
		throw null;
	}

	// Token: 0x06000DEE RID: 3566 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3? ClosestFriendCoverPoint()
	{
		throw null;
	}

	// Token: 0x06000DEF RID: 3567 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3? ClosestFriendCoverPoint(Vector3 closeToPoint)
	{
		throw null;
	}

	// Token: 0x06000DF0 RID: 3568 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetClose()
	{
		throw null;
	}

	// Token: 0x06000DF1 RID: 3569 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLong()
	{
		throw null;
	}

	// Token: 0x06000DF2 RID: 3570 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLastCoverSearchInfo(CoverSearchData data)
	{
		throw null;
	}

	// Token: 0x06000DF3 RID: 3571 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_0(GroupPoint point, CoverLevel minCoverLevel)
	{
		throw null;
	}

	// Token: 0x06000DF4 RID: 3572 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	CustomNavigationPoint ICoversData.FindClosestPoint(Vector3 pos, bool noRestrictions, Func<GroupPoint, bool> goodFunc)
	{
		throw null;
	}

	// Token: 0x06000DF5 RID: 3573 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	CustomNavigationPoint ICoversData.GetFreeClosePoint(Vector3 pos, float minSDistToEnemy)
	{
		throw null;
	}

	// Token: 0x1700037F RID: 895
	// (get) Token: 0x06000DF6 RID: 3574 RVA: 0x00002050 File Offset: 0x00000250
	public int ConnectionGroupId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000380 RID: 896
	// (get) Token: 0x06000DF7 RID: 3575 RVA: 0x00002050 File Offset: 0x00000250
	public CustomNavigationPoint LastCustomNavigationPoint
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000DF8 RID: 3576 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GroupPoint GetClosest(Vector3 center, int connectionGroupId)
	{
		throw null;
	}

	// Token: 0x06000DF9 RID: 3577 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GroupPoint GetClosestByClosestsVoxeles(Vector3 center)
	{
		throw null;
	}

	// Token: 0x06000DFA RID: 3578 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x06000DFB RID: 3579 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(NavGraphVoxelSimple voxel, ref BotCoversData.Struct8 struct8_0)
	{
		throw null;
	}

	// Token: 0x04000D82 RID: 3458
	public BotOwner LastClosestFriend;

	// Token: 0x04000D83 RID: 3459
	public float LastClosestFriendSDist;

	// Token: 0x04000D84 RID: 3460
	public GClass453 CoverFinderAnalyzer;

	// Token: 0x04000D85 RID: 3461
	private readonly GClass313 gclass313_0;

	// Token: 0x020002A6 RID: 678
	[CompilerGenerated]
	private sealed class Class158
	{
		// Token: 0x06000DFC RID: 3580 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GroupPoint p)
		{
			throw null;
		}

		// Token: 0x04000D87 RID: 3463
		public BotCoversData botCoversData_0;

		// Token: 0x04000D88 RID: 3464
		public float minSDistToEnemy;
	}

	// Token: 0x020002A7 RID: 679
	[CompilerGenerated]
	[StructLayout(LayoutKind.Auto)]
	public struct Struct8
	{
		// Token: 0x04000D89 RID: 3465
		public Vector3 pos;

		// Token: 0x04000D8A RID: 3466
		public float sDist;

		// Token: 0x04000D8B RID: 3467
		public List<CustomNavigationPoint> list;

		// Token: 0x04000D8C RID: 3468
		public BotCoversData botCoversData_0;
	}

	// Token: 0x020002A8 RID: 680
	[CompilerGenerated]
	private sealed class Class159
	{
		// Token: 0x06000DFD RID: 3581 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GroupPoint p)
		{
			throw null;
		}

		// Token: 0x04000D8D RID: 3469
		public BotCoversData botCoversData_0;

		// Token: 0x04000D8E RID: 3470
		public CoverLevel coverLvl;

		// Token: 0x04000D8F RID: 3471
		public bool checkPlaceID;

		// Token: 0x04000D90 RID: 3472
		public int? placeId;

		// Token: 0x04000D91 RID: 3473
		public CoverPointMaster.GStruct10? friendCover;

		// Token: 0x04000D92 RID: 3474
		public bool checksDistMinToTarget;

		// Token: 0x04000D93 RID: 3475
		public Vector3? trg;

		// Token: 0x04000D94 RID: 3476
		public float sDistMinToTarget;
	}

	// Token: 0x020002A9 RID: 681
	[CompilerGenerated]
	private sealed class Class160
	{
		// Token: 0x06000DFE RID: 3582 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GroupPoint point)
		{
			throw null;
		}

		// Token: 0x04000D95 RID: 3477
		public int? placeId;

		// Token: 0x04000D96 RID: 3478
		public bool onlyWithInsideCover;

		// Token: 0x04000D97 RID: 3479
		public float minLvl;

		// Token: 0x04000D98 RID: 3480
		public CoverPointMaster.GStruct10? friednData;

		// Token: 0x04000D99 RID: 3481
		public BotCoversData botCoversData_0;
	}

	// Token: 0x020002AA RID: 682
	[CompilerGenerated]
	private sealed class Class161
	{
		// Token: 0x06000DFF RID: 3583 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GroupPoint point)
		{
			throw null;
		}

		// Token: 0x04000D9A RID: 3482
		public BotCoversData botCoversData_0;

		// Token: 0x04000D9B RID: 3483
		public Vector3 trg;

		// Token: 0x04000D9C RID: 3484
		public float sMinDist;

		// Token: 0x04000D9D RID: 3485
		public Func<GroupPoint, bool> isGood;
	}
}
