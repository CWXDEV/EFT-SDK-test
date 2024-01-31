using System;
using Newtonsoft.Json;

namespace EFT.InventoryLogic.BackendInventoryInteraction
{
	// Token: 0x02002599 RID: 9625
	[Serializable]
	public sealed class BindCommand : GClass2830
	{
		// Token: 0x0400C1FF RID: 49663
		[JsonProperty("Action")]
		public string Action;

		// Token: 0x0400C200 RID: 49664
		[JsonProperty("item")]
		public string Item;

		// Token: 0x0400C201 RID: 49665
		[JsonProperty("index")]
		public EBoundItem Index;
	}
}
