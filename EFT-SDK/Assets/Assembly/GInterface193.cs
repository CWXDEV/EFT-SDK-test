using System;

// Token: 0x02001E84 RID: 7812
public interface GInterface193 : GInterface194
{
	// Token: 0x14000205 RID: 517
	// (add) Token: 0x0600A068 RID: 41064
	// (remove) Token: 0x0600A069 RID: 41065
	event Action OnNeedUpdateData;

	// Token: 0x14000206 RID: 518
	// (add) Token: 0x0600A06A RID: 41066
	// (remove) Token: 0x0600A06B RID: 41067
	event Action OnClickSubmitButton;

	// Token: 0x14000207 RID: 519
	// (add) Token: 0x0600A06C RID: 41068
	// (remove) Token: 0x0600A06D RID: 41069
	event Action OnClickBackButton;

	// Token: 0x0600A06E RID: 41070
	void SetParameters(GStruct260 model);

	// Token: 0x0600A06F RID: 41071
	bool TryUpdateGridOptions(out GStruct260 model);
}
