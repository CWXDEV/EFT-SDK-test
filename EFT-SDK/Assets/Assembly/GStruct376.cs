using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT.InventoryLogic;

// Token: 0x0200253D RID: 9533
[StructLayout(LayoutKind.Auto)]
public readonly struct GStruct376 : IRollback, IExecute, GInterface321
{
	// Token: 0x0600BF07 RID: 48903 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct412 Execute()
	{
		throw null;
	}

	// Token: 0x0600BF08 RID: 48904 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RollBack()
	{
		throw null;
	}

	// Token: 0x0600BF09 RID: 48905 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvents(TraderControllerClass controller, CommandStatus status)
	{
		throw null;
	}

	// Token: 0x0600BF0A RID: 48906 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanExecute(TraderControllerClass itemController)
	{
		throw null;
	}

	// Token: 0x0400C0E1 RID: 49377
	public readonly GClass2490 NotesManager;

	// Token: 0x0400C0E2 RID: 49378
	public readonly int Index;

	// Token: 0x0400C0E3 RID: 49379
	public readonly GClass2489 Note;

	// Token: 0x0400C0E4 RID: 49380
	public readonly GClass2489 ChangedNote;

	// Token: 0x0400C0E5 RID: 49381
	public readonly string OldText;
}
