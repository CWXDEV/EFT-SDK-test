using System;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x020030B8 RID: 12472
public class GClass3261<T> : IProgress<T>
{
	// Token: 0x0600F4C2 RID: 62658 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Report(T value)
	{
		throw null;
	}

	// Token: 0x0400FACE RID: 64206
	private readonly Action<T> action_0;

	// Token: 0x0400FACF RID: 64207
	private readonly CancellationToken cancellationToken_0;
}
