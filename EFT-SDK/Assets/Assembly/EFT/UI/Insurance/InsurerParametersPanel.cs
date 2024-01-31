using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI.Insurance
{
	// Token: 0x02002ED4 RID: 11988
	public sealed class InsurerParametersPanel : UIElement
	{
		// Token: 0x1400034D RID: 845
		// (add) Token: 0x0600EC9A RID: 60570 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600EC9B RID: 60571 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<bool> OnInsuranceAvailableChanged
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

		// Token: 0x170028A6 RID: 10406
		// (get) Token: 0x0600EC9C RID: 60572 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600EC9D RID: 60573 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
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

		// Token: 0x170028A7 RID: 10407
		// (get) Token: 0x0600EC9E RID: 60574 RVA: 0x00002050 File Offset: 0x00000250
		private Dictionary<Item, LocationInGrid>.KeyCollection KeyCollection_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170028A8 RID: 10408
		// (get) Token: 0x0600EC9F RID: 60575 RVA: 0x00002050 File Offset: 0x00000250
		private BackendConfigSettingsClass.TraderInsurance TraderInsurance_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600ECA0 RID: 60576 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Awake()
		{
			throw null;
		}

		// Token: 0x0600ECA1 RID: 60577 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x0600ECA2 RID: 60578 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Inventory inventory, InsuranceCompanyClass insurance, Action updateItemsPrices, SkillManager skills)
		{
			throw null;
		}

		// Token: 0x0600ECA3 RID: 60579 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateInsureButtonStatus(InsuranceCompanyClass.EInsuranceError? error)
		{
			throw null;
		}

		// Token: 0x0600ECA4 RID: 60580 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(int index)
		{
			throw null;
		}

		// Token: 0x0600ECA5 RID: 60581 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateLabels(int moneyToPay, bool updateMoneyToPay = true, bool updateMoneySums = true)
		{
			throw null;
		}

		// Token: 0x0600ECA6 RID: 60582 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string method_1(int start, int end)
		{
			throw null;
		}

		// Token: 0x0600ECA7 RID: 60583 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600ECA8 RID: 60584 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(PointerEventData arg)
		{
			throw null;
		}

		// Token: 0x0600ECA9 RID: 60585 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(PointerEventData arg)
		{
			throw null;
		}

		// Token: 0x0600ECAA RID: 60586 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private TradeItemType method_4(EItemType arg)
		{
			throw null;
		}

		// Token: 0x0600ECAB RID: 60587 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Transform method_5(EItemType arg)
		{
			throw null;
		}

		// Token: 0x0400F188 RID: 61832
		public const string NO_SELECTED_ITEMS = "Trading/NoSelectedItems";

		// Token: 0x0400F189 RID: 61833
		[CompilerGenerated]
		private Action<bool> action_0;

		// Token: 0x0400F18A RID: 61834
		[SerializeField]
		private DropDownBox _tradersDropDown;

		// Token: 0x0400F18B RID: 61835
		[SerializeField]
		private RankPanel _rankPanel;

		// Token: 0x0400F18C RID: 61836
		[SerializeField]
		private Image _avatar;

		// Token: 0x0400F18D RID: 61837
		[SerializeField]
		private TextMeshProUGUI _minPayment;

		// Token: 0x0400F18E RID: 61838
		[SerializeField]
		private TextMeshProUGUI _returnRate;

		// Token: 0x0400F18F RID: 61839
		[SerializeField]
		private TextMeshProUGUI _repairerStanding;

		// Token: 0x0400F190 RID: 61840
		[SerializeField]
		private DefaultUIButton _insureButton;

		// Token: 0x0400F191 RID: 61841
		[SerializeField]
		private TextMeshProUGUI _returnTime;

		// Token: 0x0400F192 RID: 61842
		[SerializeField]
		private TextMeshProUGUI _cashInStash;

		// Token: 0x0400F193 RID: 61843
		[SerializeField]
		private TextMeshProUGUI _sumToPay;

		// Token: 0x0400F194 RID: 61844
		[SerializeField]
		private TradeItemType _sellTypeTemplate;

		// Token: 0x0400F195 RID: 61845
		[SerializeField]
		private RectTransform _sellTypesContainer;

		// Token: 0x0400F196 RID: 61846
		[SerializeField]
		private Color _criticalColor;

		// Token: 0x0400F197 RID: 61847
		[SerializeField]
		private Color _defaultColor;

		// Token: 0x0400F198 RID: 61848
		private Inventory inventory_0;

		// Token: 0x0400F199 RID: 61849
		private SkillManager skillManager_0;

		// Token: 0x0400F19A RID: 61850
		private GClass3078<EItemType, TradeItemType> gclass3078_0;

		// Token: 0x0400F19B RID: 61851
		private InsuranceCompanyClass gclass3179_0;

		// Token: 0x0400F19C RID: 61852
		private Action action_1;

		// Token: 0x0400F19D RID: 61853
		private Action action_2;

		// Token: 0x0400F19E RID: 61854
		private Action action_3;

		// Token: 0x0400F19F RID: 61855
		private int int_0;

		// Token: 0x0400F1A0 RID: 61856
		private int int_1;

		// Token: 0x0400F1A1 RID: 61857
		private Dictionary<ECurrencyType, int> dictionary_0;

		// Token: 0x0400F1A2 RID: 61858
		private int int_2;

		// Token: 0x0400F1A3 RID: 61859
		private bool bool_0;

		// Token: 0x0400F1A4 RID: 61860
		private double double_0;

		// Token: 0x0400F1A5 RID: 61861
		private List<TraderClass> list_0;

		// Token: 0x0400F1A6 RID: 61862
		private List<string> list_1;

		// Token: 0x0400F1A7 RID: 61863
		private GClass763 gclass763_0;

		// Token: 0x0400F1A8 RID: 61864
		private MultiLineTooltip multiLineTooltip_0;

		// Token: 0x0400F1A9 RID: 61865
		private GClass3093 gclass3093_0;

		// Token: 0x02002ED5 RID: 11989
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2949
		{
			// Token: 0x0600ECAC RID: 60588 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0(TraderClass trader)
			{
				throw null;
			}

			// Token: 0x0600ECAD RID: 60589 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_1(TraderClass trader)
			{
				throw null;
			}

			// Token: 0x0600ECAE RID: 60590 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal EItemType method_2(string x)
			{
				throw null;
			}

			// Token: 0x0600ECAF RID: 60591 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_3(EItemType itemType, TradeItemType itemTypeView)
			{
				throw null;
			}

			// Token: 0x0400F1AA RID: 61866
			public static readonly InsurerParametersPanel.Class2949 class2949_0;

			// Token: 0x0400F1AB RID: 61867
			public static Func<TraderClass, string> func_0;

			// Token: 0x0400F1AC RID: 61868
			public static Func<TraderClass, string> func_1;

			// Token: 0x0400F1AD RID: 61869
			public static Func<string, EItemType> func_2;

			// Token: 0x0400F1AE RID: 61870
			public static Action<EItemType, TradeItemType> action_0;
		}
	}
}
