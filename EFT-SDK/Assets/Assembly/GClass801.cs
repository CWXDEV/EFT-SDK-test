using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;
using EFT.InventoryLogic;
using UnityEngine;

// Token: 0x020008DA RID: 2266
public class GClass801 : GInterface33
{
	// Token: 0x170008C6 RID: 2246
	// (get) Token: 0x0600334B RID: 13131 RVA: 0x00002050 File Offset: 0x00000250
	public List<GClass799> RepairKitsCollections
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170008C7 RID: 2247
	// (get) Token: 0x0600334C RID: 13132 RVA: 0x00002050 File Offset: 0x00000250
	public IEnumerable<GInterface182> Repairers
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170008C8 RID: 2248
	// (get) Token: 0x0600334D RID: 13133 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600334E RID: 13134 RVA: 0x00002050 File Offset: 0x00000250
	public GInterface182 CurrentRepairer
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x0600334F RID: 13135 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int method_0(Item item)
	{
		throw null;
	}

	// Token: 0x06003350 RID: 13136 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddRepairKitToRepairers(GClass2726 repairKit)
	{
		throw null;
	}

	// Token: 0x06003351 RID: 13137 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetEnhancementChance(float repairAmount, out double enhancementChance)
	{
		throw null;
	}

	// Token: 0x06003352 RID: 13138 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string RepairabilityText(bool isRepairKit)
	{
		throw null;
	}

	// Token: 0x06003353 RID: 13139 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetRepairQualityForDisplay()
	{
		throw null;
	}

	// Token: 0x06003354 RID: 13140 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetRepairQuality()
	{
		throw null;
	}

	// Token: 0x06003355 RID: 13141 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetRepairPrice(float repairAmountLeft, GClass799 repairKit)
	{
		throw null;
	}

	// Token: 0x06003356 RID: 13142 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsNoCorrespondingArea()
	{
		throw null;
	}

	// Token: 0x06003357 RID: 13143 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsEligibleForBuff()
	{
		throw null;
	}

	// Token: 0x06003358 RID: 13144 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool BrokenItemError()
	{
		throw null;
	}

	// Token: 0x06003359 RID: 13145 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int TemplateDurability()
	{
		throw null;
	}

	// Token: 0x0600335A RID: 13146 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float Durability()
	{
		throw null;
	}

	// Token: 0x0600335B RID: 13147 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float MaxDurability()
	{
		throw null;
	}

	// Token: 0x0600335C RID: 13148 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float HowMuchRepairScoresCanAccept()
	{
		throw null;
	}

	// Token: 0x0600335D RID: 13149 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ValueTuple<bool, bool> GetBuffState()
	{
		throw null;
	}

	// Token: 0x0600335E RID: 13150 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetCurrentDurabilityFraction()
	{
		throw null;
	}

	// Token: 0x0600335F RID: 13151 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetMaxDurabilityFraction()
	{
		throw null;
	}

	// Token: 0x06003360 RID: 13152 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 GetDegradationValues(float repairAmountLeft)
	{
		throw null;
	}

	// Token: 0x06003361 RID: 13153 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetPriceRate()
	{
		throw null;
	}

	// Token: 0x06003362 RID: 13154 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanRepair(GInterface182 repairer, string[] excludedCategories)
	{
		throw null;
	}

	// Token: 0x06003363 RID: 13155 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_1(GInterface182 repairer, Item item, string[] excludedCategories)
	{
		throw null;
	}

	// Token: 0x06003364 RID: 13156 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetCurrencyPrice(float repairAmountLeft)
	{
		throw null;
	}

	// Token: 0x06003365 RID: 13157 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int method_2(Item item, float amount)
	{
		throw null;
	}

	// Token: 0x06003366 RID: 13158 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> RepairItem(float repairAmount, GClass2726 draggedRepairKit)
	{
		throw null;
	}

	// Token: 0x06003367 RID: 13159 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_3(TraderClass trader)
	{
		throw null;
	}

	// Token: 0x06003368 RID: 13160 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_4(GClass801.Class468 item)
	{
		throw null;
	}

	// Token: 0x06003369 RID: 13161 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_5(GClass801.Class468 item)
	{
		throw null;
	}

	// Token: 0x0600336A RID: 13162 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_6(GClass801.Class468 item)
	{
		throw null;
	}

	// Token: 0x0600336B RID: 13163 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_7(GClass801.Class468 item)
	{
		throw null;
	}

	// Token: 0x0600336C RID: 13164 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private double method_8(GClass801.Class468 subItem)
	{
		throw null;
	}

	// Token: 0x040033FD RID: 13309
	[CompilerGenerated]
	private readonly List<GClass799> list_0;

	// Token: 0x040033FE RID: 13310
	private Item item_0;

	// Token: 0x040033FF RID: 13311
	private GClass801.Class468[] class468_0;

	// Token: 0x04003400 RID: 13312
	private GClass2087 gclass2087_0;

	// Token: 0x04003401 RID: 13313
	private List<GInterface182> list_1;

	// Token: 0x04003402 RID: 13314
	[CompilerGenerated]
	private GInterface182 ginterface182_0;

	// Token: 0x020008DB RID: 2267
	private class Class468
	{
		// Token: 0x0600336D RID: 13165 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool NotNull()
		{
			throw null;
		}

		// Token: 0x04003403 RID: 13315
		public Item Item;

		// Token: 0x04003404 RID: 13316
		public ItemAttributeClass Durability;

		// Token: 0x04003405 RID: 13317
		public ItemAttributeClass MaxDurability;

		// Token: 0x04003406 RID: 13318
		public RepairableComponent Repairable;

		// Token: 0x020008DC RID: 2268
		[CompilerGenerated]
		[Serializable]
		private sealed class Class469
		{
			// Token: 0x0600336E RID: 13166 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(ItemAttributeClass attribute)
			{
				throw null;
			}

			// Token: 0x0600336F RID: 13167 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(ItemAttributeClass attribute)
			{
				throw null;
			}

			// Token: 0x04003407 RID: 13319
			public static readonly GClass801.Class468.Class469 class469_0;

			// Token: 0x04003408 RID: 13320
			public static Predicate<ItemAttributeClass> predicate_0;

			// Token: 0x04003409 RID: 13321
			public static Predicate<ItemAttributeClass> predicate_1;
		}
	}

	// Token: 0x020008DE RID: 2270
	[CompilerGenerated]
	[Serializable]
	private sealed class Class471
	{
		// Token: 0x06003377 RID: 13175 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal Item method_0(RepairableComponent repairable)
		{
			throw null;
		}

		// Token: 0x06003378 RID: 13176 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass801.Class468 method_1(Item subItem)
		{
			throw null;
		}

		// Token: 0x06003379 RID: 13177 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_2(GClass801.Class468 info)
		{
			throw null;
		}

		// Token: 0x0600337A RID: 13178 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_3(GClass801.Class468 repairable)
		{
			throw null;
		}

		// Token: 0x0600337B RID: 13179 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_4(GClass801.Class468 repairableItem)
		{
			throw null;
		}

		// Token: 0x0600337C RID: 13180 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_5(GClass801.Class468 repairable)
		{
			throw null;
		}

		// Token: 0x0600337D RID: 13181 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_6(GClass801.Class468 subItem)
		{
			throw null;
		}

		// Token: 0x0600337E RID: 13182 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_7(GClass801.Class468 subItem)
		{
			throw null;
		}

		// Token: 0x0600337F RID: 13183 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_8(GClass801.Class468 subItem)
		{
			throw null;
		}

		// Token: 0x04003410 RID: 13328
		public static readonly GClass801.Class471 class471_0;

		// Token: 0x04003411 RID: 13329
		public static Func<RepairableComponent, Item> func_0;

		// Token: 0x04003412 RID: 13330
		public static Func<Item, GClass801.Class468> func_1;

		// Token: 0x04003413 RID: 13331
		public static Func<GClass801.Class468, bool> func_2;

		// Token: 0x04003414 RID: 13332
		public static Func<GClass801.Class468, bool> func_3;

		// Token: 0x04003415 RID: 13333
		public static Func<GClass801.Class468, int> func_4;

		// Token: 0x04003416 RID: 13334
		public static Func<GClass801.Class468, float> func_5;

		// Token: 0x04003417 RID: 13335
		public static Func<GClass801.Class468, float> func_6;

		// Token: 0x04003418 RID: 13336
		public static Func<GClass801.Class468, float> func_7;

		// Token: 0x04003419 RID: 13337
		public static Func<GClass801.Class468, float> func_8;
	}

	// Token: 0x020008DF RID: 2271
	[CompilerGenerated]
	private sealed class Class472
	{
		// Token: 0x06003380 RID: 13184 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal double method_0(GClass801.Class468 itemInfo)
		{
			throw null;
		}

		// Token: 0x0400341A RID: 13338
		public GClass801 gclass801_0;

		// Token: 0x0400341B RID: 13339
		public float repairAmount;

		// Token: 0x0400341C RID: 13340
		public bool any;
	}

	// Token: 0x020008E0 RID: 2272
	[CompilerGenerated]
	private sealed class Class473
	{
		// Token: 0x06003381 RID: 13185 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass801.Class468 subItem)
		{
			throw null;
		}

		// Token: 0x0400341D RID: 13341
		public GClass801 gclass801_0;

		// Token: 0x0400341E RID: 13342
		public GInterface182 repairer;

		// Token: 0x0400341F RID: 13343
		public string[] excludedCategories;
	}
}
