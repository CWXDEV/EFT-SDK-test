using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GPUInstancer
{
	// Token: 0x02000E70 RID: 3696
	[Serializable]
	public abstract class GPUInstancerPrototype : ScriptableObject
	{
		// Token: 0x06004D62 RID: 19810 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x040058CE RID: 22734
		public GameObject prefabObject;

		// Token: 0x040058CF RID: 22735
		public bool isShadowCasting;

		// Token: 0x040058D0 RID: 22736
		public bool useCustomShadowDistance;

		// Token: 0x040058D1 RID: 22737
		public float shadowDistance;

		// Token: 0x040058D2 RID: 22738
		public float[] shadowLODMap;

		// Token: 0x040058D3 RID: 22739
		public bool useOriginalShaderForShadow;

		// Token: 0x040058D4 RID: 22740
		public bool cullShadows;

		// Token: 0x040058D5 RID: 22741
		public float minDistance;

		// Token: 0x040058D6 RID: 22742
		public float maxDistance;

		// Token: 0x040058D7 RID: 22743
		public float minDistanceOptic;

		// Token: 0x040058D8 RID: 22744
		public float maxDistanceOptic;

		// Token: 0x040058D9 RID: 22745
		public bool isFrustumCulling;

		// Token: 0x040058DA RID: 22746
		public bool isOcclusionCulling;

		// Token: 0x040058DB RID: 22747
		public float minCullingDistance;

		// Token: 0x040058DC RID: 22748
		public float occlusionOffset;

		// Token: 0x040058DD RID: 22749
		public int occlusionAccuracy;

		// Token: 0x040058DE RID: 22750
		public Vector3 boundsOffset;

		// Token: 0x040058DF RID: 22751
		public bool isLODCrossFade;

		// Token: 0x040058E0 RID: 22752
		public bool isLODCrossFadeAnimate;

		// Token: 0x040058E1 RID: 22753
		[Range(0.01f, 1f)]
		public float lodFadeTransitionWidth;

		// Token: 0x040058E2 RID: 22754
		public float lodBiasAdjustment;

		// Token: 0x040058E3 RID: 22755
		public GPUInstancerBillboard billboard;

		// Token: 0x040058E4 RID: 22756
		public bool isBillboardDisabled;

		// Token: 0x040058E5 RID: 22757
		public bool useGeneratedBillboard;

		// Token: 0x040058E6 RID: 22758
		public bool checkedForBillboardExtensions;

		// Token: 0x040058E7 RID: 22759
		public bool autoUpdateTransformData;

		// Token: 0x040058E8 RID: 22760
		public GPUInstancerTreeType treeType;

		// Token: 0x040058E9 RID: 22761
		public string warningText;
	}
}
