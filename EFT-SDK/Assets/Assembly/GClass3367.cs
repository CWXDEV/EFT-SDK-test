using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Diz.Binding;

// Token: 0x020030EE RID: 12526
public class GClass3367<T> : GInterface388<int, T>, GInterface391<T> where T : IUpdatable<T>
{
	// Token: 0x14000389 RID: 905
	// (add) Token: 0x0600F5C2 RID: 62914 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600F5C3 RID: 62915 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<int, T> ItemAdded
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

	// Token: 0x1400038A RID: 906
	// (add) Token: 0x0600F5C4 RID: 62916 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600F5C5 RID: 62917 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<int> ItemRemoved
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

	// Token: 0x17002A49 RID: 10825
	// (get) Token: 0x0600F5C6 RID: 62918 RVA: 0x00002050 File Offset: 0x00000250
	public IEnumerable<KeyValuePair<int, T>> Items
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600F5C7 RID: 62919 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(T value)
	{
		throw null;
	}

	// Token: 0x0600F5C8 RID: 62920 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Remove(T value)
	{
		throw null;
	}

	// Token: 0x0600F5C9 RID: 62921 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateItems(ICollection<T> newItems)
	{
		throw null;
	}

	// Token: 0x0600F5CA RID: 62922 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public T First()
	{
		throw null;
	}

	// Token: 0x0600F5CB RID: 62923 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public T Last()
	{
		throw null;
	}

	// Token: 0x0600F5CC RID: 62924 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator<T> GetEnumerator()
	{
		throw null;
	}

	// Token: 0x0600F5CD RID: 62925 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Contains(T item)
	{
		throw null;
	}

	// Token: 0x0400FB5A RID: 64346
	[CompilerGenerated]
	private Action<int, T> action_0;

	// Token: 0x0400FB5B RID: 64347
	[CompilerGenerated]
	private Action<int> action_1;

	// Token: 0x0400FB5C RID: 64348
	[NonSerialized]
	public BindableEvent OnItemsChanged;

	// Token: 0x0400FB5D RID: 64349
	private readonly SortedList<int, T> sortedList_0;

	// Token: 0x020030F0 RID: 12528
	[CompilerGenerated]
	private sealed class Class3163
	{
		// Token: 0x0600F5D4 RID: 62932 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(KeyValuePair<int, T> x)
		{
			throw null;
		}

		// Token: 0x0400FB64 RID: 64356
		public T newItem;
	}

	// Token: 0x020030F1 RID: 12529
	[CompilerGenerated]
	private sealed class Class3164
	{
		// Token: 0x0600F5D5 RID: 62933 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(T x)
		{
			throw null;
		}

		// Token: 0x0400FB65 RID: 64357
		public KeyValuePair<int, T> existingItem;
	}
}
