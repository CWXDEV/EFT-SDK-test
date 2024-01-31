using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT;
using EFT.InventoryLogic;
using JetBrains.Annotations;

// Token: 0x02001362 RID: 4962
public static class GClass1521
{
	// Token: 0x060065A2 RID: 26018 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass1486 SerializeInventory(Inventory inventory)
	{
		throw null;
	}

	// Token: 0x060065A3 RID: 26019 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Inventory DeserializeInventory(ItemFactory itemFactory, GClass1486 descriptor)
	{
		throw null;
	}

	// Token: 0x060065A4 RID: 26020 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Inventory CloneInventory(ItemFactory itemFactory, Inventory inventory)
	{
		throw null;
	}

	// Token: 0x060065A5 RID: 26021 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass1495 SerializeNestedItem([NotNull] Item item, ItemAddress newAddress = null)
	{
		throw null;
	}

	// Token: 0x060065A6 RID: 26022 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass1496 SerializeItem([CanBeNull] Item item)
	{
		throw null;
	}

	// Token: 0x060065A7 RID: 26023 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass1496 SerializeOnlyVisibleEquipment([CanBeNull] Item item)
	{
		throw null;
	}

	// Token: 0x060065A8 RID: 26024 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static GClass1496 smethod_0([CanBeNull] Item item)
	{
		throw null;
	}

	// Token: 0x060065A9 RID: 26025 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Item DeserializeItem(ItemFactory itemFactory, Dictionary<string, Item> items, [CanBeNull] GClass1496 itemDescriptor)
	{
		throw null;
	}

	// Token: 0x060065AA RID: 26026 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Item smethod_1(ItemFactory itemFactory, Dictionary<string, Item> items, [CanBeNull] GClass1496 itemDescriptor)
	{
		throw null;
	}

	// Token: 0x060065AB RID: 26027 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass1487 SerializeFastAccess(GClass2515 fastAccess)
	{
		throw null;
	}

	// Token: 0x060065AC RID: 26028 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass1488 SerializeDiscardLimits(Dictionary<string, int> discardLimits)
	{
		throw null;
	}

	// Token: 0x060065AD RID: 26029 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass2515 DeserializeFastAccess(EquipmentClass equipment, Dictionary<string, Item> items, GClass1487 descriptor)
	{
		throw null;
	}

	// Token: 0x060065AE RID: 26030 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Dictionary<string, int> DeserializeDiscardLimits(GClass1488 descriptor)
	{
		throw null;
	}

	// Token: 0x060065AF RID: 26031 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass1497 SerializeComponent(IItemComponent component)
	{
		throw null;
	}

	// Token: 0x060065B0 RID: 26032 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DeserializeComponent(GClass1497 descriptor, Item item)
	{
		throw null;
	}

	// Token: 0x060065B1 RID: 26033 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass1520 SerializeLootData(IEnumerable<LootItemPositionClass> lootData)
	{
		throw null;
	}

	// Token: 0x060065B2 RID: 26034 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass1199 DeserializeLootData(ItemFactory itemFactory, GClass1520 lootDataDescriptor)
	{
		throw null;
	}

	// Token: 0x060065B3 RID: 26035 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass1518 SerializeJsonLootItem(LootItemPositionClass t)
	{
		throw null;
	}

	// Token: 0x060065B4 RID: 26036 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static LootItemPositionClass DeserializeJsonLootItem(ItemFactory itemFactory, Dictionary<string, Item> items, GClass1518 t)
	{
		throw null;
	}

	// Token: 0x060065B5 RID: 26037 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool smethod_2(ref GClass1521.Struct206 struct206_0)
	{
		throw null;
	}

	// Token: 0x02001363 RID: 4963
	[CompilerGenerated]
	[StructLayout(LayoutKind.Auto)]
	public struct Struct206
	{
		// Token: 0x04007258 RID: 29272
		public Item item;
	}

	// Token: 0x02001364 RID: 4964
	[CompilerGenerated]
	private sealed class Class951
	{
		// Token: 0x060065B6 RID: 26038 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal LootItemPositionClass method_0(GClass1518 x)
		{
			throw null;
		}

		// Token: 0x04007259 RID: 29273
		public ItemFactory itemFactory;
	}

	// Token: 0x02001365 RID: 4965
	[CompilerGenerated]
	[Serializable]
	private sealed class Class952
	{
		// Token: 0x060065B7 RID: 26039 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(string x)
		{
			throw null;
		}

		// Token: 0x060065B8 RID: 26040 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_1(KeyValuePair<EBodyModelPart, string> x)
		{
			throw null;
		}

		// Token: 0x060065B9 RID: 26041 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_2(KeyValuePair<EBodyModelPart, string> x)
		{
			throw null;
		}

		// Token: 0x060065BA RID: 26042 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_3(string x)
		{
			throw null;
		}

		// Token: 0x060065BB RID: 26043 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal EBodyModelPart method_4(KeyValuePair<int, string> x)
		{
			throw null;
		}

		// Token: 0x060065BC RID: 26044 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_5(KeyValuePair<int, string> x)
		{
			throw null;
		}

		// Token: 0x0400725A RID: 29274
		public static readonly GClass1521.Class952 class952_0;

		// Token: 0x0400725B RID: 29275
		public static Func<string, bool> func_0;

		// Token: 0x0400725C RID: 29276
		public static Func<KeyValuePair<EBodyModelPart, string>, int> func_1;

		// Token: 0x0400725D RID: 29277
		public static Func<KeyValuePair<EBodyModelPart, string>, string> func_2;

		// Token: 0x0400725E RID: 29278
		public static Func<string, bool> func_3;

		// Token: 0x0400725F RID: 29279
		public static Func<KeyValuePair<int, string>, EBodyModelPart> func_4;

		// Token: 0x04007260 RID: 29280
		public static Func<KeyValuePair<int, string>, string> func_5;
	}
}
