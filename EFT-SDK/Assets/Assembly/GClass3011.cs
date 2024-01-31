using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InputSystem;
using EFT.InventoryLogic;

// Token: 0x0200289D RID: 10397
public static class GClass3011
{
	// Token: 0x0600CFB6 RID: 53174 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryGetSelectDirection(ECommand command, out bool isNext)
	{
		throw null;
	}

	// Token: 0x0400D074 RID: 53364
	public static readonly IReadOnlyDictionary<ECommand, EBoundItem> SlotBySelectCommandDictionary;

	// Token: 0x0400D075 RID: 53365
	public static readonly IReadOnlyDictionary<ECommand, EBoundItem> SlotByConfirmCommandDictionary;
}
