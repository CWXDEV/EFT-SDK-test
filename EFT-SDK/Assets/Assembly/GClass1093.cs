using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000F1B RID: 3867
public class GClass1093<T> : IEnumerable, IEnumerable<T>
{
	// Token: 0x17000C9E RID: 3230
	// (get) Token: 0x06005113 RID: 20755 RVA: 0x00002050 File Offset: 0x00000250
	public int Capacity
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000C9F RID: 3231
	// (get) Token: 0x06005114 RID: 20756 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsFull
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000CA0 RID: 3232
	// (get) Token: 0x06005115 RID: 20757 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsEmpty
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000CA1 RID: 3233
	// (get) Token: 0x06005116 RID: 20758 RVA: 0x00002050 File Offset: 0x00000250
	public int Size
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06005117 RID: 20759 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public T Front()
	{
		throw null;
	}

	// Token: 0x06005118 RID: 20760 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public T Back()
	{
		throw null;
	}

	// Token: 0x17000CA2 RID: 3234
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

	// Token: 0x0600511B RID: 20763 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PushBack(T item)
	{
		throw null;
	}

	// Token: 0x0600511C RID: 20764 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PushFront(T item)
	{
		throw null;
	}

	// Token: 0x0600511D RID: 20765 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PopBack()
	{
		throw null;
	}

	// Token: 0x0600511E RID: 20766 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PopFront()
	{
		throw null;
	}

	// Token: 0x0600511F RID: 20767 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		throw null;
	}

	// Token: 0x06005120 RID: 20768 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public T[] ToArray()
	{
		throw null;
	}

	// Token: 0x06005121 RID: 20769 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IList<ArraySegment<T>> ToArraySegments()
	{
		throw null;
	}

	// Token: 0x06005122 RID: 20770 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator<T> GetEnumerator()
	{
		throw null;
	}

	// Token: 0x06005123 RID: 20771 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		throw null;
	}

	// Token: 0x06005124 RID: 20772 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(string message = "Cannot access an empty buffer.")
	{
		throw null;
	}

	// Token: 0x06005125 RID: 20773 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(ref int index)
	{
		throw null;
	}

	// Token: 0x06005126 RID: 20774 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(ref int index)
	{
		throw null;
	}

	// Token: 0x06005127 RID: 20775 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int method_3(int index)
	{
		throw null;
	}

	// Token: 0x06005128 RID: 20776 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private ArraySegment<T> method_4()
	{
		throw null;
	}

	// Token: 0x06005129 RID: 20777 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private ArraySegment<T> method_5()
	{
		throw null;
	}

	// Token: 0x04005D49 RID: 23881
	private readonly T[] gparam_0;

	// Token: 0x04005D4A RID: 23882
	private int int_0;

	// Token: 0x04005D4B RID: 23883
	private int int_1;

	// Token: 0x04005D4C RID: 23884
	private int int_2;
}
