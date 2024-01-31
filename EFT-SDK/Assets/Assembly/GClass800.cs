using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;
using EFT.InventoryLogic;
using UnityEngine;

// Token: 0x020008D6 RID: 2262
public class GClass800 : GInterface33
{
	// Token: 0x170008C1 RID: 2241
	// (get) Token: 0x06003326 RID: 13094 RVA: 0x00002050 File Offset: 0x00000250
	public List<GClass799> RepairKitsCollections
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170008C2 RID: 2242
	// (get) Token: 0x06003327 RID: 13095 RVA: 0x00002050 File Offset: 0x00000250
	public IEnumerable<GInterface182> Repairers
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170008C3 RID: 2243
	// (get) Token: 0x06003328 RID: 13096 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003329 RID: 13097 RVA: 0x00002050 File Offset: 0x00000250
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

	// Token: 0x0600332A RID: 13098 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddRepairKitToRepairers(GClass2726 repairKit)
	{
		throw null;
	}

	// Token: 0x0600332B RID: 13099 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float Durability()
	{
		throw null;
	}

	// Token: 0x0600332C RID: 13100 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float MaxDurability()
	{
		throw null;
	}

	// Token: 0x0600332D RID: 13101 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetCurrentDurabilityFraction()
	{
		throw null;
	}

	// Token: 0x0600332E RID: 13102 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetMaxDurabilityFraction()
	{
		throw null;
	}

	// Token: 0x0600332F RID: 13103 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float HowMuchRepairScoresCanAccept()
	{
		throw null;
	}

	// Token: 0x06003330 RID: 13104 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetEnhancementChance(float repairAmount, out double enhancementChance)
	{
		throw null;
	}

	// Token: 0x06003331 RID: 13105 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string RepairabilityText(bool isRepairKit)
	{
		throw null;
	}

	// Token: 0x06003332 RID: 13106 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetRepairQualityForDisplay()
	{
		throw null;
	}

	// Token: 0x06003333 RID: 13107 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetRepairQuality()
	{
		throw null;
	}

	// Token: 0x06003334 RID: 13108 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetRepairPrice(float repairValue, GClass799 repairKit)
	{
		throw null;
	}

	// Token: 0x06003335 RID: 13109 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsNoCorrespondingArea()
	{
		throw null;
	}

	// Token: 0x06003336 RID: 13110 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsEligibleForBuff()
	{
		throw null;
	}

	// Token: 0x06003337 RID: 13111 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool BrokenItemError()
	{
		throw null;
	}

	// Token: 0x06003338 RID: 13112 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int TemplateDurability()
	{
		throw null;
	}

	// Token: 0x06003339 RID: 13113 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ValueTuple<bool, bool> GetBuffState()
	{
		throw null;
	}

	// Token: 0x0600333A RID: 13114 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 GetDegradationValues(float repairAmount)
	{
		throw null;
	}

	// Token: 0x0600333B RID: 13115 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetPriceRate()
	{
		throw null;
	}

	// Token: 0x0600333C RID: 13116 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanRepair(GInterface182 repairer, string[] excludedCategories)
	{
		throw null;
	}

	// Token: 0x0600333D RID: 13117 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetCurrencyPrice(float amount)
	{
		throw null;
	}

	// Token: 0x0600333E RID: 13118 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> RepairItem(float repairAmount, GClass2726 draggedRepairKit)
	{
		throw null;
	}

	// Token: 0x0600333F RID: 13119 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_0(TraderClass trader)
	{
		throw null;
	}

	// Token: 0x040033E6 RID: 13286
	private Item item_0;

	// Token: 0x040033E7 RID: 13287
	private RepairableComponent repairableComponent_0;

	// Token: 0x040033E8 RID: 13288
	private ItemAttributeClass gclass2745_0;

	// Token: 0x040033E9 RID: 13289
	private ItemAttributeClass gclass2745_1;

	// Token: 0x040033EA RID: 13290
	private List<GInterface182> list_0;

	// Token: 0x040033EB RID: 13291
	private GClass2087 gclass2087_0;

	// Token: 0x040033EC RID: 13292
	[CompilerGenerated]
	private readonly List<GClass799> list_1;

	// Token: 0x040033ED RID: 13293
	[CompilerGenerated]
	private GInterface182 ginterface182_0;

	// Token: 0x020008D8 RID: 2264
	[CompilerGenerated]
	[Serializable]
	private sealed class Class467
	{
		// Token: 0x06003347 RID: 13127 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(ItemAttributeClass x)
		{
			throw null;
		}

		// Token: 0x06003348 RID: 13128 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(ItemAttributeClass x)
		{
			throw null;
		}

		// Token: 0x040033F4 RID: 13300
		public static readonly GClass800.Class467 class467_0;

		// Token: 0x040033F5 RID: 13301
		public static Predicate<ItemAttributeClass> predicate_0;

		// Token: 0x040033F6 RID: 13302
		public static Predicate<ItemAttributeClass> predicate_1;
	}
}
