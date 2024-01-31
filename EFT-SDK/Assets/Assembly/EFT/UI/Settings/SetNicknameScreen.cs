using System;
using System.Runtime.CompilerServices;
using EFT.InputSystem;
using EFT.UI.Screens;
using UnityEngine;

namespace EFT.UI.Settings
{
	// Token: 0x02002D25 RID: 11557
	public sealed class SetNicknameScreen : EftScreen<SetNicknameScreen.GClass3159, SetNicknameScreen>
	{
		// Token: 0x0600E35C RID: 58204 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600E35D RID: 58205 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(SetNicknameScreen.GClass3159 controller)
		{
			throw null;
		}

		// Token: 0x0600E35E RID: 58206 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600E35F RID: 58207 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(ENicknameError error)
		{
			throw null;
		}

		// Token: 0x0600E360 RID: 58208 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(string reservedNickname)
		{
			throw null;
		}

		// Token: 0x0600E361 RID: 58209 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(bool value)
		{
			throw null;
		}

		// Token: 0x0600E362 RID: 58210 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600E363 RID: 58211 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(bool hasError)
		{
			throw null;
		}

		// Token: 0x0400E829 RID: 59433
		[SerializeField]
		private ValidationInputField _nicknameInput;

		// Token: 0x0400E82A RID: 59434
		[SerializeField]
		private DefaultUIButton _nextButton;

		// Token: 0x02002D26 RID: 11558
		public sealed class GClass3159 : GClass3107.GClass3109<SetNicknameScreen.GClass3159, SetNicknameScreen>
		{
			// Token: 0x170027BA RID: 10170
			// (get) Token: 0x0600E364 RID: 58212 RVA: 0x00002050 File Offset: 0x00000250
			public override EEftScreenType ScreenType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1400032C RID: 812
			// (add) Token: 0x0600E365 RID: 58213 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x0600E366 RID: 58214 RVA: 0x00002050 File Offset: 0x00000250
			public event Action<string> OnNickNameSubmitted
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

			// Token: 0x1400032D RID: 813
			// (add) Token: 0x0600E367 RID: 58215 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x0600E368 RID: 58216 RVA: 0x00002050 File Offset: 0x00000250
			public event Action<ENicknameError> OnNicknameError
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

			// Token: 0x170027BB RID: 10171
			// (get) Token: 0x0600E369 RID: 58217 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher MenuChatBarVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600E36A RID: 58218 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SubmitNickname(string nickname)
			{
				throw null;
			}

			// Token: 0x0600E36B RID: 58219 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void ShowNicknameError(ENicknameError error)
			{
				throw null;
			}

			// Token: 0x0400E82B RID: 59435
			[CompilerGenerated]
			private Action<string> action_2;

			// Token: 0x0400E82C RID: 59436
			[CompilerGenerated]
			private Action<ENicknameError> action_3;

			// Token: 0x0400E82D RID: 59437
			public readonly string ReservedNickname;
		}

		// Token: 0x02002D27 RID: 11559
		[CompilerGenerated]
		private sealed class Class2766
		{
			// Token: 0x0600E36C RID: 58220 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400E82E RID: 59438
			public SetNicknameScreen.GClass3159 controller;

			// Token: 0x0400E82F RID: 59439
			public SetNicknameScreen setNicknameScreen_0;
		}
	}
}
