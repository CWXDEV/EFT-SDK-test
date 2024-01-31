using System;
using System.Collections.Generic;

// Token: 0x02000D83 RID: 3459
public interface GInterface60
{
	// Token: 0x17000B93 RID: 2963
	// (get) Token: 0x0600492D RID: 18733
	int Count { get; }

	// Token: 0x0600492E RID: 18734
	void Clear();

	// Token: 0x0600492F RID: 18735
	bool ContainsIndex(ushort index);

	// Token: 0x06004930 RID: 18736
	int GetNumPixels(ushort index);

	// Token: 0x06004931 RID: 18737
	ushort[] ToIndexArray();

	// Token: 0x06004932 RID: 18738
	List<KeyValuePair<ushort, int>> ToSamplesArray();

	// Token: 0x06004933 RID: 18739
	void UnionWith(GStruct74 result);
}
