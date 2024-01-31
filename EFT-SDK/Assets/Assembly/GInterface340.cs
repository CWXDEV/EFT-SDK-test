using System;
using System.Collections.Generic;

// Token: 0x02002603 RID: 9731
public interface GInterface340<T> where T : GInterface340<T>, IEnumerable<T>
{
	// Token: 0x17002281 RID: 8833
	// (get) Token: 0x0600C124 RID: 49444
	string Id { get; }

	// Token: 0x17002282 RID: 8834
	// (get) Token: 0x0600C125 RID: 49445
	T Parent { get; }

	// Token: 0x0600C126 RID: 49446
	bool TryGetChildById(string id, out T child);

	// Token: 0x17002283 RID: 8835
	// (get) Token: 0x0600C127 RID: 49447
	Dictionary<string, T>.ValueCollection Children { get; }
}
