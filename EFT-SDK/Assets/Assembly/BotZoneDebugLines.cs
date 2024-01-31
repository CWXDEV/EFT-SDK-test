using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000866 RID: 2150
[Serializable]
public class BotZoneDebugLines
{
	// Token: 0x17000864 RID: 2148
	// (get) Token: 0x060030D0 RID: 12496 RVA: 0x00002050 File Offset: 0x00000250
	public string Label
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060030D1 RID: 12497 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		throw null;
	}

	// Token: 0x060030D2 RID: 12498 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddLine(Vector3 a, Vector3 b)
	{
		throw null;
	}

	// Token: 0x060030D3 RID: 12499 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Draw(bool isDraw, Color color, Vector3 offset)
	{
		throw null;
	}

	// Token: 0x040031A5 RID: 12709
	[SerializeField]
	private string _label;

	// Token: 0x040031A6 RID: 12710
	[SerializeField]
	private List<Vector3> lineA;

	// Token: 0x040031A7 RID: 12711
	[SerializeField]
	private List<Vector3> lineB;

	// Token: 0x040031A8 RID: 12712
	public int Count;
}
