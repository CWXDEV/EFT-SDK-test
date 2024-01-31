using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02003167 RID: 12647
public abstract class GClass3393<T> : IEnumerable, ICollection<T>, IEnumerable<T> where T : class, GInterface397
{
	// Token: 0x17002AE1 RID: 10977
	// (get) Token: 0x0600F867 RID: 63591
	protected abstract string ItemTypeName { get; }

	// Token: 0x0600F868 RID: 63592 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(T item)
	{
		throw null;
	}

	// Token: 0x0600F869 RID: 63593 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetIndexByName(string name, out int result)
	{
		throw null;
	}

	// Token: 0x0600F86A RID: 63594 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Insert(int index, T item)
	{
		throw null;
	}

	// Token: 0x140003A4 RID: 932
	// (add) Token: 0x0600F86B RID: 63595 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600F86C RID: 63596 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<string, GInterface397> NameChanged
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x140003A5 RID: 933
	// (add) Token: 0x0600F86D RID: 63597 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600F86E RID: 63598 RVA: 0x00002050 File Offset: 0x00000250
	public event EventHandler OrderChanged
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x140003A6 RID: 934
	// (add) Token: 0x0600F86F RID: 63599 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600F870 RID: 63600 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<T> ItemRemoved
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x17002AE2 RID: 10978
	public T this[int index]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002AE3 RID: 10979
	public T this[string name]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600F873 RID: 63603 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(string prevName, GInterface397 item)
	{
		throw null;
	}

	// Token: 0x0600F874 RID: 63604 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		throw null;
	}

	// Token: 0x0600F875 RID: 63605 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Contains(T item)
	{
		throw null;
	}

	// Token: 0x0600F876 RID: 63606 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CopyTo(T[] array, int arrayIndex)
	{
		throw null;
	}

	// Token: 0x17002AE4 RID: 10980
	// (get) Token: 0x0600F877 RID: 63607 RVA: 0x00002050 File Offset: 0x00000250
	public int Count
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002AE5 RID: 10981
	// (get) Token: 0x0600F878 RID: 63608 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsReadOnly
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600F879 RID: 63609 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Remove(T item)
	{
		throw null;
	}

	// Token: 0x0600F87A RID: 63610 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator<T> GetEnumerator()
	{
		throw null;
	}

	// Token: 0x0600F87B RID: 63611 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		throw null;
	}

	// Token: 0x0400FD58 RID: 64856
	private Dictionary<string, T> dictionary_0;

	// Token: 0x0400FD59 RID: 64857
	private List<T> list_0;

	// Token: 0x0400FD5A RID: 64858
	[CompilerGenerated]
	private Action<string, GInterface397> action_0;

	// Token: 0x0400FD5B RID: 64859
	[CompilerGenerated]
	private EventHandler eventHandler_0;

	// Token: 0x0400FD5C RID: 64860
	[CompilerGenerated]
	private Action<T> action_1;
}
