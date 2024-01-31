using System;
using System.Runtime.CompilerServices;
using EFT.InputSystem;
using EFT.UI.Screens;
using JsonType;
using UnityEngine;

namespace EFT.UI.Matchmaker
{
	// Token: 0x02002DD6 RID: 11734
	public sealed class MatchMakerSelectionLocationScreen : MatchmakerEftScreen<MatchMakerSelectionLocationScreen.GClass3151, MatchMakerSelectionLocationScreen>
	{
		// Token: 0x17002815 RID: 10261
		// (get) Token: 0x0600E6AB RID: 59051 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E6AC RID: 59052 RVA: 0x00002050 File Offset: 0x00000250
		private LocationSettingsClass.Location Location_0
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

		// Token: 0x0600E6AD RID: 59053 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_4()
		{
			throw null;
		}

		// Token: 0x0600E6AE RID: 59054 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600E6AF RID: 59055 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(MatchMakerSelectionLocationScreen.GClass3151 controller)
		{
			throw null;
		}

		// Token: 0x0600E6B0 RID: 59056 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(ISession session, RaidSettings raidSettings)
		{
			throw null;
		}

		// Token: 0x0600E6B1 RID: 59057 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(LocationSettingsClass.Location location)
		{
			throw null;
		}

		// Token: 0x0600E6B2 RID: 59058 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(EDateTime time)
		{
			throw null;
		}

		// Token: 0x0600E6B3 RID: 59059 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(LocationSettingsClass.Location location, EDateTime time)
		{
			throw null;
		}

		// Token: 0x0600E6B4 RID: 59060 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_0(LocationSettingsClass.Location location)
		{
			throw null;
		}

		// Token: 0x0600E6B5 RID: 59061 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600E6B6 RID: 59062 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x0600E6B7 RID: 59063 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x0600E6B8 RID: 59064 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10()
		{
			throw null;
		}

		// Token: 0x0600E6B9 RID: 59065 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11()
		{
			throw null;
		}

		// Token: 0x0400EBBC RID: 60348
		private const string string_0 = "MapPointConfigs/";

		// Token: 0x0400EBBD RID: 60349
		[SerializeField]
		private DefaultUIButton _acceptButton;

		// Token: 0x0400EBBE RID: 60350
		[SerializeField]
		private DefaultUIButton _backButton;

		// Token: 0x0400EBBF RID: 60351
		[SerializeField]
		private DefaultUIButton _readyButton;

		// Token: 0x0400EBC0 RID: 60352
		[SerializeField]
		private DefaultUIButton _pocketMapButton;

		// Token: 0x0400EBC1 RID: 60353
		[SerializeField]
		private LocationButton _locationButtonTemplate;

		// Token: 0x0400EBC2 RID: 60354
		[SerializeField]
		private LocationPath _locationPathTemplate;

		// Token: 0x0400EBC3 RID: 60355
		[SerializeField]
		private Transform _locationButtonsContainer;

		// Token: 0x0400EBC4 RID: 60356
		[SerializeField]
		private Transform _locationPathsContainer;

		// Token: 0x0400EBC5 RID: 60357
		[SerializeField]
		private LocationInfoPanel _infoPanel;

		// Token: 0x0400EBC6 RID: 60358
		[SerializeField]
		private LocationConditionsPanel _conditions;

		// Token: 0x0400EBC7 RID: 60359
		private LocationSettingsClass.Location location_0;

		// Token: 0x0400EBC8 RID: 60360
		private Profile profile_0;

		// Token: 0x0400EBC9 RID: 60361
		private ESideType esideType_0;

		// Token: 0x0400EBCA RID: 60362
		private EDateTime edateTime_0;

		// Token: 0x0400EBCB RID: 60363
		private RaidSettings raidSettings_0;

		// Token: 0x02002DD7 RID: 11735
		public sealed class GClass3151 : GClass3148<MatchMakerSelectionLocationScreen.GClass3151, MatchMakerSelectionLocationScreen>
		{
			// Token: 0x17002816 RID: 10262
			// (get) Token: 0x0600E6BA RID: 59066 RVA: 0x00002050 File Offset: 0x00000250
			public override EEftScreenType ScreenType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x14000344 RID: 836
			// (add) Token: 0x0600E6BB RID: 59067 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x0600E6BC RID: 59068 RVA: 0x00002050 File Offset: 0x00000250
			public event Action OnShowPocketMapScreen
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

			// Token: 0x17002817 RID: 10263
			// (get) Token: 0x0600E6BD RID: 59069 RVA: 0x00002050 File Offset: 0x00000250
			public override bool KeyScreen
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600E6BE RID: 59070 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_12()
			{
				throw null;
			}

			// Token: 0x0600E6BF RID: 59071 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void UpdateSelectedDateTime()
			{
				throw null;
			}

			// Token: 0x0400EBCC RID: 60364
			public readonly ISession Session;

			// Token: 0x0400EBCD RID: 60365
			public readonly RaidSettings RaidSettings;

			// Token: 0x0400EBCE RID: 60366
			[CompilerGenerated]
			private Action action_4;
		}

		// Token: 0x02002DD8 RID: 11736
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2859
		{
			// Token: 0x0600E6C0 RID: 59072 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_0(GClass1207 p)
			{
				throw null;
			}

			// Token: 0x0600E6C1 RID: 59073 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_1(GClass1207 p)
			{
				throw null;
			}

			// Token: 0x0600E6C2 RID: 59074 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_2(Class83<LocationSettingsClass.Location, LocationSettingsClass.Location> x)
			{
				throw null;
			}

			// Token: 0x0600E6C3 RID: 59075 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_3(Class83<LocationSettingsClass.Location, LocationSettingsClass.Location> path, LocationPath pathView)
			{
				throw null;
			}

			// Token: 0x0600E6C4 RID: 59076 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_4(GClass1207 p)
			{
				throw null;
			}

			// Token: 0x0600E6C5 RID: 59077 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_5(GClass1207 p)
			{
				throw null;
			}

			// Token: 0x0600E6C6 RID: 59078 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_6(LocationSettingsClass.Location x)
			{
				throw null;
			}

			// Token: 0x0600E6C7 RID: 59079 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_7(LocationSettingsClass.Location x)
			{
				throw null;
			}

			// Token: 0x0400EBCF RID: 60367
			public static readonly MatchMakerSelectionLocationScreen.Class2859 class2859_0;

			// Token: 0x0400EBD0 RID: 60368
			public static Func<GClass1207, int> func_0;

			// Token: 0x0400EBD1 RID: 60369
			public static Func<GClass1207, int> func_1;

			// Token: 0x0400EBD2 RID: 60370
			public static Func<Class83<LocationSettingsClass.Location, LocationSettingsClass.Location>, bool> func_2;

			// Token: 0x0400EBD3 RID: 60371
			public static Action<Class83<LocationSettingsClass.Location, LocationSettingsClass.Location>, LocationPath> action_0;

			// Token: 0x0400EBD4 RID: 60372
			public static Func<GClass1207, int> func_3;

			// Token: 0x0400EBD5 RID: 60373
			public static Func<GClass1207, int> func_4;

			// Token: 0x0400EBD6 RID: 60374
			public static Func<LocationSettingsClass.Location, bool> func_5;

			// Token: 0x0400EBD7 RID: 60375
			public static Func<LocationSettingsClass.Location, bool> func_6;
		}

		// Token: 0x02002DD9 RID: 11737
		[CompilerGenerated]
		private sealed class Class2860
		{
			// Token: 0x0600E6C8 RID: 59080 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Class83<LocationSettingsClass.Location, LocationSettingsClass.Location> method_0(LocationSettingsClass.GClass1220 x)
			{
				throw null;
			}

			// Token: 0x0600E6C9 RID: 59081 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(LocationSettingsClass.Location location, LocationButton locationButton)
			{
				throw null;
			}

			// Token: 0x0600E6CA RID: 59082 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2()
			{
				throw null;
			}

			// Token: 0x0400EBD8 RID: 60376
			public LocationSettingsClass locations;

			// Token: 0x0400EBD9 RID: 60377
			public MatchMakerSelectionLocationScreen matchMakerSelectionLocationScreen_0;

			// Token: 0x0400EBDA RID: 60378
			public LocationSettingsClass.Location selectedLocation;
		}
	}
}
