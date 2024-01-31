using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using EFT.UI.DragAndDrop;
using UnityEngine;

namespace EFT.UI.Insurance
{
	// Token: 0x02002ECE RID: 11982
	public sealed class InsuranceSearchableSlotView : InsuranceSlotView
	{
		// Token: 0x0600EC77 RID: 60535 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(Slot slot, GClass2809 parentItemContext, InventoryControllerClass inventoryController, ItemUiContext itemUiContext, SkillManager skills, InsuranceCompanyClass insurance, bool canClickOnHeader = false)
		{
			throw null;
		}

		// Token: 0x0600EC78 RID: 60536 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13(Item item)
		{
			throw null;
		}

		// Token: 0x0600EC79 RID: 60537 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_14(Item item)
		{
			throw null;
		}

		// Token: 0x0600EC7A RID: 60538 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_15(bool value)
		{
			throw null;
		}

		// Token: 0x0600EC7B RID: 60539 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void DragStarted()
		{
			throw null;
		}

		// Token: 0x0600EC7C RID: 60540 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void DragCancelled()
		{
			throw null;
		}

		// Token: 0x0600EC7D RID: 60541 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnAddToSlot(Item item, GEventArgs2 args)
		{
			throw null;
		}

		// Token: 0x0600EC7E RID: 60542 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnRemoveFromSlot(Item item, GEventArgs3 args)
		{
			throw null;
		}

		// Token: 0x0600EC7F RID: 60543 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600EC80 RID: 60544 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_16(int searchOperationsCount)
		{
			throw null;
		}

		// Token: 0x0400F175 RID: 61813
		[SerializeField]
		private SearchableItemView _searchableItemView;

		// Token: 0x0400F176 RID: 61814
		[SerializeField]
		private Transform _specSlotsPanel;

		// Token: 0x0400F177 RID: 61815
		[SerializeField]
		private SlotView _specSlotTemplate;

		// Token: 0x0400F178 RID: 61816
		[SerializeField]
		private CustomTextMeshProUGUI _specSlotHeader;

		// Token: 0x0400F179 RID: 61817
		private List<SlotView> list_0;

		// Token: 0x0400F17A RID: 61818
		private const string string_0 = "InventoryScreen/SpecialSlotsHeader";

		// Token: 0x0400F17B RID: 61819
		private Action action_4;
	}
}
