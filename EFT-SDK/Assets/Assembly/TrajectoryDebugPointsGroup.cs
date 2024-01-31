using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000873 RID: 2163
[Serializable]
public class TrajectoryDebugPointsGroup
{
	// Token: 0x17000873 RID: 2163
	// (get) Token: 0x06003102 RID: 12546 RVA: 0x00002050 File Offset: 0x00000250
	public string Label
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000874 RID: 2164
	// (get) Token: 0x06003103 RID: 12547 RVA: 0x00002050 File Offset: 0x00000250
	public List<TrajectoryDebugPoints> Points
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000875 RID: 2165
	// (get) Token: 0x06003104 RID: 12548 RVA: 0x00002050 File Offset: 0x00000250
	public TrajectoryDebugPoints List
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000876 RID: 2166
	// (get) Token: 0x06003105 RID: 12549 RVA: 0x00002050 File Offset: 0x00000250
	public float MinTimeLimit
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000877 RID: 2167
	// (get) Token: 0x06003106 RID: 12550 RVA: 0x00002050 File Offset: 0x00000250
	public float MaxTimeLimit
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06003107 RID: 12551 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string[] GetElementsList()
	{
		throw null;
	}

	// Token: 0x06003108 RID: 12552 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected Color NextColor()
	{
		throw null;
	}

	// Token: 0x06003109 RID: 12553 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset()
	{
		throw null;
	}

	// Token: 0x0600310A RID: 12554 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Add(string label, Vector3 point, float time)
	{
		throw null;
	}

	// Token: 0x0600310B RID: 12555 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Draw()
	{
		throw null;
	}

	// Token: 0x040031D2 RID: 12754
	[SerializeField]
	protected string _label;

	// Token: 0x040031D3 RID: 12755
	public bool IsDraw;

	// Token: 0x040031D4 RID: 12756
	public Color Color;

	// Token: 0x040031D5 RID: 12757
	public Vector3 Offset;

	// Token: 0x040031D6 RID: 12758
	public float Radius;

	// Token: 0x040031D7 RID: 12759
	private List<Color> _colors;

	// Token: 0x040031D8 RID: 12760
	private static int _colorIndex;

	// Token: 0x040031D9 RID: 12761
	[SerializeField]
	protected List<TrajectoryDebugPoints> _points;

	// Token: 0x040031DA RID: 12762
	public int ActivePointsIndex;

	// Token: 0x040031DB RID: 12763
	public float MinTime;

	// Token: 0x040031DC RID: 12764
	public float MaxTime;

	// Token: 0x02000874 RID: 2164
	[CompilerGenerated]
	private sealed class Class442
	{
		// Token: 0x0600310C RID: 12556 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(TrajectoryDebugPoints p)
		{
			throw null;
		}

		// Token: 0x040031DD RID: 12765
		public string label;
	}
}
