using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace EFT
{
	// Token: 0x02001848 RID: 6216
	[Serializable]
	public sealed class SupplyData : IBasePriceSource
	{
		// Token: 0x06008550 RID: 34128 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public double GetBasePrice(string itemId)
		{
			throw null;
		}

		// Token: 0x04008C10 RID: 35856
		[JsonProperty("supplyNextTime")]
		public int SupplyNextTime;

		// Token: 0x04008C11 RID: 35857
		[JsonProperty("prices")]
		public Dictionary<string, double> MarketPrices;

		// Token: 0x04008C12 RID: 35858
		[JsonProperty("currencyCourses")]
		public Dictionary<string, double> CurrencyCourses;
	}
}
