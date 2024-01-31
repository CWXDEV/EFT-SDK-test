using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace EFT.UI.Ragfair
{
	// Token: 0x02002F7A RID: 12154
	[Serializable]
	public struct FilterRule
	{
		// Token: 0x17002914 RID: 10516
		// (get) Token: 0x0600EFB7 RID: 61367 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600EFB8 RID: 61368 RVA: 0x00002050 File Offset: 0x00000250
		public string HandbookId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17002915 RID: 10517
		// (get) Token: 0x0600EFB9 RID: 61369 RVA: 0x00002050 File Offset: 0x00000250
		public BuildItemSearchValue BuildSearch
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600EFBA RID: 61370 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ShowFilterChange(FilterRule rule)
		{
			throw null;
		}

		// Token: 0x17002916 RID: 10518
		// (get) Token: 0x0600EFBB RID: 61371 RVA: 0x00002050 File Offset: 0x00000250
		public bool AnyIdSearch
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600EFBC RID: 61372 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearBuildFilter()
		{
			throw null;
		}

		// Token: 0x0600EFBD RID: 61373 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400F504 RID: 62724
		public EViewListType ViewListType;

		// Token: 0x0400F505 RID: 62725
		public int Page;

		// Token: 0x0400F506 RID: 62726
		public int CurrencyType;

		// Token: 0x0400F507 RID: 62727
		public ESortType SortType;

		// Token: 0x0400F508 RID: 62728
		public bool SortDirection;

		// Token: 0x0400F509 RID: 62729
		public int PriceFrom;

		// Token: 0x0400F50A RID: 62730
		public int PriceTo;

		// Token: 0x0400F50B RID: 62731
		public int QuantityFrom;

		// Token: 0x0400F50C RID: 62732
		public int QuantityTo;

		// Token: 0x0400F50D RID: 62733
		public int ConditionFrom;

		// Token: 0x0400F50E RID: 62734
		public int ConditionTo;

		// Token: 0x0400F50F RID: 62735
		public bool OneHourExpiration;

		// Token: 0x0400F510 RID: 62736
		public bool RemoveBartering;

		// Token: 0x0400F511 RID: 62737
		public int OfferOwnerType;

		// Token: 0x0400F512 RID: 62738
		public bool OnlyFunctional;

		// Token: 0x0400F513 RID: 62739
		public long OfferId;

		// Token: 0x0400F514 RID: 62740
		public string FilterSearchId;

		// Token: 0x0400F515 RID: 62741
		public string LinkedSearchId;

		// Token: 0x0400F516 RID: 62742
		public string NeededSearchId;

		// Token: 0x0400F517 RID: 62743
		[NonSerialized]
		public string BuildName;

		// Token: 0x0400F518 RID: 62744
		public Dictionary<string, int> BuildItems;

		// Token: 0x0400F519 RID: 62745
		public int BuildCount;

		// Token: 0x0400F51A RID: 62746
		private string _handbookId;
	}
}
