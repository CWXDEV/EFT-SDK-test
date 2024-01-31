using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002944 RID: 10564
	public sealed class DisplayMoneyPanel : UIElement
	{
		// Token: 0x0600D2C2 RID: 53954 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(IEnumerable<Item> inventoryItems)
		{
			throw null;
		}

		// Token: 0x0400D44A RID: 54346
		[SerializeField]
		private CustomTextMeshProUGUI _roubles;

		// Token: 0x0400D44B RID: 54347
		[SerializeField]
		private CustomTextMeshProUGUI _euros;

		// Token: 0x0400D44C RID: 54348
		[SerializeField]
		private CustomTextMeshProUGUI _dollars;
	}
}
