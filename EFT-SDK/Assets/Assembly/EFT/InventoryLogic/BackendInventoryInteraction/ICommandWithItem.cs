using System;
using Newtonsoft.Json;

namespace EFT.InventoryLogic.BackendInventoryInteraction
{
	// Token: 0x02002583 RID: 9603
	public interface ICommandWithItem
	{
		// Token: 0x1700223E RID: 8766
		// (get) Token: 0x0600C006 RID: 49158
		[JsonIgnore]
		string ItemTemplate { get; }
	}
}
