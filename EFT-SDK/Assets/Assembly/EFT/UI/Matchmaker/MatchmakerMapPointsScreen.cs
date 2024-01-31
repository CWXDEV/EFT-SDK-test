using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InputSystem;
using EFT.InventoryLogic;
using EFT.UI.Map;
using EFT.UI.Screens;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.UI.Matchmaker
{
	// Token: 0x02002DE8 RID: 11752
	public sealed class MatchmakerMapPointsScreen : MatchmakerEftScreen<MatchmakerMapPointsScreen.GClass3154, MatchmakerMapPointsScreen>
	{
		// Token: 0x0600E711 RID: 59153 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600E712 RID: 59154 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(MatchmakerMapPointsScreen.GClass3154 controller)
		{
			throw null;
		}

		// Token: 0x0600E713 RID: 59155 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(bool allowSelection, MapPoints mapPoints, LocationSettingsClass.Location location, GInterface313 itemController)
		{
			throw null;
		}

		// Token: 0x0600E714 RID: 59156 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private MapComponent method_4(IEnumerable<MapComponent> maps)
		{
			throw null;
		}

		// Token: 0x0600E715 RID: 59157 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600E716 RID: 59158 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600E717 RID: 59159 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600E718 RID: 59160 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600E719 RID: 59161 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x0600E71A RID: 59162 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8(bool arg)
		{
			throw null;
		}

		// Token: 0x0600E71B RID: 59163 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(EntryPoint arg)
		{
			throw null;
		}

		// Token: 0x0600E71C RID: 59164 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_10(MapComponent map)
		{
			throw null;
		}

		// Token: 0x0400EC37 RID: 60471
		[SerializeField]
		private CustomTextMeshProUGUI _substring;

		// Token: 0x0400EC38 RID: 60472
		[SerializeField]
		private CustomTextMeshProUGUI _warningDescription;

		// Token: 0x0400EC39 RID: 60473
		[SerializeField]
		private GameObject[] _enableWhenNoMap;

		// Token: 0x0400EC3A RID: 60474
		[SerializeField]
		private GameObject[] _enableWhenMap;

		// Token: 0x0400EC3B RID: 60475
		[SerializeField]
		private GameObject _mapIcon;

		// Token: 0x0400EC3C RID: 60476
		[SerializeField]
		private SelectEntryPointPanel _entryPointPanel;

		// Token: 0x0400EC3D RID: 60477
		[SerializeField]
		private MapPointsManager _mapPointsManager;

		// Token: 0x0400EC3E RID: 60478
		[SerializeField]
		private DefaultUIButton _acceptButton;

		// Token: 0x0400EC3F RID: 60479
		[SerializeField]
		private DefaultUIButton _backButton;

		// Token: 0x0400EC40 RID: 60480
		[SerializeField]
		private DefaultUIButton _readyButton;

		// Token: 0x0400EC41 RID: 60481
		[SerializeField]
		private SimplePocketMap _pocketMap;

		// Token: 0x0400EC42 RID: 60482
		[SerializeField]
		private CustomToggle _legendButton;

		// Token: 0x0400EC43 RID: 60483
		[SerializeField]
		private GameObject _legend;

		// Token: 0x0400EC44 RID: 60484
		private MapPoints mapPoints_0;

		// Token: 0x0400EC45 RID: 60485
		private LocationSettingsClass.Location location_0;

		// Token: 0x0400EC46 RID: 60486
		private readonly Dictionary<string, string> dictionary_0;

		// Token: 0x02002DE9 RID: 11753
		public sealed class GClass3154 : GClass3148<MatchmakerMapPointsScreen.GClass3154, MatchmakerMapPointsScreen>
		{
			// Token: 0x17002824 RID: 10276
			// (get) Token: 0x0600E71D RID: 59165 RVA: 0x00002050 File Offset: 0x00000250
			public override EEftScreenType ScreenType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17002825 RID: 10277
			// (get) Token: 0x0600E71E RID: 59166 RVA: 0x00002050 File Offset: 0x00000250
			public override bool KeyScreen
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0400EC47 RID: 60487
			public readonly bool AllowSelection;

			// Token: 0x0400EC48 RID: 60488
			public readonly MapPoints MapPoints;

			// Token: 0x0400EC49 RID: 60489
			public readonly LocationSettingsClass.Location Location;

			// Token: 0x0400EC4A RID: 60490
			public readonly GInterface313 ItemController;
		}
	}
}
