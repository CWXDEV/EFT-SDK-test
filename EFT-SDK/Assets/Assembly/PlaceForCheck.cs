using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x02000152 RID: 338
public class PlaceForCheck
{
	// Token: 0x170001F8 RID: 504
	// (get) Token: 0x06000720 RID: 1824 RVA: 0x00002050 File Offset: 0x00000250
	public CustomNavigationPoint Point
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170001F9 RID: 505
	// (get) Token: 0x06000721 RID: 1825 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000722 RID: 1826 RVA: 0x00002050 File Offset: 0x00000250
	public PlaceForCheckType Type
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

	// Token: 0x170001FA RID: 506
	// (get) Token: 0x06000723 RID: 1827 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000724 RID: 1828 RVA: 0x00002050 File Offset: 0x00000250
	public float CreatedTime
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

	// Token: 0x170001FB RID: 507
	// (get) Token: 0x06000725 RID: 1829 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000726 RID: 1830 RVA: 0x00002050 File Offset: 0x00000250
	public float DieTime
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

	// Token: 0x170001FC RID: 508
	// (get) Token: 0x06000727 RID: 1831 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsDanger
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170001FD RID: 509
	// (get) Token: 0x06000728 RID: 1832 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 Position
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170001FE RID: 510
	// (get) Token: 0x06000729 RID: 1833 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600072A RID: 1834 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsCome
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

	// Token: 0x170001FF RID: 511
	// (get) Token: 0x0600072B RID: 1835 RVA: 0x00002050 File Offset: 0x00000250
	public int EnvironmentId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600072C RID: 1836 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x0600072D RID: 1837 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsThisPointClose(Vector3 testPoint)
	{
		throw null;
	}

	// Token: 0x0600072E RID: 1838 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PointLookComplete(int index)
	{
		throw null;
	}

	// Token: 0x0600072F RID: 1839 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetPointToLook(out Vector3? point)
	{
		throw null;
	}

	// Token: 0x06000730 RID: 1840 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsOld()
	{
		throw null;
	}

	// Token: 0x06000731 RID: 1841 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x06000732 RID: 1842 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(PlaceForCheckType type)
	{
		throw null;
	}

	// Token: 0x06000733 RID: 1843 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x040007F1 RID: 2033
	public Vector3 BasePoint;

	// Token: 0x040007F2 RID: 2034
	public BotOwner CheckingPlayer;

	// Token: 0x040007F3 RID: 2035
	public bool Reacheble;

	// Token: 0x040007F4 RID: 2036
	private bool _isCome;

	// Token: 0x040007F5 RID: 2037
	private readonly List<Vector3> points2look;

	// Token: 0x040007F6 RID: 2038
	private readonly List<int> isPointChecked;

	// Token: 0x040007FB RID: 2043
	public int _environmentId;
}
