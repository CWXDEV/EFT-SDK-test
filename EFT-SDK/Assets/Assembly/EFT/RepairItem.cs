using System;
using Newtonsoft.Json;

namespace EFT
{
	// Token: 0x02001841 RID: 6209
	[Serializable]
	public sealed class RepairItem
	{
		// Token: 0x04008C03 RID: 35843
		[JsonProperty("_id")]
		public string Id;

		// Token: 0x04008C04 RID: 35844
		[JsonProperty("count")]
		public float Count;
	}
}
