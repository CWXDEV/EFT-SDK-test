using System;
using Newtonsoft.Json;

namespace EFT.InventoryLogic.BackendInventoryInteraction
{
	// Token: 0x02002588 RID: 9608
	[Serializable]
	public sealed class AddItemCommand : GClass2830
	{
		// Token: 0x0400C1C7 RID: 49607
		[JsonProperty("Action")]
		public string Action;

		// Token: 0x0400C1C8 RID: 49608
		[JsonProperty("item")]
		public string Item;

		// Token: 0x0400C1C9 RID: 49609
		[JsonProperty("container")]
		public GClass2759.GClass2808 Container;
	}
}
