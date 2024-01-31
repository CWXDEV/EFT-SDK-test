using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

// Token: 0x020030B0 RID: 12464
public static class GClass3260
{
	// Token: 0x0600F4A6 RID: 62630 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> e)
	{
		throw null;
	}

	// Token: 0x0600F4A7 RID: 62631 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<T> Flatten<T>(this IEnumerable<T> e, Func<T, IEnumerable<T>> f)
	{
		throw null;
	}

	// Token: 0x0600F4A8 RID: 62632 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<T> FlattenWithoutArray<T>(this IEnumerable<T> e, Func<T, IEnumerable<T>> f)
	{
		throw null;
	}

	// Token: 0x0600F4A9 RID: 62633 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<T> FlattenDepthFirst<T>(this IEnumerable<T> e, Func<T, IEnumerable<T>> f)
	{
		throw null;
	}

	// Token: 0x0600F4AA RID: 62634 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<T> ToEnumerable<T>(this T val)
	{
		throw null;
	}

	// Token: 0x0600F4AB RID: 62635 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<T> Recurse<T>([CanBeNull] this T value, Func<T, T> recurse, Func<T, bool> condition)
	{
		throw null;
	}

	// Token: 0x0600F4AC RID: 62636 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<T> Distinct<T, TKey>(this IEnumerable<T> source, Func<T, TKey> keySelector)
	{
		throw null;
	}

	// Token: 0x0600F4AD RID: 62637 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T Random<T>(this IEnumerable<T> source)
	{
		throw null;
	}

	// Token: 0x020030B1 RID: 12465
	[CompilerGenerated]
	[Serializable]
	private sealed class Class3139<T>
	{
		// Token: 0x0600F4AE RID: 62638 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<T> method_0(IEnumerable<T> i)
		{
			throw null;
		}

		// Token: 0x0400FAB2 RID: 64178
		public static readonly GClass3260.Class3139<T> class3139_0;

		// Token: 0x0400FAB3 RID: 64179
		public static Func<IEnumerable<T>, IEnumerable<T>> func_0;
	}

	// Token: 0x020030B2 RID: 12466
	[CompilerGenerated]
	private sealed class Class3140<T>
	{
		// Token: 0x0600F4AF RID: 62639 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<T> method_0(T c)
		{
			throw null;
		}

		// Token: 0x0400FAB4 RID: 64180
		public Func<T, IEnumerable<T>> f;
	}

	// Token: 0x020030B3 RID: 12467
	[CompilerGenerated]
	private sealed class Class3141<T>
	{
		// Token: 0x0600F4B0 RID: 62640 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<T> method_0(T c)
		{
			throw null;
		}

		// Token: 0x0400FAB5 RID: 64181
		public Func<T, IEnumerable<T>> f;
	}

	// Token: 0x020030B4 RID: 12468
	[CompilerGenerated]
	private sealed class Class3142<T>
	{
		// Token: 0x0600F4B1 RID: 62641 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<T> method_0(T c)
		{
			throw null;
		}

		// Token: 0x0400FAB6 RID: 64182
		public Func<T, IEnumerable<T>> f;
	}
}
