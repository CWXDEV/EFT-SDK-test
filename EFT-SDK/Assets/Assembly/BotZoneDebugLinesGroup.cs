using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000867 RID: 2151
[Serializable]
public class BotZoneDebugLinesGroup
{
	// Token: 0x17000865 RID: 2149
	// (get) Token: 0x060030D4 RID: 12500 RVA: 0x00002050 File Offset: 0x00000250
	public string Label
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000866 RID: 2150
	// (get) Token: 0x060030D5 RID: 12501 RVA: 0x00002050 File Offset: 0x00000250
	public List<BotZoneDebugLines> Lines
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000867 RID: 2151
	// (get) Token: 0x060030D6 RID: 12502 RVA: 0x00002050 File Offset: 0x00000250
	public BotZoneDebugLines List
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060030D7 RID: 12503 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string[] GetElementsList()
	{
		throw null;
	}

	// Token: 0x060030D8 RID: 12504 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Color method_0()
	{
		throw null;
	}

	// Token: 0x060030D9 RID: 12505 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset()
	{
		throw null;
	}

	// Token: 0x060030DA RID: 12506 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddLine(string label, Vector3 pointA, Vector3 pointB)
	{
		throw null;
	}

	// Token: 0x060030DB RID: 12507 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Draw()
	{
		throw null;
	}

	// Token: 0x040031A9 RID: 12713
	[SerializeField]
	private string _label;

	// Token: 0x040031AA RID: 12714
	public bool IsDraw;

	// Token: 0x040031AB RID: 12715
	public Color Color;

	// Token: 0x040031AC RID: 12716
	public Vector3 Offset;

	// Token: 0x040031AD RID: 12717
	private List<Color> _colors;

	// Token: 0x040031AE RID: 12718
	private static int _colorIndex;

	// Token: 0x040031AF RID: 12719
	[SerializeField]
	private List<BotZoneDebugLines> _lines;

	// Token: 0x040031B0 RID: 12720
	public int ActiveLinesIndex;

	// Token: 0x02000868 RID: 2152
	[CompilerGenerated]
	private sealed class Class439
	{
		// Token: 0x060030DC RID: 12508 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(BotZoneDebugLines p)
		{
			throw null;
		}

		// Token: 0x040031B1 RID: 12721
		public string label;
	}
}
