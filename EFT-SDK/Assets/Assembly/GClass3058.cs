using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.UI;

// Token: 0x02002B63 RID: 11107
public abstract class GClass3058<T> : GInterface368 where T : UIElement
{
	// Token: 0x0600DB99 RID: 56217
	public abstract void Show();

	// Token: 0x0600DB9A RID: 56218 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Task<bool> TryHide()
	{
		throw null;
	}

	// Token: 0x0400DF5F RID: 57183
	protected readonly T gparam_0;
}
