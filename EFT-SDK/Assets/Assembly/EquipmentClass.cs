using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

// Token: 0x02002491 RID: 9361
public class EquipmentClass : LootItemClass
{
	// Token: 0x0600BB9C RID: 48028 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Slot GetSlot(EquipmentSlot slotName)
	{
		throw null;
	}

	// Token: 0x17002165 RID: 8549
	// (get) Token: 0x0600BB9D RID: 48029 RVA: 0x00002050 File Offset: 0x00000250
	public IReadOnlyList<Slot> ContainerSlots
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002166 RID: 8550
	// (get) Token: 0x0600BB9E RID: 48030 RVA: 0x00002050 File Offset: 0x00000250
	public IReadOnlyList<Slot> PaymentSlots
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600BB9F RID: 48031 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_10(ContainerCollection container)
	{
		throw null;
	}

	// Token: 0x0600BBA0 RID: 48032 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_11(IEnumerable<Slot> slots)
	{
		throw null;
	}

	// Token: 0x0600BBA1 RID: 48033 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_12(Item item)
	{
		throw null;
	}

	// Token: 0x0600BBA2 RID: 48034 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetEquipmentWeight()
	{
		throw null;
	}

	// Token: 0x0600BBA3 RID: 48035 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetEquipmentWeightEliteSkill()
	{
		throw null;
	}

	// Token: 0x0400BE18 RID: 48664
	public static readonly EquipmentSlot[] AllSlotNames;

	// Token: 0x0400BE19 RID: 48665
	public static readonly EquipmentSlot[] AllVisualSlotNames;

	// Token: 0x0400BE1A RID: 48666
	public static readonly EquipmentSlot[] TraderServicesEligibleSlots;

	// Token: 0x0400BE1B RID: 48667
	private readonly Slot[] slot_0;

	// Token: 0x0400BE1C RID: 48668
	private readonly EquipmentSlot[] equipmentSlot_0;

	// Token: 0x0400BE1D RID: 48669
	private IReadOnlyList<Slot> ireadOnlyList_0;

	// Token: 0x0400BE1E RID: 48670
	private IReadOnlyList<Slot> ireadOnlyList_1;

	// Token: 0x02002492 RID: 9362
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2072
	{
		// Token: 0x0600BBA4 RID: 48036 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_0(Slot x)
		{
			throw null;
		}

		// Token: 0x0600BBA5 RID: 48037 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_1(Slot slot)
		{
			throw null;
		}

		// Token: 0x0600BBA6 RID: 48038 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_2(Item x)
		{
			throw null;
		}

		// Token: 0x0400BE1F RID: 48671
		public static readonly EquipmentClass.Class2072 class2072_0;

		// Token: 0x0400BE20 RID: 48672
		public static Func<Slot, string> func_0;

		// Token: 0x0400BE21 RID: 48673
		public static Func<Slot, Item> func_1;

		// Token: 0x0400BE22 RID: 48674
		public static Func<Item, float> func_2;
	}
}
