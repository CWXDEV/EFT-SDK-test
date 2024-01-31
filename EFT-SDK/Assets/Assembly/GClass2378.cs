using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Jobs;

// Token: 0x02002039 RID: 8249
public static class GClass2378
{
	// Token: 0x0600AAC9 RID: 43721 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static JobHandle Run(GClass2359 observedPlayerControllers, List<GClass1252> snapshotMessageBuffers, List<GClass1252> commandsMessageBuffers, GClass1644 channelCombinedPacketEncryptor, float localTime, float localDeltaTime)
	{
		throw null;
	}

	// Token: 0x0400B1AA RID: 45482
	public const int OBSERVED_PLAYER_SIZE = 255;

	// Token: 0x0400B1AB RID: 45483
	public const int MESSAGE_SIZE = 1024;

	// Token: 0x0400B1AC RID: 45484
	private static NativeArray<JobHandle> nativeArray_0;

	// Token: 0x0400B1AD RID: 45485
	private static int int_0;

	// Token: 0x0400B1AE RID: 45486
	private static readonly int[] int_1;

	// Token: 0x0400B1AF RID: 45487
	private static readonly bool[] bool_0;
}
