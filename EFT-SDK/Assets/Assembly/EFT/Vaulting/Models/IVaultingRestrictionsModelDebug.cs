using System;

namespace EFT.Vaulting.Models
{
	// Token: 0x02001EAD RID: 7853
	public interface IVaultingRestrictionsModelDebug
	{
		// Token: 0x17001A0F RID: 6671
		// (get) Token: 0x0600A1FC RID: 41468
		// (set) Token: 0x0600A1FD RID: 41469
		float MinDistantToVault { get; set; }

		// Token: 0x17001A10 RID: 6672
		// (get) Token: 0x0600A1FE RID: 41470
		// (set) Token: 0x0600A1FF RID: 41471
		float MinVaultHeight { get; set; }

		// Token: 0x17001A11 RID: 6673
		// (get) Token: 0x0600A200 RID: 41472
		// (set) Token: 0x0600A201 RID: 41473
		float MaxVaultHeight { get; set; }

		// Token: 0x17001A12 RID: 6674
		// (get) Token: 0x0600A202 RID: 41474
		// (set) Token: 0x0600A203 RID: 41475
		float MinVaultLength { get; set; }

		// Token: 0x17001A13 RID: 6675
		// (get) Token: 0x0600A204 RID: 41476
		// (set) Token: 0x0600A205 RID: 41477
		float MaxVaultLength { get; set; }

		// Token: 0x17001A14 RID: 6676
		// (get) Token: 0x0600A206 RID: 41478
		// (set) Token: 0x0600A207 RID: 41479
		float MinClimbHeight { get; set; }

		// Token: 0x17001A15 RID: 6677
		// (get) Token: 0x0600A208 RID: 41480
		// (set) Token: 0x0600A209 RID: 41481
		float MaxClimbHeight { get; set; }

		// Token: 0x17001A16 RID: 6678
		// (get) Token: 0x0600A20A RID: 41482
		// (set) Token: 0x0600A20B RID: 41483
		float MinClimbLength { get; set; }

		// Token: 0x17001A17 RID: 6679
		// (get) Token: 0x0600A20C RID: 41484
		// (set) Token: 0x0600A20D RID: 41485
		float MaxClimbLength { get; set; }

		// Token: 0x17001A18 RID: 6680
		// (get) Token: 0x0600A20E RID: 41486
		float MaxVaultingHeight { get; }

		// Token: 0x17001A19 RID: 6681
		// (get) Token: 0x0600A20F RID: 41487
		float MaxVaultingLength { get; }

		// Token: 0x17001A1A RID: 6682
		// (get) Token: 0x0600A210 RID: 41488
		float MinVaultingHeight { get; }

		// Token: 0x17001A1B RID: 6683
		// (get) Token: 0x0600A211 RID: 41489
		float MinVaultingLength { get; }
	}
}
