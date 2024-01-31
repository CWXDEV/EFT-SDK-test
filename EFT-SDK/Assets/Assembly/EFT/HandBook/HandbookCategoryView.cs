using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.UI.Ragfair;
using UnityEngine;

namespace EFT.HandBook
{
	// Token: 0x0200261C RID: 9756
	public sealed class HandbookCategoryView : CategoryView
	{
		// Token: 0x0600C1CB RID: 49611 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(RagFairClass ragfair, NodeBaseView categoryView, NodeBaseView subcategoryView, GClass2884 node, EViewListType viewListType, EWindowType windowType, Dictionary<string, NodeBaseView> viewNodes, string forbiddenItem, Action<NodeBaseView, string> onCategorySelected, Action<NodeBaseView, string> onCategoryConfirmed = null)
		{
			throw null;
		}

		// Token: 0x0600C1CC RID: 49612 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override RectTransform GetSubcategoryContainer()
		{
			throw null;
		}

		// Token: 0x0400C3D0 RID: 50128
		[SerializeField]
		private RectTransform _nodesContainer;
	}
}
