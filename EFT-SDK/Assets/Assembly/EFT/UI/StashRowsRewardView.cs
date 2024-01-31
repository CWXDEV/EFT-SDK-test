using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.UI
{
	// Token: 0x02002BAE RID: 11182
	[UsedImplicitly]
	public sealed class StashRowsRewardView : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x0600DC89 RID: 56457 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(int additionalRows)
		{
			throw null;
		}

		// Token: 0x0600DC8A RID: 56458 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DC8B RID: 56459 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400E0D3 RID: 57555
		[SerializeField]
		private TMP_Text _rewardCaptionField;

		// Token: 0x0400E0D4 RID: 57556
		[SerializeField]
		private TMP_Text _rowsNumberField;

		// Token: 0x0400E0D5 RID: 57557
		private SimpleTooltip simpleTooltip_0;
	}
}
