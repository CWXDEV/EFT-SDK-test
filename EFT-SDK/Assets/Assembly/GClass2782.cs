using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;

// Token: 0x02002521 RID: 9505
public sealed class GClass2782 : IRollback, IExecute, GInterface321, GInterface322, GInterface324, GInterface325, GInterface330
{
	// Token: 0x170021F7 RID: 8695
	// (get) Token: 0x0600BE9B RID: 48795 RVA: 0x00002050 File Offset: 0x00000250
	public Item Item
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021F8 RID: 8696
	// (get) Token: 0x0600BE9C RID: 48796 RVA: 0x00002050 File Offset: 0x00000250
	public ItemAddress From
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021F9 RID: 8697
	// (get) Token: 0x0600BE9D RID: 48797 RVA: 0x00002050 File Offset: 0x00000250
	public ItemAddress To
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021FA RID: 8698
	// (get) Token: 0x0600BE9E RID: 48798 RVA: 0x00002050 File Offset: 0x00000250
	public IEnumerable<GClass2799> UnbindResults
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021FB RID: 8699
	// (get) Token: 0x0600BE9F RID: 48799 RVA: 0x00002050 File Offset: 0x00000250
	public bool ItemsDestroyRequired
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021FC RID: 8700
	// (get) Token: 0x0600BEA0 RID: 48800 RVA: 0x00002050 File Offset: 0x00000250
	public bool DestroysMainItem
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021FD RID: 8701
	// (get) Token: 0x0600BEA1 RID: 48801 RVA: 0x00002050 File Offset: 0x00000250
	public IEnumerable<GStruct368> ItemsToDestroy
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021FE RID: 8702
	// (get) Token: 0x0600BEA2 RID: 48802 RVA: 0x00002050 File Offset: 0x00000250
	Item GInterface322.ResultItem
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600BEA3 RID: 48803 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct412 Execute()
	{
		throw null;
	}

	// Token: 0x0600BEA4 RID: 48804 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RollBack()
	{
		throw null;
	}

	// Token: 0x0600BEA5 RID: 48805 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvents(TraderControllerClass itemController, CommandStatus status)
	{
		throw null;
	}

	// Token: 0x0600BEA6 RID: 48806 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanExecute(TraderControllerClass itemController)
	{
		throw null;
	}

	// Token: 0x0600BEA7 RID: 48807 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	bool GInterface324.Contains(Item item, out GStruct368 numberToDestroy)
	{
		throw null;
	}

	// Token: 0x0400C088 RID: 49288
	[CompilerGenerated]
	private readonly Item item_0;

	// Token: 0x0400C089 RID: 49289
	[CompilerGenerated]
	private readonly ItemAddress itemAddress_0;

	// Token: 0x0400C08A RID: 49290
	[CompilerGenerated]
	private readonly ItemAddress itemAddress_1;

	// Token: 0x0400C08B RID: 49291
	private readonly TraderControllerClass gclass2754_0;

	// Token: 0x0400C08C RID: 49292
	public readonly GInterface324 DestroyResult;

	// Token: 0x0400C08D RID: 49293
	private readonly GClass2781 gclass2781_0;

	// Token: 0x0400C08E RID: 49294
	private readonly GClass2778 gclass2778_0;

	// Token: 0x0400C08F RID: 49295
	[CanBeNull]
	private readonly List<GClass2799> list_0;

	// Token: 0x0400C090 RID: 49296
	[CanBeNull]
	private readonly List<GClass2803> list_1;
}
