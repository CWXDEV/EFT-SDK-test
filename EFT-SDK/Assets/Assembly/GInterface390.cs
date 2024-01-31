using System;
using System.Collections;
using System.Collections.Generic;

// Token: 0x0200310C RID: 12556
public interface GInterface390<out T> : IEnumerable, IEnumerable<T>
{
	// Token: 0x14000395 RID: 917
	// (add) Token: 0x0600F648 RID: 63048
	// (remove) Token: 0x0600F649 RID: 63049
	event Action<T> ItemAdded;

	// Token: 0x14000396 RID: 918
	// (add) Token: 0x0600F64A RID: 63050
	// (remove) Token: 0x0600F64B RID: 63051
	event Action<T> ItemRemoved;

	// Token: 0x14000397 RID: 919
	// (add) Token: 0x0600F64C RID: 63052
	// (remove) Token: 0x0600F64D RID: 63053
	event Action<IEnumerable<T>> ItemsAdded;

	// Token: 0x14000398 RID: 920
	// (add) Token: 0x0600F64E RID: 63054
	// (remove) Token: 0x0600F64F RID: 63055
	event Action<IEnumerable<T>> ItemsRemoved;

	// Token: 0x14000399 RID: 921
	// (add) Token: 0x0600F650 RID: 63056
	// (remove) Token: 0x0600F651 RID: 63057
	event Action AllItemsRemoved;
}
