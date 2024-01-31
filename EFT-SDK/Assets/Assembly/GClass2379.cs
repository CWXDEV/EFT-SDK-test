using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Jobs;
using UnityEngine.Networking;

// Token: 0x0200203B RID: 8251
public class GClass2379 : IDisposable
{
	// Token: 0x0600AACB RID: 43723 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSpawnObservedPlayer(NetworkMessage networkMessage)
	{
		throw null;
	}

	// Token: 0x0600AACC RID: 43724 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSpawnObservedPlayers(NetworkMessage networkMessage)
	{
		throw null;
	}

	// Token: 0x0600AACD RID: 43725 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnChangeFramerate(NetworkMessage networkMessage)
	{
		throw null;
	}

	// Token: 0x0600AACE RID: 43726 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSnapshotObservedPlayers(NetworkMessage networkMessage)
	{
		throw null;
	}

	// Token: 0x0600AACF RID: 43727 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCommandsObservedPlayers(NetworkMessage networkMessage)
	{
		throw null;
	}

	// Token: 0x0600AAD0 RID: 43728 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(int id, ArraySegment<byte> segment)
	{
		throw null;
	}

	// Token: 0x0600AAD1 RID: 43729 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(int id, GStruct275 message)
	{
		throw null;
	}

	// Token: 0x0600AAD2 RID: 43730 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveObservedController(GClass2358 controller, float remoteTime)
	{
		throw null;
	}

	// Token: 0x0600AAD3 RID: 43731 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x0600AAD4 RID: 43732 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualLateUpdate()
	{
		throw null;
	}

	// Token: 0x0600AAD5 RID: 43733 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0400B1BC RID: 45500
	public float lastServerWorldTime;

	// Token: 0x0400B1BD RID: 45501
	public int lastRemoteFrame;

	// Token: 0x0400B1BE RID: 45502
	private readonly GClass2359 gclass2359_0;

	// Token: 0x0400B1BF RID: 45503
	private readonly List<GClass1252> list_0;

	// Token: 0x0400B1C0 RID: 45504
	private readonly List<GClass1252> list_1;

	// Token: 0x0400B1C1 RID: 45505
	private GClass1635 gclass1635_0;

	// Token: 0x0400B1C2 RID: 45506
	private readonly byte[] byte_0;

	// Token: 0x0400B1C3 RID: 45507
	private JobHandle jobHandle_0;

	// Token: 0x0400B1C4 RID: 45508
	public readonly GStruct286[] Models;

	// Token: 0x0400B1C5 RID: 45509
	private DateTime dateTime_0;
}
