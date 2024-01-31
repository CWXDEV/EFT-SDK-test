using System;

namespace Diz.Binding
{
	// Token: 0x0200310D RID: 12557
	public interface IUpdatable<in T> where T : IUpdatable<T>
	{
		// Token: 0x0600F652 RID: 63058
		bool Compare(T other);

		// Token: 0x0600F653 RID: 63059
		void UpdateFromAnotherItem(T other);
	}
}
