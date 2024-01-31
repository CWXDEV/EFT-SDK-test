using System;
using Comfort.Common;

// Token: 0x0200150E RID: 5390
public interface GInterface135 : GInterface123
{
	// Token: 0x060073DB RID: 29659
	void SetOnUsedCallback(Callback<GInterface135> callback);

	// Token: 0x060073DC RID: 29660
	Callback<GInterface135> GetOnUsedCallback();
}
