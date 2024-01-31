using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x0200236B RID: 9067
public class FoodClass : Item
{
	// Token: 0x0600B6C3 RID: 46787 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool Compare(Item item)
	{
		throw null;
	}

	// Token: 0x17001F8F RID: 8079
	// (get) Token: 0x0600B6C4 RID: 46788 RVA: 0x00002050 File Offset: 0x00000250
	public override IEnumerable<EItemInfoButton> ItemInteractionButtons
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600B6C5 RID: 46789 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[DebuggerHidden]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerable<EItemInfoButton> method_7()
	{
		throw null;
	}

	// Token: 0x0400BA56 RID: 47702
	public readonly FoodDrinkComponent FoodDrinkComponent;

	// Token: 0x0400BA57 RID: 47703
	public readonly HealthEffectsComponent HealthEffectsComponent;
}
