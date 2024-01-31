using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using FlyingWormConsole3.LiteNetLib;

// Token: 0x02001142 RID: 4418
public class GClass1279
{
	// Token: 0x17000E78 RID: 3704
	// (get) Token: 0x06005CE1 RID: 23777 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06005CE2 RID: 23778 RVA: 0x00002050 File Offset: 0x00000250
	internal byte Byte_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000E79 RID: 3705
	// (get) Token: 0x06005CE3 RID: 23779 RVA: 0x00002050 File Offset: 0x00000250
	public ConnectionState ConnectionState
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000E7A RID: 3706
	// (get) Token: 0x06005CE4 RID: 23780 RVA: 0x00002050 File Offset: 0x00000250
	internal long Int64_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000E7B RID: 3707
	// (get) Token: 0x06005CE5 RID: 23781 RVA: 0x00002050 File Offset: 0x00000250
	public int Ping
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000E7C RID: 3708
	// (get) Token: 0x06005CE6 RID: 23782 RVA: 0x00002050 File Offset: 0x00000250
	public int Mtu
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000E7D RID: 3709
	// (get) Token: 0x06005CE7 RID: 23783 RVA: 0x00002050 File Offset: 0x00000250
	public long RemoteTimeDelta
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000E7E RID: 3710
	// (get) Token: 0x06005CE8 RID: 23784 RVA: 0x00002050 File Offset: 0x00000250
	public DateTime RemoteUtcTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000E7F RID: 3711
	// (get) Token: 0x06005CE9 RID: 23785 RVA: 0x00002050 File Offset: 0x00000250
	public int TimeSinceLastPacket
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000E80 RID: 3712
	// (get) Token: 0x06005CEA RID: 23786 RVA: 0x00002050 File Offset: 0x00000250
	internal double Double_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06005CEB RID: 23787 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(int mtuIdx)
	{
		throw null;
	}

	// Token: 0x06005CEC RID: 23788 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(int mtuValue)
	{
		throw null;
	}

	// Token: 0x06005CED RID: 23789 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetPacketsCountInReliableQueue(byte channelNumber, bool ordered)
	{
		throw null;
	}

	// Token: 0x06005CEE RID: 23790 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Class817 method_2(byte idx)
	{
		throw null;
	}

	// Token: 0x06005CEF RID: 23791 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_3(long connectionId, byte connectionNumber, byte[] data, int start, int length)
	{
		throw null;
	}

	// Token: 0x06005CF0 RID: 23792 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal bool method_4(Class827 packet)
	{
		throw null;
	}

	// Token: 0x06005CF1 RID: 23793 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetMaxSinglePacketSize(DeliveryMethod options)
	{
		throw null;
	}

	// Token: 0x06005CF2 RID: 23794 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendWithDeliveryEvent(byte[] data, byte channelNumber, DeliveryMethod deliveryMethod, object userData)
	{
		throw null;
	}

	// Token: 0x06005CF3 RID: 23795 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendWithDeliveryEvent(byte[] data, int start, int length, byte channelNumber, DeliveryMethod deliveryMethod, object userData)
	{
		throw null;
	}

	// Token: 0x06005CF4 RID: 23796 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SendWithDeliveryEvent(GClass1286 dataWriter, byte channelNumber, DeliveryMethod deliveryMethod, object userData)
	{
		throw null;
	}

	// Token: 0x06005CF5 RID: 23797 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Send(byte[] data, DeliveryMethod deliveryMethod)
	{
		throw null;
	}

	// Token: 0x06005CF6 RID: 23798 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Send(GClass1286 dataWriter, DeliveryMethod deliveryMethod)
	{
		throw null;
	}

	// Token: 0x06005CF7 RID: 23799 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Send(byte[] data, int start, int length, DeliveryMethod options)
	{
		throw null;
	}

	// Token: 0x06005CF8 RID: 23800 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Send(byte[] data, byte channelNumber, DeliveryMethod deliveryMethod)
	{
		throw null;
	}

	// Token: 0x06005CF9 RID: 23801 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Send(GClass1286 dataWriter, byte channelNumber, DeliveryMethod deliveryMethod)
	{
		throw null;
	}

	// Token: 0x06005CFA RID: 23802 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Send(byte[] data, int start, int length, byte channelNumber, DeliveryMethod deliveryMethod)
	{
		throw null;
	}

	// Token: 0x06005CFB RID: 23803 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(byte[] data, int start, int length, byte channelNumber, DeliveryMethod deliveryMethod, object userData)
	{
		throw null;
	}

	// Token: 0x06005CFC RID: 23804 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Disconnect(byte[] data)
	{
		throw null;
	}

	// Token: 0x06005CFD RID: 23805 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Disconnect(GClass1286 writer)
	{
		throw null;
	}

	// Token: 0x06005CFE RID: 23806 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Disconnect(byte[] data, int start, int count)
	{
		throw null;
	}

	// Token: 0x06005CFF RID: 23807 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Disconnect()
	{
		throw null;
	}

	// Token: 0x06005D00 RID: 23808 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal DisconnectResult method_6(Class825 packet)
	{
		throw null;
	}

	// Token: 0x06005D01 RID: 23809 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_7(Class817 channel)
	{
		throw null;
	}

	// Token: 0x06005D02 RID: 23810 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ShutdownResult method_8(byte[] data, int start, int length, bool force)
	{
		throw null;
	}

	// Token: 0x06005D03 RID: 23811 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_9(int roundTripTime)
	{
		throw null;
	}

	// Token: 0x06005D04 RID: 23812 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_10(DeliveryMethod method, Class825 p)
	{
		throw null;
	}

	// Token: 0x06005D05 RID: 23813 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_11(Class825 packet)
	{
		throw null;
	}

	// Token: 0x06005D06 RID: 23814 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_12(int deltaTime)
	{
		throw null;
	}

	// Token: 0x06005D07 RID: 23815 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal ConnectRequestResult method_13(Class826 connRequest)
	{
		throw null;
	}

	// Token: 0x06005D08 RID: 23816 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_14(Class825 packet)
	{
		throw null;
	}

	// Token: 0x06005D09 RID: 23817 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_15()
	{
		throw null;
	}

	// Token: 0x06005D0A RID: 23818 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_16(Class825 packet)
	{
		throw null;
	}

	// Token: 0x06005D0B RID: 23819 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void Update(int deltaTime)
	{
		throw null;
	}

	// Token: 0x06005D0C RID: 23820 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_17(Class825 packet)
	{
		throw null;
	}

	// Token: 0x04006864 RID: 26724
	private int int_0;

	// Token: 0x04006865 RID: 26725
	private int int_1;

	// Token: 0x04006866 RID: 26726
	private int int_2;

	// Token: 0x04006867 RID: 26727
	private double double_0;

	// Token: 0x04006868 RID: 26728
	private int int_3;

	// Token: 0x04006869 RID: 26729
	private int int_4;

	// Token: 0x0400686A RID: 26730
	private readonly Stopwatch stopwatch_0;

	// Token: 0x0400686B RID: 26731
	private int int_5;

	// Token: 0x0400686C RID: 26732
	private long long_0;

	// Token: 0x0400686D RID: 26733
	private readonly Class828 class828_0;

	// Token: 0x0400686E RID: 26734
	private readonly object object_0;

	// Token: 0x0400686F RID: 26735
	internal volatile GClass1279 gclass1279_0;

	// Token: 0x04006870 RID: 26736
	internal GClass1279 gclass1279_1;

	// Token: 0x04006871 RID: 26737
	private readonly Queue<Class825> queue_0;

	// Token: 0x04006872 RID: 26738
	private readonly Queue<Class817> queue_1;

	// Token: 0x04006873 RID: 26739
	private readonly Class817[] class817_0;

	// Token: 0x04006874 RID: 26740
	private int int_6;

	// Token: 0x04006875 RID: 26741
	private int int_7;

	// Token: 0x04006876 RID: 26742
	private bool bool_0;

	// Token: 0x04006877 RID: 26743
	private int int_8;

	// Token: 0x04006878 RID: 26744
	private int int_9;

	// Token: 0x04006879 RID: 26745
	private const int int_10 = 1000;

	// Token: 0x0400687A RID: 26746
	private const int int_11 = 4;

	// Token: 0x0400687B RID: 26747
	private readonly object object_1;

	// Token: 0x0400687C RID: 26748
	private int int_12;

	// Token: 0x0400687D RID: 26749
	private readonly Dictionary<ushort, GClass1279.Class829> dictionary_0;

	// Token: 0x0400687E RID: 26750
	private readonly Dictionary<ushort, ushort> dictionary_1;

	// Token: 0x0400687F RID: 26751
	private readonly Class825 class825_0;

	// Token: 0x04006880 RID: 26752
	private int int_13;

	// Token: 0x04006881 RID: 26753
	private int int_14;

	// Token: 0x04006882 RID: 26754
	private int int_15;

	// Token: 0x04006883 RID: 26755
	private int int_16;

	// Token: 0x04006884 RID: 26756
	private long long_1;

	// Token: 0x04006885 RID: 26757
	private byte byte_0;

	// Token: 0x04006886 RID: 26758
	private ConnectionState connectionState_0;

	// Token: 0x04006887 RID: 26759
	private Class825 class825_1;

	// Token: 0x04006888 RID: 26760
	private const int int_17 = 300;

	// Token: 0x04006889 RID: 26761
	private int int_18;

	// Token: 0x0400688A RID: 26762
	private readonly Class825 class825_2;

	// Token: 0x0400688B RID: 26763
	private readonly Class825 class825_3;

	// Token: 0x0400688C RID: 26764
	private readonly Class825 class825_4;

	// Token: 0x0400688D RID: 26765
	private readonly Class825 class825_5;

	// Token: 0x0400688E RID: 26766
	public readonly IPEndPoint EndPoint;

	// Token: 0x0400688F RID: 26767
	public readonly GClass1278 NetManager;

	// Token: 0x04006890 RID: 26768
	public readonly int Id;

	// Token: 0x04006891 RID: 26769
	public object Tag;

	// Token: 0x04006892 RID: 26770
	public readonly GClass1280 Statistics;

	// Token: 0x02001143 RID: 4419
	private class Class829
	{
		// Token: 0x04006893 RID: 26771
		public Class825[] Fragments;

		// Token: 0x04006894 RID: 26772
		public int ReceivedCount;

		// Token: 0x04006895 RID: 26773
		public int TotalSize;

		// Token: 0x04006896 RID: 26774
		public byte ChannelId;
	}
}
