using System;
using UnityEngine;

namespace WindowsManagerUtilities
{
	// Token: 0x02000C18 RID: 3096
	[Serializable]
	internal struct LightProperties
	{
		// Token: 0x04004CE6 RID: 19686
		public Vector4 pos;

		// Token: 0x04004CE7 RID: 19687
		public Vector3 dir;

		// Token: 0x04004CE8 RID: 19688
		public Vector3 color;

		// Token: 0x04004CE9 RID: 19689
		public Matrix4x4 worldToLight;
	}
}
