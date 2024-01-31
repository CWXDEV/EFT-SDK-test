using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002BFE RID: 11262
	public class TraderHoverPanel : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
	{
		// Token: 0x0600DDEE RID: 56814 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600DDEF RID: 56815 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Action onClick)
		{
			throw null;
		}

		// Token: 0x0600DDF0 RID: 56816 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DDF1 RID: 56817 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DDF2 RID: 56818 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DDF3 RID: 56819 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400E299 RID: 58009
		[SerializeField]
		private Image _buttonImage;

		// Token: 0x0400E29A RID: 58010
		[SerializeField]
		private Color _defaultColor;

		// Token: 0x0400E29B RID: 58011
		[SerializeField]
		private Color _selectedColor;

		// Token: 0x0400E29C RID: 58012
		[SerializeField]
		private Color _defaultTextColor;

		// Token: 0x0400E29D RID: 58013
		[SerializeField]
		private CustomTextMeshProUGUI[] _labels;

		// Token: 0x0400E29E RID: 58014
		private readonly Dictionary<CustomTextMeshProUGUI, Color> dictionary_0;

		// Token: 0x0400E29F RID: 58015
		private Action action_0;
	}
}
