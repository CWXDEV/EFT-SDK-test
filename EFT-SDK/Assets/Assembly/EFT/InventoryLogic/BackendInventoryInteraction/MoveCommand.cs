using System;
using Newtonsoft.Json;

namespace EFT.InventoryLogic.BackendInventoryInteraction
{
	// Token: 0x0200258B RID: 9611
	[Serializable]
	public sealed class MoveCommand : GClass2831
	{
		// Token: 0x0400C1CD RID: 49613
		[JsonProperty("Action")]
		public string Action;

		// Token: 0x0400C1CE RID: 49614
		[JsonProperty("item")]
		public string Item;

		// Token: 0x0400C1CF RID: 49615
		[JsonProperty("to")]
		public GClass2759.GClass2808 To;
	}
}
