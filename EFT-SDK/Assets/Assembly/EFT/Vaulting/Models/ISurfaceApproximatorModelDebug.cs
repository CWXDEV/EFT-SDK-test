using System;
using System.Collections.Generic;

namespace EFT.Vaulting.Models
{
	// Token: 0x02001EB9 RID: 7865
	public interface ISurfaceApproximatorModelDebug
	{
		// Token: 0x17001A57 RID: 6743
		// (get) Token: 0x0600A27D RID: 41597
		// (set) Token: 0x0600A27E RID: 41598
		float Tolerance { get; set; }

		// Token: 0x17001A58 RID: 6744
		// (get) Token: 0x0600A27F RID: 41599
		List<VaultingPoint> ResultPoints { get; }

		// Token: 0x0600A280 RID: 41600
		List<VaultingPoint> Approximate(List<VaultingPoint> points);
	}
}
