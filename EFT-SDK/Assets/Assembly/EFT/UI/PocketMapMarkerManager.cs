using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002B38 RID: 11064
	public sealed class PocketMapMarkerManager : MonoBehaviour, IEventSystemHandler, IPointerClickHandler
	{
		// Token: 0x17002690 RID: 9872
		// (get) Token: 0x0600DB34 RID: 56116 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DB35 RID: 56117 RVA: 0x00002050 File Offset: 0x00000250
		public bool Shown
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

		// Token: 0x0600DB36 RID: 56118 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600DB37 RID: 56119 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(MapComponent map, GInterface313 itemController, MapMarkerWindow markerWindow)
		{
			throw null;
		}

		// Token: 0x0600DB38 RID: 56120 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			throw null;
		}

		// Token: 0x0600DB39 RID: 56121 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnCreateMapMarkerEvent(GEventArgs15 args)
		{
			throw null;
		}

		// Token: 0x0600DB3A RID: 56122 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEditMapMarkerEvent(GEventArgs16 args)
		{
			throw null;
		}

		// Token: 0x0600DB3B RID: 56123 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDeleteMapMarkerEvent(GEventArgs17 args)
		{
			throw null;
		}

		// Token: 0x0600DB3C RID: 56124 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CreateMarkerView(MapMarker marker)
		{
			throw null;
		}

		// Token: 0x0600DB3D RID: 56125 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EditMarkerView(int x, int y, MapMarker marker)
		{
			throw null;
		}

		// Token: 0x0600DB3E RID: 56126 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DiscardEditMarkerView(int x, int y)
		{
			throw null;
		}

		// Token: 0x0600DB3F RID: 56127 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RemoveMarkerView(int x, int y)
		{
			throw null;
		}

		// Token: 0x0600DB40 RID: 56128 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private PocketMapMarker GetMarkerView(int x, int y)
		{
			throw null;
		}

		// Token: 0x0600DB41 RID: 56129 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DB42 RID: 56130 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowCreateContextMenu(Vector2 position)
		{
			throw null;
		}

		// Token: 0x0600DB43 RID: 56131 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowEditContextMenu(Vector2 position, MapMarker marker)
		{
			throw null;
		}

		// Token: 0x0600DB44 RID: 56132 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void HideMarkerWindow()
		{
			throw null;
		}

		// Token: 0x0600DB45 RID: 56133 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MarkerCreate(Vector2 position)
		{
			throw null;
		}

		// Token: 0x0600DB46 RID: 56134 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MarkerEdit(Vector2 position, MapMarker marker)
		{
			throw null;
		}

		// Token: 0x0600DB47 RID: 56135 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MarkerDelete(MapMarker marker)
		{
			throw null;
		}

		// Token: 0x0600DB48 RID: 56136 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int GetMarkersCount(MapMarkerType type)
		{
			throw null;
		}

		// Token: 0x0600DB49 RID: 56137 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateLegend()
		{
			throw null;
		}

		// Token: 0x0600DB4A RID: 56138 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool IsMarkerTypeVisible(MapMarkerType type)
		{
			throw null;
		}

		// Token: 0x0600DB4B RID: 56139 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetMarkersVisible(MapMarkerType type, bool value)
		{
			throw null;
		}

		// Token: 0x0400DEC0 RID: 57024
		[SerializeField]
		private GameObject _markerPrefab;

		// Token: 0x0400DEC1 RID: 57025
		[SerializeField]
		private RectTransform _container;

		// Token: 0x0400DEC2 RID: 57026
		[SerializeField]
		private SpriteMap _spriteMap;

		// Token: 0x0400DEC3 RID: 57027
		[SerializeField]
		private PocketMapMarkerManager.ToggleData[] _toggles;

		// Token: 0x0400DEC4 RID: 57028
		[SerializeField]
		private CustomTextMeshProUGUI _markersCounter;

		// Token: 0x0400DEC5 RID: 57029
		[SerializeField]
		private CustomToggle _legendButton;

		// Token: 0x0400DEC6 RID: 57030
		[SerializeField]
		private GameObject _legend;

		// Token: 0x0400DEC7 RID: 57031
		private MapComponent _map;

		// Token: 0x0400DEC8 RID: 57032
		private IItemOwner _mapOwner;

		// Token: 0x0400DEC9 RID: 57033
		private GInterface313 _itemController;

		// Token: 0x0400DECA RID: 57034
		private MapMarkerWindow _markerWindow;

		// Token: 0x0400DECC RID: 57036
		private readonly List<PocketMapMarker> _markers;

		// Token: 0x02002B39 RID: 11065
		[Serializable]
		public sealed class ToggleData
		{
			// Token: 0x0400DECD RID: 57037
			public MapMarkerType Type;

			// Token: 0x0400DECE RID: 57038
			public Toggle Toggle;

			// Token: 0x0400DECF RID: 57039
			public CustomTextMeshProUGUI Label;
		}

		// Token: 0x02002B3A RID: 11066
		[CompilerGenerated]
		private sealed class Class2604
		{
			// Token: 0x0400DED0 RID: 57040
			public PocketMapMarkerManager.ToggleData toggleDataSave;

			// Token: 0x0400DED1 RID: 57041
			public PocketMapMarkerManager pocketMapMarkerManager_0;
		}

		// Token: 0x02002B3B RID: 11067
		[CompilerGenerated]
		private sealed class Class2605
		{
			// Token: 0x0400DED2 RID: 57042
			public int x;

			// Token: 0x0400DED3 RID: 57043
			public int y;

			// Token: 0x0400DED4 RID: 57044
			public Func<PocketMapMarker, bool> func_0;
		}

		// Token: 0x02002B3C RID: 11068
		[CompilerGenerated]
		private sealed class Class2606
		{
			// Token: 0x0400DED5 RID: 57045
			public int x;

			// Token: 0x0400DED6 RID: 57046
			public int y;
		}

		// Token: 0x02002B3D RID: 11069
		[CompilerGenerated]
		private sealed class Class2607
		{
			// Token: 0x0400DED7 RID: 57047
			public PocketMapMarkerManager pocketMapMarkerManager_0;

			// Token: 0x0400DED8 RID: 57048
			public Vector2 position;
		}

		// Token: 0x02002B3E RID: 11070
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2608
		{
			// Token: 0x0400DED9 RID: 57049
			public static readonly PocketMapMarkerManager.Class2608 class2608_0;

			// Token: 0x0400DEDA RID: 57050
			public static Action action_0;

			// Token: 0x0400DEDB RID: 57051
			public static Func<PocketMapMarkerManager.ToggleData, bool> func_0;
		}

		// Token: 0x02002B3F RID: 11071
		[CompilerGenerated]
		private sealed class Class2609
		{
			// Token: 0x0400DEDC RID: 57052
			public MapMarker marker;

			// Token: 0x0400DEDD RID: 57053
			public PocketMapMarkerManager pocketMapMarkerManager_0;
		}

		// Token: 0x02002B40 RID: 11072
		[CompilerGenerated]
		private sealed class Class2610
		{
			// Token: 0x0400DEDE RID: 57054
			public MapMarkerType type;
		}

		// Token: 0x02002B41 RID: 11073
		[CompilerGenerated]
		private sealed class Class2611
		{
			// Token: 0x0400DEDF RID: 57055
			public MapMarkerType type;
		}
	}
}
