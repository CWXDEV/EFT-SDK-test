using System;
using Newtonsoft.Json;

namespace EFT.InventoryLogic.BackendInventoryInteraction
{
	// Token: 0x02002595 RID: 9621
	[Serializable]
	public sealed class ApplyCommand : GClass2831
	{
		// Token: 0x0400C1F0 RID: 49648
		[JsonProperty("Action")]
		public string Action;

		// Token: 0x0400C1F1 RID: 49649
		[JsonProperty("item")]
		public string Item;

		// Token: 0x0400C1F2 RID: 49650
		[JsonProperty("target")]
		public string Target;
	}
}
