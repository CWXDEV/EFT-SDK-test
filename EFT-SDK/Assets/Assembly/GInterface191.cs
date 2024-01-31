using System;

// Token: 0x02001E80 RID: 7808
public interface GInterface191 : GInterface194
{
	// Token: 0x140001F8 RID: 504
	// (add) Token: 0x0600A02F RID: 41007
	// (remove) Token: 0x0600A030 RID: 41008
	event Action OnClickSubmitButtonEvent;

	// Token: 0x140001F9 RID: 505
	// (add) Token: 0x0600A031 RID: 41009
	// (remove) Token: 0x0600A032 RID: 41010
	event Action OnClickBackButtonEvent;

	// Token: 0x0600A033 RID: 41011
	void SetParameters(GStruct258 model);

	// Token: 0x0600A034 RID: 41012
	bool TryToApplyParameters(out GStruct258 newModel);
}
