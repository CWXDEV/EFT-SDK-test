using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200022B RID: 555
public class AITriangleData : MonoBehaviour
{
	// Token: 0x170002DA RID: 730
	// (get) Token: 0x06000A38 RID: 2616 RVA: 0x00002050 File Offset: 0x00000250
	public int LastUsedId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000A39 RID: 2617 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetId()
	{
		throw null;
	}

	// Token: 0x06000A3A RID: 2618 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static AITriangleData CreateOrFind(bool withClear)
	{
		throw null;
	}

	// Token: 0x06000A3B RID: 2619 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDrawGizmosSelected()
	{
		throw null;
	}

	// Token: 0x06000A3C RID: 2620 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		throw null;
	}

	// Token: 0x06000A3D RID: 2621 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDictionaries(Dictionary<int, NavPoint> dcPoints, Dictionary<int, NavEdge> dcEdge, Dictionary<int, NavTriangle> dcTriangles)
	{
		throw null;
	}

	// Token: 0x06000A3E RID: 2622 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeleteTriangle(NavTriangle triagToDel)
	{
		throw null;
	}

	// Token: 0x06000A3F RID: 2623 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddTriag(NavTriangle trianlge)
	{
		throw null;
	}

	// Token: 0x06000A40 RID: 2624 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NavPoint GetPointNew(Vector3 pos)
	{
		throw null;
	}

	// Token: 0x06000A41 RID: 2625 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NavPoint GetPoint(int id)
	{
		throw null;
	}

	// Token: 0x06000A42 RID: 2626 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NavEdge GetEdge(int index)
	{
		throw null;
	}

	// Token: 0x06000A43 RID: 2627 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool AddCut(GClass326 point, NavEdge edge)
	{
		throw null;
	}

	// Token: 0x06000A44 RID: 2628 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveEdge(NavEdge navEgde)
	{
		throw null;
	}

	// Token: 0x06000A45 RID: 2629 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddEdgeExternal(NavEdge nEdge)
	{
		throw null;
	}

	// Token: 0x06000A46 RID: 2630 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string EdgeDebug()
	{
		throw null;
	}

	// Token: 0x06000A47 RID: 2631 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int CalcZeroDistEdges()
	{
		throw null;
	}

	// Token: 0x06000A48 RID: 2632 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TryAddPoint(NavPoint p)
	{
		throw null;
	}

	// Token: 0x04000B31 RID: 2865
	public List<NavPoint> Points;

	// Token: 0x04000B32 RID: 2866
	public List<NavTriangle> Triangles;

	// Token: 0x04000B33 RID: 2867
	public List<NavEdge> Edge;

	// Token: 0x04000B34 RID: 2868
	public TriangleCounters Counters;

	// Token: 0x04000B35 RID: 2869
	[NonSerialized]
	public bool Restored;

	// Token: 0x04000B36 RID: 2870
	[NonSerialized]
	public Dictionary<NavEdge, List<NavPoint>> ToCut;

	// Token: 0x04000B37 RID: 2871
	public bool HaveExternalEdges;

	// Token: 0x04000B38 RID: 2872
	public bool DrawPoints;

	// Token: 0x04000B39 RID: 2873
	public bool DrawPointsWithEdges;

	// Token: 0x04000B3A RID: 2874
	public bool DrawEdges;

	// Token: 0x04000B3B RID: 2875
	public bool DrawTriags;

	// Token: 0x04000B3C RID: 2876
	public bool DrawCounters;

	// Token: 0x04000B3D RID: 2877
	public bool DrawWithIndex;

	// Token: 0x04000B3E RID: 2878
	public int DistDraw;

	// Token: 0x04000B3F RID: 2879
	public int CountExternalEdges;

	// Token: 0x04000B40 RID: 2880
	[SerializeField]
	private int _idIndex;

	// Token: 0x04000B41 RID: 2881
	public int wrongAddsToCutList;

	// Token: 0x04000B42 RID: 2882
	public int goodAddsToCutList;

	// Token: 0x04000B43 RID: 2883
	private Dictionary<int, NavPoint> dictionary_0;

	// Token: 0x04000B44 RID: 2884
	private Dictionary<int, NavTriangle> dictionary_1;

	// Token: 0x04000B45 RID: 2885
	private Dictionary<int, NavEdge> dictionary_2;

	// Token: 0x04000B46 RID: 2886
	private readonly Vector3 vector3_0;

	// Token: 0x04000B47 RID: 2887
	private readonly Vector3 vector3_1;

	// Token: 0x04000B48 RID: 2888
	private readonly Vector3 vector3_2;

	// Token: 0x04000B49 RID: 2889
	private readonly Vector3 vector3_3;

	// Token: 0x04000B4A RID: 2890
	public float SizeToCutOff;
}
