using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.UI.DragAndDrop
{
	// Token: 0x02002E0C RID: 11788
	public sealed class SearchableItemView : MonoBehaviour
	{
		// Token: 0x0600E807 RID: 59399 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600E808 RID: 59400 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(LootItemClass compoundItem, GClass2809 itemContext, InventoryControllerClass inventoryController, [CanBeNull] FilterPanel filterPanel, ItemUiContext itemUiContext)
		{
			throw null;
		}

		// Token: 0x0600E809 RID: 59401 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowContents()
		{
			throw null;
		}

		// Token: 0x0600E80A RID: 59402 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600E80B RID: 59403 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HideContents()
		{
			throw null;
		}

		// Token: 0x0600E80C RID: 59404 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			throw null;
		}

		// Token: 0x0600E80D RID: 59405 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Close()
		{
			throw null;
		}

		// Token: 0x0400ED1D RID: 60701
		[SerializeField]
		private SearchableView _searchableView;

		// Token: 0x0400ED1E RID: 60702
		[SerializeField]
		private ContainedGridsView _containedGridsTemplate;

		// Token: 0x0400ED1F RID: 60703
		[SerializeField]
		private Transform _gridsContainer;

		// Token: 0x0400ED20 RID: 60704
		[SerializeField]
		private GridViewMagnifier _viewMagnifier;

		// Token: 0x0400ED21 RID: 60705
		private ContainedGridsView containedGridsView_0;

		// Token: 0x0400ED22 RID: 60706
		private GClass2809 gclass2809_0;

		// Token: 0x0400ED23 RID: 60707
		private LootItemClass gclass2625_0;

		// Token: 0x0400ED24 RID: 60708
		private InventoryControllerClass gclass2757_0;

		// Token: 0x0400ED25 RID: 60709
		private FilterPanel filterPanel_0;

		// Token: 0x0400ED26 RID: 60710
		private ItemUiContext itemUiContext_0;

		// Token: 0x0400ED27 RID: 60711
		private bool bool_0;
	}
}
