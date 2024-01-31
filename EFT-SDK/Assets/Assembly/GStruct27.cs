using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Jobs;

// Token: 0x020006B0 RID: 1712
[StructLayout(LayoutKind.Auto)]
public struct GStruct27 : IJobParallelFor
{
	// Token: 0x060026B6 RID: 9910 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetExecutionLength()
	{
		throw null;
	}

	// Token: 0x060026B7 RID: 9911 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Execute(int executeIndex)
	{
		throw null;
	}

	// Token: 0x060026B8 RID: 9912 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(GStruct27.GClass644 pars, int index)
	{
		throw null;
	}

	// Token: 0x040025F6 RID: 9718
	public static readonly GStruct27.GClass644[] JobParams;

	// Token: 0x040025F7 RID: 9719
	[ReadOnly]
	public int Index;

	// Token: 0x020006B1 RID: 1713
	public sealed class GClass644
	{
		// Token: 0x040025F8 RID: 9720
		public int Count;

		// Token: 0x040025F9 RID: 9721
		public GStruct24[] Commands;

		// Token: 0x040025FA RID: 9722
		public GClass642[] Triggers;

		// Token: 0x040025FB RID: 9723
		public int[] Result;
	}
}
