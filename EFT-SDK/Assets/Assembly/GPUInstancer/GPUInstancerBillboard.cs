using System;
using UnityEngine;

namespace GPUInstancer
{
	// Token: 0x02000E71 RID: 3697
	[Serializable]
	public class GPUInstancerBillboard
	{
		// Token: 0x040058EA RID: 22762
		public BillboardQuality billboardQuality;

		// Token: 0x040058EB RID: 22763
		public int atlasResolution;

		// Token: 0x040058EC RID: 22764
		public int frameCount;

		// Token: 0x040058ED RID: 22765
		public bool replaceLODCullWithBillboard;

		// Token: 0x040058EE RID: 22766
		public bool isOverridingOriginalCutoff;

		// Token: 0x040058EF RID: 22767
		public float cutoffOverride;

		// Token: 0x040058F0 RID: 22768
		[Range(0f, 1f)]
		public float billboardBrightness;

		// Token: 0x040058F1 RID: 22769
		[Range(0.01f, 1f)]
		public float billboardDistance;

		// Token: 0x040058F2 RID: 22770
		public float quadSize;

		// Token: 0x040058F3 RID: 22771
		public float yPivotOffset;

		// Token: 0x040058F4 RID: 22772
		public Texture2D albedoAtlasTexture;

		// Token: 0x040058F5 RID: 22773
		public Texture2D normalAtlasTexture;

		// Token: 0x040058F6 RID: 22774
		public bool customBillboardInLODGroup;

		// Token: 0x040058F7 RID: 22775
		public bool useCustomBillboard;

		// Token: 0x040058F8 RID: 22776
		public Mesh customBillboardMesh;

		// Token: 0x040058F9 RID: 22777
		public Material customBillboardMaterial;

		// Token: 0x040058FA RID: 22778
		public bool isBillboardShadowCasting;

		// Token: 0x040058FB RID: 22779
		public bool billboardFaceCamPos;
	}
}
