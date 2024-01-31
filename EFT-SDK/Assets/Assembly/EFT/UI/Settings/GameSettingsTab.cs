using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Comfort.Common;
using UnityEngine;
using UnityEngine.Events;

namespace EFT.UI.Settings
{
	// Token: 0x02002D43 RID: 11587
	public sealed class GameSettingsTab : SettingsTab
	{
		// Token: 0x0600E3DB RID: 58331 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600E3DC RID: 58332 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600E3DD RID: 58333 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass956 gameSettings, ISession backEndSession)
		{
			throw null;
		}

		// Token: 0x0600E3DE RID: 58334 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600E3DF RID: 58335 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_1()
		{
			throw null;
		}

		// Token: 0x0600E3E0 RID: 58336 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600E3E1 RID: 58337 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task TakeSettingsFrom(SharedGameSettingsClass settingsManager)
		{
			throw null;
		}

		// Token: 0x0600E3E2 RID: 58338 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600E3E3 RID: 58339 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(bool hideStreamerName)
		{
			throw null;
		}

		// Token: 0x0600E3E4 RID: 58340 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600E3E5 RID: 58341 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(long date)
		{
			throw null;
		}

		// Token: 0x0600E3E6 RID: 58342 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(string x)
		{
			throw null;
		}

		// Token: 0x0600E3E7 RID: 58343 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(string x)
		{
			throw null;
		}

		// Token: 0x0600E3E8 RID: 58344 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8(string x)
		{
			throw null;
		}

		// Token: 0x0600E3E9 RID: 58345 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(Result<GClass688> changeNicknameResult)
		{
			throw null;
		}

		// Token: 0x0400E8B2 RID: 59570
		private const string string_1 = "NicknameCanBeChangedAfter";

		// Token: 0x0400E8B3 RID: 59571
		private const string string_2 = "Not available in alpha";

		// Token: 0x0400E8B4 RID: 59572
		private static readonly ReadOnlyCollection<int> readOnlyCollection_0;

		// Token: 0x0400E8B5 RID: 59573
		private static readonly ReadOnlyCollection<float> readOnlyCollection_1;

		// Token: 0x0400E8B6 RID: 59574
		[SerializeField]
		private DropDownBox _interfaceLanguage;

		// Token: 0x0400E8B7 RID: 59575
		[SerializeField]
		private DropDownBox _interfaceEnvironmentType;

		// Token: 0x0400E8B8 RID: 59576
		[SerializeField]
		private DropDownBox _quickSlotsDropdown;

		// Token: 0x0400E8B9 RID: 59577
		[SerializeField]
		private DropDownBox _staminaDropdown;

		// Token: 0x0400E8BA RID: 59578
		[SerializeField]
		private DropDownBox _healthDropdown;

		// Token: 0x0400E8BB RID: 59579
		[SerializeField]
		private DropDownBox _healthColorDropdown;

		// Token: 0x0400E8BC RID: 59580
		[SerializeField]
		private DropDownBox _highlightScopeDropdown;

		// Token: 0x0400E8BD RID: 59581
		[SerializeField]
		private DropDownBox _notificationTypeDropdown;

		// Token: 0x0400E8BE RID: 59582
		[SerializeField]
		private DropDownBox _itemUseTypeDropdown;

		// Token: 0x0400E8BF RID: 59583
		[SerializeField]
		private DropDownBox _autoVaultingTypeDropdown;

		// Token: 0x0400E8C0 RID: 59584
		[SerializeField]
		private DropDownBox _connectionTypeDropdown;

		// Token: 0x0400E8C1 RID: 59585
		[SerializeField]
		private UpdatableToggle _subtitles;

		// Token: 0x0400E8C2 RID: 59586
		[SerializeField]
		private UpdatableToggle _tutorialHints;

		// Token: 0x0400E8C3 RID: 59587
		[SerializeField]
		private UpdatableToggle _dontAllowToAddMe;

		// Token: 0x0400E8C4 RID: 59588
		[SerializeField]
		private UpdatableToggle _clearRAM;

		// Token: 0x0400E8C5 RID: 59589
		[SerializeField]
		private UpdatableToggle _setAffinityToLogicalCores;

		// Token: 0x0400E8C6 RID: 59590
		[SerializeField]
		private UpdatableToggle _enableHideoutPreload;

		// Token: 0x0400E8C7 RID: 59591
		[SerializeField]
		private UpdatableToggle _enableStreamerMode;

		// Token: 0x0400E8C8 RID: 59592
		[SerializeField]
		private UpdatableToggle _enableBlockInvites;

		// Token: 0x0400E8C9 RID: 59593
		[SerializeField]
		private UpdatableToggle _malfunctionVisability;

		// Token: 0x0400E8CA RID: 59594
		[SerializeField]
		private UpdatableToggle _traderIntermediateScreen;

		// Token: 0x0400E8CB RID: 59595
		[SerializeField]
		private SelectSlider _aimingDeadzone;

		// Token: 0x0400E8CC RID: 59596
		[SerializeField]
		private SelectSlider _fov;

		// Token: 0x0400E8CD RID: 59597
		[SerializeField]
		private SelectSlider _headbobbing;

		// Token: 0x0400E8CE RID: 59598
		[SerializeField]
		private UpdatableToggle _blood;

		// Token: 0x0400E8CF RID: 59599
		[SerializeField]
		private UpdatableToggle _badLanguage;

		// Token: 0x0400E8D0 RID: 59600
		[SerializeField]
		private DefaultUIButton _editInterfaceLayout;

		// Token: 0x0400E8D1 RID: 59601
		[SerializeField]
		private ValidationInputField _nicknameInput;

		// Token: 0x0400E8D2 RID: 59602
		[SerializeField]
		private DefaultUIButton _changeNicknameButton;

		// Token: 0x0400E8D3 RID: 59603
		[SerializeField]
		private GameObject _nicknameBlocker;

		// Token: 0x0400E8D4 RID: 59604
		[SerializeField]
		private SettingsTab.ElementBlocker _streamerModeBlocker;

		// Token: 0x0400E8D5 RID: 59605
		[SerializeField]
		private SettingsTab.ElementBlocker _subtitlesBlocker;

		// Token: 0x0400E8D6 RID: 59606
		[SerializeField]
		private SettingsTab.ElementBlocker _tutorialHintsBlocker;

		// Token: 0x0400E8D7 RID: 59607
		[SerializeField]
		private SettingsTab.ElementBlocker _bloodBlocker;

		// Token: 0x0400E8D8 RID: 59608
		private DateTime? nullable_0;

		// Token: 0x0400E8D9 RID: 59609
		private GClass956 gclass956_0;

		// Token: 0x0400E8DA RID: 59610
		private GClass947 gclass947_0;

		// Token: 0x0400E8DB RID: 59611
		private ISession ginterface145_0;

		// Token: 0x0400E8DC RID: 59612
		private Profile profile_0;

		// Token: 0x0400E8DD RID: 59613
		private string string_3;

		// Token: 0x02002D44 RID: 11588
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2780
		{
			// Token: 0x0600E3EA RID: 58346 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600E3EB RID: 58347 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_1(int x)
			{
				throw null;
			}

			// Token: 0x0600E3EC RID: 58348 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_2(float x)
			{
				throw null;
			}

			// Token: 0x0600E3ED RID: 58349 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_3(KeyValuePair<string, string> x)
			{
				throw null;
			}

			// Token: 0x0400E8DE RID: 59614
			public static readonly GameSettingsTab.Class2780 class2780_0;

			// Token: 0x0400E8DF RID: 59615
			public static UnityAction unityAction_0;

			// Token: 0x0400E8E0 RID: 59616
			public static Func<int, string> func_0;

			// Token: 0x0400E8E1 RID: 59617
			public static Func<float, string> func_1;

			// Token: 0x0400E8E2 RID: 59618
			public static Func<KeyValuePair<string, string>, string> func_2;
		}

		// Token: 0x02002D45 RID: 11589
		[CompilerGenerated]
		private sealed class Class2781
		{
			// Token: 0x0600E3EE RID: 58350 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(bool x)
			{
				throw null;
			}

			// Token: 0x0600E3EF RID: 58351 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(bool x)
			{
				throw null;
			}

			// Token: 0x0600E3F0 RID: 58352 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(int index)
			{
				throw null;
			}

			// Token: 0x0600E3F1 RID: 58353 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_3(string _)
			{
				throw null;
			}

			// Token: 0x0600E3F2 RID: 58354 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_4()
			{
				throw null;
			}

			// Token: 0x0600E3F3 RID: 58355 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_5(EnvironmentUI.EEnvironmentUIType x)
			{
				throw null;
			}

			// Token: 0x0600E3F4 RID: 58356 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Task method_6(EnvironmentUI.EEnvironmentUIType x)
			{
				throw null;
			}

			// Token: 0x0400E8E3 RID: 59619
			public GameSettingsTab gameSettingsTab_0;

			// Token: 0x0400E8E4 RID: 59620
			public IDictionary<string, string> languages;

			// Token: 0x02002D46 RID: 11590
			[StructLayout(LayoutKind.Auto)]
			public struct Struct958 : IAsyncStateMachine
			{
				// Token: 0x0600E3F5 RID: 58357 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IAsyncStateMachine.MoveNext()
				{
					throw null;
				}

				// Token: 0x0600E3F6 RID: 58358 RVA: 0x00002050 File Offset: 0x00000250
				[DebuggerHidden]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					throw null;
				}

				// Token: 0x0400E8E5 RID: 59621
				public int int_0;

				// Token: 0x0400E8E6 RID: 59622
				public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

				// Token: 0x0400E8E7 RID: 59623
				public GameSettingsTab.Class2781 class2781_0;

				// Token: 0x0400E8E8 RID: 59624
				public EnvironmentUI.EEnvironmentUIType x;

				// Token: 0x0400E8E9 RID: 59625
				private TaskAwaiter taskAwaiter_0;
			}
		}

		// Token: 0x02002D47 RID: 11591
		[CompilerGenerated]
		private sealed class Class2782
		{
			// Token: 0x0600E3F7 RID: 58359 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<string> method_0()
			{
				throw null;
			}

			// Token: 0x0400E8EA RID: 59626
			public IDictionary<string, string> languages;
		}
	}
}
