using System;
using Newtonsoft.Json;

namespace EFT.InventoryLogic.BackendInventoryInteraction
{
	// Token: 0x0200258D RID: 9613
	[Serializable]
	public sealed class MergeCommand : GClass2831
	{
		// Token: 0x0400C1D5 RID: 49621
		[JsonProperty("Action")]
		public string Action;

		// Token: 0x0400C1D6 RID: 49622
		[JsonProperty("item")]
		public string Item;

		// Token: 0x0400C1D7 RID: 49623
		[JsonProperty("with")]
		public string With;
	}
}
