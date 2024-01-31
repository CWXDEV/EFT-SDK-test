using System;

namespace EFT.Vaulting.Models
{
	// Token: 0x02001EA6 RID: 7846
	public interface IAutomaticVaultingModelDebug
	{
		// Token: 0x170019CD RID: 6605
		// (get) Token: 0x0600A195 RID: 41365
		// (set) Token: 0x0600A196 RID: 41366
		float MinVaultHeight { get; set; }

		// Token: 0x170019CE RID: 6606
		// (get) Token: 0x0600A197 RID: 41367
		// (set) Token: 0x0600A198 RID: 41368
		float MaxVaultHeight { get; set; }

		// Token: 0x170019CF RID: 6607
		// (get) Token: 0x0600A199 RID: 41369
		// (set) Token: 0x0600A19A RID: 41370
		float MinVaultLength { get; set; }

		// Token: 0x170019D0 RID: 6608
		// (get) Token: 0x0600A19B RID: 41371
		// (set) Token: 0x0600A19C RID: 41372
		float MaxVaultLength { get; set; }

		// Token: 0x170019D1 RID: 6609
		// (get) Token: 0x0600A19D RID: 41373
		// (set) Token: 0x0600A19E RID: 41374
		float MinClimbHeight { get; set; }

		// Token: 0x170019D2 RID: 6610
		// (get) Token: 0x0600A19F RID: 41375
		// (set) Token: 0x0600A1A0 RID: 41376
		float MaxClimbHeight { get; set; }

		// Token: 0x170019D3 RID: 6611
		// (get) Token: 0x0600A1A1 RID: 41377
		// (set) Token: 0x0600A1A2 RID: 41378
		float MinClimbLength { get; set; }

		// Token: 0x170019D4 RID: 6612
		// (get) Token: 0x0600A1A3 RID: 41379
		// (set) Token: 0x0600A1A4 RID: 41380
		float MaxClimbLength { get; set; }

		// Token: 0x170019D5 RID: 6613
		// (get) Token: 0x0600A1A5 RID: 41381
		// (set) Token: 0x0600A1A6 RID: 41382
		bool IsEnableAutoVault { get; set; }

		// Token: 0x170019D6 RID: 6614
		// (get) Token: 0x0600A1A7 RID: 41383
		// (set) Token: 0x0600A1A8 RID: 41384
		bool IsEnableAutoClimb { get; set; }
	}
}
