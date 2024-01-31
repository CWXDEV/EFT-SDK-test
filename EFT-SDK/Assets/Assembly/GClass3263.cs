using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

// Token: 0x020030BB RID: 12475
public static class GClass3263
{
	// Token: 0x0600F4C8 RID: 62664 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IProgress<TResult> Select<TResult, TSource>([CanBeNull] this IProgress<TSource> progress, Func<TResult, TSource> selector)
	{
		throw null;
	}

	// Token: 0x020030BC RID: 12476
	[CompilerGenerated]
	private sealed class Class3147<T, U>
	{
		// Token: 0x0600F4C9 RID: 62665 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(T x)
		{
			throw null;
		}

		// Token: 0x0400FAD7 RID: 64215
		public IProgress<U> progress;

		// Token: 0x0400FAD8 RID: 64216
		public Func<T, U> selector;
	}
}
