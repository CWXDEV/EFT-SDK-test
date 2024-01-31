using System;
using System.Net;

// Token: 0x02001181 RID: 4481
public abstract class GClass1290
{
	// Token: 0x06005E81 RID: 24193
	public abstract void ProcessInboundPacket(IPEndPoint endPoint, ref byte[] data, ref int offset, ref int length);

	// Token: 0x06005E82 RID: 24194
	public abstract void ProcessOutBoundPacket(IPEndPoint endPoint, ref byte[] data, ref int offset, ref int length);

	// Token: 0x0400691A RID: 26906
	public readonly int ExtraPacketSizeForLayer;
}
