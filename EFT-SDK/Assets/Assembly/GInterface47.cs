using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// Token: 0x02000CFF RID: 3327
public interface GInterface47<T> where T : GClass952<T>, new()
{
	// Token: 0x17000B52 RID: 2898
	// (get) Token: 0x060046FF RID: 18175
	IReadOnlyList<GClass951<T>> Presets { get; }

	// Token: 0x06004700 RID: 18176
	Task RefreshPresetList();

	// Token: 0x06004701 RID: 18177
	Task<GClass951<T>> CreateNewPreset(string name, T settingsGroup);

	// Token: 0x06004702 RID: 18178
	Task RemovePreset(GClass951<T> preset);
}
