using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000E16 RID: 3606
public static class GClass1037
{
	// Token: 0x17000C0E RID: 3086
	// (get) Token: 0x06004B5F RID: 19295 RVA: 0x00002050 File Offset: 0x00000250
	public static IReadOnlyCollection<GClass1037.GClass1038> DebugAllocation
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000C0F RID: 3087
	// (get) Token: 0x06004B60 RID: 19296 RVA: 0x00002050 File Offset: 0x00000250
	public static int NumDebugAllocs
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000C10 RID: 3088
	// (get) Token: 0x06004B61 RID: 19297 RVA: 0x00002050 File Offset: 0x00000250
	public static int RuntimeMemoryUsage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000C11 RID: 3089
	// (get) Token: 0x06004B62 RID: 19298 RVA: 0x00002050 File Offset: 0x00000250
	public static int NumFreeBuffers
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06004B63 RID: 19299 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass1013<ushort> AllocateCellArray()
	{
		throw null;
	}

	// Token: 0x06004B64 RID: 19300 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ReuseCellArray(GClass1013<ushort> e)
	{
		throw null;
	}

	// Token: 0x04005659 RID: 22105
	public const int MAX_SAMPLE_ARRAY_SIZE = 65535;

	// Token: 0x0400565A RID: 22106
	public const int INDEX_SIZE = 2;

	// Token: 0x0400565B RID: 22107
	private static readonly ConcurrentQueue<GClass1037.GClass1038> concurrentQueue_0;

	// Token: 0x0400565C RID: 22108
	private static readonly ConcurrentQueue<GClass1013<ushort>> concurrentQueue_1;

	// Token: 0x02000E17 RID: 3607
	public class GClass1038
	{
		// Token: 0x0400565D RID: 22109
		public GClass1013<ushort> buffer;
	}
}
