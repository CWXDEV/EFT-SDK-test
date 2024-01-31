using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

// Token: 0x02000F0E RID: 3854
public class GClass1087<T>
{
	// Token: 0x060050A8 RID: 20648 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public T Get()
	{
		throw null;
	}

	// Token: 0x060050A9 RID: 20649 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Return(T item)
	{
		throw null;
	}

	// Token: 0x17000C9B RID: 3227
	// (get) Token: 0x060050AA RID: 20650 RVA: 0x00002050 File Offset: 0x00000250
	public int Count
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x04005D00 RID: 23808
	private readonly ConcurrentBag<T> concurrentBag_0;

	// Token: 0x04005D01 RID: 23809
	private readonly Func<T> func_0;
}
