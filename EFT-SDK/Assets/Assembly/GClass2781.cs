using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;

// Token: 0x02002520 RID: 9504
public sealed class GClass2781 : IRollback, IExecute, GInterface321, GInterface322, GInterface323
{
	// Token: 0x170021F4 RID: 8692
	// (get) Token: 0x0600BE94 RID: 48788 RVA: 0x00002050 File Offset: 0x00000250
	GStruct368 GInterface323.ItemsCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021F5 RID: 8693
	// (get) Token: 0x0600BE95 RID: 48789 RVA: 0x00002050 File Offset: 0x00000250
	Item GInterface322.Item
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021F6 RID: 8694
	// (get) Token: 0x0600BE96 RID: 48790 RVA: 0x00002050 File Offset: 0x00000250
	Item GInterface322.ResultItem
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600BE97 RID: 48791 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct412 Execute()
	{
		throw null;
	}

	// Token: 0x0600BE98 RID: 48792 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RollBack()
	{
		throw null;
	}

	// Token: 0x0600BE99 RID: 48793 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvents(TraderControllerClass itemController, CommandStatus status)
	{
		throw null;
	}

	// Token: 0x0600BE9A RID: 48794 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanExecute(TraderControllerClass controller)
	{
		throw null;
	}

	// Token: 0x0400C080 RID: 49280
	public readonly Item Item;

	// Token: 0x0400C081 RID: 49281
	public readonly ItemAddress From;

	// Token: 0x0400C082 RID: 49282
	private readonly GStruct368 gstruct368_0;

	// Token: 0x0400C083 RID: 49283
	private readonly TraderControllerClass gclass2754_0;

	// Token: 0x0400C084 RID: 49284
	public readonly GClass2783 ResizeResult;

	// Token: 0x0400C085 RID: 49285
	[CanBeNull]
	private readonly GClass2780 gclass2780_0;

	// Token: 0x0400C086 RID: 49286
	private bool bool_0;

	// Token: 0x0400C087 RID: 49287
	private bool bool_1;
}
