using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000120 RID: 288
[Serializable]
public class AIPointsCounter
{
	// Token: 0x06000642 RID: 1602 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(NavEdge edge)
	{
		throw null;
	}

	// Token: 0x06000643 RID: 1603 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<GClass309> CalculateSegments()
	{
		throw null;
	}

	// Token: 0x06000644 RID: 1604 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Dictionary<int, GClass309> method_0(List<GClass307> pairs)
	{
		throw null;
	}

	// Token: 0x06000645 RID: 1605 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int method_1(GClass307 x, GClass307 y)
	{
		throw null;
	}

	// Token: 0x06000646 RID: 1606 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DebugDrawCounter(float duration = 10f)
	{
		throw null;
	}

	// Token: 0x06000647 RID: 1607 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 GetCenterPoint()
	{
		throw null;
	}

	// Token: 0x06000648 RID: 1608 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NavPoint RandomPointFirst()
	{
		throw null;
	}

	// Token: 0x06000649 RID: 1609 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCorePoint(AICorePoint holderTestObject)
	{
		throw null;
	}

	// Token: 0x040006F9 RID: 1785
	public const float POSSIBLE_TOTAL_ANG = 35f;

	// Token: 0x040006FA RID: 1786
	private const float MIN_SEGMENT_LENGHT_TO_ADD = 2f;

	// Token: 0x040006FB RID: 1787
	[SerializeField]
	private List<NavEdge> _edges;

	// Token: 0x040006FC RID: 1788
	public bool IsAlwaysGood;

	// Token: 0x040006FD RID: 1789
	private AITriangleData _triangle;

	// Token: 0x040006FE RID: 1790
	public int CorePointId;
}
