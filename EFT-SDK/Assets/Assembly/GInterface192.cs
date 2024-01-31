using System;

// Token: 0x02001E82 RID: 7810
public interface GInterface192 : GInterface194
{
	// Token: 0x140001FE RID: 510
	// (add) Token: 0x0600A04C RID: 41036
	// (remove) Token: 0x0600A04D RID: 41037
	event Action<bool> OnClickAutomaticVaultToggle;

	// Token: 0x140001FF RID: 511
	// (add) Token: 0x0600A04E RID: 41038
	// (remove) Token: 0x0600A04F RID: 41039
	event Action<bool> OnClickAutomaticClimbToggle;

	// Token: 0x14000200 RID: 512
	// (add) Token: 0x0600A050 RID: 41040
	// (remove) Token: 0x0600A051 RID: 41041
	event Action OnClickBackButton;

	// Token: 0x14000201 RID: 513
	// (add) Token: 0x0600A052 RID: 41042
	// (remove) Token: 0x0600A053 RID: 41043
	event Action OnClickSublitButton;

	// Token: 0x0600A054 RID: 41044
	void SetParameters(GStruct259 model);

	// Token: 0x0600A055 RID: 41045
	bool TryUpdateGridOptions(out GStruct259 model);
}
