using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x02000258 RID: 600
[Serializable]
public class NavGraphVoxelSimple : NavGraphVoxelBase
{
	// Token: 0x17000303 RID: 771
	// (get) Token: 0x06000B35 RID: 2869 RVA: 0x00002050 File Offset: 0x00000250
	public bool HaveStartPointId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000304 RID: 772
	// (get) Token: 0x06000B36 RID: 2870 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000B37 RID: 2871 RVA: 0x00002050 File Offset: 0x00000250
	public GroupPoint PointStartSearch
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

	// Token: 0x06000B38 RID: 2872 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddCover(GroupPoint cover)
	{
		throw null;
	}

	// Token: 0x06000B39 RID: 2873 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddNeightbourhood(NavGraphVoxelSimple voxel)
	{
		throw null;
	}

	// Token: 0x06000B3A RID: 2874 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetClosestsPoint(GroupPoint closetsPoint)
	{
		throw null;
	}

	// Token: 0x06000B3B RID: 2875 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 GetSize()
	{
		throw null;
	}

	// Token: 0x06000B3C RID: 2876 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GroupPoint FindClosest(int botId, Vector3 pos, bool noRestrictions)
	{
		throw null;
	}

	// Token: 0x06000B3D RID: 2877 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GroupPoint FindClosestPoint(int botId, Vector3 pos, bool noRestrictions = false, Func<GroupPoint, bool> isGood = null)
	{
		throw null;
	}

	// Token: 0x06000B3E RID: 2878 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GroupPoint GetClosestPoint(Vector3 crn, out float sDist)
	{
		throw null;
	}

	// Token: 0x06000B3F RID: 2879 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GroupPoint GetClosestPoint(Vector3 crn, out float sDist, int excludedPoint)
	{
		throw null;
	}

	// Token: 0x06000B40 RID: 2880 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddDoor(NavMeshDoorLink link)
	{
		throw null;
	}

	// Token: 0x06000B41 RID: 2881 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawGizmos(bool drawClosestPoint, bool drawDoorsLinks, float sizeCoef = 1f)
	{
		throw null;
	}

	// Token: 0x06000B42 RID: 2882 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Restore(Dictionary<int, GroupPoint> data)
	{
		throw null;
	}

	// Token: 0x06000B43 RID: 2883 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearEntrances()
	{
		throw null;
	}

	// Token: 0x06000B44 RID: 2884 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearDoors()
	{
		throw null;
	}

	// Token: 0x06000B45 RID: 2885 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemovePoint(GroupPoint point)
	{
		throw null;
	}

	// Token: 0x04000C16 RID: 3094
	[SerializeField]
	private int _closetsPointId;

	// Token: 0x04000C17 RID: 3095
	[NonSerialized]
	public List<GroupPoint> Points;

	// Token: 0x04000C18 RID: 3096
	[NonSerialized]
	public List<NavMeshDoorLink> DoorLinks;

	// Token: 0x04000C19 RID: 3097
	public bool HaveNavMesh;

	// Token: 0x04000C1A RID: 3098
	public List<int> PointsIds;

	// Token: 0x04000C1B RID: 3099
	public List<int> EntrancesIds;

	// Token: 0x04000C1C RID: 3100
	public List<int> DoorLinksIds;

	// Token: 0x04000C1D RID: 3101
	[CompilerGenerated]
	[NonSerialized]
	private GroupPoint groupPoint_0;
}
