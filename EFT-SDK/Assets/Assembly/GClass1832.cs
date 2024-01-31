using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;

// Token: 0x02001816 RID: 6166
public abstract class GClass1832<T>
{
	// Token: 0x0600849C RID: 33948
	protected abstract Task<Result<T>> ExecuteOnce();

	// Token: 0x0600849D RID: 33949 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<Result<T>> Execute()
	{
		throw null;
	}

	// Token: 0x04008B64 RID: 35684
	protected readonly GInterface178 ginterface178_0;
}
