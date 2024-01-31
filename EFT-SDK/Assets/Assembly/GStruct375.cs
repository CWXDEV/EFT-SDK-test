using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT.InventoryLogic;

// Token: 0x0200253C RID: 9532
[StructLayout(LayoutKind.Auto)]
public readonly struct GStruct375 : IRollback, IExecute, GInterface321
{
	// Token: 0x0600BF03 RID: 48899 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct412 Execute()
	{
		throw null;
	}

	// Token: 0x0600BF04 RID: 48900 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RollBack()
	{
		throw null;
	}

	// Token: 0x0600BF05 RID: 48901 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvents(TraderControllerClass controller, CommandStatus status)
	{
		throw null;
	}

	// Token: 0x0600BF06 RID: 48902 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanExecute(TraderControllerClass itemController)
	{
		throw null;
	}

	// Token: 0x0400C0DF RID: 49375
	public readonly GClass2490 NotesManager;

	// Token: 0x0400C0E0 RID: 49376
	public readonly GClass2489 Note;
}
