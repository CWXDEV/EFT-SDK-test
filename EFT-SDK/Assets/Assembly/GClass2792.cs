using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x0200252F RID: 9519
public sealed class GClass2792 : IRollback, IExecute, GInterface321, GInterface322, GInterface326, GInterface330
{
	// Token: 0x1700220A RID: 8714
	// (get) Token: 0x0600BECA RID: 48842 RVA: 0x00002050 File Offset: 0x00000250
	Item GInterface322.Item
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700220B RID: 8715
	// (get) Token: 0x0600BECB RID: 48843 RVA: 0x00002050 File Offset: 0x00000250
	Item GInterface326.TargetItem
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700220C RID: 8716
	// (get) Token: 0x0600BECC RID: 48844 RVA: 0x00002050 File Offset: 0x00000250
	Item GInterface322.ResultItem
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600BECD RID: 48845 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct412 Execute()
	{
		throw null;
	}

	// Token: 0x0600BECE RID: 48846 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct413<GClass2792> ExecuteWithNewCount(int count, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BECF RID: 48847 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RollBack()
	{
		throw null;
	}

	// Token: 0x0600BED0 RID: 48848 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvents(TraderControllerClass controller, CommandStatus status)
	{
		throw null;
	}

	// Token: 0x0600BED1 RID: 48849 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanExecute(TraderControllerClass controller)
	{
		throw null;
	}

	// Token: 0x0400C0A6 RID: 49318
	public readonly Item Item;

	// Token: 0x0400C0A7 RID: 49319
	public readonly int Count;

	// Token: 0x0400C0A8 RID: 49320
	public readonly Item TargetItem;

	// Token: 0x0400C0A9 RID: 49321
	private readonly GInterface324 ginterface324_0;

	// Token: 0x0400C0AA RID: 49322
	private readonly TraderControllerClass gclass2754_0;
}
