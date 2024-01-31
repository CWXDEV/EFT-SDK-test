using System;
using Newtonsoft.Json;

namespace EFT
{
	// Token: 0x02001846 RID: 6214
	[Serializable]
	public class ExchangeRateDTO
	{
		// Token: 0x04008C0B RID: 35851
		[JsonProperty("exchange_rate")]
		public double ExchangeRate;
	}
}
