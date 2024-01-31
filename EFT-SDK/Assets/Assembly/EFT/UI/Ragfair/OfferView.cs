using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ChatShared;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI.Ragfair
{
	// Token: 0x02002FA0 RID: 12192
	public sealed class OfferView : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
	{
		// Token: 0x1700293A RID: 10554
		// (get) Token: 0x0600F078 RID: 61560 RVA: 0x00002050 File Offset: 0x00000250
		private static Color32 Color32_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700293B RID: 10555
		// (get) Token: 0x0600F079 RID: 61561 RVA: 0x00002050 File Offset: 0x00000250
		private static Color32 Color32_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700293C RID: 10556
		// (get) Token: 0x0600F07A RID: 61562 RVA: 0x00002050 File Offset: 0x00000250
		private static Color32 Color32_2
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700293D RID: 10557
		// (get) Token: 0x0600F07B RID: 61563 RVA: 0x00002050 File Offset: 0x00000250
		private static Color32 Color32_3
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700293E RID: 10558
		// (get) Token: 0x0600F07C RID: 61564 RVA: 0x00002050 File Offset: 0x00000250
		private static Color32 Color32_4
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700293F RID: 10559
		// (get) Token: 0x0600F07D RID: 61565 RVA: 0x00002050 File Offset: 0x00000250
		private static Color32 Color32_5
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002940 RID: 10560
		// (get) Token: 0x0600F07E RID: 61566 RVA: 0x00002050 File Offset: 0x00000250
		private static Color32 Color32_6
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002941 RID: 10561
		// (get) Token: 0x0600F07F RID: 61567 RVA: 0x00002050 File Offset: 0x00000250
		private static Color32 Color32_7
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002942 RID: 10562
		// (get) Token: 0x0600F080 RID: 61568 RVA: 0x00002050 File Offset: 0x00000250
		private static Color32 Color32_8
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002943 RID: 10563
		// (get) Token: 0x0600F081 RID: 61569 RVA: 0x00002050 File Offset: 0x00000250
		private TimeSpan TimeSpan_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002944 RID: 10564
		// (get) Token: 0x0600F082 RID: 61570 RVA: 0x00002050 File Offset: 0x00000250
		private TimeSpan TimeSpan_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002945 RID: 10565
		// (get) Token: 0x0600F083 RID: 61571 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002946 RID: 10566
		// (get) Token: 0x0600F084 RID: 61572 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F085 RID: 61573 RVA: 0x00002050 File Offset: 0x00000250
		private Offer Offer_0
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

		// Token: 0x17002947 RID: 10567
		// (get) Token: 0x0600F086 RID: 61574 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F087 RID: 61575 RVA: 0x00002050 File Offset: 0x00000250
		private GClass3197 GClass3197_0
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

		// Token: 0x17002948 RID: 10568
		// (get) Token: 0x0600F088 RID: 61576 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002949 RID: 10569
		// (get) Token: 0x0600F089 RID: 61577 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_2
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700294A RID: 10570
		// (get) Token: 0x0600F08A RID: 61578 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_3
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600F08B RID: 61579 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600F08C RID: 61580 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(EViewListType viewType, GClass3197 data)
		{
			throw null;
		}

		// Token: 0x0600F08D RID: 61581 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600F08E RID: 61582 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600F08F RID: 61583 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600F090 RID: 61584 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(Offer offer, bool value)
		{
			throw null;
		}

		// Token: 0x0600F091 RID: 61585 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(Offer offer, int count, string handbookId)
		{
			throw null;
		}

		// Token: 0x0600F092 RID: 61586 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(IEnumerable<string> offerIds, bool finished)
		{
			throw null;
		}

		// Token: 0x0600F093 RID: 61587 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600F094 RID: 61588 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x0600F095 RID: 61589 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600F096 RID: 61590 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x0600F097 RID: 61591 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x0600F098 RID: 61592 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_10()
		{
			throw null;
		}

		// Token: 0x0600F099 RID: 61593 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11(bool expanded)
		{
			throw null;
		}

		// Token: 0x0600F09A RID: 61594 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12()
		{
			throw null;
		}

		// Token: 0x0600F09B RID: 61595 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600F09C RID: 61596 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600F09D RID: 61597 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13(bool hovered, bool bordered)
		{
			throw null;
		}

		// Token: 0x0600F09E RID: 61598 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_14(Image image, bool hovered)
		{
			throw null;
		}

		// Token: 0x0600F09F RID: 61599 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick([CanBeNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600F0A0 RID: 61600 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600F0A1 RID: 61601 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_15(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600F0A2 RID: 61602 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_16(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600F0A3 RID: 61603 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_17()
		{
			throw null;
		}

		// Token: 0x0600F0A4 RID: 61604 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_18()
		{
			throw null;
		}

		// Token: 0x0600F0A5 RID: 61605 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_19()
		{
			throw null;
		}

		// Token: 0x0600F0A6 RID: 61606 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_20()
		{
			throw null;
		}

		// Token: 0x0400F62A RID: 63018
		private const int int_0 = 85;

		// Token: 0x0400F62B RID: 63019
		[SerializeField]
		private GameObject _checkboxPanel;

		// Token: 0x0400F62C RID: 63020
		[SerializeField]
		private GameObject _selectedMark;

		// Token: 0x0400F62D RID: 63021
		[SerializeField]
		private Image _minimizeButton;

		// Token: 0x0400F62E RID: 63022
		[SerializeField]
		private Sprite _minimizedSprite;

		// Token: 0x0400F62F RID: 63023
		[SerializeField]
		private Sprite _expandedSprite;

		// Token: 0x0400F630 RID: 63024
		[SerializeField]
		private GameObject _buttonsContainer;

		// Token: 0x0400F631 RID: 63025
		[SerializeField]
		private DefaultUIButton _purchaseButton;

		// Token: 0x0400F632 RID: 63026
		[SerializeField]
		private DefaultUIButton _removeButton;

		// Token: 0x0400F633 RID: 63027
		[SerializeField]
		private TextMeshProUGUI _offerId;

		// Token: 0x0400F634 RID: 63028
		[SerializeField]
		private GameObject _exchangeOffer;

		// Token: 0x0400F635 RID: 63029
		[SerializeField]
		private MerchantInfoView _merchantInfoView;

		// Token: 0x0400F636 RID: 63030
		[SerializeField]
		private CanvasGroup _merchantCanvasGroup;

		// Token: 0x0400F637 RID: 63031
		[SerializeField]
		private OfferItemDescription _descriptionShrunk;

		// Token: 0x0400F638 RID: 63032
		[SerializeField]
		private OfferItemDescription _descriptionExpanded;

		// Token: 0x0400F639 RID: 63033
		[SerializeField]
		private OfferItemPrice _priceShrunk;

		// Token: 0x0400F63A RID: 63034
		[SerializeField]
		private OfferItemPrice _priceExpanded;

		// Token: 0x0400F63B RID: 63035
		[SerializeField]
		private GameObject _lockedButton;

		// Token: 0x0400F63C RID: 63036
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0400F63D RID: 63037
		[SerializeField]
		private HoverTooltipAreaClick _hoverTooltipArea;

		// Token: 0x0400F63E RID: 63038
		[SerializeField]
		private Button _renewButton;

		// Token: 0x0400F63F RID: 63039
		[SerializeField]
		private Image _disabledPanel;

		// Token: 0x0400F640 RID: 63040
		[SerializeField]
		private Image _selectedBackground;

		// Token: 0x0400F641 RID: 63041
		[SerializeField]
		private GameObject _notAvailableButton;

		// Token: 0x0400F642 RID: 63042
		[SerializeField]
		private GameObject _outOfStockButton;

		// Token: 0x0400F643 RID: 63043
		[SerializeField]
		private GameObject _expirationTimePanel;

		// Token: 0x0400F644 RID: 63044
		[SerializeField]
		private TextMeshProUGUI _expirationLabel;

		// Token: 0x0400F645 RID: 63045
		[SerializeField]
		private TextMeshProUGUI _createdTimeLabel;

		// Token: 0x0400F646 RID: 63046
		[SerializeField]
		private GameObject _availableTimePanel;

		// Token: 0x0400F647 RID: 63047
		[SerializeField]
		private TextMeshProUGUI _availableTimeLabel;

		// Token: 0x0400F648 RID: 63048
		[SerializeField]
		private GameObject _loader;

		// Token: 0x0400F649 RID: 63049
		[SerializeField]
		private Image[] _backgroundImages;

		// Token: 0x0400F64A RID: 63050
		[SerializeField]
		private Image _timeLeftImage;

		// Token: 0x0400F64B RID: 63051
		[SerializeField]
		private Image _borderImage;

		// Token: 0x0400F64C RID: 63052
		[SerializeField]
		private Image _backgroundIdImage;

		// Token: 0x0400F64D RID: 63053
		[SerializeField]
		private Sprite _myIdSprite;

		// Token: 0x0400F64E RID: 63054
		[SerializeField]
		private Sprite _traderIdSprite;

		// Token: 0x0400F64F RID: 63055
		private readonly Dictionary<Image, Color32> dictionary_0;

		// Token: 0x0400F650 RID: 63056
		private readonly Dictionary<Image, Color32> dictionary_1;

		// Token: 0x0400F651 RID: 63057
		private int int_1;

		// Token: 0x0400F652 RID: 63058
		private EViewListType eviewListType_0;

		// Token: 0x0400F653 RID: 63059
		private GClass2881 gclass2881_0;

		// Token: 0x0400F654 RID: 63060
		private string string_0;

		// Token: 0x0400F655 RID: 63061
		private Profile.TraderInfo traderInfo_0;

		// Token: 0x0400F656 RID: 63062
		private RagFairClass gclass3190_0;

		// Token: 0x0400F657 RID: 63063
		private InventoryControllerClass gclass2757_0;

		// Token: 0x0400F658 RID: 63064
		private InsuranceCompanyClass gclass3179_0;

		// Token: 0x0400F659 RID: 63065
		private ItemUiContext itemUiContext_0;

		// Token: 0x0400F65A RID: 63066
		private GClass1839 gclass1839_0;

		// Token: 0x0400F65B RID: 63067
		private Action<Offer, Action> action_0;

		// Token: 0x0400F65C RID: 63068
		private Action<bool, Dictionary<GInterface151, int>> action_1;

		// Token: 0x0400F65D RID: 63069
		private Action<Offer> action_2;

		// Token: 0x0400F65E RID: 63070
		private Action<Offer, Action> action_3;

		// Token: 0x0400F65F RID: 63071
		private Color32 color32_0;

		// Token: 0x0400F660 RID: 63072
		private Color32 color32_1;

		// Token: 0x0400F661 RID: 63073
		private DateTime dateTime_0;

		// Token: 0x0400F662 RID: 63074
		private double double_0;

		// Token: 0x0400F663 RID: 63075
		private bool bool_0;

		// Token: 0x0400F664 RID: 63076
		private bool bool_1;

		// Token: 0x0400F665 RID: 63077
		private bool? nullable_0;

		// Token: 0x0400F666 RID: 63078
		private int int_2;

		// Token: 0x0400F667 RID: 63079
		[CompilerGenerated]
		private Offer offer_0;

		// Token: 0x0400F668 RID: 63080
		[CompilerGenerated]
		private GClass3197 gclass3197_0;

		// Token: 0x02002FA1 RID: 12193
		[CompilerGenerated]
		[Serializable]
		private sealed class Class3040
		{
			// Token: 0x0600F0A7 RID: 61607 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600F0A8 RID: 61608 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal UpdatableChatMember method_1(string id)
			{
				throw null;
			}

			// Token: 0x0400F669 RID: 63081
			public static readonly OfferView.Class3040 class3040_0;

			// Token: 0x0400F66A RID: 63082
			public static Action action_0;

			// Token: 0x0400F66B RID: 63083
			public static Func<string, UpdatableChatMember> func_0;
		}
	}
}
