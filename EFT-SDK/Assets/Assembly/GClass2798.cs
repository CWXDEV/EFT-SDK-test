using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;

// Token: 0x02002535 RID: 9525
public sealed class GClass2798 : IRollback, IExecute, GInterface321
{
	// Token: 0x0600BEEC RID: 48876 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct413<GClass2798> Run(InventoryControllerClass controller, Item item, EBoundItem index, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BEED RID: 48877 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct412 Execute()
	{
		throw null;
	}

	// Token: 0x0600BEEE RID: 48878 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RollBack()
	{
		throw null;
	}

	// Token: 0x0600BEEF RID: 48879 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvents(TraderControllerClass controller, CommandStatus status)
	{
		throw null;
	}

	// Token: 0x0600BEF0 RID: 48880 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanExecute(TraderControllerClass itemController)
	{
		throw null;
	}

	// Token: 0x0400C0C6 RID: 49350
	public readonly InventoryControllerClass Controller;

	// Token: 0x0400C0C7 RID: 49351
	public readonly Item Item;

	// Token: 0x0400C0C8 RID: 49352
	public readonly EBoundItem Index;

	// Token: 0x0400C0C9 RID: 49353
	[CanBeNull]
	public readonly List<GClass2799> UnbindResults;

	// Token: 0x02002536 RID: 9526
	[CompilerGenerated]
	private sealed class Class2129
	{
		// Token: 0x0600BEF1 RID: 48881 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(KeyValuePair<EBoundItem, Item> pair)
		{
			throw null;
		}

		// Token: 0x0400C0CA RID: 49354
		public Item item;
	}
}
