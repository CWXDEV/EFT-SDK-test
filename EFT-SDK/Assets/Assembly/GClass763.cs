using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Diz.Binding;
using UnityEngine.Events;

// Token: 0x020007EE RID: 2030
public class GClass763 : IDisposable
{
	// Token: 0x17000830 RID: 2096
	// (get) Token: 0x06002EE9 RID: 12009 RVA: 0x00002050 File Offset: 0x00000250
	public CancellationToken CancellationToken
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06002EEA RID: 12010 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddDisposable(Action destroy)
	{
		throw null;
	}

	// Token: 0x06002EEB RID: 12011 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public T AddDisposable<T>(T disposable) where T : class, IDisposable
	{
		throw null;
	}

	// Token: 0x06002EEC RID: 12012 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisposeReference<T>(ref T disposable) where T : class, IDisposable
	{
		throw null;
	}

	// Token: 0x06002EED RID: 12013 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SubscribeEvent(UnityEvent unityEvent, UnityAction handler)
	{
		throw null;
	}

	// Token: 0x06002EEE RID: 12014 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SubscribeEvent<T>(UnityEvent<T> unityEvent, UnityAction<T> handler)
	{
		throw null;
	}

	// Token: 0x06002EEF RID: 12015 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SubscribeEvent(GInterface386 @event, Action handler)
	{
		throw null;
	}

	// Token: 0x06002EF0 RID: 12016 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SubscribeEvent<T>(GInterface387<T> @event, Action<T> handler)
	{
		throw null;
	}

	// Token: 0x06002EF1 RID: 12017 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BindEvent(GInterface386 @event, Action handler)
	{
		throw null;
	}

	// Token: 0x06002EF2 RID: 12018 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BindEvent<T>(GInterface387<T> @event, Action<T> handler, T defaultValue)
	{
		throw null;
	}

	// Token: 0x06002EF3 RID: 12019 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BindState<T>(IBindable<T> state, Action<T> handler)
	{
		throw null;
	}

	// Token: 0x06002EF4 RID: 12020 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SubscribeState<T>(IBindable<T> state, Action<T> handler)
	{
		throw null;
	}

	// Token: 0x06002EF5 RID: 12021 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x06002EF6 RID: 12022 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x04002E2D RID: 11821
	private Action action_0;

	// Token: 0x04002E2E RID: 11822
	private List<Action> list_0;

	// Token: 0x04002E2F RID: 11823
	private CancellationTokenSource cancellationTokenSource_0;

	// Token: 0x020007EF RID: 2031
	[CompilerGenerated]
	private sealed class Class413
	{
		// Token: 0x06002EF7 RID: 12023 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x04002E30 RID: 11824
		public UnityEvent unityEvent;

		// Token: 0x04002E31 RID: 11825
		public UnityAction handler;
	}

	// Token: 0x020007F0 RID: 2032
	[CompilerGenerated]
	private sealed class Class414<T>
	{
		// Token: 0x06002EF8 RID: 12024 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x04002E32 RID: 11826
		public UnityEvent<T> unityEvent;

		// Token: 0x04002E33 RID: 11827
		public UnityAction<T> handler;
	}
}
