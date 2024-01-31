using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Comfort.Common;
using EFT.Hideout;
using EFT.InputSystem;
using EFT.UI;
using EFT.UI.Matchmaker;
using UnityEngine;

namespace EFT
{
	// Token: 0x020016E2 RID: 5858
	public sealed class TarkovApplication : CommonClientApplication<ISession>, GInterface185
	{
		// Token: 0x170013CA RID: 5066
		// (get) Token: 0x06007E4E RID: 32334 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007E4F RID: 32335 RVA: 0x00002050 File Offset: 0x00000250
		public int CurrentRaidNum
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170013CB RID: 5067
		// (get) Token: 0x06007E50 RID: 32336 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007E51 RID: 32337 RVA: 0x00002050 File Offset: 0x00000250
		public int CurrentTotalRaidNum
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170013CC RID: 5068
		// (get) Token: 0x06007E52 RID: 32338 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007E53 RID: 32339 RVA: 0x00002050 File Offset: 0x00000250
		public TarkovApplication.GClass1813 HideoutControllerAccess
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1400017D RID: 381
		// (add) Token: 0x06007E54 RID: 32340 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06007E55 RID: 32341 RVA: 0x00002050 File Offset: 0x00000250
		public event Action AfterApplicationLoaded
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

		// Token: 0x06007E56 RID: 32342 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override bool ConfigureApplication()
		{
			throw null;
		}

		// Token: 0x06007E57 RID: 32343 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Task Start()
		{
			throw null;
		}

		// Token: 0x06007E58 RID: 32344 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Update()
		{
			throw null;
		}

		// Token: 0x06007E59 RID: 32345 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void LateUpdate()
		{
			throw null;
		}

		// Token: 0x06007E5A RID: 32346 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void DestroyApplication()
		{
			throw null;
		}

		// Token: 0x06007E5B RID: 32347 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Task LoadLoginScenes()
		{
			throw null;
		}

		// Token: 0x06007E5C RID: 32348 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Task BundleCheck(string bundlePath)
		{
			throw null;
		}

		// Token: 0x06007E5D RID: 32349 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task InternalStartGame(string gameMap, bool isLocalGame, bool isBotEnabled)
		{
			throw null;
		}

		// Token: 0x06007E5E RID: 32350 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(bool on)
		{
			throw null;
		}

		// Token: 0x06007E5F RID: 32351 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_5()
		{
			throw null;
		}

		// Token: 0x06007E60 RID: 32352 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Init(IAssetsManager assetsManager, InputTree inputTree)
		{
			throw null;
		}

		// Token: 0x06007E61 RID: 32353 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override Task CreateBackend()
		{
			throw null;
		}

		// Token: 0x06007E62 RID: 32354 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IBackendInterface<ISession> method_6(bool developMode, string sessionId)
		{
			throw null;
		}

		// Token: 0x06007E63 RID: 32355 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_7()
		{
			throw null;
		}

		// Token: 0x06007E64 RID: 32356 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_8()
		{
			throw null;
		}

		// Token: 0x06007E65 RID: 32357 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_9()
		{
			throw null;
		}

		// Token: 0x06007E66 RID: 32358 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10(GException1 ex, string debilniiOverride = null)
		{
			throw null;
		}

		// Token: 0x06007E67 RID: 32359 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_11()
		{
			throw null;
		}

		// Token: 0x06007E68 RID: 32360 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_12(Task unloadHideoutTask)
		{
			throw null;
		}

		// Token: 0x06007E69 RID: 32361 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13()
		{
			throw null;
		}

		// Token: 0x06007E6A RID: 32362 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_14()
		{
			throw null;
		}

		// Token: 0x06007E6B RID: 32363 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_15()
		{
			throw null;
		}

		// Token: 0x06007E6C RID: 32364 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_16()
		{
			throw null;
		}

		// Token: 0x06007E6D RID: 32365 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_17()
		{
			throw null;
		}

		// Token: 0x06007E6E RID: 32366 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_18(NotificationClass notification)
		{
			throw null;
		}

		// Token: 0x06007E6F RID: 32367 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_19()
		{
			throw null;
		}

		// Token: 0x06007E70 RID: 32368 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_20()
		{
			throw null;
		}

		// Token: 0x06007E71 RID: 32369 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_21()
		{
			throw null;
		}

		// Token: 0x06007E72 RID: 32370 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_22()
		{
			throw null;
		}

		// Token: 0x06007E73 RID: 32371 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_23()
		{
			throw null;
		}

		// Token: 0x06007E74 RID: 32372 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_24(out bool isPet, bool isMatching = false)
		{
			throw null;
		}

		// Token: 0x06007E75 RID: 32373 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_25(bool isMatching = false)
		{
			throw null;
		}

		// Token: 0x06007E76 RID: 32374 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_26()
		{
			throw null;
		}

		// Token: 0x06007E77 RID: 32375 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_27(Profile profile, ProfileStatusClass profileStatus, bool isPet, Profile savageProfile)
		{
			throw null;
		}

		// Token: 0x06007E78 RID: 32376 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_28(string profileId, bool isPet, Profile savageProfile)
		{
			throw null;
		}

		// Token: 0x06007E79 RID: 32377 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private MatchmakerTimeHasCome.GClass3163 method_29(bool isPet, CancellationTokenSource cancellationToken)
		{
			throw null;
		}

		// Token: 0x06007E7A RID: 32378 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_30(Action reconnectAction = null)
		{
			throw null;
		}

		// Token: 0x06007E7B RID: 32379 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_31()
		{
			throw null;
		}

		// Token: 0x06007E7C RID: 32380 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_32(string matchingName, Exception e)
		{
			throw null;
		}

		// Token: 0x06007E7D RID: 32381 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_33(IResult result, Action callback)
		{
			throw null;
		}

		// Token: 0x06007E7E RID: 32382 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_34(TimeAndWeatherSettings timeAndWeather)
		{
			throw null;
		}

		// Token: 0x06007E7F RID: 32383 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_35(string groupId, EMatchingType type)
		{
			throw null;
		}

		// Token: 0x06007E80 RID: 32384 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_36(GStruct229 scenePreset, CancellationTokenSource cancellationTokenSource, GClass2136 metricsEvents, MatchmakerTimeHasCome.GClass3163 screenController)
		{
			throw null;
		}

		// Token: 0x06007E81 RID: 32385 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_37(GStruct229 scenePreset, CancellationToken cancellationToken, MatchmakerTimeHasCome.GClass3163 screenController)
		{
			throw null;
		}

		// Token: 0x06007E82 RID: 32386 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_38()
		{
			throw null;
		}

		// Token: 0x06007E83 RID: 32387 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<IResult> method_39(MatchmakerTimeHasCome.GClass3163 timeHasComeScreenController, bool isRaid = true)
		{
			throw null;
		}

		// Token: 0x06007E84 RID: 32388 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_40(string profileId, Profile savageProfile, LocationSettingsClass.Location location, GClass2136 metricsEvents, MatchmakerTimeHasCome.GClass3163 timeHasComeScreenController)
		{
			throw null;
		}

		// Token: 0x06007E85 RID: 32389 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_41(string profileId, Profile savageProfile, GClass2136 metricsEvents, MatchmakerTimeHasCome.GClass3163 timeHasComeScreenController)
		{
			throw null;
		}

		// Token: 0x06007E86 RID: 32390 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_42(ProfileStatusClass profileStatus, Profile savageProfile, GClass2136 metricsEvents, MetricsConfigClass metricsConfig, MatchmakerTimeHasCome.GClass3163 timeHasComeScreenController)
		{
			throw null;
		}

		// Token: 0x06007E87 RID: 32391 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_43(TimeAndWeatherSettings timeAndWeather, MatchmakerTimeHasCome.GClass3163 timeHasComeScreenController)
		{
			throw null;
		}

		// Token: 0x06007E88 RID: 32392 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private TimeSpan method_44(int defaultMinutes)
		{
			throw null;
		}

		// Token: 0x06007E89 RID: 32393 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_45()
		{
			throw null;
		}

		// Token: 0x06007E8A RID: 32394 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_46(string profileId, Profile savageProfile, LocationSettingsClass.Location location, Result<ExitStatus, TimeSpan, MetricsClass> result, MatchmakerTimeHasCome.GClass3163 timeHasComeScreenController = null)
		{
			throw null;
		}

		// Token: 0x06007E8B RID: 32395 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_47(string profileId, Profile savageProfile, LocationSettingsClass.Location location, ExitStatus exitStatus, TimeSpan exitTime, MetricsClass clientMetrics = null)
		{
			throw null;
		}

		// Token: 0x06007E8C RID: 32396 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_48()
		{
			throw null;
		}

		// Token: 0x06007E8D RID: 32397 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_49()
		{
			throw null;
		}

		// Token: 0x06007E8E RID: 32398 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnApplicationQuit()
		{
			throw null;
		}

		// Token: 0x06007E8F RID: 32399 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_50()
		{
			throw null;
		}

		// Token: 0x06007E90 RID: 32400 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[DebuggerHidden]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_51()
		{
			throw null;
		}

		// Token: 0x06007E91 RID: 32401 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_52(EMenuType menuType, bool isOn)
		{
			throw null;
		}

		// Token: 0x06007E92 RID: 32402 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_53(string operationName, string error)
		{
			throw null;
		}

		// Token: 0x06007E93 RID: 32403 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_54()
		{
			throw null;
		}

		// Token: 0x06007E94 RID: 32404 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_55()
		{
			throw null;
		}

		// Token: 0x06007E95 RID: 32405 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_56()
		{
			throw null;
		}

		// Token: 0x06007E96 RID: 32406 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_57()
		{
			throw null;
		}

		// Token: 0x06007E97 RID: 32407 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_58()
		{
			throw null;
		}

		// Token: 0x06007E98 RID: 32408 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_59()
		{
			throw null;
		}

		// Token: 0x06007E99 RID: 32409 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_60()
		{
			throw null;
		}

		// Token: 0x0400853F RID: 34111
		[SerializeField]
		private SplashScreenPanel _splashScreenPanel;

		// Token: 0x04008540 RID: 34112
		[SerializeField]
		private Camera _temporaryCamera;

		// Token: 0x04008541 RID: 34113
		[HideInInspector]
		[SerializeField]
		private GameDateTime _localGameDateTime;

		// Token: 0x04008542 RID: 34114
		[Header("Locations debug settings")]
		public bool UnlockAndShowAllLocations;

		// Token: 0x04008543 RID: 34115
		[SerializeField]
		private bool _customRaidSettings;

		// Token: 0x04008544 RID: 34116
		[SerializeField]
		private RaidSettings _raidSettings;

		// Token: 0x04008545 RID: 34117
		public FastGameInfo FastGameInfo_EXPERIMENTAL;

		// Token: 0x04008546 RID: 34118
		private HideoutClass gclass1904_0;

		// Token: 0x04008547 RID: 34119
		private UIInputRoot uiinputRoot_0;

		// Token: 0x04008548 RID: 34120
		private MainMenuController gclass1819_0;

		// Token: 0x04008549 RID: 34121
		private string string_0;

		// Token: 0x0400854A RID: 34122
		private bool bool_3;

		// Token: 0x0400854B RID: 34123
		private Task task_0;

		// Token: 0x0400854C RID: 34124
		[CompilerGenerated]
		private int int_0;

		// Token: 0x0400854D RID: 34125
		[CompilerGenerated]
		private int int_1;

		// Token: 0x0400854E RID: 34126
		[CompilerGenerated]
		private TarkovApplication.GClass1813 gclass1813_0;

		// Token: 0x0400854F RID: 34127
		[CompilerGenerated]
		private Action action_0;

		// Token: 0x04008550 RID: 34128
		private static readonly WaitForSeconds waitForSeconds_0;

		// Token: 0x04008551 RID: 34129
		private Coroutine coroutine_0;

		// Token: 0x020016E3 RID: 5859
		public sealed class GClass1813
		{
			// Token: 0x170013CD RID: 5069
			// (get) Token: 0x06007E9A RID: 32410 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06007E9B RID: 32411 RVA: 0x00002050 File Offset: 0x00000250
			public bool IsHideoutActive
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				private set
				{
					throw null;
				}
			}

			// Token: 0x06007E9C RID: 32412 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Task HideoutSelectedHandler(EAreaType? areaType = null)
			{
				throw null;
			}

			// Token: 0x06007E9D RID: 32413 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Task method_0()
			{
				throw null;
			}

			// Token: 0x06007E9E RID: 32414 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void StartLoadHideoutMap()
			{
				throw null;
			}

			// Token: 0x06007E9F RID: 32415 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Task method_1()
			{
				throw null;
			}

			// Token: 0x06007EA0 RID: 32416 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Task method_2()
			{
				throw null;
			}

			// Token: 0x06007EA1 RID: 32417 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Task method_3()
			{
				throw null;
			}

			// Token: 0x06007EA2 RID: 32418 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Task method_4()
			{
				throw null;
			}

			// Token: 0x06007EA3 RID: 32419 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void StartLoadHideoutBundles()
			{
				throw null;
			}

			// Token: 0x06007EA4 RID: 32420 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Task method_5(GDelegate77 yield)
			{
				throw null;
			}

			// Token: 0x06007EA5 RID: 32421 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_6()
			{
				throw null;
			}

			// Token: 0x06007EA6 RID: 32422 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Task method_7(LocationSettingsClass.Location location, TimeAndWeatherSettings timeAndWeather)
			{
				throw null;
			}

			// Token: 0x06007EA7 RID: 32423 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_8()
			{
				throw null;
			}

			// Token: 0x06007EA8 RID: 32424 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Task UnloadHideout()
			{
				throw null;
			}

			// Token: 0x06007EA9 RID: 32425 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_9()
			{
				throw null;
			}

			// Token: 0x06007EAA RID: 32426 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void HideHideout()
			{
				throw null;
			}

			// Token: 0x04008552 RID: 34130
			private TarkovApplication tarkovApplication_0;

			// Token: 0x04008553 RID: 34131
			private LocationSettingsClass.Location location_0;

			// Token: 0x04008554 RID: 34132
			private Task task_0;

			// Token: 0x04008555 RID: 34133
			private Task task_1;

			// Token: 0x04008556 RID: 34134
			private GClass1802.GClass1803 gclass1803_0;

			// Token: 0x04008557 RID: 34135
			private bool bool_0;

			// Token: 0x04008558 RID: 34136
			private DependencyGraph<IEasyBundle>.GClass3388 gclass3388_0;

			// Token: 0x04008559 RID: 34137
			private HideoutScreenRear.GClass3157 gclass3157_0;

			// Token: 0x0400855A RID: 34138
			private Profile profile_0;

			// Token: 0x0400855B RID: 34139
			private HideoutGame hideoutGame_0;

			// Token: 0x0400855C RID: 34140
			[CompilerGenerated]
			private bool bool_1;

			// Token: 0x020016E5 RID: 5861
			[CompilerGenerated]
			[Serializable]
			private sealed class Class1214
			{
				// Token: 0x06007EAD RID: 32429 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool method_0(KeyValuePair<string, LocationSettingsClass.Location> x)
				{
					throw null;
				}

				// Token: 0x06007EAE RID: 32430 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal string method_1(GClass1920 _)
				{
					throw null;
				}

				// Token: 0x06007EAF RID: 32431 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool method_2(string id)
				{
					throw null;
				}

				// Token: 0x06007EB0 RID: 32432 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal ResourceKey method_3(string x)
				{
					throw null;
				}

				// Token: 0x06007EB1 RID: 32433 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal bool method_4(AreaData x)
				{
					throw null;
				}

				// Token: 0x04008562 RID: 34146
				public static readonly TarkovApplication.GClass1813.Class1214 class1214_0;

				// Token: 0x04008563 RID: 34147
				public static Func<KeyValuePair<string, LocationSettingsClass.Location>, bool> func_0;

				// Token: 0x04008564 RID: 34148
				public static Func<GClass1920, string> func_1;

				// Token: 0x04008565 RID: 34149
				public static Func<string, bool> func_2;

				// Token: 0x04008566 RID: 34150
				public static Func<string, ResourceKey> func_3;

				// Token: 0x04008567 RID: 34151
				public static Func<AreaData, bool> func_4;
			}

			// Token: 0x020016EA RID: 5866
			[CompilerGenerated]
			private sealed class Class1215
			{
				// Token: 0x06007EBA RID: 32442 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal string method_0(string id)
				{
					throw null;
				}

				// Token: 0x06007EBB RID: 32443 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_1()
				{
					throw null;
				}

				// Token: 0x04008581 RID: 34177
				public ItemFactory itemFactory;

				// Token: 0x04008582 RID: 34178
				public TaskCompletionSource<bool> source;
			}

			// Token: 0x020016EC RID: 5868
			[CompilerGenerated]
			private sealed class Class1216
			{
				// Token: 0x06007EBE RID: 32446 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0(IResult error)
				{
					throw null;
				}

				// Token: 0x04008589 RID: 34185
				public TarkovApplication.GClass1813 gclass1813_0;

				// Token: 0x0400858A RID: 34186
				public LocationSettingsClass.Location location;

				// Token: 0x0400858B RID: 34187
				public TaskCompletionSource taskSource;
			}

			// Token: 0x020016ED RID: 5869
			[CompilerGenerated]
			private sealed class Class1217
			{
				// Token: 0x06007EBF RID: 32447 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				internal void method_0(Result<ExitStatus, TimeSpan, MetricsClass> result)
				{
					throw null;
				}

				// Token: 0x0400858C RID: 34188
				public Profile savageProfile;

				// Token: 0x0400858D RID: 34189
				public TarkovApplication.GClass1813.Class1216 class1216_0;
			}
		}

		// Token: 0x020016F2 RID: 5874
		[CompilerGenerated]
		private sealed class Class1218
		{
			// Token: 0x06007EC8 RID: 32456 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(LocationSettingsClass.Location v)
			{
				throw null;
			}

			// Token: 0x040085A3 RID: 34211
			public string gameMap;
		}

		// Token: 0x020016F4 RID: 5876
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1219
		{
			// Token: 0x06007ECB RID: 32459 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x06007ECC RID: 32460 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x06007ECD RID: 32461 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2()
			{
				throw null;
			}

			// Token: 0x06007ECE RID: 32462 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_3()
			{
				throw null;
			}

			// Token: 0x06007ECF RID: 32463 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Task method_4(string x)
			{
				throw null;
			}

			// Token: 0x040085AB RID: 34219
			public static readonly TarkovApplication.Class1219 class1219_0;

			// Token: 0x040085AC RID: 34220
			public static Action action_0;

			// Token: 0x040085AD RID: 34221
			public static Action action_1;

			// Token: 0x040085AE RID: 34222
			public static Action action_2;

			// Token: 0x040085AF RID: 34223
			public static Func<string, Task> func_0;
		}

		// Token: 0x02001703 RID: 5891
		[CompilerGenerated]
		private sealed class Class1220
		{
			// Token: 0x0400860C RID: 34316
			public bool isLeaving;

			// Token: 0x0400860D RID: 34317
			public TarkovApplication tarkovApplication_0;

			// Token: 0x0400860E RID: 34318
			public bool isPet;

			// Token: 0x0400860F RID: 34319
			public bool isMatching;
		}

		// Token: 0x02001704 RID: 5892
		[CompilerGenerated]
		private sealed class Class1221
		{
			// Token: 0x06007EEC RID: 32492 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Result<ProfileStatusClass[]> _)
			{
				throw null;
			}

			// Token: 0x04008610 RID: 34320
			public bool refreshed;

			// Token: 0x04008611 RID: 34321
			public TarkovApplication.Class1220 class1220_0;
		}

		// Token: 0x02001706 RID: 5894
		[CompilerGenerated]
		private sealed class Class1222
		{
			// Token: 0x06007EEF RID: 32495 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(LocationSettingsClass.Location loc)
			{
				throw null;
			}

			// Token: 0x06007EF0 RID: 32496 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x06007EF1 RID: 32497 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2()
			{
				throw null;
			}

			// Token: 0x06007EF2 RID: 32498 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_3()
			{
				throw null;
			}

			// Token: 0x06007EF3 RID: 32499 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_4()
			{
				throw null;
			}

			// Token: 0x0400861B RID: 34331
			public ProfileStatusClass profileStatus;

			// Token: 0x0400861C RID: 34332
			public TarkovApplication tarkovApplication_0;

			// Token: 0x0400861D RID: 34333
			public bool isPet;

			// Token: 0x0400861E RID: 34334
			public Profile savageProfile;

			// Token: 0x0400861F RID: 34335
			public Action action_0;

			// Token: 0x02001707 RID: 5895
			[StructLayout(LayoutKind.Auto)]
			public struct Struct289 : IAsyncStateMachine
			{
				// Token: 0x06007EF4 RID: 32500 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IAsyncStateMachine.MoveNext()
				{
					throw null;
				}

				// Token: 0x06007EF5 RID: 32501 RVA: 0x00002050 File Offset: 0x00000250
				[DebuggerHidden]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					throw null;
				}

				// Token: 0x04008620 RID: 34336
				public int int_0;

				// Token: 0x04008621 RID: 34337
				public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

				// Token: 0x04008622 RID: 34338
				public TarkovApplication.Class1222 class1222_0;

				// Token: 0x04008623 RID: 34339
				private TaskAwaiter taskAwaiter_0;
			}

			// Token: 0x02001708 RID: 5896
			[StructLayout(LayoutKind.Auto)]
			public struct Struct290 : IAsyncStateMachine
			{
				// Token: 0x06007EF6 RID: 32502 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IAsyncStateMachine.MoveNext()
				{
					throw null;
				}

				// Token: 0x06007EF7 RID: 32503 RVA: 0x00002050 File Offset: 0x00000250
				[DebuggerHidden]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					throw null;
				}

				// Token: 0x04008624 RID: 34340
				public int int_0;

				// Token: 0x04008625 RID: 34341
				public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

				// Token: 0x04008626 RID: 34342
				public TarkovApplication.Class1222 class1222_0;

				// Token: 0x04008627 RID: 34343
				private TaskAwaiter taskAwaiter_0;
			}
		}

		// Token: 0x02001709 RID: 5897
		[CompilerGenerated]
		private sealed class Class1223
		{
			// Token: 0x06007EF8 RID: 32504 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04008628 RID: 34344
			public ReconnectionScreen.GClass3129 reconnectionScreenController;

			// Token: 0x04008629 RID: 34345
			public TarkovApplication.Class1222 class1222_0;
		}

		// Token: 0x0200170A RID: 5898
		[CompilerGenerated]
		private sealed class Class1224
		{
			// Token: 0x06007EF9 RID: 32505 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(IResult result)
			{
				throw null;
			}

			// Token: 0x0400862A RID: 34346
			public Task unloadHideout;

			// Token: 0x0400862B RID: 34347
			public TarkovApplication.Class1222 class1222_0;

			// Token: 0x0200170B RID: 5899
			[StructLayout(LayoutKind.Auto)]
			public struct Struct291 : IAsyncStateMachine
			{
				// Token: 0x06007EFA RID: 32506 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IAsyncStateMachine.MoveNext()
				{
					throw null;
				}

				// Token: 0x06007EFB RID: 32507 RVA: 0x00002050 File Offset: 0x00000250
				[DebuggerHidden]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					throw null;
				}

				// Token: 0x0400862C RID: 34348
				public int int_0;

				// Token: 0x0400862D RID: 34349
				public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

				// Token: 0x0400862E RID: 34350
				public TarkovApplication.Class1224 class1224_0;

				// Token: 0x0400862F RID: 34351
				public IResult result;

				// Token: 0x04008630 RID: 34352
				private TaskAwaiter taskAwaiter_0;
			}
		}

		// Token: 0x0200170E RID: 5902
		[CompilerGenerated]
		private sealed class Class1225
		{
			// Token: 0x06007F00 RID: 32512 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x06007F01 RID: 32513 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(IResult result)
			{
				throw null;
			}

			// Token: 0x04008645 RID: 34373
			public TarkovApplication tarkovApplication_0;

			// Token: 0x04008646 RID: 34374
			public bool isPet;

			// Token: 0x04008647 RID: 34375
			public MatchmakerTimeHasCome.GClass3163 controller;

			// Token: 0x04008648 RID: 34376
			public CancellationTokenSource cancellationToken;

			// Token: 0x04008649 RID: 34377
			public Callback callback_0;
		}

		// Token: 0x02001710 RID: 5904
		[CompilerGenerated]
		private sealed class Class1226
		{
			// Token: 0x06007F04 RID: 32516 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Exception x)
			{
				throw null;
			}

			// Token: 0x06007F05 RID: 32517 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x04008652 RID: 34386
			public TarkovApplication tarkovApplication_0;

			// Token: 0x04008653 RID: 34387
			public string matchingName;

			// Token: 0x04008654 RID: 34388
			public bool handled;
		}

		// Token: 0x02001711 RID: 5905
		[CompilerGenerated]
		private sealed class Class1227
		{
			// Token: 0x06007F06 RID: 32518 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(GStruct117 p)
			{
				throw null;
			}

			// Token: 0x06007F07 RID: 32519 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(Exception x)
			{
				throw null;
			}

			// Token: 0x04008655 RID: 34389
			public MatchmakerTimeHasCome.GClass3163 screenController;

			// Token: 0x04008656 RID: 34390
			public CancellationTokenSource cancellationTokenSource;
		}

		// Token: 0x02001713 RID: 5907
		[CompilerGenerated]
		private sealed class Class1228
		{
			// Token: 0x06007F0A RID: 32522 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Exception x)
			{
				throw null;
			}

			// Token: 0x0400865E RID: 34398
			public CancellationTokenSource cancellationTokenSource;
		}

		// Token: 0x02001716 RID: 5910
		[CompilerGenerated]
		private sealed class Class1229
		{
			// Token: 0x06007F0F RID: 32527 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(GStruct117 pr)
			{
				throw null;
			}

			// Token: 0x06007F10 RID: 32528 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(float pr)
			{
				throw null;
			}

			// Token: 0x06007F11 RID: 32529 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(float pr)
			{
				throw null;
			}

			// Token: 0x04008675 RID: 34421
			public MatchmakerTimeHasCome.GClass3163 screenController;
		}

		// Token: 0x02001719 RID: 5913
		[CompilerGenerated]
		private sealed class Class1230
		{
			// Token: 0x06007F16 RID: 32534 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400868E RID: 34446
			public TarkovApplication tarkovApplication_0;

			// Token: 0x0400868F RID: 34447
			public string profileId;

			// Token: 0x04008690 RID: 34448
			public Profile savageProfile;

			// Token: 0x04008691 RID: 34449
			public LocationSettingsClass.Location location;

			// Token: 0x04008692 RID: 34450
			public MatchmakerTimeHasCome.GClass3163 timeHasComeScreenController;
		}

		// Token: 0x0200171A RID: 5914
		[CompilerGenerated]
		private sealed class Class1231
		{
			// Token: 0x06007F17 RID: 32535 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x04008693 RID: 34451
			public TaskCanceledException e;

			// Token: 0x04008694 RID: 34452
			public TarkovApplication.Class1230 class1230_0;
		}

		// Token: 0x0200171C RID: 5916
		[CompilerGenerated]
		private sealed class Class1232
		{
			// Token: 0x06007F1A RID: 32538 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(ProfileStatusClass status)
			{
				throw null;
			}

			// Token: 0x0400869F RID: 34463
			public string profileId;
		}

		// Token: 0x0200171E RID: 5918
		[CompilerGenerated]
		private sealed class Class1233
		{
			// Token: 0x06007F1D RID: 32541 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x06007F1E RID: 32542 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(Result<ExitStatus, TimeSpan, MetricsClass> result)
			{
				throw null;
			}

			// Token: 0x06007F1F RID: 32543 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2()
			{
				throw null;
			}

			// Token: 0x040086A9 RID: 34473
			public TarkovApplication tarkovApplication_0;

			// Token: 0x040086AA RID: 34474
			public ProfileStatusClass profileStatus;

			// Token: 0x040086AB RID: 34475
			public Profile savageProfile;

			// Token: 0x040086AC RID: 34476
			public LocationSettingsClass.Location location;

			// Token: 0x040086AD RID: 34477
			public MatchmakerTimeHasCome.GClass3163 timeHasComeScreenController;
		}

		// Token: 0x0200171F RID: 5919
		[CompilerGenerated]
		private sealed class Class1234
		{
			// Token: 0x06007F20 RID: 32544 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Result<ExitStatus, TimeSpan, MetricsClass> result)
			{
				throw null;
			}

			// Token: 0x06007F21 RID: 32545 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(IResult error)
			{
				throw null;
			}

			// Token: 0x040086AE RID: 34478
			public TarkovApplication tarkovApplication_0;

			// Token: 0x040086AF RID: 34479
			public Profile profile;

			// Token: 0x040086B0 RID: 34480
			public Profile savageProfile;

			// Token: 0x040086B1 RID: 34481
			public LocationSettingsClass.Location location;

			// Token: 0x040086B2 RID: 34482
			public MatchmakerTimeHasCome.GClass3163 timeHasComeScreenController;
		}
	}
}
