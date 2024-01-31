using System;
using System.Runtime.CompilerServices;

// Token: 0x0200113C RID: 4412
internal sealed class Class827
{
	// Token: 0x06005CDA RID: 23770 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Class827 FromData(Class825 packet)
	{
		throw null;
	}

	// Token: 0x06005CDB RID: 23771 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Class825 Make(long connectId, byte connectNum, bool reusedPeer)
	{
		throw null;
	}

	// Token: 0x0400684A RID: 26698
	public const int Size = 11;

	// Token: 0x0400684B RID: 26699
	public readonly long ConnectionId;

	// Token: 0x0400684C RID: 26700
	public readonly byte ConnectionNumber;

	// Token: 0x0400684D RID: 26701
	public readonly bool IsReusedPeer;
}
