using System;
using System.Collections.Generic;

// Token: 0x02000D85 RID: 3461
public interface GInterface62
{
	// Token: 0x17000B94 RID: 2964
	// (get) Token: 0x06004937 RID: 18743
	int NumCells { get; }

	// Token: 0x17000B95 RID: 2965
	// (get) Token: 0x06004938 RID: 18744
	List<ushort>[] RawCells { get; }

	// Token: 0x17000B96 RID: 2966
	// (get) Token: 0x06004939 RID: 18745
	List<int>[] RawPixels { get; }

	// Token: 0x0600493A RID: 18746
	void Dispose();

	// Token: 0x0600493B RID: 18747
	void DisposeAt(int cellIndex);

	// Token: 0x0600493C RID: 18748
	List<ushort> GetCellData(int index);

	// Token: 0x0600493D RID: 18749
	List<int> GetPixelData(int index);

	// Token: 0x0600493E RID: 18750
	GStruct74 GetSample(int cellIndex);

	// Token: 0x0600493F RID: 18751
	void Remap(GDelegate29 remapDelegate);
}
