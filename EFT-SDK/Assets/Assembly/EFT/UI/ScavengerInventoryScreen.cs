using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.HealthSystem;
using EFT.InputSystem;
using EFT.InventoryLogic;
using EFT.UI.Screens;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002AC8 RID: 10952
	public sealed class ScavengerInventoryScreen : EftScreen<ScavengerInventoryScreen.GClass3131, ScavengerInventoryScreen>
	{
		// Token: 0x17002676 RID: 9846
		// (get) Token: 0x0600D9BA RID: 55738 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600D9BB RID: 55739 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600D9BC RID: 55740 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(ScavengerInventoryScreen.GClass3131 controller)
		{
			throw null;
		}

		// Token: 0x0600D9BD RID: 55741 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(GClass2760 mainController, GClass2760 scavController, IHealthController healthController, StashClass playerStash, ISession session, ItemUiContext uiContext)
		{
			throw null;
		}

		// Token: 0x0600D9BE RID: 55742 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_3(out IEnumerable<Item> items)
		{
			throw null;
		}

		// Token: 0x0600D9BF RID: 55743 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_4()
		{
			throw null;
		}

		// Token: 0x0600D9C0 RID: 55744 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(GEventArgs3 args)
		{
			throw null;
		}

		// Token: 0x0600D9C1 RID: 55745 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600D9C2 RID: 55746 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x0600D9C3 RID: 55747 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600D9C4 RID: 55748 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600D9C5 RID: 55749 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x0600D9C6 RID: 55750 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x0600D9C7 RID: 55751 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10()
		{
			throw null;
		}

		// Token: 0x0600D9C8 RID: 55752 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11()
		{
			throw null;
		}

		// Token: 0x0600D9C9 RID: 55753 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12()
		{
			throw null;
		}

		// Token: 0x0400DC96 RID: 56470
		[SerializeField]
		private ItemsPanel _itemsPanel;

		// Token: 0x0400DC97 RID: 56471
		[SerializeField]
		private SimpleStashPanel _simpleStashPanel;

		// Token: 0x0400DC98 RID: 56472
		[SerializeField]
		private DefaultUIButton _backButton;

		// Token: 0x0400DC99 RID: 56473
		[SerializeField]
		private DefaultUIButton _nextButton;

		// Token: 0x0400DC9A RID: 56474
		[SerializeField]
		private DefaultUIButton _sellAllButton;

		// Token: 0x0400DC9B RID: 56475
		[SerializeField]
		private CustomTextMeshProUGUI _scavCaption;

		// Token: 0x0400DC9C RID: 56476
		[SerializeField]
		private SortingTableWindow _sortingTable;

		// Token: 0x0400DC9D RID: 56477
		[SerializeField]
		private TagBank _scavPhrases;

		// Token: 0x0400DC9E RID: 56478
		[SerializeField]
		private GameObject _loadingPanel;

		// Token: 0x0400DC9F RID: 56479
		[SerializeField]
		private GameObject _loadingSpinner;

		// Token: 0x0400DCA0 RID: 56480
		private ItemUiContext itemUiContext_0;

		// Token: 0x0400DCA1 RID: 56481
		private GClass2759 gclass2759_0;

		// Token: 0x0400DCA2 RID: 56482
		private GClass2759 gclass2759_1;

		// Token: 0x0400DCA3 RID: 56483
		private ISession ginterface145_0;

		// Token: 0x0400DCA4 RID: 56484
		private bool bool_1;

		// Token: 0x02002AC9 RID: 10953
		public sealed class GClass3131 : GClass3107.GClass3109<ScavengerInventoryScreen.GClass3131, ScavengerInventoryScreen>
		{
			// Token: 0x17002677 RID: 9847
			// (get) Token: 0x0600D9CA RID: 55754 RVA: 0x00002050 File Offset: 0x00000250
			public override EEftScreenType ScreenType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x140002FC RID: 764
			// (add) Token: 0x0600D9CB RID: 55755 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x0600D9CC RID: 55756 RVA: 0x00002050 File Offset: 0x00000250
			public event Action OnShowNextScreen
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

			// Token: 0x17002678 RID: 9848
			// (get) Token: 0x0600D9CD RID: 55757 RVA: 0x00002050 File Offset: 0x00000250
			protected override bool MainEnvironment
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002679 RID: 9849
			// (get) Token: 0x0600D9CE RID: 55758 RVA: 0x00002050 File Offset: 0x00000250
			public override bool KeyScreen
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700267A RID: 9850
			// (get) Token: 0x0600D9CF RID: 55759 RVA: 0x00002050 File Offset: 0x00000250
			public bool HasItems
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700267B RID: 9851
			// (get) Token: 0x0600D9D0 RID: 55760 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher TaskBarButtonsVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600D9D1 RID: 55761 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void ShowNextScreen()
			{
				throw null;
			}

			// Token: 0x0600D9D2 RID: 55762 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override Task<bool> CloseScreenInterruption(bool moveForward)
			{
				throw null;
			}

			// Token: 0x0600D9D3 RID: 55763 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[DebuggerHidden]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Task<bool> method_9(bool moveForward)
			{
				throw null;
			}

			// Token: 0x0400DCA5 RID: 56485
			[CompilerGenerated]
			private Action action_2;

			// Token: 0x0400DCA6 RID: 56486
			public readonly GClass2760 MainController;

			// Token: 0x0400DCA7 RID: 56487
			public readonly GClass2760 ScavController;

			// Token: 0x0400DCA8 RID: 56488
			public readonly IHealthController HealthController;

			// Token: 0x0400DCA9 RID: 56489
			public readonly StashClass PlayerStash;

			// Token: 0x0400DCAA RID: 56490
			public readonly ISession Session;

			// Token: 0x0400DCAB RID: 56491
			public readonly ItemUiContext UiContext;

			// Token: 0x02002ACA RID: 10954
			[CompilerGenerated]
			private sealed class Class2565
			{
				// Token: 0x0600D9D4 RID: 55764 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0()
				{
					throw null;
				}

				// Token: 0x0600D9D5 RID: 55765 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_1()
				{
					throw null;
				}

				// Token: 0x0400DCAC RID: 56492
				public TaskCompletionSource<bool> taskSource;
			}
		}

		// Token: 0x02002ACC RID: 10956
		[CompilerGenerated]
		private sealed class Class2566
		{
			// Token: 0x0600D9D8 RID: 55768 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Item item)
			{
				throw null;
			}

			// Token: 0x0400DCB3 RID: 56499
			public EquipmentClass equipment;
		}

		// Token: 0x02002ACD RID: 10957
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2567
		{
			// Token: 0x0600D9D9 RID: 55769 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(TraderClass x)
			{
				throw null;
			}

			// Token: 0x0600D9DA RID: 55770 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x0600D9DB RID: 55771 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2()
			{
				throw null;
			}

			// Token: 0x0400DCB4 RID: 56500
			public static readonly ScavengerInventoryScreen.Class2567 class2567_0;

			// Token: 0x0400DCB5 RID: 56501
			public static Func<TraderClass, bool> func_0;

			// Token: 0x0400DCB6 RID: 56502
			public static Action action_0;

			// Token: 0x0400DCB7 RID: 56503
			public static Action action_1;
		}
	}
}
