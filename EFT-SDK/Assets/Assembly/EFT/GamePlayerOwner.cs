using System;
using System.Collections;
using System.Runtime.CompilerServices;
using EFT.HealthSystem;
using EFT.InputSystem;
using EFT.InventoryLogic;
using EFT.UI;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT
{
	// Token: 0x020018E2 RID: 6370
	public class GamePlayerOwner : PlayerOwner
	{
		// Token: 0x0600891D RID: 35101 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static TPlayerOwner Create<TPlayerOwner>(Player player, GInterface155 inputTree, InsuranceCompanyClass insurance, ISession session, CommonUI commonUI, PreloaderUI preloaderUI, GameUI gameUI, GameDateTime gameDateTime, [CanBeNull] LocationSettingsClass.Location location) where TPlayerOwner : GamePlayerOwner
		{
			throw null;
		}

		// Token: 0x17001505 RID: 5381
		// (get) Token: 0x0600891E RID: 35102 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600891F RID: 35103 RVA: 0x00002050 File Offset: 0x00000250
		public static bool IgnoreInputInNPCDialog
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17001506 RID: 5382
		// (get) Token: 0x06008920 RID: 35104 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008921 RID: 35105 RVA: 0x00002050 File Offset: 0x00000250
		public static bool IgnoreInputWithKeepResetLook
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06008922 RID: 35106 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static GamePlayerOwner smethod_2(Player player, GInterface155 inputTree, InsuranceCompanyClass insurance, ISession session, CommonUI commonUI, PreloaderUI preloaderUI, GameUI gameUI, GameDateTime gameDateTime, [CanBeNull] LocationSettingsClass.Location location)
		{
			throw null;
		}

		// Token: 0x17001507 RID: 5383
		// (get) Token: 0x06008923 RID: 35107 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008924 RID: 35108 RVA: 0x00002050 File Offset: 0x00000250
		private ISession Session
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

		// Token: 0x17001508 RID: 5384
		// (get) Token: 0x06008925 RID: 35109 RVA: 0x00002050 File Offset: 0x00000250
		public static Player MyPlayer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06008926 RID: 35110 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Init()
		{
			throw null;
		}

		// Token: 0x06008927 RID: 35111 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void vmethod_0()
		{
			throw null;
		}

		// Token: 0x06008928 RID: 35112 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetIgnoreInput(bool ignore)
		{
			throw null;
		}

		// Token: 0x06008929 RID: 35113 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetIgnoreInputInNPCDialog(bool ignore)
		{
			throw null;
		}

		// Token: 0x0600892A RID: 35114 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetIgnoreInputWithKeepResetLook(bool ignore)
		{
			throw null;
		}

		// Token: 0x0600892B RID: 35115 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void InitBattleUIScreen()
		{
			throw null;
		}

		// Token: 0x0600892C RID: 35116 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void ShowBattleUIScreen()
		{
			throw null;
		}

		// Token: 0x0600892D RID: 35117 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void CleanupOnDestroy()
		{
			throw null;
		}

		// Token: 0x0600892E RID: 35118 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal override void vmethod_1()
		{
			throw null;
		}

		// Token: 0x0600892F RID: 35119 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static IEnumerator smethod_3()
		{
			throw null;
		}

		// Token: 0x06008930 RID: 35120 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseObjectivesPanel()
		{
			throw null;
		}

		// Token: 0x06008931 RID: 35121 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowObjectivesPanel(string text, float time)
		{
			throw null;
		}

		// Token: 0x06008932 RID: 35122 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		// Token: 0x06008933 RID: 35123 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x06008934 RID: 35124 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void TranslateAxes(ref float[] axes)
		{
			throw null;
		}

		// Token: 0x06008935 RID: 35125 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_6(ECommand command)
		{
			throw null;
		}

		// Token: 0x06008936 RID: 35126 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Weapon GetCurrentWeapon()
		{
			throw null;
		}

		// Token: 0x06008937 RID: 35127 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CanSwitchMagazine()
		{
			throw null;
		}

		// Token: 0x06008938 RID: 35128 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SwitchMagazine(Weapon weapon, Item item)
		{
			throw null;
		}

		// Token: 0x06008939 RID: 35129 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CanUseMeds()
		{
			throw null;
		}

		// Token: 0x0600893A RID: 35130 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600893B RID: 35131 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual bool TranslateInventoryScreenInput(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600893C RID: 35132 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual bool TranslateExitScreenInput(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600893D RID: 35133 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowInventoryScreenLoot(LootItemClass loot, Action callback, bool isFakeContainer = false)
		{
			throw null;
		}

		// Token: 0x0600893E RID: 35134 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(GameObject model)
		{
			throw null;
		}

		// Token: 0x0600893F RID: 35135 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void ShowInventoryScreen(Action exitAction, IHealthController healthController, InventoryControllerClass controller, AbstractQuestControllerClass questController, AbstractAchievementControllerClass achievementsController, [CanBeNull] LootItemClass lootItem, InventoryScreen.EInventoryTab tab, bool showAsGridContent = false)
		{
			throw null;
		}

		// Token: 0x06008940 RID: 35136 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void InteractionsChangedHandler()
		{
			throw null;
		}

		// Token: 0x06008941 RID: 35137 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearInteractionState()
		{
			throw null;
		}

		// Token: 0x06008942 RID: 35138 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DisplayPreloaderUiNotification(string message)
		{
			throw null;
		}

		// Token: 0x06008943 RID: 35139 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SetHandsController(IFirearmHandsController controller)
		{
			throw null;
		}

		// Token: 0x06008944 RID: 35140 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SetHandsController(IHandsController grenadeController)
		{
			throw null;
		}

		// Token: 0x06008945 RID: 35141 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SetHandsController(GInterface125 controller)
		{
			throw null;
		}

		// Token: 0x06008946 RID: 35142 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void ResetHands()
		{
			throw null;
		}

		// Token: 0x06008947 RID: 35143 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x06008948 RID: 35144 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x06008949 RID: 35145 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private GClass2765 method_10(Item searchItem)
		{
			throw null;
		}

		// Token: 0x0600894A RID: 35146 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11()
		{
			throw null;
		}

		// Token: 0x04008F05 RID: 36613
		private static bool bool_0;

		// Token: 0x04008F06 RID: 36614
		[CompilerGenerated]
		private static bool bool_1;

		// Token: 0x04008F07 RID: 36615
		[CompilerGenerated]
		private static bool bool_2;

		// Token: 0x04008F08 RID: 36616
		private LocationSettingsClass.Location location_0;

		// Token: 0x04008F09 RID: 36617
		private BattleUIPanelExtraction battleUIPanelExtraction_0;

		// Token: 0x04008F0A RID: 36618
		private ExtractionTimersPanel extractionTimersPanel_0;

		// Token: 0x04008F0B RID: 36619
		private ConsoleScreen consoleScreen_0;

		// Token: 0x04008F0C RID: 36620
		private IFirearmHandsController ifirearmHandsController_0;

		// Token: 0x04008F0D RID: 36621
		private bool bool_3;

		// Token: 0x04008F0E RID: 36622
		private InsuranceCompanyClass gclass3179_0;

		// Token: 0x04008F0F RID: 36623
		private bool bool_4;

		// Token: 0x04008F10 RID: 36624
		[CompilerGenerated]
		private ISession ginterface145_0;

		// Token: 0x04008F11 RID: 36625
		protected BattleUIScreen.GClass3112 BattleUIScreenController;

		// Token: 0x04008F12 RID: 36626
		private GameDateTime gameDateTime_0;

		// Token: 0x04008F13 RID: 36627
		private static Player player_1;

		// Token: 0x04008F14 RID: 36628
		protected GClass1651 _headLightsValidator;

		// Token: 0x04008F15 RID: 36629
		public readonly BindableState<GClass3008> AvailableInteractionState;

		// Token: 0x020018E3 RID: 6371
		[CompilerGenerated]
		private sealed class Class1432<T> where T : GamePlayerOwner
		{
			// Token: 0x0600894B RID: 35147 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600894C RID: 35148 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(GEventArgs3 removeItemEventArgs)
			{
				throw null;
			}

			// Token: 0x0600894D RID: 35149 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2()
			{
				throw null;
			}

			// Token: 0x04008F16 RID: 36630
			public Player player;

			// Token: 0x04008F17 RID: 36631
			public T owner;
		}

		// Token: 0x020018E4 RID: 6372
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1433
		{
			// Token: 0x0600894E RID: 35150 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(UIInputNode child)
			{
				throw null;
			}

			// Token: 0x0600894F RID: 35151 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(GClass2765 g)
			{
				throw null;
			}

			// Token: 0x06008950 RID: 35152 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_2(GClass2765 g)
			{
				throw null;
			}

			// Token: 0x06008951 RID: 35153 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Transform method_3(TacticalComboVisualController x)
			{
				throw null;
			}

			// Token: 0x04008F18 RID: 36632
			public static readonly GamePlayerOwner.Class1433 class1433_0;

			// Token: 0x04008F19 RID: 36633
			public static Func<UIInputNode, bool> func_0;

			// Token: 0x04008F1A RID: 36634
			public static Func<GClass2765, bool> func_1;

			// Token: 0x04008F1B RID: 36635
			public static Func<GClass2765, int> func_2;

			// Token: 0x04008F1C RID: 36636
			public static Func<TacticalComboVisualController, Transform> func_3;
		}

		// Token: 0x020018E6 RID: 6374
		[CompilerGenerated]
		private sealed class Class1435
		{
			// Token: 0x06008956 RID: 35158 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal GClass2765 method_0(GClass2495 grid)
			{
				throw null;
			}

			// Token: 0x04008F1F RID: 36639
			public Item searchItem;
		}

		// Token: 0x020018E7 RID: 6375
		[CompilerGenerated]
		private sealed class Class1436
		{
			// Token: 0x06008957 RID: 35159 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04008F20 RID: 36640
			public GamePlayerOwner gamePlayerOwner_0;

			// Token: 0x04008F21 RID: 36641
			public Action callback;
		}

		// Token: 0x020018E8 RID: 6376
		[CompilerGenerated]
		private sealed class Class1437
		{
			// Token: 0x06008958 RID: 35160 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04008F22 RID: 36642
			public GamePlayerOwner gamePlayerOwner_0;

			// Token: 0x04008F23 RID: 36643
			public Action exitAction;
		}
	}
}
