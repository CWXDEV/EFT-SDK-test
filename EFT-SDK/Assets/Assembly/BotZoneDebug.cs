using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000863 RID: 2147
public class BotZoneDebug : MonoBehaviour
{
	// Token: 0x17000862 RID: 2146
	// (get) Token: 0x060030C5 RID: 12485 RVA: 0x00002050 File Offset: 0x00000250
	public List<BotZoneDebugPointsGroup> Points
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000863 RID: 2147
	// (get) Token: 0x060030C6 RID: 12486 RVA: 0x00002050 File Offset: 0x00000250
	public List<BotZoneDebugLinesGroup> Lines
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060030C7 RID: 12487 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		throw null;
	}

	// Token: 0x060030C8 RID: 12488 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(string groupName, Vector3 point)
	{
		throw null;
	}

	// Token: 0x060030C9 RID: 12489 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(string groupName, string label, Vector3 point)
	{
		throw null;
	}

	// Token: 0x060030CA RID: 12490 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddLine(string groupName, Vector3 pointA, Vector3 pointB)
	{
		throw null;
	}

	// Token: 0x060030CB RID: 12491 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddLine(string groupName, string label, Vector3 pointA, Vector3 pointB)
	{
		throw null;
	}

	// Token: 0x060030CC RID: 12492 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmos()
	{
		throw null;
	}

	// Token: 0x060030CD RID: 12493 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawPoints(List<Vector3> points, Color color, float delta)
	{
		throw null;
	}

	// Token: 0x040031A1 RID: 12705
	[SerializeField]
	private List<BotZoneDebugPointsGroup> _points;

	// Token: 0x040031A2 RID: 12706
	[SerializeField]
	private List<BotZoneDebugLinesGroup> _lines;

	// Token: 0x02000864 RID: 2148
	[CompilerGenerated]
	private sealed class Class437
	{
		// Token: 0x060030CE RID: 12494 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(BotZoneDebugPointsGroup p)
		{
			throw null;
		}

		// Token: 0x040031A3 RID: 12707
		public string groupName;
	}

	// Token: 0x02000865 RID: 2149
	[CompilerGenerated]
	private sealed class Class438
	{
		// Token: 0x060030CF RID: 12495 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(BotZoneDebugLinesGroup p)
		{
			throw null;
		}

		// Token: 0x040031A4 RID: 12708
		public string groupName;
	}
}
