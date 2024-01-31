using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GPUInstancer
{
	// Token: 0x02000EC2 RID: 3778
	[ExecuteInEditMode]
	public class GPUInstancerTerrainProxy : MonoBehaviour
	{
		// Token: 0x06004EE3 RID: 20195 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x04005B88 RID: 23432
		public GPUInstancerDetailManager detailManager;

		// Token: 0x04005B89 RID: 23433
		public GPUInstancerDetailManager detailManagerOptic;

		// Token: 0x04005B8A RID: 23434
		public GPUInstancerTreeManager treeManager;

		// Token: 0x04005B8B RID: 23435
		public bool beingDestroyed;

		// Token: 0x04005B8C RID: 23436
		public int terrainSelectedToolIndex;
	}
}
