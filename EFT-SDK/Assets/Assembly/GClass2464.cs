using System;
using System.Net;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;
using UnityEngine.Networking.Types;

// Token: 0x0200221E RID: 8734
public class GClass2464 : INetworkTransport
{
	// Token: 0x0600B208 RID: 45576 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void EarlyUpdate()
	{
		throw null;
	}

	// Token: 0x0600B209 RID: 45577 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void LateUpdate()
	{
		throw null;
	}

	// Token: 0x17001DE6 RID: 7654
	// (get) Token: 0x0600B20A RID: 45578 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsStarted
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600B20B RID: 45579 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int AddHost(HostTopology topology, int port, string ip)
	{
		throw null;
	}

	// Token: 0x0600B20C RID: 45580 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int AddHostWithSimulator(HostTopology topology, int minTimeout, int maxTimeout, int port)
	{
		throw null;
	}

	// Token: 0x0600B20D RID: 45581 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int AddWebsocketHost(HostTopology topology, int port, string ip)
	{
		throw null;
	}

	// Token: 0x0600B20E RID: 45582 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int Connect(int hostId, string address, int port, int specialConnectionId, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B20F RID: 45583 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ConnectAsNetworkHost(int hostId, string address, int port, NetworkID network, SourceID source, NodeID node, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B210 RID: 45584 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int ConnectEndPoint(int hostId, EndPoint endPoint, int specialConnectionId, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B211 RID: 45585 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int ConnectToNetworkPeer(int hostId, string address, int port, int specialConnectionId, int relaySlotId, NetworkID network, SourceID source, NodeID node, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B212 RID: 45586 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int ConnectWithSimulator(int hostId, string address, int port, int specialConnectionId, out byte error, ConnectionSimulatorConfig conf)
	{
		throw null;
	}

	// Token: 0x0600B213 RID: 45587 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Disconnect(int hostId, int connectionId, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B214 RID: 45588 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool DoesEndPointUsePlatformProtocols(EndPoint endPoint)
	{
		throw null;
	}

	// Token: 0x0600B215 RID: 45589 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetBroadcastConnectionInfo(int hostId, out string address, out int port, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B216 RID: 45590 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetBroadcastConnectionMessage(int hostId, byte[] buffer, int bufferSize, out int receivedSize, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B217 RID: 45591 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetConnectionInfo(int hostId, int connectionId, out string address, out int port, out NetworkID network, out NodeID dstNode, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B218 RID: 45592 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetCurrentRTT(int hostId, int connectionId, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B219 RID: 45593 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		throw null;
	}

	// Token: 0x0600B21A RID: 45594 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(GlobalConfig config)
	{
		throw null;
	}

	// Token: 0x0600B21B RID: 45595 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetworkEventType Receive(out int hostId, out int connectionId, out int channelId, byte[] buffer, int bufferSize, out int receivedSize, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B21C RID: 45596 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetworkEventType ReceiveFromHost(int hostId, out int connectionId, out int channelId, byte[] buffer, int bufferSize, out int receivedSize, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B21D RID: 45597 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetworkEventType ReceiveRelayEventFromHost(int hostId, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B21E RID: 45598 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool RemoveHost(int hostId)
	{
		throw null;
	}

	// Token: 0x0600B21F RID: 45599 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Send(int hostId, int connectionId, int channelId, byte[] buffer, int bufferSize, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B220 RID: 45600 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBroadcastCredentials(int hostId, int key, int version, int subversion, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B221 RID: 45601 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPacketStat(int direction, int packetStatId, int numMsgs, int numBytes)
	{
		throw null;
	}

	// Token: 0x0600B222 RID: 45602 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Shutdown()
	{
		throw null;
	}

	// Token: 0x0600B223 RID: 45603 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool StartBroadcastDiscovery(int hostId, int broadcastPort, int key, int version, int subversion, byte[] buffer, int size, int timeout, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B224 RID: 45604 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopBroadcastDiscovery()
	{
		throw null;
	}

	// Token: 0x0600B225 RID: 45605 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetRtt(int hostId, int connectionId, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B226 RID: 45606 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetLossPercent(int hostId, int connectionId, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B227 RID: 45607 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int GetLossCount(int hostId, int connectionId, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B228 RID: 45608 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct365 GetStatistics(int hostId, int connectionId)
	{
		throw null;
	}

	// Token: 0x0400B6B6 RID: 46774
	private static HandsControllerClass gclass2487_0;
}
