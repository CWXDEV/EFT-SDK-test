using System;
using System.Collections.Generic;
using Diz.DependencyManager;

// Token: 0x02003129 RID: 12585
public interface GInterface395
{
	// Token: 0x17002A68 RID: 10856
	// (get) Token: 0x0600F6A5 RID: 63141
	BindableState<ELoadState> LoadState { get; }

	// Token: 0x0600F6A6 RID: 63142
	void Load();

	// Token: 0x0600F6A7 RID: 63143
	void Unload();

	// Token: 0x17002A69 RID: 10857
	// (get) Token: 0x0600F6A8 RID: 63144
	float Progress { get; }

	// Token: 0x17002A6A RID: 10858
	// (get) Token: 0x0600F6A9 RID: 63145
	string Key { get; }

	// Token: 0x17002A6B RID: 10859
	// (get) Token: 0x0600F6AA RID: 63146
	IEnumerable<string> DependencyKeys { get; }
}
