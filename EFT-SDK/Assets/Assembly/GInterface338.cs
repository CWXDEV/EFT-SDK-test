using System;
using EFT.InventoryLogic;
using JetBrains.Annotations;

// Token: 0x020025A8 RID: 9640
public interface GInterface338 : GInterface336, GInterface337
{
	// Token: 0x17002247 RID: 8775
	// (get) Token: 0x0600C032 RID: 49202
	Item Item2 { get; }

	// Token: 0x17002248 RID: 8776
	// (get) Token: 0x0600C033 RID: 49203
	[CanBeNull]
	ItemAddress From2 { get; }

	// Token: 0x17002249 RID: 8777
	// (get) Token: 0x0600C034 RID: 49204
	[CanBeNull]
	ItemAddress To2 { get; }
}
