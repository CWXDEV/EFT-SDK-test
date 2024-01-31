using System;
using Newtonsoft.Json;

namespace EFT.InventoryLogic.BackendInventoryInteraction
{
	// Token: 0x02002597 RID: 9623
	[Serializable]
	public sealed class EatCommand : GClass2831
	{
		// Token: 0x0400C1F8 RID: 49656
		[JsonProperty("Action")]
		public string Action;

		// Token: 0x0400C1F9 RID: 49657
		[JsonProperty("item")]
		public string Item;

		// Token: 0x0400C1FA RID: 49658
		[JsonProperty("count")]
		public int Count;

		// Token: 0x0400C1FB RID: 49659
		[JsonProperty("time")]
		public int Time;
	}
}
