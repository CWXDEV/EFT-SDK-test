using System;
using System.Runtime.CompilerServices;
using EFT.InputSystem;
using EFT.UI.Screens;
using UnityEngine;

namespace EFT.UI.Matchmaker
{
	// Token: 0x02002DEB RID: 11755
	public sealed class MatchmakerOfflineRaidScreen : MatchmakerEftScreen<MatchmakerOfflineRaidScreen.GClass3155, MatchmakerOfflineRaidScreen>
	{
		// Token: 0x0600E71F RID: 59167 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600E720 RID: 59168 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(MatchmakerOfflineRaidScreen.GClass3155 controller)
		{
			throw null;
		}

		// Token: 0x0600E721 RID: 59169 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(InfoClass profileInfo, RaidSettings raidSettings)
		{
			throw null;
		}

		// Token: 0x0600E722 RID: 59170 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600E723 RID: 59171 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(bool isToggleOn)
		{
			throw null;
		}

		// Token: 0x0600E724 RID: 59172 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600E725 RID: 59173 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x0600E726 RID: 59174 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8(bool value)
		{
			throw null;
		}

		// Token: 0x0600E727 RID: 59175 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(EBanType banType = EBanType.Online)
		{
			throw null;
		}

		// Token: 0x0600E728 RID: 59176 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600E729 RID: 59177 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10()
		{
			throw null;
		}

		// Token: 0x0600E72A RID: 59178 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11()
		{
			throw null;
		}

		// Token: 0x0600E72B RID: 59179 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12()
		{
			throw null;
		}

		// Token: 0x0600E72C RID: 59180 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13()
		{
			throw null;
		}

		// Token: 0x0400EC51 RID: 60497
		[SerializeField]
		private UpdatableToggle _offlineModeToggle;

		// Token: 0x0400EC52 RID: 60498
		[SerializeField]
		private UiElementBlocker _onlineBlocker;

		// Token: 0x0400EC53 RID: 60499
		[SerializeField]
		private RaidSettingsWindow _raidSettingsWindow;

		// Token: 0x0400EC54 RID: 60500
		[SerializeField]
		private MatchmakerRaidSettingsSummaryView _raidSettingsSummaryView;

		// Token: 0x0400EC55 RID: 60501
		[SerializeField]
		private DefaultUIButton _changeSettingsButton;

		// Token: 0x0400EC56 RID: 60502
		[SerializeField]
		private DefaultUIButton _nextButtonSpawner;

		// Token: 0x0400EC57 RID: 60503
		[SerializeField]
		private DefaultUIButton _backButtonSpawner;

		// Token: 0x0400EC58 RID: 60504
		[SerializeField]
		private DefaultUIButton _readyButton;

		// Token: 0x0400EC59 RID: 60505
		private InfoClass gclass1757_0;

		// Token: 0x0400EC5A RID: 60506
		private RaidSettings raidSettings_0;

		// Token: 0x0400EC5B RID: 60507
		private GClass1756 gclass1756_0;

		// Token: 0x02002DEC RID: 11756
		public sealed class GClass3155 : GClass3148<MatchmakerOfflineRaidScreen.GClass3155, MatchmakerOfflineRaidScreen>
		{
			// Token: 0x17002826 RID: 10278
			// (get) Token: 0x0600E72D RID: 59181 RVA: 0x00002050 File Offset: 0x00000250
			public override EEftScreenType ScreenType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002827 RID: 10279
			// (get) Token: 0x0600E72E RID: 59182 RVA: 0x00002050 File Offset: 0x00000250
			public override bool KeyScreen
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0400EC5C RID: 60508
			public readonly InfoClass ProfileInfo;

			// Token: 0x0400EC5D RID: 60509
			public readonly RaidSettings RaidSettings;
		}
	}
}
