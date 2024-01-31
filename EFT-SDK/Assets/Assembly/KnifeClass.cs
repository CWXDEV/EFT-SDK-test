using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x02002397 RID: 9111
public class KnifeClass : Item
{
	// Token: 0x17001FF2 RID: 8178
	// (get) Token: 0x0600B7F3 RID: 47091 RVA: 0x00002050 File Offset: 0x00000250
	public override IEnumerable<EItemInfoButton> ItemInteractionButtons
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600B7F4 RID: 47092 RVA: 0x00002050 File Offset: 0x00000250
	[DebuggerHidden]
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerable<EItemInfoButton> method_7()
	{
		throw null;
	}

	// Token: 0x0400BB10 RID: 47888
	public readonly SideEffectComponent SideEffect;

	// Token: 0x0400BB11 RID: 47889
	public readonly RepairableComponent Repairable;

	// Token: 0x0400BB12 RID: 47890
	public readonly KnifeComponent KnifeComponent;
}
