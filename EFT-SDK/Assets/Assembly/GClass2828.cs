using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Diz.LanguageExtensions;
using EFT.InventoryLogic;

// Token: 0x0200257A RID: 9594
public class GClass2828
{
	// Token: 0x0600BFF2 RID: 49138 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<Mod> GetInstalledMods(Weapon weapon)
	{
		throw null;
	}

	// Token: 0x0600BFF3 RID: 49139 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckIfAlreadyBuilt(IEnumerable<Item> installedMods, Weapon assemblingWeapon)
	{
		throw null;
	}

	// Token: 0x0600BFF4 RID: 49140 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<bool> Assemble(Weapon itemBody, Weapon buildWeapon, InventoryControllerClass inventoryController, IEnumerable<Item> playerItems)
	{
		throw null;
	}

	// Token: 0x0600BFF5 RID: 49141 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GStruct415<List<GStruct413<GClass2782>>> method_0(Weapon itemBody, Weapon buildWeapon, InventoryControllerClass inventoryController, IEnumerable<Item> playerItems, bool simulate = true)
	{
		throw null;
	}

	// Token: 0x0600BFF6 RID: 49142 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_1(Error error)
	{
		throw null;
	}

	// Token: 0x0600BFF7 RID: 49143 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GStruct415<List<GStruct413<GClass2782>>> method_2(Item item, List<GClass2828.Class2143> modsWithSlots, TraderControllerClass itemController, bool simulate)
	{
		throw null;
	}

	// Token: 0x0600BFF8 RID: 49144 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<T> method_3<T>(Stack<Slot> slots, Func<Mod, Slot, T> selector)
	{
		throw null;
	}

	// Token: 0x0600BFF9 RID: 49145 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void smethod_0(Mod processingItem, GClass2828.Class2143 processingSlot, ref GClass2828.Struct749 struct749_0)
	{
		throw null;
	}

	// Token: 0x0200257B RID: 9595
	public sealed class Class2143
	{
		// Token: 0x0600BFFA RID: 49146 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400C1A0 RID: 49568
		public readonly Mod Mod;

		// Token: 0x0400C1A1 RID: 49569
		public readonly string SlotId;
	}

	// Token: 0x0200257C RID: 9596
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2144
	{
		// Token: 0x0600BFFB RID: 49147 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_0(Slot x)
		{
			throw null;
		}

		// Token: 0x0600BFFC RID: 49148 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_1(Item x)
		{
			throw null;
		}

		// Token: 0x0600BFFD RID: 49149 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass2828.Class2143 method_2(Mod mod, Slot slot)
		{
			throw null;
		}

		// Token: 0x0600BFFE RID: 49150 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_3(Mod item)
		{
			throw null;
		}

		// Token: 0x0600BFFF RID: 49151 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Mod method_4(Mod mod, Slot slot)
		{
			throw null;
		}

		// Token: 0x0400C1A2 RID: 49570
		public static readonly GClass2828.Class2144 class2144_0;

		// Token: 0x0400C1A3 RID: 49571
		public static Func<Slot, Item> func_0;

		// Token: 0x0400C1A4 RID: 49572
		public static Func<Item, string> func_1;

		// Token: 0x0400C1A5 RID: 49573
		public static Func<Mod, Slot, GClass2828.Class2143> func_2;

		// Token: 0x0400C1A6 RID: 49574
		public static Func<Mod, bool> func_3;

		// Token: 0x0400C1A7 RID: 49575
		public static Func<Mod, Slot, Mod> func_4;
	}

	// Token: 0x0200257D RID: 9597
	[CompilerGenerated]
	private sealed class Class2145
	{
		// Token: 0x0600C000 RID: 49152 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GStruct415<List<GStruct413<GClass2782>>> method_0()
		{
			throw null;
		}

		// Token: 0x0400C1A8 RID: 49576
		public GClass2828 gclass2828_0;

		// Token: 0x0400C1A9 RID: 49577
		public Weapon itemBody;

		// Token: 0x0400C1AA RID: 49578
		public Weapon buildWeapon;

		// Token: 0x0400C1AB RID: 49579
		public InventoryControllerClass inventoryController;

		// Token: 0x0400C1AC RID: 49580
		public IEnumerable<Item> playerItems;
	}

	// Token: 0x0200257F RID: 9599
	[CompilerGenerated]
	[StructLayout(LayoutKind.Auto)]
	public struct Struct749
	{
		// Token: 0x0400C1B9 RID: 49593
		public List<GClass2828.Class2143> modsToInstall;

		// Token: 0x0400C1BA RID: 49594
		public List<Mod> playerMods;

		// Token: 0x0400C1BB RID: 49595
		public List<GClass2828.Class2143> modsWithSlots;

		// Token: 0x0400C1BC RID: 49596
		public GClass2495 sortingTableGrid;

		// Token: 0x0400C1BD RID: 49597
		public List<GStruct413<GClass2782>> moveOperations;

		// Token: 0x0400C1BE RID: 49598
		public InventoryControllerClass inventoryController;
	}

	// Token: 0x02002580 RID: 9600
	[CompilerGenerated]
	private sealed class Class2146
	{
		// Token: 0x0600C003 RID: 49155 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass2828.Class2143 x)
		{
			throw null;
		}

		// Token: 0x0400C1BF RID: 49599
		public Mod item;
	}

	// Token: 0x02002581 RID: 9601
	[CompilerGenerated]
	private sealed class Class2147
	{
		// Token: 0x0600C004 RID: 49156 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Mod playerItem)
		{
			throw null;
		}

		// Token: 0x0400C1C0 RID: 49600
		public GClass2828.Class2143 slot;
	}

	// Token: 0x02002582 RID: 9602
	[CompilerGenerated]
	private sealed class Class2148
	{
		// Token: 0x0600C005 RID: 49157 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass2828.Class2143 x)
		{
			throw null;
		}

		// Token: 0x0400C1C1 RID: 49601
		public Mod innerMod;
	}
}
