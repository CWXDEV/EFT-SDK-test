using System;
using System.Net;
using System.Net.Sockets;
using FlyingWormConsole3.LiteNetLib;

// Token: 0x02001134 RID: 4404
internal sealed class Class823
{
	// Token: 0x040067E5 RID: 26597
	public Class823 Next;

	// Token: 0x040067E6 RID: 26598
	public Class823.EType Type;

	// Token: 0x040067E7 RID: 26599
	public GClass1279 Peer;

	// Token: 0x040067E8 RID: 26600
	public IPEndPoint RemoteEndPoint;

	// Token: 0x040067E9 RID: 26601
	public object UserData;

	// Token: 0x040067EA RID: 26602
	public int Latency;

	// Token: 0x040067EB RID: 26603
	public SocketError ErrorCode;

	// Token: 0x040067EC RID: 26604
	public DisconnectReason DisconnectReason;

	// Token: 0x040067ED RID: 26605
	public GClass1272 ConnectionRequest;

	// Token: 0x040067EE RID: 26606
	public DeliveryMethod DeliveryMethod;

	// Token: 0x040067EF RID: 26607
	public readonly GClass1285 DataReader;

	// Token: 0x02001135 RID: 4405
	public enum EType
	{
		// Token: 0x040067F1 RID: 26609
		Connect,
		// Token: 0x040067F2 RID: 26610
		Disconnect,
		// Token: 0x040067F3 RID: 26611
		Receive,
		// Token: 0x040067F4 RID: 26612
		ReceiveUnconnected,
		// Token: 0x040067F5 RID: 26613
		Error,
		// Token: 0x040067F6 RID: 26614
		ConnectionLatencyUpdated,
		// Token: 0x040067F7 RID: 26615
		Broadcast,
		// Token: 0x040067F8 RID: 26616
		ConnectionRequest,
		// Token: 0x040067F9 RID: 26617
		MessageDelivered
	}
}
