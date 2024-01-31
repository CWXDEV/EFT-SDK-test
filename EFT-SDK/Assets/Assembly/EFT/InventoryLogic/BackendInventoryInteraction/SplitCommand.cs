using System;
using Newtonsoft.Json;

namespace EFT.InventoryLogic.BackendInventoryInteraction
{
	// Token: 0x0200258C RID: 9612
	[Serializable]
	public sealed class SplitCommand : GClass2831
	{
		// Token: 0x0400C1D0 RID: 49616
		[JsonProperty("Action")]
		public string Action;

		// Token: 0x0400C1D1 RID: 49617
		[JsonProperty("splitItem")]
		public string Item;

		// Token: 0x0400C1D2 RID: 49618
		[JsonProperty("newItem")]
		public string NewItem;

		// Token: 0x0400C1D3 RID: 49619
		[JsonProperty("container")]
		public GClass2759.GClass2808 Container;

		// Token: 0x0400C1D4 RID: 49620
		[JsonProperty("count")]
		public int Count;
	}
}
