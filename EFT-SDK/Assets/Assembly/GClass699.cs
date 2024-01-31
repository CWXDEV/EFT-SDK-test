using System;
using System.Runtime.CompilerServices;

// Token: 0x02000781 RID: 1921
public abstract class GClass699<T>
{
	// Token: 0x17000804 RID: 2052
	// (get) Token: 0x06002CC0 RID: 11456 RVA: 0x00002050 File Offset: 0x00000250
	public T Average
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06002CC1 RID: 11457 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddValue(T val)
	{
		throw null;
	}

	// Token: 0x06002CC2 RID: 11458
	protected abstract T Difference(T minuend, T subtrahend);

	// Token: 0x06002CC3 RID: 11459
	protected abstract T Summation(T summandL, T summandR);

	// Token: 0x06002CC4 RID: 11460
	protected abstract T Division(T dividend, int divisor);

	// Token: 0x04002B94 RID: 11156
	protected readonly T[] gparam_0;

	// Token: 0x04002B95 RID: 11157
	protected readonly int int_0;

	// Token: 0x04002B96 RID: 11158
	private T gparam_1;

	// Token: 0x04002B97 RID: 11159
	private T gparam_2;

	// Token: 0x04002B98 RID: 11160
	protected int int_1;

	// Token: 0x04002B99 RID: 11161
	protected bool bool_0;
}
