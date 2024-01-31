using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02003059 RID: 12377
public abstract class GClass3248<T> : IEnumerable, IEnumerable<T>, IReadOnlyCollection<T> where T : class
{
	// Token: 0x170029C7 RID: 10695
	// (get) Token: 0x0600F332 RID: 62258 RVA: 0x00002050 File Offset: 0x00000250
	public int Count
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600F333 RID: 62259
	public abstract bool Contains(T template);

	// Token: 0x0600F334 RID: 62260
	public abstract void Remove(T template);

	// Token: 0x0600F335 RID: 62261 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Add(T template)
	{
		throw null;
	}

	// Token: 0x0600F336 RID: 62262 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddRange(IEnumerable<T> templates)
	{
		throw null;
	}

	// Token: 0x0600F337 RID: 62263 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		throw null;
	}

	// Token: 0x0600F338 RID: 62264 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator<T> GetEnumerator()
	{
		throw null;
	}

	// Token: 0x0600F339 RID: 62265 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		throw null;
	}

	// Token: 0x0400F977 RID: 63863
	protected readonly List<T> list_0;
}
