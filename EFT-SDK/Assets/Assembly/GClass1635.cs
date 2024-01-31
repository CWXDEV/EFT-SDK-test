using System;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

// Token: 0x020014B9 RID: 5305
public sealed class GClass1635
{
	// Token: 0x060071C2 RID: 29122 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass1635 CreateInstance(NetworkConnection connection, GClass1644 packetEncryptor)
	{
		throw null;
	}

	// Token: 0x17001191 RID: 4497
	// (get) Token: 0x060071C3 RID: 29123 RVA: 0x00002050 File Offset: 0x00000250
	public GClass1644 PacketEncryptor
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060071C4 RID: 29124 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private byte[] method_0(short messageType, ArraySegment<byte> buffer, out int messageSize)
	{
		throw null;
	}

	// Token: 0x060071C5 RID: 29125 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Send(byte channel, short messageType, ArraySegment<byte> buffer)
	{
		throw null;
	}

	// Token: 0x0400785A RID: 30810
	public const int DEFERRED_BUFFER_SIZE = 8388608;

	// Token: 0x0400785B RID: 30811
	private NetworkConnection networkConnection_0;

	// Token: 0x0400785C RID: 30812
	private GClass1644 gclass1644_0;

	// Token: 0x0400785D RID: 30813
	private readonly byte[] byte_0;

	// Token: 0x0400785E RID: 30814
	private readonly GClass1160 gclass1160_0;

	// Token: 0x0400785F RID: 30815
	private const int int_0 = 4;
}
