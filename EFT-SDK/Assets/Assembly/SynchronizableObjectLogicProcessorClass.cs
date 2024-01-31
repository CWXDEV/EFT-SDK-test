using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.SynchronizableObjects;
using UnityEngine;

// Token: 0x02001E3F RID: 7743
public class SynchronizableObjectLogicProcessorClass : IDisposable
{
	// Token: 0x06009ED2 RID: 40658 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ISynchronizableObject GetSyncObjectStrategyByType(SynchronizableObjectType type)
	{
		throw null;
	}

	// Token: 0x17001930 RID: 6448
	// (get) Token: 0x06009ED3 RID: 40659 RVA: 0x00002050 File Offset: 0x00000250
	public LevelPhysicsSettings Settings
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001931 RID: 6449
	// (get) Token: 0x06009ED4 RID: 40660 RVA: 0x00002050 File Offset: 0x00000250
	public byte TakeSynchronizedObjectId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06009ED5 RID: 40661 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetSynchronizableObjects(ref List<SynchronizableObject> synchronizableObjects)
	{
		throw null;
	}

	// Token: 0x06009ED6 RID: 40662 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_0(bool isServer, AirdropManagerAbstractClass airdropManager, GInterface188 data = null)
	{
		throw null;
	}

	// Token: 0x06009ED7 RID: 40663 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ProcessSyncObjectPackets(List<AirplaneDataPacketStruct> synchronizableObjectPackets)
	{
		throw null;
	}

	// Token: 0x06009ED8 RID: 40664 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void WriteSyncObjects(ref GStruct118 packet)
	{
		throw null;
	}

	// Token: 0x06009ED9 RID: 40665 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate(float deltaTime)
	{
		throw null;
	}

	// Token: 0x06009EDA RID: 40666 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitStaticObject(SynchronizableObject synchronizableObject)
	{
		throw null;
	}

	// Token: 0x06009EDB RID: 40667 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitSyncObject(SynchronizableObject syncObject, Vector3 position, Vector3 rotation, int objectId = -1)
	{
		throw null;
	}

	// Token: 0x06009EDC RID: 40668 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x06009EDD RID: 40669 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private SynchronizableObject method_2(int objectID)
	{
		throw null;
	}

	// Token: 0x06009EDE RID: 40670 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private SynchronizableObject method_3(AirplaneDataPacketStruct packet)
	{
		throw null;
	}

	// Token: 0x06009EDF RID: 40671 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SynchronizableObject TakeFromPool(SynchronizableObjectType type)
	{
		throw null;
	}

	// Token: 0x06009EE0 RID: 40672 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReturnToPool(SynchronizableObject synchronizableObject)
	{
		throw null;
	}

	// Token: 0x06009EE1 RID: 40673 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(List<AirplaneDataPacketStruct> synchronizableObjectPackets)
	{
		throw null;
	}

	// Token: 0x06009EE2 RID: 40674 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0400A75D RID: 42845
	private List<SynchronizableObject> list_0;

	// Token: 0x0400A75E RID: 42846
	private List<SynchronizableObject> list_1;

	// Token: 0x0400A75F RID: 42847
	private LevelPhysicsSettings levelPhysicsSettings_0;

	// Token: 0x0400A760 RID: 42848
	private byte byte_0;

	// Token: 0x0400A761 RID: 42849
	internal GInterface188 ginterface188_0;

	// Token: 0x0400A762 RID: 42850
	public AirdropManagerAbstractClass AirdropManager;
}
