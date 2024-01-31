using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Comfort.Common;
using EFT;
using EFT.HandBook;
using EFT.InventoryLogic;
using EFT.UI.Ragfair;
using JetBrains.Annotations;

// Token: 0x02002F31 RID: 12081
public sealed class RagFairClass
{
	// Token: 0x170028D8 RID: 10456
	// (get) Token: 0x0600EE45 RID: 60997 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600EE46 RID: 60998 RVA: 0x00002050 File Offset: 0x00000250
	public static RagfairSettingsClass Settings
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

	// Token: 0x170028D9 RID: 10457
	// (get) Token: 0x0600EE47 RID: 60999 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600EE48 RID: 61000 RVA: 0x00002050 File Offset: 0x00000250
	public static GClass3010 IconsLoader
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

	// Token: 0x14000354 RID: 852
	// (add) Token: 0x0600EE49 RID: 61001 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600EE4A RID: 61002 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Offer, bool> OnOfferSelected
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x14000355 RID: 853
	// (add) Token: 0x0600EE4B RID: 61003 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600EE4C RID: 61004 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnSelectedOffersCleared
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x14000356 RID: 854
	// (add) Token: 0x0600EE4D RID: 61005 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600EE4E RID: 61006 RVA: 0x00002050 File Offset: 0x00000250
	public event Action OnMoneySpend
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x14000357 RID: 855
	// (add) Token: 0x0600EE4F RID: 61007 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600EE50 RID: 61008 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<RagFairClass.ESetFilterSource, bool, bool> OnFilterRuleChanged
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x14000358 RID: 856
	// (add) Token: 0x0600EE51 RID: 61009 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600EE52 RID: 61010 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<IEnumerable<string>, bool> OnOfferProcessing
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x14000359 RID: 857
	// (add) Token: 0x0600EE53 RID: 61011 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600EE54 RID: 61012 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Offer, int, string> OnYourOfferSold
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x1400035A RID: 858
	// (add) Token: 0x0600EE55 RID: 61013 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600EE56 RID: 61014 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<bool> OnGettingOffersProcessing
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x1400035B RID: 859
	// (add) Token: 0x0600EE57 RID: 61015 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600EE58 RID: 61016 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<GClass3195> OnRagfairSearch
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x1400035C RID: 860
	// (add) Token: 0x0600EE59 RID: 61017 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600EE5A RID: 61018 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Offer, object, bool> OnFindById
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x1400035D RID: 861
	// (add) Token: 0x0600EE5B RID: 61019 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600EE5C RID: 61020 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<float, bool> OnRatingUpdated
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x1400035E RID: 862
	// (add) Token: 0x0600EE5D RID: 61021 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600EE5E RID: 61022 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Dictionary<string, float>> OnNodePriceUpdated
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x1400035F RID: 863
	// (add) Token: 0x0600EE5F RID: 61023 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600EE60 RID: 61024 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<string> OnOfferRemoved
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x170028DA RID: 10458
	// (get) Token: 0x0600EE61 RID: 61025 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600EE62 RID: 61026 RVA: 0x00002050 File Offset: 0x00000250
	public RagFairClass.ERagFairStatus Status
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

	// Token: 0x170028DB RID: 10459
	// (get) Token: 0x0600EE63 RID: 61027 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600EE64 RID: 61028 RVA: 0x00002050 File Offset: 0x00000250
	public int OffersPerPageCount
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

	// Token: 0x170028DC RID: 10460
	// (get) Token: 0x0600EE65 RID: 61029 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsBuildFilterActive
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170028DD RID: 10461
	// (get) Token: 0x0600EE66 RID: 61030 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600EE67 RID: 61031 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsRatingGrowing
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

	// Token: 0x170028DE RID: 10462
	// (get) Token: 0x0600EE68 RID: 61032 RVA: 0x00002050 File Offset: 0x00000250
	public bool Available
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170028DF RID: 10463
	// (get) Token: 0x0600EE69 RID: 61033 RVA: 0x00002050 File Offset: 0x00000250
	public bool Disabled
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170028E0 RID: 10464
	// (get) Token: 0x0600EE6A RID: 61034 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600EE6B RID: 61035 RVA: 0x00002050 File Offset: 0x00000250
	public List<Offer> WeaponBuilds
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

	// Token: 0x170028E1 RID: 10465
	// (get) Token: 0x0600EE6C RID: 61036 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600EE6D RID: 61037 RVA: 0x00002050 File Offset: 0x00000250
	public GClass3354 Wishlist
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

	// Token: 0x170028E2 RID: 10466
	// (get) Token: 0x0600EE6E RID: 61038 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600EE6F RID: 61039 RVA: 0x00002050 File Offset: 0x00000250
	public FilterRule FilterRule
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

	// Token: 0x170028E3 RID: 10467
	// (get) Token: 0x0600EE70 RID: 61040 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600EE71 RID: 61041 RVA: 0x00002050 File Offset: 0x00000250
	public bool GettingOffers
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

	// Token: 0x170028E4 RID: 10468
	// (get) Token: 0x0600EE72 RID: 61042 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600EE73 RID: 61043 RVA: 0x00002050 File Offset: 0x00000250
	private List<Offer> List_0
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

	// Token: 0x170028E5 RID: 10469
	// (get) Token: 0x0600EE74 RID: 61044 RVA: 0x00002050 File Offset: 0x00000250
	public int MyOffersCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170028E6 RID: 10470
	// (get) Token: 0x0600EE75 RID: 61045 RVA: 0x00002050 File Offset: 0x00000250
	public GInterface178 TradingSession
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170028E7 RID: 10471
	// (get) Token: 0x0600EE76 RID: 61046 RVA: 0x00002050 File Offset: 0x00000250
	public string CategoryName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170028E8 RID: 10472
	// (get) Token: 0x0600EE77 RID: 61047 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600EE78 RID: 61048 RVA: 0x00002050 File Offset: 0x00000250
	public float MyRating
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x0600EE79 RID: 61049 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CanUseForBarterExchange(Item item, out string error)
	{
		throw null;
	}

	// Token: 0x0600EE7A RID: 61050 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetFormattedStatusDescription()
	{
		throw null;
	}

	// Token: 0x0600EE7B RID: 61051 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetRawStatusDescription()
	{
		throw null;
	}

	// Token: 0x0600EE7C RID: 61052 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private string method_0(bool formatted)
	{
		throw null;
	}

	// Token: 0x0600EE7D RID: 61053 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateSettings(RagfairSettingsClass settings, string[] wishlist, Offer[] myOffers)
	{
		throw null;
	}

	// Token: 0x0600EE7E RID: 61054 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x0600EE7F RID: 61055 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private string method_2(EViewListType viewListType)
	{
		throw null;
	}

	// Token: 0x0600EE80 RID: 61056 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private FilterRule method_3(EViewListType viewListType)
	{
		throw null;
	}

	// Token: 0x0600EE81 RID: 61057 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(EViewListType viewListType)
	{
		throw null;
	}

	// Token: 0x0600EE82 RID: 61058 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddSearchesInRule(FilterRule rule, bool setRule)
	{
		throw null;
	}

	// Token: 0x0600EE83 RID: 61059 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMyRating(float rating, bool isGrowing)
	{
		throw null;
	}

	// Token: 0x0600EE84 RID: 61060 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OfferSold(Offer offer, int count, string handbookId)
	{
		throw null;
	}

	// Token: 0x0600EE85 RID: 61061 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<Result<GStruct402>> GetOffers(bool updateCategories, FilterRule filterRule)
	{
		throw null;
	}

	// Token: 0x0600EE86 RID: 61062 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private ValueTuple<int, string> method_5(OffersList result, Dictionary<string, int> buildItems, bool updateCategories, bool updateOffersCount)
	{
		throw null;
	}

	// Token: 0x0600EE87 RID: 61063 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6(Result<OffersList> result)
	{
		throw null;
	}

	// Token: 0x0600EE88 RID: 61064 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7(ICollection<Offer> newOffers, bool updateCategories, bool updateOffersCount, Dictionary<string, int> newCategories)
	{
		throw null;
	}

	// Token: 0x0600EE89 RID: 61065 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateMyOffers(Offer[] newOffers)
	{
		throw null;
	}

	// Token: 0x0600EE8A RID: 61066 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FilterMyOffers()
	{
		throw null;
	}

	// Token: 0x0600EE8B RID: 61067 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FilterWeaponBuildOffers()
	{
		throw null;
	}

	// Token: 0x0600EE8C RID: 61068 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_8(EViewListType type, GClass3361 filteredList, List<Offer> cachedNodes)
	{
		throw null;
	}

	// Token: 0x0600EE8D RID: 61069 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerable<Offer> method_9(IOrderedEnumerable<Offer> offers)
	{
		throw null;
	}

	// Token: 0x0600EE8E RID: 61070 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_10(Offer offer)
	{
		throw null;
	}

	// Token: 0x0600EE8F RID: 61071 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_11(Offer offer)
	{
		throw null;
	}

	// Token: 0x0600EE90 RID: 61072 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_12(Offer offer)
	{
		throw null;
	}

	// Token: 0x0600EE91 RID: 61073 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SwitchOfferSelection(Offer offer)
	{
		throw null;
	}

	// Token: 0x0600EE92 RID: 61074 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsSelected(Offer offer)
	{
		throw null;
	}

	// Token: 0x0600EE93 RID: 61075 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearCachedInfo()
	{
		throw null;
	}

	// Token: 0x0600EE94 RID: 61076 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_13(GClass3361 offers, Dictionary<string, int> categories)
	{
		throw null;
	}

	// Token: 0x0600EE95 RID: 61077 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0(GClass3354 nodes, Dictionary<string, int> categories)
	{
		throw null;
	}

	// Token: 0x0600EE96 RID: 61078 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddMyOffers(Offer[] offers)
	{
		throw null;
	}

	// Token: 0x0600EE97 RID: 61079 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_14()
	{
		throw null;
	}

	// Token: 0x0600EE98 RID: 61080 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_15()
	{
		throw null;
	}

	// Token: 0x0600EE99 RID: 61081 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_16(IEnumerable<Offer> offers)
	{
		throw null;
	}

	// Token: 0x0600EE9A RID: 61082 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_17(Offer offer)
	{
		throw null;
	}

	// Token: 0x0600EE9B RID: 61083 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_18(Offer timeOffer)
	{
		throw null;
	}

	// Token: 0x0600EE9C RID: 61084 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task<bool> method_19(float timeSeconds)
	{
		throw null;
	}

	// Token: 0x0600EE9D RID: 61085 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetMarketPrices(string templateId, Action<ItemMarketPrices> prices)
	{
		throw null;
	}

	// Token: 0x0600EE9E RID: 61086 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> Purchase(CustomizationClass purchases)
	{
		throw null;
	}

	// Token: 0x0600EE9F RID: 61087 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddOffer(bool sellInOnePiece, string[] items, GClass1841[] requirements, Action callback)
	{
		throw null;
	}

	// Token: 0x0600EEA0 RID: 61088 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveOfferFromList(string offerId)
	{
		throw null;
	}

	// Token: 0x0600EEA1 RID: 61089 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveOffer(Offer offer)
	{
		throw null;
	}

	// Token: 0x0600EEA2 RID: 61090 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RenewOffer(Offer offer, bool priority, int renewTime)
	{
		throw null;
	}

	// Token: 0x0600EEA3 RID: 61091 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReportOffer([NotNull] Offer offer, Callback callback)
	{
		throw null;
	}

	// Token: 0x0600EEA4 RID: 61092 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_20(string offerId, bool value)
	{
		throw null;
	}

	// Token: 0x0600EEA5 RID: 61093 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_21(IEnumerable<string> offerIds, bool value)
	{
		throw null;
	}

	// Token: 0x0600EEA6 RID: 61094 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsInWishList(string id)
	{
		throw null;
	}

	// Token: 0x0600EEA7 RID: 61095 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddToWishList(string id, Action callback)
	{
		throw null;
	}

	// Token: 0x0600EEA8 RID: 61096 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveFromWishList(string id, Action callback)
	{
		throw null;
	}

	// Token: 0x0600EEA9 RID: 61097 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_22()
	{
		throw null;
	}

	// Token: 0x0600EEAA RID: 61098 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFilterRule(FilterRule rule, bool clear, bool updateCategories = true, RagFairClass.ESetFilterSource source = RagFairClass.ESetFilterSource.FilterWindow)
	{
		throw null;
	}

	// Token: 0x0600EEAB RID: 61099 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_23(EFilterType type, string name)
	{
		throw null;
	}

	// Token: 0x0600EEAC RID: 61100 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveCancellableFilter(GClass3192 filter, bool sendCallback)
	{
		throw null;
	}

	// Token: 0x0600EEAD RID: 61101 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyRule(EViewListType listType)
	{
		throw null;
	}

	// Token: 0x0600EEAE RID: 61102 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ForceSetFilterRule(FilterRule newRule)
	{
		throw null;
	}

	// Token: 0x0600EEAF RID: 61103 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SaveRuleAsDefault()
	{
		throw null;
	}

	// Token: 0x0600EEB0 RID: 61104 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearSavedFilters()
	{
		throw null;
	}

	// Token: 0x0600EEB1 RID: 61105 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ExternalRagfairSearch([CanBeNull] GClass3195 search)
	{
		throw null;
	}

	// Token: 0x0600EEB2 RID: 61106 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSearch(GClass3195 search, bool sendBackendData)
	{
		throw null;
	}

	// Token: 0x0600EEB3 RID: 61107 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_24(EViewListType viewListType, GClass3195[] searches, bool sendBackendData, out FilterRule newRule)
	{
		throw null;
	}

	// Token: 0x0600EEB4 RID: 61108 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_25(FilterRule rule)
	{
		throw null;
	}

	// Token: 0x0600EEB5 RID: 61109 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private FilterRule method_26(EFilterType filterType, FilterRule resetRule, bool sendCallback, bool displayChange = true)
	{
		throw null;
	}

	// Token: 0x0600EEB6 RID: 61110 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RefreshItemPrices()
	{
		throw null;
	}

	// Token: 0x0600EEB7 RID: 61111 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearOffers()
	{
		throw null;
	}

	// Token: 0x0600EEB8 RID: 61112 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanUseForBarterExchange(Item item)
	{
		throw null;
	}

	// Token: 0x0600EEB9 RID: 61113 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetMaxOffersCount(float rating)
	{
		throw null;
	}

	// Token: 0x0600EEBA RID: 61114 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool OfferAlreadyReported(long offerId)
	{
		throw null;
	}

	// Token: 0x0600EEBB RID: 61115 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_27(HandbookData category)
	{
		throw null;
	}

	// Token: 0x0600EEBC RID: 61116 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_28(int x)
	{
		throw null;
	}

	// Token: 0x0600EEBD RID: 61117 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void smethod_1(EFilterType type, int value, int defaultValue, ref RagFairClass.Struct1012 struct1012_0)
	{
		throw null;
	}

	// Token: 0x0600EEBE RID: 61118 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void smethod_2(EFilterType type, int value, ref RagFairClass.Struct1012 struct1012_0)
	{
		throw null;
	}

	// Token: 0x0600EEBF RID: 61119 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_29(IExchangeRequirement x)
	{
		throw null;
	}

	// Token: 0x0600EEC0 RID: 61120 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GClass3192 method_30(EFilterType item)
	{
		throw null;
	}

	// Token: 0x0600EEC1 RID: 61121 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_31(Result<Dictionary<string, float>> prices)
	{
		throw null;
	}

	// Token: 0x0400F3A0 RID: 62368
	private const string string_0 = "DefaultFilterRule";

	// Token: 0x0400F3A1 RID: 62369
	public const string NOT_ENOUGH_MONEY_HEADER = "ragfair/Not enough money";

	// Token: 0x0400F3A2 RID: 62370
	[CompilerGenerated]
	private static RagfairSettingsClass gclass3188_0;

	// Token: 0x0400F3A3 RID: 62371
	[CompilerGenerated]
	private static GClass3010 gclass3010_0;

	// Token: 0x0400F3A4 RID: 62372
	[CompilerGenerated]
	private Action<Offer, bool> action_0;

	// Token: 0x0400F3A5 RID: 62373
	[CompilerGenerated]
	private Action action_1;

	// Token: 0x0400F3A6 RID: 62374
	[CompilerGenerated]
	private Action action_2;

	// Token: 0x0400F3A7 RID: 62375
	[CompilerGenerated]
	private Action<RagFairClass.ESetFilterSource, bool, bool> action_3;

	// Token: 0x0400F3A8 RID: 62376
	[CompilerGenerated]
	private Action<IEnumerable<string>, bool> action_4;

	// Token: 0x0400F3A9 RID: 62377
	[CompilerGenerated]
	private Action<Offer, int, string> action_5;

	// Token: 0x0400F3AA RID: 62378
	[CompilerGenerated]
	private Action<bool> action_6;

	// Token: 0x0400F3AB RID: 62379
	[CompilerGenerated]
	private Action<GClass3195> action_7;

	// Token: 0x0400F3AC RID: 62380
	[CompilerGenerated]
	private Action<Offer, object, bool> action_8;

	// Token: 0x0400F3AD RID: 62381
	[CompilerGenerated]
	private Action<float, bool> action_9;

	// Token: 0x0400F3AE RID: 62382
	[CompilerGenerated]
	private Action<Dictionary<string, float>> action_10;

	// Token: 0x0400F3AF RID: 62383
	[CompilerGenerated]
	private Action<string> action_11;

	// Token: 0x0400F3B0 RID: 62384
	public readonly GClass3194 CancellableFilters;

	// Token: 0x0400F3B1 RID: 62385
	private readonly Dictionary<EBackendErrorCode, string> dictionary_0;

	// Token: 0x0400F3B2 RID: 62386
	public readonly FilterRule DefaultFilterRule;

	// Token: 0x0400F3B3 RID: 62387
	private readonly FilterRule filterRule_0;

	// Token: 0x0400F3B4 RID: 62388
	public readonly FilterRule WishListFilterRule;

	// Token: 0x0400F3B5 RID: 62389
	private readonly FilterRule filterRule_1;

	// Token: 0x0400F3B6 RID: 62390
	[NonSerialized]
	public readonly GClass3355<EViewListType> OnFilteredOffersCountChanged;

	// Token: 0x0400F3B7 RID: 62391
	[NonSerialized]
	public readonly GClass3355<RagFairClass.ERagFairStatus> OnStatusChanged;

	// Token: 0x0400F3B8 RID: 62392
	private readonly List<Offer> list_0;

	// Token: 0x0400F3B9 RID: 62393
	private readonly RagFairClass.Class2986 class2986_0;

	// Token: 0x0400F3BA RID: 62394
	private readonly ISession ginterface145_0;

	// Token: 0x0400F3BB RID: 62395
	private readonly Dictionary<EViewListType, FilterRule> dictionary_1;

	// Token: 0x0400F3BC RID: 62396
	private readonly Dictionary<EViewListType, FilterRule> dictionary_2;

	// Token: 0x0400F3BD RID: 62397
	public GClass3361 Offers;

	// Token: 0x0400F3BE RID: 62398
	public GClass3361 MyOffersFiltered;

	// Token: 0x0400F3BF RID: 62399
	public GClass3361 WeaponBuildsFiltered;

	// Token: 0x0400F3C0 RID: 62400
	public readonly Dictionary<EViewListType, string> LastSelectedIds;

	// Token: 0x0400F3C1 RID: 62401
	public bool ForceNextUpdate;

	// Token: 0x0400F3C2 RID: 62402
	private GClass2881 gclass2881_0;

	// Token: 0x0400F3C3 RID: 62403
	private FilterRule filterRule_2;

	// Token: 0x0400F3C4 RID: 62404
	private bool bool_0;

	// Token: 0x0400F3C5 RID: 62405
	private string string_1;

	// Token: 0x0400F3C6 RID: 62406
	private CancellationTokenSource cancellationTokenSource_0;

	// Token: 0x0400F3C7 RID: 62407
	private int int_0;

	// Token: 0x0400F3C8 RID: 62408
	[CompilerGenerated]
	private RagFairClass.ERagFairStatus eragFairStatus_0;

	// Token: 0x0400F3C9 RID: 62409
	[CompilerGenerated]
	private int int_1;

	// Token: 0x0400F3CA RID: 62410
	[CompilerGenerated]
	private bool bool_1;

	// Token: 0x0400F3CB RID: 62411
	[CompilerGenerated]
	private List<Offer> list_1;

	// Token: 0x0400F3CC RID: 62412
	[CompilerGenerated]
	private GClass3354 gclass3354_0;

	// Token: 0x0400F3CD RID: 62413
	[CompilerGenerated]
	private FilterRule filterRule_3;

	// Token: 0x0400F3CE RID: 62414
	[CompilerGenerated]
	private bool bool_2;

	// Token: 0x0400F3CF RID: 62415
	[CompilerGenerated]
	private List<Offer> list_2;

	// Token: 0x0400F3D0 RID: 62416
	private float float_0;

	// Token: 0x02002F32 RID: 12082
	public enum ERagFairStatus
	{
		// Token: 0x0400F3D2 RID: 62418
		Available,
		// Token: 0x0400F3D3 RID: 62419
		Disabled,
		// Token: 0x0400F3D4 RID: 62420
		LevelCapped,
		// Token: 0x0400F3D5 RID: 62421
		Banned
	}

	// Token: 0x02002F33 RID: 12083
	public enum EUpdatePagesStatus
	{
		// Token: 0x0400F3D7 RID: 62423
		Default,
		// Token: 0x0400F3D8 RID: 62424
		DoNotUpdate = -1,
		// Token: 0x0400F3D9 RID: 62425
		DoNotUpdateCached = -2
	}

	// Token: 0x02002F34 RID: 12084
	public enum ESetFilterSource
	{
		// Token: 0x0400F3DB RID: 62427
		FilterWindow,
		// Token: 0x0400F3DC RID: 62428
		IdSelected
	}

	// Token: 0x02002F35 RID: 12085
	private sealed class Class2984
	{
		// Token: 0x170028E9 RID: 10473
		// (get) Token: 0x0600EEC2 RID: 61122 RVA: 0x00002050 File Offset: 0x00000250
		public List<Offer> OffersList
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600EEC3 RID: 61123 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TryRemove(string offerId)
		{
			throw null;
		}

		// Token: 0x0400F3DD RID: 62429
		public readonly Dictionary<string, int> Categories;

		// Token: 0x0400F3DE RID: 62430
		[CompilerGenerated]
		private readonly List<Offer> list_0;

		// Token: 0x02002F36 RID: 12086
		[CompilerGenerated]
		private sealed class Class2985
		{
			// Token: 0x0600EEC4 RID: 61124 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Offer x)
			{
				throw null;
			}

			// Token: 0x0400F3DF RID: 62431
			public string offerId;
		}
	}

	// Token: 0x02002F37 RID: 12087
	private sealed class Class2986 : Dictionary<FilterRule, RagFairClass.Class2984>
	{
		// Token: 0x0600EEC5 RID: 61125 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Remove(string offerId)
		{
			throw null;
		}
	}

	// Token: 0x02002F38 RID: 12088
	[CompilerGenerated]
	private sealed class Class2987
	{
		// Token: 0x0600EEC6 RID: 61126 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass2884 y)
		{
			throw null;
		}

		// Token: 0x0600EEC7 RID: 61127 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(NotificationClass arg)
		{
			throw null;
		}

		// Token: 0x0600EEC8 RID: 61128 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2(int _, int __)
		{
			throw null;
		}

		// Token: 0x0600EEC9 RID: 61129 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_3(EBanType banType)
		{
			throw null;
		}

		// Token: 0x0400F3E0 RID: 62432
		public string[] wishlist;

		// Token: 0x0400F3E1 RID: 62433
		public RagFairClass gclass3190_0;
	}

	// Token: 0x02002F39 RID: 12089
	[CompilerGenerated]
	private sealed class Class2988
	{
		// Token: 0x0600EECA RID: 61130 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Offer x)
		{
			throw null;
		}
	}

	// Token: 0x02002F3A RID: 12090
	[CompilerGenerated]
	[Serializable]
	private sealed class Class2989
	{
		// Token: 0x0600EECB RID: 61131 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<GClass2884> method_0(GClass2884 x)
		{
			throw null;
		}

		// Token: 0x0600EECC RID: 61132 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass2884 method_1(GClass2884 x)
		{
			throw null;
		}

		// Token: 0x0600EECD RID: 61133 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_2(GClass2884 x)
		{
			throw null;
		}

		// Token: 0x0600EECE RID: 61134 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass2884 method_3(GClass2884 x)
		{
			throw null;
		}

		// Token: 0x0600EECF RID: 61135 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_4(RagfairSettingsClass.GClass3189 x)
		{
			throw null;
		}

		// Token: 0x0600EED0 RID: 61136 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_5(RagfairSettingsClass.GClass3189 x)
		{
			throw null;
		}

		// Token: 0x0600EED1 RID: 61137 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<SearchableItemClass> method_6(Offer offer)
		{
			throw null;
		}

		// Token: 0x0600EED2 RID: 61138 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<SearchableItemClass> method_7(Offer offer)
		{
			throw null;
		}

		// Token: 0x0600EED3 RID: 61139 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_8(Offer x)
		{
			throw null;
		}

		// Token: 0x0600EED4 RID: 61140 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_9(Offer x)
		{
			throw null;
		}

		// Token: 0x0600EED5 RID: 61141 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_10(Offer x)
		{
			throw null;
		}

		// Token: 0x0600EED6 RID: 61142 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_11(Offer x)
		{
			throw null;
		}

		// Token: 0x0600EED7 RID: 61143 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_12(Offer x)
		{
			throw null;
		}

		// Token: 0x0600EED8 RID: 61144 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_13(Offer x)
		{
			throw null;
		}

		// Token: 0x0600EED9 RID: 61145 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_14(Offer x)
		{
			throw null;
		}

		// Token: 0x0600EEDA RID: 61146 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_15(Offer x)
		{
			throw null;
		}

		// Token: 0x0600EEDB RID: 61147 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_16(Offer x)
		{
			throw null;
		}

		// Token: 0x0600EEDC RID: 61148 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_17(Offer x)
		{
			throw null;
		}

		// Token: 0x0600EEDD RID: 61149 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_18(Offer x)
		{
			throw null;
		}

		// Token: 0x0600EEDE RID: 61150 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal DateTime method_19(Offer x)
		{
			throw null;
		}

		// Token: 0x0600EEDF RID: 61151 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal DateTime method_20(Offer x)
		{
			throw null;
		}

		// Token: 0x0600EEE0 RID: 61152 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<GClass2884> method_21(GClass2884 x)
		{
			throw null;
		}

		// Token: 0x0600EEE1 RID: 61153 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<SearchableItemClass> method_22(Offer offer)
		{
			throw null;
		}

		// Token: 0x0600EEE2 RID: 61154 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_23(GClass1864 x)
		{
			throw null;
		}

		// Token: 0x0600EEE3 RID: 61155 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_24(FilterRule key)
		{
			throw null;
		}

		// Token: 0x0600EEE4 RID: 61156 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_25(GClass3192 foundFilter)
		{
			throw null;
		}

		// Token: 0x0600EEE5 RID: 61157 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_26(GClass3195 search)
		{
			throw null;
		}

		// Token: 0x0600EEE6 RID: 61158 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_27(GClass3195 search)
		{
			throw null;
		}

		// Token: 0x0600EEE7 RID: 61159 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_28(KeyValuePair<string, GClass2884> x)
		{
			throw null;
		}

		// Token: 0x0600EEE8 RID: 61160 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string method_29(KeyValuePair<string, GClass2884> x)
		{
			throw null;
		}

		// Token: 0x0600EEE9 RID: 61161 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_30(KeyValuePair<string, GClass2884> x)
		{
			throw null;
		}

		// Token: 0x0400F3E2 RID: 62434
		public static readonly RagFairClass.Class2989 class2989_0;

		// Token: 0x0400F3E3 RID: 62435
		public static Func<GClass2884, IEnumerable<GClass2884>> func_0;

		// Token: 0x0400F3E4 RID: 62436
		public static Func<GClass2884, GClass2884> func_1;

		// Token: 0x0400F3E5 RID: 62437
		public static Func<GClass2884, string> func_2;

		// Token: 0x0400F3E6 RID: 62438
		public static Func<GClass2884, GClass2884> func_3;

		// Token: 0x0400F3E7 RID: 62439
		public static Func<RagfairSettingsClass.GClass3189, float> func_4;

		// Token: 0x0400F3E8 RID: 62440
		public static Func<RagfairSettingsClass.GClass3189, float> func_5;

		// Token: 0x0400F3E9 RID: 62441
		public static Func<Offer, IEnumerable<SearchableItemClass>> func_6;

		// Token: 0x0400F3EA RID: 62442
		public static Func<Offer, IEnumerable<SearchableItemClass>> func_7;

		// Token: 0x0400F3EB RID: 62443
		public static Func<Offer, bool> func_8;

		// Token: 0x0400F3EC RID: 62444
		public static Func<Offer, string> func_9;

		// Token: 0x0400F3ED RID: 62445
		public static Func<Offer, string> func_10;

		// Token: 0x0400F3EE RID: 62446
		public static Func<Offer, bool> func_11;

		// Token: 0x0400F3EF RID: 62447
		public static Func<Offer, bool> func_12;

		// Token: 0x0400F3F0 RID: 62448
		public static Func<Offer, string> func_13;

		// Token: 0x0400F3F1 RID: 62449
		public static Func<Offer, int> func_14;

		// Token: 0x0400F3F2 RID: 62450
		public static Func<Offer, string> func_15;

		// Token: 0x0400F3F3 RID: 62451
		public static Func<Offer, int> func_16;

		// Token: 0x0400F3F4 RID: 62452
		public static Func<Offer, int> func_17;

		// Token: 0x0400F3F5 RID: 62453
		public static Func<Offer, int> func_18;

		// Token: 0x0400F3F6 RID: 62454
		public static Func<Offer, DateTime> func_19;

		// Token: 0x0400F3F7 RID: 62455
		public static Func<Offer, DateTime> func_20;

		// Token: 0x0400F3F8 RID: 62456
		public static Func<GClass2884, IEnumerable<GClass2884>> func_21;

		// Token: 0x0400F3F9 RID: 62457
		public static Func<Offer, IEnumerable<SearchableItemClass>> func_22;

		// Token: 0x0400F3FA RID: 62458
		public static Func<GClass1864, string> func_23;

		// Token: 0x0400F3FB RID: 62459
		public static Func<FilterRule, bool> func_24;

		// Token: 0x0400F3FC RID: 62460
		public static Func<GClass3192, bool> func_25;

		// Token: 0x0400F3FD RID: 62461
		public static Func<GClass3195, bool> func_26;

		// Token: 0x0400F3FE RID: 62462
		public static Func<GClass3195, bool> func_27;

		// Token: 0x0400F3FF RID: 62463
		public static Func<KeyValuePair<string, GClass2884>, int> func_28;

		// Token: 0x0400F400 RID: 62464
		public static Func<KeyValuePair<string, GClass2884>, string> func_29;

		// Token: 0x0400F401 RID: 62465
		public static Func<KeyValuePair<string, GClass2884>, bool> func_30;
	}

	// Token: 0x02002F3B RID: 12091
	[CompilerGenerated]
	[StructLayout(LayoutKind.Auto)]
	public struct Struct1012
	{
		// Token: 0x0400F402 RID: 62466
		public List<GClass3195> ragfairSearches;
	}

	// Token: 0x02002F3D RID: 12093
	[CompilerGenerated]
	private sealed class Class2990
	{
		// Token: 0x0600EEEC RID: 61164 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Offer x)
		{
			throw null;
		}

		// Token: 0x0400F40C RID: 62476
		public string templateId;
	}

	// Token: 0x02002F3E RID: 12094
	[CompilerGenerated]
	private sealed class Class2991
	{
		// Token: 0x0600EEED RID: 61165 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(ItemTemplate x)
		{
			throw null;
		}

		// Token: 0x0400F40D RID: 62477
		public ModTemplate modTemplate;
	}

	// Token: 0x02002F42 RID: 12098
	[CompilerGenerated]
	private sealed class Class2992
	{
		// Token: 0x0600EEF4 RID: 61172 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<ItemMarketPrices> result)
		{
			throw null;
		}

		// Token: 0x0400F41E RID: 62494
		public Action<ItemMarketPrices> prices;
	}

	// Token: 0x02002F43 RID: 12099
	[CompilerGenerated]
	private sealed class Class2993
	{
		// Token: 0x0600EEF5 RID: 61173 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x0400F41F RID: 62495
		public RagFairClass gclass3190_0;

		// Token: 0x0400F420 RID: 62496
		public string[] offerIds;

		// Token: 0x0400F421 RID: 62497
		public TaskCompletionSource<IResult> taskSource;
	}

	// Token: 0x02002F44 RID: 12100
	[CompilerGenerated]
	private sealed class Class2994
	{
		// Token: 0x0600EEF6 RID: 61174 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x0400F422 RID: 62498
		public RagFairClass gclass3190_0;

		// Token: 0x0400F423 RID: 62499
		public Action callback;
	}

	// Token: 0x02002F45 RID: 12101
	[CompilerGenerated]
	private sealed class Class2995
	{
		// Token: 0x0600EEF7 RID: 61175 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Offer x)
		{
			throw null;
		}

		// Token: 0x0600EEF8 RID: 61176 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(Offer x)
		{
			throw null;
		}

		// Token: 0x0600EEF9 RID: 61177 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_2(Offer x)
		{
			throw null;
		}

		// Token: 0x0400F424 RID: 62500
		public string offerId;
	}

	// Token: 0x02002F46 RID: 12102
	[CompilerGenerated]
	private sealed class Class2996
	{
		// Token: 0x0600EEFA RID: 61178 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x0400F425 RID: 62501
		public RagFairClass gclass3190_0;

		// Token: 0x0400F426 RID: 62502
		public Offer offer;
	}

	// Token: 0x02002F47 RID: 12103
	[CompilerGenerated]
	private sealed class Class2997
	{
		// Token: 0x0600EEFB RID: 61179 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x0400F427 RID: 62503
		public RagFairClass gclass3190_0;

		// Token: 0x0400F428 RID: 62504
		public Offer offer;

		// Token: 0x0400F429 RID: 62505
		public DateTime oldEndTime;
	}

	// Token: 0x02002F48 RID: 12104
	[CompilerGenerated]
	private sealed class Class2998
	{
		// Token: 0x0600EEFC RID: 61180 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x0400F42A RID: 62506
		public RagFairClass gclass3190_0;

		// Token: 0x0400F42B RID: 62507
		public Action callback;
	}

	// Token: 0x02002F49 RID: 12105
	[CompilerGenerated]
	private sealed class Class2999
	{
		// Token: 0x0600EEFD RID: 61181 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(IResult result)
		{
			throw null;
		}

		// Token: 0x0400F42C RID: 62508
		public RagFairClass gclass3190_0;

		// Token: 0x0400F42D RID: 62509
		public Action callback;
	}

	// Token: 0x02002F4A RID: 12106
	[CompilerGenerated]
	private sealed class Class3000
	{
		// Token: 0x0600EEFE RID: 61182 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(GClass3192 filter, bool sendCallback)
		{
			throw null;
		}

		// Token: 0x0600EEFF RID: 61183 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(GClass3192 x)
		{
			throw null;
		}

		// Token: 0x0400F42E RID: 62510
		public RagFairClass gclass3190_0;

		// Token: 0x0400F42F RID: 62511
		public EFilterType type;
	}

	// Token: 0x02002F4B RID: 12107
	[CompilerGenerated]
	private sealed class Class3001
	{
		// Token: 0x0600EF00 RID: 61184 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass3192 x)
		{
			throw null;
		}

		// Token: 0x0400F430 RID: 62512
		public EFilterType item;
	}

	// Token: 0x02002F4C RID: 12108
	[CompilerGenerated]
	private sealed class Class3002
	{
		// Token: 0x0600EF01 RID: 61185 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass3192 x)
		{
			throw null;
		}

		// Token: 0x0400F431 RID: 62513
		public EFilterType item;
	}

	// Token: 0x02002F4D RID: 12109
	[CompilerGenerated]
	private sealed class Class3003
	{
		// Token: 0x0600EF02 RID: 61186 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Offer offer)
		{
			throw null;
		}

		// Token: 0x0400F432 RID: 62514
		public object value;

		// Token: 0x0400F433 RID: 62515
		public RagFairClass gclass3190_0;
	}

	// Token: 0x02002F4E RID: 12110
	[CompilerGenerated]
	private sealed class Class3004
	{
		// Token: 0x0400F434 RID: 62516
		public long longId;

		// Token: 0x0400F435 RID: 62517
		public RagFairClass.Class3003 class3003_0;
	}

	// Token: 0x02002F4F RID: 12111
	[CompilerGenerated]
	private sealed class Class3005
	{
		// Token: 0x0600EF03 RID: 61187 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<Offer> result)
		{
			throw null;
		}

		// Token: 0x0400F436 RID: 62518
		public FilterRule ruleToApply;

		// Token: 0x0400F437 RID: 62519
		public RagFairClass.Class3004 class3004_0;
	}

	// Token: 0x02002F50 RID: 12112
	[CompilerGenerated]
	private sealed class Class3006
	{
		// Token: 0x0600EF04 RID: 61188 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass3192 x)
		{
			throw null;
		}

		// Token: 0x0400F438 RID: 62520
		public GClass3195 filter;
	}

	// Token: 0x02002F51 RID: 12113
	[CompilerGenerated]
	private sealed class Class3007
	{
		// Token: 0x0600EF05 RID: 61189 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(RagfairSettingsClass.GClass3189 x)
		{
			throw null;
		}

		// Token: 0x0400F439 RID: 62521
		public float rating;
	}
}
