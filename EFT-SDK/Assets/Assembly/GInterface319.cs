using System;
using EFT;

// Token: 0x020024B1 RID: 9393
public interface GInterface319
{
	// Token: 0x1700217F RID: 8575
	// (get) Token: 0x0600BC1E RID: 48158
	MongoID NextId { get; }

	// Token: 0x0600BC1F RID: 48159
	void RollBack();
}
