using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;

// Token: 0x0200251B RID: 9499
public sealed class GClass2777 : IRollback, IExecute, GInterface321, GInterface324
{
	// Token: 0x170021E7 RID: 8679
	// (get) Token: 0x0600BE72 RID: 48754 RVA: 0x00002050 File Offset: 0x00000250
	public bool ItemsDestroyRequired
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021E8 RID: 8680
	// (get) Token: 0x0600BE73 RID: 48755 RVA: 0x00002050 File Offset: 0x00000250
	public ItemAddress From
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021E9 RID: 8681
	// (get) Token: 0x0600BE74 RID: 48756 RVA: 0x00002050 File Offset: 0x00000250
	public ItemAddress To
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021EA RID: 8682
	// (get) Token: 0x0600BE75 RID: 48757 RVA: 0x00002050 File Offset: 0x00000250
	public IEnumerable<GStruct368> ItemsToDestroy
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170021EB RID: 8683
	// (get) Token: 0x0600BE76 RID: 48758 RVA: 0x00002050 File Offset: 0x00000250
	public bool DestroysMainItem
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600BE77 RID: 48759 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Contains(Item item, out GStruct368 numberToDestroy)
	{
		throw null;
	}

	// Token: 0x0600BE78 RID: 48760 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct412 Execute()
	{
		throw null;
	}

	// Token: 0x0600BE79 RID: 48761 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RollBack()
	{
		throw null;
	}

	// Token: 0x0600BE7A RID: 48762 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvents(TraderControllerClass itemController, CommandStatus status)
	{
		throw null;
	}

	// Token: 0x0600BE7B RID: 48763 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanExecute(TraderControllerClass itemController)
	{
		throw null;
	}

	// Token: 0x0400C065 RID: 49253
	private readonly Item item_0;

	// Token: 0x0400C066 RID: 49254
	private readonly GInterface314 ginterface314_0;

	// Token: 0x0400C067 RID: 49255
	[CanBeNull]
	private readonly GInterface314 ginterface314_1;

	// Token: 0x0400C068 RID: 49256
	private readonly int int_0;

	// Token: 0x0400C069 RID: 49257
	private readonly TraderControllerClass gclass2754_0;

	// Token: 0x0400C06A RID: 49258
	private readonly IReadOnlyList<GInterface323> ireadOnlyList_0;

	// Token: 0x0400C06B RID: 49259
	[CompilerGenerated]
	private readonly bool bool_0;

	// Token: 0x0400C06C RID: 49260
	[CompilerGenerated]
	private readonly ItemAddress itemAddress_0;

	// Token: 0x0400C06D RID: 49261
	[CompilerGenerated]
	private readonly ItemAddress itemAddress_1;
}
