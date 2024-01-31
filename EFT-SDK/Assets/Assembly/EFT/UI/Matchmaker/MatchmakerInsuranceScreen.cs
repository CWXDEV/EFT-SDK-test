using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;
using EFT.HealthSystem;
using EFT.InputSystem;
using EFT.UI.Insurance;
using EFT.UI.Screens;
using UnityEngine;

namespace EFT.UI.Matchmaker
{
	// Token: 0x02002DC1 RID: 11713
	public sealed class MatchmakerInsuranceScreen : MatchmakerEftScreen<MatchmakerInsuranceScreen.GClass3149, MatchmakerInsuranceScreen>
	{
		// Token: 0x0600E640 RID: 58944 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600E641 RID: 58945 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(MatchmakerInsuranceScreen.GClass3149 controller)
		{
			throw null;
		}

		// Token: 0x0600E642 RID: 58946 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(IHealthController healthController, InventoryControllerClass controller, ISession session)
		{
			throw null;
		}

		// Token: 0x0600E643 RID: 58947 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(GClass1207 player, bool _)
		{
			throw null;
		}

		// Token: 0x0600E644 RID: 58948 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(bool available)
		{
			throw null;
		}

		// Token: 0x0600E645 RID: 58949 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600E646 RID: 58950 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(Action acceptAction, int itemsToInsureCount)
		{
			throw null;
		}

		// Token: 0x0600E647 RID: 58951 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600E648 RID: 58952 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600E649 RID: 58953 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x0600E64A RID: 58954 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x0600E64B RID: 58955 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10()
		{
			throw null;
		}

		// Token: 0x0600E64C RID: 58956 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11()
		{
			throw null;
		}

		// Token: 0x0400EB4D RID: 60237
		[SerializeField]
		private Tab _insuredTab;

		// Token: 0x0400EB4E RID: 60238
		[SerializeField]
		private Tab _toInsureTab;

		// Token: 0x0400EB4F RID: 60239
		[SerializeField]
		private ItemsToInsureScreen _itemsToInsureScreen;

		// Token: 0x0400EB50 RID: 60240
		[SerializeField]
		private InsuredItemsScreen _insuredItemsScreen;

		// Token: 0x0400EB51 RID: 60241
		[SerializeField]
		private DefaultUIButton _readyButton;

		// Token: 0x0400EB52 RID: 60242
		[SerializeField]
		private DefaultUIButton _nextButton;

		// Token: 0x0400EB53 RID: 60243
		[SerializeField]
		private DefaultUIButton _insureButton;

		// Token: 0x0400EB54 RID: 60244
		[SerializeField]
		private DefaultUIButton _backButton;

		// Token: 0x0400EB55 RID: 60245
		private ItemUiContext itemUiContext_0;

		// Token: 0x0400EB56 RID: 60246
		private Dictionary<MatchmakerInsuranceScreen.EInsuranceTab, Tab> dictionary_0;

		// Token: 0x0400EB57 RID: 60247
		private GClass3065 gclass3065_0;

		// Token: 0x0400EB58 RID: 60248
		private ISession ginterface145_0;

		// Token: 0x0400EB59 RID: 60249
		private InsuranceCompanyClass gclass3179_0;

		// Token: 0x02002DC2 RID: 11714
		private enum EInsuranceTab
		{
			// Token: 0x0400EB5B RID: 60251
			Insured,
			// Token: 0x0400EB5C RID: 60252
			ToInsure
		}

		// Token: 0x02002DC3 RID: 11715
		public sealed class GClass3149 : GClass3148<MatchmakerInsuranceScreen.GClass3149, MatchmakerInsuranceScreen>
		{
			// Token: 0x17002802 RID: 10242
			// (get) Token: 0x0600E64D RID: 58957 RVA: 0x00002050 File Offset: 0x00000250
			public override EEftScreenType ScreenType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002803 RID: 10243
			// (get) Token: 0x0600E64E RID: 58958 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher ShowEnvironment
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002804 RID: 10244
			// (get) Token: 0x0600E64F RID: 58959 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher ShowEnvironmentCamera
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002805 RID: 10245
			// (get) Token: 0x0600E650 RID: 58960 RVA: 0x00002050 File Offset: 0x00000250
			public override bool KeyScreen
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600E651 RID: 58961 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void CloseAction(bool moveForward)
			{
				throw null;
			}

			// Token: 0x0600E652 RID: 58962 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override Task<bool> CloseScreenInterruption(bool moveForward)
			{
				throw null;
			}

			// Token: 0x0600E653 RID: 58963 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[DebuggerHidden]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Task<bool> method_12(bool moveForward)
			{
				throw null;
			}

			// Token: 0x0400EB5D RID: 60253
			public readonly IHealthController HealthController;

			// Token: 0x0400EB5E RID: 60254
			public readonly InventoryControllerClass InventoryController;

			// Token: 0x0400EB5F RID: 60255
			public readonly ISession Session;
		}

		// Token: 0x02002DC5 RID: 11717
		[CompilerGenerated]
		private sealed class Class2853
		{
			// Token: 0x0600E656 RID: 58966 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600E657 RID: 58967 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(IResult result)
			{
				throw null;
			}

			// Token: 0x0400EB66 RID: 60262
			public MatchmakerInsuranceScreen matchmakerInsuranceScreen_0;

			// Token: 0x0400EB67 RID: 60263
			public List<ItemClass> allItemsToInsure;

			// Token: 0x0400EB68 RID: 60264
			public Callback callback_0;
		}

		// Token: 0x02002DC6 RID: 11718
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2854
		{
			// Token: 0x0600E658 RID: 58968 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400EB69 RID: 60265
			public static readonly MatchmakerInsuranceScreen.Class2854 class2854_0;

			// Token: 0x0400EB6A RID: 60266
			public static Action action_0;
		}
	}
}
