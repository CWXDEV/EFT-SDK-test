using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using EFT.KcpNetwork;

// Token: 0x0200222C RID: 8748
public class GClass2475
{
	// Token: 0x17001DED RID: 7661
	// (get) Token: 0x0600B278 RID: 45688 RVA: 0x00002050 File Offset: 0x00000250
	public int Index
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600B279 RID: 45689 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x0600B27A RID: 45690 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int Connect(string address, int port, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B27B RID: 45691 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Disconnect(int index, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B27C RID: 45692 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetConnectionInfo(int index, out string address, out int port, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B27D RID: 45693 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetRtt(int index, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B27E RID: 45694 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetLossPercent(int index, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B27F RID: 45695 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetLossCount(int index, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B280 RID: 45696 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Send(int connection, NetworkChannel channel, byte[] buffer, int bufferSize, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B281 RID: 45697 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Receive(out int index, out NetworkMessageType type, out NetworkChannel channel, byte[] buffer, out int bufferSize, out byte error)
	{
		throw null;
	}

	// Token: 0x0600B282 RID: 45698 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Shutdown()
	{
		throw null;
	}

	// Token: 0x0600B283 RID: 45699 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct365 GetStatistics(int index)
	{
		throw null;
	}

	// Token: 0x0400B6EB RID: 46827
	private const int int_0 = 10;

	// Token: 0x0400B6EC RID: 46828
	private const int int_1 = 2000;

	// Token: 0x0400B6ED RID: 46829
	private GClass2476 gclass2476_0;

	// Token: 0x0400B6EE RID: 46830
	private Thread thread_0;

	// Token: 0x0400B6EF RID: 46831
	private readonly GClass2477<GClass2475.Struct732> gclass2477_0;

	// Token: 0x0400B6F0 RID: 46832
	private readonly GClass2477<GClass2475.Struct733> gclass2477_1;

	// Token: 0x0400B6F1 RID: 46833
	private readonly GClass2477<GClass2475.Struct734> gclass2477_2;

	// Token: 0x0400B6F2 RID: 46834
	private readonly GClass2477<GClass2475.Struct735> gclass2477_3;

	// Token: 0x0400B6F3 RID: 46835
	public GClass629 Logger;

	// Token: 0x0200222D RID: 8749
	[StructLayout(LayoutKind.Auto)]
	public struct Struct732
	{
		// Token: 0x0400B6F4 RID: 46836
		public int Connection;

		// Token: 0x0400B6F5 RID: 46837
		public string Address;

		// Token: 0x0400B6F6 RID: 46838
		public int Port;
	}

	// Token: 0x0200222E RID: 8750
	[StructLayout(LayoutKind.Auto)]
	public struct Struct733
	{
		// Token: 0x0400B6F7 RID: 46839
		public int Connection;
	}

	// Token: 0x0200222F RID: 8751
	[StructLayout(LayoutKind.Auto)]
	public struct Struct734
	{
		// Token: 0x0400B6F8 RID: 46840
		public int Connection;

		// Token: 0x0400B6F9 RID: 46841
		public NetworkMessageType Type;

		// Token: 0x0400B6FA RID: 46842
		public NetworkChannel Channel;

		// Token: 0x0400B6FB RID: 46843
		public ArraySegment<byte> Buffer;
	}

	// Token: 0x02002230 RID: 8752
	[StructLayout(LayoutKind.Auto)]
	public struct Struct735
	{
		// Token: 0x0400B6FC RID: 46844
		public int Connection;

		// Token: 0x0400B6FD RID: 46845
		public NetworkChannel Channel;

		// Token: 0x0400B6FE RID: 46846
		public ArraySegment<byte> Buffer;
	}
}
