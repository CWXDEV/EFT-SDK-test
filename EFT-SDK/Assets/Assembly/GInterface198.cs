using System;

// Token: 0x02001EA5 RID: 7845
public interface GInterface198
{
	// Token: 0x170019C3 RID: 6595
	// (get) Token: 0x0600A18B RID: 41355
	float MinVaultHeight { get; }

	// Token: 0x170019C4 RID: 6596
	// (get) Token: 0x0600A18C RID: 41356
	float MaxVaultHeight { get; }

	// Token: 0x170019C5 RID: 6597
	// (get) Token: 0x0600A18D RID: 41357
	float MinVaultLength { get; }

	// Token: 0x170019C6 RID: 6598
	// (get) Token: 0x0600A18E RID: 41358
	float MaxVaultLength { get; }

	// Token: 0x170019C7 RID: 6599
	// (get) Token: 0x0600A18F RID: 41359
	float MinClimbHeight { get; }

	// Token: 0x170019C8 RID: 6600
	// (get) Token: 0x0600A190 RID: 41360
	float MaxClimbHeight { get; }

	// Token: 0x170019C9 RID: 6601
	// (get) Token: 0x0600A191 RID: 41361
	float MinClimbLength { get; }

	// Token: 0x170019CA RID: 6602
	// (get) Token: 0x0600A192 RID: 41362
	float MaxClimbLength { get; }

	// Token: 0x170019CB RID: 6603
	// (get) Token: 0x0600A193 RID: 41363
	bool IsEnableAutoVault { get; }

	// Token: 0x170019CC RID: 6604
	// (get) Token: 0x0600A194 RID: 41364
	bool IsEnableAutoClimb { get; }
}
