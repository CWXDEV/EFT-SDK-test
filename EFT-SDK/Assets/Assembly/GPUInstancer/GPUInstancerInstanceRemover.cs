using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GPUInstancer
{
	// Token: 0x02000EAC RID: 3756
	public class GPUInstancerInstanceRemover : MonoBehaviour
	{
		// Token: 0x06004E7B RID: 20091 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Reset()
		{
			throw null;
		}

		// Token: 0x06004E7C RID: 20092 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x06004E7D RID: 20093 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x04005B3E RID: 23358
		public bool useBounds;

		// Token: 0x04005B3F RID: 23359
		public List<Collider> selectedColliders;

		// Token: 0x04005B40 RID: 23360
		public bool removeFromDetailManagers;

		// Token: 0x04005B41 RID: 23361
		public bool removeFromTreeManagers;

		// Token: 0x04005B42 RID: 23362
		public bool removeFromPrefabManagers;

		// Token: 0x04005B43 RID: 23363
		public bool removeAtUpdate;

		// Token: 0x04005B44 RID: 23364
		public float offset;

		// Token: 0x04005B45 RID: 23365
		public bool onlyRemoveSelectedPrototypes;

		// Token: 0x04005B46 RID: 23366
		public List<GPUInstancerPrototype> selectedPrototypes;
	}
}
