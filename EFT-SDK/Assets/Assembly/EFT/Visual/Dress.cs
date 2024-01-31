using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using UnityEngine;

namespace EFT.Visual
{
	// Token: 0x020019FD RID: 6653
	public class Dress : MonoBehaviour, GInterface152
	{
		// Token: 0x06008D65 RID: 36197 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Init(PlayerBody playerBody)
		{
			throw null;
		}

		// Token: 0x06008D66 RID: 36198 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Skin(Transform playerTransform, Transform meshTransform)
		{
			throw null;
		}

		// Token: 0x06008D67 RID: 36199 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Init(Item item, bool isAnimated)
		{
			throw null;
		}

		// Token: 0x06008D68 RID: 36200 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Deinit()
		{
			throw null;
		}

		// Token: 0x06008D69 RID: 36201 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnSkin(Transform playerTransform, Transform meshTransform)
		{
			throw null;
		}

		// Token: 0x06008D6A RID: 36202 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Unskin()
		{
			throw null;
		}

		// Token: 0x06008D6B RID: 36203 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GStruct53 GetBodyRenderer()
		{
			throw null;
		}

		// Token: 0x06008D6C RID: 36204 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual IEnumerable<Renderer> GetRenderers()
		{
			throw null;
		}

		// Token: 0x06008D6D RID: 36205 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void AdjustShadowMode(EPointOfView pointOfView)
		{
			throw null;
		}

		// Token: 0x040093C7 RID: 37831
		public EDecalTextureType DecalTextureType;

		// Token: 0x040093C8 RID: 37832
		protected PlayerBody PlayerBody;

		// Token: 0x040093C9 RID: 37833
		protected readonly GClass763 CompositeDisposable;

		// Token: 0x040093CA RID: 37834
		[SerializeField]
		protected Renderer[] Renderers;
	}
}
