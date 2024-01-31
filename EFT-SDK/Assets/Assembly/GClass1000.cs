using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000D8A RID: 3466
public class GClass1000<T> : IEnumerable, IEnumerable<T>
{
	// Token: 0x17000B9B RID: 2971
	// (get) Token: 0x06004953 RID: 18771 RVA: 0x00002050 File Offset: 0x00000250
	public int Length
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000B9C RID: 2972
	// (get) Token: 0x06004954 RID: 18772 RVA: 0x00002050 File Offset: 0x00000250
	public T[] BufferCopy
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000B9D RID: 2973
	public T this[int i]
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

	// Token: 0x06004957 RID: 18775 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset()
	{
		throw null;
	}

	// Token: 0x06004958 RID: 18776 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator<T> GetEnumerator()
	{
		throw null;
	}

	// Token: 0x06004959 RID: 18777 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		throw null;
	}

	// Token: 0x04005499 RID: 21657
	public T[] buffer;

	// Token: 0x0400549A RID: 21658
	public int numIndices;

	// Token: 0x02000D8B RID: 3467
	private sealed class Class686 : IEnumerator, IDisposable, IEnumerator<T>
	{
		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x0600495A RID: 18778 RVA: 0x00002050 File Offset: 0x00000250
		object IEnumerator.Current
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600495B RID: 18779 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IDisposable.Dispose()
		{
			throw null;
		}

		// Token: 0x0600495C RID: 18780 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		bool IEnumerator.MoveNext()
		{
			throw null;
		}

		// Token: 0x0600495D RID: 18781 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IEnumerator.Reset()
		{
			throw null;
		}

		public T Current { get; }

		// Token: 0x0400549B RID: 21659
		private T[] gparam_0;

		// Token: 0x0400549C RID: 21660
		private int int_0;

		// Token: 0x0400549D RID: 21661
		private int int_1;
	}
}
