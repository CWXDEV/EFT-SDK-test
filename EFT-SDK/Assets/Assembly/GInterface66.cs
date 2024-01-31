using System;
using GPUInstancer;
using UnityEngine;

// Token: 0x02000EBF RID: 3775
public interface GInterface66
{
	// Token: 0x06004ECC RID: 20172
	void InitializeBufferAndArray(int count, bool setDefaults = true);

	// Token: 0x06004ECD RID: 20173
	void SetInstanceData(GPUInstancerPrefab prefabInstance);

	// Token: 0x06004ECE RID: 20174
	void SetBufferData(int managedBufferStartIndex, int computeBufferStartIndex, int count);

	// Token: 0x06004ECF RID: 20175
	void SetVariation(MaterialPropertyBlock mpb);

	// Token: 0x06004ED0 RID: 20176
	void SetNewBufferSize(int newCount);

	// Token: 0x06004ED1 RID: 20177
	GPUInstancerPrefabPrototype GetPrototype();

	// Token: 0x06004ED2 RID: 20178
	string GetBufferName();

	// Token: 0x06004ED3 RID: 20179
	void ReleaseBuffer();
}
