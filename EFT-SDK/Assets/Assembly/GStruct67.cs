using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

// Token: 0x02000C5A RID: 3162
[StructLayout(LayoutKind.Auto)]
public struct GStruct67
{
	// Token: 0x17000AFC RID: 2812
	// (get) Token: 0x060044E5 RID: 17637 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060044E6 RID: 17638 RVA: 0x00002050 File Offset: 0x00000250
	public int MaxHits
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

	// Token: 0x060044E7 RID: 17639 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public JobHandle Schedule(JobHandle dependency)
	{
		throw null;
	}

	// Token: 0x060044E8 RID: 17640 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x04004EF1 RID: 20209
	private readonly NativeArray<RaycastHit> nativeArray_0;

	// Token: 0x04004EF2 RID: 20210
	[CompilerGenerated]
	private int int_0;

	// Token: 0x04004EF3 RID: 20211
	public readonly float MINStep;

	// Token: 0x04004EF4 RID: 20212
	private readonly NativeArray<RaycastHit>[] nativeArray_1;

	// Token: 0x04004EF5 RID: 20213
	private readonly NativeArray<RaycastCommand>[] nativeArray_2;

	// Token: 0x02000C5B RID: 3163
	[StructLayout(LayoutKind.Auto)]
	public struct Struct134 : IJobParallelFor
	{
		// Token: 0x060044E9 RID: 17641 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Execute(int index)
		{
			throw null;
		}

		// Token: 0x04004EF6 RID: 20214
		[ReadOnly]
		public NativeArray<RaycastCommand> PreviousCommands;

		// Token: 0x04004EF7 RID: 20215
		[ReadOnly]
		public NativeArray<RaycastHit> RaycastHits;

		// Token: 0x04004EF8 RID: 20216
		[WriteOnly]
		public NativeArray<RaycastCommand> RaycastCommands;

		// Token: 0x04004EF9 RID: 20217
		[ReadOnly]
		public float MINStep;
	}

	// Token: 0x02000C5C RID: 3164
	[StructLayout(LayoutKind.Auto)]
	public struct Struct135 : IJob
	{
		// Token: 0x060044EA RID: 17642 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Execute()
		{
			throw null;
		}

		// Token: 0x04004EFA RID: 20218
		public int MAXHits;

		// Token: 0x04004EFB RID: 20219
		public int Offset;

		// Token: 0x04004EFC RID: 20220
		[ReadOnly]
		public NativeArray<RaycastHit> SemiResults;

		// Token: 0x04004EFD RID: 20221
		[WriteOnly]
		public NativeArray<RaycastHit> Results;
	}

	// Token: 0x02000C5D RID: 3165
	[StructLayout(LayoutKind.Auto)]
	public struct Struct136 : IJob
	{
		// Token: 0x060044EB RID: 17643 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Execute()
		{
			throw null;
		}

		// Token: 0x04004EFE RID: 20222
		public int MAXHits;

		// Token: 0x04004EFF RID: 20223
		public NativeArray<RaycastCommand> RaycastCommands;

		// Token: 0x04004F00 RID: 20224
		public NativeArray<RaycastHit> RaycastHits;
	}
}
