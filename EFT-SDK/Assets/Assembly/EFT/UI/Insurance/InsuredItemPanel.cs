using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace EFT.UI.Insurance
{
	// Token: 0x02002EDB RID: 11995
	public class InsuredItemPanel : UIElement
	{
		// Token: 0x0600ECD1 RID: 60625 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(string itemName, string insurerName, EItemType itemType)
		{
			throw null;
		}

		// Token: 0x0400F1D1 RID: 61905
		[SerializeField]
		private TextMeshProUGUI _itemNameLabel;

		// Token: 0x0400F1D2 RID: 61906
		[SerializeField]
		private TextMeshProUGUI _insurerNamePanel;

		// Token: 0x0400F1D3 RID: 61907
		[SerializeField]
		private TradeItemType _itemType;
	}
}
