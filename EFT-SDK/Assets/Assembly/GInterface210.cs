using System;
using System.Collections.Generic;
using EFT.Vaulting.Models;

// Token: 0x02001ECB RID: 7883
public interface GInterface210
{
	// Token: 0x17001A92 RID: 6802
	// (get) Token: 0x0600A2EC RID: 41708
	VaultingPoint MaxWeightPoint { get; }

	// Token: 0x0600A2ED RID: 41709
	void CalculateWeights(List<VaultingPoint> hits);
}
