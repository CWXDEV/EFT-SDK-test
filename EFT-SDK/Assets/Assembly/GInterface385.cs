using System;
using System.Runtime.CompilerServices;

// Token: 0x020030D5 RID: 12501
public interface GInterface385 : INotifyCompletion
{
	// Token: 0x17002A29 RID: 10793
	// (get) Token: 0x0600F506 RID: 62726
	bool IsCompleted { get; }

	// Token: 0x0600F507 RID: 62727
	void GetResult();
}
