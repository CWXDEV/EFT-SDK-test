using System;
using Newtonsoft.Json;

namespace EFT.InventoryLogic.BackendInventoryInteraction
{
	// Token: 0x02002590 RID: 9616
	[Serializable]
	public sealed class SwapCommand : GClass2831
	{
		// Token: 0x0400C1DE RID: 49630
		[JsonProperty("Action")]
		public string Action;

		// Token: 0x0400C1DF RID: 49631
		[JsonProperty("item")]
		public string Item;

		// Token: 0x0400C1E0 RID: 49632
		[JsonProperty("to")]
		public GClass2759.GClass2808 To;

		// Token: 0x0400C1E1 RID: 49633
		[JsonProperty("item2")]
		public string Item2;

		// Token: 0x0400C1E2 RID: 49634
		[JsonProperty("to2")]
		public GClass2759.GClass2808 To2;

		// Token: 0x0400C1E3 RID: 49635
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public OwnerInfo fromOwner2;

		// Token: 0x0400C1E4 RID: 49636
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public OwnerInfo toOwner2;
	}
}
