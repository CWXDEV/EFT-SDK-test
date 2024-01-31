using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Diz.Binding;
using JetBrains.Annotations;

// Token: 0x020030E1 RID: 12513
public class GClass3353<T, U> : IEnumerable, IEnumerable<KeyValuePair<T, U>>, IDictionary<T, U>, ICollection<KeyValuePair<T, U>>
{
	// Token: 0x14000375 RID: 885
	// (add) Token: 0x0600F555 RID: 62805 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600F556 RID: 62806 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<U> ItemAdded
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

	// Token: 0x14000376 RID: 886
	// (add) Token: 0x0600F557 RID: 62807 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600F558 RID: 62808 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<U> ItemRemoved
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

	// Token: 0x14000377 RID: 887
	// (add) Token: 0x0600F559 RID: 62809 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600F55A RID: 62810 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<IEnumerable<U>> ItemsAdded
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

	// Token: 0x14000378 RID: 888
	// (add) Token: 0x0600F55B RID: 62811 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600F55C RID: 62812 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<IEnumerable<U>> ItemsRemoved
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

	// Token: 0x14000379 RID: 889
	// (add) Token: 0x0600F55D RID: 62813 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600F55E RID: 62814 RVA: 0x00002050 File Offset: 0x00000250
	public event Action AllItemsRemoved
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

	// Token: 0x17002A3F RID: 10815
	// (get) Token: 0x0600F55F RID: 62815 RVA: 0x00002050 File Offset: 0x00000250
	public ICollection<T> Keys
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002A40 RID: 10816
	// (get) Token: 0x0600F560 RID: 62816 RVA: 0x00002050 File Offset: 0x00000250
	public ICollection<U> Values
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002A41 RID: 10817
	// (get) Token: 0x0600F561 RID: 62817 RVA: 0x00002050 File Offset: 0x00000250
	public int Count
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002A42 RID: 10818
	// (get) Token: 0x0600F562 RID: 62818 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsReadOnly
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002A43 RID: 10819
	public virtual U this[T key]
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

	// Token: 0x0600F565 RID: 62821 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GInterface390<U> AsBindableList()
	{
		throw null;
	}

	// Token: 0x0600F566 RID: 62822 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool Remove(T existingItem)
	{
		throw null;
	}

	// Token: 0x0600F567 RID: 62823 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetValue(T key, out U value)
	{
		throw null;
	}

	// Token: 0x0600F568 RID: 62824 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsKey(T key)
	{
		throw null;
	}

	// Token: 0x0600F569 RID: 62825 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Add(T key, [CanBeNull] U value)
	{
		throw null;
	}

	// Token: 0x0600F56A RID: 62826 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddRange(IDictionary<T, U> dict)
	{
		throw null;
	}

	// Token: 0x0600F56B RID: 62827 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(KeyValuePair<T, U> item)
	{
		throw null;
	}

	// Token: 0x0600F56C RID: 62828 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Clear()
	{
		throw null;
	}

	// Token: 0x0600F56D RID: 62829 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Contains(KeyValuePair<T, U> item)
	{
		throw null;
	}

	// Token: 0x0600F56E RID: 62830 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CopyTo(KeyValuePair<T, U>[] array, int arrayIndex)
	{
		throw null;
	}

	// Token: 0x0600F56F RID: 62831 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Remove(KeyValuePair<T, U> item)
	{
		throw null;
	}

	// Token: 0x0600F570 RID: 62832 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator<KeyValuePair<T, U>> GetEnumerator()
	{
		throw null;
	}

	// Token: 0x0600F571 RID: 62833 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		throw null;
	}

	// Token: 0x0600F572 RID: 62834 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_0(KeyValuePair<T, U> item)
	{
		throw null;
	}

	// Token: 0x0400FB36 RID: 64310
	[CompilerGenerated]
	private Action<U> action_0;

	// Token: 0x0400FB37 RID: 64311
	[CompilerGenerated]
	private Action<U> action_1;

	// Token: 0x0400FB38 RID: 64312
	[CompilerGenerated]
	private Action<IEnumerable<U>> action_2;

	// Token: 0x0400FB39 RID: 64313
	[CompilerGenerated]
	private Action<IEnumerable<U>> action_3;

	// Token: 0x0400FB3A RID: 64314
	[CompilerGenerated]
	private Action action_4;

	// Token: 0x0400FB3B RID: 64315
	private readonly BindableEvent bindableEvent_0;

	// Token: 0x0400FB3C RID: 64316
	private readonly Dictionary<T, U> dictionary_0;

	// Token: 0x0400FB3D RID: 64317
	private GClass3352<T, U> gclass3352_0;
}
