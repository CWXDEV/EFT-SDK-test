using System;
using Newtonsoft.Json;

namespace EFT.Interactive
{
	// Token: 0x020027C2 RID: 10178
	[Serializable]
	public class LootPointTemplate
	{
		// Token: 0x0400CC2F RID: 52271
		[JsonProperty("id")]
		public string Id;

		// Token: 0x0400CC30 RID: 52272
		[JsonProperty("systemName")]
		public string Name;

		// Token: 0x0400CC31 RID: 52273
		[JsonProperty("filterInclusive")]
		public string[] FilterInclusive;

		// Token: 0x0400CC32 RID: 52274
		[JsonProperty("filterExclusive")]
		public string[] FilterExclusive;
	}
}
