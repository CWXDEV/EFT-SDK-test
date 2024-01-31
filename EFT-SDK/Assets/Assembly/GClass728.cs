using System;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.ObjectPool;

// Token: 0x020007A4 RID: 1956
public class GClass728<T> : IDisposable
{
	// Token: 0x1700080D RID: 2061
	// (get) Token: 0x06002D66 RID: 11622 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06002D67 RID: 11623 RVA: 0x00002050 File Offset: 0x00000250
	public int Size
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x1700080E RID: 2062
	// (get) Token: 0x06002D68 RID: 11624 RVA: 0x00002050 File Offset: 0x00000250
	public int ReservedSize
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06002D69 RID: 11625 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Dispose()
	{
		throw null;
	}

	// Token: 0x06002D6A RID: 11626 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Enqueue(T packet)
	{
		throw null;
	}

	// Token: 0x06002D6B RID: 11627 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual T Dequeue()
	{
		throw null;
	}

	// Token: 0x06002D6C RID: 11628 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public T Peek()
	{
		throw null;
	}

	// Token: 0x06002D6D RID: 11629 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public T PeekBack()
	{
		throw null;
	}

	// Token: 0x06002D6E RID: 11630 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryPeekBack(out T value)
	{
		throw null;
	}

	// Token: 0x06002D6F RID: 11631 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RemoveValues(int count)
	{
		throw null;
	}

	// Token: 0x06002D70 RID: 11632 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Clear()
	{
		throw null;
	}

	// Token: 0x1700080F RID: 2063
	public T this[int index]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x04002BF2 RID: 11250
	private ObjectPool<T[]> objectPool_0;

	// Token: 0x04002BF3 RID: 11251
	private T[] gparam_0;

	// Token: 0x04002BF4 RID: 11252
	private int int_0;

	// Token: 0x04002BF5 RID: 11253
	private int int_1;

	// Token: 0x04002BF6 RID: 11254
	[CompilerGenerated]
	private int int_2;
}
