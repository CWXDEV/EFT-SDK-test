using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.UI.Utilities.LightScroller;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.Ragfair
{
	// Token: 0x02002FA3 RID: 12195
	public sealed class OfferViewList : UIElement
	{
		// Token: 0x1700294B RID: 10571
		// (get) Token: 0x0600F0A9 RID: 61609 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700294C RID: 10572
		// (get) Token: 0x0600F0AA RID: 61610 RVA: 0x00002050 File Offset: 0x00000250
		private int Int32_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700294D RID: 10573
		// (get) Token: 0x0600F0AB RID: 61611 RVA: 0x00002050 File Offset: 0x00000250
		private int Int32_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600F0AC RID: 61612 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600F0AD RID: 61613 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(EViewListType type, GClass2881 handbook, string profileId, GClass3361 offers, Dictionary<string, Profile.TraderInfo> traders, ItemUiContext itemUiContext, RagFairClass ragfair, InventoryControllerClass inventoryController, InsuranceCompanyClass insuranceCompany, GClass1839 social, Action<Offer, Action> onRenew, Action<bool, Dictionary<GInterface151, int>> onPurchase, Action<Offer, Action> onRemove, Action<Offer> onClose, Action<string> onFindById, GClass3195 currentSearch = null)
		{
			throw null;
		}

		// Token: 0x0600F0AE RID: 61614 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearIdFilter()
		{
			throw null;
		}

		// Token: 0x0600F0AF RID: 61615 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(GClass3361 offers)
		{
			throw null;
		}

		// Token: 0x0600F0B0 RID: 61616 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600F0B1 RID: 61617 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600F0B2 RID: 61618 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(GClass2884 node)
		{
			throw null;
		}

		// Token: 0x0600F0B3 RID: 61619 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(GClass3192 filter)
		{
			throw null;
		}

		// Token: 0x0600F0B4 RID: 61620 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(GClass3192 filter)
		{
			throw null;
		}

		// Token: 0x0600F0B5 RID: 61621 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(Offer offer, int count, string handbookId)
		{
			throw null;
		}

		// Token: 0x0600F0B6 RID: 61622 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7([CanBeNull] Offer offer, object id, bool reset)
		{
			throw null;
		}

		// Token: 0x0600F0B7 RID: 61623 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_8(Offer offer, out GClass3196 convertedItem)
		{
			throw null;
		}

		// Token: 0x0600F0B8 RID: 61624 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600F0B9 RID: 61625 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x0600F0BA RID: 61626 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10(string id, bool dropPage)
		{
			throw null;
		}

		// Token: 0x0600F0BB RID: 61627 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11(RagFairClass.ESetFilterSource source, bool clear, bool updateCategories)
		{
			throw null;
		}

		// Token: 0x0600F0BC RID: 61628 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_12(bool updateCategories, Action afterGetOffers = null)
		{
			throw null;
		}

		// Token: 0x0600F0BD RID: 61629 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13(string failedCategoryId)
		{
			throw null;
		}

		// Token: 0x0600F0BE RID: 61630 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_14(GStruct402 offersData)
		{
			throw null;
		}

		// Token: 0x0600F0BF RID: 61631 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateOffersForced()
		{
			throw null;
		}

		// Token: 0x0600F0C0 RID: 61632 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_15(Offer offer)
		{
			throw null;
		}

		// Token: 0x0600F0C1 RID: 61633 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private UIElement method_16(GClass3196 offerData)
		{
			throw null;
		}

		// Token: 0x0600F0C2 RID: 61634 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_17(GClass3196 offerData, UIElement dataView)
		{
			throw null;
		}

		// Token: 0x0600F0C3 RID: 61635 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_18(OffersUpdatePanel view)
		{
			throw null;
		}

		// Token: 0x0600F0C4 RID: 61636 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_19(int offersPerPage)
		{
			throw null;
		}

		// Token: 0x0600F0C7 RID: 61639 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600F0C8 RID: 61640 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_22()
		{
			throw null;
		}

		// Token: 0x0600F0C9 RID: 61641 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_23(int arg)
		{
			throw null;
		}

		// Token: 0x0400F673 RID: 63091
		private const int int_0 = 3;

		// Token: 0x0400F674 RID: 63092
		private const string string_0 = "ragfair/No offers has been found in {0} category. Select another category.";

		// Token: 0x0400F675 RID: 63093
		[SerializeField]
		private FiltersPanel _filtersPanel;

		// Token: 0x0400F676 RID: 63094
		[SerializeField]
		private RagfairCategoriesPanel _browseCategoriesPanel;

		// Token: 0x0400F677 RID: 63095
		[SerializeField]
		private CancellableFiltersPanel _cancellableFiltersPanel;

		// Token: 0x0400F678 RID: 63096
		[SerializeField]
		private GameObject _loader;

		// Token: 0x0400F679 RID: 63097
		[SerializeField]
		private LightScroller _scroller;

		// Token: 0x0400F67A RID: 63098
		[SerializeField]
		private UIElement _cellViewPrefab;

		// Token: 0x0400F67B RID: 63099
		[SerializeField]
		private UIElement _updateDataPrefab;

		// Token: 0x0400F67C RID: 63100
		[SerializeField]
		private RagfairAvailabilityWarning _availabilityWarningPrefab;

		// Token: 0x0400F67D RID: 63101
		[SerializeField]
		private GameObject _notFoundObject;

		// Token: 0x0400F67E RID: 63102
		[SerializeField]
		private TextMeshProUGUI _notFoundLabel;

		// Token: 0x0400F67F RID: 63103
		[SerializeField]
		private MassPurchasePanel _massPurchasePanel;

		// Token: 0x0400F680 RID: 63104
		[SerializeField]
		private Button _refreshButton;

		// Token: 0x0400F681 RID: 63105
		private RagFairClass gclass3190_0;

		// Token: 0x0400F682 RID: 63106
		private EViewListType eviewListType_0;

		// Token: 0x0400F683 RID: 63107
		private GClass3354 gclass3354_0;

		// Token: 0x0400F684 RID: 63108
		private readonly Dictionary<string, int> dictionary_0;

		// Token: 0x0400F685 RID: 63109
		private GClass3363<Offer, GClass3196> gclass3363_0;

		// Token: 0x0400F686 RID: 63110
		private OffersUpdatePanel offersUpdatePanel_0;

		// Token: 0x0400F687 RID: 63111
		private NodeBaseView nodeBaseView_0;

		// Token: 0x0400F688 RID: 63112
		private Action<Offer> action_0;

		// Token: 0x0400F689 RID: 63113
		private Action<string> action_1;

		// Token: 0x0400F68A RID: 63114
		private GClass2881 gclass2881_0;

		// Token: 0x0400F68B RID: 63115
		private string string_1;

		// Token: 0x0400F68C RID: 63116
		private Dictionary<string, Profile.TraderInfo> dictionary_1;

		// Token: 0x0400F68D RID: 63117
		private ItemUiContext itemUiContext_0;

		// Token: 0x0400F68E RID: 63118
		private InventoryControllerClass gclass2757_0;

		// Token: 0x0400F68F RID: 63119
		private InsuranceCompanyClass gclass3179_0;

		// Token: 0x0400F690 RID: 63120
		private GClass1839 gclass1839_0;

		// Token: 0x0400F691 RID: 63121
		private CaptchaHandler captchaHandler_0;

		// Token: 0x0400F692 RID: 63122
		private Action<Offer, Action> action_2;

		// Token: 0x0400F693 RID: 63123
		private Action<bool, Dictionary<GInterface151, int>> action_3;

		// Token: 0x0400F694 RID: 63124
		private Action<Offer, Action> action_4;

		// Token: 0x0400F695 RID: 63125
		private float float_0;

		// Token: 0x0400F696 RID: 63126
		private bool bool_0;

		// Token: 0x0400F697 RID: 63127
		private GClass3195 gclass3195_0;

		// Token: 0x0400F698 RID: 63128
		private readonly GClass763 gclass763_0;

		// Token: 0x0400F699 RID: 63129
		private readonly GClass3198 gclass3198_0;

		// Token: 0x0400F69A RID: 63130
		private readonly GClass3199 gclass3199_0;

		// Token: 0x0400F69B RID: 63131
		private string string_2;

		// Token: 0x02002FA4 RID: 12196
		[CompilerGenerated]
		private sealed class Class3041
		{
			// Token: 0x0600F0CA RID: 61642 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600F0CB RID: 61643 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x0600F0CC RID: 61644 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2()
			{
				throw null;
			}

			// Token: 0x0600F0CD RID: 61645 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_3(NodeBaseView view, string id)
			{
				throw null;
			}

			// Token: 0x0600F0CE RID: 61646 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_4(NodeBaseView view, string id)
			{
				throw null;
			}

			// Token: 0x0600F0CF RID: 61647 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_5(GClass2884 child)
			{
				throw null;
			}

			// Token: 0x0600F0D0 RID: 61648 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_6()
			{
				throw null;
			}

			// Token: 0x0400F69C RID: 63132
			public GClass3361 offers;

			// Token: 0x0400F69D RID: 63133
			public OfferViewList offerViewList_0;

			// Token: 0x0400F69E RID: 63134
			public GClass3354 originalNodes;

			// Token: 0x0400F69F RID: 63135
			public Func<GClass2884, bool> func_0;
		}

		// Token: 0x02002FA5 RID: 12197
		[CompilerGenerated]
		[Serializable]
		private sealed class Class3042
		{
			// Token: 0x0600F0D1 RID: 61649 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Enum method_0(GClass3196 offerData)
			{
				throw null;
			}

			// Token: 0x0600F0D2 RID: 61650 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<GClass2884> method_1(GClass2884 child)
			{
				throw null;
			}

			// Token: 0x0600F0D3 RID: 61651 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_2(KeyValuePair<string, GClass2884> x)
			{
				throw null;
			}

			// Token: 0x0600F0D4 RID: 61652 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_3(KeyValuePair<string, GClass2884> x)
			{
				throw null;
			}

			// Token: 0x0600F0D5 RID: 61653 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_4(KeyValuePair<string, GClass2884> x)
			{
				throw null;
			}

			// Token: 0x0400F6A0 RID: 63136
			public static readonly OfferViewList.Class3042 class3042_0;

			// Token: 0x0400F6A1 RID: 63137
			public static LightScroller.GDelegate76<GClass3196, Enum> gdelegate76_0;

			// Token: 0x0400F6A2 RID: 63138
			public static Func<GClass2884, IEnumerable<GClass2884>> func_0;

			// Token: 0x0400F6A3 RID: 63139
			public static Func<KeyValuePair<string, GClass2884>, int> func_1;

			// Token: 0x0400F6A4 RID: 63140
			public static Func<KeyValuePair<string, GClass2884>, string> func_2;

			// Token: 0x0400F6A5 RID: 63141
			public static Func<KeyValuePair<string, GClass2884>, bool> func_3;
		}
	}
}
