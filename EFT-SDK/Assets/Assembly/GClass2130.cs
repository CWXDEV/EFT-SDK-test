using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// Token: 0x02001E1A RID: 7706
[JsonConverter(typeof(GClass2129))]
public sealed class GClass2130<T> : IEnumerable, IEnumerable<T>, IReadOnlyList<T>, IReadOnlyCollection<T>, GInterface186 where T : IConvertible
{
	// Token: 0x1700191E RID: 6430
	// (get) Token: 0x06009E66 RID: 40550 RVA: 0x00002050 File Offset: 0x00000250
	public int Count
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700191F RID: 6431
	// (get) Token: 0x06009E67 RID: 40551 RVA: 0x00002050 File Offset: 0x00000250
	public int Length
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001920 RID: 6432
	public T this[int index]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06009E69 RID: 40553 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface186.Deserialize(JArray jArray)
	{
		throw null;
	}

	// Token: 0x06009E6A RID: 40554 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator<T> GetEnumerator()
	{
		throw null;
	}

	// Token: 0x06009E6B RID: 40555 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	IEnumerator IEnumerable.GetEnumerator()
	{
		throw null;
	}

	// Token: 0x0400A69D RID: 42653
	private readonly List<T> list_0;
}
