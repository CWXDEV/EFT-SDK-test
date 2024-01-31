using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EFT.InputSystem;
using EFT.UI.Screens;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x0200292F RID: 10543
	public sealed class WelcomeScreen : EftScreen<WelcomeScreen.GClass3144, WelcomeScreen>
	{
		// Token: 0x17002578 RID: 9592
		// (get) Token: 0x0600D281 RID: 53889 RVA: 0x00002050 File Offset: 0x00000250
		public static string DefaultLanguage
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600D282 RID: 53890 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(WelcomeScreen.GClass3144 controller)
		{
			throw null;
		}

		// Token: 0x0600D283 RID: 53891 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(ISession session)
		{
			throw null;
		}

		// Token: 0x0600D284 RID: 53892 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(bool value)
		{
			throw null;
		}

		// Token: 0x0600D285 RID: 53893 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_4()
		{
			throw null;
		}

		// Token: 0x0600D286 RID: 53894 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(bool value)
		{
			throw null;
		}

		// Token: 0x0600D287 RID: 53895 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_6(string locale)
		{
			throw null;
		}

		// Token: 0x0600D288 RID: 53896 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(bool value)
		{
			throw null;
		}

		// Token: 0x0600D289 RID: 53897 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8(string locale)
		{
			throw null;
		}

		// Token: 0x0600D28A RID: 53898 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600D28B RID: 53899 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600D28C RID: 53900 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x0400D3E1 RID: 54241
		[SerializeField]
		private DefaultUIButton _acceptButton;

		// Token: 0x0400D3E2 RID: 54242
		[SerializeField]
		private GameObject _loadingCaption;

		// Token: 0x0400D3E3 RID: 54243
		[SerializeField]
		private GameObject _loader;

		// Token: 0x0400D3E4 RID: 54244
		[SerializeField]
		private GameObject _descriptionText;

		// Token: 0x0400D3E5 RID: 54245
		[SerializeField]
		private LocalizationButtonCap _toggleTemplate;

		// Token: 0x0400D3E6 RID: 54246
		[SerializeField]
		private RectTransform _togglesContainer;

		// Token: 0x0400D3E7 RID: 54247
		private const string string_0 = "ru";

		// Token: 0x0400D3E8 RID: 54248
		private const string string_1 = "en";

		// Token: 0x0400D3E9 RID: 54249
		private const string string_2 = "fr";

		// Token: 0x0400D3EA RID: 54250
		private const string string_3 = "ge";

		// Token: 0x0400D3EB RID: 54251
		private ISession ginterface145_0;

		// Token: 0x0400D3EC RID: 54252
		private Dictionary<string, LocalizationButtonCap> dictionary_0;

		// Token: 0x0400D3ED RID: 54253
		private CancellationTokenSource cancellationTokenSource_0;

		// Token: 0x0400D3EE RID: 54254
		private bool bool_1;

		// Token: 0x02002930 RID: 10544
		public sealed class GClass3144 : GClass3142<WelcomeScreen.GClass3144, WelcomeScreen>
		{
			// Token: 0x17002579 RID: 9593
			// (get) Token: 0x0600D28D RID: 53901 RVA: 0x00002050 File Offset: 0x00000250
			public override EEftScreenType ScreenType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700257A RID: 9594
			// (get) Token: 0x0600D28E RID: 53902 RVA: 0x00002050 File Offset: 0x00000250
			protected override bool MainEnvironment
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700257B RID: 9595
			// (get) Token: 0x0600D28F RID: 53903 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher MenuChatBarVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600D290 RID: 53904 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetButtonAvailability(bool value)
			{
				throw null;
			}

			// Token: 0x0400D3EF RID: 54255
			public readonly ISession Session;
		}

		// Token: 0x02002931 RID: 10545
		[CompilerGenerated]
		private sealed class Class2408
		{
			// Token: 0x0600D291 RID: 53905 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(bool arg)
			{
				throw null;
			}

			// Token: 0x0400D3F0 RID: 54256
			public string localizationString;

			// Token: 0x0400D3F1 RID: 54257
			public WelcomeScreen welcomeScreen_0;
		}
	}
}
