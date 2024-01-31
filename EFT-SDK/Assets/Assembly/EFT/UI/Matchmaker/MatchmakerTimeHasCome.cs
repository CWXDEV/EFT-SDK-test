using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.InputSystem;
using EFT.UI.Screens;
using TMPro;
using UnityEngine;

namespace EFT.UI.Matchmaker
{
	// Token: 0x02002DEE RID: 11758
	public sealed class MatchmakerTimeHasCome : EftScreen<MatchmakerTimeHasCome.GClass3163, MatchmakerTimeHasCome>
	{
		// Token: 0x0600E731 RID: 59185 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600E732 RID: 59186 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(MatchmakerTimeHasCome.GClass3163 controller)
		{
			throw null;
		}

		// Token: 0x0600E733 RID: 59187 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(ISession session, RaidSettings raidSettings)
		{
			throw null;
		}

		// Token: 0x0600E734 RID: 59188 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(NotificationClass notification)
		{
			throw null;
		}

		// Token: 0x0600E735 RID: 59189 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_4()
		{
			throw null;
		}

		// Token: 0x0600E736 RID: 59190 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(bool value)
		{
			throw null;
		}

		// Token: 0x0600E737 RID: 59191 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(string status, float? progress = null)
		{
			throw null;
		}

		// Token: 0x0600E738 RID: 59192 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600E739 RID: 59193 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x0600E73A RID: 59194 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600E73B RID: 59195 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600E73C RID: 59196 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_8()
		{
			throw null;
		}

		// Token: 0x0400EC60 RID: 60512
		private const int int_0 = 5;

		// Token: 0x0400EC61 RID: 60513
		[SerializeField]
		private PlayerModelView _playerModelView;

		// Token: 0x0400EC62 RID: 60514
		[SerializeField]
		private TextMeshProUGUI _locationName;

		// Token: 0x0400EC63 RID: 60515
		[SerializeField]
		private PlayerLevelPanel _levelPanel;

		// Token: 0x0400EC64 RID: 60516
		[SerializeField]
		private MatchmakerBannersPanel _bannersPanel;

		// Token: 0x0400EC65 RID: 60517
		[SerializeField]
		private TextMeshProUGUI _deployingText;

		// Token: 0x0400EC66 RID: 60518
		[SerializeField]
		private DefaultUIButton _cancelButton;

		// Token: 0x0400EC67 RID: 60519
		private DateTime dateTime_0;

		// Token: 0x0400EC68 RID: 60520
		private string string_0;

		// Token: 0x0400EC69 RID: 60521
		private bool bool_1;

		// Token: 0x0400EC6A RID: 60522
		private readonly GClass764 gclass764_0;

		// Token: 0x0400EC6B RID: 60523
		private TimeSpan timeSpan_0;

		// Token: 0x0400EC6C RID: 60524
		private ERaidMode eraidMode_0;

		// Token: 0x0400EC6D RID: 60525
		private RaidSettings raidSettings_0;

		// Token: 0x02002DEF RID: 11759
		public sealed class GClass3163 : GClass3107.GClass3109<MatchmakerTimeHasCome.GClass3163, MatchmakerTimeHasCome>
		{
			// Token: 0x17002828 RID: 10280
			// (get) Token: 0x0600E73D RID: 59197 RVA: 0x00002050 File Offset: 0x00000250
			public override EEftScreenType ScreenType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x14000345 RID: 837
			// (add) Token: 0x0600E73E RID: 59198 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x0600E73F RID: 59199 RVA: 0x00002050 File Offset: 0x00000250
			public event Action OnAbortMatching
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

			// Token: 0x17002829 RID: 10281
			// (get) Token: 0x0600E740 RID: 59200 RVA: 0x00002050 File Offset: 0x00000250
			public override bool KeyScreen
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700282A RID: 10282
			// (get) Token: 0x0600E741 RID: 59201 RVA: 0x00002050 File Offset: 0x00000250
			public bool LimitedServersAvailability
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700282B RID: 10283
			// (get) Token: 0x0600E742 RID: 59202 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher MenuChatBarVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600E743 RID: 59203 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void AbortMatching()
			{
				throw null;
			}

			// Token: 0x0600E744 RID: 59204 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void ChangeCancelButtonVisibility(bool value)
			{
				throw null;
			}

			// Token: 0x0600E745 RID: 59205 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void ChangeStatus(string text, float? progress = null)
			{
				throw null;
			}

			// Token: 0x0600E746 RID: 59206 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void ShowPlayerModel()
			{
				throw null;
			}

			// Token: 0x0400EC6E RID: 60526
			public readonly ISession Session;

			// Token: 0x0400EC6F RID: 60527
			public readonly RaidSettings RaidSettings;

			// Token: 0x0400EC70 RID: 60528
			public bool SearchingForServer;

			// Token: 0x0400EC71 RID: 60529
			[CompilerGenerated]
			private Action action_2;
		}

		// Token: 0x02002DF0 RID: 11760
		[CompilerGenerated]
		private sealed class Class2866
		{
			// Token: 0x0600E747 RID: 59207 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400EC72 RID: 60530
			public NotificationManagerClass notificationManager;

			// Token: 0x0400EC73 RID: 60531
			public MatchmakerTimeHasCome matchmakerTimeHasCome_0;
		}
	}
}
