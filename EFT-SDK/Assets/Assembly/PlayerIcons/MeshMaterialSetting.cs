using System;
using UnityEngine;

namespace PlayerIcons
{
	// Token: 0x02000C72 RID: 3186
	[Serializable]
	public class MeshMaterialSetting
	{
		// Token: 0x04004F4B RID: 20299
		public MeshType meshType;

		// Token: 0x04004F4C RID: 20300
		public bool isChanged;

		// Token: 0x04004F4D RID: 20301
		[Range(0.01f, 10f)]
		public float specularityMesh;

		// Token: 0x04004F4E RID: 20302
		[Range(0.01f, 10f)]
		public float glossnessMesh;
	}
}
