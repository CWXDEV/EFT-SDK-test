using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EFT.InventoryLogic;

// Token: 0x02002442 RID: 9282
public class GClass2681 : SearchableItemClass
{
	// Token: 0x1700213A RID: 8506
	// (get) Token: 0x0600BA77 RID: 47735 RVA: 0x00002050 File Offset: 0x00000250
	public override IEnumerable<EItemInfoButton> ItemInteractionButtons
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600BA78 RID: 47736 RVA: 0x00002050 File Offset: 0x00000250
	[OnDeserializing]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_12(StreamingContext context)
	{
		throw null;
	}

	// Token: 0x0600BA79 RID: 47737 RVA: 0x00002050 File Offset: 0x00000250
	[DebuggerHidden]
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerable<EItemInfoButton> method_13()
	{
		throw null;
	}

	// Token: 0x0400BD24 RID: 48420
	public readonly RepairableComponent Repairable;

	// Token: 0x0400BD25 RID: 48421
	public BuffComponent Buff;

	// Token: 0x02002443 RID: 9283
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2048
	{
		// Token: 0x0600BA7A RID: 47738 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Slot slot)
		{
			throw null;
		}

		// Token: 0x0600BA7B RID: 47739 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(Slot slot)
		{
			throw null;
		}

		// Token: 0x0400BD26 RID: 48422
		public static readonly GClass2681.Class2048 class2048_0;

		// Token: 0x0400BD27 RID: 48423
		public static Func<Slot, bool> func_0;

		// Token: 0x0400BD28 RID: 48424
		public static Func<Slot, bool> func_1;
	}
}
