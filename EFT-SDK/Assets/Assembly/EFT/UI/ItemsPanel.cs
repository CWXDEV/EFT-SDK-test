using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.HealthSystem;
using EFT.InventoryLogic;
using EFT.UI.DragAndDrop;
using EFT.UI.Health;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002B0B RID: 11019
	public sealed class ItemsPanel : UIElement
	{
		// Token: 0x14000301 RID: 769
		// (add) Token: 0x0600DAB2 RID: 55986 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600DAB3 RID: 55987 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnBackButtonClick
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

		// Token: 0x0600DAB4 RID: 55988 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task Show(GClass2809 sourceContext, LootItemClass lootItem, ISession session, InventoryControllerClass inventoryController, IHealthController health, Profile profile, InsuranceCompanyClass insurance, GClass3182 buildsStorage, ItemsPanel.EItemsTab currentTab, bool inRaid)
		{
			throw null;
		}

		// Token: 0x0600DAB5 RID: 55989 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400DDC0 RID: 56768
		[SerializeField]
		private SimpleStashPanel _simpleStashPanel;

		// Token: 0x0400DDC1 RID: 56769
		[SerializeField]
		private ComplexStashPanel _complexStashPanel;

		// Token: 0x0400DDC2 RID: 56770
		[SerializeField]
		private HealthParametersPanel _healthParametersPanel;

		// Token: 0x0400DDC3 RID: 56771
		[SerializeField]
		private EquipmentBuildPanel _equipmentBuildPanel;

		// Token: 0x0400DDC4 RID: 56772
		[SerializeField]
		private EquipmentTab _equipmentPanel;

		// Token: 0x0400DDC5 RID: 56773
		[SerializeField]
		private InventoryScreenHealthPanel _healthPanel;

		// Token: 0x0400DDC6 RID: 56774
		[SerializeField]
		private ContainersPanel _containers;

		// Token: 0x0400DDC7 RID: 56775
		[SerializeField]
		private InventoryScreenQuickAccessPanel _quickUse;

		// Token: 0x0400DDC8 RID: 56776
		[SerializeField]
		private DefaultUIButton _backButton;

		// Token: 0x0400DDC9 RID: 56777
		[CompilerGenerated]
		private Action action_0;

		// Token: 0x0400DDCA RID: 56778
		public bool SplitInFrames;

		// Token: 0x0400DDCB RID: 56779
		private ItemsPanel.EItemsTab eitemsTab_0;

		// Token: 0x0400DDCC RID: 56780
		private ISession ginterface145_0;

		// Token: 0x0400DDCD RID: 56781
		private InventoryControllerClass gclass2757_0;

		// Token: 0x0400DDCE RID: 56782
		private ItemUiContext itemUiContext_0;

		// Token: 0x0400DDCF RID: 56783
		private SkillManager skillManager_0;

		// Token: 0x0400DDD0 RID: 56784
		private Inventory inventory_0;

		// Token: 0x0400DDD1 RID: 56785
		private InsuranceCompanyClass gclass3179_0;

		// Token: 0x0400DDD2 RID: 56786
		private IHealthController ihealthController_0;

		// Token: 0x0400DDD3 RID: 56787
		private Profile profile_0;

		// Token: 0x0400DDD4 RID: 56788
		[CanBeNull]
		private GInterface367 ginterface367_0;

		// Token: 0x02002B0C RID: 11020
		public enum EItemsTab
		{
			// Token: 0x0400DDD6 RID: 56790
			Gear,
			// Token: 0x0400DDD7 RID: 56791
			Health
		}

		// Token: 0x02002B0D RID: 11021
		public sealed class GClass3059 : GClass3058<ItemsPanel>
		{
			// Token: 0x0600DAB6 RID: 55990 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Show()
			{
				throw null;
			}

			// Token: 0x0600DAB7 RID: 55991 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override Task<bool> TryHide()
			{
				throw null;
			}

			// Token: 0x0600DAB8 RID: 55992 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[DebuggerHidden]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Task<bool> method_0()
			{
				throw null;
			}

			// Token: 0x0400DDD8 RID: 56792
			private readonly InventoryControllerClass gclass2757_0;

			// Token: 0x0400DDD9 RID: 56793
			private readonly ISession ginterface145_0;

			// Token: 0x0400DDDA RID: 56794
			private readonly LootItemClass gclass2625_0;

			// Token: 0x0400DDDB RID: 56795
			private readonly GClass2809 gclass2809_0;

			// Token: 0x0400DDDC RID: 56796
			private readonly IHealthController ihealthController_0;

			// Token: 0x0400DDDD RID: 56797
			private readonly InsuranceCompanyClass gclass3179_0;

			// Token: 0x0400DDDE RID: 56798
			private readonly ItemsPanel.EItemsTab eitemsTab_0;

			// Token: 0x0400DDDF RID: 56799
			[CanBeNull]
			private readonly SortingTableWindow sortingTableWindow_0;

			// Token: 0x0400DDE0 RID: 56800
			private readonly GClass3182 gclass3182_0;

			// Token: 0x0400DDE1 RID: 56801
			private readonly bool bool_0;

			// Token: 0x0400DDE2 RID: 56802
			private readonly Profile profile_0;
		}

		// Token: 0x02002B0F RID: 11023
		[CompilerGenerated]
		private sealed class Class2584
		{
			// Token: 0x0600DABB RID: 55995 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600DABC RID: 55996 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x0600DABD RID: 55997 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2()
			{
				throw null;
			}

			// Token: 0x0400DDE7 RID: 56807
			public ItemsPanel itemsPanel_0;

			// Token: 0x0400DDE8 RID: 56808
			public bool wasClosed;

			// Token: 0x0400DDE9 RID: 56809
			public GClass2809 equipmentContext;
		}

		// Token: 0x02002B10 RID: 11024
		[CompilerGenerated]
		private sealed class Class2585
		{
			// Token: 0x0600DABE RID: 55998 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400DDEA RID: 56810
			public GClass2759 backendController;

			// Token: 0x0400DDEB RID: 56811
			public ItemsPanel.Class2584 class2584_0;
		}
	}
}
