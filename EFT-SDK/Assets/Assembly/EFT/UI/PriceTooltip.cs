using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002ABC RID: 10940
	public sealed class PriceTooltip : SimpleTooltip
	{
		// Token: 0x0600D97E RID: 55678 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(EOwnerType ownerType, string text, int price, string currencyTemplate)
		{
			throw null;
		}

		// Token: 0x0400DC67 RID: 56423
		private const string string_0 = "Trader can't buy this item";

		// Token: 0x0400DC68 RID: 56424
		private const string string_1 = "The item has been sold";

		// Token: 0x0400DC69 RID: 56425
		[SerializeField]
		private Image _currencyIcon;

		// Token: 0x0400DC6A RID: 56426
		[SerializeField]
		private TextMeshProUGUI _price;

		// Token: 0x0400DC6B RID: 56427
		[SerializeField]
		private Color _priceColor;

		// Token: 0x0400DC6C RID: 56428
		[SerializeField]
		private Color _unbuyableColor;
	}
}
