using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GPUInstancer
{
	// Token: 0x02000E74 RID: 3700
	public class GPUInstancerBillboardAtlasBindings : ScriptableObject
	{
		// Token: 0x06004D6B RID: 19819 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public BillboardAtlasBinding GetBillboardAtlasBinding(GameObject prefab, int atlasResolution, int frameCount)
		{
			throw null;
		}

		// Token: 0x06004D6C RID: 19820 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetBillboardAtlases()
		{
			throw null;
		}

		// Token: 0x06004D6D RID: 19821 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearEmptyBillboardAtlases()
		{
			throw null;
		}

		// Token: 0x06004D6E RID: 19822 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddBillboardAtlas(GameObject prefab, int atlasResolution, int frameCount, Texture2D albedoAtlasTexture, Texture2D normalAtlasTexture, float quadSize, float yPivotOffset)
		{
			throw null;
		}

		// Token: 0x06004D6F RID: 19823 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveBillboardAtlas(BillboardAtlasBinding billboardAtlasBinding)
		{
			throw null;
		}

		// Token: 0x06004D70 RID: 19824 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsBillboardAtlasExists(GameObject prefab)
		{
			throw null;
		}

		// Token: 0x06004D71 RID: 19825 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool DeleteBillboardTextures(GPUInstancerPrototype selectedPrototype)
		{
			throw null;
		}

		// Token: 0x04005904 RID: 22788
		public List<BillboardAtlasBinding> billboardAtlasBindings;
	}
}
