using System;

namespace Diz.Binding
{
	// Token: 0x020030F3 RID: 12531
	public interface IBindable<out T>
	{
		// Token: 0x0600F5DB RID: 62939
		Action Bind(Action<T> handler);

		// Token: 0x0600F5DC RID: 62940
		Action Subscribe(Action<T> handler);

		// Token: 0x0600F5DD RID: 62941
		Action BindWithoutValue(GInterface389 handler);

		// Token: 0x17002A4E RID: 10830
		// (get) Token: 0x0600F5DE RID: 62942
		T Value { get; }
	}
}
