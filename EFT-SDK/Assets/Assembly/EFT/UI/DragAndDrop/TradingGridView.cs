using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using EFT.Trading;
using UnityEngine;

namespace EFT.UI.DragAndDrop
{
	// Token: 0x02002E14 RID: 11796
	public sealed class TradingGridView : GridView
	{
		// Token: 0x1400034A RID: 842
		// (add) Token: 0x0600E85B RID: 59483 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600E85C RID: 59484 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnFilterChanged
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

		// Token: 0x0600E85D RID: 59485 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass2495 grid, GClass2809 sourceContext, TraderAssortmentControllerClass assortment, InventoryControllerClass inventoryController, ItemUiContext itemUiContext)
		{
			throw null;
		}

		// Token: 0x0600E85E RID: 59486 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(IEnumerable<Item> items, GClass2809 sourceContext, TraderAssortmentControllerClass assortment, InventoryControllerClass inventoryController, ItemUiContext itemUiContext, bool raiseEvents = true)
		{
			throw null;
		}

		// Token: 0x0600E85F RID: 59487 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_17(IEnumerable<Item> items, TraderAssortmentControllerClass assortment)
		{
			throw null;
		}

		// Token: 0x0600E860 RID: 59488 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_18()
		{
			throw null;
		}

		// Token: 0x0600E861 RID: 59489 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_19()
		{
			throw null;
		}

		// Token: 0x0600E862 RID: 59490 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_20()
		{
			throw null;
		}

		// Token: 0x0600E863 RID: 59491 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void PrepareItems()
		{
			throw null;
		}

		// Token: 0x0600E864 RID: 59492 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_21()
		{
			throw null;
		}

		// Token: 0x0600E865 RID: 59493 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_22()
		{
			throw null;
		}

		// Token: 0x0600E866 RID: 59494 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool CanAccept(GClass2821 itemContext, GClass2809 targetItemContext, out GStruct412 operation)
		{
			throw null;
		}

		// Token: 0x0600E867 RID: 59495 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Color GetHighlightColor(GClass2821 itemContext, GStruct412 possibleOperation, GClass2809 targetItemContext)
		{
			throw null;
		}

		// Token: 0x0600E868 RID: 59496 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearFilterChoice()
		{
			throw null;
		}

		// Token: 0x0600E869 RID: 59497 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Hide()
		{
			throw null;
		}

		// Token: 0x0400ED6A RID: 60778
		[CompilerGenerated]
		private Action action_0;

		// Token: 0x0400ED6B RID: 60779
		private TraderAssortmentControllerClass gclass2043_0;

		// Token: 0x0400ED6C RID: 60780
		private StashClass gclass2698_0;

		// Token: 0x0400ED6D RID: 60781
		private IEnumerable<Item> ienumerable_1;

		// Token: 0x02002E15 RID: 11797
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2879
		{
			// Token: 0x0600E86A RID: 59498 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<TradingItemReference> method_0(GClass2045 x)
			{
				throw null;
			}

			// Token: 0x0600E86B RID: 59499 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Item method_1(TradingItemReference x)
			{
				throw null;
			}

			// Token: 0x0400ED6E RID: 60782
			public static readonly TradingGridView.Class2879 class2879_0;

			// Token: 0x0400ED6F RID: 60783
			public static Func<GClass2045, IEnumerable<TradingItemReference>> func_0;

			// Token: 0x0400ED70 RID: 60784
			public static Func<TradingItemReference, Item> func_1;
		}
	}
}
