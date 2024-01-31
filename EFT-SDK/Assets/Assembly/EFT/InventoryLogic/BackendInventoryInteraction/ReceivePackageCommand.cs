using System;
using Newtonsoft.Json;

namespace EFT.InventoryLogic.BackendInventoryInteraction
{
	// Token: 0x02002589 RID: 9609
	[Serializable]
	public sealed class ReceivePackageCommand : GClass2830
	{
		// Token: 0x0400C1CA RID: 49610
		[JsonProperty("Action")]
		public string Action;
	}
}
