using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace WindowsManagerUtilities
{
	// Token: 0x02000C19 RID: 3097
	[Serializable]
	internal struct MaterialParameters
	{
		// Token: 0x06004388 RID: 17288 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(Material material, string mainTexName, string specTexName)
		{
			throw null;
		}

		// Token: 0x04004CEA RID: 19690
		public float GlobalReflectionStrength;

		// Token: 0x04004CEB RID: 19691
		public float CustomFogStrength;

		// Token: 0x04004CEC RID: 19692
		public float ScatterStrength;

		// Token: 0x04004CED RID: 19693
		public float Shininess;

		// Token: 0x04004CEE RID: 19694
		public Vector4 MainColor;

		// Token: 0x04004CEF RID: 19695
		public Vector4 SpecularColor;

		// Token: 0x04004CF0 RID: 19696
		public Vector4 ReflectionColor;

		// Token: 0x04004CF1 RID: 19697
		public Vector4 MainTexTilingOffset;

		// Token: 0x04004CF2 RID: 19698
		public Vector4 SpecTexTilingOffset;
	}
}
