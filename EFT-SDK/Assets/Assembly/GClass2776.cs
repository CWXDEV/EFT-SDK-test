using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;

// Token: 0x02002519 RID: 9497
public sealed class GClass2776 : IRollback, GInterface321, GInterface324
{
	// Token: 0x170021E0 RID: 8672
	// (get) Token: 0x0600BE64 RID: 48740 RVA: 0x00002050 File Offset: 0x00000250
	public ItemAddress From
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021E1 RID: 8673
	// (get) Token: 0x0600BE65 RID: 48741 RVA: 0x00002050 File Offset: 0x00000250
	public ItemAddress To
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021E2 RID: 8674
	// (get) Token: 0x0600BE66 RID: 48742 RVA: 0x00002050 File Offset: 0x00000250
	public bool ItemsDestroyRequired
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021E3 RID: 8675
	// (get) Token: 0x0600BE67 RID: 48743 RVA: 0x00002050 File Offset: 0x00000250
	public bool DestroysMainItem
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021E4 RID: 8676
	// (get) Token: 0x0600BE68 RID: 48744 RVA: 0x00002050 File Offset: 0x00000250
	public IEnumerable<GStruct368> ItemsToDestroy
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600BE69 RID: 48745 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Contains(Item item, out GStruct368 numberToDestroy)
	{
		throw null;
	}

	// Token: 0x0600BE6A RID: 48746 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanExecute(TraderControllerClass itemController)
	{
		throw null;
	}

	// Token: 0x0600BE6B RID: 48747 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvents(TraderControllerClass controller, CommandStatus status)
	{
		throw null;
	}

	// Token: 0x0600BE6C RID: 48748 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RollBack()
	{
		throw null;
	}

	// Token: 0x0400C05B RID: 49243
	private readonly Item item_0;

	// Token: 0x0400C05C RID: 49244
	private readonly GStruct368 gstruct368_0;

	// Token: 0x0400C05D RID: 49245
	[CanBeNull]
	private readonly GInterface314 ginterface314_0;

	// Token: 0x0400C05E RID: 49246
	[CanBeNull]
	private readonly GInterface314 ginterface314_1;

	// Token: 0x0400C05F RID: 49247
	[CompilerGenerated]
	private readonly ItemAddress itemAddress_0;

	// Token: 0x0400C060 RID: 49248
	[CompilerGenerated]
	private readonly ItemAddress itemAddress_1;
}
