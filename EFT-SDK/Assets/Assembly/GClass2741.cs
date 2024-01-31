using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;

// Token: 0x02002493 RID: 9363
public static class GClass2741
{
	// Token: 0x0600BBA7 RID: 48039 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<GClass2495> GetPrioritizedGridsForLoot(this EquipmentClass equipment, Item item)
	{
		throw null;
	}

	// Token: 0x0600BBA8 RID: 48040 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<GClass2495> GetPrioritizedGridsForUnloadedObject(this EquipmentClass equipment, bool backpackIncluded = false)
	{
		throw null;
	}

	// Token: 0x0600BBA9 RID: 48041 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<Slot> GetAllSlots(this EquipmentClass equipment)
	{
		throw null;
	}

	// Token: 0x0600BBAA RID: 48042 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void GetSlotsByNameNonAlloc(this EquipmentClass equipment, IEnumerable<EquipmentSlot> slotNames, [NotNull] IList<Slot> preallocatedList)
	{
		throw null;
	}

	// Token: 0x0600BBAB RID: 48043 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<Slot> GetSlotsByName(this EquipmentClass equipment, IEnumerable<EquipmentSlot> slotNames)
	{
		throw null;
	}

	// Token: 0x0600BBAC RID: 48044 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<LootItemClass> GetCollections(this EquipmentClass equipment, IEnumerable<EquipmentSlot> slotNames)
	{
		throw null;
	}

	// Token: 0x02002494 RID: 9364
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2073
	{
		// Token: 0x0600BBAD RID: 48045 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_0(Slot x)
		{
			throw null;
		}

		// Token: 0x0400BE23 RID: 48675
		public static readonly GClass2741.Class2073 class2073_0;

		// Token: 0x0400BE24 RID: 48676
		public static Func<Slot, Item> func_0;
	}
}
