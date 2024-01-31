using System;
using Newtonsoft.Json;

namespace EFT.InventoryLogic.BackendInventoryInteraction
{
	// Token: 0x02002596 RID: 9622
	[Serializable]
	public sealed class HealCommand : GClass2831
	{
		// Token: 0x0400C1F3 RID: 49651
		[JsonProperty("Action")]
		public string Action;

		// Token: 0x0400C1F4 RID: 49652
		[JsonProperty("item")]
		public string Item;

		// Token: 0x0400C1F5 RID: 49653
		[JsonProperty("part")]
		public EBodyPart Part;

		// Token: 0x0400C1F6 RID: 49654
		[JsonProperty("count")]
		public int Count;

		// Token: 0x0400C1F7 RID: 49655
		[JsonProperty("time")]
		public int Time;
	}
}
