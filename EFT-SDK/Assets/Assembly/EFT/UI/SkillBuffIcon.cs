using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002B46 RID: 11078
	public class SkillBuffIcon : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x0600DB57 RID: 56151 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GInterface226 buff)
		{
			throw null;
		}

		// Token: 0x0600DB58 RID: 56152 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DB59 RID: 56153 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DB5A RID: 56154 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400DEEA RID: 57066
		[SerializeField]
		private Image _image;

		// Token: 0x0400DEEB RID: 57067
		[SerializeField]
		private Sprite _buffSprite;

		// Token: 0x0400DEEC RID: 57068
		[SerializeField]
		private Sprite _debuffSprite;

		// Token: 0x0400DEED RID: 57069
		private SimpleTooltip simpleTooltip_0;

		// Token: 0x0400DEEE RID: 57070
		private GInterface226 ginterface226_0;
	}
}
