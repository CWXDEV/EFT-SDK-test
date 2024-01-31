using System;
using System.Runtime.CompilerServices;
using Diz.Binding;

// Token: 0x020030FB RID: 12539
public class GClass3373<T, U, V> : GClass3371<V>, GInterface389
{
	// Token: 0x0600F601 RID: 62977 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckChanges()
	{
		throw null;
	}

	// Token: 0x0600F602 RID: 62978 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Connect()
	{
		throw null;
	}

	// Token: 0x0400FB77 RID: 64375
	private readonly IBindable<T> ibindable_0;

	// Token: 0x0400FB78 RID: 64376
	private readonly IBindable<U> ibindable_1;

	// Token: 0x0400FB79 RID: 64377
	private readonly Func<T, U, V> func_0;
}
