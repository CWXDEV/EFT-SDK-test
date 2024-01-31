using System;

// Token: 0x02000F7A RID: 3962
public interface GInterface74
{
	// Token: 0x17000D0B RID: 3339
	// (get) Token: 0x06005391 RID: 21393
	string Name { get; }

	// Token: 0x17000D0C RID: 3340
	// (get) Token: 0x06005392 RID: 21394
	double Average { get; }

	// Token: 0x17000D0D RID: 3341
	// (get) Token: 0x06005393 RID: 21395
	double LastValue { get; }

	// Token: 0x06005394 RID: 21396
	void AddMeasurement(GStruct97 measurementData);
}
