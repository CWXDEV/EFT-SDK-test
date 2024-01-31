using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02000206 RID: 518
[StructLayout(LayoutKind.Auto)]
public struct GStruct17
{
	// Token: 0x170002B9 RID: 697
	// (get) Token: 0x06000999 RID: 2457 RVA: 0x00002050 File Offset: 0x00000250
	public int Count
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600099A RID: 2458 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Serialize(GStruct17 data, GInterface79 stream)
	{
		throw null;
	}

	// Token: 0x0600099B RID: 2459 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct17 Deserialize(GInterface76 stream)
	{
		throw null;
	}

	// Token: 0x04000A97 RID: 2711
	public const int OFFSET = 1;

	// Token: 0x04000A98 RID: 2712
	private static int int_0;

	// Token: 0x04000A99 RID: 2713
	public int wildTypesCount;

	// Token: 0x04000A9A RID: 2714
	public int ZonesCount;

	// Token: 0x04000A9B RID: 2715
	public string[] Names;

	// Token: 0x04000A9C RID: 2716
	public int[][] Blocks;
}
