using System;
using Newtonsoft.Json;

namespace EFT.InventoryLogic.BackendInventoryInteraction
{
	// Token: 0x02002593 RID: 9619
	[Serializable]
	public sealed class FoldCommand : GClass2830
	{
		// Token: 0x0400C1EA RID: 49642
		[JsonProperty("Action")]
		public string Action;

		// Token: 0x0400C1EB RID: 49643
		[JsonProperty("item")]
		public string Item;

		// Token: 0x0400C1EC RID: 49644
		[JsonProperty("value")]
		public bool Value;
	}
}
