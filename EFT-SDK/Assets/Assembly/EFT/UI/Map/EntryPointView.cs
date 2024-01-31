using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI.Map
{
	// Token: 0x02002F16 RID: 12054
	public sealed class EntryPointView : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
	{
		// Token: 0x0600EDE9 RID: 60905 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(bool allowSelection, EntryPoint entryPoint, bool editPositions, Action<EntryPoint> onSelect, Action<EntryPoint> onDoubleClick)
		{
			throw null;
		}

		// Token: 0x0600EDEA RID: 60906 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(EntryPoint point)
		{
			throw null;
		}

		// Token: 0x0600EDEB RID: 60907 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Select()
		{
			throw null;
		}

		// Token: 0x0600EDEC RID: 60908 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Deselect()
		{
			throw null;
		}

		// Token: 0x0600EDED RID: 60909 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600EDEE RID: 60910 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick([CanBeNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600EDEF RID: 60911 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter([CanBeNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600EDF0 RID: 60912 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit([CanBeNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400F319 RID: 62233
		[SerializeField]
		private Image _background;

		// Token: 0x0400F31A RID: 62234
		[SerializeField]
		private Image _glow;

		// Token: 0x0400F31B RID: 62235
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0400F31C RID: 62236
		[SerializeField]
		private CustomTextMeshProUGUI _nameLabel;

		// Token: 0x0400F31D RID: 62237
		[SerializeField]
		private CustomTextMeshProUGUI _indexLabel;

		// Token: 0x0400F31E RID: 62238
		[SerializeField]
		private Color _defaultColor;

		// Token: 0x0400F31F RID: 62239
		[SerializeField]
		private Color _selectedColor;

		// Token: 0x0400F320 RID: 62240
		[SerializeField]
		private Color _defaultTextColor;

		// Token: 0x0400F321 RID: 62241
		[SerializeField]
		private Color _selectedTextColor;

		// Token: 0x0400F322 RID: 62242
		[SerializeField]
		private Outline _outline;

		// Token: 0x0400F323 RID: 62243
		[SerializeField]
		private Color _defaultOutlineColor;

		// Token: 0x0400F324 RID: 62244
		[SerializeField]
		private Color _selectedOutlineColor;

		// Token: 0x0400F325 RID: 62245
		[SerializeField]
		private Image _iconImage;

		// Token: 0x0400F326 RID: 62246
		[SerializeField]
		private Image _allowDiableIcon;

		// Token: 0x0400F327 RID: 62247
		[SerializeField]
		private Sprite _defaultSprite;

		// Token: 0x0400F328 RID: 62248
		[SerializeField]
		private Sprite _selectedSprite;

		// Token: 0x0400F329 RID: 62249
		[SerializeField]
		private Sprite _lockedSprite;

		// Token: 0x0400F32A RID: 62250
		[SerializeField]
		private GameObject _lockedIcon;

		// Token: 0x0400F32B RID: 62251
		[SerializeField]
		private Image _textObject;

		// Token: 0x0400F32C RID: 62252
		private readonly Color32 color32_0;

		// Token: 0x0400F32D RID: 62253
		private bool bool_0;

		// Token: 0x0400F32E RID: 62254
		private EntryPoint entryPoint_0;

		// Token: 0x0400F32F RID: 62255
		private Action<EntryPoint> action_0;

		// Token: 0x0400F330 RID: 62256
		private bool bool_1;
	}
}
