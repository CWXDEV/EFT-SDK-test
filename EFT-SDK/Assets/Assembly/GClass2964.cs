using System;
using System.Runtime.CompilerServices;
using EFT.Interactive;
using EFT.InventoryLogic;
using JetBrains.Annotations;

// Token: 0x02002766 RID: 10086
public class GClass2964 : InteractionResult, IRollback, GInterface321
{
	// Token: 0x0600C9FF RID: 51711 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RollBack()
	{
		throw null;
	}

	// Token: 0x0600CA00 RID: 51712 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvents(TraderControllerClass controller, CommandStatus status)
	{
		throw null;
	}

	// Token: 0x0600CA01 RID: 51713 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct412 Replay()
	{
		throw null;
	}

	// Token: 0x0600CA02 RID: 51714 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanExecute(TraderControllerClass itemController)
	{
		throw null;
	}

	// Token: 0x0400C9E9 RID: 51689
	public readonly KeyComponent Key;

	// Token: 0x0400C9EA RID: 51690
	public readonly ItemAddress From;

	// Token: 0x0400C9EB RID: 51691
	public readonly bool Succeed;

	// Token: 0x0400C9EC RID: 51692
	[CanBeNull]
	public readonly GClass2779 DiscardResult;
}
