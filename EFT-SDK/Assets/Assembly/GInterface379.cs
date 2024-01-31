using System;
using EFT.UI;

// Token: 0x02002F21 RID: 12065
public interface GInterface379
{
	// Token: 0x14000352 RID: 850
	// (add) Token: 0x0600EE2A RID: 60970
	// (remove) Token: 0x0600EE2B RID: 60971
	event Action<PocketMapConfig> BundleReceived;

	// Token: 0x0600EE2C RID: 60972
	void RequestBundle(int scaleVariant);
}
