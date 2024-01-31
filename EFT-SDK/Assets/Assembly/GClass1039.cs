using System;
using System.IO;
using System.Runtime.CompilerServices;
using Koenigz.PerfectCulling.EFT;

// Token: 0x02000E18 RID: 3608
public sealed class GClass1039
{
	// Token: 0x17000C12 RID: 3090
	// (get) Token: 0x06004B65 RID: 19301 RVA: 0x00002050 File Offset: 0x00000250
	public StreamingVolumeBakeDataIndex StreamData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06004B66 RID: 19302 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetRuntimeMemorySizeBytes()
	{
		throw null;
	}

	// Token: 0x06004B67 RID: 19303 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(byte[] compressed, int offset, int len, GClass1013<ushort> indices)
	{
		throw null;
	}

	// Token: 0x06004B68 RID: 19304 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(byte[] compressed, int len, GClass1013<ushort> indices)
	{
		throw null;
	}

	// Token: 0x06004B69 RID: 19305 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int SampleByIndexFromDisk(int index, GClass1013<ushort> buffer)
	{
		throw null;
	}

	// Token: 0x06004B6A RID: 19306 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0400565E RID: 22110
	private StreamingVolumeBakeDataIndex streamingVolumeBakeDataIndex_0;

	// Token: 0x0400565F RID: 22111
	private FileStream fileStream_0;

	// Token: 0x04005660 RID: 22112
	private GClass1022 gclass1022_0;

	// Token: 0x04005661 RID: 22113
	private byte[] byte_0;

	// Token: 0x04005662 RID: 22114
	private byte[] byte_1;

	// Token: 0x04005663 RID: 22115
	public volatile int bytesRead;

	// Token: 0x04005664 RID: 22116
	public volatile int readOps;

	// Token: 0x04005665 RID: 22117
	private bool bool_0;
}
