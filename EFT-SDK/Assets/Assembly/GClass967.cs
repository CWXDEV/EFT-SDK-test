using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

// Token: 0x02000D24 RID: 3364
public class GClass967
{
	// Token: 0x17000B5F RID: 2911
	// (get) Token: 0x06004791 RID: 18321 RVA: 0x00002050 File Offset: 0x00000250
	public Dictionary<int, RaycastHit[]> HitsData
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000B60 RID: 2912
	// (get) Token: 0x06004792 RID: 18322 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsCompleted
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06004793 RID: 18323 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddRaycastCommand(Vector3 startPoint, Vector3 endPoint, float distance, int index, int mask)
	{
		throw null;
	}

	// Token: 0x06004794 RID: 18324 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Execute()
	{
		throw null;
	}

	// Token: 0x06004795 RID: 18325 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StoreResults()
	{
		throw null;
	}

	// Token: 0x06004796 RID: 18326 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x06004797 RID: 18327 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearHitData()
	{
		throw null;
	}

	// Token: 0x06004798 RID: 18328 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void Finalize()
	{
		throw null;
	}

	// Token: 0x0400527B RID: 21115
	private readonly int int_0;

	// Token: 0x0400527C RID: 21116
	private readonly int int_1;

	// Token: 0x0400527D RID: 21117
	private NativeArray<RaycastCommand> nativeArray_0;

	// Token: 0x0400527E RID: 21118
	private NativeArray<RaycastHit> nativeArray_1;

	// Token: 0x0400527F RID: 21119
	private GStruct67 gstruct67_0;

	// Token: 0x04005280 RID: 21120
	private JobHandle jobHandle_0;

	// Token: 0x04005281 RID: 21121
	[CompilerGenerated]
	private readonly Dictionary<int, RaycastHit[]> dictionary_0;

	// Token: 0x04005282 RID: 21122
	private bool bool_0;

	// Token: 0x04005283 RID: 21123
	private bool bool_1;
}
