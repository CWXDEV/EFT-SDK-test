using System;
using System.Collections;
using System.Runtime.CompilerServices;
using EFT.SynchronizableObjects;
using UnityEngine;

// Token: 0x02001E53 RID: 7763
public class AirplaneLogicClass : ISynchronizableObject
{
	// Token: 0x1700193D RID: 6461
	// (get) Token: 0x06009F2A RID: 40746 RVA: 0x00002050 File Offset: 0x00000250
	private Transform Transform_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700193E RID: 6462
	// (get) Token: 0x06009F2B RID: 40747 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009F2C RID: 40748 RVA: 0x00002050 File Offset: 0x00000250
	private BetterSource BetterSource_0
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

	// Token: 0x06009F2D RID: 40749 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(int objectID, Vector3 position, Vector3 rotation)
	{
		throw null;
	}

	// Token: 0x06009F2E RID: 40750 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSyncObject(SynchronizableObject syncObject)
	{
		throw null;
	}

	// Token: 0x06009F2F RID: 40751 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate(float deltaTime)
	{
		throw null;
	}

	// Token: 0x06009F30 RID: 40752 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(float deltaTime)
	{
		throw null;
	}

	// Token: 0x06009F31 RID: 40753 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x06009F32 RID: 40754 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateSyncObjectData(ref AirplaneDataPacketStruct packet)
	{
		throw null;
	}

	// Token: 0x06009F33 RID: 40755 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TakeFromPool()
	{
		throw null;
	}

	// Token: 0x06009F34 RID: 40756 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReturnToPool()
	{
		throw null;
	}

	// Token: 0x06009F35 RID: 40757 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CollisionEnter(Collider collider)
	{
		throw null;
	}

	// Token: 0x06009F36 RID: 40758 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitStaticObject()
	{
		throw null;
	}

	// Token: 0x06009F37 RID: 40759 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(TaggedClip clip)
	{
		throw null;
	}

	// Token: 0x06009F38 RID: 40760 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_3(float emissionTime)
	{
		throw null;
	}

	// Token: 0x06009F39 RID: 40761 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_4()
	{
		throw null;
	}

	// Token: 0x06009F3A RID: 40762 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5()
	{
		throw null;
	}

	// Token: 0x0400A7B7 RID: 42935
	private const float float_0 = 0.5f;

	// Token: 0x0400A7B8 RID: 42936
	private const float float_1 = 1.3f;

	// Token: 0x0400A7B9 RID: 42937
	private const float float_2 = 5f;

	// Token: 0x0400A7BA RID: 42938
	private const float float_3 = 60f;

	// Token: 0x0400A7BB RID: 42939
	private const float float_4 = 180f;

	// Token: 0x0400A7BC RID: 42940
	private const float float_5 = 800f;

	// Token: 0x0400A7BD RID: 42941
	private const float float_6 = 300f;

	// Token: 0x0400A7BE RID: 42942
	private const float float_7 = 5f;

	// Token: 0x0400A7BF RID: 42943
	private const float float_8 = 49f;

	// Token: 0x0400A7C0 RID: 42944
	private const float float_9 = 4f;

	// Token: 0x0400A7C1 RID: 42945
	private const float float_10 = 0.2f;

	// Token: 0x0400A7C2 RID: 42946
	private const float float_11 = 0.4f;

	// Token: 0x0400A7C3 RID: 42947
	private static readonly Vector3 vector3_0;

	// Token: 0x0400A7C4 RID: 42948
	private float float_12;

	// Token: 0x0400A7C5 RID: 42949
	private bool bool_0;

	// Token: 0x0400A7C6 RID: 42950
	private Vector3 vector3_1;

	// Token: 0x0400A7C7 RID: 42951
	private Quaternion quaternion_0;

	// Token: 0x0400A7C8 RID: 42952
	private SynchronizableObjectType synchronizableObjectType_0;

	// Token: 0x0400A7C9 RID: 42953
	private AirplaneSynchronizableObject airplaneSynchronizableObject_0;

	// Token: 0x0400A7CA RID: 42954
	private int int_0;

	// Token: 0x0400A7CB RID: 42955
	private int int_1;

	// Token: 0x0400A7CC RID: 42956
	private Renderer[] renderer_0;

	// Token: 0x0400A7CD RID: 42957
	private AudioListener audioListener_0;

	// Token: 0x0400A7CE RID: 42958
	private Bounds bounds_0;

	// Token: 0x0400A7CF RID: 42959
	private BetterSource betterSource_0;

	// Token: 0x0400A7D0 RID: 42960
	private float float_13;

	// Token: 0x0400A7D1 RID: 42961
	private float float_14;
}
