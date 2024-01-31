using System;
using UnityEngine;

namespace GPUInstancer
{
	// Token: 0x02000E75 RID: 3701
	[Serializable]
	public class BillboardAtlasBinding
	{
		// Token: 0x04005905 RID: 22789
		public GameObject prefab;

		// Token: 0x04005906 RID: 22790
		public int atlasResolution;

		// Token: 0x04005907 RID: 22791
		public int frameCount;

		// Token: 0x04005908 RID: 22792
		public Texture2D albedoAtlasTexture;

		// Token: 0x04005909 RID: 22793
		public Texture2D normalAtlasTexture;

		// Token: 0x0400590A RID: 22794
		public float quadSize;

		// Token: 0x0400590B RID: 22795
		public float yPivotOffset;

		// Token: 0x0400590C RID: 22796
		public string modifiedDate;
	}
}
