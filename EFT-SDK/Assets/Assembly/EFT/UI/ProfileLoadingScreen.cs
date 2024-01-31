using System;
using System.Collections;
using System.Runtime.CompilerServices;
using EFT.InputSystem;
using EFT.UI.Screens;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002ABD RID: 10941
	public sealed class ProfileLoadingScreen : EftScreen<ProfileLoadingScreen.GClass3128, ProfileLoadingScreen>
	{
		// Token: 0x0600D97F RID: 55679 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(ProfileLoadingScreen.GClass3128 controller)
		{
			throw null;
		}

		// Token: 0x0600D980 RID: 55680 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(bool loading)
		{
			throw null;
		}

		// Token: 0x0600D981 RID: 55681 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(bool isLiving)
		{
			throw null;
		}

		// Token: 0x0600D982 RID: 55682 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static IEnumerator smethod_0(Action autoHideAction)
		{
			throw null;
		}

		// Token: 0x0600D983 RID: 55683 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0400DC6D RID: 56429
		private const string string_0 = "Profile data loading...";

		// Token: 0x0400DC6E RID: 56430
		private const string string_1 = "Leaving the game...";

		// Token: 0x0400DC6F RID: 56431
		[SerializeField]
		private RectTransform _loadingPanel;

		// Token: 0x0400DC70 RID: 56432
		[SerializeField]
		private RectTransform _errorPanel;

		// Token: 0x0400DC71 RID: 56433
		[SerializeField]
		private CustomTextMeshProUGUI _statusField;

		// Token: 0x02002ABE RID: 10942
		public sealed class GClass3128 : GClass3107.GClass3109<ProfileLoadingScreen.GClass3128, ProfileLoadingScreen>
		{
			// Token: 0x17002667 RID: 9831
			// (get) Token: 0x0600D984 RID: 55684 RVA: 0x00002050 File Offset: 0x00000250
			public override EEftScreenType ScreenType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002668 RID: 9832
			// (get) Token: 0x0600D985 RID: 55685 RVA: 0x00002050 File Offset: 0x00000250
			protected override bool MainEnvironment
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002669 RID: 9833
			// (get) Token: 0x0600D986 RID: 55686 RVA: 0x00002050 File Offset: 0x00000250
			protected override EShadingStateSwitcher ShadingType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700266A RID: 9834
			// (get) Token: 0x0600D987 RID: 55687 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher MenuChatBarVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700266B RID: 9835
			// (get) Token: 0x0600D988 RID: 55688 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher TaskBarButtonsVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700266C RID: 9836
			// (get) Token: 0x0600D989 RID: 55689 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher ShowEnvironment
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700266D RID: 9837
			// (get) Token: 0x0600D98A RID: 55690 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher EnvironmentOverlay
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700266E RID: 9838
			// (get) Token: 0x0600D98B RID: 55691 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher ShowEnvironmentCamera
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600D98C RID: 55692 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetLivingStatus(bool isLiving)
			{
				throw null;
			}
		}
	}
}
