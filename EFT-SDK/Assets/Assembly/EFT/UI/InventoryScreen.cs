using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;
using EFT.HealthSystem;
using EFT.InputSystem;
using EFT.InventoryLogic;
using EFT.UI.Map;
using EFT.UI.Screens;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002A27 RID: 10791
	[UsedImplicitly]
	public sealed class InventoryScreen : EftScreen<InventoryScreen.GClass3116, InventoryScreen>
	{
		// Token: 0x170025FD RID: 9725
		// (get) Token: 0x0600D667 RID: 54887 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600D668 RID: 54888 RVA: 0x00002050 File Offset: 0x00000250
		[UsedImplicitly]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600D669 RID: 54889 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(MapComponent map)
		{
			throw null;
		}

		// Token: 0x0600D66A RID: 54890 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(InventoryScreen.GClass3116 controller)
		{
			throw null;
		}

		// Token: 0x0600D66B RID: 54891 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(IHealthController healthController, InventoryControllerClass controller, AbstractQuestControllerClass questController, AbstractAchievementControllerClass achievementsController, LootItemClass lootItem, InventoryScreen.EInventoryTab tab, ISession session, GClass2809 itemContext, bool showAsGridContent)
		{
			throw null;
		}

		// Token: 0x0600D66C RID: 54892 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_4(InventoryScreen.EInventoryTab arg, bool splitInFrames)
		{
			throw null;
		}

		// Token: 0x0600D66D RID: 54893 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(GClass2934 suite)
		{
			throw null;
		}

		// Token: 0x0600D66E RID: 54894 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600D66F RID: 54895 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600D670 RID: 54896 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600D671 RID: 54897 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x0600D672 RID: 54898 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x0600D673 RID: 54899 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(IResult response)
		{
			throw null;
		}

		// Token: 0x0400D8D0 RID: 55504
		[SerializeField]
		private SimpleStashPanel _simpleStashPanel;

		// Token: 0x0400D8D1 RID: 55505
		[SerializeField]
		private Tab _overallTab;

		// Token: 0x0400D8D2 RID: 55506
		[SerializeField]
		private Tab _gearTab;

		// Token: 0x0400D8D3 RID: 55507
		[SerializeField]
		private Tab _healthTab;

		// Token: 0x0400D8D4 RID: 55508
		[SerializeField]
		private Tab _skillsTab;

		// Token: 0x0400D8D5 RID: 55509
		[SerializeField]
		private Tab _mapTab;

		// Token: 0x0400D8D6 RID: 55510
		[SerializeField]
		private Tab _tasksTab;

		// Token: 0x0400D8D7 RID: 55511
		[SerializeField]
		private Tab _achievementsTab;

		// Token: 0x0400D8D8 RID: 55512
		[SerializeField]
		private ItemsPanel _itemsPanel;

		// Token: 0x0400D8D9 RID: 55513
		[SerializeField]
		private MapScreen _mapScreen;

		// Token: 0x0400D8DA RID: 55514
		[SerializeField]
		private TasksScreen _tasksScreen;

		// Token: 0x0400D8DB RID: 55515
		[SerializeField]
		private AchievementsScreen _achievementsScreen;

		// Token: 0x0400D8DC RID: 55516
		[SerializeField]
		private SkillsAndMasteringScreen _skillsAndMasteringScreen;

		// Token: 0x0400D8DD RID: 55517
		[SerializeField]
		private OverallScreen _overallScreen;

		// Token: 0x0400D8DE RID: 55518
		[SerializeField]
		private bool _playBackpackSounds;

		// Token: 0x0400D8DF RID: 55519
		[SerializeField]
		private DefaultUIButton _backButton;

		// Token: 0x0400D8E0 RID: 55520
		[SerializeField]
		private SortingTableWindow _sortingTable;

		// Token: 0x0400D8E1 RID: 55521
		private ItemUiContext itemUiContext_0;

		// Token: 0x0400D8E2 RID: 55522
		private GClass3065 gclass3065_0;

		// Token: 0x0400D8E3 RID: 55523
		private Dictionary<InventoryScreen.EInventoryTab, Tab> dictionary_0;

		// Token: 0x0400D8E4 RID: 55524
		private InventoryControllerClass gclass2757_0;

		// Token: 0x0400D8E5 RID: 55525
		private IHealthController ihealthController_0;

		// Token: 0x0400D8E6 RID: 55526
		[CanBeNull]
		private LootItemClass gclass2625_0;

		// Token: 0x0400D8E7 RID: 55527
		private Profile profile_0;

		// Token: 0x0400D8E8 RID: 55528
		private ISession ginterface145_0;

		// Token: 0x0400D8E9 RID: 55529
		private InsuranceCompanyClass gclass3179_0;

		// Token: 0x0400D8EA RID: 55530
		private AbstractQuestControllerClass gclass3203_0;

		// Token: 0x0400D8EB RID: 55531
		private AbstractAchievementControllerClass gclass3207_0;

		// Token: 0x0400D8EC RID: 55532
		private GClass2809 gclass2809_0;

		// Token: 0x0400D8ED RID: 55533
		private readonly Dictionary<EBodyModelPart, GClass2934> dictionary_1;

		// Token: 0x0400D8EE RID: 55534
		private Dictionary<EBodyModelPart, string> dictionary_2;

		// Token: 0x02002A28 RID: 10792
		public enum EInventoryTab
		{
			// Token: 0x0400D8F0 RID: 55536
			Unchanged,
			// Token: 0x0400D8F1 RID: 55537
			Overall,
			// Token: 0x0400D8F2 RID: 55538
			Gear,
			// Token: 0x0400D8F3 RID: 55539
			Health,
			// Token: 0x0400D8F4 RID: 55540
			Skills,
			// Token: 0x0400D8F5 RID: 55541
			Map,
			// Token: 0x0400D8F6 RID: 55542
			Notes,
			// Token: 0x0400D8F7 RID: 55543
			Achievements
		}

		// Token: 0x02002A29 RID: 10793
		public abstract class GClass3116 : GClass3107.GClass3109<InventoryScreen.GClass3116, InventoryScreen>
		{
			// Token: 0x170025FE RID: 9726
			// (get) Token: 0x0600D674 RID: 54900 RVA: 0x00002050 File Offset: 0x00000250
			public override EEftScreenType ScreenType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170025FF RID: 9727
			// (get) Token: 0x0600D675 RID: 54901
			public abstract GClass2809 ItemContext { get; }

			// Token: 0x17002600 RID: 9728
			// (get) Token: 0x0600D676 RID: 54902 RVA: 0x00002050 File Offset: 0x00000250
			protected virtual EItemUiContextType ContextType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002601 RID: 9729
			// (get) Token: 0x0600D677 RID: 54903 RVA: 0x00002050 File Offset: 0x00000250
			public virtual Profile Profile
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002602 RID: 9730
			// (get) Token: 0x0600D678 RID: 54904 RVA: 0x00002050 File Offset: 0x00000250
			public virtual bool InRaid
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002603 RID: 9731
			// (get) Token: 0x0600D679 RID: 54905 RVA: 0x00002050 File Offset: 0x00000250
			public virtual bool ShowAsGridContent
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002604 RID: 9732
			// (get) Token: 0x0600D67A RID: 54906 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher MenuChatBarVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002605 RID: 9733
			// (get) Token: 0x0600D67B RID: 54907 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher TaskBarButtonsVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600D67C RID: 54908 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void ShowAction(InventoryScreen screen)
			{
				throw null;
			}

			// Token: 0x0600D67D RID: 54909 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override Task<bool> CloseScreenInterruption(bool moveForward)
			{
				throw null;
			}

			// Token: 0x0600D67E RID: 54910 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void ShowMap(MapComponent map)
			{
				throw null;
			}

			// Token: 0x0600D67F RID: 54911 RVA: 0x00002050 File Offset: 0x00000250
			[DebuggerHidden]
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Task<bool> method_9(bool moveForward)
			{
				throw null;
			}

			// Token: 0x0400D8F8 RID: 55544
			public readonly ISession Session;

			// Token: 0x0400D8F9 RID: 55545
			public readonly IHealthController HealthController;

			// Token: 0x0400D8FA RID: 55546
			public readonly InventoryControllerClass InventoryController;

			// Token: 0x0400D8FB RID: 55547
			public readonly AbstractQuestControllerClass QuestController;

			// Token: 0x0400D8FC RID: 55548
			public readonly AbstractAchievementControllerClass AchievementsController;

			// Token: 0x0400D8FD RID: 55549
			public readonly LootItemClass LootItem;

			// Token: 0x0400D8FE RID: 55550
			public readonly InventoryScreen.EInventoryTab InventoryTab;
		}

		// Token: 0x02002A2B RID: 10795
		public class GClass3117 : InventoryScreen.GClass3116
		{
			// Token: 0x17002606 RID: 9734
			// (get) Token: 0x0600D682 RID: 54914 RVA: 0x00002050 File Offset: 0x00000250
			public override GClass2809 ItemContext
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0400D904 RID: 55556
			[CompilerGenerated]
			private readonly GClass2809 gclass2809_0;
		}

		// Token: 0x02002A2C RID: 10796
		public abstract class GClass3119 : InventoryScreen.GClass3116
		{
			// Token: 0x17002607 RID: 9735
			// (get) Token: 0x0600D683 RID: 54915 RVA: 0x00002050 File Offset: 0x00000250
			public override Profile Profile
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002608 RID: 9736
			// (get) Token: 0x0600D684 RID: 54916 RVA: 0x00002050 File Offset: 0x00000250
			public override bool InRaid
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002609 RID: 9737
			// (get) Token: 0x0600D685 RID: 54917 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher UnrestrictedFrameRate
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700260A RID: 9738
			// (get) Token: 0x0600D686 RID: 54918 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher MenuChatBarVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700260B RID: 9739
			// (get) Token: 0x0600D687 RID: 54919 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher TaskBarButtonsVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700260C RID: 9740
			// (get) Token: 0x0600D688 RID: 54920 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher EnvironmentOverlay
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700260D RID: 9741
			// (get) Token: 0x0600D689 RID: 54921 RVA: 0x00002050 File Offset: 0x00000250
			public override GClass2809 ItemContext
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0400D905 RID: 55557
			[CompilerGenerated]
			private readonly Profile profile_0;

			// Token: 0x0400D906 RID: 55558
			[CompilerGenerated]
			private readonly GClass2809 gclass2809_0;
		}

		// Token: 0x02002A2D RID: 10797
		public sealed class GClass3120 : InventoryScreen.GClass3119
		{
			// Token: 0x1700260E RID: 9742
			// (get) Token: 0x0600D68A RID: 54922 RVA: 0x00002050 File Offset: 0x00000250
			public override bool ShowAsGridContent
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0400D907 RID: 55559
			[CompilerGenerated]
			private readonly bool bool_4;
		}

		// Token: 0x02002A2E RID: 10798
		public sealed class GClass3118 : InventoryScreen.GClass3117
		{
			// Token: 0x1700260F RID: 9743
			// (get) Token: 0x0600D68B RID: 54923 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher UnrestrictedFrameRate
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002610 RID: 9744
			// (get) Token: 0x0600D68C RID: 54924 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher MenuChatBarVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002611 RID: 9745
			// (get) Token: 0x0600D68D RID: 54925 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher TaskBarButtonsVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002612 RID: 9746
			// (get) Token: 0x0600D68E RID: 54926 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher EnvironmentOverlay
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}
		}

		// Token: 0x02002A2F RID: 10799
		[CompilerGenerated]
		private sealed class Class2496
		{
			// Token: 0x0600D68F RID: 54927 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(GEventArgs3 removeArgs)
			{
				throw null;
			}

			// Token: 0x0400D908 RID: 55560
			public LootItemClass originalLootItem;

			// Token: 0x0400D909 RID: 55561
			public InventoryScreen inventoryScreen_0;
		}

		// Token: 0x02002A30 RID: 10800
		[CompilerGenerated]
		private sealed class Class2497
		{
			// Token: 0x0600D690 RID: 54928 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400D90A RID: 55562
			public IItemOwner itemOwner;

			// Token: 0x0400D90B RID: 55563
			public InventoryScreen.Class2496 class2496_0;
		}

		// Token: 0x02002A32 RID: 10802
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2499
		{
			// Token: 0x0600D695 RID: 54933 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0(KeyValuePair<EBodyModelPart, GClass2934> quipped)
			{
				throw null;
			}

			// Token: 0x0400D912 RID: 55570
			public static readonly InventoryScreen.Class2499 class2499_0;

			// Token: 0x0400D913 RID: 55571
			public static Func<KeyValuePair<EBodyModelPart, GClass2934>, string> func_0;
		}
	}
}
