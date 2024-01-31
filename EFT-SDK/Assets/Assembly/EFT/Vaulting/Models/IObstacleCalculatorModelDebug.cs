using System;

namespace EFT.Vaulting.Models
{
	// Token: 0x02001EC2 RID: 7874
	public interface IObstacleCalculatorModelDebug : GInterface206
	{
		// Token: 0x17001A78 RID: 6776
		// (get) Token: 0x0600A2BE RID: 41662
		// (set) Token: 0x0600A2BF RID: 41663
		float MaxHeightOffset { get; set; }

		// Token: 0x17001A79 RID: 6777
		// (get) Token: 0x0600A2C0 RID: 41664
		// (set) Token: 0x0600A2C1 RID: 41665
		float SlopedAreaThreshold { get; set; }

		// Token: 0x17001A7A RID: 6778
		// (get) Token: 0x0600A2C2 RID: 41666
		// (set) Token: 0x0600A2C3 RID: 41667
		float RectangleAreaThreshold { get; set; }
	}
}
