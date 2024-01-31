using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ChartAndGraph;
using UnityEngine;

// Token: 0x020000CF RID: 207
public class GraphAnimation : MonoBehaviour
{
	// Token: 0x06000463 RID: 1123 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x06000464 RID: 1124 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_0(float val)
	{
		throw null;
	}

	// Token: 0x06000465 RID: 1125 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Animate(string category, List<Vector2> points, float totalTime)
	{
		throw null;
	}

	// Token: 0x06000466 RID: 1126 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x040004EA RID: 1258
	private GraphChartBase graphChartBase_0;

	// Token: 0x040004EB RID: 1259
	public float AnimationTime;

	// Token: 0x040004EC RID: 1260
	public bool ModifyRange;

	// Token: 0x040004ED RID: 1261
	private Dictionary<string, GraphAnimation.Class84> dictionary_0;

	// Token: 0x020000D0 RID: 208
	private class Class84
	{
		// Token: 0x06000467 RID: 1127 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update(GraphChartBase graphChart)
		{
			throw null;
		}

		// Token: 0x040004EE RID: 1262
		public float maxX;

		// Token: 0x040004EF RID: 1263
		public float minX;

		// Token: 0x040004F0 RID: 1264
		public float maxY;

		// Token: 0x040004F1 RID: 1265
		public float minY;

		// Token: 0x040004F2 RID: 1266
		public float totalTime;

		// Token: 0x040004F3 RID: 1267
		public float next;

		// Token: 0x040004F4 RID: 1268
		public string category;

		// Token: 0x040004F5 RID: 1269
		public List<Vector2> points;

		// Token: 0x040004F6 RID: 1270
		public int index;
	}
}
