using System;
using Newtonsoft.Json;

namespace EFT.InventoryLogic.BackendInventoryInteraction
{
	// Token: 0x02002594 RID: 9620
	[Serializable]
	public sealed class RecodeCommand : GClass2830
	{
		// Token: 0x0400C1ED RID: 49645
		[JsonProperty("Action")]
		public string Action;

		// Token: 0x0400C1EE RID: 49646
		[JsonProperty("item")]
		public string Item;

		// Token: 0x0400C1EF RID: 49647
		[JsonProperty("value")]
		public bool Value;
	}
}
