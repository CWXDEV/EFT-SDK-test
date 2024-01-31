using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x0200248F RID: 9359
public class GEventArgs20 : GEventArgs1, GInterface317
{
	// Token: 0x0600BB9B RID: 48027 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override ItemAddress GetLocation()
	{
		throw null;
	}

	// Token: 0x0400BE15 RID: 48661
	public readonly ItemAddress To;

	// Token: 0x0400BE16 RID: 48662
	public readonly bool Silent;

	// Token: 0x0400BE17 RID: 48663
	public readonly string ProfileId;
}
