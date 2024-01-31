using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.KcpNetwork;
using UnityEngine.Networking;
using UnityEngine.Networking.Types;

// Token: 0x02002242 RID: 8770
public class HandsControllerClass
{
	// Token: 0x17001DFB RID: 7675
	// (get) Token: 0x0600B2D0 RID: 45776 RVA: 0x00002050 File Offset: 0x00000250
	private int Int32_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001DFC RID: 7676
	// (get) Token: 0x0600B2D1 RID: 45777 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsStarted
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600B2D2 RID: 45778 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EarlyUpdate()
	{
		throw null;
	}

	// Token: 0x0600B2D3 RID: 45779 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LateUpdate()
	{
		throw null;
	}

	// Token: 0x0600B2D4 RID: 45780 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_0(int index, out GClass2475 host, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B2D5 RID: 45781 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int AddHost(HostTopology topology, int port, string ip)
	{
		throw null;
	}

	// Token: 0x0600B2D6 RID: 45782 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool RemoveHost(int index)
	{
		throw null;
	}

	// Token: 0x0600B2D7 RID: 45783 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int Connect(int hostId, string address, int port, int specialConnectionId, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B2D8 RID: 45784 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Disconnect(int hostId, int connectionId, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B2D9 RID: 45785 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetConnectionInfo(int hostId, int connectionId, out string address, out int port, out NetworkID network, out NodeID dstNode, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B2DA RID: 45786 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetRtt(int hostId, int connectionId, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B2DB RID: 45787 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetLossPercent(int hostId, int connectionId, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B2DC RID: 45788 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetLossCount(int hostId, int connectionId, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B2DD RID: 45789 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NetworkEventType ReceiveFromHost(int hostId, out int connectionId, out int channelId, byte[] buffer, out int bufferSize, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B2DE RID: 45790 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Send(int hostId, int connectionId, int channelId, byte[] buffer, int bufferSize, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B2DF RID: 45791 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Shutdown()
	{
		throw null;
	}

	// Token: 0x0600B2E0 RID: 45792 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct365 GetStatistics(int hostId, int connectionId)
	{
		throw null;
	}

	// Token: 0x0400B761 RID: 46945
	private Dictionary<int, GClass2475> dictionary_0;

	// Token: 0x0400B762 RID: 46946
	private int int_0;

	// Token: 0x0400B763 RID: 46947
	private HandsControllerClass.Class1931 class1931_0;

	// Token: 0x02002243 RID: 8771
	private class Class1931
	{
		// Token: 0x0600B2E1 RID: 45793 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static NetworkChannel Convert(QosType value)
		{
			throw null;
		}

		// Token: 0x0600B2E2 RID: 45794 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static QosType Convert(NetworkChannel value)
		{
			throw null;
		}

		// Token: 0x0600B2E3 RID: 45795 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public NetworkChannel ConvertIdentifier(int outsideChannel)
		{
			throw null;
		}

		// Token: 0x0600B2E4 RID: 45796 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int ConvertIdentifier(NetworkChannel insideNetworkChannel)
		{
			throw null;
		}

		// Token: 0x0400B764 RID: 46948
		private List<QosType> list_0;

		// Token: 0x0400B765 RID: 46949
		private Dictionary<QosType, int> dictionary_0;
	}

	// Token: 0x02002244 RID: 8772
	private static class Class1932
	{
		// Token: 0x0600B2E5 RID: 45797 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static NetworkMessageType Convert(NetworkEventType value)
		{
			throw null;
		}

		// Token: 0x0600B2E6 RID: 45798 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static NetworkEventType Convert(NetworkMessageType value)
		{
			throw null;
		}
	}
}
