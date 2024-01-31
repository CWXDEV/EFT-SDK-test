using System;
using EFT;

// Token: 0x02002CD3 RID: 11475
public interface GInterface372 : IDisposable, GInterface371
{
	// Token: 0x1700274C RID: 10060
	// (get) Token: 0x0600E1AA RID: 57770
	float ValueToHeal { get; }

	// Token: 0x0600E1AB RID: 57771
	GInterface372 Clone(Profile profile, HealthControllerClass healthController, Profile.TraderInfo traderInfo);
}
