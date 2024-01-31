using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x02002537 RID: 9527
public sealed class GClass2799 : IRollback, IExecute, GInterface321
{
	// Token: 0x0600BEF2 RID: 48882 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct413<GClass2799> Run(InventoryControllerClass controller, Item item, EBoundItem index, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BEF3 RID: 48883 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct412 Execute()
	{
		throw null;
	}

	// Token: 0x0600BEF4 RID: 48884 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RollBack()
	{
		throw null;
	}

	// Token: 0x0600BEF5 RID: 48885 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvents(TraderControllerClass controller, CommandStatus status)
	{
		throw null;
	}

	// Token: 0x0600BEF6 RID: 48886 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanExecute(TraderControllerClass itemController)
	{
		throw null;
	}

	// Token: 0x0400C0CB RID: 49355
	public readonly InventoryControllerClass Controller;

	// Token: 0x0400C0CC RID: 49356
	public readonly Item Item;

	// Token: 0x0400C0CD RID: 49357
	public readonly EBoundItem Index;
}
