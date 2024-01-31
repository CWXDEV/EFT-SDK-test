using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x0200251F RID: 9503
public sealed class GClass2780 : IRollback, IExecute, GInterface321
{
	// Token: 0x0600BE90 RID: 48784 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct412 Execute()
	{
		throw null;
	}

	// Token: 0x0600BE91 RID: 48785 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RollBack()
	{
		throw null;
	}

	// Token: 0x0600BE92 RID: 48786 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvents(TraderControllerClass itemController, CommandStatus status)
	{
		throw null;
	}

	// Token: 0x0600BE93 RID: 48787 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanExecute(TraderControllerClass controller)
	{
		throw null;
	}

	// Token: 0x0400C07E RID: 49278
	public readonly Item Item;

	// Token: 0x0400C07F RID: 49279
	public readonly int PreviousVersion;
}
