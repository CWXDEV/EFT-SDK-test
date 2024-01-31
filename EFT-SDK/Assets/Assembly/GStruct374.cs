using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT.InventoryLogic;
using EFT.Quests;

// Token: 0x0200253B RID: 9531
[StructLayout(LayoutKind.Auto)]
public readonly struct GStruct374 : IRollback, GInterface321
{
	// Token: 0x0600BF00 RID: 48896 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RollBack()
	{
		throw null;
	}

	// Token: 0x0600BF01 RID: 48897 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvents(TraderControllerClass controller, CommandStatus status)
	{
		throw null;
	}

	// Token: 0x0600BF02 RID: 48898 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanExecute(TraderControllerClass itemController)
	{
		throw null;
	}

	// Token: 0x0400C0DA RID: 49370
	public readonly GClass1246 Quest;

	// Token: 0x0400C0DB RID: 49371
	public readonly AbstractQuestControllerClass QuestController;

	// Token: 0x0400C0DC RID: 49372
	public readonly IReadOnlyList<GStruct412> RemoveResults;

	// Token: 0x0400C0DD RID: 49373
	public readonly Item[] Items;

	// Token: 0x0400C0DE RID: 49374
	public readonly ConditionItem Condition;
}
