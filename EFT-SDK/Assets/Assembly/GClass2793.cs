using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x02002530 RID: 9520
public sealed class GClass2793 : IRollback, IExecute, GInterface321, GInterface324
{
	// Token: 0x1700220D RID: 8717
	// (get) Token: 0x0600BED2 RID: 48850 RVA: 0x00002050 File Offset: 0x00000250
	public ItemAddress From
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700220E RID: 8718
	// (get) Token: 0x0600BED3 RID: 48851 RVA: 0x00002050 File Offset: 0x00000250
	public ItemAddress To
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700220F RID: 8719
	// (get) Token: 0x0600BED4 RID: 48852 RVA: 0x00002050 File Offset: 0x00000250
	public bool ItemsDestroyRequired
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002210 RID: 8720
	// (get) Token: 0x0600BED5 RID: 48853 RVA: 0x00002050 File Offset: 0x00000250
	public bool DestroysMainItem
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002211 RID: 8721
	// (get) Token: 0x0600BED6 RID: 48854 RVA: 0x00002050 File Offset: 0x00000250
	public IEnumerable<GStruct368> ItemsToDestroy
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600BED7 RID: 48855 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct412 Execute()
	{
		throw null;
	}

	// Token: 0x0600BED8 RID: 48856 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RollBack()
	{
		throw null;
	}

	// Token: 0x0600BED9 RID: 48857 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvents(TraderControllerClass controller, CommandStatus status)
	{
		throw null;
	}

	// Token: 0x0600BEDA RID: 48858 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanExecute(TraderControllerClass controller)
	{
		throw null;
	}

	// Token: 0x0600BEDB RID: 48859 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	bool GInterface324.Contains(Item item, out GStruct368 numberToDestroy)
	{
		throw null;
	}

	// Token: 0x0400C0AB RID: 49323
	public readonly Item Item;

	// Token: 0x0400C0AC RID: 49324
	[CompilerGenerated]
	private readonly ItemAddress itemAddress_0;

	// Token: 0x0400C0AD RID: 49325
	[CompilerGenerated]
	private readonly ItemAddress itemAddress_1;

	// Token: 0x0400C0AE RID: 49326
	public readonly Item Item1;

	// Token: 0x0400C0AF RID: 49327
	public readonly ItemAddress From1;

	// Token: 0x0400C0B0 RID: 49328
	public readonly ItemAddress To1;

	// Token: 0x0400C0B1 RID: 49329
	private readonly TraderControllerClass gclass2754_0;

	// Token: 0x0400C0B2 RID: 49330
	private readonly GInterface324 ginterface324_0;

	// Token: 0x0400C0B3 RID: 49331
	private readonly GInterface324 ginterface324_1;

	// Token: 0x0400C0B4 RID: 49332
	private readonly GClass2781 gclass2781_0;

	// Token: 0x0400C0B5 RID: 49333
	private readonly GClass2781 gclass2781_1;

	// Token: 0x0400C0B6 RID: 49334
	private readonly GClass2778 gclass2778_0;

	// Token: 0x0400C0B7 RID: 49335
	private readonly GClass2778 gclass2778_1;
}
