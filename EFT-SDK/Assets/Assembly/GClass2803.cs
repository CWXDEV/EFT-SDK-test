using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x02002542 RID: 9538
public sealed class GClass2803 : IRollback, IExecute, GInterface321
{
	// Token: 0x0600BF1B RID: 48923 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanExecute(TraderControllerClass itemController)
	{
		throw null;
	}

	// Token: 0x0600BF1C RID: 48924 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct412 Execute()
	{
		throw null;
	}

	// Token: 0x0600BF1D RID: 48925 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvents(TraderControllerClass controller, CommandStatus status)
	{
		throw null;
	}

	// Token: 0x0600BF1E RID: 48926 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RollBack()
	{
		throw null;
	}

	// Token: 0x0400C0F4 RID: 49396
	public readonly TagComponent Tag;

	// Token: 0x0400C0F5 RID: 49397
	public readonly string Name;

	// Token: 0x0400C0F6 RID: 49398
	public readonly int Color;

	// Token: 0x0400C0F7 RID: 49399
	public readonly string OldName;

	// Token: 0x0400C0F8 RID: 49400
	public readonly int OldColor;
}
