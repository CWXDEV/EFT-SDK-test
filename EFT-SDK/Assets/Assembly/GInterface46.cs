using System;
using System.Threading.Tasks;
using Diz.Binding;

// Token: 0x02000CFD RID: 3325
public interface GInterface46<T> : IBindable<T>
{
	// Token: 0x060046FD RID: 18173
	Task<T> Set(T t);
}
