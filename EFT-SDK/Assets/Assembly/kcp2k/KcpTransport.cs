using System;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;

namespace kcp2k
{
	// Token: 0x02000F16 RID: 3862
	[HelpURL("https://mirror-networking.gitbook.io/docs/transports/kcp-transport")]
	[DisallowMultipleComponent]
	public class KcpTransport : Transport
	{
		// Token: 0x060050C3 RID: 20675 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int smethod_0(KcpChannel channel)
		{
			throw null;
		}

		// Token: 0x060050C4 RID: 20676 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static KcpChannel smethod_1(int channel)
		{
			throw null;
		}

		// Token: 0x060050C5 RID: 20677 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private TransportError method_0(ErrorCode error)
		{
			throw null;
		}

		// Token: 0x060050C6 RID: 20678 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x060050C7 RID: 20679 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnValidate()
		{
			throw null;
		}

		// Token: 0x060050C8 RID: 20680 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Available()
		{
			throw null;
		}

		// Token: 0x060050C9 RID: 20681 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ClientConnected()
		{
			throw null;
		}

		// Token: 0x060050CA RID: 20682 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ClientConnect(string address)
		{
			throw null;
		}

		// Token: 0x060050CB RID: 20683 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ClientConnect(Uri uri)
		{
			throw null;
		}

		// Token: 0x060050CC RID: 20684 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ClientSend(ArraySegment<byte> segment, int channelId)
		{
			throw null;
		}

		// Token: 0x060050CD RID: 20685 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ClientDisconnect()
		{
			throw null;
		}

		// Token: 0x060050CE RID: 20686 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ClientEarlyUpdate()
		{
			throw null;
		}

		// Token: 0x060050CF RID: 20687 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ClientLateUpdate()
		{
			throw null;
		}

		// Token: 0x060050D0 RID: 20688 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Uri ServerUri()
		{
			throw null;
		}

		// Token: 0x060050D1 RID: 20689 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool ServerActive()
		{
			throw null;
		}

		// Token: 0x060050D2 RID: 20690 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ServerStart()
		{
			throw null;
		}

		// Token: 0x060050D3 RID: 20691 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ServerSend(int connectionId, ArraySegment<byte> segment, int channelId)
		{
			throw null;
		}

		// Token: 0x060050D4 RID: 20692 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ServerDisconnect(int connectionId)
		{
			throw null;
		}

		// Token: 0x060050D5 RID: 20693 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ServerGetClientAddress(int connectionId)
		{
			throw null;
		}

		// Token: 0x060050D6 RID: 20694 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ServerStop()
		{
			throw null;
		}

		// Token: 0x060050D7 RID: 20695 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ServerEarlyUpdate()
		{
			throw null;
		}

		// Token: 0x060050D8 RID: 20696 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ServerLateUpdate()
		{
			throw null;
		}

		// Token: 0x060050D9 RID: 20697 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Shutdown()
		{
			throw null;
		}

		// Token: 0x060050DA RID: 20698 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetMaxPacketSize(int channelId = 0)
		{
			throw null;
		}

		// Token: 0x060050DB RID: 20699 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetBatchThreshold(int channelId)
		{
			throw null;
		}

		// Token: 0x060050DC RID: 20700 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public long GetAverageMaxSendRate()
		{
			throw null;
		}

		// Token: 0x060050DD RID: 20701 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public long GetAverageMaxReceiveRate()
		{
			throw null;
		}

		// Token: 0x060050DE RID: 20702 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private long method_1()
		{
			throw null;
		}

		// Token: 0x060050DF RID: 20703 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private long method_2()
		{
			throw null;
		}

		// Token: 0x060050E0 RID: 20704 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private long method_3()
		{
			throw null;
		}

		// Token: 0x060050E1 RID: 20705 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private long method_4()
		{
			throw null;
		}

		// Token: 0x060050E2 RID: 20706 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string PrettyBytes(long bytes)
		{
			throw null;
		}

		// Token: 0x060050E3 RID: 20707 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x060050E4 RID: 20708 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060050E5 RID: 20709 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x060050E6 RID: 20710 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(ArraySegment<byte> message, KcpChannel channel)
		{
			throw null;
		}

		// Token: 0x060050E7 RID: 20711 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x060050E8 RID: 20712 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(ErrorCode error, string reason)
		{
			throw null;
		}

		// Token: 0x060050E9 RID: 20713 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10()
		{
			throw null;
		}

		// Token: 0x060050EA RID: 20714 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11(ArraySegment<byte> message, KcpChannel channel)
		{
			throw null;
		}

		// Token: 0x060050EB RID: 20715 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12()
		{
			throw null;
		}

		// Token: 0x060050EC RID: 20716 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13(ErrorCode error, string reason)
		{
			throw null;
		}

		// Token: 0x060050ED RID: 20717 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_14(int connectionId)
		{
			throw null;
		}

		// Token: 0x060050EE RID: 20718 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_15(int connectionId, ArraySegment<byte> message, KcpChannel channel)
		{
			throw null;
		}

		// Token: 0x060050EF RID: 20719 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_16(int connectionId)
		{
			throw null;
		}

		// Token: 0x060050F0 RID: 20720 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_17(int connectionId, ErrorCode error, string reason)
		{
			throw null;
		}

		// Token: 0x060050F1 RID: 20721 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_18(int connectionId)
		{
			throw null;
		}

		// Token: 0x060050F2 RID: 20722 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_19(int connectionId, ArraySegment<byte> message, KcpChannel channel)
		{
			throw null;
		}

		// Token: 0x060050F3 RID: 20723 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_20(int connectionId)
		{
			throw null;
		}

		// Token: 0x060050F4 RID: 20724 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_21(int connectionId, ErrorCode error, string reason)
		{
			throw null;
		}

		// Token: 0x04005D18 RID: 23832
		public const string Scheme = "kcp";

		// Token: 0x04005D19 RID: 23833
		[Header("Transport Configuration")]
		public ushort Port;

		// Token: 0x04005D1A RID: 23834
		[Tooltip("DualMode listens to IPv6 and IPv4 simultaneously. Disable if the platform only supports IPv4.")]
		public bool DualMode;

		// Token: 0x04005D1B RID: 23835
		[Tooltip("NoDelay is recommended to reduce latency. This also scales better without buffers getting full.")]
		public bool NoDelay;

		// Token: 0x04005D1C RID: 23836
		[Tooltip("KCP internal update interval. 100ms is KCP default, but a lower interval is recommended to minimize latency and to scale to more networked entities.")]
		public uint Interval;

		// Token: 0x04005D1D RID: 23837
		[Tooltip("KCP timeout in milliseconds. Note that KCP sends a ping automatically.")]
		public int Timeout;

		// Token: 0x04005D1E RID: 23838
		[Header("Advanced")]
		[Tooltip("KCP fastresend parameter. Faster resend for the cost of higher bandwidth. 0 in normal mode, 2 in turbo mode.")]
		public int FastResend;

		// Token: 0x04005D1F RID: 23839
		[Tooltip("KCP congestion window. Enabled in normal mode, disabled in turbo mode. Disable this for high scale games if connections get choked regularly.")]
		public bool CongestionWindow;

		// Token: 0x04005D20 RID: 23840
		[Tooltip("KCP window size can be modified to support higher loads.")]
		public uint SendWindowSize;

		// Token: 0x04005D21 RID: 23841
		[Tooltip("KCP window size can be modified to support higher loads. This also increases max message size.")]
		public uint ReceiveWindowSize;

		// Token: 0x04005D22 RID: 23842
		[Tooltip("KCP will try to retransmit lost messages up to MaxRetransmit (aka dead_link) before disconnecting.")]
		public uint MaxRetransmit;

		// Token: 0x04005D23 RID: 23843
		[Tooltip("Enable to use where-allocation NonAlloc KcpServer/Client/Connection versions. Highly recommended on all Unity platforms.")]
		public bool NonAlloc;

		// Token: 0x04005D24 RID: 23844
		[Tooltip("Enable to automatically set client & server send/recv buffers to OS limit. Avoids issues with too small buffers under heavy load, potentially dropping connections. Increase the OS limit if this is still too small.")]
		public bool MaximizeSendReceiveBuffersToOSLimit;

		// Token: 0x04005D25 RID: 23845
		[Header("Calculated Max (based on Receive Window Size)")]
		[ReadOnly]
		[Tooltip("KCP reliable max message size shown for convenience. Can be changed via ReceiveWindowSize.")]
		public int ReliableMaxMessageSize;

		// Token: 0x04005D26 RID: 23846
		[ReadOnly]
		[Tooltip("KCP unreliable channel max message size for convenience. Not changeable.")]
		public int UnreliableMaxMessageSize;

		// Token: 0x04005D27 RID: 23847
		private KcpServer kcpServer_0;

		// Token: 0x04005D28 RID: 23848
		private KcpClient kcpClient_0;

		// Token: 0x04005D29 RID: 23849
		[Header("Debug")]
		public bool debugLog;

		// Token: 0x04005D2A RID: 23850
		public bool statisticsGUI;

		// Token: 0x04005D2B RID: 23851
		public bool statisticsLog;

		// Token: 0x02000F17 RID: 3863
		[CompilerGenerated]
		[Serializable]
		private sealed class Class767
		{
			// Token: 0x060050F5 RID: 20725 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(string _)
			{
				throw null;
			}

			// Token: 0x060050F6 RID: 20726 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal long method_1(KcpServerConnection conn)
			{
				throw null;
			}

			// Token: 0x060050F7 RID: 20727 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal long method_2(KcpServerConnection conn)
			{
				throw null;
			}

			// Token: 0x060050F8 RID: 20728 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_3(KcpServerConnection conn)
			{
				throw null;
			}

			// Token: 0x060050F9 RID: 20729 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_4(KcpServerConnection conn)
			{
				throw null;
			}

			// Token: 0x060050FA RID: 20730 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_5(KcpServerConnection conn)
			{
				throw null;
			}

			// Token: 0x060050FB RID: 20731 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_6(KcpServerConnection conn)
			{
				throw null;
			}

			// Token: 0x04005D2C RID: 23852
			public static readonly KcpTransport.Class767 class767_0;

			// Token: 0x04005D2D RID: 23853
			public static Action<string> action_0;

			// Token: 0x04005D2E RID: 23854
			public static Func<KcpServerConnection, long> func_0;

			// Token: 0x04005D2F RID: 23855
			public static Func<KcpServerConnection, long> func_1;

			// Token: 0x04005D30 RID: 23856
			public static Func<KcpServerConnection, int> func_2;

			// Token: 0x04005D31 RID: 23857
			public static Func<KcpServerConnection, int> func_3;

			// Token: 0x04005D32 RID: 23858
			public static Func<KcpServerConnection, int> func_4;

			// Token: 0x04005D33 RID: 23859
			public static Func<KcpServerConnection, int> func_5;
		}
	}
}
