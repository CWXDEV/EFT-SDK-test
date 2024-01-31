using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200012C RID: 300
[Serializable]
public class NavEdge
{
	// Token: 0x170001C6 RID: 454
	// (get) Token: 0x0600066F RID: 1647 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000670 RID: 1648 RVA: 0x00002050 File Offset: 0x00000250
	public bool Deleted
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x170001C7 RID: 455
	// (get) Token: 0x06000671 RID: 1649 RVA: 0x00002050 File Offset: 0x00000250
	public bool HavePair
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000672 RID: 1650 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CalcCompareString(int halfSize)
	{
		throw null;
	}

	// Token: 0x06000673 RID: 1651 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Restore(Dictionary<int, NavPoint> dc, Dictionary<int, NavTriangle> dcTriang)
	{
		throw null;
	}

	// Token: 0x06000674 RID: 1652 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetMagnitude()
	{
		throw null;
	}

	// Token: 0x06000675 RID: 1653 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NavPoint GetOther(NavPoint key)
	{
		throw null;
	}

	// Token: 0x06000676 RID: 1654 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MarkDeleted()
	{
		throw null;
	}

	// Token: 0x06000677 RID: 1655 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DebugDraw(float up, Color? color = null)
	{
		throw null;
	}

	// Token: 0x06000678 RID: 1656 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x06000679 RID: 1657 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 GetPos()
	{
		throw null;
	}

	// Token: 0x0600067A RID: 1658 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float CalcDist()
	{
		throw null;
	}

	// Token: 0x0600067B RID: 1659 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangePoints(NavPoint toRemove, NavPoint connectTo)
	{
		throw null;
	}

	// Token: 0x0600067C RID: 1660 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(NavPoint p1, NavPoint p2)
	{
		throw null;
	}

	// Token: 0x04000723 RID: 1827
	[NonSerialized]
	public NavPoint Point1;

	// Token: 0x04000724 RID: 1828
	[NonSerialized]
	public NavPoint Point2;

	// Token: 0x04000725 RID: 1829
	[NonSerialized]
	public NavTriangle Triangle;

	// Token: 0x04000726 RID: 1830
	[NonSerialized]
	public NavEdge Pair;

	// Token: 0x04000727 RID: 1831
	[NonSerialized]
	public int IdToCompare;

	// Token: 0x04000728 RID: 1832
	[NonSerialized]
	public float Magnitude;

	// Token: 0x04000729 RID: 1833
	public int Idpoint1;

	// Token: 0x0400072A RID: 1834
	public int Idpoint2;

	// Token: 0x0400072B RID: 1835
	public int IdTriangle;

	// Token: 0x0400072C RID: 1836
	public int Id;
}
