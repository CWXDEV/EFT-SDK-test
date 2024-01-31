using System;
using Newtonsoft.Json;

namespace EFT.InventoryLogic.BackendInventoryInteraction
{
	// Token: 0x02002591 RID: 9617
	[Serializable]
	public sealed class ThrowCommand : GClass2830
	{
		// Token: 0x0400C1E5 RID: 49637
		[JsonProperty("Action")]
		public string Action;

		// Token: 0x0400C1E6 RID: 49638
		[JsonProperty("item")]
		public string Item;
	}
}
