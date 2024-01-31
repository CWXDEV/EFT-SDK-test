using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x02000140 RID: 320
[Serializable]
public class NavGraphFindDebugStepInfo
{
	// Token: 0x060006BC RID: 1724 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddUsedPath(int info)
	{
		throw null;
	}

	// Token: 0x060006BD RID: 1725 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(NavGraphFindDebugPointInfo info)
	{
		throw null;
	}

	// Token: 0x060006BE RID: 1726 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public StringBuilder GetInfo()
	{
		throw null;
	}

	// Token: 0x060006BF RID: 1727 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawGizmos(NavGraphContainer container, int coverSelectId)
	{
		throw null;
	}

	// Token: 0x04000784 RID: 1924
	public int _step;

	// Token: 0x04000785 RID: 1925
	public float Rad;

	// Token: 0x04000786 RID: 1926
	public List<NavGraphFindDebugPointInfo> DebugPointInfos;

	// Token: 0x04000787 RID: 1927
	public List<int> usedPathId;
}
