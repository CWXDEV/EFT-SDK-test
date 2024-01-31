using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.Ragfair
{
	// Token: 0x02002F8C RID: 12172
	public sealed class SubcategoryView : NodeBaseView
	{
		// Token: 0x0600F01F RID: 61471 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(RagFairClass ragfair, NodeBaseView categoryView, NodeBaseView subcategoryView, GClass2884 node, EViewListType viewListType, EWindowType windowType, Dictionary<string, NodeBaseView> viewNodes, string forbiddenItem, Action<NodeBaseView, string> onCategorySelected, Action<NodeBaseView, string> onCategoryConfirmed = null)
		{
			throw null;
		}

		// Token: 0x0600F020 RID: 61472 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(GClass2884 node)
		{
			throw null;
		}

		// Token: 0x0600F021 RID: 61473 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OffersCountUpdatedHandler(GClass2884 node)
		{
			throw null;
		}

		// Token: 0x0400F597 RID: 62871
		private const int int_0 = 32;

		// Token: 0x0400F598 RID: 62872
		private const int int_1 = 25;

		// Token: 0x0400F599 RID: 62873
		private const int int_2 = 16;

		// Token: 0x0400F59A RID: 62874
		private const int int_3 = 14;

		// Token: 0x0400F59B RID: 62875
		[SerializeField]
		private LayoutElement _mainLayoutElement;

		// Token: 0x0400F59C RID: 62876
		[SerializeField]
		private CanvasGroup _canvasGroup;
	}
}
