using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;

// Token: 0x0200235C RID: 9052
public class LootItemClass : ContainerCollection, GInterface304
{
	// Token: 0x17001F73 RID: 8051
	// (get) Token: 0x0600B687 RID: 46727 RVA: 0x00002050 File Offset: 0x00000250
	[NotNull]
	public virtual IEnumerable<Slot> AllSlots
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001F74 RID: 8052
	// (get) Token: 0x0600B688 RID: 46728 RVA: 0x00002050 File Offset: 0x00000250
	[NotNull]
	public virtual IEnumerable<Slot> AllSlotsWithoutArrayInside
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001F75 RID: 8053
	// (get) Token: 0x0600B689 RID: 46729 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsEmpty
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001F76 RID: 8054
	// (get) Token: 0x0600B68A RID: 46730 RVA: 0x00002050 File Offset: 0x00000250
	[NotNull]
	public override IEnumerable<IContainer> Containers
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600B68B RID: 46731 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Item FindItem(string itemId)
	{
		throw null;
	}

	// Token: 0x17001F77 RID: 8055
	// (get) Token: 0x0600B68C RID: 46732 RVA: 0x00002050 File Offset: 0x00000250
	public override bool CanSellOnRagfair
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001F78 RID: 8056
	// (get) Token: 0x0600B68D RID: 46733 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsAllowedToSort
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001F79 RID: 8057
	// (get) Token: 0x0600B68E RID: 46734 RVA: 0x00002050 File Offset: 0x00000250
	public override bool MarkedAsSpawnedInSession
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001F7A RID: 8058
	// (get) Token: 0x0600B68F RID: 46735 RVA: 0x00002050 File Offset: 0x00000250
	public IEnumerable<Slot> VitalParts
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001F7B RID: 8059
	// (get) Token: 0x0600B690 RID: 46736 RVA: 0x00002050 File Offset: 0x00000250
	public IEnumerable<Slot> MissingVitalParts
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001F7C RID: 8060
	// (get) Token: 0x0600B691 RID: 46737 RVA: 0x00002050 File Offset: 0x00000250
	private int Int32_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600B692 RID: 46738 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override IContainer GetContainer([NotNull] string containerId)
	{
		throw null;
	}

	// Token: 0x0600B693 RID: 46739 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetHashSum()
	{
		throw null;
	}

	// Token: 0x0600B694 RID: 46740 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_7()
	{
		throw null;
	}

	// Token: 0x0600B695 RID: 46741 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetLastForbiddenItem(out Item item)
	{
		throw null;
	}

	// Token: 0x0600B696 RID: 46742 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual GStruct412 Apply(TraderControllerClass itemController, Item item, int count, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600B697 RID: 46743 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Slot method_8(Slot x)
	{
		throw null;
	}

	// Token: 0x0600B698 RID: 46744 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GClass2495 method_9(GClass2495 x)
	{
		throw null;
	}

	// Token: 0x0400BA2B RID: 47659
	public GClass2495[] Grids;

	// Token: 0x0400BA2C RID: 47660
	public Slot[] Slots;

	// Token: 0x0400BA2D RID: 47661
	private static readonly List<Item> list_0;

	// Token: 0x0200235D RID: 9053
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2001
	{
		// Token: 0x0600B699 RID: 46745 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<Slot> method_0(Slot container)
		{
			throw null;
		}

		// Token: 0x0600B69A RID: 46746 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<Slot> method_1(ContainerCollection x)
		{
			throw null;
		}

		// Token: 0x0600B69B RID: 46747 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<Slot> method_2(Slot container)
		{
			throw null;
		}

		// Token: 0x0600B69C RID: 46748 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<Slot> method_3(ContainerCollection x)
		{
			throw null;
		}

		// Token: 0x0600B69D RID: 46749 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_4(GClass2495 x)
		{
			throw null;
		}

		// Token: 0x0600B69E RID: 46750 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_5(Slot x)
		{
			throw null;
		}

		// Token: 0x0600B69F RID: 46751 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_6(Item x)
		{
			throw null;
		}

		// Token: 0x0600B6A0 RID: 46752 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_7(Slot x)
		{
			throw null;
		}

		// Token: 0x0600B6A1 RID: 46753 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_8(Slot x)
		{
			throw null;
		}

		// Token: 0x0600B6A2 RID: 46754 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_9(GClass2495 grid)
		{
			throw null;
		}

		// Token: 0x0600B6A3 RID: 46755 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_10(GClass2495 x)
		{
			throw null;
		}

		// Token: 0x0600B6A4 RID: 46756 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal EItemAttributeDisplayType method_11()
		{
			throw null;
		}

		// Token: 0x0400BA2E RID: 47662
		public static readonly LootItemClass.Class2001 class2001_0;

		// Token: 0x0400BA2F RID: 47663
		public static Func<ContainerCollection, IEnumerable<Slot>> func_0;

		// Token: 0x0400BA30 RID: 47664
		public static Func<Slot, IEnumerable<Slot>> func_1;

		// Token: 0x0400BA31 RID: 47665
		public static Func<ContainerCollection, IEnumerable<Slot>> func_2;

		// Token: 0x0400BA32 RID: 47666
		public static Func<Slot, IEnumerable<Slot>> func_3;

		// Token: 0x0400BA33 RID: 47667
		public static Func<GClass2495, int> func_4;

		// Token: 0x0400BA34 RID: 47668
		public static Func<Slot, Item> func_5;

		// Token: 0x0400BA35 RID: 47669
		public static Func<Item, bool> func_6;

		// Token: 0x0400BA36 RID: 47670
		public static Func<Slot, bool> func_7;

		// Token: 0x0400BA37 RID: 47671
		public static Func<Slot, bool> func_8;

		// Token: 0x0400BA38 RID: 47672
		public static Func<GClass2495, int> func_9;

		// Token: 0x0400BA39 RID: 47673
		public static Func<GClass2495, int> func_10;

		// Token: 0x0400BA3A RID: 47674
		public static Func<EItemAttributeDisplayType> func_11;
	}

	// Token: 0x0200235F RID: 9055
	[CompilerGenerated]
	private sealed class Class2003
	{
		// Token: 0x0600B6AA RID: 46762 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_0()
		{
			throw null;
		}

		// Token: 0x0600B6AB RID: 46763 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_1()
		{
			throw null;
		}

		// Token: 0x0400BA40 RID: 47680
		public int gridsCapacity;
	}
}
