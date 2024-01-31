using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x02002523 RID: 9507
public sealed class GClass2784 : IRollback, IExecute, GInterface321, GInterface322, GInterface326, GInterface330
{
	// Token: 0x170021FF RID: 8703
	// (get) Token: 0x0600BEAC RID: 48812 RVA: 0x00002050 File Offset: 0x00000250
	public ItemAddress From
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002200 RID: 8704
	// (get) Token: 0x0600BEAD RID: 48813 RVA: 0x00002050 File Offset: 0x00000250
	Item GInterface322.Item
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002201 RID: 8705
	// (get) Token: 0x0600BEAE RID: 48814 RVA: 0x00002050 File Offset: 0x00000250
	Item GInterface326.TargetItem
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002202 RID: 8706
	// (get) Token: 0x0600BEAF RID: 48815 RVA: 0x00002050 File Offset: 0x00000250
	Item GInterface322.ResultItem
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600BEB1 RID: 48817 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RollBack()
	{
		throw null;
	}

	public GStruct412 Execute()
	{
		throw new NotImplementedException();
	}

	// Token: 0x0600BEB2 RID: 48818 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvents(TraderControllerClass controller, CommandStatus status)
	{
		throw null;
	}

	// Token: 0x0600BEB3 RID: 48819 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanExecute(TraderControllerClass itemController)
	{
		throw null;
	}

	// Token: 0x0400C096 RID: 49302
	public readonly Item Item;

	// Token: 0x0400C097 RID: 49303
	public readonly Item TargetItem;

	// Token: 0x0400C098 RID: 49304
	private readonly TraderControllerClass gclass2754_0;

	// Token: 0x0400C099 RID: 49305
	private readonly GClass2781 gclass2781_0;

	// Token: 0x0400C09A RID: 49306
	private readonly GClass2792 gclass2792_0;
}
