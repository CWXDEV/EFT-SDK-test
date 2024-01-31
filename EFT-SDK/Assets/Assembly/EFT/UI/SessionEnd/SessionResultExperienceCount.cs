using System;
using System.Runtime.CompilerServices;
using EFT.InputSystem;
using EFT.UI.Screens;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.SessionEnd
{
	// Token: 0x02002CE9 RID: 11497
	public sealed class SessionResultExperienceCount : EftScreen<SessionResultExperienceCount.GClass3145, SessionResultExperienceCount>
	{
		// Token: 0x0600E232 RID: 57906 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600E233 RID: 57907 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(SessionResultExperienceCount.GClass3145 controller)
		{
			throw null;
		}

		// Token: 0x0600E234 RID: 57908 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(Profile profile, bool isOnline, ExitStatus exitStatus)
		{
			throw null;
		}

		// Token: 0x0600E235 RID: 57909 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600E236 RID: 57910 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600E237 RID: 57911 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0400E6FD RID: 59133
		[SerializeField]
		private DefaultUIButton _nextButton;

		// Token: 0x0400E6FE RID: 59134
		[SerializeField]
		private DefaultUIButton _backButton;

		// Token: 0x0400E6FF RID: 59135
		[SerializeField]
		private SessionExperiencePanel _experiencePanel;

		// Token: 0x0400E700 RID: 59136
		[SerializeField]
		private CustomTextMeshProUGUI _resultExperience;

		// Token: 0x0400E701 RID: 59137
		[SerializeField]
		private GameObject _sectionsScroller;

		// Token: 0x0400E702 RID: 59138
		[SerializeField]
		private Transform _sectionsContainer;

		// Token: 0x0400E703 RID: 59139
		[SerializeField]
		private ExperienceSectionView _sectionTemplate;

		// Token: 0x0400E704 RID: 59140
		[SerializeField]
		private SpriteMap _bonusGlow;

		// Token: 0x0400E705 RID: 59141
		[SerializeField]
		private SpriteMap _bonusIcons;

		// Token: 0x0400E706 RID: 59142
		[SerializeField]
		private CustomTextMeshProUGUI _bonusTitle;

		// Token: 0x0400E707 RID: 59143
		[SerializeField]
		private CustomTextMeshProUGUI _bonusValue;

		// Token: 0x0400E708 RID: 59144
		[SerializeField]
		private Image _bonusBack;

		// Token: 0x0400E709 RID: 59145
		[SerializeField]
		private Image _bonusIcon;

		// Token: 0x0400E70A RID: 59146
		[SerializeField]
		private Image _bonusHalo;

		// Token: 0x0400E70B RID: 59147
		private GClass3078<GClass3103, ExperienceSectionView> gclass3078_0;

		// Token: 0x02002CEA RID: 11498
		public sealed class GClass3145 : GClass3142<SessionResultExperienceCount.GClass3145, SessionResultExperienceCount>
		{
			// Token: 0x17002775 RID: 10101
			// (get) Token: 0x0600E238 RID: 57912 RVA: 0x00002050 File Offset: 0x00000250
			public override EEftScreenType ScreenType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002776 RID: 10102
			// (get) Token: 0x0600E239 RID: 57913 RVA: 0x00002050 File Offset: 0x00000250
			protected override bool MainEnvironment
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002777 RID: 10103
			// (get) Token: 0x0600E23A RID: 57914 RVA: 0x00002050 File Offset: 0x00000250
			public override bool KeyScreen
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002778 RID: 10104
			// (get) Token: 0x0600E23B RID: 57915 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher TaskBarButtonsVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002779 RID: 10105
			// (get) Token: 0x0600E23C RID: 57916 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher MenuChatBarVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0400E70C RID: 59148
			public readonly Profile Profile;

			// Token: 0x0400E70D RID: 59149
			public readonly bool IsOnline;

			// Token: 0x0400E70E RID: 59150
			public readonly ExitStatus ExitStatus;
		}

		// Token: 0x02002CEB RID: 11499
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2751
		{
			// Token: 0x0600E23D RID: 57917 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(GClass3103 section, ExperienceSectionView view)
			{
				throw null;
			}

			// Token: 0x0400E70F RID: 59151
			public static readonly SessionResultExperienceCount.Class2751 class2751_0;

			// Token: 0x0400E710 RID: 59152
			public static Action<GClass3103, ExperienceSectionView> action_0;
		}
	}
}
