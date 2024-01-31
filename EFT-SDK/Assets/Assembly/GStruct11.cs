using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x020001FA RID: 506
[StructLayout(LayoutKind.Auto)]
public struct GStruct11
{
	// Token: 0x06000920 RID: 2336 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Serialize(GStruct11 data, GInterface79 stream)
	{
		throw null;
	}

	// Token: 0x06000921 RID: 2337 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct11 Deserialize(GInterface76 stream)
	{
		throw null;
	}

	// Token: 0x040009F7 RID: 2551
	public int Alive;

	// Token: 0x040009F8 RID: 2552
	public int ProfileWait;

	// Token: 0x040009F9 RID: 2553
	public int SpawnBundlesWait;

	// Token: 0x040009FA RID: 2554
	public int Delayed;

	// Token: 0x040009FB RID: 2555
	public int SpawnProcess;

	// Token: 0x040009FC RID: 2556
	public int Hour;

	// Token: 0x040009FD RID: 2557
	public int DelayedGroups;

	// Token: 0x040009FE RID: 2558
	public int[] DelayedCounts;
}
