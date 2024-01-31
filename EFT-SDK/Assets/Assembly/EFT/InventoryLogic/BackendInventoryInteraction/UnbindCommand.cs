using System;
using Newtonsoft.Json;

namespace EFT.InventoryLogic.BackendInventoryInteraction
{
	// Token: 0x0200259A RID: 9626
	[Serializable]
	public sealed class UnbindCommand : GClass2830
	{
		// Token: 0x0400C202 RID: 49666
		[JsonProperty("Action")]
		public string Action;

		// Token: 0x0400C203 RID: 49667
		[JsonProperty("item")]
		public string Item;

		// Token: 0x0400C204 RID: 49668
		[JsonProperty("index")]
		public EBoundItem Index;
	}
}
