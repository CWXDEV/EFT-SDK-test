using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using UnityEngine;

namespace EFT.UI.DragAndDrop
{
	// Token: 0x02002DF9 RID: 11769
	public sealed class BoundSlotView : QuickSlotView, GInterface104, GInterface105, GInterface106, GInterface117, GInterface118
	{
		// Token: 0x0600E77A RID: 59258 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Slot GetSlot()
		{
			throw null;
		}

		// Token: 0x0600E77B RID: 59259 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetBoundIndex(EBoundItem boundIndex)
		{
			throw null;
		}

		// Token: 0x0600E77C RID: 59260 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Slot slot, InventoryControllerClass inventoryController, ItemUiContext itemUiContext)
		{
			throw null;
		}

		// Token: 0x0600E77D RID: 59261 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(Slot slot, InventoryControllerClass inventoryController, ItemUiContext itemUiContext)
		{
			throw null;
		}

		// Token: 0x0600E77E RID: 59262 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SetIconScale()
		{
			throw null;
		}

		// Token: 0x0600E77F RID: 59263 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(Slot slot, InventoryControllerClass inventoryController, ItemUiContext itemUiContext)
		{
			throw null;
		}

		// Token: 0x0600E780 RID: 59264 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RefreshSelectView(Item itemInHands)
		{
			throw null;
		}

		// Token: 0x0600E781 RID: 59265 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Hide()
		{
			throw null;
		}

		// Token: 0x0600E782 RID: 59266 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSetInHands(GEventArgs10 args)
		{
			throw null;
		}

		// Token: 0x0600E783 RID: 59267 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnRemoveFromHands(GEventArgs11 args)
		{
			throw null;
		}

		// Token: 0x0600E784 RID: 59268 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnItemRemoved(GEventArgs3 eventArgs)
		{
			throw null;
		}

		// Token: 0x0600E785 RID: 59269 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnItemAdded(GEventArgs2 eventArgs)
		{
			throw null;
		}

		// Token: 0x0600E786 RID: 59270 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600E787 RID: 59271 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool CanAccept(GClass2821 itemContext, GClass2809 targetItemContext, out GStruct412 operation)
		{
			throw null;
		}

		// Token: 0x0600E788 RID: 59272 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool CanDrag(GClass2809 itemContext)
		{
			throw null;
		}

		// Token: 0x0400ECB5 RID: 60597
		[SerializeField]
		private BoundSlotView _subWeaponView;

		// Token: 0x0400ECB6 RID: 60598
		private Slot slot_0;
	}
}
