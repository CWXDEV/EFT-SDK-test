using System;
using Newtonsoft.Json;

namespace EFT
{
	// Token: 0x0200184B RID: 6219
	[Serializable]
	public sealed class CaptchaData
	{
		// Token: 0x04008C18 RID: 35864
		[JsonProperty("code")]
		public string Code;

		// Token: 0x04008C19 RID: 35865
		[JsonProperty("items")]
		public string[] Items;

		// Token: 0x04008C1A RID: 35866
		[JsonProperty("title")]
		public string Title;

		// Token: 0x04008C1B RID: 35867
		[JsonProperty("description")]
		public string Description;

		// Token: 0x04008C1C RID: 35868
		[JsonProperty("type")]
		public string Type;
	}
}
