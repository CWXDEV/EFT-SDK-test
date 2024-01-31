using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Diz.Skinning;
using UnityEngine;

namespace EFT.Visual
{
	// Token: 0x02001A0A RID: 6666
	public sealed class SkinDress : Dress
	{
		// Token: 0x06008D9B RID: 36251 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Init(PlayerBody playerBody)
		{
			throw null;
		}

		// Token: 0x06008D9C RID: 36252 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnSkin(Transform playerTransform, Transform meshTransform)
		{
			throw null;
		}

		// Token: 0x06008D9D RID: 36253 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Unskin()
		{
			throw null;
		}

		// Token: 0x06008D9E RID: 36254 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override IEnumerable<Renderer> GetRenderers()
		{
			throw null;
		}

		// Token: 0x040093F7 RID: 37879
		[SerializeField]
		private AbstractSkin[] _lods;
	}
}
