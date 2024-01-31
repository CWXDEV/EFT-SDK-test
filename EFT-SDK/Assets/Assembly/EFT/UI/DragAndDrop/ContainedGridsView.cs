using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;

namespace EFT.UI.DragAndDrop
{
	// Token: 0x02002DF6 RID: 11766
	public abstract class ContainedGridsView : UIElement
	{
		// Token: 0x0600E76A RID: 59242 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static ContainedGridsView CreateGrids(Item item, ContainedGridsView containedGridsTemplate)
		{
			throw null;
		}

		// Token: 0x0600E76B RID: 59243
		public abstract void Show(LootItemClass compoundItem, GClass2809 itemContext, InventoryControllerClass inventoryController, FilterPanel filterPanel, ItemUiContext itemUiContext, bool magnify = false);

		// Token: 0x0600E76C RID: 59244 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Show(LootItemClass compoundItem, GClass2809 itemContext, GridView[] gridViews, SlotView[] slotViews, InventoryControllerClass inventoryController, FilterPanel filterPanel, ItemUiContext itemUiContext, bool magnify = false)
		{
			throw null;
		}

		// Token: 0x0600E76D RID: 59245 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400ECB3 RID: 60595
		public GridView[] GridViews;

		// Token: 0x0400ECB4 RID: 60596
		public SlotView[] SlotViews;
	}
}
