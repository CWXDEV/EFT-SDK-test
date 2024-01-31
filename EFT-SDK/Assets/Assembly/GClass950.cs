using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Bsg.GameSettings;
using Diz.Binding;

// Token: 0x02000CFE RID: 3326
public sealed class GClass950<T> : IBindable<T>, GInterface46<T>
{
	// Token: 0x060046FE RID: 18174 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task<T> method_0(T t)
	{
		throw null;
	}

	// Token: 0x040051DC RID: 20956
	private readonly GameSetting<T> gameSetting_0;

	// Token: 0x040051DD RID: 20957
	private readonly Func<T, Task<T>> func_0;
	public Action Bind(Action<T> handler)
	{
		throw new NotImplementedException();
	}

	public Action Subscribe(Action<T> handler)
	{
		throw new NotImplementedException();
	}

	public Action BindWithoutValue(GInterface389 handler)
	{
		throw new NotImplementedException();
	}

	public T Value { get; }
	public Task<T> Set(T t)
	{
		throw new NotImplementedException();
	}
}
