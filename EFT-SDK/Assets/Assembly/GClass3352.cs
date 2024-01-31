using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020030E0 RID: 12512
public sealed class GClass3352<T, U> : IEnumerable, GInterface390<U>, IEnumerable<U>
{
	// Token: 0x0600F549 RID: 62793 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator<U> GetEnumerator()
	{
		throw null;
	}

	// Token: 0x0600F54A RID: 62794 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		throw null;
	}

	// Token: 0x14000370 RID: 880
	// (add) Token: 0x0600F54B RID: 62795 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600F54C RID: 62796 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<U> ItemAdded
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x14000371 RID: 881
	// (add) Token: 0x0600F54D RID: 62797 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600F54E RID: 62798 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<U> ItemRemoved
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x14000372 RID: 882
	// (add) Token: 0x0600F54F RID: 62799 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600F550 RID: 62800 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<IEnumerable<U>> ItemsAdded
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x14000373 RID: 883
	// (add) Token: 0x0600F551 RID: 62801 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600F552 RID: 62802 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<IEnumerable<U>> ItemsRemoved
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x14000374 RID: 884
	// (add) Token: 0x0600F553 RID: 62803 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600F554 RID: 62804 RVA: 0x00002050 File Offset: 0x00000250
	public event Action AllItemsRemoved
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x0400FB35 RID: 64309
	private readonly GClass3353<T, U> gclass3353_0;
}
