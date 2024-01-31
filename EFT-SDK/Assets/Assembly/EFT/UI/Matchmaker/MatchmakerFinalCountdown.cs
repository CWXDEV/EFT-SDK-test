using System;
using System.Runtime.CompilerServices;
using EFT.InputSystem;
using EFT.UI.Screens;
using TMPro;
using UnityEngine;

namespace EFT.UI.Matchmaker
{
	// Token: 0x02002DE3 RID: 11747
	public sealed class MatchmakerFinalCountdown : EftScreen<MatchmakerFinalCountdown.GClass3162, MatchmakerFinalCountdown>
	{
		// Token: 0x0600E6FA RID: 59130 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(MatchmakerFinalCountdown.GClass3162 controller)
		{
			throw null;
		}

		// Token: 0x0600E6FB RID: 59131 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(Profile activeProfile, DateTime gameStartTime)
		{
			throw null;
		}

		// Token: 0x0600E6FC RID: 59132 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600E6FD RID: 59133 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0400EC22 RID: 60450
		[SerializeField]
		private TextMeshProUGUI _time;

		// Token: 0x0400EC23 RID: 60451
		[SerializeField]
		private PlayerNamePanel _namePanel;

		// Token: 0x0400EC24 RID: 60452
		private DateTime dateTime_0;

		// Token: 0x02002DE4 RID: 11748
		public sealed class GClass3162 : GClass3107.GClass3109<MatchmakerFinalCountdown.GClass3162, MatchmakerFinalCountdown>
		{
			// Token: 0x1700281F RID: 10271
			// (get) Token: 0x0600E6FE RID: 59134 RVA: 0x00002050 File Offset: 0x00000250
			public override EEftScreenType ScreenType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002820 RID: 10272
			// (get) Token: 0x0600E6FF RID: 59135 RVA: 0x00002050 File Offset: 0x00000250
			public override bool KeyScreen
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002821 RID: 10273
			// (get) Token: 0x0600E700 RID: 59136 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher MenuChatBarVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0400EC25 RID: 60453
			public readonly Profile ActiveProfile;

			// Token: 0x0400EC26 RID: 60454
			public readonly DateTime GameStartTime;
		}
	}
}
