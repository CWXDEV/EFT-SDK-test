using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.Ragfair
{
	// Token: 0x02002F9D RID: 12189
	public sealed class OfferItemPrice : UIElement
	{
		// Token: 0x0600F076 RID: 61558 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Offer offer, ItemTooltip tooltip, InventoryControllerClass inventoryController, ItemUiContext itemUiContext, InsuranceCompanyClass insuranceCompany, bool expanded)
		{
			throw null;
		}

		// Token: 0x0400F619 RID: 63001
		[SerializeField]
		private OfferItemPriceBarter _barterRequirementView;

		// Token: 0x0400F61A RID: 63002
		[SerializeField]
		private RectTransform _barterRequirementsContainer;

		// Token: 0x0400F61B RID: 63003
		[SerializeField]
		private TextMeshProUGUI _priceLabel;

		// Token: 0x0400F61C RID: 63004
		[SerializeField]
		private Image _priceIcon;

		// Token: 0x0400F61D RID: 63005
		[SerializeField]
		private GameObject _estimatedPriceObject;

		// Token: 0x0400F61E RID: 63006
		[SerializeField]
		private TextMeshProUGUI _estimatedPriceLabel;

		// Token: 0x0400F61F RID: 63007
		[SerializeField]
		private TextMeshProUGUI _packLabel;

		// Token: 0x0400F620 RID: 63008
		[SerializeField]
		private GridLayoutGroup _gridLayout;

		// Token: 0x0400F621 RID: 63009
		private GClass3078<IExchangeRequirement, OfferItemPriceBarter> gclass3078_0;

		// Token: 0x02002F9E RID: 12190
		[CompilerGenerated]
		private sealed class Class3038
		{
			// Token: 0x0400F622 RID: 63010
			public ItemTooltip tooltip;

			// Token: 0x0400F623 RID: 63011
			public Offer offer;

			// Token: 0x0400F624 RID: 63012
			public InventoryControllerClass inventoryController;

			// Token: 0x0400F625 RID: 63013
			public ItemUiContext itemUiContext;

			// Token: 0x0400F626 RID: 63014
			public InsuranceCompanyClass insuranceCompany;

			// Token: 0x0400F627 RID: 63015
			public bool expanded;
		}

		// Token: 0x02002F9F RID: 12191
		[CompilerGenerated]
		private sealed class Class3039
		{
			// Token: 0x0600F077 RID: 61559 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(IExchangeRequirement item, OfferItemPriceBarter view)
			{
				throw null;
			}

			// Token: 0x0400F628 RID: 63016
			public int i;

			// Token: 0x0400F629 RID: 63017
			public OfferItemPrice.Class3038 class3038_0;
		}
	}
}
