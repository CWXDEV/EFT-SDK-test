using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x0200253E RID: 9534
public sealed class GClass2800 : IRollback, IExecute, GInterface321
{
	// Token: 0x0600BF0B RID: 48907 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct412 Execute()
	{
		throw null;
	}

	// Token: 0x0600BF0C RID: 48908 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RollBack()
	{
		throw null;
	}

	// Token: 0x0600BF0D RID: 48909 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvents(TraderControllerClass controller, CommandStatus status)
	{
		throw null;
	}

	// Token: 0x0600BF0E RID: 48910 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanExecute(TraderControllerClass itemController)
	{
		throw null;
	}

	// Token: 0x0400C0E6 RID: 49382
	public readonly GClass2490 NotesManager;

	// Token: 0x0400C0E7 RID: 49383
	public readonly int Index;

	// Token: 0x0400C0E8 RID: 49384
	public GClass2489 DeletedNote;
}
