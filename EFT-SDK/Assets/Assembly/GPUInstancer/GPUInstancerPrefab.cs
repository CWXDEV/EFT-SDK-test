using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GPUInstancer
{
	// Token: 0x02000EB0 RID: 3760
	public class GPUInstancerPrefab : MonoBehaviour
	{
		// Token: 0x06004E8E RID: 20110 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddVariation<T>(string bufferName, T value)
		{
			throw null;
		}

		// Token: 0x06004E8F RID: 20111 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Transform GetInstanceTransform(bool forceNew = false)
		{
			throw null;
		}

		// Token: 0x06004E90 RID: 20112 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Matrix4x4 GetLocalToWorldMatrix(bool forceNew = false)
		{
			throw null;
		}

		// Token: 0x06004E91 RID: 20113 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetupPrefabInstance(GClass1061 runtimeData, bool forceNew = false)
		{
			throw null;
		}

		// Token: 0x04005B50 RID: 23376
		[HideInInspector]
		public GPUInstancerPrefabPrototype prefabPrototype;

		// Token: 0x04005B51 RID: 23377
		[HideInInspector]
		public int gpuInstancerID;

		// Token: 0x04005B52 RID: 23378
		[HideInInspector]
		public PrefabInstancingState state;

		// Token: 0x04005B53 RID: 23379
		public Dictionary<string, object> variationDataList;

		// Token: 0x04005B54 RID: 23380
		private bool bool_0;

		// Token: 0x04005B55 RID: 23381
		private Transform transform_0;

		// Token: 0x04005B56 RID: 23382
		private bool bool_1;

		// Token: 0x04005B57 RID: 23383
		private Matrix4x4 matrix4x4_0;
	}
}
