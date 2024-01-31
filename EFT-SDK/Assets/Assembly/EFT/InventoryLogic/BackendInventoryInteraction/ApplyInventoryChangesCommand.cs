using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EFT.InventoryLogic.BackendInventoryInteraction
{
	// Token: 0x0200258E RID: 9614
	[Serializable]
	public sealed class ApplyInventoryChangesCommand : GClass2829
	{
		// Token: 0x0400C1D8 RID: 49624
		[JsonProperty("Action")]
		public string Action;

		// Token: 0x0400C1D9 RID: 49625
		[JsonProperty("changedItems")]
		public IEnumerable<GClass1186> ChangedItems;
	}
}
