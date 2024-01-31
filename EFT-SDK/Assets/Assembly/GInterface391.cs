using System;
using System.Collections.Generic;
using Diz.Binding;

// Token: 0x0200310E RID: 12558
public interface GInterface391<T> where T : IUpdatable<T>
{
	// Token: 0x0600F654 RID: 63060
	void UpdateItems(ICollection<T> newItems);
}
