using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000254 RID: 596
[Serializable]
public class NavGraphVoxel : NavGraphVoxelBase
{
	// Token: 0x06000B1B RID: 2843 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddPoint(NavGraphEditorPoint newPoint)
	{
		throw null;
	}

	// Token: 0x06000B1C RID: 2844 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NavGraphEditorPoint GetClosestPoint(Vector3 crn, out float sDist, int excuedPoint = -1)
	{
		throw null;
	}

	// Token: 0x06000B1D RID: 2845 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 GetSize()
	{
		throw null;
	}

	// Token: 0x06000B1E RID: 2846 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDrawGizmos(Color color, float sizeCoef = 1f)
	{
		throw null;
	}

	// Token: 0x06000B1F RID: 2847 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddNeightbourhood(NavGraphVoxel voxeles)
	{
		throw null;
	}

	// Token: 0x06000B20 RID: 2848 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x06000B21 RID: 2849 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemovePoint(NavGraphEditorPoint point)
	{
		throw null;
	}

	// Token: 0x04000BFF RID: 3071
	[NonSerialized]
	public List<NavGraphEditorPoint> Points;

	// Token: 0x04000C00 RID: 3072
	[NonSerialized]
	public List<NavGraphEditorPathValue> Pathes;

	// Token: 0x04000C01 RID: 3073
	[NonSerialized]
	public List<NavGraphVoxel> Neightbourhoods;

	// Token: 0x04000C02 RID: 3074
	public NavMeshDoorLink[] DoorLinks;

	// Token: 0x04000C03 RID: 3075
	public NavMeshDoorLink[] DoorLinksAffected;

	// Token: 0x04000C04 RID: 3076
	public List<int> PointsIds;

	// Token: 0x04000C05 RID: 3077
	public List<int> NeightbourhoodsIds;
}
