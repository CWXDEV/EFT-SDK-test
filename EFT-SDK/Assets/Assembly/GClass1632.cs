using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020014B2 RID: 5298
public static class GClass1632
{
	// Token: 0x060071B6 RID: 29110 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string CastToStringValue<T>(this IEnumerable<T> enumerable, string separator = "", bool localized = true)
	{
		throw null;
	}

	// Token: 0x060071B7 RID: 29111 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string ToCollectionStringValue<T>(this IEnumerable<T> enumerable, string separator = ",")
	{
		throw null;
	}

	// Token: 0x060071B8 RID: 29112 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T PickRandom<T>(this IEnumerable<T> enumerable)
	{
		throw null;
	}

	// Token: 0x060071B9 RID: 29113 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T PickRandom<T>(this IReadOnlyList<T> options)
	{
		throw null;
	}

	// Token: 0x060071BA RID: 29114 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddRange<T, S>(this IDictionary<T, S> source, IDictionary<T, S> collection)
	{
		throw null;
	}

	// Token: 0x060071BB RID: 29115 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool RemoveFirst<T>(this IList<T> source, Predicate<T> match)
	{
		throw null;
	}

	// Token: 0x020014B3 RID: 5299
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1115<T>
	{
		// Token: 0x060071BC RID: 29116 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_0(object x)
		{
			throw null;
		}

		// Token: 0x060071BD RID: 29117 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_1(object x)
		{
			throw null;
		}

		// Token: 0x04007848 RID: 30792
		public static readonly GClass1632.Class1115<T> class1115_0;

		// Token: 0x04007849 RID: 30793
		public static Func<object, string> func_0;

		// Token: 0x0400784A RID: 30794
		public static Func<object, string> func_1;
	}

	// Token: 0x020014B4 RID: 5300
	[CompilerGenerated]
	private sealed class Class1116<T>
	{
		// Token: 0x060071BE RID: 29118 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(T x)
		{
			throw null;
		}

		// Token: 0x0400784B RID: 30795
		public Predicate<T> match;
	}
}
