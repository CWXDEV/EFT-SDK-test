using System;
using System.Runtime.CompilerServices;
using EFT.InputSystem;
using EFT.UI.Screens;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002A64 RID: 10852
	public sealed class LoginScreen : EftScreen<LoginScreen.GClass3121, LoginScreen>
	{
		// Token: 0x0600D793 RID: 55187 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600D794 RID: 55188 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(bool value)
		{
			throw null;
		}

		// Token: 0x0600D795 RID: 55189 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(LoginScreen.GClass3121 controller)
		{
			throw null;
		}

		// Token: 0x0600D796 RID: 55190 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(string login, string password, bool saveToggle)
		{
			throw null;
		}

		// Token: 0x0600D797 RID: 55191 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600D798 RID: 55192 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(string login, string password)
		{
			throw null;
		}

		// Token: 0x0600D799 RID: 55193 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(string err, double banTime)
		{
			throw null;
		}

		// Token: 0x0600D79A RID: 55194 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string smethod_0(double unix)
		{
			throw null;
		}

		// Token: 0x0600D79B RID: 55195 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetNextButtonStatus(bool status)
		{
			throw null;
		}

		// Token: 0x0600D79C RID: 55196 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600D79D RID: 55197 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0400DA3D RID: 55869
		[SerializeField]
		private QueueScreen _queuePanel;

		// Token: 0x0400DA3E RID: 55870
		[SerializeField]
		private CustomTextMeshProInputField _loginInput;

		// Token: 0x0400DA3F RID: 55871
		[SerializeField]
		private CustomTextMeshProInputField _passwordInput;

		// Token: 0x0400DA40 RID: 55872
		[SerializeField]
		private Toggle _passwordToggle;

		// Token: 0x0400DA41 RID: 55873
		[SerializeField]
		private CustomTextMeshProUGUI _errorLabel;

		// Token: 0x0400DA42 RID: 55874
		[SerializeField]
		private DefaultUIButton _nextButton;

		// Token: 0x0400DA43 RID: 55875
		[SerializeField]
		private DefaultUIButton _exitButton;

		// Token: 0x0400DA44 RID: 55876
		[SerializeField]
		private GameObject _blockPanel;

		// Token: 0x0400DA45 RID: 55877
		private string string_0;

		// Token: 0x0400DA46 RID: 55878
		private bool bool_1;

		// Token: 0x02002A65 RID: 10853
		public sealed class GClass3121 : GClass3107.GClass3109<LoginScreen.GClass3121, LoginScreen>
		{
			// Token: 0x17002631 RID: 9777
			// (get) Token: 0x0600D79E RID: 55198 RVA: 0x00002050 File Offset: 0x00000250
			public override EEftScreenType ScreenType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x140002F2 RID: 754
			// (add) Token: 0x0600D79F RID: 55199 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x0600D7A0 RID: 55200 RVA: 0x00002050 File Offset: 0x00000250
			public event Action<string, string, bool, Action<string, double>> OnLogin
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

			// Token: 0x140002F3 RID: 755
			// (add) Token: 0x0600D7A1 RID: 55201 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x0600D7A2 RID: 55202 RVA: 0x00002050 File Offset: 0x00000250
			public event Action OnRestore
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

			// Token: 0x17002632 RID: 9778
			// (get) Token: 0x0600D7A3 RID: 55203 RVA: 0x00002050 File Offset: 0x00000250
			protected override bool MainEnvironment
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002633 RID: 9779
			// (get) Token: 0x0600D7A4 RID: 55204 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher MenuChatBarVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002634 RID: 9780
			// (get) Token: 0x0600D7A5 RID: 55205 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher TaskBarButtonsVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002635 RID: 9781
			// (get) Token: 0x0600D7A6 RID: 55206 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher EnvironmentOverlay
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600D7A7 RID: 55207 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_9(string login, string password, bool savePassword, Action<string, double> onError)
			{
				throw null;
			}

			// Token: 0x0600D7A8 RID: 55208 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_10()
			{
				throw null;
			}

			// Token: 0x0400DA47 RID: 55879
			[CompilerGenerated]
			private Action<string, string, bool, Action<string, double>> action_2;

			// Token: 0x0400DA48 RID: 55880
			[CompilerGenerated]
			private Action action_3;

			// Token: 0x0400DA49 RID: 55881
			public readonly string Login;

			// Token: 0x0400DA4A RID: 55882
			public readonly string Password;

			// Token: 0x0400DA4B RID: 55883
			public readonly bool SavePassword;
		}

		// Token: 0x02002A66 RID: 10854
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2521
		{
			// Token: 0x0600D7A9 RID: 55209 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400DA4C RID: 55884
			public static readonly LoginScreen.Class2521 class2521_0;

			// Token: 0x0400DA4D RID: 55885
			public static UnityAction unityAction_0;
		}
	}
}
