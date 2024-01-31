using System;
using EFT.InventoryLogic;
using Newtonsoft.Json;

namespace EFT.Trading
{
	// Token: 0x02001D15 RID: 7445
	[Serializable]
	public struct TradingItemReference
	{
		// Token: 0x0400A14F RID: 41295
		[JsonProperty("Item")]
		public Item Item;

		// Token: 0x0400A150 RID: 41296
		[JsonProperty("Count")]
		public int Count;

		// Token: 0x0400A151 RID: 41297
		[JsonProperty("SchemeId")]
		public int SchemeId;
	}
}
