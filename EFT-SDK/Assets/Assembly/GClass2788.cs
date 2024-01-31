using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x0200252E RID: 9518
public class GClass2788 : IRollback, GInterface321, GInterface322
{
	// Token: 0x17002207 RID: 8711
	// (get) Token: 0x0600BEC2 RID: 48834 RVA: 0x00002050 File Offset: 0x00000250
	public int Count
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002208 RID: 8712
	// (get) Token: 0x0600BEC3 RID: 48835 RVA: 0x00002050 File Offset: 0x00000250
	public virtual Item Item
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002209 RID: 8713
	// (get) Token: 0x0600BEC4 RID: 48836 RVA: 0x00002050 File Offset: 0x00000250
	public Item ResultItem
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600BEC5 RID: 48837 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual GStruct412 Execute()
	{
		throw null;
	}

	// Token: 0x0600BEC6 RID: 48838 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RollBack()
	{
		throw null;
	}

	// Token: 0x0600BEC7 RID: 48839 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RaiseEvents(TraderControllerClass controller, CommandStatus status)
	{
		throw null;
	}

	// Token: 0x0600BEC8 RID: 48840 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void RaiseSucceedEvent(TraderControllerClass controller)
	{
		throw null;
	}

	// Token: 0x0600BEC9 RID: 48841 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool CanExecute(TraderControllerClass itemController)
	{
		throw null;
	}

	// Token: 0x0400C0A0 RID: 49312
	public readonly Item SourceItem;

	// Token: 0x0400C0A1 RID: 49313
	public readonly GInterface319 IDGenerator;

	// Token: 0x0400C0A2 RID: 49314
	protected readonly TraderControllerClass gclass2754_0;

	// Token: 0x0400C0A3 RID: 49315
	private bool bool_0;

	// Token: 0x0400C0A4 RID: 49316
	private bool bool_1;

	// Token: 0x0400C0A5 RID: 49317
	[CompilerGenerated]
	private readonly Item item_0;
}
