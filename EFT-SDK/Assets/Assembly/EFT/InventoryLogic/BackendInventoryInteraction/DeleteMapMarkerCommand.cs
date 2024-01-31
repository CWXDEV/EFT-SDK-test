using System;
using Newtonsoft.Json;

namespace EFT.InventoryLogic.BackendInventoryInteraction
{
	// Token: 0x0200259E RID: 9630
	[Serializable]
	public sealed class DeleteMapMarkerCommand : GClass2830
	{
		// Token: 0x0400C210 RID: 49680
		[JsonProperty("Action")]
		public string Action;

		// Token: 0x0400C211 RID: 49681
		[JsonProperty("item")]
		public string Item;

		// Token: 0x0400C212 RID: 49682
		[JsonProperty("X")]
		public int X;

		// Token: 0x0400C213 RID: 49683
		[JsonProperty("Y")]
		public int Y;
	}
}
