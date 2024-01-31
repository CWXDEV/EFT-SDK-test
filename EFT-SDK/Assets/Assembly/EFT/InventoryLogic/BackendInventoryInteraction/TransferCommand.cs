using System;
using Newtonsoft.Json;

namespace EFT.InventoryLogic.BackendInventoryInteraction
{
	// Token: 0x0200258F RID: 9615
	[Serializable]
	public sealed class TransferCommand : GClass2831
	{
		// Token: 0x0400C1DA RID: 49626
		[JsonProperty("Action")]
		public string Action;

		// Token: 0x0400C1DB RID: 49627
		[JsonProperty("item")]
		public string Item;

		// Token: 0x0400C1DC RID: 49628
		[JsonProperty("with")]
		public string With;

		// Token: 0x0400C1DD RID: 49629
		[JsonProperty("count")]
		public int Count;
	}
}
