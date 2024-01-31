using System;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

// Token: 0x0200186C RID: 6252
internal sealed class Class1371
{
	// Token: 0x060085E3 RID: 34275 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Class1371 smethod_0(Class1371.Interface8 session)
	{
		throw null;
	}

	// Token: 0x1700149E RID: 5278
	// (get) Token: 0x060085E4 RID: 34276 RVA: 0x00002050 File Offset: 0x00000250
	private NetworkClient NetworkClient_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060085E5 RID: 34277 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x060085E6 RID: 34278 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_1(HostTopology hostTopology, string address, int port)
	{
		throw null;
	}

	// Token: 0x060085E7 RID: 34279 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_2(HostTopology hostTopology, string address, int port, int latency, float packetLoss)
	{
		throw null;
	}

	// Token: 0x060085E8 RID: 34280 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_3()
	{
		throw null;
	}

	// Token: 0x060085E9 RID: 34281 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(NetworkMessage message)
	{
		throw null;
	}

	// Token: 0x060085EA RID: 34282 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(NetworkMessage message)
	{
		throw null;
	}

	// Token: 0x060085EB RID: 34283 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6(NetworkMessage message)
	{
		throw null;
	}

	// Token: 0x060085EC RID: 34284 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7(NetworkMessage message)
	{
		throw null;
	}

	// Token: 0x04008CD3 RID: 36051
	private Class1371.Interface8 interface8_0;

	// Token: 0x0200186D RID: 6253
	internal interface Interface8
	{
		// Token: 0x1700149F RID: 5279
		// (get) Token: 0x060085ED RID: 34285
		NetworkClient NetworkClient { get; }

		// Token: 0x060085EE RID: 34286
		void OnConnect(NetworkConnection connection);

		// Token: 0x060085EF RID: 34287
		void OnDisconnect(NetworkConnection connection);
	}
}
