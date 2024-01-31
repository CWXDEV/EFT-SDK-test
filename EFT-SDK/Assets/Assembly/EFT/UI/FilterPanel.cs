using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.UI
{
	// Token: 0x0200297F RID: 10623
	public class FilterPanel : UIElement
	{
		// Token: 0x140002E5 RID: 741
		// (add) Token: 0x0600D36C RID: 54124 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600D36D RID: 54125 RVA: 0x00002050 File Offset: 0x00000250
		public event Action CurrentFilterChanged
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

		// Token: 0x1700258E RID: 9614
		// (get) Token: 0x0600D36E RID: 54126 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D36F RID: 54127 RVA: 0x00002050 File Offset: 0x00000250
		private FilterPanel.Class2427 Class2427_0
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600D370 RID: 54128 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_0(Item item, Type[] types)
		{
			throw null;
		}

		// Token: 0x0600D371 RID: 54129 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Awake()
		{
			throw null;
		}

		// Token: 0x0600D372 RID: 54130 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void FilterChanged()
		{
			throw null;
		}

		// Token: 0x0600D373 RID: 54131 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void PreInit(TraderAssortmentControllerClass assortment, [CanBeNull] IEnumerable<Item> items)
		{
			throw null;
		}

		// Token: 0x0600D374 RID: 54132 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Init()
		{
			throw null;
		}

		// Token: 0x0600D375 RID: 54133 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void RegisterItem(Item item)
		{
			throw null;
		}

		// Token: 0x0600D376 RID: 54134 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void UnregisterItem(Item item)
		{
			throw null;
		}

		// Token: 0x0600D377 RID: 54135 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearAll()
		{
			throw null;
		}

		// Token: 0x0600D378 RID: 54136 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetFilterTabAlpha(Item item)
		{
			throw null;
		}

		// Token: 0x0600D379 RID: 54137 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool IsFilteredSingleItem(Item item)
		{
			throw null;
		}

		// Token: 0x0600D37A RID: 54138 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual IEnumerable<Item> GetFilteredItems(IEnumerable<Item> allItems)
		{
			throw null;
		}

		// Token: 0x0600D37B RID: 54139 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Hide()
		{
			throw null;
		}

		// Token: 0x0600D37C RID: 54140 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ClearChoice()
		{
			throw null;
		}

		// Token: 0x0600D37D RID: 54141 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(FilterPanel.Class2427 filter)
		{
			throw null;
		}

		// Token: 0x0600D37E RID: 54142 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(PointerEventData arg)
		{
			throw null;
		}

		// Token: 0x0600D37F RID: 54143 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_2(Item item)
		{
			throw null;
		}

		// Token: 0x0400D570 RID: 54640
		private static readonly FilterPanel.Class2427[] class2427_0;

		// Token: 0x0400D571 RID: 54641
		[CompilerGenerated]
		private Action action_0;

		// Token: 0x0400D572 RID: 54642
		[SerializeField]
		protected FilterTab[] _filterTabs;

		// Token: 0x0400D573 RID: 54643
		public bool RememberChoice;

		// Token: 0x0400D574 RID: 54644
		protected SimpleTooltip _tooltip;

		// Token: 0x0400D575 RID: 54645
		protected GClass3065 _tabs;

		// Token: 0x0400D576 RID: 54646
		private readonly Dictionary<FilterPanel.EFilterItemType, FilterTab> dictionary_0;

		// Token: 0x0400D577 RID: 54647
		private readonly List<Item> list_0;

		// Token: 0x0400D578 RID: 54648
		[CompilerGenerated]
		private FilterPanel.Class2427 class2427_1;

		// Token: 0x02002980 RID: 10624
		private enum EFilterItemType
		{
			// Token: 0x0400D57A RID: 54650
			None,
			// Token: 0x0400D57B RID: 54651
			All,
			// Token: 0x0400D57C RID: 54652
			Ammo,
			// Token: 0x0400D57D RID: 54653
			Barter,
			// Token: 0x0400D57E RID: 54654
			Container,
			// Token: 0x0400D57F RID: 54655
			Food,
			// Token: 0x0400D580 RID: 54656
			Goggles,
			// Token: 0x0400D581 RID: 54657
			Rig,
			// Token: 0x0400D582 RID: 54658
			Armor,
			// Token: 0x0400D583 RID: 54659
			Grenade,
			// Token: 0x0400D584 RID: 54660
			Info,
			// Token: 0x0400D585 RID: 54661
			Keys,
			// Token: 0x0400D586 RID: 54662
			Knife,
			// Token: 0x0400D587 RID: 54663
			Magazine,
			// Token: 0x0400D588 RID: 54664
			Meds,
			// Token: 0x0400D589 RID: 54665
			Mod,
			// Token: 0x0400D58A RID: 54666
			Special,
			// Token: 0x0400D58B RID: 54667
			Weapon,
			// Token: 0x0400D58C RID: 54668
			FoundInRaid
		}

		// Token: 0x02002981 RID: 10625
		private class Class2427
		{
			// Token: 0x1700258F RID: 9615
			// (get) Token: 0x0600D380 RID: 54144 RVA: 0x00002050 File Offset: 0x00000250
			public FilterPanel.EFilterItemType Type
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600D381 RID: 54145 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual bool Check(Item item)
			{
				throw null;
			}

			// Token: 0x0400D58D RID: 54669
			[CompilerGenerated]
			private readonly FilterPanel.EFilterItemType efilterItemType_0;
		}

		// Token: 0x02002982 RID: 10626
		private sealed class Class2428 : FilterPanel.Class2427
		{
			// Token: 0x0600D382 RID: 54146 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool Check(Item item)
			{
				throw null;
			}
		}

		// Token: 0x02002983 RID: 10627
		private sealed class Class2429 : FilterPanel.Class2427
		{
			// Token: 0x0600D383 RID: 54147 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool Check(Item item)
			{
				throw null;
			}

			// Token: 0x0400D58E RID: 54670
			private readonly Type[] type_0;
		}

		// Token: 0x02002984 RID: 10628
		private sealed class Class2626 : GClass3057
		{
			// Token: 0x0600D384 RID: 54148 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Show()
			{
				throw null;
			}

			// Token: 0x0400D58F RID: 54671
			private readonly FilterPanel.Class2427 class2427_0;

			// Token: 0x0400D590 RID: 54672
			private readonly FilterPanel filterPanel_0;
		}

		// Token: 0x02002985 RID: 10629
		[CompilerGenerated]
		private sealed class Class2430
		{
			// Token: 0x0600D385 RID: 54149 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Type x)
			{
				throw null;
			}

			// Token: 0x0400D591 RID: 54673
			public Type itemType;
		}

		// Token: 0x02002986 RID: 10630
		[CompilerGenerated]
		private sealed class Class2431
		{
			// Token: 0x0600D386 RID: 54150 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(PointerEventData arg)
			{
				throw null;
			}

			// Token: 0x0400D592 RID: 54674
			public FilterPanel.Class2427 filterRule;

			// Token: 0x0400D593 RID: 54675
			public int index;

			// Token: 0x0400D594 RID: 54676
			public FilterPanel filterPanel_0;
		}

		// Token: 0x02002987 RID: 10631
		[CompilerGenerated]
		private sealed class Class2432
		{
			// Token: 0x0600D387 RID: 54151 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Item x)
			{
				throw null;
			}

			// Token: 0x0400D595 RID: 54677
			public FilterPanel.Class2427 filterRule;
		}
	}
}
