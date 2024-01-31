using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI.Ragfair
{
	// Token: 0x02002FB5 RID: 12213
	public sealed class HandoverRequirementBarterIcon : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x0600F119 RID: 61721 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass2045 requisite, SimpleTooltip tooltip)
		{
			throw null;
		}

		// Token: 0x0600F11A RID: 61722 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateView()
		{
			throw null;
		}

		// Token: 0x0600F11B RID: 61723 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter([CanBeNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600F11C RID: 61724 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit([CanBeNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400F713 RID: 63251
		[SerializeField]
		private Image _barterIcon;

		// Token: 0x0400F714 RID: 63252
		[SerializeField]
		private Color _unavailableColor;

		// Token: 0x0400F715 RID: 63253
		[SerializeField]
		private Color _defaultColor;

		// Token: 0x0400F716 RID: 63254
		[SerializeField]
		private Color _selectedColor;

		// Token: 0x0400F717 RID: 63255
		private string string_0;

		// Token: 0x0400F718 RID: 63256
		private SimpleTooltip simpleTooltip_0;

		// Token: 0x0400F719 RID: 63257
		private GClass2045 gclass2045_0;
	}
}
