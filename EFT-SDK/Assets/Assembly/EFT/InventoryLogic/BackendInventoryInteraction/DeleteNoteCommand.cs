using System;
using Newtonsoft.Json;

namespace EFT.InventoryLogic.BackendInventoryInteraction
{
	// Token: 0x020025A1 RID: 9633
	[Serializable]
	public sealed class DeleteNoteCommand : GClass2830
	{
		// Token: 0x0400C219 RID: 49689
		[JsonProperty("Action")]
		public string Action;

		// Token: 0x0400C21A RID: 49690
		[JsonProperty("index")]
		public int Index;
	}
}
