using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI.Insurance
{
	// Token: 0x02002EDE RID: 11998
	public sealed class ItemToInsurePanel : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
	{
		// Token: 0x170028AD RID: 10413
		// (get) Token: 0x0600ECD5 RID: 60629 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600ECD6 RID: 60630 RVA: 0x00002050 File Offset: 0x00000250
		private ItemClass GClass3180_0
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

		// Token: 0x170028AE RID: 10414
		// (get) Token: 0x0600ECD7 RID: 60631 RVA: 0x00002050 File Offset: 0x00000250
		private InsuranceCompanyClass.GStruct401 GStruct401_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600ECD8 RID: 60632 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600ECD9 RID: 60633 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(ItemClass insuredItem, EItemType itemType, InsuranceCompanyClass insurance, ItemToInsurePanel panelTemplate, ItemsToInsureScreen insureScreen)
		{
			throw null;
		}

		// Token: 0x0600ECDA RID: 60634 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600ECDB RID: 60635 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(bool value)
		{
			throw null;
		}

		// Token: 0x0600ECDC RID: 60636 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600ECDD RID: 60637 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateInsuranceItemsPrices(IEnumerable<ItemClass> items)
		{
			throw null;
		}

		// Token: 0x0600ECDE RID: 60638 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAsChild(ItemToInsurePanel child, int parentsLevel)
		{
			throw null;
		}

		// Token: 0x0600ECDF RID: 60639 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600ECE0 RID: 60640 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(int price, int childPrice)
		{
			throw null;
		}

		// Token: 0x0600ECE1 RID: 60641 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600ECE2 RID: 60642 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600ECE3 RID: 60643 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600ECE4 RID: 60644 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600ECE5 RID: 60645 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(ItemToInsurePanel arg)
		{
			throw null;
		}

		// Token: 0x0600ECE6 RID: 60646 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(ItemClass[] insuredItems)
		{
			throw null;
		}

		// Token: 0x0400F1DB RID: 61915
		[SerializeField]
		private TextMeshProUGUI _itemNameLabel;

		// Token: 0x0400F1DC RID: 61916
		[SerializeField]
		private TextMeshProUGUI _itemPriceLabel;

		// Token: 0x0400F1DD RID: 61917
		[SerializeField]
		private Image _background;

		// Token: 0x0400F1DE RID: 61918
		[SerializeField]
		private Color _defaultColor;

		// Token: 0x0400F1DF RID: 61919
		[SerializeField]
		private Color _selectedColor;

		// Token: 0x0400F1E0 RID: 61920
		[SerializeField]
		private TradeItemType _itemType;

		// Token: 0x0400F1E1 RID: 61921
		[SerializeField]
		private GameObject _childItemSpace;

		// Token: 0x0400F1E2 RID: 61922
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0400F1E3 RID: 61923
		[SerializeField]
		private TextMeshProUGUI _itemsToInsureCount;

		// Token: 0x0400F1E4 RID: 61924
		[SerializeField]
		private InsurerParametersPanel _insurerParametersPanel;

		// Token: 0x0400F1E5 RID: 61925
		[SerializeField]
		private RectTransform _childContainer;

		// Token: 0x0400F1E6 RID: 61926
		[SerializeField]
		private SwitchableParamsButton _dropdownButton;

		// Token: 0x0400F1E7 RID: 61927
		private GClass3079<ItemClass, ItemToInsurePanel> gclass3079_0;

		// Token: 0x0400F1E8 RID: 61928
		private InsuranceCompanyClass gclass3179_0;

		// Token: 0x0400F1E9 RID: 61929
		private bool bool_0;

		// Token: 0x0400F1EA RID: 61930
		[CompilerGenerated]
		private ItemClass gclass3180_0;

		// Token: 0x02002EDF RID: 11999
		[CompilerGenerated]
		private sealed class Class2954
		{
			// Token: 0x0600ECE7 RID: 60647 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(ItemClass child, ItemToInsurePanel view)
			{
				throw null;
			}

			// Token: 0x0400F1EB RID: 61931
			public ItemToInsurePanel itemToInsurePanel_0;

			// Token: 0x0400F1EC RID: 61932
			public ItemToInsurePanel panelTemplate;

			// Token: 0x0400F1ED RID: 61933
			public ItemsToInsureScreen insureScreen;
		}

		// Token: 0x02002EE0 RID: 12000
		[CompilerGenerated]
		private sealed class Class2955
		{
			// Token: 0x0600ECE8 RID: 60648 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_0(ItemClass x)
			{
				throw null;
			}

			// Token: 0x0400F1EE RID: 61934
			public GClass3177 selectedInsurer;
		}
	}
}
