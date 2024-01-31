using System;
using Newtonsoft.Json;

namespace EFT.InventoryLogic.BackendInventoryInteraction
{
	// Token: 0x02002592 RID: 9618
	[Serializable]
	public sealed class ToggleCommand : GClass2830
	{
		// Token: 0x0400C1E7 RID: 49639
		[JsonProperty("Action")]
		public string Action;

		// Token: 0x0400C1E8 RID: 49640
		[JsonProperty("item")]
		public string Item;

		// Token: 0x0400C1E9 RID: 49641
		[JsonProperty("value")]
		public bool Value;
	}
}
