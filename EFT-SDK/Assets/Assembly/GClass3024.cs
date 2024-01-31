using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.InventoryLogic;

// Token: 0x020029BA RID: 10682
public abstract class GClass3024 : GClass3022
{
	// Token: 0x170025AA RID: 9642
	// (get) Token: 0x0600D496 RID: 54422 RVA: 0x00002050 File Offset: 0x00000250
	protected override IEnumerable<EItemInfoButton> AvailableInteractions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170025AB RID: 9643
	// (get) Token: 0x0600D497 RID: 54423 RVA: 0x00002050 File Offset: 0x00000250
	protected override IEnumerable<EItemInfoButton> SubInteractions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600D498 RID: 54424 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ExecuteInteractionInternal(EItemInfoButton interaction)
	{
		throw null;
	}

	// Token: 0x0600D499 RID: 54425 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CreateSubInteractions(EItemInfoButton parentInteraction, IBallisticsCalculator subInteractionsWrapper)
	{
		throw null;
	}

	// Token: 0x0600D49A RID: 54426 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_43()
	{
		throw null;
	}

	// Token: 0x0600D49B RID: 54427 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_44()
	{
		throw null;
	}

	// Token: 0x0600D49C RID: 54428 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_45()
	{
		throw null;
	}

	// Token: 0x0400D6E5 RID: 55013
	public const string HIDEOUT_WEAPON_MODIFICATION_REQUIRED = "bonus/UnlockWeaponModification_required";

	// Token: 0x0400D6E6 RID: 55014
	private static readonly IReadOnlyList<EItemInfoButton> ireadOnlyList_0;

	// Token: 0x0400D6E7 RID: 55015
	private readonly LootItemClass[] gclass2625_0;
}
