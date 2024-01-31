using System;
using System.Runtime.CompilerServices;
using Diz.Skinning;
using EFT.InventoryLogic;
using UnityEngine;

namespace EFT.Visual
{
	// Token: 0x02001A12 RID: 6674
	public class TorsoSkin : AbstractSkin
	{
		// Token: 0x17001582 RID: 5506
		// (get) Token: 0x06008DAD RID: 36269 RVA: 0x00002050 File Offset: 0x00000250
		public override SkinnedMeshRenderer SkinnedMeshRenderer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06008DAE RID: 36270 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(Skeleton skeleton, PlayerBody playerBody)
		{
			throw null;
		}

		// Token: 0x06008DAF RID: 36271 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ApplySkin()
		{
			throw null;
		}

		// Token: 0x06008DB0 RID: 36272 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Unskin()
		{
			throw null;
		}

		// Token: 0x06008DB1 RID: 36273 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(Tuple<Item, Item, Item, Dress> tuple)
		{
			throw null;
		}

		// Token: 0x04009409 RID: 37897
		[SerializeField]
		private Skin _skin;

		// Token: 0x0400940A RID: 37898
		[SerializeField]
		private Mesh _base;

		// Token: 0x0400940B RID: 37899
		[SerializeField]
		private Mesh _armor;

		// Token: 0x0400940C RID: 37900
		[SerializeField]
		private Mesh _vest;

		// Token: 0x0400940D RID: 37901
		private PlayerBody playerBody_0;
	}
}
