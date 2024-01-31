using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000872 RID: 2162
[Serializable]
public class TrajectoryDebugPoints
{
	// Token: 0x17000870 RID: 2160
	// (get) Token: 0x060030FC RID: 12540 RVA: 0x00002050 File Offset: 0x00000250
	public string Label
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000871 RID: 2161
	// (get) Token: 0x060030FD RID: 12541 RVA: 0x00002050 File Offset: 0x00000250
	public float MinTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000872 RID: 2162
	// (get) Token: 0x060030FE RID: 12542 RVA: 0x00002050 File Offset: 0x00000250
	public float MaxTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060030FF RID: 12543 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		throw null;
	}

	// Token: 0x06003100 RID: 12544 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddPoint(Vector3 point, float time)
	{
		throw null;
	}

	// Token: 0x06003101 RID: 12545 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Draw(bool isDraw, Color color, Vector3 offset, float radius, float minTime, float maxTime)
	{
		throw null;
	}

	// Token: 0x040031CE RID: 12750
	[SerializeField]
	private string _label;

	// Token: 0x040031CF RID: 12751
	[SerializeField]
	private List<Vector3> Points;

	// Token: 0x040031D0 RID: 12752
	[SerializeField]
	private List<float> Times;

	// Token: 0x040031D1 RID: 12753
	public int Count;
}
