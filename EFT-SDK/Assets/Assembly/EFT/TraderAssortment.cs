using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EFT
{
	// Token: 0x02001847 RID: 6215
	[Serializable]
	public sealed class TraderAssortment : ExchangeRateDTO
	{
		// Token: 0x04008C0C RID: 35852
		[JsonProperty("items")]
		public GClass1186[] Items;

		// Token: 0x04008C0D RID: 35853
		[JsonProperty("barter_scheme")]
		public Dictionary<string, BarterScheme> BarterScheme;

		// Token: 0x04008C0E RID: 35854
		[JsonProperty("loyal_level_items")]
		public Dictionary<string, int> LoyaltyLevelItems;

		// Token: 0x04008C0F RID: 35855
		[JsonProperty("nextResupply")]
		public int NextResupply;
	}
}
