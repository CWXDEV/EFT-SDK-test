using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000F13 RID: 3859
public class GClass1091<T>
{
	// Token: 0x060050B9 RID: 20665 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public T Get()
	{
		throw null;
	}

	// Token: 0x060050BA RID: 20666 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Return(T item)
	{
		throw null;
	}

	// Token: 0x17000C9C RID: 3228
	// (get) Token: 0x060050BB RID: 20667 RVA: 0x00002050 File Offset: 0x00000250
	public int Count
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x04005D07 RID: 23815
	private readonly Stack<T> stack_0;

	// Token: 0x04005D08 RID: 23816
	private readonly Func<T> func_0;
}
