using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Comfort.Common;
using Diz.Binding;
using EFT;
using EFT.InventoryLogic;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02001D28 RID: 7464
public sealed class TraderClass : IDisposable, GInterface182
{
	// Token: 0x170017FD RID: 6141
	// (get) Token: 0x06009A72 RID: 39538 RVA: 0x00002050 File Offset: 0x00000250
	public string RepairerId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170017FE RID: 6142
	// (get) Token: 0x06009A73 RID: 39539 RVA: 0x00002050 File Offset: 0x00000250
	public string LocalizedName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170017FF RID: 6143
	// (get) Token: 0x06009A74 RID: 39540 RVA: 0x00002050 File Offset: 0x00000250
	public string[] Targets
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001800 RID: 6144
	// (get) Token: 0x06009A75 RID: 39541 RVA: 0x00002050 File Offset: 0x00000250
	public double Standing
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001801 RID: 6145
	// (get) Token: 0x06009A76 RID: 39542 RVA: 0x00002050 File Offset: 0x00000250
	public int LoyaltyLevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001802 RID: 6146
	// (get) Token: 0x06009A77 RID: 39543 RVA: 0x00002050 File Offset: 0x00000250
	public int MaxLoyaltyLevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001803 RID: 6147
	// (get) Token: 0x06009A78 RID: 39544 RVA: 0x00002050 File Offset: 0x00000250
	public float CurrencyCoefficient
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06009A79 RID: 39545 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<bool> GetAndAssignAvatar(Image image, CancellationToken cancellationToken)
	{
		throw null;
	}

	// Token: 0x17001804 RID: 6148
	// (get) Token: 0x06009A7A RID: 39546 RVA: 0x00002050 File Offset: 0x00000250
	private Dictionary<string, double> Dictionary_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001805 RID: 6149
	// (get) Token: 0x06009A7B RID: 39547 RVA: 0x00002050 File Offset: 0x00000250
	public bool AssortmentUpdateTimeout
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001806 RID: 6150
	// (get) Token: 0x06009A7C RID: 39548 RVA: 0x00002050 File Offset: 0x00000250
	public TimeSpan DelayBeforeAssortmentUpdate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001807 RID: 6151
	// (get) Token: 0x06009A7D RID: 39549 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06009A7E RID: 39550 RVA: 0x00002050 File Offset: 0x00000250
	public TraderAssortmentControllerClass CurrentAssortment
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17001808 RID: 6152
	// (get) Token: 0x06009A7F RID: 39551 RVA: 0x00002050 File Offset: 0x00000250
	public BackendConfigSettingsClass.TraderSettings Settings
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001809 RID: 6153
	// (get) Token: 0x06009A80 RID: 39552 RVA: 0x00002050 File Offset: 0x00000250
	public Profile.TraderInfo Info
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700180A RID: 6154
	// (get) Token: 0x06009A81 RID: 39553 RVA: 0x00002050 File Offset: 0x00000250
	public bool AssortmentLoading
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06009A82 RID: 39554 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public TraderClass.GStruct242? GetAssortmentPrice(StashClass stash)
	{
		throw null;
	}

	// Token: 0x06009A83 RID: 39555 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public TraderClass.GStruct242? GetUserItemPrice(Item item)
	{
		throw null;
	}

	// Token: 0x06009A84 RID: 39556 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetItemPriceOnScavSell(Item item, bool allowProhibited)
	{
		throw null;
	}

	// Token: 0x06009A85 RID: 39557 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> RepairItems(RepairItem repairItem, GClass2726 draggedRepairKit)
	{
		throw null;
	}

	// Token: 0x06009A86 RID: 39558 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector2 GetDegradationValues(RepairableComponent repairable, Item item)
	{
		throw null;
	}

	// Token: 0x06009A87 RID: 39559 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InsureItems(string[] items, Callback callback)
	{
		throw null;
	}

	// Token: 0x06009A88 RID: 39560 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task RefreshAssortment(bool createIfNotExists, bool ignoreTimeout)
	{
		throw null;
	}

	// Token: 0x06009A89 RID: 39561 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetRepairQuality(Item item)
	{
		throw null;
	}

	// Token: 0x06009A8A RID: 39562 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetRepairPriceCoefficient(Item item)
	{
		throw null;
	}

	// Token: 0x06009A8B RID: 39563 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGetEnhancementChance(Item item, float receiveDurabilityPercent, out double enhancementChance)
	{
		throw null;
	}

	// Token: 0x06009A8C RID: 39564 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<GClass2938[]> GetOffers()
	{
		throw null;
	}

	// Token: 0x06009A8D RID: 39565 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BuyWear(string offerId, IEnumerable<GClass1223> requirements, Callback onFinished)
	{
		throw null;
	}

	// Token: 0x06009A8E RID: 39566 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyWear(GClass2934[] customizationSuites)
	{
		throw null;
	}

	// Token: 0x06009A8F RID: 39567 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<Result<TraderAssortment>> UpdateAssortment(bool ignoreTimeout)
	{
		throw null;
	}

	// Token: 0x06009A90 RID: 39568 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task<Texture2D> method_0()
	{
		throw null;
	}

	// Token: 0x06009A91 RID: 39569 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetAssortmentTimeout()
	{
		throw null;
	}

	// Token: 0x06009A92 RID: 39570 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0400A1AE RID: 41390
	public readonly BindableEvent AssortmentChanged;

	// Token: 0x0400A1AF RID: 41391
	public readonly BindableEvent AssortmentLoadingChanged;

	// Token: 0x0400A1B0 RID: 41392
	public readonly TraderControllerClass TraderController;

	// Token: 0x0400A1B1 RID: 41393
	public readonly string Id;

	// Token: 0x0400A1B2 RID: 41394
	private readonly GInterface178 ginterface178_0;

	// Token: 0x0400A1B3 RID: 41395
	private DateTime dateTime_0;

	// Token: 0x0400A1B4 RID: 41396
	private float float_0;

	// Token: 0x0400A1B5 RID: 41397
	private GClass2938[] gclass2938_0;

	// Token: 0x0400A1B6 RID: 41398
	private SupplyData supplyData_0;

	// Token: 0x0400A1B7 RID: 41399
	[CompilerGenerated]
	private TraderAssortmentControllerClass gclass2043_0;

	// Token: 0x0400A1B8 RID: 41400
	[CompilerGenerated]
	private readonly BackendConfigSettingsClass.TraderSettings traderSettings_0;

	// Token: 0x0400A1B9 RID: 41401
	[CompilerGenerated]
	private readonly Profile.TraderInfo traderInfo_0;

	// Token: 0x0400A1BA RID: 41402
	private Task<Result<TraderAssortment>> task_0;

	// Token: 0x0400A1BB RID: 41403
	private Task<Result<SupplyData>> task_1;

	// Token: 0x0400A1BC RID: 41404
	private bool bool_0;

	// Token: 0x02001D29 RID: 7465
	[StructLayout(LayoutKind.Auto)]
	public readonly struct GStruct242
	{
		// Token: 0x0400A1BD RID: 41405
		public readonly string CurrencyId;

		// Token: 0x0400A1BE RID: 41406
		public readonly int Amount;
	}

	// Token: 0x02001D2A RID: 7466
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1744
	{
		// Token: 0x06009A93 RID: 39571 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(TraderClass.GStruct242? price)
		{
			throw null;
		}

		// Token: 0x06009A94 RID: 39572 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal TraderClass.GStruct242 method_1(TraderClass.GStruct242? price)
		{
			throw null;
		}

		// Token: 0x06009A95 RID: 39573 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_2(TraderClass.GStruct242 price)
		{
			throw null;
		}

		// Token: 0x0400A1BF RID: 41407
		public static readonly TraderClass.Class1744 class1744_0;

		// Token: 0x0400A1C0 RID: 41408
		public static Func<TraderClass.GStruct242?, bool> func_0;

		// Token: 0x0400A1C1 RID: 41409
		public static Func<TraderClass.GStruct242?, TraderClass.GStruct242> func_1;

		// Token: 0x0400A1C2 RID: 41410
		public static Func<TraderClass.GStruct242, int> func_2;
	}

	// Token: 0x02001D2C RID: 7468
	[CompilerGenerated]
	private sealed class Class1745
	{
		// Token: 0x06009A98 RID: 39576 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<GClass2938[]> offers)
		{
			throw null;
		}

		// Token: 0x0400A1CB RID: 41419
		public TraderClass gclass2046_0;

		// Token: 0x0400A1CC RID: 41420
		public TaskCompletionSource<GClass2938[]> result;
	}

	// Token: 0x02001D2D RID: 7469
	[CompilerGenerated]
	private sealed class Class1746
	{
		// Token: 0x06009A99 RID: 39577 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult response)
		{
			throw null;
		}

		// Token: 0x0400A1CD RID: 41421
		public GClass1752 oldCustomization;

		// Token: 0x0400A1CE RID: 41422
		public ISession session;
	}
}
