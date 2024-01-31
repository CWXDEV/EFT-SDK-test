using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000870 RID: 2160
public class TrajectoryDebug : MonoBehaviour
{
	// Token: 0x1700086F RID: 2159
	// (get) Token: 0x060030F6 RID: 12534 RVA: 0x00002050 File Offset: 0x00000250
	public List<TrajectoryDebugPointsGroup> Points
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060030F7 RID: 12535 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		throw null;
	}

	// Token: 0x060030F8 RID: 12536 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(string groupName, Vector3 point, float time)
	{
		throw null;
	}

	// Token: 0x060030F9 RID: 12537 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(string groupName, string label, Vector3 point, float time)
	{
		throw null;
	}

	// Token: 0x060030FA RID: 12538 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmos()
	{
		throw null;
	}

	// Token: 0x040031CC RID: 12748
	[SerializeField]
	private List<TrajectoryDebugPointsGroup> _points;

	// Token: 0x02000871 RID: 2161
	[CompilerGenerated]
	private sealed class Class441
	{
		// Token: 0x060030FB RID: 12539 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(TrajectoryDebugPointsGroup p)
		{
			throw null;
		}

		// Token: 0x040031CD RID: 12749
		public string groupName;
	}
}
