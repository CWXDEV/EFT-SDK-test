using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Jobs;

// Token: 0x02002043 RID: 8259
[StructLayout(LayoutKind.Auto, Size = 1)]
public struct GStruct288 : IJobParallelFor
{
	// Token: 0x0600AAFB RID: 43771 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Execute(int index)
	{
		throw null;
	}

	// Token: 0x0400B1FF RID: 45567
	private const int int_0 = 256;

	// Token: 0x0400B200 RID: 45568
	private const int int_1 = 1024;

	// Token: 0x0400B201 RID: 45569
	public static double LocalTime;

	// Token: 0x0400B202 RID: 45570
	public static float DeltaTime;

	// Token: 0x0400B203 RID: 45571
	public static readonly double[] RemoteTimes;

	// Token: 0x0400B204 RID: 45572
	public static int Count;

	// Token: 0x0400B205 RID: 45573
	public static bool[,] Exists;

	// Token: 0x0400B206 RID: 45574
	public static GStruct274[,] Messages;

	// Token: 0x0400B207 RID: 45575
	public static readonly GClass1648[] Interpolations;

	// Token: 0x0400B208 RID: 45576
	public static GStruct286[] Models;
}
