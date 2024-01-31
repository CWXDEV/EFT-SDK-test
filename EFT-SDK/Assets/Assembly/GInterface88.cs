using System;
using System.Net;
using System.Net.Sockets;
using FlyingWormConsole3.LiteNetLib;

// Token: 0x02001113 RID: 4371
public interface GInterface88
{
	// Token: 0x06005BF4 RID: 23540
	void OnPeerConnected(GClass1279 peer);

	// Token: 0x06005BF5 RID: 23541
	void OnPeerDisconnected(GClass1279 peer, GStruct113 disconnectInfo);

	// Token: 0x06005BF6 RID: 23542
	void OnNetworkError(IPEndPoint endPoint, SocketError socketError);

	// Token: 0x06005BF7 RID: 23543
	void OnNetworkReceive(GClass1279 peer, GClass1285 reader, DeliveryMethod deliveryMethod);

	// Token: 0x06005BF8 RID: 23544
	void OnNetworkReceiveUnconnected(IPEndPoint remoteEndPoint, GClass1285 reader, UnconnectedMessageType messageType);

	// Token: 0x06005BF9 RID: 23545
	void OnNetworkLatencyUpdate(GClass1279 peer, int latency);

	// Token: 0x06005BFA RID: 23546
	void OnConnectionRequest(GClass1272 request);
}
