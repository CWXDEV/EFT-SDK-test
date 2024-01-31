using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x02002541 RID: 9537
public sealed class GClass2802 : IRollback, IExecute, GInterface321
{
	// Token: 0x0600BF17 RID: 48919 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct412 Execute()
	{
		throw null;
	}

	// Token: 0x0600BF18 RID: 48920 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RollBack()
	{
		throw null;
	}

	// Token: 0x0600BF19 RID: 48921 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvents(TraderControllerClass controller, CommandStatus status)
	{
		throw null;
	}

	// Token: 0x0600BF1A RID: 48922 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanExecute(TraderControllerClass itemController)
	{
		throw null;
	}

	// Token: 0x0400C0F0 RID: 49392
	public readonly MapComponent Map;

	// Token: 0x0400C0F1 RID: 49393
	public readonly int X;

	// Token: 0x0400C0F2 RID: 49394
	public readonly int Y;

	// Token: 0x0400C0F3 RID: 49395
	public readonly MapMarker DeletedMarker;
}
