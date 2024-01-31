using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Visual
{
	// Token: 0x02001A02 RID: 6658
	public sealed class JackOLantern : Dress
	{
		// Token: 0x06008D7B RID: 36219 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnSkin(Transform playerTransform, Transform meshTransform)
		{
			throw null;
		}

		// Token: 0x06008D7C RID: 36220 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Unskin()
		{
			throw null;
		}

		// Token: 0x06008D7D RID: 36221 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override IEnumerable<Renderer> GetRenderers()
		{
			throw null;
		}

		// Token: 0x06008D7E RID: 36222 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void AdjustShadowMode(EPointOfView pointOfView)
		{
			throw null;
		}

		// Token: 0x040093DF RID: 37855
		[SerializeField]
		private VolumetricLight _volumetricLight;

		// Token: 0x040093E0 RID: 37856
		private Transform transform_0;
	}
}
