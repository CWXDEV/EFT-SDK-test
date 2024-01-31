using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;

// Token: 0x02002531 RID: 9521
public sealed class GClass2794 : IRollback, IExecute, GInterface321
{
	// Token: 0x0600BEDC RID: 48860 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct412 Execute()
	{
		throw null;
	}

	// Token: 0x0600BEDD RID: 48861 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RollBack()
	{
		throw null;
	}

	// Token: 0x0600BEDE RID: 48862 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvents(TraderControllerClass controller, CommandStatus status)
	{
		throw null;
	}

	// Token: 0x0600BEDF RID: 48863 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanExecute(TraderControllerClass controller)
	{
		throw null;
	}

	// Token: 0x0400C0B8 RID: 49336
	public readonly KeyComponent Key;

	// Token: 0x0400C0B9 RID: 49337
	public readonly LockableComponent Lockable;

	// Token: 0x0400C0BA RID: 49338
	public readonly bool Locked;

	// Token: 0x0400C0BB RID: 49339
	[CanBeNull]
	public readonly InventoryControllerClass InventoryController;
}
