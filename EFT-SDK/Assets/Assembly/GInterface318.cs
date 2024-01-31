using System;

// Token: 0x020024AC RID: 9388
public interface GInterface318
{
	// Token: 0x1700217E RID: 8574
	// (get) Token: 0x0600BC11 RID: 48145
	int Health { get; }

	// Token: 0x0600BC12 RID: 48146
	void RemoveBleeding();

	// Token: 0x0600BC13 RID: 48147
	void RestoreHealth(int restoreHealthAmount);
}
