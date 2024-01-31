using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using UI;
using UnityEngine;

namespace EFT.UI.DragAndDrop
{
	// Token: 0x02002E53 RID: 11859
	public class TemplatedGridsView : ContainedGridsView
	{
		// Token: 0x1400034B RID: 843
		// (add) Token: 0x0600EA3F RID: 59967 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600EA40 RID: 59968 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<IContainer, string> OnItemFilter
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

		// Token: 0x1400034C RID: 844
		// (add) Token: 0x0600EA41 RID: 59969 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600EA42 RID: 59970 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<string> OnAllItemFilter
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

		// Token: 0x0600EA43 RID: 59971 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(LootItemClass compoundItem, GClass2809 itemContext, InventoryControllerClass inventoryController, FilterPanel filterPanel, ItemUiContext itemUiContext, bool magnify = false)
		{
			throw null;
		}

		// Token: 0x0600EA44 RID: 59972 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0400EE9C RID: 61084
		[SerializeField]
		private GridView[] _presetGridViews;

		// Token: 0x0400EE9D RID: 61085
		[SerializeField]
		private SlotView[] _presetSlotViews;

		// Token: 0x0400EE9E RID: 61086
		[SerializeField]
		private Dictionary<GridView, LocalizedFilterButton> _gridButtons;

		// Token: 0x0400EE9F RID: 61087
		[SerializeField]
		private Dictionary<SlotView, LocalizedFilterButton> _slotButtons;

		// Token: 0x0400EEA0 RID: 61088
		[SerializeField]
		private LocalizedFilterButton _generalSortButton;

		// Token: 0x0400EEA1 RID: 61089
		public Transform SwitchZoneTabsPosition;

		// Token: 0x0400EEA2 RID: 61090
		[CompilerGenerated]
		private Action<IContainer, string> action_0;

		// Token: 0x0400EEA3 RID: 61091
		[CompilerGenerated]
		private Action<string> action_1;

		// Token: 0x02002E54 RID: 11860
		[CompilerGenerated]
		private sealed class Class2897
		{
			// Token: 0x0600EA45 RID: 59973 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400EEA4 RID: 61092
			public GridView view;

			// Token: 0x0400EEA5 RID: 61093
			public LocalizedFilterButton button;

			// Token: 0x0400EEA6 RID: 61094
			public TemplatedGridsView templatedGridsView_0;
		}

		// Token: 0x02002E55 RID: 11861
		[CompilerGenerated]
		private sealed class Class2898
		{
			// Token: 0x0600EA46 RID: 59974 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400EEA7 RID: 61095
			public SlotView view;

			// Token: 0x0400EEA8 RID: 61096
			public LocalizedFilterButton button;

			// Token: 0x0400EEA9 RID: 61097
			public TemplatedGridsView templatedGridsView_0;
		}
	}
}
