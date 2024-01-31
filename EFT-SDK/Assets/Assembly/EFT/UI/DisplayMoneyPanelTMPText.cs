using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using TMPro;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002945 RID: 10565
	public class DisplayMoneyPanelTMPText : UIElement
	{
		// Token: 0x0600D2C3 RID: 53955 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(IEnumerable<Item> inventoryItems)
		{
			throw null;
		}

		// Token: 0x0400D44D RID: 54349
		[SerializeField]
		private TMP_Text _roubles;

		// Token: 0x0400D44E RID: 54350
		[SerializeField]
		private TMP_Text _euros;

		// Token: 0x0400D44F RID: 54351
		[SerializeField]
		private TMP_Text _dollars;
	}
}
