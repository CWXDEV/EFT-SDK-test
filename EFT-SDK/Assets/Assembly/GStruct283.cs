using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Jobs;

// Token: 0x02002037 RID: 8247
[StructLayout(LayoutKind.Auto, Size = 1)]
public struct GStruct283 : IJobParallelFor
{
	// Token: 0x0600AAC7 RID: 43719 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Execute(int observedPlayerIndex)
	{
		throw null;
	}

	// Token: 0x0400B190 RID: 45456
	public static int ObservedPlayerCount;

	// Token: 0x0400B191 RID: 45457
	public static int[] ObservedPlayers;

	// Token: 0x0400B192 RID: 45458
	public static bool[] ObservedPlayerControllerExists;

	// Token: 0x0400B193 RID: 45459
	public static GStruct286[] ObservedPlayerModels;

	// Token: 0x0400B194 RID: 45460
	public static GClass1648[] ObservedPlayerInterpolators;

	// Token: 0x0400B195 RID: 45461
	public static int SnapshotMessageCount;

	// Token: 0x0400B196 RID: 45462
	public static double[] SnapshotMessageRemoteTimes;

	// Token: 0x0400B197 RID: 45463
	public static GStruct274[,] SnapshotMessages;

	// Token: 0x0400B198 RID: 45464
	public static bool[,] SnapshotMessageExists;

	// Token: 0x0400B199 RID: 45465
	public static int CommandsMessageCount;

	// Token: 0x0400B19A RID: 45466
	public static double[] CommandsMessageRemoteTimes;

	// Token: 0x0400B19B RID: 45467
	public static GClass2304[,] CommandsMessages;

	// Token: 0x0400B19C RID: 45468
	public static bool[,] CommandsMessageExists;

	// Token: 0x0400B19D RID: 45469
	public static double LocalTime;

	// Token: 0x0400B19E RID: 45470
	public static float LocalDeltaTime;
}
