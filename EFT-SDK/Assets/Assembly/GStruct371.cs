using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT.InventoryLogic;

// Token: 0x02002538 RID: 9528
[StructLayout(LayoutKind.Auto)]
public readonly struct GStruct371 : IRollback, GInterface321
{
	// Token: 0x0600BEF7 RID: 48887 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RollBack()
	{
		throw null;
	}

	// Token: 0x0600BEF8 RID: 48888 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvents(TraderControllerClass controller, CommandStatus status)
	{
		throw null;
	}

	// Token: 0x0600BEF9 RID: 48889 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanExecute(TraderControllerClass itemController)
	{
		throw null;
	}

	// Token: 0x0400C0CE RID: 49358
	public readonly GClass1246 Quest;

	// Token: 0x0400C0CF RID: 49359
	public readonly AbstractQuestControllerClass QuestController;
}
