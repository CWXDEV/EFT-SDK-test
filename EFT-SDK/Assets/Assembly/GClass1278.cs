using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using FlyingWormConsole3.LiteNetLib;

// Token: 0x02001136 RID: 4406
public class GClass1278 : IEnumerable, IEnumerable<GClass1279>
{
	// Token: 0x17000E67 RID: 3687
	// (get) Token: 0x06005C6C RID: 23660 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsRunning
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000E68 RID: 3688
	// (get) Token: 0x06005C6D RID: 23661 RVA: 0x00002050 File Offset: 0x00000250
	public int LocalPort
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000E69 RID: 3689
	// (get) Token: 0x06005C6E RID: 23662 RVA: 0x00002050 File Offset: 0x00000250
	public GClass1279 FirstPeer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000E6A RID: 3690
	// (get) Token: 0x06005C6F RID: 23663 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06005C70 RID: 23664 RVA: 0x00002050 File Offset: 0x00000250
	public byte ChannelsCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000E6B RID: 3691
	// (get) Token: 0x06005C71 RID: 23665 RVA: 0x00002050 File Offset: 0x00000250
	public List<GClass1279> ConnectedPeerList
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06005C72 RID: 23666 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass1279 GetPeerById(int id)
	{
		throw null;
	}

	// Token: 0x17000E6C RID: 3692
	// (get) Token: 0x06005C73 RID: 23667 RVA: 0x00002050 File Offset: 0x00000250
	public int ConnectedPeersCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000E6D RID: 3693
	// (get) Token: 0x06005C74 RID: 23668 RVA: 0x00002050 File Offset: 0x00000250
	public int ExtraPacketSizeForLayer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06005C75 RID: 23669 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_0(IPEndPoint endPoint, out GClass1279 peer)
	{
		throw null;
	}

	// Token: 0x06005C76 RID: 23670 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(GClass1279 peer)
	{
		throw null;
	}

	// Token: 0x06005C77 RID: 23671 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(GClass1279 peer)
	{
		throw null;
	}

	// Token: 0x06005C78 RID: 23672 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(GClass1279 peer)
	{
		throw null;
	}

	// Token: 0x06005C79 RID: 23673 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_4(GClass1279 fromPeer, int latency)
	{
		throw null;
	}

	// Token: 0x06005C7A RID: 23674 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_5(GClass1279 fromPeer, object userData)
	{
		throw null;
	}

	// Token: 0x06005C7B RID: 23675 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int method_6(Class825 packet, IPEndPoint remoteEndPoint)
	{
		throw null;
	}

	// Token: 0x06005C7C RID: 23676 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int method_7(Class825 packet, IPEndPoint remoteEndPoint)
	{
		throw null;
	}

	// Token: 0x06005C7D RID: 23677 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int method_8(byte[] message, int start, int length, IPEndPoint remoteEndPoint)
	{
		throw null;
	}

	// Token: 0x06005C7E RID: 23678 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_9(GClass1279 peer, DisconnectReason reason, SocketError socketErrorCode, Class825 eventData)
	{
		throw null;
	}

	// Token: 0x06005C7F RID: 23679 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_10(GClass1279 peer, DisconnectReason reason, SocketError socketErrorCode, bool force, byte[] data, int start, int count, Class825 eventData)
	{
		throw null;
	}

	// Token: 0x06005C80 RID: 23680 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_11(Class823.EType type, GClass1279 peer = null, IPEndPoint remoteEndPoint = null, SocketError errorCode = SocketError.Success, int latency = 0, DisconnectReason disconnectReason = DisconnectReason.ConnectionFailed, GClass1272 connectionRequest = null, DeliveryMethod deliveryMethod = DeliveryMethod.Unreliable, Class825 readerSource = null, object userData = null)
	{
		throw null;
	}

	// Token: 0x06005C81 RID: 23681 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_12(Class823 evt)
	{
		throw null;
	}

	// Token: 0x06005C82 RID: 23682 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_13(Class823 evt)
	{
		throw null;
	}

	// Token: 0x06005C83 RID: 23683 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_14()
	{
		throw null;
	}

	// Token: 0x06005C84 RID: 23684 RVA: 0x00002050 File Offset: 0x00000250
	[Conditional("DEBUG")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_15()
	{
		throw null;
	}

	// Token: 0x06005C85 RID: 23685 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_16(int elapsedMilliseconds)
	{
		throw null;
	}

	// Token: 0x06005C86 RID: 23686 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate(int elapsedMilliseconds)
	{
		throw null;
	}

	// Token: 0x06005C87 RID: 23687 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualReceive()
	{
		throw null;
	}

	// Token: 0x06005C88 RID: 23688 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_17(Class825 packet, SocketError errorCode, IPEndPoint remoteEndPoint)
	{
		throw null;
	}

	// Token: 0x06005C89 RID: 23689 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal GClass1279 method_18(GClass1272 request, byte[] rejectData, int start, int length)
	{
		throw null;
	}

	// Token: 0x06005C8A RID: 23690 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int method_19()
	{
		throw null;
	}

	// Token: 0x06005C8B RID: 23691 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_20(IPEndPoint remoteEndPoint, GClass1279 netPeer, Class826 connRequest)
	{
		throw null;
	}

	// Token: 0x06005C8C RID: 23692 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_21(Class825 packet, IPEndPoint remoteEndPoint)
	{
		throw null;
	}

	// Token: 0x06005C8D RID: 23693 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_22(Class825 packet, DeliveryMethod method, int headerSize, GClass1279 fromPeer)
	{
		throw null;
	}

	// Token: 0x06005C8E RID: 23694 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendToAll(GClass1286 writer, DeliveryMethod options)
	{
		throw null;
	}

	// Token: 0x06005C8F RID: 23695 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendToAll(byte[] data, DeliveryMethod options)
	{
		throw null;
	}

	// Token: 0x06005C90 RID: 23696 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendToAll(byte[] data, int start, int length, DeliveryMethod options)
	{
		throw null;
	}

	// Token: 0x06005C91 RID: 23697 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendToAll(GClass1286 writer, byte channelNumber, DeliveryMethod options)
	{
		throw null;
	}

	// Token: 0x06005C92 RID: 23698 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendToAll(byte[] data, byte channelNumber, DeliveryMethod options)
	{
		throw null;
	}

	// Token: 0x06005C93 RID: 23699 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendToAll(byte[] data, int start, int length, byte channelNumber, DeliveryMethod options)
	{
		throw null;
	}

	// Token: 0x06005C94 RID: 23700 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendToAll(GClass1286 writer, DeliveryMethod options, GClass1279 excludePeer)
	{
		throw null;
	}

	// Token: 0x06005C95 RID: 23701 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendToAll(byte[] data, DeliveryMethod options, GClass1279 excludePeer)
	{
		throw null;
	}

	// Token: 0x06005C96 RID: 23702 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendToAll(byte[] data, int start, int length, DeliveryMethod options, GClass1279 excludePeer)
	{
		throw null;
	}

	// Token: 0x06005C97 RID: 23703 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendToAll(GClass1286 writer, byte channelNumber, DeliveryMethod options, GClass1279 excludePeer)
	{
		throw null;
	}

	// Token: 0x06005C98 RID: 23704 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendToAll(byte[] data, byte channelNumber, DeliveryMethod options, GClass1279 excludePeer)
	{
		throw null;
	}

	// Token: 0x06005C99 RID: 23705 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendToAll(byte[] data, int start, int length, byte channelNumber, DeliveryMethod options, GClass1279 excludePeer)
	{
		throw null;
	}

	// Token: 0x06005C9A RID: 23706 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Start()
	{
		throw null;
	}

	// Token: 0x06005C9B RID: 23707 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port)
	{
		throw null;
	}

	// Token: 0x06005C9C RID: 23708 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Start(string addressIPv4, string addressIPv6, int port)
	{
		throw null;
	}

	// Token: 0x06005C9D RID: 23709 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Start(int port)
	{
		throw null;
	}

	// Token: 0x06005C9E RID: 23710 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool StartInManualMode(IPAddress addressIPv4, IPAddress addressIPv6, int port)
	{
		throw null;
	}

	// Token: 0x06005C9F RID: 23711 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool StartInManualMode(string addressIPv4, string addressIPv6, int port)
	{
		throw null;
	}

	// Token: 0x06005CA0 RID: 23712 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool StartInManualMode(int port)
	{
		throw null;
	}

	// Token: 0x06005CA1 RID: 23713 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SendUnconnectedMessage(byte[] message, IPEndPoint remoteEndPoint)
	{
		throw null;
	}

	// Token: 0x06005CA2 RID: 23714 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SendUnconnectedMessage(GClass1286 writer, IPEndPoint remoteEndPoint)
	{
		throw null;
	}

	// Token: 0x06005CA3 RID: 23715 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SendUnconnectedMessage(byte[] message, int start, int length, IPEndPoint remoteEndPoint)
	{
		throw null;
	}

	// Token: 0x06005CA4 RID: 23716 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SendBroadcast(GClass1286 writer, int port)
	{
		throw null;
	}

	// Token: 0x06005CA5 RID: 23717 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SendBroadcast(byte[] data, int port)
	{
		throw null;
	}

	// Token: 0x06005CA6 RID: 23718 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SendBroadcast(byte[] data, int start, int length, int port)
	{
		throw null;
	}

	// Token: 0x06005CA7 RID: 23719 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TriggerUpdate()
	{
		throw null;
	}

	// Token: 0x06005CA8 RID: 23720 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PollEvents()
	{
		throw null;
	}

	// Token: 0x06005CA9 RID: 23721 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass1279 Connect(string address, int port, string key)
	{
		throw null;
	}

	// Token: 0x06005CAA RID: 23722 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass1279 Connect(string address, int port, GClass1286 connectionData)
	{
		throw null;
	}

	// Token: 0x06005CAB RID: 23723 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass1279 Connect(IPEndPoint target, string key)
	{
		throw null;
	}

	// Token: 0x06005CAC RID: 23724 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass1279 Connect(IPEndPoint target, GClass1286 connectionData)
	{
		throw null;
	}

	// Token: 0x06005CAD RID: 23725 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Stop()
	{
		throw null;
	}

	// Token: 0x06005CAE RID: 23726 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Stop(bool sendDisconnectMessages)
	{
		throw null;
	}

	// Token: 0x06005CAF RID: 23727 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetPeersCount(ConnectionState peerState)
	{
		throw null;
	}

	// Token: 0x06005CB0 RID: 23728 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetPeersNonAlloc(List<GClass1279> peers, ConnectionState peerState)
	{
		throw null;
	}

	// Token: 0x06005CB1 RID: 23729 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisconnectAll()
	{
		throw null;
	}

	// Token: 0x06005CB2 RID: 23730 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisconnectAll(byte[] data, int start, int count)
	{
		throw null;
	}

	// Token: 0x06005CB3 RID: 23731 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisconnectPeerForce(GClass1279 peer)
	{
		throw null;
	}

	// Token: 0x06005CB4 RID: 23732 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisconnectPeer(GClass1279 peer)
	{
		throw null;
	}

	// Token: 0x06005CB5 RID: 23733 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisconnectPeer(GClass1279 peer, byte[] data)
	{
		throw null;
	}

	// Token: 0x06005CB6 RID: 23734 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisconnectPeer(GClass1279 peer, GClass1286 writer)
	{
		throw null;
	}

	// Token: 0x06005CB7 RID: 23735 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisconnectPeer(GClass1279 peer, byte[] data, int start, int count)
	{
		throw null;
	}

	// Token: 0x06005CB8 RID: 23736 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateNtpRequest(IPEndPoint endPoint)
	{
		throw null;
	}

	// Token: 0x06005CB9 RID: 23737 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateNtpRequest(string ntpServerAddress, int port)
	{
		throw null;
	}

	// Token: 0x06005CBA RID: 23738 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateNtpRequest(string ntpServerAddress)
	{
		throw null;
	}

	// Token: 0x06005CBB RID: 23739 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator<GClass1279> GetEnumerator()
	{
		throw null;
	}

	// Token: 0x06005CBC RID: 23740 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		throw null;
	}

	// Token: 0x040067FA RID: 26618
	private readonly Class830 class830_0;

	// Token: 0x040067FB RID: 26619
	private Thread thread_0;

	// Token: 0x040067FC RID: 26620
	private bool bool_0;

	// Token: 0x040067FD RID: 26621
	private readonly AutoResetEvent autoResetEvent_0;

	// Token: 0x040067FE RID: 26622
	private readonly Queue<Class823> queue_0;

	// Token: 0x040067FF RID: 26623
	private Class823 class823_0;

	// Token: 0x04006800 RID: 26624
	private readonly GInterface88 ginterface88_0;

	// Token: 0x04006801 RID: 26625
	private readonly GInterface89 ginterface89_0;

	// Token: 0x04006802 RID: 26626
	private readonly GInterface90 ginterface90_0;

	// Token: 0x04006803 RID: 26627
	private readonly Dictionary<IPEndPoint, GClass1279> dictionary_0;

	// Token: 0x04006804 RID: 26628
	private readonly Dictionary<IPEndPoint, GClass1272> dictionary_1;

	// Token: 0x04006805 RID: 26629
	private readonly Dictionary<IPEndPoint, Class867> dictionary_2;

	// Token: 0x04006806 RID: 26630
	private readonly ReaderWriterLockSlim readerWriterLockSlim_0;

	// Token: 0x04006807 RID: 26631
	private volatile GClass1279 gclass1279_0;

	// Token: 0x04006808 RID: 26632
	private volatile int int_0;

	// Token: 0x04006809 RID: 26633
	private readonly List<GClass1279> list_0;

	// Token: 0x0400680A RID: 26634
	private GClass1279[] gclass1279_1;

	// Token: 0x0400680B RID: 26635
	private readonly GClass1290 gclass1290_0;

	// Token: 0x0400680C RID: 26636
	private int int_1;

	// Token: 0x0400680D RID: 26637
	private readonly Queue<int> queue_1;

	// Token: 0x0400680E RID: 26638
	private byte byte_0;

	// Token: 0x0400680F RID: 26639
	private readonly object object_0;

	// Token: 0x04006810 RID: 26640
	internal readonly Class828 class828_0;

	// Token: 0x04006811 RID: 26641
	public bool UnconnectedMessagesEnabled;

	// Token: 0x04006812 RID: 26642
	public bool NatPunchEnabled;

	// Token: 0x04006813 RID: 26643
	public int UpdateTime;

	// Token: 0x04006814 RID: 26644
	public int PingInterval;

	// Token: 0x04006815 RID: 26645
	public int DisconnectTimeout;

	// Token: 0x04006816 RID: 26646
	public bool SimulatePacketLoss;

	// Token: 0x04006817 RID: 26647
	public bool SimulateLatency;

	// Token: 0x04006818 RID: 26648
	public int SimulationPacketLossChance;

	// Token: 0x04006819 RID: 26649
	public int SimulationMinLatency;

	// Token: 0x0400681A RID: 26650
	public int SimulationMaxLatency;

	// Token: 0x0400681B RID: 26651
	public bool UnsyncedEvents;

	// Token: 0x0400681C RID: 26652
	public bool UnsyncedReceiveEvent;

	// Token: 0x0400681D RID: 26653
	public bool UnsyncedDeliveryEvent;

	// Token: 0x0400681E RID: 26654
	public bool BroadcastReceiveEnabled;

	// Token: 0x0400681F RID: 26655
	public int ReconnectDelay;

	// Token: 0x04006820 RID: 26656
	public int MaxConnectAttempts;

	// Token: 0x04006821 RID: 26657
	public bool ReuseAddress;

	// Token: 0x04006822 RID: 26658
	public readonly GClass1280 Statistics;

	// Token: 0x04006823 RID: 26659
	public bool EnableStatistics;

	// Token: 0x04006824 RID: 26660
	public readonly GClass1275 NatPunchModule;

	// Token: 0x04006825 RID: 26661
	public bool AutoRecycle;

	// Token: 0x04006826 RID: 26662
	public IPv6Mode IPv6Enabled;

	// Token: 0x04006827 RID: 26663
	public int MtuOverride;

	// Token: 0x04006828 RID: 26664
	public bool UseSafeMtu;

	// Token: 0x04006829 RID: 26665
	public bool DisconnectOnUnreachable;

	// Token: 0x02001137 RID: 4407
	private class Class824 : IEqualityComparer<IPEndPoint>
	{
		// Token: 0x06005CBD RID: 23741 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(IPEndPoint x, IPEndPoint y)
		{
			throw null;
		}

		// Token: 0x06005CBE RID: 23742 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetHashCode(IPEndPoint obj)
		{
			throw null;
		}
	}

	// Token: 0x02001138 RID: 4408
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct114 : IEnumerator, IDisposable, IEnumerator<GClass1279>
	{
		// Token: 0x06005CBF RID: 23743 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x06005CC0 RID: 23744 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool MoveNext()
		{
			throw null;
		}

		// Token: 0x06005CC1 RID: 23745 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x06005CC2 RID: 23746 RVA: 0x00002050 File Offset: 0x00000250
		public GClass1279 Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x06005CC3 RID: 23747 RVA: 0x00002050 File Offset: 0x00000250
		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400682A RID: 26666
		private readonly GClass1279 gclass1279_0;

		// Token: 0x0400682B RID: 26667
		private GClass1279 gclass1279_1;
	}
}
