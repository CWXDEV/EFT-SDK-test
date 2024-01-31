using System;
using System.Collections.Generic;
using EFT.Vaulting.Models;

// Token: 0x02001EBB RID: 7867
public interface GInterface204
{
	// Token: 0x17001A5F RID: 6751
	// (get) Token: 0x0600A293 RID: 41619
	List<VaultingPoint> ForwardWorldHitPoints { get; }

	// Token: 0x17001A60 RID: 6752
	// (get) Token: 0x0600A294 RID: 41620
	List<VaultingPoint> VerticalWorldHitPoints { get; }

	// Token: 0x17001A61 RID: 6753
	// (get) Token: 0x0600A295 RID: 41621
	List<VaultingPoint> AllWorldHitPoints { get; }

	// Token: 0x0600A296 RID: 41622
	void RecalculateGrid(GInterface202 data);

	// Token: 0x0600A297 RID: 41623
	void CalculateHitPoints();
}
