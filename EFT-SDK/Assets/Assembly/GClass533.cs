using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x02000507 RID: 1287
public class GClass533<T, U, V>
{
	// Token: 0x170005C8 RID: 1480
	public V this[U subKey]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170005C9 RID: 1481
	public V this[T primaryKey]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170005CA RID: 1482
	// (get) Token: 0x06001FA2 RID: 8098 RVA: 0x00002050 File Offset: 0x00000250
	public List<V> Values
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170005CB RID: 1483
	// (get) Token: 0x06001FA3 RID: 8099 RVA: 0x00002050 File Offset: 0x00000250
	public int Count
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06001FA4 RID: 8100 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Associate(U subKey, T primaryKey)
	{
		throw null;
	}

	// Token: 0x06001FA5 RID: 8101 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetValue(U subKey, out V val)
	{
		throw null;
	}

	// Token: 0x06001FA6 RID: 8102 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetValue(T primaryKey, out V val)
	{
		throw null;
	}

	// Token: 0x06001FA7 RID: 8103 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsKey(U subKey)
	{
		throw null;
	}

	// Token: 0x06001FA8 RID: 8104 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsKey(T primaryKey)
	{
		throw null;
	}

	// Token: 0x06001FA9 RID: 8105 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Remove(T primaryKey)
	{
		throw null;
	}

	// Token: 0x06001FAA RID: 8106 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Remove(U subKey)
	{
		throw null;
	}

	// Token: 0x06001FAB RID: 8107 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(T primaryKey, V val)
	{
		throw null;
	}

	// Token: 0x06001FAC RID: 8108 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(T primaryKey, U subKey, V val)
	{
		throw null;
	}

	// Token: 0x06001FAD RID: 8109 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public V[] CloneValues()
	{
		throw null;
	}

	// Token: 0x06001FAE RID: 8110 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public T[] ClonePrimaryKeys()
	{
		throw null;
	}

	// Token: 0x06001FAF RID: 8111 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public U[] CloneSubKeys()
	{
		throw null;
	}

	// Token: 0x06001FB0 RID: 8112 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		throw null;
	}

	// Token: 0x06001FB1 RID: 8113 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator<KeyValuePair<T, V>> GetEnumerator()
	{
		throw null;
	}

	// Token: 0x04001E1D RID: 7709
	private readonly Dictionary<T, V> dictionary_0;

	// Token: 0x04001E1E RID: 7710
	private readonly Dictionary<T, U> dictionary_1;

	// Token: 0x04001E1F RID: 7711
	private readonly Dictionary<U, T> dictionary_2;

	// Token: 0x04001E20 RID: 7712
	private readonly ReaderWriterLockSlim readerWriterLockSlim_0;
}
