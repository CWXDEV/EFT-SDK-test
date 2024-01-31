using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using EFT.UI.DragAndDrop;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.UI
{
	// Token: 0x020029F6 RID: 10742
	public sealed class GridWindow : Window<GClass3085>, IEventSystemHandler, IPointerClickHandler, GInterface104, GInterface106
	{
		// Token: 0x0600D56B RID: 54635 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600D56C RID: 54636 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(LootItemClass compoundItem, GClass2809 itemContext, InventoryControllerClass inventoryController, Action onSelected, Action onClosed, ItemUiContext itemUiContext, bool searchButtonDisplay)
		{
			throw null;
		}

		// Token: 0x0600D56D RID: 54637 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600D56E RID: 54638 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600D56F RID: 54639 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600D570 RID: 54640 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600D571 RID: 54641 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnItemRemoved(GEventArgs3 removeItemEventArgs)
		{
			throw null;
		}

		// Token: 0x0600D572 RID: 54642 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600D573 RID: 54643 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0400D78C RID: 55180
		[SerializeField]
		private SearchableView _searchableView;

		// Token: 0x0400D78D RID: 55181
		[SerializeField]
		private ContainedGridsView _containedGridsTemplate;

		// Token: 0x0400D78E RID: 55182
		[SerializeField]
		private TextMeshProUGUI _tagName;

		// Token: 0x0400D78F RID: 55183
		[SerializeField]
		private GridSortPanel _sortPanel;

		// Token: 0x0400D790 RID: 55184
		private ContainedGridsView containedGridsView_0;

		// Token: 0x0400D791 RID: 55185
		private InventoryControllerClass gclass2757_0;

		// Token: 0x0400D792 RID: 55186
		private GClass2809 gclass2809_0;

		// Token: 0x0400D793 RID: 55187
		private LootItemClass gclass2625_0;

		// Token: 0x0400D794 RID: 55188
		private IItemOwner iitemOwner_0;

		// Token: 0x0400D795 RID: 55189
		private ItemUiContext itemUiContext_0;

		// Token: 0x0400D796 RID: 55190
		private Action action_1;

		// Token: 0x0400D797 RID: 55191
		private Item[] item_0;
	}
}
