using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000234 RID: 564
public class BotVoxelesPersonalData : GClass362
{
	// Token: 0x170002DB RID: 731
	// (get) Token: 0x06000A60 RID: 2656 RVA: 0x00002050 File Offset: 0x00000250
	public int MaxX
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170002DC RID: 732
	// (get) Token: 0x06000A61 RID: 2657 RVA: 0x00002050 File Offset: 0x00000250
	public int MaxY
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170002DD RID: 733
	// (get) Token: 0x06000A62 RID: 2658 RVA: 0x00002050 File Offset: 0x00000250
	public int MaxZ
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170002DE RID: 734
	// (get) Token: 0x06000A63 RID: 2659 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 _min
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170002DF RID: 735
	// (get) Token: 0x06000A64 RID: 2660 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000A65 RID: 2661 RVA: 0x00002050 File Offset: 0x00000250
	public NavGraphVoxelSimple CurVoxel
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

	// Token: 0x06000A66 RID: 2662 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<CustomNavigationPoint> Points(Func<CustomNavigationPoint, bool> func)
	{
		throw null;
	}

	// Token: 0x06000A67 RID: 2663 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate(AICoversData data)
	{
		throw null;
	}

	// Token: 0x06000A68 RID: 2664 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetLastConnectionId()
	{
		throw null;
	}

	// Token: 0x06000A69 RID: 2665 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NavGraphVoxelSimple GetVoxelSafe(Vector3 pos, bool withLogs = false)
	{
		throw null;
	}

	// Token: 0x06000A6A RID: 2666 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<NavGraphVoxelSimple> GetVoxelesExtended(Vector3 pos, int rad)
	{
		throw null;
	}

	// Token: 0x06000A6B RID: 2667 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCurrectVoxel(NavGraphVoxelSimple prevVoxel)
	{
		throw null;
	}

	// Token: 0x06000A6C RID: 2668 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NavGraphVoxelSimple GetVoxelSafeByIndex(int x, int y, int z)
	{
		throw null;
	}

	// Token: 0x04000B68 RID: 2920
	private readonly List<CustomNavigationPoint> _allPoints;

	// Token: 0x04000B69 RID: 2921
	private AICoversData _data;
}
