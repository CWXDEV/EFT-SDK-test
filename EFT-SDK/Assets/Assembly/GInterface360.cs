using System;

// Token: 0x020028E9 RID: 10473
public interface GInterface360<in T> where T : Enum
{
	// Token: 0x0600D10A RID: 53514
	void TransitionToState(T state);

	// Token: 0x0600D10B RID: 53515
	void SetState(T state);

	// Token: 0x0600D10C RID: 53516
	void Stop();
}
