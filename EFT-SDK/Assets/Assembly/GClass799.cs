using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Comfort.Common;
using EFT;
using EFT.InventoryLogic;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020008D3 RID: 2259
public class GClass799 : GInterface182
{
	// Token: 0x170008B7 RID: 2231
	// (get) Token: 0x060032F8 RID: 13048 RVA: 0x00002050 File Offset: 0x00000250
	public string RepairerId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170008B8 RID: 2232
	// (get) Token: 0x060032F9 RID: 13049 RVA: 0x00002050 File Offset: 0x00000250
	public string[] Targets
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170008B9 RID: 2233
	// (get) Token: 0x060032FA RID: 13050 RVA: 0x00002050 File Offset: 0x00000250
	public string LocalizedName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170008BA RID: 2234
	// (get) Token: 0x060032FB RID: 13051 RVA: 0x00002050 File Offset: 0x00000250
	public double Standing
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170008BB RID: 2235
	// (get) Token: 0x060032FC RID: 13052 RVA: 0x00002050 File Offset: 0x00000250
	public int LoyaltyLevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170008BC RID: 2236
	// (get) Token: 0x060032FD RID: 13053 RVA: 0x00002050 File Offset: 0x00000250
	public int MaxLoyaltyLevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170008BD RID: 2237
	// (get) Token: 0x060032FE RID: 13054 RVA: 0x00002050 File Offset: 0x00000250
	public float CurrencyCoefficient
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060032FF RID: 13055 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool AddRepairKit(GClass2726 repairKit)
	{
		throw null;
	}

	// Token: 0x06003300 RID: 13056 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool RemoveRepairKit(GClass2726 repairKit)
	{
		throw null;
	}

	// Token: 0x06003301 RID: 13057 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass2726 SelectMinRepairKit(GClass2726 draggedRepairKit)
	{
		throw null;
	}

	// Token: 0x06003302 RID: 13058 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<bool> GetAndAssignAvatar(Image image, CancellationToken cancellationToken)
	{
		throw null;
	}

	// Token: 0x06003303 RID: 13059 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetRepairQuality(Item item)
	{
		throw null;
	}

	// Token: 0x06003304 RID: 13060 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetRepairQualityForDisplay(Item item)
	{
		throw null;
	}

	// Token: 0x06003305 RID: 13061 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetRepairPriceCoefficient(Item item)
	{
		throw null;
	}

	// Token: 0x06003306 RID: 13062 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetRepairPoints()
	{
		throw null;
	}

	// Token: 0x06003307 RID: 13063 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetEnhancementChance(Item item, float receiveDurabilityPercent, out double enhancementChance)
	{
		throw null;
	}

	// Token: 0x06003308 RID: 13064 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> RepairItems(RepairItem repairItem, GClass2726 draggedRepairKit)
	{
		throw null;
	}

	// Token: 0x06003309 RID: 13065 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 GetDegradationValues(RepairableComponent repairable, Item item)
	{
		throw null;
	}

	// Token: 0x0600330A RID: 13066 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetRepairPrice(double repairValue, Item itemToRepair)
	{
		throw null;
	}

	// Token: 0x040033DE RID: 13278
	private GClass2087 gclass2087_0;

	// Token: 0x040033DF RID: 13279
	private RepairKitClass gclass2614_0;

	// Token: 0x040033E0 RID: 13280
	private HashSet<GClass2726> hashSet_0;

	// Token: 0x040033E1 RID: 13281
	private Sprite sprite_0;

	// Token: 0x040033E2 RID: 13282
	private static readonly MongoID mongoID_0;

	// Token: 0x020008D4 RID: 2260
	[CompilerGenerated]
	[Serializable]
	private sealed class Class465
	{
		// Token: 0x0600330B RID: 13067 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_0(GClass2726 repairKit)
		{
			throw null;
		}

		// Token: 0x0600330C RID: 13068 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_1(GClass2726 repairKit)
		{
			throw null;
		}

		// Token: 0x040033E3 RID: 13283
		public static readonly GClass799.Class465 class465_0;

		// Token: 0x040033E4 RID: 13284
		public static Func<GClass2726, float> func_0;

		// Token: 0x040033E5 RID: 13285
		public static Func<GClass2726, float> func_1;
	}
}
