using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x020020B7 RID: 8375
[StructLayout(LayoutKind.Auto)]
public struct GStruct330<T> where T : struct
{
	// Token: 0x17001C94 RID: 7316
	// (get) Token: 0x0600AD3F RID: 44351 RVA: 0x00002050 File Offset: 0x00000250
	public int Length
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001C95 RID: 7317
	public T this[int index]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600AD41 RID: 44353 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(T item)
	{
		throw null;
	}

	// Token: 0x0600AD42 RID: 44354 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x0600AD43 RID: 44355 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ToShortString()
	{
		throw null;
	}

	// Token: 0x0400B39C RID: 45980
	private T? nullable_0;

	// Token: 0x0400B39D RID: 45981
	private List<T> list_0;

	// Token: 0x020020B8 RID: 8376
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1880
	{
		// Token: 0x0600AD44 RID: 44356 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_0(T x)
		{
			throw null;
		}

		// Token: 0x0400B39E RID: 45982
		public static readonly GStruct330<T>.Class1880 class1880_0;

		// Token: 0x0400B39F RID: 45983
		public static Func<T, string> func_0;
	}
}
