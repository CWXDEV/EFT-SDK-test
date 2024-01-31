using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x02002540 RID: 9536
public sealed class GClass2801 : IRollback, IExecute, GInterface321
{
	// Token: 0x0600BF13 RID: 48915 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct412 Execute()
	{
		throw null;
	}

	// Token: 0x0600BF14 RID: 48916 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RollBack()
	{
		throw null;
	}

	// Token: 0x0600BF15 RID: 48917 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvents(TraderControllerClass controller, CommandStatus status)
	{
		throw null;
	}

	// Token: 0x0600BF16 RID: 48918 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanExecute(TraderControllerClass itemController)
	{
		throw null;
	}

	// Token: 0x0400C0EB RID: 49387
	public readonly MapComponent Map;

	// Token: 0x0400C0EC RID: 49388
	public readonly MapMarker Marker;

	// Token: 0x0400C0ED RID: 49389
	public readonly int X;

	// Token: 0x0400C0EE RID: 49390
	public readonly int Y;

	// Token: 0x0400C0EF RID: 49391
	public readonly MapMarker OriginalMarker;
}
