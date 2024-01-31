using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT.InventoryLogic;

// Token: 0x0200253A RID: 9530
[StructLayout(LayoutKind.Auto)]
public readonly struct GStruct373 : IRollback, GInterface321
{
	// Token: 0x0600BEFD RID: 48893 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RollBack()
	{
		throw null;
	}

	// Token: 0x0600BEFE RID: 48894 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvents(TraderControllerClass controller, CommandStatus status)
	{
		throw null;
	}

	// Token: 0x0600BEFF RID: 48895 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanExecute(TraderControllerClass itemController)
	{
		throw null;
	}

	// Token: 0x0400C0D5 RID: 49365
	public readonly GClass1246 Quest;

	// Token: 0x0400C0D6 RID: 49366
	public readonly AbstractQuestControllerClass QuestController;

	// Token: 0x0400C0D7 RID: 49367
	public readonly IReadOnlyList<GClass2782> Rewards;

	// Token: 0x0400C0D8 RID: 49368
	public readonly TraderControllerClass ItemController;

	// Token: 0x0400C0D9 RID: 49369
	public readonly int TotalCloneCount;
}
