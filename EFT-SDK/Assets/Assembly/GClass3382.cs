using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02003109 RID: 12553
public sealed class GClass3382<T, U> : IEnumerable, GInterface390<GClass3381<T>>, IEnumerable<GClass3381<T>>
{
	// Token: 0x1400038B RID: 907
	// (add) Token: 0x0600F624 RID: 63012 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600F625 RID: 63013 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GClass3381<T>> ItemAdded
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

	// Token: 0x1400038C RID: 908
	// (add) Token: 0x0600F626 RID: 63014 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600F627 RID: 63015 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GClass3381<T>> ItemRemoved
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

	// Token: 0x1400038D RID: 909
	// (add) Token: 0x0600F628 RID: 63016 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600F629 RID: 63017 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<IEnumerable<GClass3381<T>>> ItemsAdded
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

	// Token: 0x1400038E RID: 910
	// (add) Token: 0x0600F62A RID: 63018 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600F62B RID: 63019 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<IEnumerable<GClass3381<T>>> ItemsRemoved
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

	// Token: 0x1400038F RID: 911
	// (add) Token: 0x0600F62C RID: 63020 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600F62D RID: 63021 RVA: 0x00002050 File Offset: 0x00000250
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

	// Token: 0x0600F62E RID: 63022 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator<GClass3381<T>> GetEnumerator()
	{
		throw null;
	}

	// Token: 0x0600F62F RID: 63023 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		throw null;
	}

	// Token: 0x0400FBB4 RID: 64436
	[CompilerGenerated]
	private Action<GClass3381<T>> action_0;

	// Token: 0x0400FBB5 RID: 64437
	[CompilerGenerated]
	private Action<GClass3381<T>> action_1;

	// Token: 0x0400FBB6 RID: 64438
	[CompilerGenerated]
	private Action<IEnumerable<GClass3381<T>>> action_2;

	// Token: 0x0400FBB7 RID: 64439
	[CompilerGenerated]
	private Action<IEnumerable<GClass3381<T>>> action_3;

	// Token: 0x0400FBB8 RID: 64440
	[CompilerGenerated]
	private Action action_4;

	// Token: 0x0400FBB9 RID: 64441
	private readonly Dictionary<U, GClass3381<T>> dictionary_0;

	// Token: 0x0200310A RID: 12554
	[CompilerGenerated]
	private sealed class Class3170
	{
		// Token: 0x0600F630 RID: 63024 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(T element)
		{
			throw null;
		}

		// Token: 0x0600F631 RID: 63025 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(T element)
		{
			throw null;
		}

		// Token: 0x0600F632 RID: 63026 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2(IEnumerable<T> elements)
		{
			throw null;
		}

		// Token: 0x0600F633 RID: 63027 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_3(IEnumerable<T> elements)
		{
			throw null;
		}

		// Token: 0x0400FBBA RID: 64442
		public Func<T, U> keySelector;

		// Token: 0x0400FBBB RID: 64443
		public GClass3382<T, U> gclass3382_0;
	}
}
