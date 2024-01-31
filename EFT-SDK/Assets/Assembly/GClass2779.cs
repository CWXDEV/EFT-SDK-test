using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;

// Token: 0x0200251E RID: 9502
public sealed class GClass2779 : IRollback, IExecute, GInterface321, GInterface322
{
	// Token: 0x170021F1 RID: 8689
	// (get) Token: 0x0600BE89 RID: 48777 RVA: 0x00002050 File Offset: 0x00000250
	public Item Item
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021F2 RID: 8690
	// (get) Token: 0x0600BE8A RID: 48778 RVA: 0x00002050 File Offset: 0x00000250
	public ItemAddress From
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021F3 RID: 8691
	// (get) Token: 0x0600BE8B RID: 48779 RVA: 0x00002050 File Offset: 0x00000250
	Item GInterface322.ResultItem
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600BE8C RID: 48780 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct412 Execute()
	{
		throw null;
	}

	// Token: 0x0600BE8D RID: 48781 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RollBack()
	{
		throw null;
	}

	// Token: 0x0600BE8E RID: 48782 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvents(TraderControllerClass itemController, CommandStatus status)
	{
		throw null;
	}

	// Token: 0x0600BE8F RID: 48783 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanExecute(TraderControllerClass itemController)
	{
		throw null;
	}

	// Token: 0x0400C07A RID: 49274
	public readonly GClass2781 RemoveResult;

	// Token: 0x0400C07B RID: 49275
	[CanBeNull]
	public readonly List<GClass2799> UnbindResults;

	// Token: 0x0400C07C RID: 49276
	[CanBeNull]
	public readonly List<GClass2803> SetTagResults;

	// Token: 0x0400C07D RID: 49277
	private readonly TraderControllerClass gclass2754_0;
}
