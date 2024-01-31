using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020007B0 RID: 1968
public sealed class GClass737<T> : IDisposable
{
	// Token: 0x06002D8E RID: 11662 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public T Withdraw()
	{
		throw null;
	}

	// Token: 0x06002D8F RID: 11663 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Return(T t)
	{
		throw null;
	}

	// Token: 0x06002D90 RID: 11664 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x04002C1B RID: 11291
	private readonly Queue<T> queue_0;

	// Token: 0x04002C1C RID: 11292
	private readonly Func<T> func_0;

	// Token: 0x04002C1D RID: 11293
	private readonly Action<T> action_0;

	// Token: 0x04002C1E RID: 11294
	private readonly Action<T> action_1;
}
