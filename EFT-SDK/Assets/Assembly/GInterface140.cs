using System;

// Token: 0x0200161E RID: 5662
public interface GInterface140<T> : GInterface141<T> where T : GInterface140<T>
{
	// Token: 0x06007B4E RID: 31566
	bool TryUpdate(T source);
}
