using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GPUInstancer
{
	// Token: 0x02000E93 RID: 3731
	[Serializable]
	public class ShaderInstance
	{
		// Token: 0x06004DAA RID: 19882 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Regenerate()
		{
			throw null;
		}

		// Token: 0x04005A7A RID: 23162
		public string name;

		// Token: 0x04005A7B RID: 23163
		public Shader instancedShader;

		// Token: 0x04005A7C RID: 23164
		public string modifiedDate;

		// Token: 0x04005A7D RID: 23165
		public bool isOriginalInstanced;

		// Token: 0x04005A7E RID: 23166
		public string extensionCode;
	}
}
