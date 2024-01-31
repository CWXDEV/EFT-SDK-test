using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;

// Token: 0x02002496 RID: 9366
public static class GClass2743
{
	// Token: 0x0600BBB0 RID: 48048 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool AffectsDiscardLimits(this IItemOwner itemController)
	{
		throw null;
	}

	// Token: 0x0600BBB1 RID: 48049 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dictionary<ECurrencyType, int> GetMoneySums(IEnumerable<Item> items)
	{
		throw null;
	}

	// Token: 0x0600BBB2 RID: 48050 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool HasDiscardLimits(this Item item, [CanBeNull] ItemAddress to, out int limit)
	{
		throw null;
	}

	// Token: 0x0600BBB3 RID: 48051 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool HasKnownMalfunction(this TraderControllerClass controller, Weapon weapon)
	{
		throw null;
	}

	// Token: 0x0600BBB4 RID: 48052 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool HasKnownMalfType(this TraderControllerClass controller, Weapon weapon)
	{
		throw null;
	}

	// Token: 0x0600BBB5 RID: 48053 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsItemEquipped(this GInterface313 itemController, Item item)
	{
		throw null;
	}

	// Token: 0x0600BBB6 RID: 48054 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass2763 FindSlotToPickUp(this GInterface313 itemController, Item item)
	{
		throw null;
	}

	// Token: 0x0600BBB7 RID: 48055 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass2765 FindGridToPickUp(this GInterface313 itemController, Item item, IItemOwner itemOwner)
	{
		throw null;
	}

	// Token: 0x0600BBB8 RID: 48056 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<Item> GetTopLevelItems(this IEnumerable<LootItemClass> collections)
	{
		throw null;
	}

	// Token: 0x0400BE27 RID: 48679
	private static readonly EquipmentSlot[] equipmentSlot_0;

	// Token: 0x0400BE28 RID: 48680
	private static readonly EquipmentSlot[] equipmentSlot_1;

	// Token: 0x0400BE29 RID: 48681
	private static readonly EquipmentSlot[] equipmentSlot_2;

	// Token: 0x0400BE2A RID: 48682
	private static readonly EquipmentSlot[] equipmentSlot_3;

	// Token: 0x0400BE2B RID: 48683
	private static readonly EquipmentSlot[] equipmentSlot_4;

	// Token: 0x0400BE2C RID: 48684
	private static readonly EquipmentSlot[] equipmentSlot_5;

	// Token: 0x0400BE2D RID: 48685
	private static readonly EquipmentSlot[] equipmentSlot_6;

	// Token: 0x0400BE2E RID: 48686
	private static readonly EquipmentSlot[] equipmentSlot_7;

	// Token: 0x0400BE2F RID: 48687
	private static readonly EquipmentSlot[] equipmentSlot_8;

	// Token: 0x0400BE30 RID: 48688
	private static readonly EquipmentSlot[] equipmentSlot_9;

	// Token: 0x0400BE31 RID: 48689
	private static readonly EquipmentSlot[] equipmentSlot_10;

	// Token: 0x0400BE32 RID: 48690
	private static readonly EquipmentSlot[] equipmentSlot_11;

	// Token: 0x02002497 RID: 9367
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2074
	{
		// Token: 0x0600BBB9 RID: 48057 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal ECurrencyType method_0(ECurrencyType x)
		{
			throw null;
		}

		// Token: 0x0600BBBA RID: 48058 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_1(ECurrencyType x)
		{
			throw null;
		}

		// Token: 0x0600BBBB RID: 48059 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_2(GClass2765 x)
		{
			throw null;
		}

		// Token: 0x0400BE33 RID: 48691
		public static readonly GClass2743.Class2074 class2074_0;

		// Token: 0x0400BE34 RID: 48692
		public static Func<ECurrencyType, ECurrencyType> func_0;

		// Token: 0x0400BE35 RID: 48693
		public static Func<ECurrencyType, int> func_1;

		// Token: 0x0400BE36 RID: 48694
		public static Func<GClass2765, bool> func_2;
	}

	// Token: 0x02002498 RID: 9368
	[CompilerGenerated]
	private sealed class Class2075
	{
		// Token: 0x0600BBBC RID: 48060 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Slot slot)
		{
			throw null;
		}

		// Token: 0x0400BE37 RID: 48695
		public Item item;
	}

	// Token: 0x02002499 RID: 9369
	[CompilerGenerated]
	private sealed class Class2076
	{
		// Token: 0x0600BBBD RID: 48061 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass2765 method_0(GClass2495 grid)
		{
			throw null;
		}

		// Token: 0x0400BE38 RID: 48696
		public Item item;

		// Token: 0x0400BE39 RID: 48697
		public IItemOwner itemOwner;
	}
}
