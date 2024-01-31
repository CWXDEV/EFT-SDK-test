using System;

namespace EFT.Vaulting.Models
{
	// Token: 0x02001EA9 RID: 7849
	public interface IGridSettingsModelDebug
	{
		// Token: 0x170019EB RID: 6635
		// (get) Token: 0x0600A1C5 RID: 41413
		// (set) Token: 0x0600A1C6 RID: 41414
		float GridSizeX { get; set; }

		// Token: 0x170019EC RID: 6636
		// (get) Token: 0x0600A1C7 RID: 41415
		// (set) Token: 0x0600A1C8 RID: 41416
		float GridSizeY { get; set; }

		// Token: 0x170019ED RID: 6637
		// (get) Token: 0x0600A1C9 RID: 41417
		// (set) Token: 0x0600A1CA RID: 41418
		float GridSizeZ { get; set; }

		// Token: 0x170019EE RID: 6638
		// (get) Token: 0x0600A1CB RID: 41419
		// (set) Token: 0x0600A1CC RID: 41420
		float SteppingLengthX { get; set; }

		// Token: 0x170019EF RID: 6639
		// (get) Token: 0x0600A1CD RID: 41421
		// (set) Token: 0x0600A1CE RID: 41422
		float SteppingLengthY { get; set; }

		// Token: 0x170019F0 RID: 6640
		// (get) Token: 0x0600A1CF RID: 41423
		// (set) Token: 0x0600A1D0 RID: 41424
		float SteppingLengthZ { get; set; }

		// Token: 0x170019F1 RID: 6641
		// (get) Token: 0x0600A1D1 RID: 41425
		// (set) Token: 0x0600A1D2 RID: 41426
		float GridOffsetX { get; set; }

		// Token: 0x170019F2 RID: 6642
		// (get) Token: 0x0600A1D3 RID: 41427
		// (set) Token: 0x0600A1D4 RID: 41428
		float GridOffsetY { get; set; }

		// Token: 0x170019F3 RID: 6643
		// (get) Token: 0x0600A1D5 RID: 41429
		// (set) Token: 0x0600A1D6 RID: 41430
		float GridOffsetZ { get; set; }

		// Token: 0x170019F4 RID: 6644
		// (get) Token: 0x0600A1D7 RID: 41431
		// (set) Token: 0x0600A1D8 RID: 41432
		float OffsetFactor { get; set; }
	}
}
