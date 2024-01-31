using System;
using System.Runtime.CompilerServices;
using EFT.InputSystem;
using EFT.UI.Matchmaker;
using EFT.UI.Screens;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002AC3 RID: 10947
	public sealed class ReconnectionScreen : EftScreen<ReconnectionScreen.GClass3129, ReconnectionScreen>
	{
		// Token: 0x0600D997 RID: 55703 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(ReconnectionScreen.GClass3129 controller)
		{
			throw null;
		}

		// Token: 0x0600D998 RID: 55704 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600D999 RID: 55705 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(Profile activeProfile, [CanBeNull] LocationSettingsClass.Location location, ESideType side, bool returnAllowed, bool nextScreenAllowed, ISession session)
		{
			throw null;
		}

		// Token: 0x0600D99A RID: 55706 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(bool available)
		{
			throw null;
		}

		// Token: 0x0600D99B RID: 55707 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600D99C RID: 55708 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void TranslateAxes(ref float[] axes)
		{
			throw null;
		}

		// Token: 0x0600D99D RID: 55709 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override ECursorResult ShouldLockCursor()
		{
			throw null;
		}

		// Token: 0x0600D99E RID: 55710 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600D99F RID: 55711 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600D9A0 RID: 55712 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600D9A1 RID: 55713 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0400DC7B RID: 56443
		[SerializeField]
		private DefaultUIButton _reconnectButton;

		// Token: 0x0400DC7C RID: 56444
		[SerializeField]
		private DefaultUIButton _backButton;

		// Token: 0x0400DC7D RID: 56445
		[SerializeField]
		private DefaultUIButton _exitButton;

		// Token: 0x0400DC7E RID: 56446
		[SerializeField]
		private CustomTextMeshProUGUI _locationName;

		// Token: 0x0400DC7F RID: 56447
		[SerializeField]
		private PlayerLevelPanel _levelPanel;

		// Token: 0x0400DC80 RID: 56448
		[SerializeField]
		private PlayerModelView _playerModelView;

		// Token: 0x0400DC81 RID: 56449
		[SerializeField]
		private MatchmakerBannersPanel _bannersPanel;

		// Token: 0x02002AC4 RID: 10948
		public sealed class GClass3129 : GClass3107.GClass3109<ReconnectionScreen.GClass3129, ReconnectionScreen>
		{
			// Token: 0x17002671 RID: 9841
			// (get) Token: 0x0600D9A2 RID: 55714 RVA: 0x00002050 File Offset: 0x00000250
			public override EEftScreenType ScreenType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x140002F9 RID: 761
			// (add) Token: 0x0600D9A3 RID: 55715 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x0600D9A4 RID: 55716 RVA: 0x00002050 File Offset: 0x00000250
			public event Action OnReconnectAction
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

			// Token: 0x140002FA RID: 762
			// (add) Token: 0x0600D9A5 RID: 55717 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x0600D9A6 RID: 55718 RVA: 0x00002050 File Offset: 0x00000250
			public event Action OnLeave
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

			// Token: 0x17002672 RID: 9842
			// (get) Token: 0x0600D9A7 RID: 55719 RVA: 0x00002050 File Offset: 0x00000250
			public override bool KeyScreen
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002673 RID: 9843
			// (get) Token: 0x0600D9A8 RID: 55720 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher TaskBarButtonsVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600D9A9 RID: 55721 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Reconnect()
			{
				throw null;
			}

			// Token: 0x0600D9AA RID: 55722 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Leave()
			{
				throw null;
			}

			// Token: 0x0400DC82 RID: 56450
			[CompilerGenerated]
			private Action action_2;

			// Token: 0x0400DC83 RID: 56451
			[CompilerGenerated]
			private Action action_3;

			// Token: 0x0400DC84 RID: 56452
			public readonly Profile ActiveProfile;

			// Token: 0x0400DC85 RID: 56453
			public readonly LocationSettingsClass.Location Location;

			// Token: 0x0400DC86 RID: 56454
			public readonly ESideType Side;

			// Token: 0x0400DC87 RID: 56455
			public readonly bool ReturnAllowed;

			// Token: 0x0400DC88 RID: 56456
			public readonly bool NextScreenAllowed;

			// Token: 0x0400DC89 RID: 56457
			public readonly ISession Session;
		}
	}
}
