using System;
using System.Collections.Generic;

namespace EFT.UI.Ragfair
{
	// Token: 0x02002F55 RID: 12117
	[Serializable]
	public class OffersList
	{
		// Token: 0x0400F44E RID: 62542
		public Offer[] offers;

		// Token: 0x0400F44F RID: 62543
		public int offersCount;

		// Token: 0x0400F450 RID: 62544
		public Dictionary<string, int> categories;

		// Token: 0x0400F451 RID: 62545
		public string selectedCategory;
	}
}
