using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using FlyingWormConsole3.LiteNetLib;

// Token: 0x02001144 RID: 4420
internal sealed class Class830
{
	// Token: 0x17000E81 RID: 3713
	// (get) Token: 0x06005D0D RID: 23821 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06005D0E RID: 23822 RVA: 0x00002050 File Offset: 0x00000250
	public int LocalPort
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000E82 RID: 3714
	// (get) Token: 0x06005D0F RID: 23823 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06005D10 RID: 23824 RVA: 0x00002050 File Offset: 0x00000250
	public short Ttl
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

	// Token: 0x06005D11 RID: 23825 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_0()
	{
		throw null;
	}

	// Token: 0x06005D12 RID: 23826 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_1(SocketException ex, EndPoint bufferEndPoint)
	{
		throw null;
	}

	// Token: 0x06005D13 RID: 23827 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualReceive()
	{
		throw null;
	}

	// Token: 0x06005D14 RID: 23828 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_2(Socket socket, EndPoint bufferEndPoint)
	{
		throw null;
	}

	// Token: 0x06005D15 RID: 23829 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(object state)
	{
		throw null;
	}

	// Token: 0x06005D16 RID: 23830 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Bind(IPAddress addressIPv4, IPAddress addressIPv6, int port, bool reuseAddress, IPv6Mode ipv6Mode, bool manualMode)
	{
		throw null;
	}

	// Token: 0x06005D17 RID: 23831 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_4(Socket socket, IPEndPoint ep, bool reuseAddress, IPv6Mode ipv6Mode)
	{
		throw null;
	}

	// Token: 0x06005D18 RID: 23832 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SendBroadcast(byte[] data, int offset, int size, int port)
	{
		throw null;
	}

	// Token: 0x06005D19 RID: 23833 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int SendTo(byte[] data, int offset, int size, IPEndPoint remoteEndPoint, ref SocketError errorCode)
	{
		throw null;
	}

	// Token: 0x06005D1A RID: 23834 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Close(bool suspend)
	{
		throw null;
	}

	// Token: 0x04006897 RID: 26775
	public const int ReceivePollingTime = 500000;

	// Token: 0x04006898 RID: 26776
	private Socket socket_0;

	// Token: 0x04006899 RID: 26777
	private Socket socket_1;

	// Token: 0x0400689A RID: 26778
	private Thread thread_0;

	// Token: 0x0400689B RID: 26779
	private Thread thread_1;

	// Token: 0x0400689C RID: 26780
	private IPEndPoint ipendPoint_0;

	// Token: 0x0400689D RID: 26781
	private IPEndPoint ipendPoint_1;

	// Token: 0x0400689E RID: 26782
	private readonly GClass1278 gclass1278_0;

	// Token: 0x0400689F RID: 26783
	private const int int_0 = -1744830452;

	// Token: 0x040068A0 RID: 26784
	private static readonly IPAddress ipaddress_0;

	// Token: 0x040068A1 RID: 26785
	internal static readonly bool bool_0;

	// Token: 0x040068A2 RID: 26786
	[CompilerGenerated]
	private int int_1;

	// Token: 0x040068A3 RID: 26787
	public volatile bool IsRunning;
}
