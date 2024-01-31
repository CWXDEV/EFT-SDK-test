using System;
using Newtonsoft.Json;

namespace EFT.InventoryLogic.BackendInventoryInteraction
{
	// Token: 0x0200258A RID: 9610
	[Serializable]
	public sealed class RemoveCommand : GClass2830
	{
		// Token: 0x0400C1CB RID: 49611
		[JsonProperty("Action")]
		public string Action;

		// Token: 0x0400C1CC RID: 49612
		[JsonProperty("item")]
		public string Item;
	}
}
