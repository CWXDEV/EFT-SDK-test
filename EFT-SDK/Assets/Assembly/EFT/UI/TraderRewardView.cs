using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002BB1 RID: 11185
	public sealed class TraderRewardView : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x0600DC8F RID: 56463 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(string traderId)
		{
			throw null;
		}

		// Token: 0x0600DC90 RID: 56464 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DC91 RID: 56465 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400E0DB RID: 57563
		[SerializeField]
		private TextMeshProUGUI _traderName;

		// Token: 0x0400E0DC RID: 57564
		[SerializeField]
		private Image _avatar;

		// Token: 0x0400E0DD RID: 57565
		private SimpleTooltip simpleTooltip_0;
	}
}
