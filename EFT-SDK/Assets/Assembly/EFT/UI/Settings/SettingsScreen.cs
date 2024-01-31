using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EFT.InputSystem;
using EFT.UI.Screens;
using UnityEngine;

namespace EFT.UI.Settings
{
	// Token: 0x02002D68 RID: 11624
	public sealed class SettingsScreen : EftScreen<SettingsScreen.GClass3160, SettingsScreen>
	{
		// Token: 0x0600E49F RID: 58527 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600E4A0 RID: 58528 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(SettingsScreen.GClass3160 controller)
		{
			throw null;
		}

		// Token: 0x0600E4A1 RID: 58529 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show()
		{
			throw null;
		}

		// Token: 0x0600E4A2 RID: 58530 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(bool toggleEnabled)
		{
			throw null;
		}

		// Token: 0x0600E4A3 RID: 58531 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(bool inProgress)
		{
			throw null;
		}

		// Token: 0x0600E4A4 RID: 58532 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600E4A5 RID: 58533 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600E4A6 RID: 58534 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void TranslateAxes(ref float[] axes)
		{
			throw null;
		}

		// Token: 0x0600E4A7 RID: 58535 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override ECursorResult ShouldLockCursor()
		{
			throw null;
		}

		// Token: 0x0600E4A8 RID: 58536 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600E4A9 RID: 58537 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(SettingsScreen.ESettingsGroup desiredGroup)
		{
			throw null;
		}

		// Token: 0x0600E4AA RID: 58538 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(SettingsScreen.ESettingsGroup group)
		{
			throw null;
		}

		// Token: 0x0600E4AB RID: 58539 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8(bool status)
		{
			throw null;
		}

		// Token: 0x0600E4AC RID: 58540 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x0600E4AD RID: 58541 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10(Action accept, Action cancel)
		{
			throw null;
		}

		// Token: 0x0600E4AE RID: 58542 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11()
		{
			throw null;
		}

		// Token: 0x0600E4AF RID: 58543 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12()
		{
			throw null;
		}

		// Token: 0x0600E4B0 RID: 58544 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13()
		{
			throw null;
		}

		// Token: 0x0400E9B6 RID: 59830
		[SerializeField]
		private GameObject _loader;

		// Token: 0x0400E9B7 RID: 59831
		[SerializeField]
		private DefaultUIButton _saveButton;

		// Token: 0x0400E9B8 RID: 59832
		[SerializeField]
		private DefaultUIButton _backButton;

		// Token: 0x0400E9B9 RID: 59833
		[SerializeField]
		private DefaultUIButton _defaultButton;

		// Token: 0x0400E9BA RID: 59834
		[Space]
		[SerializeField]
		private UIAnimatedToggleSpawner _gameButton;

		// Token: 0x0400E9BB RID: 59835
		[SerializeField]
		private UIAnimatedToggleSpawner _graphicsButton;

		// Token: 0x0400E9BC RID: 59836
		[SerializeField]
		private UIAnimatedToggleSpawner _postFXButton;

		// Token: 0x0400E9BD RID: 59837
		[SerializeField]
		private UIAnimatedToggleSpawner _soundButton;

		// Token: 0x0400E9BE RID: 59838
		[SerializeField]
		private UIAnimatedToggleSpawner _controlsButton;

		// Token: 0x0400E9BF RID: 59839
		[Space]
		[SerializeField]
		private GameSettingsTab _gameSettingsScreen;

		// Token: 0x0400E9C0 RID: 59840
		[SerializeField]
		private GraphicsSettingsTab _graphicsSettingsScreen;

		// Token: 0x0400E9C1 RID: 59841
		[SerializeField]
		private PostFXSettingsTab _postFXSettingsScreen;

		// Token: 0x0400E9C2 RID: 59842
		[SerializeField]
		private SoundSettingsTab _soundSettingsScreen;

		// Token: 0x0400E9C3 RID: 59843
		[SerializeField]
		private ControlSettingsTab _controlsSettingsTabScreen;

		// Token: 0x0400E9C4 RID: 59844
		private SettingsTab settingsTab_0;

		// Token: 0x0400E9C5 RID: 59845
		private static readonly Dictionary<SettingsScreen.ESettingsGroup, SettingsScreen.Struct967> dictionary_0;

		// Token: 0x02002D69 RID: 11625
		public enum ESettingsGroup
		{
			// Token: 0x0400E9C7 RID: 59847
			Screen,
			// Token: 0x0400E9C8 RID: 59848
			Game,
			// Token: 0x0400E9C9 RID: 59849
			Sound,
			// Token: 0x0400E9CA RID: 59850
			Control,
			// Token: 0x0400E9CB RID: 59851
			PostFX
		}

		// Token: 0x02002D6A RID: 11626
		public class GClass3160 : GClass3107.GClass3109<SettingsScreen.GClass3160, SettingsScreen>
		{
			// Token: 0x170027CD RID: 10189
			// (get) Token: 0x0600E4B1 RID: 58545 RVA: 0x00002050 File Offset: 0x00000250
			public override EEftScreenType ScreenType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170027CE RID: 10190
			// (get) Token: 0x0600E4B2 RID: 58546 RVA: 0x00002050 File Offset: 0x00000250
			public SharedGameSettingsClass OriginalSettings
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170027CF RID: 10191
			// (get) Token: 0x0600E4B3 RID: 58547 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher MenuChatBarVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170027D0 RID: 10192
			// (get) Token: 0x0600E4B4 RID: 58548 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher TaskBarButtonsVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600E4B5 RID: 58549 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void InitSettings(SharedGameSettingsClass settingsManager)
			{
				throw null;
			}

			// Token: 0x0600E4B6 RID: 58550 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override Task<bool> CloseScreenInterruption(bool moveForward)
			{
				throw null;
			}

			// Token: 0x0600E4B7 RID: 58551 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Task SaveSettings()
			{
				throw null;
			}

			// Token: 0x0600E4B8 RID: 58552 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void TakeFromDefault()
			{
				throw null;
			}

			// Token: 0x0600E4B9 RID: 58553 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_9()
			{
				throw null;
			}

			// Token: 0x0600E4BA RID: 58554 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_10()
			{
				throw null;
			}

			// Token: 0x0600E4BB RID: 58555 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_11()
			{
				throw null;
			}

			// Token: 0x0600E4BC RID: 58556 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_12()
			{
				throw null;
			}

			// Token: 0x0600E4BD RID: 58557 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[DebuggerHidden]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Task<bool> method_13(bool moveForward)
			{
				throw null;
			}

			// Token: 0x0400E9CC RID: 59852
			public readonly ISession BackEndSession;

			// Token: 0x0400E9CD RID: 59853
			public SettingsScreen.GClass3160.GClass3165 TempSettings;

			// Token: 0x0400E9CE RID: 59854
			public GClass3174 GesturesStorage;

			// Token: 0x0400E9CF RID: 59855
			public SettingsScreen.ESettingsGroup CurrentGroup;

			// Token: 0x0400E9D0 RID: 59856
			public bool IgnoreScreenInterruptionCheck;

			// Token: 0x0400E9D1 RID: 59857
			private SharedGameSettingsClass gclass1872_0;

			// Token: 0x02002D6B RID: 11627
			public sealed class GClass3165
			{
				// Token: 0x0600E4BE RID: 58558 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public static SettingsScreen.GClass3160.GClass3165 CopyFromManager(SharedGameSettingsClass manager)
				{
					throw null;
				}

				// Token: 0x0600E4BF RID: 58559 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public bool HasSameSettings(SharedGameSettingsClass manager)
				{
					throw null;
				}

				// Token: 0x0600E4C0 RID: 58560 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public Task ApplyTo(SharedGameSettingsClass manager)
				{
					throw null;
				}

				// Token: 0x0400E9D2 RID: 59858
				public GClass956 Game;

				// Token: 0x0400E9D3 RID: 59859
				public GClass953 Sound;

				// Token: 0x0400E9D4 RID: 59860
				public GClass954 PostFx;

				// Token: 0x0400E9D5 RID: 59861
				public GClass955 Graphics;

				// Token: 0x0400E9D6 RID: 59862
				public GClass957 Control;
			}
		}

		// Token: 0x02002D6F RID: 11631
		public sealed class GClass3161 : SettingsScreen.GClass3160
		{
			// Token: 0x170027D1 RID: 10193
			// (get) Token: 0x0600E4C7 RID: 58567 RVA: 0x00002050 File Offset: 0x00000250
			protected override EShadingStateSwitcher ShadingType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170027D2 RID: 10194
			// (get) Token: 0x0600E4C8 RID: 58568 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher MenuChatBarVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170027D3 RID: 10195
			// (get) Token: 0x0600E4C9 RID: 58569 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher TaskBarButtonsVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170027D4 RID: 10196
			// (get) Token: 0x0600E4CA RID: 58570 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher ShowEnvironment
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170027D5 RID: 10197
			// (get) Token: 0x0600E4CB RID: 58571 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher EnvironmentOverlay
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170027D6 RID: 10198
			// (get) Token: 0x0600E4CC RID: 58572 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher ShowEnvironmentCamera
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}
		}

		// Token: 0x02002D70 RID: 11632
		[StructLayout(LayoutKind.Auto)]
		public readonly struct Struct967
		{
			// Token: 0x0400E9E5 RID: 59877
			public readonly SettingsTab Tab;

			// Token: 0x0400E9E6 RID: 59878
			public readonly UIAnimatedToggleSpawner Toggle;
		}

		// Token: 0x02002D71 RID: 11633
		[CompilerGenerated]
		private sealed class Class2805
		{
			// Token: 0x0600E4CD RID: 58573 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(bool isOn)
			{
				throw null;
			}

			// Token: 0x0600E4CE RID: 58574 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x0400E9E7 RID: 59879
			public SettingsScreen.ESettingsGroup key;

			// Token: 0x0400E9E8 RID: 59880
			public SettingsScreen.Struct967 value;

			// Token: 0x0400E9E9 RID: 59881
			public SettingsScreen settingsScreen_0;
		}

		// Token: 0x02002D72 RID: 11634
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2806
		{
			// Token: 0x0600E4CF RID: 58575 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400E9EA RID: 59882
			public static readonly SettingsScreen.Class2806 class2806_0;

			// Token: 0x0400E9EB RID: 59883
			public static Action action_0;
		}
	}
}
