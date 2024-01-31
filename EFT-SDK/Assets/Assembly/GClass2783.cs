using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;

// Token: 0x02002522 RID: 9506
public sealed class GClass2783 : IRollback, IExecute, GInterface321
{
	// Token: 0x0600BEA8 RID: 48808 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct412 Execute()
	{
		throw null;
	}

	// Token: 0x0600BEA9 RID: 48809 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanExecute(TraderControllerClass itemController)
	{
		throw null;
	}

	// Token: 0x0600BEAA RID: 48810 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RollBack()
	{
		throw null;
	}

	// Token: 0x0600BEAB RID: 48811 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvents(TraderControllerClass controller, CommandStatus status)
	{
		throw null;
	}

	// Token: 0x0400C091 RID: 49297
	public readonly Item Item;

	// Token: 0x0400C092 RID: 49298
	public readonly ItemAddress To;

	// Token: 0x0400C093 RID: 49299
	public readonly GClass2770.ResizeAction ResizeAction;

	// Token: 0x0400C094 RID: 49300
	[CanBeNull]
	public readonly List<Item> ResizedItems;

	// Token: 0x0400C095 RID: 49301
	[CanBeNull]
	public readonly List<GClass2766> ChangedLocations;
}
