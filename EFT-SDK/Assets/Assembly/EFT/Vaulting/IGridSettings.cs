using System;

namespace EFT.Vaulting
{
	// Token: 0x02001E58 RID: 7768
	public interface IGridSettings
	{
		// Token: 0x17001945 RID: 6469
		// (get) Token: 0x06009F4B RID: 40779
		float GridSizeX { get; }

		// Token: 0x17001946 RID: 6470
		// (get) Token: 0x06009F4C RID: 40780
		float GridSizeY { get; }

		// Token: 0x17001947 RID: 6471
		// (get) Token: 0x06009F4D RID: 40781
		float GridSizeZ { get; }

		// Token: 0x17001948 RID: 6472
		// (get) Token: 0x06009F4E RID: 40782
		float SteppingLengthX { get; }

		// Token: 0x17001949 RID: 6473
		// (get) Token: 0x06009F4F RID: 40783
		float SteppingLengthY { get; }

		// Token: 0x1700194A RID: 6474
		// (get) Token: 0x06009F50 RID: 40784
		float SteppingLengthZ { get; }

		// Token: 0x1700194B RID: 6475
		// (get) Token: 0x06009F51 RID: 40785
		float GridOffsetX { get; }

		// Token: 0x1700194C RID: 6476
		// (get) Token: 0x06009F52 RID: 40786
		float GridOffsetY { get; }

		// Token: 0x1700194D RID: 6477
		// (get) Token: 0x06009F53 RID: 40787
		float GridOffsetZ { get; }

		// Token: 0x1700194E RID: 6478
		// (get) Token: 0x06009F54 RID: 40788
		float OffsetFactor { get; }
	}
}
