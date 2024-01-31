using System;
using Newtonsoft.Json;

namespace EFT.InventoryLogic.BackendInventoryInteraction
{
	// Token: 0x020025A2 RID: 9634
	[Serializable]
	public sealed class TagCommand : GClass2830
	{
		// Token: 0x0400C21B RID: 49691
		[JsonProperty("Action")]
		public string Action;

		// Token: 0x0400C21C RID: 49692
		[JsonProperty("item")]
		public string Item;

		// Token: 0x0400C21D RID: 49693
		[JsonProperty("TagName")]
		public string TagName;

		// Token: 0x0400C21E RID: 49694
		[JsonProperty("TagColor")]
		public int TagColor;
	}
}
