using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200012E RID: 302
[Serializable]
public class NavTriangle
{
	// Token: 0x0600067E RID: 1662 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Restore(Dictionary<int, NavPoint> dc, Dictionary<int, NavEdge> dcEdge)
	{
		throw null;
	}

	// Token: 0x0600067F RID: 1663 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddPoint(NavPoint navPoint)
	{
		throw null;
	}

	// Token: 0x06000680 RID: 1664 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddEdge(NavEdge edge)
	{
		throw null;
	}

	// Token: 0x06000681 RID: 1665 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DebugDraw(float up, Color color, float duration = 10f)
	{
		throw null;
	}

	// Token: 0x06000682 RID: 1666 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06000683 RID: 1667 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x04000732 RID: 1842
	[NonSerialized]
	public List<NavEdge> NavEgdes;

	// Token: 0x04000733 RID: 1843
	[NonSerialized]
	public List<NavPoint> Points;

	// Token: 0x04000734 RID: 1844
	public Vector3 Position;

	// Token: 0x04000735 RID: 1845
	public List<int> PosIndexes;

	// Token: 0x04000736 RID: 1846
	public int Id;

	// Token: 0x04000737 RID: 1847
	public List<int> EdgesIds;

	// Token: 0x04000738 RID: 1848
	public float Size;
}
