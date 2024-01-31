using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PostEffects
{
	// Token: 0x02000C58 RID: 3160
	public sealed class NoiseTextureSet : ScriptableObject
	{
		// Token: 0x060044E3 RID: 17635 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Texture2D GetTexture()
		{
			throw null;
		}

		// Token: 0x060044E4 RID: 17636 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Texture2D GetTexture(int frameCount)
		{
			throw null;
		}

		// Token: 0x04004EF0 RID: 20208
		[SerializeField]
		private Texture2D[] _textures;
	}
}
