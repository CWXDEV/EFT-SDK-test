using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.InputSystem;
using EFT.UI.Screens;
using UnityEngine;

namespace EFT.UI.SessionEnd
{
	// Token: 0x02002CE0 RID: 11488
	public sealed class HealthTreatmentScreen : EftScreen<HealthTreatmentScreen.GClass3140, HealthTreatmentScreen>
	{
		// Token: 0x0600E204 RID: 57860 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600E205 RID: 57861 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsAvailable(Profile profile, HealthControllerClass healthController, Profile.TraderInfo trader)
		{
			throw null;
		}

		// Token: 0x0600E206 RID: 57862 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(HealthTreatmentScreen.GClass3140 controller)
		{
			throw null;
		}

		// Token: 0x0600E207 RID: 57863 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600E208 RID: 57864 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(Profile profile, InventoryControllerClass inventoryController, HealthControllerClass healthController, ItemUiContext uiContext, ISession session)
		{
			throw null;
		}

		// Token: 0x0600E209 RID: 57865 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(bool blocked)
		{
			throw null;
		}

		// Token: 0x0600E20A RID: 57866 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600E20B RID: 57867 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600E20C RID: 57868 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0400E6BA RID: 59066
		[SerializeField]
		private HealthTreatmentServiceView _healthTreatmentView;

		// Token: 0x0400E6BB RID: 59067
		[SerializeField]
		private DefaultUIButton _nextButton;

		// Token: 0x0400E6BC RID: 59068
		[SerializeField]
		private DefaultUIButton _backButton;

		// Token: 0x02002CE1 RID: 11489
		public sealed class GClass3140 : GClass3107.GClass3109<HealthTreatmentScreen.GClass3140, HealthTreatmentScreen>
		{
			// Token: 0x14000320 RID: 800
			// (add) Token: 0x0600E20D RID: 57869 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x0600E20E RID: 57870 RVA: 0x00002050 File Offset: 0x00000250
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

			// Token: 0x14000321 RID: 801
			// (add) Token: 0x0600E20F RID: 57871 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x0600E210 RID: 57872 RVA: 0x00002050 File Offset: 0x00000250
			public event Action<bool> OnCloseInProgress
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

			// Token: 0x1700276B RID: 10091
			// (get) Token: 0x0600E211 RID: 57873 RVA: 0x00002050 File Offset: 0x00000250
			public override EEftScreenType ScreenType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700276C RID: 10092
			// (get) Token: 0x0600E212 RID: 57874 RVA: 0x00002050 File Offset: 0x00000250
			protected override bool MainEnvironment
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700276D RID: 10093
			// (get) Token: 0x0600E213 RID: 57875 RVA: 0x00002050 File Offset: 0x00000250
			public override bool KeyScreen
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700276E RID: 10094
			// (get) Token: 0x0600E214 RID: 57876 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher TaskBarButtonsVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700276F RID: 10095
			// (get) Token: 0x0600E215 RID: 57877 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher MenuChatBarVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600E216 RID: 57878 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void ShowNextScreen()
			{
				throw null;
			}

			// Token: 0x0600E217 RID: 57879 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override Task<bool> CloseScreenInterruption(bool moveForward)
			{
				throw null;
			}

			// Token: 0x0600E218 RID: 57880 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[DebuggerHidden]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Task<bool> method_9(bool moveForward)
			{
				throw null;
			}

			// Token: 0x0400E6BD RID: 59069
			[CompilerGenerated]
			private Action action_2;

			// Token: 0x0400E6BE RID: 59070
			[CompilerGenerated]
			private Action<bool> action_3;

			// Token: 0x0400E6BF RID: 59071
			public readonly Profile Profile;

			// Token: 0x0400E6C0 RID: 59072
			public readonly InventoryControllerClass InventoryController;

			// Token: 0x0400E6C1 RID: 59073
			public readonly HealthControllerClass HealthController;

			// Token: 0x0400E6C2 RID: 59074
			public readonly ItemUiContext Context;

			// Token: 0x0400E6C3 RID: 59075
			public readonly ISession Session;

			// Token: 0x0400E6C4 RID: 59076
			public readonly TraderClass Trader;
		}

		// Token: 0x02002CE3 RID: 11491
		[CompilerGenerated]
		private sealed class Class2750
		{
			// Token: 0x0600E21B RID: 57883 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400E6CB RID: 59083
			public HealthTreatmentScreen.GClass3140 controller;

			// Token: 0x0400E6CC RID: 59084
			public HealthTreatmentScreen healthTreatmentScreen_0;
		}
	}
}
