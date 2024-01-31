using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

// Token: 0x020014BB RID: 5307
public sealed class GClass1636
{
	// Token: 0x060071C6 RID: 29126 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass1636 CreateInstance()
	{
		throw null;
	}

	// Token: 0x060071C7 RID: 29127 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddInstance(NetworkConnection connection, GClass1644 packetEncryptor)
	{
		throw null;
	}

	// Token: 0x060071C8 RID: 29128 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveInstance(NetworkConnection connection)
	{
		throw null;
	}

	// Token: 0x060071C9 RID: 29129 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddNetworkQualityWatch(NetworkConnection connection, GClass1641 networkQualityParams, GClass1643.GDelegate57 action)
	{
		throw null;
	}

	// Token: 0x060071CA RID: 29130 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartNetworkQualityWatch(NetworkConnection connection)
	{
		throw null;
	}

	// Token: 0x060071CB RID: 29131 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopNetworkQualityWatch(NetworkConnection connection)
	{
		throw null;
	}

	// Token: 0x060071CC RID: 29132 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateNetworkQualityWatch(float time)
	{
		throw null;
	}

	// Token: 0x060071CD RID: 29133 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetPacketEncryptor(NetworkConnection connection, out GClass1644 packetEncryptor)
	{
		throw null;
	}

	// Token: 0x060071CE RID: 29134 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Send(NetworkConnection connection, byte channel, short messageType, in ArraySegment<byte> segment)
	{
		throw null;
	}

	// Token: 0x04007863 RID: 30819
	private Dictionary<NetworkConnection, GClass1635> dictionary_0;

	// Token: 0x04007864 RID: 30820
	private Dictionary<NetworkConnection, GClass1643> dictionary_1;
}
