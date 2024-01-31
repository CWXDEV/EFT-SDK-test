using System;
using System.Runtime.CompilerServices;
using GPUInstancer;
using UnityEngine;

// Token: 0x02000EC0 RID: 3776
public class GClass1066<T> : GInterface66
{
	// Token: 0x06004ED4 RID: 20180 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitializeBufferAndArray(int count, bool setDefaults = true)
	{
		throw null;
	}

	// Token: 0x06004ED5 RID: 20181 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetArrayAndInitializeBuffer(T[] dataArray)
	{
		throw null;
	}

	// Token: 0x06004ED6 RID: 20182 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetInstanceData(GPUInstancerPrefab prefabInstance)
	{
		throw null;
	}

	// Token: 0x06004ED7 RID: 20183 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBufferData(int managedBufferStartIndex, int computeBufferStartIndex, int count)
	{
		throw null;
	}

	// Token: 0x06004ED8 RID: 20184 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetVariation(MaterialPropertyBlock mpb)
	{
		throw null;
	}

	// Token: 0x06004ED9 RID: 20185 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetNewBufferSize(int newCount)
	{
		throw null;
	}

	// Token: 0x06004EDA RID: 20186 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GPUInstancerPrefabPrototype GetPrototype()
	{
		throw null;
	}

	// Token: 0x06004EDB RID: 20187 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetBufferName()
	{
		throw null;
	}

	// Token: 0x06004EDC RID: 20188 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReleaseBuffer()
	{
		throw null;
	}

	// Token: 0x04005B80 RID: 23424
	public GPUInstancerPrefabPrototype prototype;

	// Token: 0x04005B81 RID: 23425
	public string bufferName;

	// Token: 0x04005B82 RID: 23426
	public ComputeBuffer variationBuffer;

	// Token: 0x04005B83 RID: 23427
	public T[] dataArray;

	// Token: 0x04005B84 RID: 23428
	public T defaultValue;
}
