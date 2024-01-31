using System;
using EFT.InventoryLogic.BackendInventoryInteraction;
using Newtonsoft.Json;

// Token: 0x02002587 RID: 9607
public class GClass2831 : GClass2829
{
	// Token: 0x0400C1C5 RID: 49605
	[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
	public OwnerInfo fromOwner;

	// Token: 0x0400C1C6 RID: 49606
	[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
	public OwnerInfo toOwner;
}
