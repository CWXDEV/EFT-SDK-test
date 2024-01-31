using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT.InventoryLogic;

// Token: 0x02002539 RID: 9529
[StructLayout(LayoutKind.Auto)]
public readonly struct GStruct372<T> : IRollback, GInterface321 where T : GInterface381
{
	// Token: 0x0600BEFA RID: 48890 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RollBack()
	{
		throw null;
	}

	// Token: 0x0600BEFB RID: 48891 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvents(TraderControllerClass controller, CommandStatus status)
	{
		throw null;
	}

	// Token: 0x0600BEFC RID: 48892 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanExecute(TraderControllerClass itemController)
	{
		throw null;
	}

	// Token: 0x0400C0D0 RID: 49360
	public readonly T Conditional;

	// Token: 0x0400C0D1 RID: 49361
	public readonly GClass3202<T> ConditionalController;

	// Token: 0x0400C0D2 RID: 49362
	public readonly IReadOnlyList<GClass2782> Rewards;

	// Token: 0x0400C0D3 RID: 49363
	public readonly TraderControllerClass ItemController;

	// Token: 0x0400C0D4 RID: 49364
	public readonly int TotalCloneCount;
}
