using System;
using System.Runtime.CompilerServices;

// Token: 0x02000780 RID: 1920
public abstract class GClass700<T> : GClass699<T>
{
	// Token: 0x17000802 RID: 2050
	// (get) Token: 0x06002CBB RID: 11451 RVA: 0x00002050 File Offset: 0x00000250
	public T Min
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000803 RID: 2051
	// (get) Token: 0x06002CBC RID: 11452 RVA: 0x00002050 File Offset: 0x00000250
	public T Max
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06002CBD RID: 11453 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void AddValue(T val)
	{
		throw null;
	}

	// Token: 0x06002CBE RID: 11454
	public abstract bool IsGreaterOrEqual(T rhs, T lhs);

	// Token: 0x06002CBF RID: 11455
	public abstract bool IsLessOrEqual(T rhs, T lhs);

	// Token: 0x04002B92 RID: 11154
	private int int_2;

	// Token: 0x04002B93 RID: 11155
	private int int_3;
}
