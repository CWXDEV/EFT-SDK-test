using System;
using Newtonsoft.Json;

namespace EFT.InventoryLogic.BackendInventoryInteraction
{
	// Token: 0x02002584 RID: 9604
	[Serializable]
	public sealed class OwnerInfo
	{
		// Token: 0x0400C1C2 RID: 49602
		[JsonProperty("id")]
		public string Id;

		// Token: 0x0400C1C3 RID: 49603
		[JsonProperty("type")]
		public EOwnerType Type;
	}
}
