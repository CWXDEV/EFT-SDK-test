using System;
using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ComponentAce.Compression.Libs.zlib;
using Koenigz.PerfectCulling.EFT;
using UnityEngine;

// Token: 0x02000E21 RID: 3617
public sealed class GClass1042 : IDisposable
{
	// Token: 0x17000C16 RID: 3094
	// (get) Token: 0x06004B79 RID: 19321 RVA: 0x00002050 File Offset: 0x00000250
	public int NumCells
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000C17 RID: 3095
	// (get) Token: 0x06004B7A RID: 19322 RVA: 0x00002050 File Offset: 0x00000250
	public List<GuidReference> GroupMapping
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06004B7B RID: 19323 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetGroupIndex(GuidReference groupGuid)
	{
		throw null;
	}

	// Token: 0x17000C18 RID: 3096
	// (get) Token: 0x06004B7C RID: 19324 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsValid
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000C19 RID: 3097
	// (get) Token: 0x06004B7D RID: 19325 RVA: 0x00002050 File Offset: 0x00000250
	public System.Buffers.MemoryHandle Handle
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06004B7E RID: 19326 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass1042.GClass1043 AllocateDecompressor()
	{
		throw null;
	}

	// Token: 0x06004B7F RID: 19327 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadSync(string filePath)
	{
		throw null;
	}

	// Token: 0x06004B80 RID: 19328 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PostLoadInitialize()
	{
		throw null;
	}

	// Token: 0x06004B81 RID: 19329 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06004B82 RID: 19330 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<OrientedBounds> GetCellsBounds()
	{
		throw null;
	}

	// Token: 0x06004B83 RID: 19331 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int method_1()
	{
		throw null;
	}

	// Token: 0x06004B84 RID: 19332 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int method_2()
	{
		throw null;
	}

	// Token: 0x06004B85 RID: 19333 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int method_3(int cellIndex)
	{
		throw null;
	}

	// Token: 0x06004B86 RID: 19334 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int method_4(int cellIndex)
	{
		throw null;
	}

	// Token: 0x06004B87 RID: 19335 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int method_5(int cellIndex)
	{
		throw null;
	}

	// Token: 0x06004B88 RID: 19336 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass1042.GStruct77 GetCellBounds(int cellIndex)
	{
		throw null;
	}

	// Token: 0x06004B89 RID: 19337 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetPackedFilePathForGrid(PerfectCullingAdaptiveGrid grid)
	{
		throw null;
	}

	// Token: 0x06004B8A RID: 19338 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x04005680 RID: 22144
	public const string PACKED_FILE_EXT = "_packed_cull.bytes";

	// Token: 0x04005681 RID: 22145
	private GClass1022 gclass1022_0;

	// Token: 0x04005682 RID: 22146
	private int int_0;

	// Token: 0x04005683 RID: 22147
	private byte[] byte_0;

	// Token: 0x04005684 RID: 22148
	private System.ReadOnlyMemory<byte> readOnlyMemory_0;

	// Token: 0x04005685 RID: 22149
	private System.Buffers.MemoryHandle memoryHandle_0;

	// Token: 0x04005686 RID: 22150
	private int int_1;

	// Token: 0x04005687 RID: 22151
	private System.ReadOnlyMemory<int> readOnlyMemory_1;

	// Token: 0x04005688 RID: 22152
	private List<GuidReference> list_0;

	// Token: 0x02000E22 RID: 3618
	public sealed class GClass1043 : IDisposable
	{
		// Token: 0x06004B8B RID: 19339 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int DecompressCullingCell(int cellIndex, int targetGroupId, GClass1013<ushort> outputArray)
		{
			throw null;
		}

		// Token: 0x06004B8C RID: 19340 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DecompressCullingCell(int cellIndex, GDelegate32 callbackPerCullingGroupInCell)
		{
			throw null;
		}

		// Token: 0x06004B8D RID: 19341 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int method_0(byte[] compressedIndices, int readOffset, int numIndices, GClass1013<ushort> outIndices)
		{
			throw null;
		}

		// Token: 0x06004B8E RID: 19342 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x04005689 RID: 22153
		private const int int_0 = 262140;

		// Token: 0x0400568A RID: 22154
		private static readonly ArrayPool<byte> arrayPool_0;

		// Token: 0x0400568B RID: 22155
		private GClass1042 gclass1042_0;

		// Token: 0x0400568C RID: 22156
		private byte[] byte_0;

		// Token: 0x0400568D RID: 22157
		private GClass1022 gclass1022_0;

		// Token: 0x0400568E RID: 22158
		private GClass1013<ushort> gclass1013_0;

		// Token: 0x0400568F RID: 22159
		private ZStream zstream_0;

		// Token: 0x04005690 RID: 22160
		private byte[] byte_1;

		// Token: 0x04005691 RID: 22161
		private byte[] byte_2;

		// Token: 0x04005692 RID: 22162
		private int int_1;
	}

	// Token: 0x02000E23 RID: 3619
	[StructLayout(LayoutKind.Auto)]
	public readonly struct GStruct77
	{
		// Token: 0x06004B8F RID: 19343 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04005693 RID: 22163
		public readonly Vector3 center;

		// Token: 0x04005694 RID: 22164
		public readonly Vector3 size;

		// Token: 0x04005695 RID: 22165
		public readonly Quaternion rotation;
	}
}
