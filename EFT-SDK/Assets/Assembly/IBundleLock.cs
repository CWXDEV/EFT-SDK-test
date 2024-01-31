using System;

// Token: 0x02003113 RID: 12563
public interface IBundleLock
{
	// Token: 0x17002A58 RID: 10840
	// (get) Token: 0x0600F65A RID: 63066
	bool IsLocked { get; }

	// Token: 0x0600F65B RID: 63067
	void Lock();

	// Token: 0x0600F65C RID: 63068
	void Unlock();
}
