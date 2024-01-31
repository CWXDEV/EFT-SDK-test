using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002C37 RID: 11319
	[UsedImplicitly]
	public class DropDownBox : BaseDropDownBox, IEventSystemHandler, IPointerClickHandler, IPointerDownHandler
	{
		// Token: 0x0600DF0C RID: 57100 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Init()
		{
			throw null;
		}

		// Token: 0x0600DF0D RID: 57101 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(IEnumerable<string> values, Func<int, bool> validator = null)
		{
			throw null;
		}

		// Token: 0x0600DF0E RID: 57102 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Update()
		{
			throw null;
		}

		// Token: 0x0600DF0F RID: 57103 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void HoverDropDownEventHandler(bool value)
		{
			throw null;
		}

		// Token: 0x0600DF10 RID: 57104 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IPointerClickHandler.OnPointerClick([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DF11 RID: 57105 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DF12 RID: 57106 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SetPanelState(bool open)
		{
			throw null;
		}

		// Token: 0x0600DF13 RID: 57107 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SetTextInternal(string text)
		{
			throw null;
		}

		// Token: 0x0600DF14 RID: 57108 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAsSpecific(bool value)
		{
			throw null;
		}

		// Token: 0x0600DF15 RID: 57109 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0400E3E5 RID: 58341
		[SerializeField]
		private TextMeshProUGUI _currentValueText;

		// Token: 0x0400E3E6 RID: 58342
		[SerializeField]
		private Button _button;

		// Token: 0x0400E3E7 RID: 58343
		[SerializeField]
		private Image _background;

		// Token: 0x0400E3E8 RID: 58344
		[SerializeField]
		private Color _highlightedColor;

		// Token: 0x0400E3E9 RID: 58345
		[SerializeField]
		private LayoutElement _scrollRectLayoutElement;

		// Token: 0x0400E3EA RID: 58346
		[SerializeField]
		private RectTransform _scrollBar;

		// Token: 0x0400E3EB RID: 58347
		[SerializeField]
		private Image _buttonOpen;

		// Token: 0x0400E3EC RID: 58348
		[SerializeField]
		private Image _buttonClosed;

		// Token: 0x0400E3ED RID: 58349
		[SerializeField]
		private float _maxVisibleHeight;

		// Token: 0x0400E3EE RID: 58350
		private VerticalLayoutGroup verticalLayoutGroup_0;

		// Token: 0x0400E3EF RID: 58351
		private Vector3 vector3_0;

		// Token: 0x0400E3F0 RID: 58352
		private RectTransform rectTransform_1;

		// Token: 0x0400E3F1 RID: 58353
		private readonly Color color_0;
	}
}
