using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.UI;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x02002C52 RID: 11346
public abstract class GClass3075<T, U> : IDisposable, IEnumerable, IEnumerable<KeyValuePair<T, U>> where U : IUIView
{
	// Token: 0x1700270D RID: 9997
	// (get) Token: 0x0600DF99 RID: 57241 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600DF9A RID: 57242 RVA: 0x00002050 File Offset: 0x00000250
	private bool Boolean_0
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x1700270E RID: 9998
	[CanBeNull]
	public U this[T item]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x14000313 RID: 787
	// (add) Token: 0x0600DF9C RID: 57244 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600DF9D RID: 57245 RVA: 0x00002050 File Offset: 0x00000250
	protected event Action Event_0
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

	// Token: 0x0600DF9E RID: 57246 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int IndexOf(U view)
	{
		throw null;
	}

	// Token: 0x1700270F RID: 9999
	// (get) Token: 0x0600DF9F RID: 57247 RVA: 0x00002050 File Offset: 0x00000250
	public List<T> Keys
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600DFA0 RID: 57248 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public U ViewAt(int index)
	{
		throw null;
	}

	// Token: 0x0600DFA1 RID: 57249 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private T method_0(int index)
	{
		throw null;
	}

	// Token: 0x17002710 RID: 10000
	// (get) Token: 0x0600DFA2 RID: 57250 RVA: 0x00002050 File Offset: 0x00000250
	public int Count
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600DFA3 RID: 57251 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_1(List<T> order, Func<T, U> itemViewFactory, Func<T, Transform> container, Action<T, U> showAction, bool destroyOnKill = true)
	{
		throw null;
	}

	// Token: 0x0600DFA4 RID: 57252 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected U method_2(U template)
	{
		throw null;
	}

	// Token: 0x0600DFA5 RID: 57253 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_3(T item)
	{
		throw null;
	}

	// Token: 0x0600DFA6 RID: 57254 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateItems(Action<U> updateAction)
	{
		throw null;
	}

	// Token: 0x0600DFA7 RID: 57255 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OrderByDescending<TKey>(Func<T, TKey> order)
	{
		throw null;
	}

	// Token: 0x0600DFA8 RID: 57256 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OrderBy<TKey>(Func<T, TKey> order, IComparer<TKey> comparer)
	{
		throw null;
	}

	// Token: 0x0600DFA9 RID: 57257 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateOrder(IEnumerable<T> orderedItems)
	{
		throw null;
	}

	// Token: 0x0600DFAA RID: 57258 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FilterBy(Func<T, bool> condition = null)
	{
		throw null;
	}

	// Token: 0x0600DFAB RID: 57259 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Any()
	{
		throw null;
	}

	// Token: 0x0600DFAC RID: 57260 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Contains(T key)
	{
		throw null;
	}

	// Token: 0x0600DFAD RID: 57261 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public KeyValuePair<T, U> Last()
	{
		throw null;
	}

	// Token: 0x0600DFAE RID: 57262 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public U Add(T item)
	{
		throw null;
	}

	// Token: 0x0600DFAF RID: 57263 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Remove(T item)
	{
		throw null;
	}

	// Token: 0x0600DFB0 RID: 57264 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(U view)
	{
		throw null;
	}

	// Token: 0x0600DFB1 RID: 57265 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator<KeyValuePair<T, U>> GetEnumerator()
	{
		throw null;
	}

	// Token: 0x0600DFB2 RID: 57266 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		throw null;
	}

	// Token: 0x0600DFB3 RID: 57267 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Clear()
	{
		throw null;
	}

	// Token: 0x0600DFB4 RID: 57268 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SoftDispose()
	{
		throw null;
	}

	// Token: 0x0600DFB5 RID: 57269 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Dispose()
	{
		throw null;
	}

	// Token: 0x0400E459 RID: 58457
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x0400E45A RID: 58458
	protected List<T> list_0;

	// Token: 0x0400E45B RID: 58459
	protected readonly Dictionary<T, U> dictionary_0;

	// Token: 0x0400E45C RID: 58460
	[CompilerGenerated]
	private Action action_0;

	// Token: 0x0400E45D RID: 58461
	private Func<T, U> func_0;

	// Token: 0x0400E45E RID: 58462
	private Func<T, Transform> func_1;

	// Token: 0x0400E45F RID: 58463
	private Action<T, U> action_1;

	// Token: 0x0400E460 RID: 58464
	private bool bool_1;

	// Token: 0x02002C53 RID: 11347
	[CompilerGenerated]
	private sealed class Class2700
	{
		// Token: 0x0600DFB6 RID: 57270 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(KeyValuePair<T, U> kvp)
		{
			throw null;
		}

		// Token: 0x0400E461 RID: 58465
		public U view;
	}
}
