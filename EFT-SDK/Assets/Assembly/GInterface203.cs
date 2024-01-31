using System;
using System.Collections.Generic;
using EFT.Vaulting.Models;

// Token: 0x02001EB8 RID: 7864
public interface GInterface203
{
	// Token: 0x17001A56 RID: 6742
	// (get) Token: 0x0600A27B RID: 41595
	float Tolerance { get; }

	// Token: 0x0600A27C RID: 41596
	List<VaultingPoint> Approximate(List<VaultingPoint> points);
}
