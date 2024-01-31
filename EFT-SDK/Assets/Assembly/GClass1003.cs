using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000D8E RID: 3470
public static class GClass1003
{
	// Token: 0x0600495E RID: 18782 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass1001 AllocateBakeBuffer()
	{
		throw null;
	}

	// Token: 0x0600495F RID: 18783 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ReuseBakeBuffer(GClass1001 buffer)
	{
		throw null;
	}

	// Token: 0x06004960 RID: 18784 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass1002 AllocateExchangeBuffer()
	{
		throw null;
	}

	// Token: 0x06004961 RID: 18785 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ReuseExchangeBuffer(GClass1002 buffer)
	{
		throw null;
	}

	// Token: 0x0400549E RID: 21662
	public const int BAKE_INDEX_BUFFER_SIZE = 65535;

	// Token: 0x0400549F RID: 21663
	private static Queue<GClass1001> queue_0;

	// Token: 0x040054A0 RID: 21664
	private static Queue<GClass1002> queue_1;
}
