using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002A11 RID: 10769
	public class RepairerParametersPanel : UIElement
	{
		// Token: 0x170025F5 RID: 9717
		// (get) Token: 0x0600D605 RID: 54789 RVA: 0x00002050 File Offset: 0x00000250
		private IEnumerable<Item> IEnumerable_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170025F6 RID: 9718
		// (get) Token: 0x0600D606 RID: 54790 RVA: 0x00002050 File Offset: 0x00000250
		private float Single_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170025F7 RID: 9719
		// (get) Token: 0x0600D607 RID: 54791 RVA: 0x00002050 File Offset: 0x00000250
		public GInterface182 CurrentRepairer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170025F8 RID: 9720
		// (get) Token: 0x0600D608 RID: 54792 RVA: 0x00002050 File Offset: 0x00000250
		public float RepairAmount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600D609 RID: 54793 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600D60A RID: 54794 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		// Token: 0x0600D60B RID: 54795 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GInterface33 repairStrategy, GClass2087 repairController, Item item, Inventory inventory, GClass2726 draggedRepairKit)
		{
			throw null;
		}

		// Token: 0x0600D60C RID: 54796 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ItemAddedHandler(GEventArgs2 eventArgs)
		{
			throw null;
		}

		// Token: 0x0600D60D RID: 54797 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ItemRemovedHandler(GEventArgs3 eventArgs)
		{
			throw null;
		}

		// Token: 0x0600D60E RID: 54798 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateRepairers()
		{
			throw null;
		}

		// Token: 0x0600D60F RID: 54799 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600D610 RID: 54800 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateBuffState()
		{
			throw null;
		}

		// Token: 0x0600D611 RID: 54801 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int method_1(GInterface182 repairer)
		{
			throw null;
		}

		// Token: 0x0600D612 RID: 54802 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(float sliderValue)
		{
			throw null;
		}

		// Token: 0x0600D613 RID: 54803 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static string smethod_0(Vector2 repairDegradation, bool isRepairKit)
		{
			throw null;
		}

		// Token: 0x0600D614 RID: 54804 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(int index)
		{
			throw null;
		}

		// Token: 0x0600D615 RID: 54805 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateRepairKitLabels()
		{
			throw null;
		}

		// Token: 0x0600D616 RID: 54806 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateTraderLabels()
		{
			throw null;
		}

		// Token: 0x0600D617 RID: 54807 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(GClass2726 repairKit)
		{
			throw null;
		}

		// Token: 0x0600D618 RID: 54808 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600D619 RID: 54809 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateConditionSlider()
		{
			throw null;
		}

		// Token: 0x0600D61A RID: 54810 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int method_6(GInterface182 repairer, Item item, float count)
		{
			throw null;
		}

		// Token: 0x0600D61B RID: 54811 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string method_7(double chance)
		{
			throw null;
		}

		// Token: 0x0600D61C RID: 54812 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string method_8(double priceRate)
		{
			throw null;
		}

		// Token: 0x0600D61D RID: 54813 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string method_9(float quality)
		{
			throw null;
		}

		// Token: 0x0600D61E RID: 54814 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10(float arg)
		{
			throw null;
		}

		// Token: 0x0400D841 RID: 55361
		[SerializeField]
		private DropDownBox _tradersDropDown;

		// Token: 0x0400D842 RID: 55362
		[SerializeField]
		private RankPanel _rankPanel;

		// Token: 0x0400D843 RID: 55363
		[SerializeField]
		private Image _avatar;

		// Token: 0x0400D844 RID: 55364
		[SerializeField]
		private GameObject _repairerStandingGameObject;

		// Token: 0x0400D845 RID: 55365
		[SerializeField]
		private TextMeshProUGUI _repairPriceRate;

		// Token: 0x0400D846 RID: 55366
		[SerializeField]
		private TextMeshProUGUI _repairerStanding;

		// Token: 0x0400D847 RID: 55367
		[SerializeField]
		private TextMeshProUGUI _repairSpeed;

		// Token: 0x0400D848 RID: 55368
		[SerializeField]
		private TextMeshProUGUI _repairQuality;

		// Token: 0x0400D849 RID: 55369
		[SerializeField]
		private TextMeshProUGUI _repairability;

		// Token: 0x0400D84A RID: 55370
		[SerializeField]
		private TextMeshProUGUI _enhancementChance;

		// Token: 0x0400D84B RID: 55371
		[SerializeField]
		private RepairWarningStatusPanel _repairWarningStatusPanel;

		// Token: 0x0400D84C RID: 55372
		[SerializeField]
		private ConditionCharacteristicsSlider _conditionSlider;

		// Token: 0x0400D84D RID: 55373
		[SerializeField]
		private TextMeshProUGUI _repairTime;

		// Token: 0x0400D84E RID: 55374
		[SerializeField]
		private TextMeshProUGUI _repairDp;

		// Token: 0x0400D84F RID: 55375
		[SerializeField]
		private LocalizedText _cashInStashLabel;

		// Token: 0x0400D850 RID: 55376
		[SerializeField]
		private TextMeshProUGUI _cashInStash;

		// Token: 0x0400D851 RID: 55377
		[SerializeField]
		private Image _cashInStashIcon;

		// Token: 0x0400D852 RID: 55378
		[SerializeField]
		private Sprite _repairPointsInStashSprite;

		// Token: 0x0400D853 RID: 55379
		[SerializeField]
		private LocalizedText _sumToPayLabel;

		// Token: 0x0400D854 RID: 55380
		[SerializeField]
		private TextMeshProUGUI _sumToPay;

		// Token: 0x0400D855 RID: 55381
		[SerializeField]
		private Image _sumToPayIcon;

		// Token: 0x0400D856 RID: 55382
		[SerializeField]
		private Sprite _repairPointsToPaySprite;

		// Token: 0x0400D857 RID: 55383
		[SerializeField]
		private TextMeshProUGUI _repairKitChargeText;

		// Token: 0x0400D858 RID: 55384
		[SerializeField]
		private Color _criticalColor;

		// Token: 0x0400D859 RID: 55385
		[SerializeField]
		private Color _defaultColor;

		// Token: 0x0400D85A RID: 55386
		private const string string_0 = "<color=#c5c3b4>{0}</color> {1}";

		// Token: 0x0400D85B RID: 55387
		private GClass2087 gclass2087_0;

		// Token: 0x0400D85C RID: 55388
		private GInterface33 ginterface33_0;

		// Token: 0x0400D85D RID: 55389
		private Inventory inventory_0;

		// Token: 0x0400D85E RID: 55390
		private Sprite sprite_0;

		// Token: 0x0400D85F RID: 55391
		private GClass2726 gclass2726_0;

		// Token: 0x0400D860 RID: 55392
		private GClass2726 gclass2726_1;

		// Token: 0x0400D861 RID: 55393
		private GClass763 gclass763_0;

		// Token: 0x0400D862 RID: 55394
		private float float_0;

		// Token: 0x02002A12 RID: 10770
		[CompilerGenerated]
		private sealed class Class2484
		{
			// Token: 0x0600D61F RID: 54815 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400D863 RID: 55395
			public IItemOwner itemOwner;

			// Token: 0x0400D864 RID: 55396
			public RepairerParametersPanel repairerParametersPanel_0;
		}

		// Token: 0x02002A13 RID: 10771
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2485
		{
			// Token: 0x0600D620 RID: 54816 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0(GInterface182 trader)
			{
				throw null;
			}

			// Token: 0x0600D621 RID: 54817 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_1(GInterface182 trader)
			{
				throw null;
			}

			// Token: 0x0400D865 RID: 55397
			public static readonly RepairerParametersPanel.Class2485 class2485_0;

			// Token: 0x0400D866 RID: 55398
			public static Func<GInterface182, string> func_0;

			// Token: 0x0400D867 RID: 55399
			public static Func<GInterface182, string> func_1;
		}
	}
}
