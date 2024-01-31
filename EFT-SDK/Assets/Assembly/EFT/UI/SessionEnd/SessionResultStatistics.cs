using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InputSystem;
using EFT.UI.Screens;
using UnityEngine;

namespace EFT.UI.SessionEnd
{
	// Token: 0x02002CF4 RID: 11508
	public sealed class SessionResultStatistics : EftScreen<SessionResultStatistics.GClass3147, SessionResultStatistics>
	{
		// Token: 0x0600E251 RID: 57937 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600E252 RID: 57938 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(SessionResultStatistics.GClass3147 controller)
		{
			throw null;
		}

		// Token: 0x0600E253 RID: 57939 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(Profile profile, LocationSettingsClass.Location location)
		{
			throw null;
		}

		// Token: 0x0600E254 RID: 57940 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600E255 RID: 57941 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600E256 RID: 57942 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600E257 RID: 57943 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0400E724 RID: 59172
		[SerializeField]
		private DefaultUIButton _nextButton;

		// Token: 0x0400E725 RID: 59173
		[SerializeField]
		private DefaultUIButton _backButton;

		// Token: 0x0400E726 RID: 59174
		[SerializeField]
		private StatisticsSpawn _statsSpawn;

		// Token: 0x0400E727 RID: 59175
		[SerializeField]
		private CustomTextMeshProUGUI _locationName;

		// Token: 0x02002CF5 RID: 11509
		public sealed class GClass3147 : GClass3142<SessionResultStatistics.GClass3147, SessionResultStatistics>
		{
			// Token: 0x17002781 RID: 10113
			// (get) Token: 0x0600E258 RID: 57944 RVA: 0x00002050 File Offset: 0x00000250
			public override EEftScreenType ScreenType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002782 RID: 10114
			// (get) Token: 0x0600E259 RID: 57945 RVA: 0x00002050 File Offset: 0x00000250
			protected override bool MainEnvironment
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002783 RID: 10115
			// (get) Token: 0x0600E25A RID: 57946 RVA: 0x00002050 File Offset: 0x00000250
			public override bool KeyScreen
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002784 RID: 10116
			// (get) Token: 0x0600E25B RID: 57947 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher TaskBarButtonsVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002785 RID: 10117
			// (get) Token: 0x0600E25C RID: 57948 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher MenuChatBarVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0400E728 RID: 59176
			public readonly Profile Profile;

			// Token: 0x0400E729 RID: 59177
			public readonly LocationSettingsClass.Location Location;
		}

		// Token: 0x02002CF6 RID: 11510
		public sealed class GClass3105
		{
			// Token: 0x0400E72A RID: 59178
			public readonly List<ProfileStats.GClass690> StatItems;

			// Token: 0x0400E72B RID: 59179
			public string Caption;

			// Token: 0x0400E72C RID: 59180
			public Sprite Icon;

			// Token: 0x0400E72D RID: 59181
			public StatisticsSpawn.EStatGroupLayoutType LayoutType;
		}
	}
}
