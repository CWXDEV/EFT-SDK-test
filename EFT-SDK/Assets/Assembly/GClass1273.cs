using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using FlyingWormConsole3.LiteNetLib;

// Token: 0x02001116 RID: 4374
public class GClass1273 : GInterface88, GInterface89, GInterface90
{
	// Token: 0x140000FA RID: 250
	// (add) Token: 0x06005BFD RID: 23549 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06005BFE RID: 23550 RVA: 0x00002050 File Offset: 0x00000250
	public event GClass1273.GDelegate43 PeerConnectedEvent
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x140000FB RID: 251
	// (add) Token: 0x06005BFF RID: 23551 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06005C00 RID: 23552 RVA: 0x00002050 File Offset: 0x00000250
	public event GClass1273.GDelegate44 PeerDisconnectedEvent
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x140000FC RID: 252
	// (add) Token: 0x06005C01 RID: 23553 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06005C02 RID: 23554 RVA: 0x00002050 File Offset: 0x00000250
	public event GClass1273.GDelegate45 NetworkErrorEvent
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x140000FD RID: 253
	// (add) Token: 0x06005C03 RID: 23555 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06005C04 RID: 23556 RVA: 0x00002050 File Offset: 0x00000250
	public event GClass1273.GDelegate46 NetworkReceiveEvent
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x140000FE RID: 254
	// (add) Token: 0x06005C05 RID: 23557 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06005C06 RID: 23558 RVA: 0x00002050 File Offset: 0x00000250
	public event GClass1273.GDelegate47 NetworkReceiveUnconnectedEvent
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x140000FF RID: 255
	// (add) Token: 0x06005C07 RID: 23559 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06005C08 RID: 23560 RVA: 0x00002050 File Offset: 0x00000250
	public event GClass1273.GDelegate48 NetworkLatencyUpdateEvent
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x14000100 RID: 256
	// (add) Token: 0x06005C09 RID: 23561 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06005C0A RID: 23562 RVA: 0x00002050 File Offset: 0x00000250
	public event GClass1273.GDelegate49 ConnectionRequestEvent
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x14000101 RID: 257
	// (add) Token: 0x06005C0B RID: 23563 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06005C0C RID: 23564 RVA: 0x00002050 File Offset: 0x00000250
	public event GClass1273.GDelegate50 DeliveryEvent
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x14000102 RID: 258
	// (add) Token: 0x06005C0D RID: 23565 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06005C0E RID: 23566 RVA: 0x00002050 File Offset: 0x00000250
	public event GClass1273.GDelegate51 NtpResponseEvent
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x06005C0F RID: 23567 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearPeerConnectedEvent()
	{
		throw null;
	}

	// Token: 0x06005C10 RID: 23568 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearPeerDisconnectedEvent()
	{
		throw null;
	}

	// Token: 0x06005C11 RID: 23569 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearNetworkErrorEvent()
	{
		throw null;
	}

	// Token: 0x06005C12 RID: 23570 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearNetworkReceiveEvent()
	{
		throw null;
	}

	// Token: 0x06005C13 RID: 23571 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearNetworkReceiveUnconnectedEvent()
	{
		throw null;
	}

	// Token: 0x06005C14 RID: 23572 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearNetworkLatencyUpdateEvent()
	{
		throw null;
	}

	// Token: 0x06005C15 RID: 23573 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearConnectionRequestEvent()
	{
		throw null;
	}

	// Token: 0x06005C16 RID: 23574 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearDeliveryEvent()
	{
		throw null;
	}

	// Token: 0x06005C17 RID: 23575 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearNtpResponseEvent()
	{
		throw null;
	}

	// Token: 0x06005C18 RID: 23576 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface88.OnPeerConnected(GClass1279 peer)
	{
		throw null;
	}

	// Token: 0x06005C19 RID: 23577 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface88.OnPeerDisconnected(GClass1279 peer, GStruct113 disconnectInfo)
	{
		throw null;
	}

	// Token: 0x06005C1A RID: 23578 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface88.OnNetworkError(IPEndPoint endPoint, SocketError socketErrorCode)
	{
		throw null;
	}

	// Token: 0x06005C1B RID: 23579 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface88.OnNetworkReceive(GClass1279 peer, GClass1285 reader, DeliveryMethod deliveryMethod)
	{
		throw null;
	}

	// Token: 0x06005C1C RID: 23580 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface88.OnNetworkReceiveUnconnected(IPEndPoint remoteEndPoint, GClass1285 reader, UnconnectedMessageType messageType)
	{
		throw null;
	}

	// Token: 0x06005C1D RID: 23581 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface88.OnNetworkLatencyUpdate(GClass1279 peer, int latency)
	{
		throw null;
	}

	// Token: 0x06005C1E RID: 23582 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface88.OnConnectionRequest(GClass1272 request)
	{
		throw null;
	}

	// Token: 0x06005C1F RID: 23583 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface89.OnMessageDelivered(GClass1279 peer, object userData)
	{
		throw null;
	}

	// Token: 0x06005C20 RID: 23584 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface90.OnNtpResponse(GClass1289 packet)
	{
		throw null;
	}

	// Token: 0x0400679F RID: 26527
	[CompilerGenerated]
	private GClass1273.GDelegate43 gdelegate43_0;

	// Token: 0x040067A0 RID: 26528
	[CompilerGenerated]
	private GClass1273.GDelegate44 gdelegate44_0;

	// Token: 0x040067A1 RID: 26529
	[CompilerGenerated]
	private GClass1273.GDelegate45 gdelegate45_0;

	// Token: 0x040067A2 RID: 26530
	[CompilerGenerated]
	private GClass1273.GDelegate46 gdelegate46_0;

	// Token: 0x040067A3 RID: 26531
	[CompilerGenerated]
	private GClass1273.GDelegate47 gdelegate47_0;

	// Token: 0x040067A4 RID: 26532
	[CompilerGenerated]
	private GClass1273.GDelegate48 gdelegate48_0;

	// Token: 0x040067A5 RID: 26533
	[CompilerGenerated]
	private GClass1273.GDelegate49 gdelegate49_0;

	// Token: 0x040067A6 RID: 26534
	[CompilerGenerated]
	private GClass1273.GDelegate50 gdelegate50_0;

	// Token: 0x040067A7 RID: 26535
	[CompilerGenerated]
	private GClass1273.GDelegate51 gdelegate51_0;

	// Token: 0x02001117 RID: 4375
	// (Invoke) Token: 0x06005C21 RID: 23585
	public delegate void GDelegate43(GClass1279 peer);

	// Token: 0x02001118 RID: 4376
	// (Invoke) Token: 0x06005C24 RID: 23588
	public delegate void GDelegate44(GClass1279 peer, GStruct113 disconnectInfo);

	// Token: 0x02001119 RID: 4377
	// (Invoke) Token: 0x06005C27 RID: 23591
	public delegate void GDelegate45(IPEndPoint endPoint, SocketError socketError);

	// Token: 0x0200111A RID: 4378
	// (Invoke) Token: 0x06005C2A RID: 23594
	public delegate void GDelegate46(GClass1279 peer, GClass1285 reader, DeliveryMethod deliveryMethod);

	// Token: 0x0200111B RID: 4379
	// (Invoke) Token: 0x06005C2D RID: 23597
	public delegate void GDelegate47(IPEndPoint remoteEndPoint, GClass1285 reader, UnconnectedMessageType messageType);

	// Token: 0x0200111C RID: 4380
	// (Invoke) Token: 0x06005C30 RID: 23600
	public delegate void GDelegate48(GClass1279 peer, int latency);

	// Token: 0x0200111D RID: 4381
	// (Invoke) Token: 0x06005C33 RID: 23603
	public delegate void GDelegate49(GClass1272 request);

	// Token: 0x0200111E RID: 4382
	// (Invoke) Token: 0x06005C36 RID: 23606
	public delegate void GDelegate50(GClass1279 peer, object userData);

	// Token: 0x0200111F RID: 4383
	// (Invoke) Token: 0x06005C39 RID: 23609
	public delegate void GDelegate51(GClass1289 packet);
}
