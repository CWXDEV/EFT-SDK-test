using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200086A RID: 2154
[Serializable]
public class BotZoneDebugPointsGroup
{
	// Token: 0x17000869 RID: 2153
	// (get) Token: 0x060030E1 RID: 12513 RVA: 0x00002050 File Offset: 0x00000250
	public string Label
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700086A RID: 2154
	// (get) Token: 0x060030E2 RID: 12514 RVA: 0x00002050 File Offset: 0x00000250
	public List<BotZoneDebugPoints> Points
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700086B RID: 2155
	// (get) Token: 0x060030E3 RID: 12515 RVA: 0x00002050 File Offset: 0x00000250
	public BotZoneDebugPoints List
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060030E4 RID: 12516 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string[] GetElementsList()
	{
		throw null;
	}

	// Token: 0x060030E5 RID: 12517 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected Color NextColor()
	{
		throw null;
	}

	// Token: 0x060030E6 RID: 12518 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset()
	{
		throw null;
	}

	// Token: 0x060030E7 RID: 12519 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(string label, Vector3 point)
	{
		throw null;
	}

	// Token: 0x060030E8 RID: 12520 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Draw()
	{
		throw null;
	}

	// Token: 0x040031B5 RID: 12725
	[SerializeField]
	protected string _label;

	// Token: 0x040031B6 RID: 12726
	public bool IsDraw;

	// Token: 0x040031B7 RID: 12727
	public Color Color;

	// Token: 0x040031B8 RID: 12728
	public Vector3 Offset;

	// Token: 0x040031B9 RID: 12729
	public float Radius;

	// Token: 0x040031BA RID: 12730
	private List<Color> _colors;

	// Token: 0x040031BB RID: 12731
	private static int _colorIndex;

	// Token: 0x040031BC RID: 12732
	[SerializeField]
	protected List<BotZoneDebugPoints> _points;

	// Token: 0x040031BD RID: 12733
	public int ActivePointsIndex;

	// Token: 0x0200086B RID: 2155
	[CompilerGenerated]
	private sealed class Class440
	{
		// Token: 0x060030E9 RID: 12521 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(BotZoneDebugPoints p)
		{
			throw null;
		}

		// Token: 0x040031BE RID: 12734
		public string label;
	}
}
