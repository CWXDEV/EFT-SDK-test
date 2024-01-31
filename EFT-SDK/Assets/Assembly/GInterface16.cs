using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// Token: 0x02000576 RID: 1398
public interface GInterface16
{
	// Token: 0x1700062F RID: 1583
	// (get) Token: 0x0600217F RID: 8575
	bool Destroyed { get; }

	// Token: 0x06002180 RID: 8576
	Task<GClass1203> GetTemplates(GClass1203 returnInCaseOfCache);

	// Token: 0x06002181 RID: 8577
	Task<Dictionary<string, GClass2932>> GetCustomizations();
}
