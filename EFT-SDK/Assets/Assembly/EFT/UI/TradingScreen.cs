using System;
using System.Runtime.CompilerServices;
using EFT.HealthSystem;
using EFT.InputSystem;
using EFT.UI.Ragfair;
using EFT.UI.Screens;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002C09 RID: 11273
	public sealed class TradingScreen : EftScreen<TradingScreen.GClass3134, TradingScreen>
	{
		// Token: 0x0600DE39 RID: 56889 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(TradingScreen.GClass3134 controller)
		{
			throw null;
		}

		// Token: 0x0600DE3A RID: 56890 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600DE3B RID: 56891 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600DE3C RID: 56892 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600DE3D RID: 56893 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(ISession session, IHealthController healthController, InventoryControllerClass inventoryController, AbstractQuestControllerClass questController, Profile profile, GClass3195 ragfairSearch, TradingScreen.ETradingScreenTab tab)
		{
			throw null;
		}

		// Token: 0x0600DE3E RID: 56894 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600DE3F RID: 56895 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal TraderPanel method_6(string traderId)
		{
			throw null;
		}

		// Token: 0x0600DE40 RID: 56896 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(GClass3192 filter)
		{
			throw null;
		}

		// Token: 0x0600DE41 RID: 56897 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8(GClass3192 filter)
		{
			throw null;
		}

		// Token: 0x0600DE42 RID: 56898 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private GClass3073 method_9(TradingScreen.ETradingScreenTab tabType)
		{
			throw null;
		}

		// Token: 0x0600DE43 RID: 56899 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10(TradingScreen.ETradingScreenTab tabType)
		{
			throw null;
		}

		// Token: 0x0600DE44 RID: 56900 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600DE45 RID: 56901 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void TranslateAxes(ref float[] axes)
		{
			throw null;
		}

		// Token: 0x0600DE46 RID: 56902 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override ECursorResult ShouldLockCursor()
		{
			throw null;
		}

		// Token: 0x0600DE47 RID: 56903 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600DE48 RID: 56904 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11()
		{
			throw null;
		}

		// Token: 0x0600DE49 RID: 56905 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12(bool arg)
		{
			throw null;
		}

		// Token: 0x0600DE4A RID: 56906 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13(bool arg)
		{
			throw null;
		}

		// Token: 0x0600DE4B RID: 56907 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_14(RagFairClass.ERagFairStatus status)
		{
			throw null;
		}

		// Token: 0x0400E309 RID: 58121
		[SerializeField]
		private DefaultUIButton _exitButton;

		// Token: 0x0400E30A RID: 58122
		[SerializeField]
		private UIAnimatedToggleSpawner _merchantsToggle;

		// Token: 0x0400E30B RID: 58123
		[SerializeField]
		private UIAnimatedToggleSpawner _ragfairToggle;

		// Token: 0x0400E30C RID: 58124
		[SerializeField]
		private GameObject _ragfairLockIcon;

		// Token: 0x0400E30D RID: 58125
		[SerializeField]
		private MerchantsList _merchantsList;

		// Token: 0x0400E30E RID: 58126
		[SerializeField]
		private RagfairScreen _ragfairScreen;

		// Token: 0x0400E30F RID: 58127
		[SerializeField]
		private HoverTooltipArea _tooltipArea;

		// Token: 0x0400E310 RID: 58128
		[SerializeField]
		private GameObject _loader;

		// Token: 0x0400E311 RID: 58129
		[SerializeField]
		public TraderScreensGroup TraderScreensGroup;

		// Token: 0x0400E312 RID: 58130
		private ISession ginterface145_0;

		// Token: 0x0400E313 RID: 58131
		private IHealthController ihealthController_0;

		// Token: 0x0400E314 RID: 58132
		private InventoryControllerClass gclass2757_0;

		// Token: 0x0400E315 RID: 58133
		private AbstractQuestControllerClass gclass3203_0;

		// Token: 0x0400E316 RID: 58134
		private Profile profile_0;

		// Token: 0x0400E317 RID: 58135
		private RagFairClass gclass3190_0;

		// Token: 0x0400E318 RID: 58136
		private GClass3195 gclass3195_0;

		// Token: 0x0400E319 RID: 58137
		private GClass3073 gclass3073_0;

		// Token: 0x0400E31A RID: 58138
		private GClass3073 gclass3073_1;

		// Token: 0x0400E31B RID: 58139
		private DateTime dateTime_0;

		// Token: 0x02002C0A RID: 11274
		public enum ETradingScreenTab
		{
			// Token: 0x0400E31D RID: 58141
			Merchants = 1,
			// Token: 0x0400E31E RID: 58142
			FleaMarket
		}

		// Token: 0x02002C0B RID: 11275
		public abstract class GClass3134 : GClass3107.GClass3109<TradingScreen.GClass3134, TradingScreen>
		{
			// Token: 0x170026CE RID: 9934
			// (get) Token: 0x0600DE4C RID: 56908
			public abstract TradingScreen.ETradingScreenTab Tab { get; }

			// Token: 0x170026CF RID: 9935
			// (get) Token: 0x0600DE4D RID: 56909 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher MenuChatBarVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170026D0 RID: 9936
			// (get) Token: 0x0600DE4E RID: 56910 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher TaskBarButtonsVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0400E31F RID: 58143
			public readonly ISession Session;

			// Token: 0x0400E320 RID: 58144
			public readonly IHealthController HealthController;

			// Token: 0x0400E321 RID: 58145
			public readonly InventoryControllerClass InventoryController;

			// Token: 0x0400E322 RID: 58146
			public readonly AbstractQuestControllerClass QuestController;

			// Token: 0x0400E323 RID: 58147
			public readonly GClass3195 RagfairSearch;
		}

		// Token: 0x02002C0C RID: 11276
		public sealed class GClass3135 : TradingScreen.GClass3134
		{
			// Token: 0x170026D1 RID: 9937
			// (get) Token: 0x0600DE4F RID: 56911 RVA: 0x00002050 File Offset: 0x00000250
			public override EEftScreenType ScreenType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170026D2 RID: 9938
			// (get) Token: 0x0600DE50 RID: 56912 RVA: 0x00002050 File Offset: 0x00000250
			public override TradingScreen.ETradingScreenTab Tab
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}
		}

		// Token: 0x02002C0D RID: 11277
		public sealed class GClass3136 : TradingScreen.GClass3134
		{
			// Token: 0x170026D3 RID: 9939
			// (get) Token: 0x0600DE51 RID: 56913 RVA: 0x00002050 File Offset: 0x00000250
			public override EEftScreenType ScreenType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170026D4 RID: 9940
			// (get) Token: 0x0600DE52 RID: 56914 RVA: 0x00002050 File Offset: 0x00000250
			public override TradingScreen.ETradingScreenTab Tab
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}
		}

		// Token: 0x02002C0E RID: 11278
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2683
		{
			// Token: 0x0600DE53 RID: 56915 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(TraderClass trader)
			{
				throw null;
			}

			// Token: 0x0400E324 RID: 58148
			public static readonly TradingScreen.Class2683 class2683_0;

			// Token: 0x0400E325 RID: 58149
			public static Func<TraderClass, bool> func_0;
		}

		// Token: 0x02002C0F RID: 11279
		[CompilerGenerated]
		private sealed class Class2684
		{
			// Token: 0x0600DE54 RID: 56916 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(TraderPanel e)
			{
				throw null;
			}

			// Token: 0x0400E326 RID: 58150
			public string traderId;
		}
	}
}
