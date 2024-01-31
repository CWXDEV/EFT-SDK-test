using System;

// Token: 0x02001EC6 RID: 7878
public interface GInterface208
{
	// Token: 0x17001A81 RID: 6785
	// (get) Token: 0x0600A2CC RID: 41676
	float MinVaultingHeight { get; }

	// Token: 0x17001A82 RID: 6786
	// (get) Token: 0x0600A2CD RID: 41677
	float MaxVaultingHeight { get; }

	// Token: 0x17001A83 RID: 6787
	// (get) Token: 0x0600A2CE RID: 41678
	float MinVaultingLength { get; }

	// Token: 0x17001A84 RID: 6788
	// (get) Token: 0x0600A2CF RID: 41679
	float MaxVaultingLength { get; }

	// Token: 0x17001A85 RID: 6789
	// (get) Token: 0x0600A2D0 RID: 41680
	GInterface189 VaultState { get; }

	// Token: 0x17001A86 RID: 6790
	// (get) Token: 0x0600A2D1 RID: 41681
	GInterface189 ClimbState { get; }
}
