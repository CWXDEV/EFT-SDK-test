using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GPUInstancer
{
	// Token: 0x02000EB2 RID: 3762
	public class GPUInstancerPrefabListRuntimeHandler : MonoBehaviour
	{
		// Token: 0x06004E92 RID: 20114 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		// Token: 0x06004E93 RID: 20115 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x06004E94 RID: 20116 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddPrefabInstancesAsync(object param)
		{
			throw null;
		}

		// Token: 0x06004E95 RID: 20117 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemovePrefabInstancesAsync(object param)
		{
			throw null;
		}

		// Token: 0x06004E96 RID: 20118 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetManager(GPUInstancerPrefabManager prefabManager)
		{
			throw null;
		}

		// Token: 0x04005B5C RID: 23388
		public GPUInstancerPrefabManager prefabManager;

		// Token: 0x04005B5D RID: 23389
		private IEnumerable<GPUInstancerPrefab> ienumerable_0;

		// Token: 0x04005B5E RID: 23390
		private bool bool_0;

		// Token: 0x04005B5F RID: 23391
		public bool runInThreads;

		// Token: 0x02000EB3 RID: 3763
		[CompilerGenerated]
		[Serializable]
		private sealed class Class753
		{
			// Token: 0x06004E97 RID: 20119 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GPUInstancerPrototype p)
			{
				throw null;
			}

			// Token: 0x04005B60 RID: 23392
			public static readonly GPUInstancerPrefabListRuntimeHandler.Class753 class753_0;

			// Token: 0x04005B61 RID: 23393
			public static Func<GPUInstancerPrototype, bool> func_0;
		}
	}
}
