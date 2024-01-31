using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GPUInstancer
{
	// Token: 0x02000EC3 RID: 3779
	[ExecuteInEditMode]
	public class GPUInstancerTreeManager : GPUInstancerTerrainManager
	{
		// Token: 0x06004EE4 RID: 20196 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Awake()
		{
			throw null;
		}

		// Token: 0x06004EE5 RID: 20197 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ClearInstancingData()
		{
			throw null;
		}

		// Token: 0x06004EE6 RID: 20198 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void GeneratePrototypes(bool forceNew = false)
		{
			throw null;
		}

		// Token: 0x06004EE7 RID: 20199 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void InitializeRuntimeDataAndBuffers(bool forceNew = true)
		{
			throw null;
		}

		// Token: 0x06004EE8 RID: 20200 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void DeletePrototype(GPUInstancerPrototype prototype, bool removeSO = true)
		{
			throw null;
		}

		// Token: 0x06004EE9 RID: 20201 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator ReplaceUnityTrees()
		{
			throw null;
		}

		// Token: 0x04005B8D RID: 23437
		private static ComputeShader computeShader_0;

		// Token: 0x04005B8E RID: 23438
		public bool initializeWithCoroutine;
	}
}
