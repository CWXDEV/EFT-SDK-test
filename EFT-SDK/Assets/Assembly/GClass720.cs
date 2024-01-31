using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x02000799 RID: 1945
public class GClass720<T, U>
{
	// Token: 0x17000808 RID: 2056
	// (get) Token: 0x06002D3F RID: 11583 RVA: 0x00002050 File Offset: 0x00000250
	public int Count
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06002D40 RID: 11584 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public U GetByKey(T key)
	{
		throw null;
	}

	// Token: 0x06002D41 RID: 11585 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsKey(T key)
	{
		throw null;
	}

	// Token: 0x06002D42 RID: 11586 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetByKey(T key, out U value)
	{
		throw null;
	}

	// Token: 0x06002D43 RID: 11587 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public U GetByIndex(int index)
	{
		throw null;
	}

	// Token: 0x06002D44 RID: 11588 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Add(T key, U value)
	{
		throw null;
	}

	// Token: 0x06002D45 RID: 11589 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(T key, U value)
	{
		throw null;
	}

	// Token: 0x06002D46 RID: 11590 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public U AddOrReplace(T key, U value)
	{
		throw null;
	}

	// Token: 0x06002D47 RID: 11591 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Remove(T key)
	{
		throw null;
	}

	// Token: 0x06002D48 RID: 11592 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		throw null;
	}

	// Token: 0x06002D49 RID: 11593 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<U> Where(Func<U, bool> predicate)
	{
		throw null;
	}

	// Token: 0x06002D4A RID: 11594 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass720<T, U>.GStruct41 GetValuesEnumerator()
	{
		throw null;
	}

	// Token: 0x04002BB5 RID: 11189
	private Dictionary<T, U> dictionary_0;

	// Token: 0x04002BB6 RID: 11190
	private List<U> list_0;

	// Token: 0x0200079A RID: 1946
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct41
	{
		// Token: 0x06002D4B RID: 11595 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<U>.Enumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x04002BB7 RID: 11191
		private List<U> list_0;
	}
}
