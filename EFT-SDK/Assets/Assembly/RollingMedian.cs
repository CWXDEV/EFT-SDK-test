using System;
using System.Runtime.CompilerServices;

// Token: 0x020007B3 RID: 1971
public class RollingMedian
{
	// Token: 0x1700081B RID: 2075
	// (get) Token: 0x06002D99 RID: 11673 RVA: 0x00002050 File Offset: 0x00000250
	public float Median
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700081C RID: 2076
	// (get) Token: 0x06002D9A RID: 11674 RVA: 0x00002050 File Offset: 0x00000250
	public float Avarage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06002D9B RID: 11675 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddValue(float value)
	{
		throw null;
	}

	// Token: 0x04002C26 RID: 11302
	private int bufferSize;

	// Token: 0x04002C27 RID: 11303
	private int bufferCount;

	// Token: 0x04002C28 RID: 11304
	private int counter;

	// Token: 0x04002C29 RID: 11305
	private float[] buffer;

	// Token: 0x04002C2A RID: 11306
	private float[] sortedBuffer;

	// Token: 0x04002C2B RID: 11307
	private bool _dirty;

	// Token: 0x04002C2C RID: 11308
	private float cachedAvarage;
}
