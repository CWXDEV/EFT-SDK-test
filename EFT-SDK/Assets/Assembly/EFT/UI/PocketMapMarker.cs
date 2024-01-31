using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002B36 RID: 11062
	public class PocketMapMarker : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
	{
		// Token: 0x0600DB2E RID: 56110 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x0600DB2F RID: 56111 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(MapMarker marker, PocketMapMarkerManager manager)
		{
			throw null;
		}

		// Token: 0x0600DB30 RID: 56112 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowNote(bool value)
		{
			throw null;
		}

		// Token: 0x0600DB31 RID: 56113 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DB32 RID: 56114 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DB33 RID: 56115 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400DEB5 RID: 57013
		[SerializeField]
		private Image _image;

		// Token: 0x0400DEB6 RID: 57014
		[SerializeField]
		private CustomTextMeshProUGUI _note;

		// Token: 0x0400DEB7 RID: 57015
		[SerializeField]
		private RectTransform _noteBack;

		// Token: 0x0400DEB8 RID: 57016
		[SerializeField]
		private Image _shadow;

		// Token: 0x0400DEB9 RID: 57017
		[SerializeField]
		private SpriteMap _spriteMap;

		// Token: 0x0400DEBA RID: 57018
		[NonSerialized]
		public MapMarker Marker;

		// Token: 0x0400DEBB RID: 57019
		private PocketMapMarkerManager pocketMapMarkerManager_0;
	}
}
