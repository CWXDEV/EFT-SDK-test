using System;
using System.Runtime.CompilerServices;
using Diz.Binding;

// Token: 0x020030FC RID: 12540
public class GClass3374<T, U, V, W> : GClass3371<W>, GInterface389
{
	// Token: 0x0600F603 RID: 62979 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckChanges()
	{
		throw null;
	}

	// Token: 0x0600F604 RID: 62980 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Connect()
	{
		throw null;
	}

	// Token: 0x0400FB7A RID: 64378
	private readonly IBindable<T> ibindable_0;

	// Token: 0x0400FB7B RID: 64379
	private readonly IBindable<U> ibindable_1;

	// Token: 0x0400FB7C RID: 64380
	private readonly IBindable<V> ibindable_2;

	// Token: 0x0400FB7D RID: 64381
	private readonly Func<T, U, V, W> func_0;
}
