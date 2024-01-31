using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ChartAndGraph;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02003180 RID: 12672
public abstract class GClass3396 : Interface21
{
	// Token: 0x17002B24 RID: 11044
	// (get) Token: 0x0600F992 RID: 63890 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600F993 RID: 63891 RVA: 0x00002050 File Offset: 0x00000250
	public ChartOrientation Orientation
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17002B25 RID: 11045
	// (get) Token: 0x0600F994 RID: 63892 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600F995 RID: 63893 RVA: 0x00002050 File Offset: 0x00000250
	public float Tile
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17002B26 RID: 11046
	// (get) Token: 0x0600F996 RID: 63894 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600F997 RID: 63895 RVA: 0x00002050 File Offset: 0x00000250
	public float Offset
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17002B27 RID: 11047
	// (get) Token: 0x0600F998 RID: 63896 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600F999 RID: 63897 RVA: 0x00002050 File Offset: 0x00000250
	public float Length
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17002B28 RID: 11048
	// (get) Token: 0x0600F99A RID: 63898 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600F99B RID: 63899 RVA: 0x00002050 File Offset: 0x00000250
	public bool RecycleText
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17002B29 RID: 11049
	// (get) Token: 0x0600F99C RID: 63900 RVA: 0x00002050 File Offset: 0x00000250
	public virtual List<BillboardText> CurrentTextObjects
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002B2A RID: 11050
	// (get) Token: 0x0600F99D RID: 63901 RVA: 0x00002050 File Offset: 0x00000250
	public virtual List<BillboardText> TextObjects
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600F99E RID: 63902 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected Vector2[] method_0(Rect rect)
	{
		throw null;
	}

	// Token: 0x0600F99F RID: 63903 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Clear()
	{
		throw null;
	}

	// Token: 0x0600F9A0 RID: 63904 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected Vector2[] method_1(Rect rect, ChartOrientation orientaion)
	{
		throw null;
	}

	// Token: 0x0600F9A1 RID: 63905 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(BillboardText t)
	{
		throw null;
	}

	// Token: 0x0600F9A2 RID: 63906 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestoryRecycled()
	{
		throw null;
	}

	// Token: 0x0600F9A3 RID: 63907 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual BillboardText AddText(AnyChart chart, Text prefab, Transform parentTransform, int fontSize, float fontSharpness, string text, float x, float y, float z, float angle, object userData)
	{
		throw null;
	}

	// Token: 0x0600F9A4 RID: 63908
	public abstract void AddQuad(UIVertex vLeftTop, UIVertex vRightTop, UIVertex vLeftBottom, UIVertex vRightBottom);

	// Token: 0x0600F9A5 RID: 63909
	public abstract void AddXYRect(Rect rect, int subMeshGroup, float depth);

	// Token: 0x0600F9A6 RID: 63910
	public abstract void AddXZRect(Rect rect, int subMeshGroup, float yPosition);

	// Token: 0x0600F9A7 RID: 63911
	public abstract void AddYZRect(Rect rect, int subMeshGroup, float xPosition);

	// Token: 0x0400FDEB RID: 65003
	private List<BillboardText> list_0;

	// Token: 0x0400FDEC RID: 65004
	private List<BillboardText> list_1;

	// Token: 0x0400FDED RID: 65005
	private Dictionary<string, BillboardText> dictionary_0;

	// Token: 0x0400FDEE RID: 65006
	private List<BillboardText> list_2;

	// Token: 0x0400FDEF RID: 65007
	private float float_0;

	// Token: 0x0400FDF0 RID: 65008
	[CompilerGenerated]
	private ChartOrientation chartOrientation_0;

	// Token: 0x0400FDF1 RID: 65009
	[CompilerGenerated]
	private float float_1;

	// Token: 0x0400FDF2 RID: 65010
	[CompilerGenerated]
	private float float_2;

	// Token: 0x0400FDF3 RID: 65011
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x0400FDF4 RID: 65012
	private Vector2[][] vector2_0;

	// Token: 0x0400FDF5 RID: 65013
	private Vector2[] vector2_1;
}
