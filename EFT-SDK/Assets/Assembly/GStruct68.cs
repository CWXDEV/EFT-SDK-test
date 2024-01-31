using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

// Token: 0x02000C5E RID: 3166
[StructLayout(LayoutKind.Auto)]
public struct GStruct68
{
	// Token: 0x17000AFD RID: 2813
	// (get) Token: 0x060044EC RID: 17644 RVA: 0x00002050 File Offset: 0x00000250
	public int MaxHits
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060044ED RID: 17645 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public JobHandle Schedule(JobHandle dependency)
	{
		throw null;
	}

	// Token: 0x060044EE RID: 17646 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x04004F01 RID: 20225
	private NativeArray<RaycastHit> nativeArray_0;

	// Token: 0x04004F02 RID: 20226
	private int int_0;

	// Token: 0x04004F03 RID: 20227
	private NativeArray<RaycastHit>[] nativeArray_1;

	// Token: 0x04004F04 RID: 20228
	private NativeArray<SpherecastCommand>[] nativeArray_2;

	// Token: 0x02000C5F RID: 3167
	[StructLayout(LayoutKind.Auto)]
	public struct Struct137 : IJobParallelFor
	{
		// Token: 0x060044EF RID: 17647 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Execute(int index)
		{
			throw null;
		}

		// Token: 0x04004F05 RID: 20229
		[ReadOnly]
		public NativeArray<SpherecastCommand> previousCommands;

		// Token: 0x04004F06 RID: 20230
		[ReadOnly]
		public NativeArray<RaycastHit> spherecastHits;

		// Token: 0x04004F07 RID: 20231
		[WriteOnly]
		public NativeArray<SpherecastCommand> spherecastCommands;
	}

	// Token: 0x02000C60 RID: 3168
	[StructLayout(LayoutKind.Auto)]
	public struct Struct138 : IJob
	{
		// Token: 0x060044F0 RID: 17648 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Execute()
		{
			throw null;
		}

		// Token: 0x04004F08 RID: 20232
		public int maxHits;

		// Token: 0x04004F09 RID: 20233
		public int offset;

		// Token: 0x04004F0A RID: 20234
		[ReadOnly]
		public NativeArray<RaycastHit> semiResults;

		// Token: 0x04004F0B RID: 20235
		[WriteOnly]
		public NativeArray<RaycastHit> results;
	}

	// Token: 0x02000C61 RID: 3169
	[StructLayout(LayoutKind.Auto)]
	public struct Struct139 : IJob
	{
		// Token: 0x060044F1 RID: 17649 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Execute()
		{
			throw null;
		}

		// Token: 0x04004F0C RID: 20236
		public int maxHits;

		// Token: 0x04004F0D RID: 20237
		public NativeArray<SpherecastCommand> spherecastCommands;

		// Token: 0x04004F0E RID: 20238
		public NativeArray<RaycastHit> spherecastHits;
	}
}
