using System;
using System.Threading.Tasks;

// Token: 0x02002D11 RID: 11537
public interface GInterface375
{
	// Token: 0x170027AD RID: 10157
	// (get) Token: 0x0600E2DD RID: 58077
	Enum CurrentScreenType { get; }

	// Token: 0x0600E2DE RID: 58078
	Task<bool> CloseAllScreens(bool forced);

	// Token: 0x0600E2DF RID: 58079
	void CloseAllScreensForced();
}
