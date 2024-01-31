using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Diz.Binding;
using JetBrains.Annotations;

// Token: 0x020030F5 RID: 12533
public abstract class GClass3369<T> : IBindable<T>
{
	// Token: 0x17002A4F RID: 10831
	// (get) Token: 0x0600F5E8 RID: 62952 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	public IReadOnlyList<Action<T>> Handlers
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002A50 RID: 10832
	// (get) Token: 0x0600F5E9 RID: 62953 RVA: 0x00002050 File Offset: 0x00000250
	public bool HasHandlers
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002A51 RID: 10833
	// (get) Token: 0x0600F5EA RID: 62954 RVA: 0x00002050 File Offset: 0x00000250
	public bool HasCheckChanges
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002A52 RID: 10834
	// (get) Token: 0x0600F5EB RID: 62955 RVA: 0x00002050 File Offset: 0x00000250
	private List<Action<T>> List_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002A53 RID: 10835
	// (get) Token: 0x0600F5EC RID: 62956 RVA: 0x00002050 File Offset: 0x00000250
	private List<GInterface389> List_1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002A54 RID: 10836
	// (get) Token: 0x0600F5ED RID: 62957 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600F5EE RID: 62958 RVA: 0x00002050 File Offset: 0x00000250
	public virtual T Value
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

	// Token: 0x0600F5EF RID: 62959 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Action Bind(Action<T> handler)
	{
		throw null;
	}

	// Token: 0x0600F5F0 RID: 62960 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Action Subscribe(Action<T> handler)
	{
		throw null;
	}

	// Token: 0x0600F5F1 RID: 62961 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Unbind(Action<T> handler)
	{
		throw null;
	}

	// Token: 0x0600F5F2 RID: 62962 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Action BindWithoutValue(GInterface389 handler)
	{
		throw null;
	}

	// Token: 0x0600F5F3 RID: 62963 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_0(T newState)
	{
		throw null;
	}

	// Token: 0x0600F5F4 RID: 62964 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_1(T newState)
	{
		throw null;
	}

	// Token: 0x0600F5F5 RID: 62965 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x0400FB6A RID: 64362
	protected T gparam_0;

	// Token: 0x0400FB6B RID: 64363
	private readonly IEqualityComparer<T> iequalityComparer_0;

	// Token: 0x0400FB6C RID: 64364
	private List<Action<T>> list_0;

	// Token: 0x0400FB6D RID: 64365
	private List<GInterface389> list_1;

	// Token: 0x0400FB6E RID: 64366
	private bool bool_0;

	// Token: 0x0400FB6F RID: 64367
	private readonly Queue<Action<T>> queue_0;

	// Token: 0x020030F6 RID: 12534
	[CompilerGenerated]
	private sealed class Class3166
	{
		// Token: 0x0600F5F6 RID: 62966 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x0400FB70 RID: 64368
		public GClass3369<T> gclass3369_0;

		// Token: 0x0400FB71 RID: 64369
		public Action<T> handler;
	}

	// Token: 0x020030F7 RID: 12535
	[CompilerGenerated]
	private sealed class Class3167
	{
		// Token: 0x0600F5F7 RID: 62967 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x0400FB72 RID: 64370
		public GClass3369<T> gclass3369_0;

		// Token: 0x0400FB73 RID: 64371
		public GInterface389 handler;
	}
}
