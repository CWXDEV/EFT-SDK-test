using System;
using UnityEngine;

// Token: 0x02000BBE RID: 3006
public interface GInterface43
{
	// Token: 0x06004160 RID: 16736
	void ResetComponentsToDefaults();

	// Token: 0x06004161 RID: 16737
	void SortComponentsToTurnOff();

	// Token: 0x06004162 RID: 16738
	void EditorSetComponentsToTurnOff(Component[] components);

	// Token: 0x06004163 RID: 16739
	T[] GetComponentsInChildren<T>(bool includeInactive);

	// Token: 0x06004164 RID: 16740
	Component[] GetComponentsInChildren(Type t, bool includeInactive);
}
