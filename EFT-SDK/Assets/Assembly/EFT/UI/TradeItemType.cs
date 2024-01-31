using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002BF3 RID: 11251
	public class TradeItemType : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x0600DDB1 RID: 56753 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(EItemType itemType)
		{
			throw null;
		}

		// Token: 0x0600DDB2 RID: 56754 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DDB3 RID: 56755 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DDB4 RID: 56756 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400E252 RID: 57938
		[SerializeField]
		private Image _icon;

		// Token: 0x0400E253 RID: 57939
		private readonly Color color_0;

		// Token: 0x0400E254 RID: 57940
		private SimpleTooltip simpleTooltip_0;

		// Token: 0x0400E255 RID: 57941
		private EItemType eitemType_0;
	}
}
