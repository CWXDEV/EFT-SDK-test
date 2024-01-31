using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020014D7 RID: 5335
public class GClass1647<T> where T : GInterface67
{
	// Token: 0x170011A2 RID: 4514
	// (get) Token: 0x0600721B RID: 29211 RVA: 0x00002050 File Offset: 0x00000250
	public double BufferTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170011A3 RID: 4515
	// (get) Token: 0x0600721C RID: 29212 RVA: 0x00002050 File Offset: 0x00000250
	public double BufferMax
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600721D RID: 29213 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRemoteFramerate(int framerate)
	{
		throw null;
	}

	// Token: 0x0600721E RID: 29214 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(T message)
	{
		throw null;
	}

	// Token: 0x0600721F RID: 29215 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public T Interpolate(float deltaTime, Func<T, T, float, T> interpolateFunc)
	{
		throw null;
	}

	// Token: 0x06007221 RID: 29217 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset()
	{
		throw null;
	}

	// Token: 0x040078C3 RID: 30915
	private GClass1646.GStruct135 gstruct135_0;

	// Token: 0x040078C4 RID: 30916
	private int int_0;

	// Token: 0x040078C5 RID: 30917
	private float float_0;

	// Token: 0x040078C6 RID: 30918
	private readonly int int_1;

	// Token: 0x040078C7 RID: 30919
	private GStruct89 gstruct89_0;

	// Token: 0x040078C8 RID: 30920
	private GStruct89 gstruct89_1;

	// Token: 0x040078C9 RID: 30921
	private double double_0;

	// Token: 0x040078CA RID: 30922
	private double double_1;

	// Token: 0x040078CB RID: 30923
	private double double_2;

	// Token: 0x040078CC RID: 30924
	public SortedList<double, T> snapshots;
}
