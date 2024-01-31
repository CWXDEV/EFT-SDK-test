using System;

// Token: 0x02001EE8 RID: 7912
public interface GInterface214
{
	// Token: 0x17001AC2 RID: 6850
	// (get) Token: 0x0600A379 RID: 41849
	bool CanMove { get; }

	// Token: 0x0600A37A RID: 41850
	void Recalculate(float velocityThreshold);

	// Token: 0x0600A37B RID: 41851
	void TryUnlock();

	// Token: 0x0600A37C RID: 41852
	void Reset();
}
