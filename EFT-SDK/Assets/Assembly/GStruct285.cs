using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Jobs;

// Token: 0x0200203A RID: 8250
[StructLayout(LayoutKind.Auto, Size = 1)]
public struct GStruct285 : IJob
{
	// Token: 0x0600AACA RID: 43722 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Execute()
	{
		throw null;
	}

	// Token: 0x0400B1B0 RID: 45488
	public static int ByteMessageCount;

	// Token: 0x0400B1B1 RID: 45489
	public static readonly GClass1252[] ByteMessages;

	// Token: 0x0400B1B2 RID: 45490
	private static GClass1073 gclass1073_0;

	// Token: 0x0400B1B3 RID: 45491
	public static GClass1644 PacketEncryptor;

	// Token: 0x0400B1B4 RID: 45492
	private const int int_0 = 65536;

	// Token: 0x0400B1B5 RID: 45493
	private static readonly byte[] byte_0;

	// Token: 0x0400B1B6 RID: 45494
	public static int ObservedPlayerCount;

	// Token: 0x0400B1B7 RID: 45495
	public static int[] ObservedPlayers;

	// Token: 0x0400B1B8 RID: 45496
	public static readonly double[] RemoteTimes;

	// Token: 0x0400B1B9 RID: 45497
	public static readonly GStruct274[,] Messages;

	// Token: 0x0400B1BA RID: 45498
	public static readonly bool[,] MessageExists;

	// Token: 0x0400B1BB RID: 45499
	public static float RemoteTime;
}
