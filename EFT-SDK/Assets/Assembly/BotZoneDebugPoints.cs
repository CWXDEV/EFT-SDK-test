using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000869 RID: 2153
[Serializable]
public class BotZoneDebugPoints
{
	// Token: 0x17000868 RID: 2152
	// (get) Token: 0x060030DD RID: 12509 RVA: 0x00002050 File Offset: 0x00000250
	public string Label
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060030DE RID: 12510 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		throw null;
	}

	// Token: 0x060030DF RID: 12511 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddPoint(Vector3 point)
	{
		throw null;
	}

	// Token: 0x060030E0 RID: 12512 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Draw(bool isDraw, Color color, Vector3 offset, float radius)
	{
		throw null;
	}

	// Token: 0x040031B2 RID: 12722
	[SerializeField]
	private string _label;

	// Token: 0x040031B3 RID: 12723
	[SerializeField]
	private List<Vector3> Points;

	// Token: 0x040031B4 RID: 12724
	public int Count;
}
