using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AmplifyImpostors
{
	// Token: 0x020031BE RID: 12734
	[Serializable]
	public class TextureOutput
	{
		// Token: 0x0600FACC RID: 64204 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TextureOutput Clone()
		{
			throw null;
		}

		// Token: 0x0400FF7A RID: 65402
		[SerializeField]
		public int Index;

		// Token: 0x0400FF7B RID: 65403
		[SerializeField]
		public OverrideMask OverrideMask;

		// Token: 0x0400FF7C RID: 65404
		public bool Active;

		// Token: 0x0400FF7D RID: 65405
		public string Name;

		// Token: 0x0400FF7E RID: 65406
		public TextureScale Scale;

		// Token: 0x0400FF7F RID: 65407
		public bool SRGB;

		// Token: 0x0400FF80 RID: 65408
		public TextureChannels Channels;

		// Token: 0x0400FF81 RID: 65409
		public TextureCompression Compression;

		// Token: 0x0400FF82 RID: 65410
		public ImageFormat ImageFormat;
	}
}
