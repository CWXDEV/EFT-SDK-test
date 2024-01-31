using System;
using System.Runtime.CompilerServices;
using Comfort.Common;
using EFT.InputSystem;
using EFT.UI.Screens;
using UnityEngine;

namespace EFT.UI.SessionEnd
{
	// Token: 0x02002CE6 RID: 11494
	public sealed class SessionResultExitStatus : EftScreen<SessionResultExitStatus.GClass3141, SessionResultExitStatus>
	{
		// Token: 0x0600E21F RID: 57887 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600E220 RID: 57888 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(SessionResultExitStatus.GClass3141 controller)
		{
			throw null;
		}

		// Token: 0x0600E221 RID: 57889 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(Profile activeProfile, PlayerVisualRepresentation lastPlayerState, ESideType side, ExitStatus exitStatus, TimeSpan raidTime, ISession session, bool isOnline)
		{
			throw null;
		}

		// Token: 0x0600E222 RID: 57890 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600E223 RID: 57891 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600E224 RID: 57892 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600E225 RID: 57893 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(Result<GClass1208> result)
		{
			throw null;
		}

		// Token: 0x0400E6DF RID: 59103
		[SerializeField]
		private DefaultUIButton _nextButton;

		// Token: 0x0400E6E0 RID: 59104
		[SerializeField]
		private DefaultUIButton _mainMenuButton;

		// Token: 0x0400E6E1 RID: 59105
		[SerializeField]
		private PlayerLevelPanel _levelPanel;

		// Token: 0x0400E6E2 RID: 59106
		[SerializeField]
		private PlayerNamePanel _namePanel;

		// Token: 0x0400E6E3 RID: 59107
		[SerializeField]
		private PlayerNamePanel _killerNamePanel;

		// Token: 0x0400E6E4 RID: 59108
		[SerializeField]
		private CustomTextMeshProUGUI _bodyPartLabel;

		// Token: 0x0400E6E5 RID: 59109
		[SerializeField]
		private PlayerModelView _playerModelView;

		// Token: 0x0400E6E6 RID: 59110
		[SerializeField]
		private GameObject _survivedPanel;

		// Token: 0x0400E6E7 RID: 59111
		[SerializeField]
		private GameObject _leftPanel;

		// Token: 0x0400E6E8 RID: 59112
		[SerializeField]
		private GameObject _missingPanel;

		// Token: 0x0400E6E9 RID: 59113
		[SerializeField]
		private GameObject _killedPanel;

		// Token: 0x0400E6EA RID: 59114
		[SerializeField]
		private GameObject _runnerPanel;

		// Token: 0x0400E6EB RID: 59115
		[SerializeField]
		private GameObject _warningPanel;

		// Token: 0x0400E6EC RID: 59116
		[SerializeField]
		private CustomTextMeshProUGUI _warningCaption;

		// Token: 0x0400E6ED RID: 59117
		[SerializeField]
		private CustomTextMeshProUGUI _warningDescription;

		// Token: 0x0400E6EE RID: 59118
		[SerializeField]
		private CustomTextMeshProUGUI _raidTime;

		// Token: 0x0400E6EF RID: 59119
		[SerializeField]
		private CustomTextMeshProUGUI _experience;

		// Token: 0x0400E6F0 RID: 59120
		[SerializeField]
		private ReportPanel _reportPanel;

		// Token: 0x0400E6F1 RID: 59121
		private ISession ginterface145_0;

		// Token: 0x0400E6F2 RID: 59122
		private Profile profile_0;

		// Token: 0x02002CE7 RID: 11495
		public sealed class GClass3141 : GClass3107.GClass3109<SessionResultExitStatus.GClass3141, SessionResultExitStatus>
		{
			// Token: 0x17002770 RID: 10096
			// (get) Token: 0x0600E226 RID: 57894 RVA: 0x00002050 File Offset: 0x00000250
			public override EEftScreenType ScreenType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x14000322 RID: 802
			// (add) Token: 0x0600E227 RID: 57895 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x0600E228 RID: 57896 RVA: 0x00002050 File Offset: 0x00000250
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

			// Token: 0x14000323 RID: 803
			// (add) Token: 0x0600E229 RID: 57897 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x0600E22A RID: 57898 RVA: 0x00002050 File Offset: 0x00000250
			public event Action OnGoToMainMenu
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

			// Token: 0x17002771 RID: 10097
			// (get) Token: 0x0600E22B RID: 57899 RVA: 0x00002050 File Offset: 0x00000250
			protected override bool MainEnvironment
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002772 RID: 10098
			// (get) Token: 0x0600E22C RID: 57900 RVA: 0x00002050 File Offset: 0x00000250
			public override bool KeyScreen
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002773 RID: 10099
			// (get) Token: 0x0600E22D RID: 57901 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher TaskBarButtonsVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002774 RID: 10100
			// (get) Token: 0x0600E22E RID: 57902 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher MenuChatBarVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600E22F RID: 57903 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void ShowNextScreen()
			{
				throw null;
			}

			// Token: 0x0600E230 RID: 57904 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void GoToMainMenu()
			{
				throw null;
			}

			// Token: 0x0400E6F3 RID: 59123
			[CompilerGenerated]
			private Action action_2;

			// Token: 0x0400E6F4 RID: 59124
			[CompilerGenerated]
			private Action action_3;

			// Token: 0x0400E6F5 RID: 59125
			public readonly Profile ActiveProfile;

			// Token: 0x0400E6F6 RID: 59126
			public readonly ESideType PlayerSide;

			// Token: 0x0400E6F7 RID: 59127
			public readonly ExitStatus ExitStatus;

			// Token: 0x0400E6F8 RID: 59128
			public readonly TimeSpan RaidTime;

			// Token: 0x0400E6F9 RID: 59129
			public readonly bool IsOnline;

			// Token: 0x0400E6FA RID: 59130
			public readonly ISession Session;

			// Token: 0x0400E6FB RID: 59131
			public readonly PlayerVisualRepresentation LastPlayerState;
		}
	}
}
