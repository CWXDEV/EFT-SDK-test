using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002A68 RID: 10856
	public class MapMarkerWindow : MonoBehaviour
	{
		// Token: 0x0600D7AC RID: 55212 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600D7AD RID: 55213 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x0600D7AE RID: 55214 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600D7AF RID: 55215 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Vector2 position, Action<MapMarkerType, string> acceptAction, Action cancelAction)
		{
			throw null;
		}

		// Token: 0x0600D7B0 RID: 55216 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FillWithData(MapMarker marker)
		{
			throw null;
		}

		// Token: 0x0600D7B1 RID: 55217 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			throw null;
		}

		// Token: 0x0600D7B2 RID: 55218 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MarkerTypeChangedHandler(MapMarkerType type, bool value)
		{
			throw null;
		}

		// Token: 0x0600D7B3 RID: 55219 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void TextChangedHandler(string value)
		{
			throw null;
		}

		// Token: 0x0600D7B4 RID: 55220 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateLettersCounter()
		{
			throw null;
		}

		// Token: 0x0600D7B5 RID: 55221 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SelectToggle(MapMarkerType type)
		{
			throw null;
		}

		// Token: 0x0400DA56 RID: 55894
		[SerializeField]
		private RectTransform _mainWindow;

		// Token: 0x0400DA57 RID: 55895
		[SerializeField]
		private GameObject _captionPanel;

		// Token: 0x0400DA58 RID: 55896
		[SerializeField]
		private Button _closeButton;

		// Token: 0x0400DA59 RID: 55897
		[SerializeField]
		private DefaultUIButton _acceptButton;

		// Token: 0x0400DA5A RID: 55898
		[SerializeField]
		private ValidationInputField _note;

		// Token: 0x0400DA5B RID: 55899
		[SerializeField]
		private CustomTextMeshProUGUI _lettersCounter;

		// Token: 0x0400DA5C RID: 55900
		[SerializeField]
		private MapMarkerWindow.ToggleData[] _toggles;

		// Token: 0x0400DA5D RID: 55901
		private Action<MapMarkerType, string> _acceptAction;

		// Token: 0x0400DA5E RID: 55902
		private Action _cancelAction;

		// Token: 0x0400DA5F RID: 55903
		private MapMarkerType _selectedType;

		// Token: 0x02002A69 RID: 10857
		[Serializable]
		public class ToggleData
		{
			// Token: 0x0400DA60 RID: 55904
			public MapMarkerType Type;

			// Token: 0x0400DA61 RID: 55905
			public Toggle Toggle;
		}

		// Token: 0x02002A6A RID: 10858
		[CompilerGenerated]
		private sealed class Class2522
		{
			// Token: 0x0400DA62 RID: 55906
			public MapMarkerWindow.ToggleData toggleDataSave;

			// Token: 0x0400DA63 RID: 55907
			public MapMarkerWindow mapMarkerWindow_0;
		}

		// Token: 0x02002A6B RID: 10859
		[CompilerGenerated]
		private sealed class Class2523
		{
			// Token: 0x0400DA64 RID: 55908
			public MapMarkerType type;

			// Token: 0x0400DA65 RID: 55909
			public Func<MapMarkerWindow.ToggleData, bool> func_0;
		}
	}
}
