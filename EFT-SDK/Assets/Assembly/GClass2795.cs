using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x02002532 RID: 9522
public sealed class GClass2795 : IRollback, IExecute, GInterface321
{
	// Token: 0x0600BEE0 RID: 48864 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct412 Execute()
	{
		throw null;
	}

	// Token: 0x0600BEE1 RID: 48865 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RollBack()
	{
		throw null;
	}

	// Token: 0x0600BEE2 RID: 48866 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvents(TraderControllerClass controller, CommandStatus status)
	{
		throw null;
	}

	// Token: 0x0600BEE3 RID: 48867 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanExecute(TraderControllerClass itemController)
	{
		throw null;
	}

	// Token: 0x0400C0BC RID: 49340
	public readonly FoldableComponent Foldable;

	// Token: 0x0400C0BD RID: 49341
	public readonly bool NewValue;

	// Token: 0x0400C0BE RID: 49342
	public readonly string VisitorId;

	// Token: 0x0400C0BF RID: 49343
	public readonly GClass2783 ResizeResult;
}
