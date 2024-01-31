using System;
using System.Net;
using System.Runtime.CompilerServices;

// Token: 0x0200113B RID: 4411
internal sealed class Class826
{
	// Token: 0x06005CD7 RID: 23767 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetProtocolId(Class825 packet)
	{
		throw null;
	}

	// Token: 0x06005CD8 RID: 23768 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Class826 FromData(Class825 packet)
	{
		throw null;
	}

	// Token: 0x06005CD9 RID: 23769 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Class825 Make(GClass1286 connectData, SocketAddress addressBytes, long connectId)
	{
		throw null;
	}

	// Token: 0x04006845 RID: 26693
	public const int HeaderSize = 14;

	// Token: 0x04006846 RID: 26694
	public readonly long ConnectionTime;

	// Token: 0x04006847 RID: 26695
	public readonly byte ConnectionNumber;

	// Token: 0x04006848 RID: 26696
	public readonly byte[] TargetAddress;

	// Token: 0x04006849 RID: 26697
	public readonly GClass1284 Data;
}
