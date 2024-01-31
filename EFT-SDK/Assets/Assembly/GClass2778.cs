using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;

// Token: 0x0200251D RID: 9501
public sealed class GClass2778 : IRollback, IExecute, GInterface321, GInterface322, GInterface325
{
	// Token: 0x170021EE RID: 8686
	// (get) Token: 0x0600BE82 RID: 48770 RVA: 0x00002050 File Offset: 0x00000250
	Item GInterface322.Item
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021EF RID: 8687
	// (get) Token: 0x0600BE83 RID: 48771 RVA: 0x00002050 File Offset: 0x00000250
	ItemAddress GInterface325.To
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021F0 RID: 8688
	// (get) Token: 0x0600BE84 RID: 48772 RVA: 0x00002050 File Offset: 0x00000250
	Item GInterface322.ResultItem
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600BE85 RID: 48773 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct412 Execute()
	{
		throw null;
	}

	// Token: 0x0600BE86 RID: 48774 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RollBack()
	{
		throw null;
	}

	// Token: 0x0600BE87 RID: 48775 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvents(TraderControllerClass itemController, CommandStatus status)
	{
		throw null;
	}

	// Token: 0x0600BE88 RID: 48776 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanExecute(TraderControllerClass itemController)
	{
		throw null;
	}

	// Token: 0x0400C073 RID: 49267
	public readonly Item Item;

	// Token: 0x0400C074 RID: 49268
	public readonly ItemAddress To;

	// Token: 0x0400C075 RID: 49269
	private readonly TraderControllerClass gclass2754_0;

	// Token: 0x0400C076 RID: 49270
	[CanBeNull]
	private readonly GClass2780 gclass2780_0;

	// Token: 0x0400C077 RID: 49271
	private readonly GClass2783 gclass2783_0;

	// Token: 0x0400C078 RID: 49272
	private bool bool_0;

	// Token: 0x0400C079 RID: 49273
	private bool bool_1;
}
