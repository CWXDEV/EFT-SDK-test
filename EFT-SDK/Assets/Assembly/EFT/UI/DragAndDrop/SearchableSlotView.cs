using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using UnityEngine;

namespace EFT.UI.DragAndDrop
{
	// Token: 0x02002E0D RID: 11789
	public class SearchableSlotView : SlotView
	{
		// Token: 0x0600E80E RID: 59406 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(Slot slot, GClass2809 parentItemContext, InventoryControllerClass inventoryController, ItemUiContext itemUiContext, SkillManager skills, InsuranceCompanyClass insurance, bool canClickOnHeader = false)
		{
			throw null;
		}

		// Token: 0x0600E80F RID: 59407 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13(Item item)
		{
			throw null;
		}

		// Token: 0x0600E810 RID: 59408 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_14(Item item)
		{
			throw null;
		}

		// Token: 0x0600E811 RID: 59409 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_15(bool value)
		{
			throw null;
		}

		// Token: 0x0600E812 RID: 59410 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void DragStarted()
		{
			throw null;
		}

		// Token: 0x0600E813 RID: 59411 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void DragCancelled()
		{
			throw null;
		}

		// Token: 0x0600E814 RID: 59412 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnAddToSlot(Item item, GEventArgs2 args)
		{
			throw null;
		}

		// Token: 0x0600E815 RID: 59413 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnRemoveFromSlot(Item item, GEventArgs3 args)
		{
			throw null;
		}

		// Token: 0x0600E816 RID: 59414 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600E817 RID: 59415 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_16()
		{
			throw null;
		}

		// Token: 0x0600E818 RID: 59416 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_17(int searchOperationsCount)
		{
			throw null;
		}

		// Token: 0x0400ED28 RID: 60712
		[SerializeField]
		private SearchableItemView _searchableItemView;

		// Token: 0x0400ED29 RID: 60713
		[SerializeField]
		private Transform _specSlotsPanel;

		// Token: 0x0400ED2A RID: 60714
		[SerializeField]
		private SlotView _specSlotTemplate;

		// Token: 0x0400ED2B RID: 60715
		[SerializeField]
		private CustomTextMeshProUGUI _specSlotHeader;

		// Token: 0x0400ED2C RID: 60716
		private List<SlotView> list_0;

		// Token: 0x0400ED2D RID: 60717
		private const string string_0 = "Pockets";

		// Token: 0x0400ED2E RID: 60718
		private const string string_1 = "InventoryScreen/SpecialSlotsHeader";

		// Token: 0x0400ED2F RID: 60719
		private Action action_4;

		// Token: 0x02002E0E RID: 11790
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2876
		{
			// Token: 0x0600E819 RID: 59417 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Slot slot)
			{
				throw null;
			}

			// Token: 0x0400ED30 RID: 60720
			public static readonly SearchableSlotView.Class2876 class2876_0;

			// Token: 0x0400ED31 RID: 60721
			public static Func<Slot, bool> func_0;
		}
	}
}
