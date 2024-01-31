using System;
using Newtonsoft.Json;

namespace EFT.InventoryLogic.BackendInventoryInteraction
{
	// Token: 0x0200259B RID: 9627
	[Serializable]
	public sealed class InsureCommand : GClass2830
	{
		// Token: 0x0400C205 RID: 49669
		[JsonProperty("Action")]
		public string Action;

		// Token: 0x0400C206 RID: 49670
		[JsonProperty("tid")]
		public string TraderId;

		// Token: 0x0400C207 RID: 49671
		[JsonProperty("items")]
		public string[] Items;
	}
}
