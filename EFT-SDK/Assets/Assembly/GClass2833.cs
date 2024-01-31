using System;
using System.Runtime.CompilerServices;
using Comfort.Common;
using EFT.InventoryLogic;

// Token: 0x020025A5 RID: 9637
public abstract class GClass2833 : IDisposable, GInterface336
{
	// Token: 0x17002240 RID: 8768
	// (get) Token: 0x0600C028 RID: 49192 RVA: 0x00002050 File Offset: 0x00000250
	protected IItemOwner IItemOwner_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600C029 RID: 49193
	internal abstract void vmethod_0(Callback callback, bool requiresExternalFinalization = false);

	// Token: 0x0600C02A RID: 49194
	public abstract void Dispose();

	// Token: 0x0600C02B RID: 49195 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x0400C220 RID: 49696
	public readonly ushort Id;

	// Token: 0x0400C221 RID: 49697
	protected TraderControllerClass gclass2754_0;

	// Token: 0x0400C222 RID: 49698
	protected CommandStatus commandStatus_0;

	// Token: 0x0400C223 RID: 49699
	internal readonly string string_0;
}
