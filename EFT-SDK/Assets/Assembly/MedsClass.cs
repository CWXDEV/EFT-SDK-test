using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x020023B6 RID: 9142
public class MedsClass : Item
{
	// Token: 0x0600B897 RID: 47255 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Compare(Item item)
	{
		throw null;
	}

	// Token: 0x1700203A RID: 8250
	// (get) Token: 0x0600B898 RID: 47256 RVA: 0x00002050 File Offset: 0x00000250
	public override IEnumerable<EItemInfoButton> ItemInteractionButtons
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400BB80 RID: 48000
	public readonly HealthEffectsComponent HealthEffectsComponent;

	// Token: 0x0400BB81 RID: 48001
	public readonly MedKitComponent MedKitComponent;
}
