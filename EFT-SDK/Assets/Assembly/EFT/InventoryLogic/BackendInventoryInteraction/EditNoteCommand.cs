using System;
using Newtonsoft.Json;

namespace EFT.InventoryLogic.BackendInventoryInteraction
{
	// Token: 0x020025A0 RID: 9632
	[Serializable]
	public sealed class EditNoteCommand : GClass2830
	{
		// Token: 0x0400C216 RID: 49686
		[JsonProperty("Action")]
		public string Action;

		// Token: 0x0400C217 RID: 49687
		[JsonProperty("index")]
		public int Index;

		// Token: 0x0400C218 RID: 49688
		[JsonProperty("note")]
		public GClass2489 Note;
	}
}
