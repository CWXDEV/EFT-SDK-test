using System;
using Newtonsoft.Json;

namespace EFT.Hideout
{
	// Token: 0x02001B18 RID: 6936
	[Serializable]
	public sealed class ProductionData
	{
		// Token: 0x0400991F RID: 39199
		[JsonProperty("Progress")]
		public float Progress;

		// Token: 0x04009920 RID: 39200
		[JsonProperty("StartTimestamp", NullValueHandling = NullValueHandling.Ignore)]
		public int StartTimestamp;

		// Token: 0x04009921 RID: 39201
		[JsonProperty("ProductionTime")]
		public int ProductionTime;

		// Token: 0x04009922 RID: 39202
		[JsonProperty("inProgress")]
		public bool InProgress;

		// Token: 0x04009923 RID: 39203
		[JsonProperty("RecipeId")]
		public string RecipeId;

		// Token: 0x04009924 RID: 39204
		[JsonProperty("Products")]
		public GClass1186[] Products;

		// Token: 0x04009925 RID: 39205
		[JsonProperty("Interrupted")]
		public bool Interrupted;
	}
}
