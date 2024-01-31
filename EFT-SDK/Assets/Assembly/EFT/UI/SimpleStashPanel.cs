using System;
using System.Runtime.CompilerServices;
using EFT.UI.DragAndDrop;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002AE9 RID: 10985
	public sealed class SimpleStashPanel : UIElement, IDisposable, GInterface367
	{
		// Token: 0x140002FF RID: 767
		// (add) Token: 0x0600DA2D RID: 55853 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600DA2E RID: 55854 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnSortingTableTabSelected
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x0600DA2F RID: 55855 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Configure(LootItemClass item, InventoryControllerClass inventoryController, GClass2809 itemContext)
		{
			throw null;
		}

		// Token: 0x0600DA30 RID: 55856 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(InventoryControllerClass leftSideInventoryController = null, ItemsPanel.EItemsTab tab = ItemsPanel.EItemsTab.Gear)
		{
			throw null;
		}

		// Token: 0x0600DA31 RID: 55857 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(ItemsPanel.EItemsTab tab)
		{
			throw null;
		}

		// Token: 0x0600DA32 RID: 55858 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(Tab _, bool isVisible)
		{
			throw null;
		}

		// Token: 0x0600DA33 RID: 55859 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeSortingTableTabState(bool isVisible)
		{
			throw null;
		}

		// Token: 0x0600DA34 RID: 55860 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600DA35 RID: 55861 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600DA36 RID: 55862 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600DA37 RID: 55863 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600DA38 RID: 55864 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0400DD20 RID: 56608
		[CompilerGenerated]
		private Action action_0;

		// Token: 0x0400DD21 RID: 56609
		[SerializeField]
		private SearchableItemView _simplePanel;

		// Token: 0x0400DD22 RID: 56610
		[SerializeField]
		private TextMeshProUGUI _simpleGridName;

		// Token: 0x0400DD23 RID: 56611
		[SerializeField]
		private FilterPanel _filterPanel;

		// Token: 0x0400DD24 RID: 56612
		[SerializeField]
		private DisplayMoneyPanel _moneyCountPanel;

		// Token: 0x0400DD25 RID: 56613
		[SerializeField]
		private GameObject _containerNamePanel;

		// Token: 0x0400DD26 RID: 56614
		[SerializeField]
		private TextMeshProUGUI _containerName;

		// Token: 0x0400DD27 RID: 56615
		[SerializeField]
		private GameObject _sortPanel;

		// Token: 0x0400DD28 RID: 56616
		[SerializeField]
		private GridSortPanel _gridSortPanel;

		// Token: 0x0400DD29 RID: 56617
		[SerializeField]
		private Tab _sortingTableTab;

		// Token: 0x0400DD2A RID: 56618
		[SerializeField]
		private ScrollRect _stashScroll;

		// Token: 0x0400DD2B RID: 56619
		private GClass3056 gclass3056_0;

		// Token: 0x0400DD2C RID: 56620
		private InventoryControllerClass gclass2757_0;

		// Token: 0x0400DD2D RID: 56621
		private LootItemClass gclass2625_0;

		// Token: 0x0400DD2E RID: 56622
		private GClass2809 gclass2809_0;

		// Token: 0x0400DD2F RID: 56623
		private ItemUiContext itemUiContext_0;

		// Token: 0x0400DD30 RID: 56624
		private InventoryControllerClass gclass2757_1;

		// Token: 0x0400DD31 RID: 56625
		private bool bool_0;
	}
}
