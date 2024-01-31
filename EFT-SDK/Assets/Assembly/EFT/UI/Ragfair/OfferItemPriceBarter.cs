using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.UI.Ragfair
{
	// Token: 0x02002FB6 RID: 12214
	public sealed class OfferItemPriceBarter : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
	{
		// Token: 0x0600F11D RID: 61725 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(IExchangeRequirement requirement, ItemTooltip tooltip, Offer offer, InventoryControllerClass inventoryController, ItemUiContext itemUiContext, InsuranceCompanyClass insuranceCompany, int index, bool expanded)
		{
			throw null;
		}

		// Token: 0x0600F11E RID: 61726 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600F11F RID: 61727 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600F120 RID: 61728 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400F71A RID: 63258
		[SerializeField]
		private GameObject _separator;

		// Token: 0x0400F71B RID: 63259
		[SerializeField]
		private GameObject _barterIcon;

		// Token: 0x0400F71C RID: 63260
		[SerializeField]
		private TextMeshProUGUI _requirementName;

		// Token: 0x0400F71D RID: 63261
		private IExchangeRequirement iexchangeRequirement_0;

		// Token: 0x0400F71E RID: 63262
		private ItemTooltip itemTooltip_0;

		// Token: 0x0400F71F RID: 63263
		private Offer offer_0;

		// Token: 0x0400F720 RID: 63264
		private InventoryControllerClass gclass2757_0;

		// Token: 0x0400F721 RID: 63265
		private ItemUiContext itemUiContext_0;

		// Token: 0x0400F722 RID: 63266
		private InsuranceCompanyClass gclass3179_0;

		// Token: 0x0400F723 RID: 63267
		private bool bool_0;
	}
}
