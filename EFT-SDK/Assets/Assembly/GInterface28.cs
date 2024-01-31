using System;

// Token: 0x020007F7 RID: 2039
public interface GInterface28<T> where T : GInterface27
{
	// Token: 0x06002F1D RID: 12061
	void Register(T component);

	// Token: 0x06002F1E RID: 12062
	void Unregister(T component);
}
