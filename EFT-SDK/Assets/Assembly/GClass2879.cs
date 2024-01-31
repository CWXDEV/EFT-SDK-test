using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x020025D2 RID: 9682
public class GClass2879 : IRollback, IExecute, GInterface321
{
	// Token: 0x0600C09A RID: 49306 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RollBack()
	{
		throw null;
	}

	// Token: 0x0600C09B RID: 49307 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct412 Execute()
	{
		throw null;
	}

	// Token: 0x0600C09C RID: 49308 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvents(TraderControllerClass controller, CommandStatus status)
	{
		throw null;
	}

	// Token: 0x0600C09D RID: 49309 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanExecute(TraderControllerClass itemController)
	{
		throw null;
	}

	// Token: 0x0400C29B RID: 49819
	public readonly BackendConfigSettingsClass.ServiceData ServiceData;

	// Token: 0x0400C29C RID: 49820
	public readonly string SubServiceId;

	// Token: 0x0400C29D RID: 49821
	public readonly AbstractQuestControllerClass QuestController;

	// Token: 0x0400C29E RID: 49822
	public readonly InventoryControllerClass InventoryController;

	// Token: 0x0400C29F RID: 49823
	public readonly IReadOnlyList<GInterface321> OperationResults;
}
