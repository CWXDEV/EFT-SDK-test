using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020025FF RID: 9727
public abstract class GClass2880<T> where T : GInterface340<T>, IEnumerable<T>
{
	// Token: 0x1700227B RID: 8827
	// (get) Token: 0x0600C117 RID: 49431
	protected abstract T RootNode { get; }

	// Token: 0x0600C118 RID: 49432 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsChildOf(string testId, string parentId)
	{
		throw null;
	}

	// Token: 0x0600C119 RID: 49433
	public abstract bool IsCategory(string testId);

	// Token: 0x1700227C RID: 8828
	// (get) Token: 0x0600C11A RID: 49434
	protected abstract Dictionary<string, T> AllNodes { get; }

	// Token: 0x0600C11B RID: 49435 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static T smethod_0(T parentNode, string childId)
	{
		throw null;
	}

	// Token: 0x0600C11C RID: 49436 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static IEnumerable<T> smethod_1(T node)
	{
		throw null;
	}
}
