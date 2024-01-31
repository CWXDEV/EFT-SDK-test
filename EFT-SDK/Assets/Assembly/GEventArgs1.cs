using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;

// Token: 0x02002477 RID: 9335
public class GEventArgs1 : EventArgs
{
	// Token: 0x0600BB97 RID: 48023 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual ItemAddress GetLocation()
	{
		throw null;
	}

	// Token: 0x0400BDE9 RID: 48617
	private static int int_0;

	// Token: 0x0400BDEA RID: 48618
	public readonly Item Item;

	// Token: 0x0400BDEB RID: 48619
	public readonly CommandStatus Status;

	// Token: 0x0400BDEC RID: 48620
	public readonly int EventId;
}
