using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x02002534 RID: 9524
public sealed class GClass2797 : IRollback, IExecute, GInterface321
{
	// Token: 0x0600BEE8 RID: 48872 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct412 Execute()
	{
		throw null;
	}

	// Token: 0x0600BEE9 RID: 48873 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RollBack()
	{
		throw null;
	}

	// Token: 0x0600BEEA RID: 48874 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvents(TraderControllerClass controller, CommandStatus status)
	{
		throw null;
	}

	// Token: 0x0600BEEB RID: 48875 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanExecute(TraderControllerClass itemController)
	{
		throw null;
	}

	// Token: 0x0400C0C3 RID: 49347
	public readonly TogglableComponent Togglable;

	// Token: 0x0400C0C4 RID: 49348
	public readonly ItemAddress From;

	// Token: 0x0400C0C5 RID: 49349
	public readonly bool NewValue;
}
