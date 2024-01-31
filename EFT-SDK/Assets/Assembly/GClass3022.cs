using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;
using EFT.InventoryLogic;
using EFT.UI;

// Token: 0x020029BD RID: 10685
public abstract class GClass3022 : GClass3021<EItemInfoButton>
{
	// Token: 0x170025AC RID: 9644
	// (get) Token: 0x0600D4A1 RID: 54433
	protected abstract IEnumerable<EItemInfoButton> AvailableInteractions { get; }

	// Token: 0x170025AD RID: 9645
	// (get) Token: 0x0600D4A2 RID: 54434 RVA: 0x00002050 File Offset: 0x00000250
	public override IEnumerable<EItemInfoButton> AllInteractions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170025AE RID: 9646
	// (get) Token: 0x0600D4A3 RID: 54435 RVA: 0x00002050 File Offset: 0x00000250
	public override bool HasInteractions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600D4A4 RID: 54436 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ExecuteInteractionInternal(EItemInfoButton interaction)
	{
		throw null;
	}

	// Token: 0x0600D4A5 RID: 54437 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool IsActive(EItemInfoButton button)
	{
		throw null;
	}

	// Token: 0x0600D4A6 RID: 54438 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override IResult IsInteractive(EItemInfoButton button)
	{
		throw null;
	}

	// Token: 0x0600D4A7 RID: 54439 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Action SubscribeOnInventoryLocked(Action<bool> handler)
	{
		throw null;
	}

	// Token: 0x0600D4A8 RID: 54440 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Action SubscribeOnEffectsChange(Action<IEffect> handler)
	{
		throw null;
	}

	// Token: 0x0600D4A9 RID: 54441 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Action SubscribeOnRedraw(Action<IEnumerable<string>> handler)
	{
		throw null;
	}

	// Token: 0x0600D4AA RID: 54442 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Action SubscribeOnClose(Action<IEnumerable<string>> handler)
	{
		throw null;
	}

	// Token: 0x0600D4AB RID: 54443 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Action method_3(Action<GEventArgs1> handler)
	{
		throw null;
	}

	// Token: 0x0600D4AC RID: 54444 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x0600D4AD RID: 54445 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5()
	{
		throw null;
	}

	// Token: 0x0600D4AE RID: 54446 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6()
	{
		throw null;
	}

	// Token: 0x0600D4AF RID: 54447 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_7()
	{
		throw null;
	}

	// Token: 0x0600D4B0 RID: 54448 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_8()
	{
		throw null;
	}

	// Token: 0x0600D4B1 RID: 54449 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_9()
	{
		throw null;
	}

	// Token: 0x0600D4B2 RID: 54450 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_10()
	{
		throw null;
	}

	// Token: 0x0600D4B3 RID: 54451 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_11()
	{
		throw null;
	}

	// Token: 0x0600D4B4 RID: 54452 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_12()
	{
		throw null;
	}

	// Token: 0x0600D4B5 RID: 54453 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_13()
	{
		throw null;
	}

	// Token: 0x0600D4B6 RID: 54454 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_14()
	{
		throw null;
	}

	// Token: 0x0600D4B7 RID: 54455 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Insure()
	{
		throw null;
	}

	// Token: 0x0600D4B8 RID: 54456 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_15()
	{
		throw null;
	}

	// Token: 0x0600D4B9 RID: 54457 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected Task method_16()
	{
		throw null;
	}

	// Token: 0x0600D4BA RID: 54458 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_17()
	{
		throw null;
	}

	// Token: 0x0600D4BB RID: 54459 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_18()
	{
		throw null;
	}

	// Token: 0x0600D4BC RID: 54460 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_19()
	{
		throw null;
	}

	// Token: 0x0600D4BD RID: 54461 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_20()
	{
		throw null;
	}

	// Token: 0x0600D4BE RID: 54462 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_21()
	{
		throw null;
	}

	// Token: 0x0600D4BF RID: 54463 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_22()
	{
		throw null;
	}

	// Token: 0x0600D4C0 RID: 54464 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_23()
	{
		throw null;
	}

	// Token: 0x0600D4C1 RID: 54465 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_24()
	{
		throw null;
	}

	// Token: 0x0600D4C2 RID: 54466 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_25()
	{
		throw null;
	}

	// Token: 0x0600D4C3 RID: 54467 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_26()
	{
		throw null;
	}

	// Token: 0x0600D4C4 RID: 54468 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_27()
	{
		throw null;
	}

	// Token: 0x0600D4C5 RID: 54469 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_28()
	{
		throw null;
	}

	// Token: 0x0600D4C6 RID: 54470 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_29(LootItemClass compoundItem)
	{
		throw null;
	}

	// Token: 0x0600D4C7 RID: 54471 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_30()
	{
		throw null;
	}

	// Token: 0x0600D4C8 RID: 54472 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_31()
	{
		throw null;
	}

	// Token: 0x0600D4C9 RID: 54473 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_32()
	{
		throw null;
	}

	// Token: 0x0600D4CA RID: 54474 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_33()
	{
		throw null;
	}

	// Token: 0x0600D4CB RID: 54475 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_34()
	{
		throw null;
	}

	// Token: 0x0600D4CC RID: 54476 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_35()
	{
		throw null;
	}

	// Token: 0x0600D4CD RID: 54477 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_36()
	{
		throw null;
	}

	// Token: 0x0600D4CE RID: 54478 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_37()
	{
		throw null;
	}

	// Token: 0x0600D4CF RID: 54479 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Search(GClass3195 ragfairSearch)
	{
		throw null;
	}

	// Token: 0x0600D4D0 RID: 54480 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_38()
	{
		throw null;
	}

	// Token: 0x0600D4D1 RID: 54481 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_39()
	{
		throw null;
	}

	// Token: 0x0600D4D2 RID: 54482 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_40()
	{
		throw null;
	}

	// Token: 0x0600D4D3 RID: 54483 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_41()
	{
		throw null;
	}

	// Token: 0x0600D4D4 RID: 54484 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_42()
	{
		throw null;
	}

	// Token: 0x0400D6F1 RID: 55025
	protected readonly Item item_0;

	// Token: 0x0400D6F2 RID: 55026
	protected readonly GClass2809 gclass2809_0;

	// Token: 0x0400D6F3 RID: 55027
	protected readonly ItemUiContext itemUiContext_1;

	// Token: 0x0400D6F4 RID: 55028
	private readonly Action action_1;

	// Token: 0x0400D6F5 RID: 55029
	private readonly GClass3052 gclass3052_0;

	// Token: 0x020029BE RID: 10686
	[CompilerGenerated]
	private sealed class Class2454
	{
		// Token: 0x0600D4D5 RID: 54485 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x0400D6F6 RID: 55030
		public GClass3022 gclass3022_0;

		// Token: 0x0400D6F7 RID: 55031
		public Action<bool> handler;
	}

	// Token: 0x020029BF RID: 10687
	[CompilerGenerated]
	private sealed class Class2455
	{
		// Token: 0x0600D4D6 RID: 54486 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x0400D6F8 RID: 55032
		public GClass3022 gclass3022_0;

		// Token: 0x0400D6F9 RID: 55033
		public Action<IEffect> handler;
	}

	// Token: 0x020029C0 RID: 10688
	[CompilerGenerated]
	private sealed class Class2456
	{
		// Token: 0x0600D4D7 RID: 54487 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(GEventArgs1 _)
		{
			throw null;
		}

		// Token: 0x0600D4D8 RID: 54488 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1()
		{
			throw null;
		}

		// Token: 0x0400D6FA RID: 55034
		public Action<IEnumerable<string>> handler;

		// Token: 0x0400D6FB RID: 55035
		public GClass3022 gclass3022_0;

		// Token: 0x0400D6FC RID: 55036
		public Action unsubscriber;
	}

	// Token: 0x020029C1 RID: 10689
	[CompilerGenerated]
	private sealed class Class2457
	{
		// Token: 0x0600D4D9 RID: 54489 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(GEventArgs1 activeEvent)
		{
			throw null;
		}

		// Token: 0x0600D4DA RID: 54490 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1()
		{
			throw null;
		}

		// Token: 0x0400D6FD RID: 55037
		public GClass3022 gclass3022_0;

		// Token: 0x0400D6FE RID: 55038
		public Action<IEnumerable<string>> handler;

		// Token: 0x0400D6FF RID: 55039
		public Action unsubscriber;
	}

	// Token: 0x020029C2 RID: 10690
	[CompilerGenerated]
	private sealed class Class2458
	{
		// Token: 0x0600D4DB RID: 54491 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x0400D700 RID: 55040
		public IItemOwner itemOwner;

		// Token: 0x0400D701 RID: 55041
		public Action<GEventArgs1> handler;
	}
}
