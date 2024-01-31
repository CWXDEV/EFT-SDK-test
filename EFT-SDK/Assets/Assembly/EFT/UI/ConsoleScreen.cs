using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.Console.Core;
using EFT.InputSystem;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002893 RID: 10387
	public sealed class ConsoleScreen : UIInputNode
	{
		// Token: 0x0600CF4C RID: 53068 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600CF4D RID: 53069 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ApplyStartCommands()
		{
			throw null;
		}

		// Token: 0x0600CF4E RID: 53070 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SwitchDebugLogEnabled()
		{
			throw null;
		}

		// Token: 0x0600CF4F RID: 53071 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SwitchStackTraceEnabled()
		{
			throw null;
		}

		// Token: 0x1700250F RID: 9487
		// (get) Token: 0x0600CF50 RID: 53072 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsConsoleVisible
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002510 RID: 9488
		// (get) Token: 0x0600CF51 RID: 53073 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CF52 RID: 53074 RVA: 0x00002050 File Offset: 0x00000250
		public static bool WarningVisibility
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17002511 RID: 9489
		// (get) Token: 0x0600CF53 RID: 53075 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CF54 RID: 53076 RVA: 0x00002050 File Offset: 0x00000250
		public static bool ErrorsVisibility
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17002512 RID: 9490
		// (get) Token: 0x0600CF55 RID: 53077 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CF56 RID: 53078 RVA: 0x00002050 File Offset: 0x00000250
		public static bool LogsVisibility
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17002513 RID: 9491
		// (get) Token: 0x0600CF57 RID: 53079 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CF58 RID: 53080 RVA: 0x00002050 File Offset: 0x00000250
		private int Int32_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17002514 RID: 9492
		// (get) Token: 0x0600CF59 RID: 53081 RVA: 0x00002050 File Offset: 0x00000250
		private static Player Player_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CF5A RID: 53082 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600CF5B RID: 53083 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnProfileReceive(Profile profile)
		{
			throw null;
		}

		// Token: 0x0600CF5C RID: 53084 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitConsole()
		{
			throw null;
		}

		// Token: 0x0600CF5D RID: 53085 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Log(string statement)
		{
			throw null;
		}

		// Token: 0x0600CF5E RID: 53086 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void LogWarning(string statement)
		{
			throw null;
		}

		// Token: 0x0600CF5F RID: 53087 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void LogFormat(string statement, params object[] args)
		{
			throw null;
		}

		// Token: 0x0600CF60 RID: 53088 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void LogError(string statement)
		{
			throw null;
		}

		// Token: 0x0600CF61 RID: 53089 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void LogException(Exception exception)
		{
			throw null;
		}

		// Token: 0x0600CF62 RID: 53090 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(bool isActive)
		{
			throw null;
		}

		// Token: 0x0600CF63 RID: 53091 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		// Token: 0x0600CF64 RID: 53092 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(float value)
		{
			throw null;
		}

		// Token: 0x0600CF65 RID: 53093 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show()
		{
			throw null;
		}

		// Token: 0x0600CF66 RID: 53094 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600CF67 RID: 53095 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(string condition, string stacktrace, LogType type)
		{
			throw null;
		}

		// Token: 0x0600CF68 RID: 53096 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(string condition, string stacktrace, LogType type)
		{
			throw null;
		}

		// Token: 0x0600CF69 RID: 53097 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PullUpConsole()
		{
			throw null;
		}

		// Token: 0x0600CF6A RID: 53098 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string smethod_0(string color)
		{
			throw null;
		}

		// Token: 0x0600CF6B RID: 53099 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(string log, string statement)
		{
			throw null;
		}

		// Token: 0x0600CF6C RID: 53100 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x0600CF6D RID: 53101 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TryCommand(IConsoleCommand input)
		{
			throw null;
		}

		// Token: 0x0600CF6E RID: 53102 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TryCommand(string input)
		{
			throw null;
		}

		// Token: 0x0600CF6F RID: 53103 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600CF70 RID: 53104 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x0600CF71 RID: 53105 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_8(string input)
		{
			throw null;
		}

		// Token: 0x0600CF72 RID: 53106 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x0600CF73 RID: 53107 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LateUpdate()
		{
			throw null;
		}

		// Token: 0x0600CF74 RID: 53108 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10()
		{
			throw null;
		}

		// Token: 0x0600CF75 RID: 53109 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11()
		{
			throw null;
		}

		// Token: 0x0600CF76 RID: 53110 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12(string input)
		{
			throw null;
		}

		// Token: 0x0600CF77 RID: 53111 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13()
		{
			throw null;
		}

		// Token: 0x0600CF78 RID: 53112 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_14(AutoCompleteItem item)
		{
			throw null;
		}

		// Token: 0x0600CF79 RID: 53113 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600CF7A RID: 53114 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void TranslateAxes(ref float[] axes)
		{
			throw null;
		}

		// Token: 0x0600CF7B RID: 53115 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override ECursorResult ShouldLockCursor()
		{
			throw null;
		}

		// Token: 0x0600CF7C RID: 53116 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_15(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600CF7D RID: 53117 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_16()
		{
			throw null;
		}

		// Token: 0x0600CF7E RID: 53118 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x0600CF7F RID: 53119 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600CF80 RID: 53120 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_17(string txt)
		{
			throw null;
		}

		// Token: 0x0600CF81 RID: 53121 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_18()
		{
			throw null;
		}

		// Token: 0x0600CF82 RID: 53122 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_19(bool isEnabled)
		{
			throw null;
		}

		// Token: 0x0600CF83 RID: 53123 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_20()
		{
			throw null;
		}

		// Token: 0x0400D03C RID: 53308
		public const string CONSOLE_START_COMMANDS_SAVE_KEY = "ConsoleStartCommands";

		// Token: 0x0400D03D RID: 53309
		[SerializeField]
		private Slider _consoleSlider;

		// Token: 0x0400D03E RID: 53310
		[SerializeField]
		private TMP_InputField _enterCommandField;

		// Token: 0x0400D03F RID: 53311
		[SerializeField]
		private TextMeshProUGUI _timePanel;

		// Token: 0x0400D040 RID: 53312
		[SerializeField]
		private TMP_InputFieldNoScroll _logsPanel;

		// Token: 0x0400D041 RID: 53313
		[SerializeField]
		private ConsoleAutoCompletePanel _consoleAutoCompletePanel;

		// Token: 0x0400D042 RID: 53314
		public static readonly ConsoleProcessor Processor;

		// Token: 0x0400D043 RID: 53315
		[CompilerGenerated]
		private static bool bool_0;

		// Token: 0x0400D044 RID: 53316
		[CompilerGenerated]
		private static bool bool_1;

		// Token: 0x0400D045 RID: 53317
		[CompilerGenerated]
		private static bool bool_2;

		// Token: 0x0400D046 RID: 53318
		private readonly LinkedList<string> linkedList_0;

		// Token: 0x0400D047 RID: 53319
		private readonly LinkedList<string> linkedList_1;

		// Token: 0x0400D048 RID: 53320
		private Dictionary<string, string> dictionary_0;

		// Token: 0x0400D049 RID: 53321
		private int int_0;

		// Token: 0x0400D04A RID: 53322
		private bool bool_3;

		// Token: 0x0400D04B RID: 53323
		private string string_0;

		// Token: 0x0400D04C RID: 53324
		private bool bool_4;

		// Token: 0x0400D04D RID: 53325
		private const int int_1 = 60;

		// Token: 0x0400D04E RID: 53326
		private int int_2;

		// Token: 0x0400D04F RID: 53327
		private EMemberCategory ememberCategory_0;

		// Token: 0x0400D050 RID: 53328
		private readonly List<string> list_0;

		// Token: 0x0400D051 RID: 53329
		private Coroutine coroutine_0;

		// Token: 0x0400D052 RID: 53330
		private bool bool_5;

		// Token: 0x0400D053 RID: 53331
		private bool bool_6;

		// Token: 0x02002894 RID: 10388
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2354
		{
			// Token: 0x0600CF84 RID: 53124 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0(string current, string item)
			{
				throw null;
			}

			// Token: 0x0400D054 RID: 53332
			public static readonly ConsoleScreen.Class2354 class2354_0;

			// Token: 0x0400D055 RID: 53333
			public static Func<string, string, string> func_0;
		}
	}
}
