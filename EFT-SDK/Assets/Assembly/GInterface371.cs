using System;
using EFT.HealthSystem;

// Token: 0x02002CD2 RID: 11474
public interface GInterface371 : IDisposable
{
	// Token: 0x17002748 RID: 10056
	// (get) Token: 0x0600E1A2 RID: 57762
	EHealthFactorType FactorType { get; }

	// Token: 0x17002749 RID: 10057
	// (get) Token: 0x0600E1A3 RID: 57763
	string TreatmentName { get; }

	// Token: 0x1700274A RID: 10058
	// (get) Token: 0x0600E1A4 RID: 57764
	float TreatmentCost { get; }

	// Token: 0x1700274B RID: 10059
	// (get) Token: 0x0600E1A5 RID: 57765
	bool Active { get; }

	// Token: 0x0600E1A6 RID: 57766
	void ApplyTreatment();

	// Token: 0x0600E1A7 RID: 57767
	void Store(TreatmentDataClass treatmentData, out float cost);

	// Token: 0x0600E1A8 RID: 57768
	Action Subscribe(Action handler);

	// Token: 0x0600E1A9 RID: 57769
	void Unsubscribe(Action handler);
}
