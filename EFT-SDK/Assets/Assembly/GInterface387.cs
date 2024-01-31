using System;

// Token: 0x020030E3 RID: 12515
public interface GInterface387<T>
{
	// Token: 0x0600F575 RID: 62837
	Action Subscribe(Action<T> handler);

	// Token: 0x0600F576 RID: 62838
	Action Bind(Action<T> handler, T defaultValue);
}
