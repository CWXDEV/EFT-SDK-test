using System;
using System.Runtime.CompilerServices;
using EFT.InputSystem;
using EFT.UI.Screens;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002C74 RID: 11380
	public sealed class ValidateDeviceIdScreen : EftScreen<ValidateDeviceIdScreen.GClass3139, ValidateDeviceIdScreen>
	{
		// Token: 0x0600E038 RID: 57400 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600E039 RID: 57401 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(ValidateDeviceIdScreen.GClass3139 controller)
		{
			throw null;
		}

		// Token: 0x0600E03A RID: 57402 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show()
		{
			throw null;
		}

		// Token: 0x0600E03B RID: 57403 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600E03C RID: 57404 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(string err)
		{
			throw null;
		}

		// Token: 0x0600E03D RID: 57405 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600E03E RID: 57406 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600E03F RID: 57407 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600E040 RID: 57408 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600E041 RID: 57409 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(string arg)
		{
			throw null;
		}

		// Token: 0x0400E4BF RID: 58559
		[SerializeField]
		private CustomTextMeshProInputField _deviceIdInputField;

		// Token: 0x0400E4C0 RID: 58560
		[SerializeField]
		private CustomTextMeshProUGUI _errorLabel;

		// Token: 0x0400E4C1 RID: 58561
		[SerializeField]
		private DefaultUIButton _nextButton;

		// Token: 0x0400E4C2 RID: 58562
		[SerializeField]
		private DefaultUIButton _cancelButton;

		// Token: 0x02002C75 RID: 11381
		public sealed class GClass3139 : GClass3107.GClass3109<ValidateDeviceIdScreen.GClass3139, ValidateDeviceIdScreen>
		{
			// Token: 0x17002726 RID: 10022
			// (get) Token: 0x0600E042 RID: 57410 RVA: 0x00002050 File Offset: 0x00000250
			public override EEftScreenType ScreenType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x14000315 RID: 789
			// (add) Token: 0x0600E043 RID: 57411 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x0600E044 RID: 57412 RVA: 0x00002050 File Offset: 0x00000250
			public event Action<string> OnValidateDeviceId
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

			// Token: 0x17002727 RID: 10023
			// (get) Token: 0x0600E045 RID: 57413 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher MenuChatBarVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600E046 RID: 57414 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_9(string deviceId)
			{
				throw null;
			}

			// Token: 0x0600E047 RID: 57415 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void ErrorShow(string err)
			{
				throw null;
			}

			// Token: 0x0400E4C3 RID: 58563
			[CompilerGenerated]
			private Action<string> action_2;
		}
	}
}
