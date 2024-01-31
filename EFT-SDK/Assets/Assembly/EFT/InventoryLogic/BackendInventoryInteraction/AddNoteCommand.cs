using System;
using Newtonsoft.Json;

namespace EFT.InventoryLogic.BackendInventoryInteraction
{
	// Token: 0x0200259F RID: 9631
	[Serializable]
	public sealed class AddNoteCommand : GClass2830
	{
		// Token: 0x0400C214 RID: 49684
		[JsonProperty("Action")]
		public string Action;

		// Token: 0x0400C215 RID: 49685
		[JsonProperty("note")]
		public GClass2489 Note;
	}
}
