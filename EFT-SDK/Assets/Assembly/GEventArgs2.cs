using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x02002478 RID: 9336
public class GEventArgs2 : GEventArgs1, GInterface315, GInterface316, GInterface317
{
	// Token: 0x0600BB98 RID: 48024 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override ItemAddress GetLocation()
	{
		throw null;
	}

	// Token: 0x0400BDED RID: 48621
	public readonly ItemAddress To;

	// Token: 0x0400BDEE RID: 48622
	public readonly bool Silent;

	// Token: 0x0400BDEF RID: 48623
	public readonly string ProfileId;
}
