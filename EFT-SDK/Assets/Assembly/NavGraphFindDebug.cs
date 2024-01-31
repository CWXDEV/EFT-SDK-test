using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200014D RID: 333
[Serializable]
public class NavGraphFindDebug
{
	// Token: 0x0600070D RID: 1805 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Step(float rad, int step)
	{
		throw null;
	}

	// Token: 0x0600070E RID: 1806 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddInfo(int id, ENavGraphFindRemoveCause cause)
	{
		throw null;
	}

	// Token: 0x0600070F RID: 1807 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PrintLogs()
	{
		throw null;
	}

	// Token: 0x06000710 RID: 1808 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawGizmos(int stepConstrain, float radiusConstrain, NavGraphContainer container, int coverSelectId)
	{
		throw null;
	}

	// Token: 0x06000711 RID: 1809 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BadSearch(string whileEnd)
	{
		throw null;
	}

	// Token: 0x06000712 RID: 1810 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddResult(NavGraphEditorPoint[] way)
	{
		throw null;
	}

	// Token: 0x06000713 RID: 1811 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryRefreshIdsToPoints(out NavGraphContainer container)
	{
		throw null;
	}

	// Token: 0x06000714 RID: 1812 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddPath(int nextWayPathId)
	{
		throw null;
	}

	// Token: 0x040007D5 RID: 2005
	public Vector3 CenterPosition;

	// Token: 0x040007D6 RID: 2006
	public int StartPoint;

	// Token: 0x040007D7 RID: 2007
	public CoverShootType ShootType;

	// Token: 0x040007D8 RID: 2008
	public int BotId;

	// Token: 0x040007D9 RID: 2009
	public List<NavGraphFindDebugStepInfo> StepsInfo;

	// Token: 0x040007DA RID: 2010
	public string EndInfo;

	// Token: 0x040007DB RID: 2011
	public string ZoneName;

	// Token: 0x040007DC RID: 2012
	public NavGraphEditorPoint[] ResultWay;

	// Token: 0x040007DD RID: 2013
	public int[] ResultWayIds;

	// Token: 0x040007DE RID: 2014
	private int _step;

	// Token: 0x040007DF RID: 2015
	private readonly HashSet<int> _collectedSteps;

	// Token: 0x040007E0 RID: 2016
	private NavGraphFindDebugStepInfo _cur;
}
