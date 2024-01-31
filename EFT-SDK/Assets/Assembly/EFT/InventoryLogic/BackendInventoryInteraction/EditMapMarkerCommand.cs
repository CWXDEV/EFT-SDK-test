using System;
using Newtonsoft.Json;

namespace EFT.InventoryLogic.BackendInventoryInteraction
{
	// Token: 0x0200259D RID: 9629
	[Serializable]
	public sealed class EditMapMarkerCommand : GClass2830
	{
		// Token: 0x0400C20B RID: 49675
		[JsonProperty("Action")]
		public string Action;

		// Token: 0x0400C20C RID: 49676
		[JsonProperty("item")]
		public string Item;

		// Token: 0x0400C20D RID: 49677
		[JsonProperty("X")]
		public int X;

		// Token: 0x0400C20E RID: 49678
		[JsonProperty("Y")]
		public int Y;

		// Token: 0x0400C20F RID: 49679
		[JsonProperty("mapMarker")]
		public MapMarker MapMarker;
	}
}
