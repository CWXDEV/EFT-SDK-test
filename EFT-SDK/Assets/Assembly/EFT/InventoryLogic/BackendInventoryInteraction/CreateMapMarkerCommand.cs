using System;
using Newtonsoft.Json;

namespace EFT.InventoryLogic.BackendInventoryInteraction
{
	// Token: 0x0200259C RID: 9628
	[Serializable]
	public sealed class CreateMapMarkerCommand : GClass2830
	{
		// Token: 0x0400C208 RID: 49672
		[JsonProperty("Action")]
		public string Action;

		// Token: 0x0400C209 RID: 49673
		[JsonProperty("item")]
		public string Item;

		// Token: 0x0400C20A RID: 49674
		[JsonProperty("mapMarker")]
		public MapMarker MapMarker;
	}
}
