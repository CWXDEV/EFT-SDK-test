using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.Hideout;
using EFT.InputSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002AB7 RID: 10935
	public sealed class PreloaderUI : MonoBehaviourSingleton<PreloaderUI>
	{
		// Token: 0x1700265F RID: 9823
		// (get) Token: 0x0600D94E RID: 55630 RVA: 0x00002050 File Offset: 0x00000250
		public InputNode ErrorScreenInputNode
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002660 RID: 9824
		// (get) Token: 0x0600D94F RID: 55631 RVA: 0x00002050 File Offset: 0x00000250
		public BattleUIMalfunctionGlow MalfunctionGlow
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002661 RID: 9825
		// (get) Token: 0x0600D950 RID: 55632 RVA: 0x00002050 File Offset: 0x00000250
		public LoadingScreen LoadingScreen
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002662 RID: 9826
		// (get) Token: 0x0600D951 RID: 55633 RVA: 0x00002050 File Offset: 0x00000250
		public TMP_FPSCounter FPSCounter
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002663 RID: 9827
		// (set) Token: 0x0600D952 RID: 55634 RVA: 0x00002050 File Offset: 0x00000250
		public bool RaidInfoVisibility
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17002664 RID: 9828
		// (get) Token: 0x0600D953 RID: 55635 RVA: 0x00002050 File Offset: 0x00000250
		public bool CanShowErrorScreen
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600D954 RID: 55636 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Awake()
		{
			throw null;
		}

		// Token: 0x0600D955 RID: 55637 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600D956 RID: 55638 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitConsole(Profile profile)
		{
			throw null;
		}

		// Token: 0x0600D957 RID: 55639 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCanvasAsParent(GameObject @object)
		{
			throw null;
		}

		// Token: 0x0600D958 RID: 55640 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowRaidStartInfo(long raidNumber, DateTime registrationDate, GameDateTime locationTime, EPlayerSide side, string playerName, string location)
		{
			throw null;
		}

		// Token: 0x0600D959 RID: 55641 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartBlackScreenShow(float to, float step, Action callback)
		{
			throw null;
		}

		// Token: 0x0600D95A RID: 55642 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetMenuChatBarVisibility(bool visible)
		{
			throw null;
		}

		// Token: 0x0600D95B RID: 55643 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FadeBlackScreen(float pause, float step)
		{
			throw null;
		}

		// Token: 0x0600D95C RID: 55644 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBlackImageAlpha(float alpha)
		{
			throw null;
		}

		// Token: 0x0600D95D RID: 55645 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLoaderStatus(bool status)
		{
			throw null;
		}

		// Token: 0x0600D95E RID: 55646 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetStreamMode(bool status)
		{
			throw null;
		}

		// Token: 0x0600D95F RID: 55647 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MakeScreenshot()
		{
			throw null;
		}

		// Token: 0x0600D960 RID: 55648 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string method_0(string path)
		{
			throw null;
		}

		// Token: 0x0600D961 RID: 55649 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowErrorScreen(string header, Exception exception, Action acceptCallback = null)
		{
			throw null;
		}

		// Token: 0x0600D962 RID: 55650 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowErrorScreen(string header, string message, Action acceptCallback = null)
		{
			throw null;
		}

		// Token: 0x0600D963 RID: 55651 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GClass3085 ShowCriticalErrorScreen(string header, string message, ErrorScreen.EButtonType buttonType, float waitingTime, Action acceptCallback, Action endTimeCallback)
		{
			throw null;
		}

		// Token: 0x0600D964 RID: 55652 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseErrorScreen()
		{
			throw null;
		}

		// Token: 0x0600D965 RID: 55653 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearErrorQueue()
		{
			throw null;
		}

		// Token: 0x0600D966 RID: 55654 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_1()
		{
			throw null;
		}

		// Token: 0x0600D967 RID: 55655 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600D968 RID: 55656 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600D969 RID: 55657 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnApplicationFocus(bool hasFocus)
		{
			throw null;
		}

		// Token: 0x0600D96A RID: 55658 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_4(float to, float step, Action callback = null)
		{
			throw null;
		}

		// Token: 0x0600D96B RID: 55659 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSessionId(string id)
		{
			throw null;
		}

		// Token: 0x0600D96C RID: 55660 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCommitsNotMatchText(string commitsNotMatchText)
		{
			throw null;
		}

		// Token: 0x0600D96D RID: 55661 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600D96E RID: 55662 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetWatermarkStatus(Profile profile, bool watermarkEnabled)
		{
			throw null;
		}

		// Token: 0x0600D96F RID: 55663 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(Profile profile)
		{
			throw null;
		}

		// Token: 0x0600D970 RID: 55664 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StopClientWatermark()
		{
			throw null;
		}

		// Token: 0x0600D971 RID: 55665 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600D972 RID: 55666 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetNetworkViewSettings(GClass1300.GClass1303 clientSettingsNetworkStateView)
		{
			throw null;
		}

		// Token: 0x0400DC2C RID: 56364
		private const float float_0 = 2f;

		// Token: 0x0400DC2D RID: 56365
		private const float float_1 = 2f;

		// Token: 0x0400DC2E RID: 56366
		private const string string_0 = ".png";

		// Token: 0x0400DC2F RID: 56367
		private static readonly string string_1;

		// Token: 0x0400DC30 RID: 56368
		[SerializeField]
		private LocalizedText _alphaVersionLabel;

		// Token: 0x0400DC31 RID: 56369
		[SerializeField]
		private RectTransform _childrenContainer;

		// Token: 0x0400DC32 RID: 56370
		[SerializeField]
		private Image _overlapBlackImage;

		// Token: 0x0400DC33 RID: 56371
		[SerializeField]
		private RaidStartIntro _raidStartIntro;

		// Token: 0x0400DC34 RID: 56372
		[SerializeField]
		private TMP_FPSCounter _fpsCounter;

		// Token: 0x0400DC35 RID: 56373
		[SerializeField]
		private LoadingScreen _loadingScreen;

		// Token: 0x0400DC36 RID: 56374
		[SerializeField]
		private GameObject _rttObject;

		// Token: 0x0400DC37 RID: 56375
		[SerializeField]
		private TextMeshProUGUI _rttLabel;

		// Token: 0x0400DC38 RID: 56376
		[SerializeField]
		private GameObject _lossObject;

		// Token: 0x0400DC39 RID: 56377
		[SerializeField]
		private TextMeshProUGUI _lossLabel;

		// Token: 0x0400DC3A RID: 56378
		[SerializeField]
		private GameObject _loader;

		// Token: 0x0400DC3B RID: 56379
		[SerializeField]
		private ItemUiContext _UIContext;

		// Token: 0x0400DC3C RID: 56380
		[SerializeField]
		private GameObject _bottomPanelBackground;

		// Token: 0x0400DC3D RID: 56381
		[SerializeField]
		private ErrorScreen ErrorScreen;

		// Token: 0x0400DC3E RID: 56382
		[SerializeField]
		private ErrorScreen _criticalErrorScreenTemplate;

		// Token: 0x0400DC3F RID: 56383
		[SerializeField]
		private EmptyInputNode _criticalErrorScreenContainer;

		// Token: 0x0400DC40 RID: 56384
		[SerializeField]
		private BattleUIMalfunctionGlow _malfunctionGlow;

		// Token: 0x0400DC41 RID: 56385
		public Dictionary<KeyCode, string> Binds;

		// Token: 0x0400DC42 RID: 56386
		public ClientWatermark ClientWatermark;

		// Token: 0x0400DC43 RID: 56387
		public ConsoleScreen Console;

		// Token: 0x0400DC44 RID: 56388
		public UnknownErrorScreen UnknownErrorScreen;

		// Token: 0x0400DC45 RID: 56389
		public NotifierView NotifierView;

		// Token: 0x0400DC46 RID: 56390
		public MenuTaskBar MenuTaskBar;

		// Token: 0x0400DC47 RID: 56391
		private Coroutine coroutine_0;

		// Token: 0x0400DC48 RID: 56392
		private double double_0;

		// Token: 0x0400DC49 RID: 56393
		private double double_1;

		// Token: 0x0400DC4A RID: 56394
		private float float_2;

		// Token: 0x0400DC4B RID: 56395
		private float float_3;

		// Token: 0x0400DC4C RID: 56396
		private string string_2;

		// Token: 0x0400DC4D RID: 56397
		private string string_3;

		// Token: 0x0400DC4E RID: 56398
		private string string_4;

		// Token: 0x0400DC4F RID: 56399
		private bool bool_0;

		// Token: 0x0400DC50 RID: 56400
		private double double_2;

		// Token: 0x0400DC51 RID: 56401
		private int int_0;

		// Token: 0x0400DC52 RID: 56402
		private List<GClass3009> list_0;

		// Token: 0x0400DC53 RID: 56403
		private string string_5;

		// Token: 0x0400DC54 RID: 56404
		private int int_1;

		// Token: 0x02002AB8 RID: 10936
		[CompilerGenerated]
		private sealed class Class2560
		{
			// Token: 0x0600D973 RID: 55667 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600D974 RID: 55668 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x0400DC55 RID: 56405
			public PreloaderUI preloaderUI_0;

			// Token: 0x0400DC56 RID: 56406
			public float step;

			// Token: 0x0400DC57 RID: 56407
			public Action action_0;
		}

		// Token: 0x02002AB9 RID: 10937
		[CompilerGenerated]
		private sealed class Class2561
		{
			// Token: 0x0600D975 RID: 55669 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Action callback)
			{
				throw null;
			}

			// Token: 0x0600D976 RID: 55670 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x0600D977 RID: 55671 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2()
			{
				throw null;
			}

			// Token: 0x0400DC58 RID: 56408
			public ErrorScreen errorScreen;

			// Token: 0x0400DC59 RID: 56409
			public PreloaderUI preloaderUI_0;

			// Token: 0x0400DC5A RID: 56410
			public Action acceptCallback;

			// Token: 0x0400DC5B RID: 56411
			public Action endTimeCallback;
		}
	}
}
