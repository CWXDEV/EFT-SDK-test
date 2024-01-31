using System;
using System.Collections.Generic;

// Token: 0x020030ED RID: 12525
public interface GInterface388<T, U>
{
	// Token: 0x14000387 RID: 903
	// (add) Token: 0x0600F5BD RID: 62909
	// (remove) Token: 0x0600F5BE RID: 62910
	event Action<T, U> ItemAdded;

	// Token: 0x14000388 RID: 904
	// (add) Token: 0x0600F5BF RID: 62911
	// (remove) Token: 0x0600F5C0 RID: 62912
	event Action<T> ItemRemoved;

	// Token: 0x17002A48 RID: 10824
	// (get) Token: 0x0600F5C1 RID: 62913
	IEnumerable<KeyValuePair<T, U>> Items { get; }
}
